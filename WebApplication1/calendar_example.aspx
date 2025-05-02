<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calendar_example.aspx.cs" Inherits="WebApplication1.calendar_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;<br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFF99" BorderColor="Maroon" BorderStyle="Dotted" CaptionAlign="Bottom" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
