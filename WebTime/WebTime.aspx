<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebTime.aspx.cs" Inherits="WebTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Web For Example</title>
    <style type="text/css">
        .timeStyle {
            color: #FFFF00;
            background-color: #000000;
            font-weight: bold;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Current time on the Web server:</h2>
        <p>
            <asp:Label ID="timeLabel" runat="server" CssClass="timeStyle"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
