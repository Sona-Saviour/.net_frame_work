<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdownlistexample.aspx.cs" Inherits="WebApplication1.dropdownexample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" BorderColor="#990000" BorderStyle="Dotted" Height="241px" Width="888px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label1" runat="server" Text="enter the text"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="copy to drop downlist" />
                &nbsp;<br />
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                <br />
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel2" runat="server" BackColor="#FF6666" BorderColor="#990000" Height="169px" Width="857px">
                <asp:Label ID="Label2" runat="server" Text="select an item"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem Value="-1">select</asp:ListItem>
                    <asp:ListItem Value="1">TV</asp:ListItem>
                    <asp:ListItem Value="2">fridge</asp:ListItem>
                    <asp:ListItem Value="3">washing machine</asp:ListItem>
                    <asp:ListItem Value="4">Cooler</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="copy to text box" />
                <br />
                <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel3" runat="server" BorderColor="#CC3300" BorderStyle="Solid" Height="192px" Width="936px">
                <br />
                <asp:Label ID="Label3" runat="server" Text="select an item"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                    <asp:ListItem Value="-1">select</asp:ListItem>
                    <asp:ListItem Value="1">one</asp:ListItem>
                    <asp:ListItem Value="2">two</asp:ListItem>
                    <asp:ListItem Value="3">three</asp:ListItem>
                    <asp:ListItem Value="4">four</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;
                <br />
                <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel4" runat="server" Height="173px" Width="977px">
                <br />
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem Value="-1">select</asp:ListItem>
                    <asp:ListItem Value="1">a</asp:ListItem>
                    <asp:ListItem Value="2">b</asp:ListItem>
                    <asp:ListItem Value="3">c</asp:ListItem>
                    <asp:ListItem Value="4">d</asp:ListItem>
                    <asp:ListItem Value="5">e</asp:ListItem>
                    <asp:ListItem Value="6">f</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Remove" />
            </asp:Panel>
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
