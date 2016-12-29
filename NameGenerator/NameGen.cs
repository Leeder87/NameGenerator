using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;

namespace NameGenerator
{
    public class NameGen
    {
        private string Type { get; set; }
        public int NumFam { get; private set; }
        public int NumName { get; private set; }
        private string command;
        public string Rus { get; private set; }
        public string Eng { get; private set; }
        private int Count { get; set; }
        private string Table { get; set; }

        public NameGen(string type, int numFam, int numName)
        {
            this.Type = type;
            this.NumFam = numFam;
            this.NumName = numName;
        }

        public void GenerateName()
        {
            if (NumFam == 0)
            {
                int numNumFam = Random(10);
                if (numNumFam < 8)
                    NumFam = 1;
                else
                    NumFam = 2;
            }
            if (NumName == 0)
            {
                int numNumName = Random(10);
                if (numNumName < 8)
                    NumName = 1;
                else
                    NumName = 2;
            }

            switch (Type)
            {
                case "chi":
                    Count = GetCountOf("chinese");
                    Table = "chinese";
                    break;

                case "can":
                    Count = GetCountOf("cantonese");
                    Table = "cantonese";
                    break;

                case "random":
                    int temp;
                    temp = Random(10);
                    if (temp < 7)
                    {
                        Count = GetCountOf("chinese");
                        Table = "chinese";
                    }
                    else
                    {
                        Count = GetCountOf("cantonese");
                        Table = "cantonese";
                    }
                    break;
            }

        }

        private static int Random(int num)
        {
            RNGCryptoServiceProvider random = new RNGCryptoServiceProvider("testo");
            byte[] randomBytes = new byte[1024 * sizeof(int)];
            random.GetBytes(randomBytes);
            int val = BitConverter.ToInt32(randomBytes, 4);
            val &= 0x7fffffff;
            val = val % num + 1;
            return val;
        }

        private int GetCountOf(string table)
        {
            long ret = 0;
            MySQLConn connection = new MySQLConn();
            connection.OpenConnection();
            try
            {
                string command = "select count(*) from " + table;
                MySqlCommand sqlCom = new MySqlCommand(command, MySQLConn.conn);
                ret = (long)sqlCom.ExecuteScalar();
            }
            finally
            {
                connection.CloseConnection();
            }
            return int.Parse(ret.ToString());
        }

        public void GetName()
        {
            int rowNum = Random(Count);
            command = "select " + Table + ", russian from " + Table + " where id = " + rowNum.ToString();

            MySQLConn connection = new MySQLConn();
            connection.OpenConnection();
            try
            {
                MySqlCommand sqlCom = new MySqlCommand(command, MySQLConn.conn);

                using (var reader = sqlCom.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Eng = reader[0].ToString();
                        Rus = reader[1].ToString();
                    }
                    else
                    {
                        Eng = "Achtung!";
                        Rus = "Achtung!";
                    }
                }
            }
            finally
            {
                connection.CloseConnection();
            }

            if (Eng == "Achtung!" || Rus == "Achtung!")
                GetName();
        }
    }
}