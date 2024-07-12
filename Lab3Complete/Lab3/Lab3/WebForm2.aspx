<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Lab3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="auto-style1">EURO 2020</h1>
        <p>
            &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="WebForm1.aspx">Αρχική</asp:HyperLink>
            -
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="WebForm2.aspx">Στάδια</asp:HyperLink>
            -
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="WebForm3.aspx">Αποτελέσματα</asp:HyperLink>
        </p>
        <p>
            <asp:DropDownList ID="lstStadia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblStadioName" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblStadioCity" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="lblStadioTheseis" runat="server" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="lnkStGMaps" runat="server" Visible="False">[lnkStGMaps]</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="lnkStWiki" runat="server" Visible="False">[lnkStWiki]</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <asp:PlaceHolder ID="iFramePH" runat="server"></asp:PlaceHolder>
    </form>
</body>
</html>
