<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LAB4Revision.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 88px;
        }
        .auto-style3 {
            margin-left: 1px;
        }
        .auto-style4 {
            width: 617px;
            height: 26px;
        }
        .auto-style5 {
            width: 88px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
            width: 890px;
        }
        .auto-style7 {
            width: 95px;
        }
        .auto-style8 {
            width: 61px;
        }
        .auto-style9 {
            width: 100%;
            margin-right: 831px;
        }
        .auto-style10 {
            width: 95px;
            height: 23px;
        }
        .auto-style11 {
            width: 61px;
            height: 23px;
        }
        .auto-style14 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style15 {
            width: 455px;
        }
        .auto-style16 {
            width: 890px;
        }
        .auto-style18 {
            width: 617px;
        }
        .auto-style19 {
            width: 444px;
        }
        .auto-style20 {
            width: 249px;
        }
        .auto-style21 {
            width: 149px;
        }
        .auto-style22 {
            height: 23px;
            width: 149px;
        }
        .auto-style25 {
            width: 121px;
        }
        .auto-style26 {
            width: 277px;
        }
        .auto-style27 {
            width: 277px;
            height: 23px;
        }
        .auto-style28 {
            height: 23px;
            width: 121px;
        }
        .auto-style30 {
            height: 23px;
            width: 236px;
        }
        .auto-style31 {
            width: 236px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table style="width:100%;">
                <tr>
                    <td class="auto-style18">Δώσε νόμισμα προέλευσης:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <asp:DropDownList ID="lstCurFrom" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style16">Δώσε νόμισμα προέλευσης:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <asp:DropDownList ID="lstCurFrom2" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Δώσε νόμισμα προορισμού:</td>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="lstCurTo" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">Δώσε νόμισμα προορισμού:</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="lstCurTo2" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
            </table>
            <br />
            <table class="auto-style14">
                <tr>
                    <td class="auto-style20">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Μετατροπή" />
                    </td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style15">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Μετατροπή Συναλλάγματος" />
                    </td>
                    <td class="auto-style15">
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </td>
                </tr>
            </table>
            <br />
&nbsp;<table class="auto-style9">
                <tr>
                    <td class="auto-style7">Αποτέλεσμα:</td>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style21">Αποτέλεσμα:</td>
                    <td class="auto-style26">
                        <asp:Label ID="label3" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style25">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11">
                        <asp:Label ID="label2" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style30"></td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style27">
                        <asp:Label ID="label4" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11">&nbsp;<asp:Label ID="label5" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style30">&nbsp;<asp:Label ID="label7" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style27">
                        <asp:Label ID="label9" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style28">
                        <asp:Label ID="label11" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11">&nbsp;<asp:Label ID="label6" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style30">&nbsp;<asp:Label ID="label8" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style27">
                        <asp:Label ID="label10" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style28">
                        <asp:Label ID="label12" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
