﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF3300;
        }
        .auto-style2 {
            color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">EURO 2020</h1>
            <p class="auto-style1">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="WebForm1.aspx">Αρχική</asp:HyperLink>
                <span class="auto-style2">-</span>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="WebForm2.aspx">Στάδια</asp:HyperLink>
                <span class="auto-style2">-</span>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="WebForm3.aspx">Αποτελέσματα</asp:HyperLink>
            </p>
            <p class="auto-style1">
                <asp:DropDownList ID="lstTeamNames" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="lblPlayers" runat="server" Text="Οι παίκτες της ομάδας " Visible="False"></asp:Label>
                <asp:Label ID="lblPlithos" runat="server" Visible="False"></asp:Label>
            </p>
            <p>
                <asp:DropDownList ID="lstTeamPlayers" runat="server" AutoPostBack="True" Visible="False">
                </asp:DropDownList>
            </p>
            <p>
                &nbsp;<asp:Label ID="lblPlayersNS" runat="server" Text="Μη επιλεγμένοι παίκτες " Visible="False"></asp:Label>
                <asp:Label ID="lblPlithosNS" runat="server" Visible="False"></asp:Label>
            </p>
            <p>
                <asp:DropDownList ID="lstTeamPlayersNS" runat="server" AutoPostBack="True" Visible="False">
                </asp:DropDownList>
            </p>
        </div>
    </form>
</body>
</html>