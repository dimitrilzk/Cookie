<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cookie.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            username: <asp:TextBox ID="username" runat="server"></asp:TextBox><br />
            password:<asp:TextBox TextMode="Password" ID="password" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Registrati" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
