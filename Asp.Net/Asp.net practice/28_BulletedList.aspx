<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="28_BulletedList.aspx.cs" Inherits="Asp.Net._28_BulletedList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="CountriesBulletedList" runat="server" BulletStyle="Numbered" OnClick="CountriesBulletedList_Click">
                <asp:ListItem Text="India" Value="1"></asp:ListItem>
                <asp:ListItem Text="US" Value="2"></asp:ListItem>
                <asp:ListItem Text="UK" Value="3"></asp:ListItem>
                <asp:ListItem Text="France" Value="4"></asp:ListItem>
            </asp:BulletedList>

            <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Numbered" DisplayMode="HyperLink" OnClick="BulletedList1_Click">
                <asp:ListItem Text="Google" Value="http://google.com"></asp:ListItem>
                <asp:ListItem Text="Youtube" Value="http://Youtube.com"></asp:ListItem>
                <asp:ListItem Text="Blogger" Value="http://Blooger.com"></asp:ListItem>
                <asp:ListItem Text="Gmail" Value="http://Gmail.com"></asp:ListItem>
            </asp:BulletedList>

            <%--The following HTML, sets DisplayMode="LinkButton" and onclick="CountriesBulletedList_Click"--%>

            <asp:BulletedList ID="BulletedList2" runat="server" DisplayMode="LinkButton" OnClick="CountriesBulletedList_Click">
                <asp:ListItem Text="Google" Value="1"></asp:ListItem>
                <asp:ListItem Text="Microsoft" Value="2"></asp:ListItem>
                <asp:ListItem Text="Dell" Value="3"></asp:ListItem>
                <asp:ListItem Text="IBM" Value="4"></asp:ListItem>
            </asp:BulletedList>
                       
        </div>
    </form>
</body>
</html>
