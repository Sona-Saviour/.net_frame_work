<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="radiobutton.aspx.cs" Inherits="WebApplication1.radiobutton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <br />
        <asp:RadioButton ID="rbtmale" runat="server" BorderColor="White" GroupName="gender" Text="Male" />
        <br />
        <br />
        <br />
        <asp:RadioButton ID="rbtfemale" runat="server" GroupName="gender" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Female" />
        <br />
        <br />
        <br />
        <asp:RadioButton ID="rbtothers" runat="server" BackColor="White" GroupName="gender" Text="Others" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="select" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
