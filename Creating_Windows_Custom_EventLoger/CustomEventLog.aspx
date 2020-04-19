<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomEventLog.aspx.cs" Inherits="Creating_Windows_Custom_EventLoger.CustomEventLog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Event Log Name ::  <asp:TextBox ID="EventLogerTextBox" runat="server"></asp:TextBox>
            <br />
            Event Log Source Name ::  <asp:TextBox ID="EventlogSourceTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonToCreateEventlog" runat="server" Text="Create Custom Event log" OnClick="ButtonToCreateEventlog_Click" />

        </div>
    </form>
</body>
</html>
