<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Localization_Globalization.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DDLCulture" runat="server" AutoPostBack="true">
            <asp:ListItem Text="English" Value="en-US" />
            <asp:ListItem Text="Spanish" Value="es-CR" />
         </asp:DropDownList>
    <div>
      <%--<asp:Label ID="Label1" runat="server" Text="<%$ Resources:DisplayResources,HearderMessage %>"></asp:Label>--%>
          <div>

       <asp:Label ID="Label2" runat="server" Text="Current Date is"></asp:Label>
        <span style="color:brown">
        <asp:Label ID="LblDate" runat="server"  ></asp:Label> <br />
        <asp:Label ID="Label3" runat="server" Text="In case you want to login you should have atleast"></asp:Label>
        <asp:Label ID="LblRequiredamount" runat="server" ></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="in your pocket"></asp:Label>
        <br />
        <br />
         </span>
        <asp:Label ID="Label5" runat="server" Text="User Name:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="LoginButton" runat="server" Text="Lon In" CommandName="Login"/>
    </div>
    </div>
    </form>
</body>
</html>
