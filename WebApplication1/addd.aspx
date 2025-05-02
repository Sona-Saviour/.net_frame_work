<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addd.aspx.cs" Inherits="WebApplication1.addd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Number1: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Text1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Number2:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="result" runat="server" Text="lblsum"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;
            <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add" />
&nbsp;&nbsp;
            <asp:Button ID="btnsub" runat="server" OnClick="Button1_Click" Text="sub" />
&nbsp;
            <asp:Button ID="btnmul" runat="server" OnClick="btnmul_Click" Text="mul" />
&nbsp;
            <asp:Button ID="btndiv" runat="server" OnClick="btndiv_Click" Text="div" />
&nbsp;
            <asp:Button ID="btnreset" runat="server" OnClick="btnreset_Click" Text="Reset" />
            <br />
&nbsp;<br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
