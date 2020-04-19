<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="39_UseSubmitBehavior of button.aspx.cs" Inherits="Asp.Net.Asp.net_practice._39_UseSubmitBehavior_of_button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:button Id="btn1" runat="server" text="Button-01" UseSubmitBehavior="False" />
            <asp:button Id="btn2" runat="server" text="Button-02" UseSubmitBehavior="True"/>
            <asp:button Id="btn3" runat="server" text="Button-03" UseSubmitBehavior="False" />
        </div>
    </form>
</body>
</html>
