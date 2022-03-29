<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoktorBİlgi.aspx.cs" Inherits="HastaneRandevuSistemi.DoktorBİlgi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 68px; line-height: 60px;"  >
            HASTANE RANDEVU SİSTEMİ</div>
        <p >

        </p>
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 50px; line-height: 50px;">

            BİLGİLERİM</div>
        <table style="width:100%">
            <tr>
                <td style="width:30%">AD</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">SOYAD</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox9" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">TC</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox10" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:30%">ŞİFRE</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:30%">TÜR</td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>           
        </table>
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 50px; line-height: 50px;">

            AKTİF RANDEVULAR</div>
    </form>
</body>
</html>
