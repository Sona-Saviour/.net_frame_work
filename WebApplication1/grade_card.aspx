<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grade_card.aspx.cs" Inherits="WebApplication1.grade_card" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Grade Card</h2>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Student Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="n" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="maths:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="n1" runat="server" OnTextChanged="n0_TextChanged"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="physics:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="n2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="English:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="n3" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text="computer:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="n4" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="c" runat="server" Text="card"></asp:Label>
            </p>
            <p style="margin-left: 160px">
                <asp:Button ID="btng" runat="server" OnClick="btng_Click" Text="view" />
            </p>

        </div>
    </form>
</body>
</html>
