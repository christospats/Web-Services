using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info fbWS = new eu.dataaccess.footballpool.ws.Info();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                // η λειτουργία επιστρέφει πίνακα string
                string[] StadiumTable = fbWS.StadiumNames();
                lstStadia.Items.Add("‐Επίλεξε Στάδιο‐");
                for (int i = 0; i < StadiumTable.Length; i++)

                    lstStadia.Items.Add(StadiumTable[i]);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // η λειτουργία επιστρέφει tStadiumInfo
            eu.dataaccess.footballpool.ws.tStadiumInfo Stadio =
                                  fbWS.StadiumInfo(lstStadia.Text);
            lblStadioName.Text = Stadio.sName + ",";
            lblStadioCity.Text = Stadio.sCityName + ",";
            lblStadioTheseis.Text = Convert.ToString(Stadio.iSeatsCapacity) + "θέσεις";
            lnkStGMaps.Text = "Google Maps: Πατήστε εδώ";
            lnkStGMaps.NavigateUrl = Stadio.sGoogleMapsURL;
            lnkStWiki.Text = Stadio.sWikipediaURL;
            lnkStWiki.NavigateUrl = Stadio.sWikipediaURL;

            //προσθήκη ετικέτας <iframe> για την εμφάνιση της σελίδας wiki
            iFramePH.Controls.Add(new LiteralControl("<iframe src=\"" +
                           Stadio.sWikipediaURL + "\" width=\"600\"" +
                           "height=\"300\"runat=\"server\"></iframe>"));

            // εμφάνιση των ετικετών και των συνδέσμων, όταν έχουν περιεχόμενο
            lblStadioName.Visible = true;
            lblStadioCity.Visible = true;
            lblStadioTheseis.Visible = true;
            lnkStWiki.Visible = true;
            lnkStGMaps.Visible = true;
        }
    }
}