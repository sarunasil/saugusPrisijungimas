<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Unauthorized.aspx.cs" Inherits="saugusPrisijungimas.Unauthorized" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Neleistinas bandymas prisijungti</h2>
    <p>
    Jūs neturite pakankamų privilegijų patekti į šį puslapį.
    </p>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Prisijungti" Height="23px" OnClick="Button1_Click" Width="72px" />
    </form>
</body>
</html>
