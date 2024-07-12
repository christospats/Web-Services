<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyConsumer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbMyValue" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Τιμή"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="tbMyTotal" runat="server" Height="16px" style="margin-top: 13px" Width="116px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Σύνολο"></asp:Label>
            <br />
            <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Υπολογισμός" />
            <br />
            <br />
            <asp:Label ID="lblPercentage" runat="server"></asp:Label>
            <asp:Label ID="lblPercentageLabel" runat="server" Text="= ποσοστό που υπολογίστηκε" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblServerTime" runat="server"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="= η ώρα στον server"></asp:Label>
        </div>
    </form>
</body>
</html>
