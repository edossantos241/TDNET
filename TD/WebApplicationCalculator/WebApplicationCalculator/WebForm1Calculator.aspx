<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1Calculator.aspx.cs" Inherits="WebApplicationCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <div style="height: 353px">
                    <asp:Label ID="Label4" runat="server" Text="Operation type :"></asp:Label>
                    <br />
                    <asp:RadioButton ID="Add" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Add" />
                    <br />
                    <asp:RadioButton ID="Divide" runat="server" Text="Divide" />
                    <br />
                    <asp:RadioButton ID="Multiply" runat="server" Text="Multiply" />
                    <br />
                    <asp:RadioButton ID="Substract" runat="server" Text="Substract" />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Int 1 :"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Number"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Int 2 :"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="Button1_Click" Text="Get result" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Add result :"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
