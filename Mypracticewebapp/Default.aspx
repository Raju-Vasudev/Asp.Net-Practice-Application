<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mypracticewebapp._Default" %>


<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>

<body>
    <table style="border:2px solid black; font-family:Arial">
        <tr>
            <td>First Number</td>
          
            <td><asp:TextBox ID="txtFirstNumber" value="" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Second Number</td>
            
            <td><asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Result</td>
            
            <td><asp:TextBox ID="txtResult" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <input type="button" value="Add" id="btnAdd" onclick="Hello()" />
            </td>
        </tr>
    </table>
    <!--Type here ::<input type="text" id="txthello" />
    <br />
    <input type="button" value="SUBMIT" onclick="Hello()" />-->
    <script type="text/javascript" src="JavaScript.js"></script>
</body>

</html>


