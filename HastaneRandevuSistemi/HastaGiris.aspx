<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaGiris.aspx.cs" Inherits="HastaneRandevuSistemi.HastaGiris" %>

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

            HASTA GİRİŞ</div>
        <table style="width:100%">
            <tr>
                <td style="width:30%">TC</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:30%">ŞİFRE</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:30%">YETKİ</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>

        </table>
        <asp:Button ID="Button1" runat="server" Height="33px" Text="GİRİŞ YAP" Width="130px" BackColor="Red" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button2" runat="server" Height="30px" Text="ŞİFREMİ UNUTTUM" Width="130px" BackColor="Red" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Height="30px" Text="ÜYE OL" Width="130px" BackColor="Red" />
        </p>
    </form>
</body>
</html>
