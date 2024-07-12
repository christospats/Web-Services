<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConverterLab2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><strong>Μετατροπή&nbsp; Συναλλάγματος</strong></h3>
            <br />
            Δώσε νόμισμα προέλευσης:<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="80px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:DropDownList ID="lstCurFrom" runat="server" AutoPostBack="True" Height="21px" style="margin-left: 0px" Width="132px">
            </asp:DropDownList>
            <br />
            <br />
            Δώσε νόμισμα προορισμού:
            <asp:DropDownList ID="lstCurTo" runat="server" AutoPostBack="True" Width="215px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Μετατροπή" />
            <br />
            <br />
            Αποτέλεσμα: <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
