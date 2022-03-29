<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="HastaneRandevuSistemi.SifremiUnuttum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 68px; line-height: 68px;">
            HASTANE RANDEVU SİSTEMİ</div>
        <p >

        </p>
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 50px; line-height: 50px;">

            ŞİFREMİ UNUTTUM</div>
        <table style="width:100%">
            <tr>
                <td style="width:30%">TC</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:30%">TELEFON</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Height="30px" Text="TAMAM" Width="130px" BackColor="Red" />
    </form>
</body>
</html>
