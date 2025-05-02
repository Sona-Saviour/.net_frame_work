<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="example_multiview.aspx.cs" Inherits="WebApplication1.example_multiview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;<br />
            <br />
            <asp:MultiView ID="MultiView1" runat="server">
                <br />
                <asp:View ID="View1" runat="server">
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="View one__________________________"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="goto view2" />
                </asp:View>
                <br />
                <br />
                <asp:View ID="View2" runat="server">
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="view two!!!!!!!!!!!!!!!!"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="goto view3" />
                </asp:View>
                <br />
                <br />
                <br />
                <asp:View ID="View3" runat="server">
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="view three......................................."></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="goto view1" />
                    <br />
                </asp:View>
                <br />
                <br />
                <br />
                <br />
                <br />


            </asp:MultiView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
