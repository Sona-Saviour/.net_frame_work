<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkbox_example.aspx.cs" Inherits="WebApplication1.Checkbox_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Panel ID="Panel1" runat="server" BorderColor="#CC3300" BorderStyle="Ridge" Height="315px" Width="798px">
                <br />
                <asp:CheckBox ID="chk1" runat="server" Text="option 1" />
                <br />
                <br />
                <asp:CheckBox ID="chk2" runat="server" Text="option 2" />
                <br />
                <br />
                <asp:CheckBox ID="chk3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="option 3" />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" BackColor="#FFFFCC" Height="190px" Width="1004px">
                <br />
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                </asp:CheckBoxList>
                &nbsp;<br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="select" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
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
        </div>
    </form>
</body>
</html>
