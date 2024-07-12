<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="CountriesLab2b.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Η υπηρεσία επιστρέφει πληροφορίες για το στάδιο
                <br />
                που επιλέγει ο χρήστης</h3>
        </div>
        <p>
            Επέλεξε στάδιο:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
            Όνομα σταδίου: <asp:Label ID="lblName" runat="server"></asp:Label>
        </p>
        <p>
            Διαθέσιμες θέσεις:
            <asp:Label ID="lblSeats" runat="server"></asp:Label>
        </p>
        <p>
            Πόλη:
            <asp:Label ID="lblCity" runat="server"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server">Google url link</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server">Wikipedia</asp:HyperLink>
&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="WebForm2.aspx">Προηγούμενη Υπηρεσία</asp:HyperLink>
        </p>
    </form>
</body>
</html>
