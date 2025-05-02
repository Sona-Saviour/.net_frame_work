<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image_example.aspx.cs" Inherits="WebApplication1.Image_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Image ID="Image1" runat="server" Height="500px" ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Waterfall_at_Arthur%27s_Pass_National_Park.jpg/330px-Waterfall_at_Arthur%27s_Pass_National_Park.jpg" Width="500px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image2" runat="server" Height="98px" ImageUrl="~/file_upload/sunset.jpg" Width="123px" />
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="141px" ImageUrl="~/file_upload/newsunset.jpg" OnClick="ImageButton1_Click" Width="173px" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
