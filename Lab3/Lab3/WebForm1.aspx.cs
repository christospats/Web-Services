using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info fbWS = new
                       eu.dataaccess.footballpool.ws.Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                // η λειτουργία επιστρέφει πίνακα string
                string[] TeamTable = fbWS.TeamNames();
                lstTeamNames.Items.Add("‐Επίλεξε Εθνική Ομάδα‐");
                for (int i = 0; i < TeamTable.Length; i++)

                    lstTeamNames.Items.Add(TeamTable[i]);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  η λειτουργία επιστρέφει πίνακα tPlayer
            eu.dataaccess.footballpool.ws.tPlayer[] Player =
                             fbWS.TeamPlayers(lstTeamNames.Text, true);
            eu.dataaccess.footballpool.ws.tPlayer[] PlayerNS =
                             fbWS.TeamPlayers(lstTeamNames.Text, false);
            lstTeamPlayers.Items.Clear();
            lstTeamPlayersNS.Items.Clear();
            for (int i = 0; i < Player.Length; i++)
                lstTeamPlayers.Items.Add(Player[i].sName);
            for (int i = 0; i < PlayerNS.Length; i++)
                lstTeamPlayersNS.Items.Add(PlayerNS[i].sName);
            lstTeamPlayers.Visible = true;
            lstTeamPlayersNS.Visible = true;
            lblPlithos.Text = " (" + Convert.ToString(Player.Length) + "):";
            lblPlithosNS.Text = " (" + Convert.ToString(PlayerNS.Length) + "):";
            lblPlayers.Visible = true;
            lblPlayersNS.Visible = true;
            lblPlithos.Visible = true;
            lblPlithosNS.Visible = true;
        }
    }
}