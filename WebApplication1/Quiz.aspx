<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="WebApplication1.Quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="q1" runat="server" Text="1.No of Continents in World"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="0">5</asp:ListItem>
                <asp:ListItem Value="0">6</asp:ListItem>
                <asp:ListItem Value="1">7</asp:ListItem>
                <asp:ListItem Value="0">4</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="q2" runat="server" Text="2. Capital of India"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                <asp:ListItem Value="0">Mumbai</asp:ListItem>
                <asp:ListItem Value="0">Chennai</asp:ListItem>
                <asp:ListItem Value="0">Hyderabad</asp:ListItem>
                <asp:ListItem Value="1">New Delhi</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="q3" runat="server" Text="3.What is the Square of 4?"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                <asp:ListItem Value="0">32</asp:ListItem>
                <asp:ListItem Value="1">16</asp:ListItem>
                <asp:ListItem Value="0">72</asp:ListItem>
                <asp:ListItem Value="0">45</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="q4" runat="server" Text="4.Which of them is a primary color?"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList4" runat="server">
                <asp:ListItem Value="1">Red</asp:ListItem>
                <asp:ListItem Value="0">Yellow</asp:ListItem>
                <asp:ListItem Value="0">Orange</asp:ListItem>
                <asp:ListItem Value="0">Pink</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="q5" runat="server" Text="5. (5*5)+10=   ?"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList5" runat="server">
                <asp:ListItem Value="0">36</asp:ListItem>
                <asp:ListItem Value="0">100</asp:ListItem>
                <asp:ListItem Value="0">70</asp:ListItem>
                <asp:ListItem Value="1">35</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
