<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Lab3.WebForm3" %>

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
        <div>
            <h1 class="auto-style1">EURO 2020</h1>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="WebForm1.aspx">Αρχική</asp:HyperLink>
        -
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="WebForm2.aspx">Στάδια</asp:HyperLink>
        -
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="WebForm3.aspx">Αποτελέσματα</asp:HyperLink>
        <p>
            <span class="auto-style1">Δώσε αριθμό παιχνιδιού (1- 51):</span>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p class="auto-style1">
            (ή επιλέξτε ομάδες)</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Αποτέλεσμα" />
        </p>
        <asp:DropDownList ID="lstTeamNames" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstTeamNames_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="lblScore1" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblPen1" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblPenalty" runat="server" Text="Πέναλτι"></asp:Label>
        <br />
        <asp:DropDownList ID="lstTeam2Names" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstTeam2Names_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="lblScore2" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblPen2" runat="server"></asp:Label>
    </form>
</body>
</html>
