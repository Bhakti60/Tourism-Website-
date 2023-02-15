using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

using System.Net.Mail;


public partial class forgetpassword : System.Web.UI.Page
{
    string PASS;
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Project\majorproject.mdb");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        String query = "select * from registration where E_MAIL = '"
                            + TextBox1.Text + "'";
        OleDbCommand cmd = new OleDbCommand(query, con);
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
           PASS = dr["PASSWORD"].ToString();
           
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('RECORD FOUND......');", true);

            // SEND PASS TO MAIL
            MailMessage mail = new MailMessage();
            mail.To.Add(TextBox1.Text + ""); // use ur email id for demo
            // mail.CC.Add("pranavwankhede5@gmail.com");
            mail.CC.Add("rutajdamodare@gmail.com");

            mail.From = new MailAddress("bhaktimejari22@gmail.com");
            mail.Subject = "OPT - travel System!";
            string Body = "Your PASS is : " + PASS + "\nDo not Share with Other!";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("bhaktimejari22@gmail.com", "bhakti mejari22");

            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
        else
        {
            TextBox1.Text = "";
         //   TextBox2.Text = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('NO RECORD FOUND......');", true);
        }
        con.Close();
    }
}