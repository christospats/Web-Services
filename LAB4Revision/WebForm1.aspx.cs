using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB4Revision
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        am.cba.api.Gate myWS3 = new am.cba.api.Gate();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string[] ISOCodeTable = myWS3.ISOCodes();
                for (int i = 0; i<ISOCodeTable.Length; i++)
                {
                    lstCurFrom.Items.Add(ISOCodeTable[i]);
                    lstCurTo.Items.Add(ISOCodeTable[i]);
                }
                lstCurFrom.SelectedIndex = 3;
                lstCurTo.SelectedIndex = 1;
                am.cba.api.ExchangeRatesDS.ISOCodesDataTable ISODet = myWS3.ISOCodesDetailed();
                for(int i = 0; i < ISODet.Count; i++)
                {
                    lstCurFrom2.Items.Add(ISODet[i].ISO + "-" + ISODet[i].DescriptionEN);
                    lstCurTo2.Items.Add(ISODet[i].ISO + "-" + ISODet[i].DescriptionEN);
                    lstCurFrom2.SelectedIndex = 13;
                    lstCurTo2.SelectedIndex = 12;
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal f, rateFrom = 0, rateTo = 0;
            string n1, n2;

            n1 = Convert.ToString(lstCurFrom.Text);
            n2 = Convert.ToString(lstCurTo.Text);

            am.cba.api.ExchangeRates ExRates = myWS3.ExchangeRatesLatest();

            for(int i = 0; i < ExRates.Rates.Length; i++)
            {
                if (ExRates.Rates[i].ISO == n1)
                {
                    rateFrom = Convert.ToDecimal(ExRates.Rates[i].Rate) / Convert.ToInt32(ExRates.Rates[i].Amount);
                    label5.Text = ExRates.Rates[i].Amount;
                    label7.Text = ExRates.Rates[i].Rate;
                }
                if (ExRates.Rates[i].ISO == n2)
                {
                    rateTo = Convert.ToDecimal(ExRates.Rates[i].Rate) / Convert.ToInt32(ExRates.Rates[i].Amount);
                    label6.Text = ExRates.Rates[i].Amount;
                    label8.Text = ExRates.Rates[i].Rate;
                }
                if (rateTo != 0)
                {
                    f = Math.Round(Convert.ToDecimal(TextBox1.Text) * rateFrom / rateTo, 2);
                    Label1.Text = Convert.ToString(f);
                } else Label1.Text = "ΑΔΥΝΑΜΙΑ ΜΕΤΑΤΡΟΠΗΣ";
                label2.Text = ExRates.CurrentDate.ToString();

            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            decimal f, rateFrom = 0, rateTo = 0;
            string n3, n4;
            DateTime dt;
            // Προσοχή: οι 3 πρώτοι χαρακτήρες είναι το ISO
            n3 = Convert.ToString(lstCurFrom2.SelectedItem).Substring(0, 3);
            n4 = Convert.ToString(lstCurTo2.SelectedItem).Substring(0, 3);
            // αν θέλουμε να μην χρησιμοποιήσουμε calendar, δίνουμε την τρέχουσαμέρα / ώρα
            // στη μεταβλητή dt
            // dt = DateTime.Now;

            // αλλιώς, αφήνουμε τον χρήστη να επιλέξει μέσω του calendar
            dt = Calendar1.SelectedDate;
            // οι λειτουργίες επιστρέφουν δομή ExchangeRates.

            // Όπως και στο Button1, η παρακάτω λειτουργία επιστρέφει τιμές για όλα
            // τα νομίσματα, δίνοντας όμως τη δυνατότητα ορισμού ημερομηνίας
            // am.cba.api.ExchangeRates ExRatesBD = myWS3.ExchangeRatesByDate(dt);

            // Ακόμη πιο γρήγορη η παρακάτω λειτουργία που επιστρέφει τιμές για
            // συγκεκριμένα νομίσματα
            am.cba.api.ExchangeRates ExRatesBDFrom = myWS3.ExchangeRatesByDateByISO(dt, n3);
            am.cba.api.ExchangeRates ExRatesBDTo = myWS3.ExchangeRatesByDateByISO(dt, n4);
            // το πεδίο Rates της δομής είναι σε αυτή τη λειτουργία
            // πίνακας με (όταν υπάρχει) ένα μόνο στοιχείο, το Rates[0]
            if (ExRatesBDFrom.Rates.Length > 0 && ExRatesBDTo.Rates.Length > 0)
            {
                // η ισοτιμία δίνεται στα διάφορα νομίσματα σε διαφορετικές ποσότητες...
                rateFrom = Convert.ToDecimal(ExRatesBDFrom.Rates[0].Rate)/Convert.ToInt32(ExRatesBDFrom.Rates[0].Amount);
                // Βοηθητικές πληροφορίες για να ελέγχουμε την ορθότητα της μετατροπής
                label9.Text = ExRatesBDFrom.Rates[0].Amount;
                label11.Text = ExRatesBDFrom.Rates[0].Rate;
                // και εδώ χρειάζεται αναγωγή στη μονάδα
                rateTo = Convert.ToDecimal(ExRatesBDTo.Rates[0].Rate) /
                Convert.ToInt32(ExRatesBDTo.Rates[0].Amount);
                // Βοηθητικές πληροφορίες για να ελέγχουμε την ορθότητα της μετατροπής
                label10.Text = ExRatesBDTo.Rates[0].Amount;
                label12.Text = ExRatesBDTo.Rates[0].Rate;
                if (rateTo != 0)
                {
                    // ακρίβεια 2 δεκαδικών ψηφίων
                    f = Math.Round(Convert.ToDecimal(TextBox2.Text) *
                   rateFrom / rateTo, 2);
                    label3.Text = Convert.ToString(f);
                }
                else label3.Text = "ΑΔΥΝΑΜΙΑ ΜΕΤΑΤΡΟΠΗΣ";
                label4.Text = ExRatesBDTo.CurrentDate.ToString();
            }
            else label3.Text = "ΑΔΥΝΑΜΙΑ ΜΕΤΑΤΡΟΠΗΣ";
            label4.Text = ExRatesBDTo.CurrentDate.ToString();
        }
    }
}