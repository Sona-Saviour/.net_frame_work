<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data_list_example.aspx.cs" Inherits="WebApplication4.data_list_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;<br />
            <asp:DataList ID="DataList1" runat="server">
                <HeaderTemplate>
                    <table border="2">
                        <tr>
                            <td style="width:300px;">ID</td>
                            <td style="width:300px;">NAME</td>
                            <td style="width:300px;">DESIGNATION</td>
                             <td style="width:300px;">SALARY</td>
                             <td style="width:300px;">DEPT</td>
                             <td style="width:300px;"></td>

                        </tr>
                    </table>
                </HeaderTemplate>

                <ItemTemplate>
                    <table  border="2">
                        <tr>
                            <td style="width:300px;">
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("Id")%>'></asp:Label>
                            </td>
                             <td style="width:300px;">
                                 <asp:Label ID="Label2" runat="server" Text='<%#Eval("ename")%>'></asp:Label>
                             </td>
                             <td style="width:300px;">
                                 <asp:Label ID="Label3" runat="server" Text='<%#Eval("designation")%>'></asp:Label>
                             </td>
                           <td style="width:300px;">
                               <asp:Label ID="Label4" runat="server" Text='<%#Eval("salary")%>'></asp:Label>
                           </td>
                            <td style="width:300px;">
                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("dept")%>'></asp:Label>
                            </td>
                            <td style="width:300px;">
                                <a href="update.aspx?id=<%#DataBinder.Eval(Container.DataItem,"id") %>">Update</a>
                            </td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Remove" CommandName="Remove" CommandArgument='<%#Eval("id") %>' OnCommand="Button1_Command" />
                            </td>
                        </tr>

                    </table>
                </ItemTemplate>
            </asp:DataList>
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
