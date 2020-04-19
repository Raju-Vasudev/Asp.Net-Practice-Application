<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="86_Impersonate of Anonymous authentication.aspx.cs" Inherits="Asp.Net.Asp.net_practice._86_Impersonate_of_Anonymous_authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This will enable or disable the impersonate.This will ensure that the application code is exxcuted by using the "IUSR" account but earlier the code is executed with IIS pool identity.
            we can add this impersonate from web.conifg file or from iis server.
            To add from web.config----We have to add we have add identity element and within that element set impersonate="true"
            TO add from server select the pool that the application hosted.edit app pool and select basic settings and MANAGED PIPELINE MODE = CLASSIC.
        </div>
    </form>
</body>
</html>
