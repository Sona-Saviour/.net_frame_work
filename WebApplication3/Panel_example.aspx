<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panel_example.aspx.cs" Inherits="WebApplication3.Panel_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Panel ID="Panel1" runat="server" BorderColor="Maroon" BorderStyle="Solid" Height="139px" Width="976px">
                &nbsp;&nbsp;
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Select Product:"></asp:Label>
                &nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="-1">Select Item</asp:ListItem>
                    <asp:ListItem Value="500">Product A</asp:ListItem>
                    <asp:ListItem Value="1000">Product B</asp:ListItem>
                    <asp:ListItem Value="1500">Product C</asp:ListItem>
                    <asp:ListItem Value="2000">Product D</asp:ListItem>
                </asp:DropDownList>
            </asp:Panel>
&nbsp;
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" BorderColor="Maroon" BorderStyle="Solid" Height="189px" Width="985px">
                &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Cost:"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="Panel3" runat="server" BorderColor="Maroon" BorderStyle="Solid" Height="139px" Width="986px">
                &nbsp;<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Price:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
