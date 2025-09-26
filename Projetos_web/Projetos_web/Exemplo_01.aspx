<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo_01.aspx.cs" Inherits="Projetos_web.Exemplo_01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Exemplo 01</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNome" runat="server" style="position: absolute; top: 16px; left: 10px; z-index: 1; width: 429px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblNome" runat="server" style="position: absolute; z-index: 1; left: 11px; top: 51px; width: 431px;" BackColor="White" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Button ID="btnExibir" runat="server" style="z-index: 1; left: 10px; top: 83px; position: absolute" Text="Exibir" OnClick="btnExibir_Click" />
    </form>
</body>
</html>
