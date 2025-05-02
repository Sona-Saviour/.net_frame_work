<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bmi.aspx.cs" Inherits="WebApplication1.bmi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            BMI Calculator<br />
            <br />
            <asp:Label ID="w" runat="server" Text="Weight:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="weight" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="h" runat="server" Text="Height:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="height" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="bm" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="b" runat="server" OnClick="b_Click" Text="BMI" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
