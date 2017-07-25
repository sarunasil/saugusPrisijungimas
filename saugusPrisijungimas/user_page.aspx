<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_page.aspx.cs" Inherits="saugusPrisijungimas.user_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body{
            background-color: #F7F7F7;
            width: 1200px;
            margin: 0px auto;
            text-align: center;
        }
        header{
            max-height: 250px;
            margin: 30px auto;
        }
        #LogoBtn{
            height: 200px;
            width: 500px;
            margin: 10px auto;
            display: block;
        }
    </style>
    <title>Admin page</title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h3>LUTEX NUMERIU KONVERTAVIMO PROGRAMA</h3>
            <asp:ImageButton ID="LogoBtn" runat="server" ImageUrl="~/Resources/logo.png" />
        </header>
        <main>
            <h1>USER</h1>
        </main>
    </form>
</body>
</html>