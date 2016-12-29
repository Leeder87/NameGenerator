using MySql.Data.MySqlClient;
using System;

namespace NameGenerator
{
    public partial class NameSelectorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Request.QueryString["q"] + " " + Request.QueryString["asd"];
            SetOptions.Visible = false;
            RefreshNameTable();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            RefreshNameTable();
        }

        private void RefreshNameTable()
        {
            DisplayResults.Visible = true;
            MySQLConn connection = new MySQLConn();
            connection.OpenConnection();
            try
            {
                string command = "SELECT * FROM log order by id desc limit 1000";
                MySqlCommand sqlCom = new MySqlCommand(command, MySQLConn.conn);

                MySqlDataReader reader = sqlCom.ExecuteReader();
                grid.DataSource = reader;
                grid.DataBind();
                reader.Close();
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}