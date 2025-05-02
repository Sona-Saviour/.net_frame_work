<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Radiobutton_list.aspx.cs" Inherits="WebApplication1.Radiobutton_list" %>

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
            <asp:Panel ID="Panel1" runat="server" BorderColor="Maroon" Height="249px" Width="1018px">
                &nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="1">Male</asp:ListItem>
                    <asp:ListItem Value="2">Female</asp:ListItem>
                    <asp:ListItem Value="3">Others</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </asp:Panel>
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" Height="289px" style="margin-top: 0px" Width="998px">
                <br />
                <br />
                <asp:RadioButtonList ID="RadioButtonList2" runat="server" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                </asp:RadioButtonList>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                &nbsp;
                <br />
                &nbsp;
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
        </div>
    </form>
</body>
</html>
