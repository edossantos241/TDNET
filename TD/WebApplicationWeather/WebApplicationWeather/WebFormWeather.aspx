<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormWeather.aspx.cs" Inherits="WebApplicationWeather.WebFormWeather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 219px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 175px">
            <asp:Label ID="Label1" runat="server" Text="City:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <br />
            <input id="Text1" type="text" /><br />
            <asp:Label ID="Label2" runat="server" Text="Country :"></asp:Label>
            <br />
            <input id="Text2" type="text" /><br />
            <asp:Button ID="Button1" runat="server" OnClientClick="Button1_Click" Text="Get weather" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Weather result :"></asp:Label>
        </div>
    </form>
</body>
</html>
