<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="WebApplication1.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Marksheet:</p>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="name" runat="server" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="t1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Physics:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="phy" runat="server"></asp:TextBox>
            <br />
        </p>
        <p>
            Maths:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mat" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            English:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="eng" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="res" runat="server" Text="result"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:Button ID="sa" runat="server" OnClick="sa_Click" Text="Sum &amp; Average" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
