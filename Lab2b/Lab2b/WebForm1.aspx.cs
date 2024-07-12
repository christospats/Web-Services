using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Lab2b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        com.lavasoft.wsgeoip.GeoIPService geoWS = new com.lavasoft.wsgeoip.GeoIPService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // country is an XML string which will hold all the info in xml format
            // η country μας δίνει πρόσβαση στα πεδία του xml
            string country = geoWS.GetIpLocation(TextBox1.Text);
            // Create an XML Document and load your XML
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(country);
            // Get your nodes, here our node in GeoIP because web service
            // will give us the following format:
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("//GeoIP");
            // επειδή επιστρέφεται ένας μόνο κόμβος
            // δεν χρειάζεται βρόχος foreach
            // ένας είναι ο κόμβος, ο nodes[0]
            string iso2code = nodes[0]["Country"].InnerText;

            // Convert the ISO code to Country name passing the iso2code output of the xml
            lblCountry.Text = geoWS.GetCountryNameByISO2(iso2code) + ", ";
            lblState.Text = nodes[0]["State"].InnerText;
        }
    }
}