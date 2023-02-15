using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;


public partial class reviewpage1 : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Project\majorproject.mdb");
 
   static String star = "0";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton1.ImageUrl = "~//img//filedStar.png";
        ImageButton2.ImageUrl = "~//img//blankStar.png";
        ImageButton3.ImageUrl = "~//img//blankStar.png";
        ImageButton4.ImageUrl = "~//img//blankStar.png";
        ImageButton5.ImageUrl = "~//img//blankStar.png";
        star = "1";
        
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton1.ImageUrl = "~//img//filedStar.png";
        ImageButton2.ImageUrl = "~//img//filedStar.png";
        ImageButton3.ImageUrl = "~//img//blankStar.png";
        ImageButton4.ImageUrl = "~//img//blankStar.png";
        ImageButton5.ImageUrl = "~//img//blankStar.png";
        star = "2";
        
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton1.ImageUrl = "~//img//filedStar.png";
        ImageButton2.ImageUrl = "~//img//filedStar.png";
        ImageButton3.ImageUrl = "~//img//filedStar.png";
        ImageButton4.ImageUrl = "~//img//blankStar.png";
        ImageButton5.ImageUrl = "~//img//blankStar.png";
        star = "3";
        
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton1.ImageUrl = "~//img//filedStar.png";
        ImageButton2.ImageUrl = "~//img//filedStar.png";
        ImageButton3.ImageUrl = "~//img//filedStar.png";
        ImageButton4.ImageUrl = "~//img//filedStar.png";
        ImageButton5.ImageUrl = "~//img//blankStar.png";
        star = "4";
        
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton1.ImageUrl = "~//img//filedStar.png";
        ImageButton2.ImageUrl = "~//img//filedStar.png";
        ImageButton3.ImageUrl = "~//img//filedStar.png";
        ImageButton4.ImageUrl = "~//img//filedStar.png";
        ImageButton5.ImageUrl = "~//img//filedStar.png";
        star = "5";
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        OleDbCommand cmd = con.CreateCommand();
        cmd.CommandText = "Insert into review values('"
        + TextBox2.Text + "','"
       + DropDownList1.Text + "','"
        + star + "','"
        + TextBox1.Text + "')";
        cmd.ExecuteNonQuery();
        con.Close();

    }
}