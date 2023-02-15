<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reviewpage1.aspx.cs" Inherits="reviewpage1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style3
        {
            width: 922px;
        }
        .style7
        {
            height: 667px;
            width: 1324px;
        }
        .style8
        {
            width: 277px;
        }
        .style9
        {
            width: 277px;
            height: 127px;
        }
        .style10
        {
            width: 922px;
            height: 176px;
        }
        .style11
        {
            width: 922px;
            height: 127px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="left" 
        
        style="background-image: url('img/review.jpg'); height: 880px; width: 1545px;">
    
    <table class="style7">
        <tr>
            <td class="style8">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Name" Font-Bold="True" 
                    Font-Size="X-Large" ForeColor="White"></asp:Label>
            </td>
            <td align="left" class="style3">
                <asp:TextBox ID="TextBox2" runat="server" Height="46px" Width="290px" 
                    BorderColor="#333333"></asp:TextBox>
            </td>
        </tr>
       
        <tr>
            <td class="style8">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="Label5" runat="server" 
                    Font-Bold="True" Font-Size="X-Large" 
                    ForeColor="White" Text="Types_of_rating"></asp:Label>
            </td>
            <td align="left" class="style3">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="46px" Width="290px">
                    <asp:ListItem>Website</asp:ListItem>
                    <asp:ListItem>Hotel</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Star" Font-Bold="True" 
                    Font-Size="X-Large" ForeColor="White"></asp:Label>
&nbsp;</td>
            <td align="left" class="style11">
&nbsp;&nbsp;
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
                    ImageUrl="~/img/blankStar.png" onclick="ImageButton1_Click" Width="50px" />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" 
                    ImageUrl="~/img/blankStar.png" onclick="ImageButton2_Click" Width="50px" />
                <asp:ImageButton ID="ImageButton3" runat="server" Height="50px" 
                    ImageUrl="~/img/blankStar.png" onclick="ImageButton3_Click" Width="50px" />
                <asp:ImageButton ID="ImageButton4" runat="server" Height="50px" 
                    ImageUrl="~/img/blankStar.png" onclick="ImageButton4_Click" Width="50px" />
                <asp:ImageButton ID="ImageButton5" runat="server" Height="50px" 
                    ImageUrl="~/img/blankStar.png" onclick="ImageButton5_Click" Width="50px" />
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Comment" Font-Bold="True" 
                    Font-Size="X-Large" ForeColor="White"></asp:Label>
&nbsp;</td>
            <td align="left" class="style3">
                <asp:TextBox ID="TextBox1" runat="server" Height="78px" Width="492px" 
                    BorderColor="#333333"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#999999" 
                    BorderColor="#333333" Font-Bold="True" Font-Size="Medium" Height="47px" 
                    Width="157px" onclick="Button1_Click" ForeColor="Black" />
            </td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
