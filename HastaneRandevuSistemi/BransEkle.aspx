<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BransEkle.aspx.cs" Inherits="HastaneRandevuSistemi.BransEkle" %>

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

            BRANŞ EKLE</div>
        <table style="width:100%">
            <tr>
                <td style="width:30%">BRANŞ AD</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>          
        </table>
        <asp:Button ID="Button1" runat="server" Height="30px" Text="EKLE" Width="130px" BackColor="Red" />
    </form>
</body>
</html>
