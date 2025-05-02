<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list_example.aspx.cs" Inherits="WebApplication1.list_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="ListBox"></asp:Label>
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Value="-1">list</asp:ListItem>
                <asp:ListItem Value="1">One</asp:ListItem>
                <asp:ListItem Value="2">two</asp:ListItem>
                <asp:ListItem Value="3">three</asp:ListItem>
                <asp:ListItem Value="4">four</asp:ListItem>
                <asp:ListItem Value="5">five</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <br />
            <asp:BulletedList ID="BulletedList1" runat="server" Width="845px">
                <asp:ListItem Value="1">A</asp:ListItem>
                <asp:ListItem Value="2">B</asp:ListItem>
                <asp:ListItem Value="3">C</asp:ListItem>
                <asp:ListItem Value="4">D</asp:ListItem>
                <asp:ListItem Value="5">E</asp:ListItem>
                <asp:ListItem Value="6">F</asp:ListItem>
            </asp:BulletedList>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
