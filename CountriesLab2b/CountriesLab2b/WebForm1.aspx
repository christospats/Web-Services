<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CountriesLab2b.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ΠΛΗΡΟΦΟΡΙΕΣ ΧΩΡΑΣ</h1>
            <p>
                Χώρα:
                <asp:DropDownList ID="lstCountry" runat="server" Height="17px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="97px">
                </asp:DropDownList>
            </p>
            <p>
                ISO code: <asp:Label ID="lblIsoCode" runat="server"></asp:Label>
            </p>
            <p>
                Πρωτεύουσα:
                <asp:Label ID="lblCapital" runat="server"></asp:Label>
            </p>
        </div>
        <asp:Image ID="Image1" runat="server" Height="169px" Width="219px" />
        <br />
        Κωδικούς Διεθνούς Κλήσης :
        <asp:Label ID="lblPhone" runat="server"></asp:Label>
        <br />
        <br />
        Currency:
        <asp:Label ID="lblCurrency" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Κλήση υπηρεσίας" />
    </form>
</body>
</html>
