<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaBilgi.aspx.cs" Inherits="HastaneRandevuSistemi.HastaBilgi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 30%;
            height: 25px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            width: 30%;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
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
                <td style="width:30%">TELEFON</td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:30%">CİNSİYET</td>
                <td>
                    <asp:TextBox ID="TextBox12" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p >

        </p>
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 50px; line-height: 50px;">

            YETİŞKİN RANDEVU AL</div>
        <table style="width:100%">
            <tr>
                <td style="width:30%">BRANŞ</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:30%">DOKTOR</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button5" runat="server" Height="30px" Text="RANDEVU AL" Width="130px" BackColor="Red" />
        <p >

        </p>
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 50px; line-height: 50px;">

            ÇOCUK RANDEVU AL</div>
        <table style="width:100%">
            <tr>
                <td style="width:30%">DOKTOR</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>            
        </table>
        <asp:Button ID="Button4" runat="server" Height="30px" Text="RANDEVU AL" Width="130px" BackColor="Red" />
        <p >

        </p>
        <div style="background-color:red; text-align: center; vertical-align: middle; font-weight: 100; color: #FFFFFF; height: 50px; line-height: 50px;">

            AŞI RANDEVU AL</div>
        <table style="width:100%">
            <tr>
                <td style="width:30%">DOKTOR</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
                </td>
            </tr>           
        </table>
        <asp:Button ID="Button1" runat="server" Height="30px" Text="RANDEVU AL" Width="130px" BackColor="Red" />
    </form>
</body>
</html>
