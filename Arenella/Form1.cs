using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arenella
{
    public partial class Form1 : Form
    {
        private decimal totalCost;
        private decimal averageRate;
        private decimal revenuePerNight;
        private decimal revenuePerBooking;
        private string report;

        public Form1()
        {
            InitializeComponent();
        }
        private void bolletteUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void pulizieUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void giardiniereUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void manutenzioneUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void piscinaUpDown9_ValueChanged(object sender, EventArgs e)
        {
        }

        private void calcolaButton_Click(object sender, EventArgs e)
        {
            if (engButton.Enabled == true)      CalculateIta();
            else                                CalculateEng();
        }

        private void bookingTotaliUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (nottiPrenotateUpDown6.Value > 0 & bookingTotaliUpDown7.Value > 0)
            {
                esportaButton.Enabled = true;
                calcolaButton.Enabled = true;
            }
        }

        private void nottiPrenotateUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (nottiPrenotateUpDown6.Value > 0 & bookingTotaliUpDown7.Value > 0)
            {
                esportaButton.Enabled = true;
                calcolaButton.Enabled = true;
            }
        }

        private void CalculateIta()
        {
            totalCost += bolletteUpDown1.Value;
            report += "Costo per bollette: " + bolletteUpDown1.Value + "\r\n";
            totalCost += pulizieUpDown2.Value;
            report += "Costo per pulizie: " + pulizieUpDown2.Value + "\r\n";
            totalCost += giardiniereUpDown3.Value;
            report += "Costo per giardiniere: " + giardiniereUpDown3.Value + "\r\n";
            totalCost += manutenzioneUpDown4.Value;
            report += "Costo per manutenzione ordinaria e straordinaria: " + manutenzioneUpDown4.Value + "\r\n";
            totalCost += piscinaUpDown9.Value;
            report += "Costo per piscina: " + piscinaUpDown9.Value + "\r\n";
            averageRate = Math.Round(totalCost / nottiPrenotateUpDown6.Value, 2);
            report += "Costo totale: " + totalCost + "\r\n";
            report += "\r\nSpesa media per notte: " + averageRate + "\r\n";
            report += "\r\nGuadagno al netto delle spese: " + (incassoNettoUpDown5.Value - totalCost) + "\r\n";
            revenuePerNight = (incassoNettoUpDown5.Value - totalCost) / nottiPrenotateUpDown6.Value;
            report += "Guadagno netto per notte prenotata: " + Math.Round(revenuePerNight, 2) + "\r\n";
            report += "Media guadagno per booking: " + Math.Round((incassoNettoUpDown5.Value / bookingTotaliUpDown7.Value), 2) + "\r\n";
            report += "\r\nTariffa consigliata per l'anno prossimo: " + Math.Round((averageRate + revenuePerNight), 2) + "\r\n";
            textBox1.Text = report;
            report = "";
            totalCost = 0;
            averageRate = 0;
            revenuePerNight = 0;

        }

        private void CalculateEng()
        {
            totalCost += bolletteUpDown1.Value;
            report += "Bills cost: " + bolletteUpDown1.Value + "\r\n";
            totalCost += pulizieUpDown2.Value;
            report += "Cleaning cost: " + pulizieUpDown2.Value + "\r\n";
            totalCost += giardiniereUpDown3.Value;
            report += "Gardener cost: " + giardiniereUpDown3.Value + "\r\n";
            totalCost += manutenzioneUpDown4.Value;
            report += "Maintenance cost: " + manutenzioneUpDown4.Value + "\r\n";
            totalCost += piscinaUpDown9.Value;
            report += "Swimming pool cost: " + piscinaUpDown9.Value + "\r\n";
            averageRate = Math.Round(totalCost / nottiPrenotateUpDown6.Value, 2);
            report += "Total cost: " + totalCost + "\r\n";
            report += "\r\nAverage cost per night: " + averageRate + "\r\n";
            report += "\r\nNet revenue (costs deducted): " + (incassoNettoUpDown5.Value - totalCost) + "\r\n";
            revenuePerNight = (incassoNettoUpDown5.Value - totalCost) / nottiPrenotateUpDown6.Value;
            report += "Net revenue per night: " + Math.Round(revenuePerNight, 2) + "\r\n";
            report += "Average revenue per booking: " + Math.Round((incassoNettoUpDown5.Value / bookingTotaliUpDown7.Value), 2) + "\r\n";
            report += "\r\nSuggested rate for next season: " + Math.Round((averageRate + revenuePerNight), 2) + "\r\n";
            textBox1.Text = report;
            report = "";
            totalCost = 0;
            averageRate = 0;
            revenuePerNight = 0;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            bolletteUpDown1.Value = 0;
            pulizieUpDown2.Value = 0;
            giardiniereUpDown3.Value = 0;
            manutenzioneUpDown4.Value = 0;
            piscinaUpDown9.Value = 0;
            incassoNettoUpDown5.Value = 0;
            bookingTotaliUpDown7.Value = 0;
            nottiPrenotateUpDown6.Value = 0;
            calcolaButton.Enabled = false;
            esportaButton.Enabled = false;
            report = "";
            textBox1.Text = "";
            totalCost = 0;
            averageRate = 0;
            revenuePerNight = 0;
        }

        private void itaButton_Click(object sender, EventArgs e)
        {
            SwitchIta();
        }

        private void engButton_Click(object sender, EventArgs e)
        {
            SwitchEng();
        }
        private void SwitchEng()
        {
            engButton.Enabled = false;
            itaButton.Enabled = true;
            bolletteLabel.Text = "Bills";
            pulizieLabel.Text = "Cleaning";
            giardiniere.Text = "Gardener";
            manutenzioneLabel.Text = "Maintenance";
            piscinaLabel.Text = "Swimming pool";
            incassoNettoLabel.Text = "NET Revenue";
            bookinTotaliLabel.Text = "Total bookings";
            nottiPrenotateLabel.Text = "Nights booked (tot)";
            calcolaButton.Text = "Calculate";
            esportaButton.Text = "Export (.txt)";
        }

        private void SwitchIta()
        {
            engButton.Enabled = true;
            itaButton.Enabled = false;
            bolletteLabel.Text = "Bollette";
            pulizieLabel.Text = "Pulizie";
            giardiniere.Text = "Giardiniere";
            manutenzioneLabel.Text = "Manutenzione";
            piscinaLabel.Text = "Piscina";
            incassoNettoLabel.Text = "Incasso netto";
            bookinTotaliLabel.Text = "Booking ricevuti (tot)";
            nottiPrenotateLabel.Text = "Notti prenotate (tot)";
            calcolaButton.Text = "Calcola";
            esportaButton.Text = "Esporta (.txt)";
        }

    }
}
