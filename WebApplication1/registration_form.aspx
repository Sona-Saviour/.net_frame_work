<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration_form.aspx.cs" Inherits="WebApplication1.registration_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 120px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registration form<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" placeholder="enter your name"></asp:TextBox>
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Address:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" placeholder="enter your address"></asp:TextBox>
            <br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Mobile Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" placeholder="enter contact number"></asp:TextBox>
            <br />
&nbsp;<asp:Label ID="Label4" runat="server" Text="Employee code:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" placeholder="enter employee code"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;<asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" placeholder="enter password"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnsave" runat="server" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnreset" runat="server" OnClick="btnreset_Click" style="height: 35px" Text="Reset" />
&nbsp;
        </div>
    </form>
</body>
</html>
