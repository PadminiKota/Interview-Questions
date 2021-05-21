<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Localization_Globalization.WebForm1" culture="es-CR" meta:resourcekey="PageResource1" uiculture="es-CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

       <asp:Label ID="Label1" runat="server" Text="Current Date is" meta:resourcekey="Label1Resource1"></asp:Label>
        <span style="color:brown">
        <asp:Label ID="LblDate" runat="server" meta:resourcekey="LblDateResource1" ></asp:Label> <br />
        <asp:Label ID="Label3" runat="server" Text="In case you want to login you should have atleast" meta:resourcekey="Label3Resource1"></asp:Label>
        <asp:Label ID="LblRequiredamount" runat="server" meta:resourcekey="LblRequiredamountResource1" ></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="in your pocket" meta:resourcekey="Label2Resource1"></asp:Label>
        <br />
        <br />
         </span>
        <asp:Label ID="Label4" runat="server" Text="User Name:" meta:resourcekey="Label4Resource1"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Password:" meta:resourcekey="Label5Resource1"></asp:Label>
        <asp:TextBox ID="Password" runat="server" TextMode="Password" meta:resourcekey="PasswordResource1"></asp:TextBox>
        <br />
        <asp:Button ID="LoginButton" runat="server" Text="Lon In" CommandName="Login" meta:resourcekey="LoginButtonResource1" />
    </div>
    </form>
</body>
</html>
