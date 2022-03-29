<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="HastaneRandevuSistemi.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body >
    <form id="form1" runat="server" >
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 68px; line-height: 60px;"  >
            HASTANE RANDEVU SİSTEMİ</div>
        <p >
            <asp:Button ID="Button1" runat="server" Height="30px" Text="DOKTOR GİRİŞ" Width="130px" BackColor="Red" />
        </p>
        <p >
            <asp:Button ID="Button2" runat="server" Height="30px" Text="SEKRETER GİRİŞ" Width="130px" Backcolor="Red" />
        </p>
        <p >
            <asp:Button ID="Button3" runat="server" Text="HASTA GİRİŞ" Height="30px" Width="130px" Backcolor="Red" />
        </p>
    </form>
</body>
</html>
