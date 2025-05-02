<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="age.aspx.cs" Inherits="WebApplication1.age" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Age:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="a" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="age"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Button ID="btnage" runat="server" OnClick="Button1_Click" Text="Minor/Major" />
        </p>
    </form>
</body>
</html>
