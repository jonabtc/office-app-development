<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Options.aspx.cs" Inherits="Options" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sessions</title>
    <style type="text/css">
        .labelStyle {
            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="promptLabel" runat="server" Text="Select a programming language:" CssClass="labelStyle"></asp:Label>
    
    </div>
        <asp:RadioButtonList ID="languageList" runat="server">
            <asp:ListItem Value="1-2-3-4">Visual Basic</asp:ListItem>
            <asp:ListItem Value="2-3-4-5">Visual C#</asp:ListItem>
            <asp:ListItem Value="3-4-5-6">C++</asp:ListItem>
            <asp:ListItem Value="4-5-6-7">Php</asp:ListItem>
            <asp:ListItem Value="6-7-8-9">Java</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
        <p>
            <asp:Label ID="responseLabel" runat="server" CssClass="labelStyle" Text="Welcome to Sessions!" Visible="False"></asp:Label>
        </p>
        <asp:Label ID="idLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="timeoutLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="languageLink" runat="server" NavigateUrl="~/Options.aspx" Visible="False">Click here to choose another language</asp:HyperLink>
        <br />
        <asp:HyperLink ID="recommendationsLink" runat="server" NavigateUrl="~/Recommendations.aspx" Visible="False">Click here to get book recommendations</asp:HyperLink>
    </form>
</body>
</html>
