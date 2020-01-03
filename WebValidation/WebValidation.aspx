<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebValidation.aspx.cs" Inherits="WebValidation" UnobtrusiveValidationMode="None"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demonstrating Validation Controls</title>
    <style type="text/css">
        .auto-style1 {
            width: 59%;
        }
        .newStyle1 {
            font-weight: bold;
        }
        .auto-style2 {
            width: 61px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Please fill out all the fields in the following form:</h3>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" CssClass="newStyle1" Text="Name"></asp:Label>
                    :</td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server" Width="223px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="nameRequiredFieldValidator" runat="server" ControlToValidate="nameTextBox" Display="Dynamic" ErrorMessage="Please enter your name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" CssClass="newStyle1" Text="E-mail"></asp:Label>
                    :</td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server" Width="223px"></asp:TextBox>
&nbsp;e.g., <a href="mailto:email@domain.com">email@domain.com</a><br />
                    <asp:RequiredFieldValidator ID="emailRequiredFieldValidator0" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="Please enter your email address" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Please enter an e-mail address in a valid format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" CssClass="newStyle1" Text="Phone"></asp:Label>
                    :</td>
                <td>
                    <asp:TextBox ID="phoneTextBox" runat="server" Width="223px"></asp:TextBox>
&nbsp;e.g., (555) 555-1234<br />
                    <asp:RequiredFieldValidator ID="phoneRequiredFieldValidator0" runat="server" ControlToValidate="phoneTextBox" Display="Dynamic" ErrorMessage="Please enter your phone" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="phoneRegularExpressionValidator0" runat="server" ControlToValidate="phoneTextBox" ErrorMessage="Please enter a phone  in a valid format" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <asp:Button ID="submitButton" runat="server" Text="Submit" />
        <br />
        <asp:Label ID="outputLabel" runat="server" Visible="False"></asp:Label>
    </form>
</body>
</html>
