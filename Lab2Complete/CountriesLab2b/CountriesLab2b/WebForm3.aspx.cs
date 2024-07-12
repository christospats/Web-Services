using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountriesLab2b
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info st = new eu.dataaccess.footballpool.ws.Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                eu.dataaccess.footballpool.ws.tStadiumInfo[] stadium_names =
               st.AllStadiumInfo();
                // Iterates for array nodes and add them in dropdownlist
                DropDownList1.Items.Add("- Επιλέξτε στάδιο -");
                for (int i = 0; i < stadium_names.Length; i++)
                    DropDownList1.Items.Add(stadium_names[i].sName);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // η stURL μας δίνει πρόσβαση στα πεδία του xml
            // επειδή το XML αποτέλεσμα αποτελείται από έναν κόμβο XML
            // μπορούμε και χωρίς foreach βρόχο να λάβουμε τα πεδία XML
            eu.dataaccess.footballpool.ws.tStadiumInfo stURL =
           st.StadiumInfo(DropDownList1.Text);
            lblName.Text = DropDownList1.Text;
            lblSeats.Text = stURL.iSeatsCapacity.ToString();
            lblCity.Text = stURL.sCityName;
            HyperLink1.NavigateUrl = stURL.sGoogleMapsURL;
            HyperLink2.NavigateUrl = stURL.sWikipediaURL;
        }
    }
}