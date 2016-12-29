using System;

namespace NameGenerator
{
    public partial class NameGeneratorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Title = "Name Generator";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NameGen nameGen = new NameGen(lstType.Text, int.Parse(lstFam.Text), int.Parse(lstName.Text));

            nameGen.GenerateName();

            nameGen.GetName();
            txtEng.Text = nameGen.Eng;
            txtRus.Text = nameGen.Rus;
            if (nameGen.NumFam == 2)
            {
                nameGen.GetName();
                txtEng.Text += nameGen.Eng;
                txtRus.Text += nameGen.Rus;
            }

            nameGen.GetName();
            txtEng.Text += " " + nameGen.Eng;
            txtRus.Text += " " + nameGen.Rus;
            if (nameGen.NumName == 2)
            {
                nameGen.GetName();
                txtEng.Text += nameGen.Eng;
                txtRus.Text += nameGen.Rus;
            } 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtEng.Text != "" && txtRus.Text != "")
            {
                string engName = txtEng.Text;
                string rusName = txtRus.Text;
                string comment = txtComment.Text;
                string DoB = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                GeneratedName name = new GeneratedName(engName, rusName, DoB, comment);
                Logger.LogName(name);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("NameSelectorForm.aspx");
        }
    }
}