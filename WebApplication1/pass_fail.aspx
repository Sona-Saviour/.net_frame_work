<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pass_fail.aspx.cs" Inherits="WebApplication1.pass_fail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:Label ID="Name" runat="server" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="n" runat="server"></asp:TextBox>
        </p>
        <p>
            Marks:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="m" runat="server" Type="number"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="s" runat="server" Text="status"></asp:Label>
        </p>
        <div style="margin-left: 80px">
            <asp:Button ID="btnpf" runat="server" OnClick="btnpf_Click" Text="pass/fail" />
        </div>
    </form>
</body>
</html>
