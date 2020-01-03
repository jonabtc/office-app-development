<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebControls.aspx.cs" Inherits="WebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Controls Demonstration</title>
    <style type="text/css">
        .auto-style1 {
            width: 51%;
        }
        .labelStyle {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Registration Form</h3>
        <p>
            Please fill in all fields and click the Register button</p>
        <p>
            <asp:Image ID="userInformationImage" runat="server" Height="32px" ImageUrl="~/imagenes/sign_up-512.png" Width="54px" />
        </p>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" CssClass="labelStyle" Text="First Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="358px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" CssClass="labelStyle" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="357px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <br />
        <asp:Label ID="Label3" runat="server" CssClass="labelStyle" Text="What course would you like information about?"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>PHP</asp:ListItem>
            <asp:ListItem>HTML</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.google.com" Target="_blank">Click here to view more information about our courses</asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" CssClass="labelStyle" Text="Operating System"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Windows</asp:ListItem>
            <asp:ListItem>Linux</asp:ListItem>
            <asp:ListItem>MAC</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="Register" />
    </form>
</body>
</html>
