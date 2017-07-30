

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="saugusPrisijungimas.Login" %>

&nbsp;

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Lutex prisijungimas prisijungimas</title>
    

    <style>
        body{
            background-color: #F7F7F7;
            width: 500px;
            margin: 0 auto;
        }

        header{
            margin: 10px auto;
        }
        #LogoBtn{
            height: 200px;
            margin: 15px auto;
        }
        #Login1{
            margin: 50px auto;
        }
    </style>
</head>

<body id ="LoginBody">
    <form id="LoginForm" runat="server">
        <header id="LoginHeader">
            <asp:ImageButton ID="LogoBtn" runat="server"  ImageUrl="~/Resources/logo.png"/>
        </header>
        <main>
            <asp:Login ID="Login1" runat="server" Font-Bold="False" Font-Size="X-Large" LoginButtonText="Prisijungti" PasswordLabelText="Slaptažodis:" RememberMeText="Prisiminti" TitleText="Prisijungimas" UserNameLabelText="Vartotojo vardas:" OnAuthenticate="Login_Authenticate" FailureText="Neteisingi prisijungimo duomenys"></asp:Login>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </main>
    </form>
</body>

</html>
