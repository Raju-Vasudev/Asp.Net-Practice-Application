<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="29_List controls.aspx.cs" Inherits="Asp.Net._29_List_controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:BulletedList ID="BulletedList1" runat="server">
                <asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
