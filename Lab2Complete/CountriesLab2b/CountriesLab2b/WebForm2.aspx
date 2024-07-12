<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CountriesLab2b.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Δώσε μια IP διεύθυνση (στη μορφή x.x.x.x)<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            ΔΕΣ ΤΗΝ ΧΩΡΑ ΤΗΣ IP ΔΙΕΥΘΥNΣΗΣ<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GET IP LOCATION" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblCountry" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblState" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="WebForm3.aspx">Επόμενη υπηρεσία</asp:HyperLink>
&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="WebForm1.aspx">Προηγούμενη υπηρεσία</asp:HyperLink>
        </div>
    </form>
</body>
</html>
