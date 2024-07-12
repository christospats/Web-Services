<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorLab2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ΑΡΙΘΜΟΜΗΧΑΝΗ<br />
            Δώστε αριθμό Α:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnprosthesh" runat="server" OnClick="Button1_Click" Text="+" />
            &nbsp;<asp:Button ID="btnaferesh" runat="server" Text="-" OnClick="btnaferesh_Click" />
            &nbsp;<asp:Button ID="brnpollaplasiasmos" runat="server" Text="*" OnClick="brnpollaplasiasmos_Click" />
            &nbsp;<asp:Button ID="brndiairesh" runat="server" Text="/" OnClick="brndiairesh_Click" />
            &nbsp;<asp:Button ID="clear" runat="server" Text="Καθάρισμα" OnClick="clear_Click" />
            <br />
            Δώστε αριμθμό Β:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Αποτέλεσμα:
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
