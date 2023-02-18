<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="nPrimos.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingreso de Numero"></asp:Label>
        </div>
        <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
        <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
        <asp:GridView ID="gridDatos" runat="server">
        </asp:GridView>
        <asp:Label ID="txtTotal" runat="server" Text="Total=0"></asp:Label>
    </form>
</body>
</html>
