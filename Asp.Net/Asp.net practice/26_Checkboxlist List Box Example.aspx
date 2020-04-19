<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="26_Checkboxlist List Box Example.aspx.cs" Inherits="Asp.Net.Checkboxlist_List_Box_Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                <asp:ListItem Text="Diploma" Value="1"></asp:ListItem>
                <asp:ListItem Text="Graduate" Value="2"></asp:ListItem>
                <asp:ListItem Text="Post Graduate" Value="3"></asp:ListItem>
                <asp:ListItem Text="Doctrate" Value="4"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="78px" Width="127px" AutoPostBack="True"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
