<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebLogin1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="2" cellpadding="2" cellspacing="2">
                <tr>
                    <td align="right">
                        <asp:Label ID="Etiqueta1" runat="server" Text="Ingresa el primer numero"></asp:Label>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtPrimerNumero" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="Etiqueta2" runat="server" Text="Ingresa el segundo numero"></asp:Label>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="txtSegundoNumero" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="Etiqueta3" runat="server" Text="Resultado"></asp:Label>
                    </td>
                    <td align="left">
                        <asp:Label ID="EtiquetaResultado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btnSumar" runat="server" Text="Sumar(+)" OnClick="btnSumar_Click" />
                    </td>
                    <td align="center">
                        <asp:Button ID="btnRestar" runat="server" Text="Restar(-)" OnClick="btnRestar_Click" />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btnMultiplicar" runat="server" Text="Multiplicar(*)" OnClick="BtnMultiplicar_Click" />
                    </td>
                    <td align="center">
                        <asp:Button ID="btnDividir" runat="server" Text="Dividir(/)" OnClick="btnDividir_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
