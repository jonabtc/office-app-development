<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Pais:
        <asp:TextBox ID="PaisTextBox" runat="server"></asp:TextBox>
        <br />
        Ciudad:
        <asp:TextBox ID="CiudadTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get XML" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get Datos" />
&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Get From URL" />
        <br />
        <asp:TextBox ID="ResultadosTextBox" runat="server" Height="229px" ReadOnly="True" TextMode="MultiLine" Width="375px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
