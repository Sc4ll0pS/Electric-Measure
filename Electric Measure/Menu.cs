using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Electric_Measure
{

    public partial class Menu : Form
    {
        //declaration
        int typeindex;
        int subtypeindex;
        int unit;
        int opunit;
        int dmunit;
        int dmopunit;
        int ppunit;
        double ft;
        double basecost;
        double service;
        double vat;
        double totalcost;

        //automatic subtype
        Dictionary<string, List<string>> subTypeOptions = new Dictionary<string, List<string>>()
        {
            { "Type 1 Residential Service", new List<string> { "1.1 Normal tariff with consumption not exceeding 150 kWh per month", "1.2 Normal tariff with consuption exceeeding 150 kWh per month", "1.3 Time of Use Tariff : TOU Tariff" } },
            { "Type 2 Small General Service", new List<string> { "2.1 Normal tariff", "2.2 Time of Use Tariff : TOU Tariff" } },
            { "Type 3 Medium General Service", new List<string> { "3.1 Normal Tariff", "3.2 Time of Use Tariff : TOU Tariff" } },
            { "Type 4 Large General Service", new List<string> { "4.1 Large general service on Time of day tariff (TOD tariff)", "4.2 Large general service on Time of Use Tariff (TOU tariff)" } } ,
            { "Type 5 Specific Business Service", new List<string> { "5.1 Specific Business Service on Normal Tariff on Two-Part Tariff", "5.2 Specific Business Service on Time of Use Tariff (TOU tariff)" } },
            { "Type 6 Non-Profit Organizations", new List<string> { "6.1 Government Institutions and non-profit organization on Normal tariff", "6.2 Government Institutions and non-profit organization on Time of Use Tariff (TOU tariff)" } },
            { "Type 7 Water Pumping for Agricultural Purposes", new List<string> { "7.1 Water Pumping for agricultural purposes (Normal tariff)", "7.2 Water Pumping for agricultural purposes (TOU tariff)" } },
            { "Type 8 Temporary Tariff", new List<string> { "Temporary Tariff" } },
        };

        void ShowFinalBill(double basecost, double ft, double service)
        {
            basecost += service;
            vat = (basecost + ft) * 0.07;
            totalcost = Math.Round(basecost + ft + vat, 2);

            MessageBox.Show(
                $"Total = {totalcost} Base Tariff = {basecost} Ft = {ft} Vat = {vat}",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void typedbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = typedbox.SelectedItem?.ToString();


            if (selectedType != null && subTypeOptions.ContainsKey(selectedType))
            {
                subdbox.Items.Clear();
                subdbox.Items.AddRange(subTypeOptions[selectedType].ToArray());
                subdbox.SelectedIndex = 0;
            }
            else
            {
                subdbox.Items.Clear();
            }

            UpdateOffOnPeakVisibility();
            UpdateVoltageVisibility();
        }

        private void subdbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOffOnPeakVisibility();
            UpdateVoltageVisibility();

        }

        private void UpdateOffOnPeakVisibility()
        {
            typeindex = typedbox.SelectedIndex;
            subtypeindex = subdbox.SelectedIndex;
            switch ((typeindex, subtypeindex))
            {
                case (0, 2):
                case (1, 1):
                    txboffpeak.Enabled = true;
                    lboffpeak.Enabled = true;
                    txbdmunit.Enabled = false;
                    txbdmoffpeak.Enabled = false;
                    txbdmpp.Enabled = false;
                    lbdemandtitle.Enabled = false;
                    lbdmoffpeak.Enabled = false;
                    lbdmunit.Enabled = false;
                    lbdmpp.Enabled = false;
                    txbdmpp.Enabled = false;
                    lbdmpp.Enabled = false;
                    break;

                case (2, 0):
                    txboffpeak.Enabled = false;
                    lboffpeak.Enabled = false;
                    txbdmunit.Enabled = true;
                    txbdmoffpeak.Enabled = false;
                    txbdmpp.Enabled = false;
                    lbdemandtitle.Enabled = true;
                    lbdmunit.Enabled = true;
                    lbdmoffpeak.Enabled = false;
                    lbdmpp.Enabled = false;
                    break;

                case (2, 1):
                case (3, 1):
                    txboffpeak.Enabled = true;
                    lboffpeak.Enabled = true;
                    txbdmunit.Enabled = true;
                    txbdmoffpeak.Enabled = false;
                    txbdmpp.Enabled = false;
                    lbdemandtitle.Enabled = true;
                    lbdmunit.Enabled = true;
                    lbdmoffpeak.Enabled = false;
                    lbdmpp.Enabled = false;
                    break;

                case (3, 0):
                    txboffpeak.Enabled = false;
                    lboffpeak.Enabled = false;
                    txbdmunit.Enabled = true;
                    txbdmoffpeak.Enabled = false;
                    txbdmpp.Enabled = true;
                    lbdemandtitle.Enabled = true;
                    lbdmunit.Enabled = true;
                    lbdmoffpeak.Enabled = false;
                    lbdmpp.Enabled = true;
                    break;
                
                default:
                    txboffpeak.Enabled = false;
                    lboffpeak.Enabled = false;
                    lbdemandtitle.Enabled = false;
                    txbdmunit.Enabled = false;
                    txbdmoffpeak.Enabled = false;
                    txbdmpp.Enabled = false;
                    lbdemandtitle.Enabled = false;
                    lbdmoffpeak.Enabled = false;
                    lbdmunit.Enabled = false;
                    lbdmunit.Text = "Units : ";
                    lbunit.Text = "Units :";
                    lbdmpp.Enabled = false;
                    break;
            }
        }

        private void UpdateVoltageVisibility()
        {
            switch ((typeindex, subtypeindex))
            {
                case (0, 2):
                case (1, _):
                case (6, 1):
                    lbvoltage.Visible = true;
                    rd24V.Visible = true;
                    rd12V.Visible = true;
                    rd69V.Visible = false;
                    break;

                case (2, 0):
                case (2, 1):
                case (3, _):
                case (4, _):
                case (5, _):
                    lbvoltage.Visible = true;
                    rd24V.Visible = true;
                    rd12V.Visible = true;
                    rd69V.Visible = true;
                    break;

                default:
                    lbvoltage.Visible = false;
                    rd24V.Visible = false;
                    rd12V.Visible = false;
                    rd69V.Visible = false;
                    break;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbunit.Text) || !Int32.TryParse(txbunit.Text, out unit) || unit == 0)
            {
                MessageBox.Show("Please enter a valid unit greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txboffpeak.Enabled)
            {
                if (string.IsNullOrWhiteSpace(txboffpeak.Text) || !Int32.TryParse(txboffpeak.Text, out opunit) || opunit == 0)
                {
                    MessageBox.Show("Please enter a valid Off Peak number greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (txbdmunit.Enabled)
            {
                if (string.IsNullOrWhiteSpace(txbdmunit.Text) || !Int32.TryParse(txbdmunit.Text, out dmunit) || dmunit == 0)
                {
                    MessageBox.Show("Please enter a valid Demand On Peak greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (txbdmoffpeak.Enabled)
            {
                if (string.IsNullOrWhiteSpace(txbdmoffpeak.Text) || !Int32.TryParse(txbdmoffpeak.Text, out dmopunit) || dmopunit == 0)
                {
                    MessageBox.Show("Please enter a valid Demand Off Peak greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (txbdmpp.Enabled) 
            {
                if (string.IsNullOrWhiteSpace(txbdmpp.Text) || !Int32.TryParse(txbdmpp.Text, out ppunit) || ppunit == 0)
                {
                    MessageBox.Show("Please enter a valid Partial Peak number greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Action[] typeCalcs = { typ1cal, typ2cal, typ3cal, typ4cal, typ5cal, typ6cal, typ7cal, typ8cal };
            if (typeindex >= 0 && typeindex <= 7)
            {
                typeCalcs[typeindex]?.Invoke();
            }

            else 
            { 
                MessageBox.Show("Please select type!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void typ1cal()
        {
            if (subdbox.SelectedIndex == 0)
            {
                service = 8.19;
                ft = unit * 0.20;
                basecost = 0;
                int remaining = unit;

                var tiers = new List<(int limit, double rate)>
                {
                    (15,  2.3488),
                    (10,  2.9882),
                    (10,  3.2405),
                    (65,  3.6237),
                    (50,  3.7171),
                    (250, 4.2218),
                    (int.MaxValue, 4.4217)
                };

                foreach (var (limit, rate) in tiers)
                {
                    if (remaining <= 0) break;

                    int used = Math.Min(remaining, limit);
                    basecost += used * rate;
                    remaining -= used;
                }

                ShowFinalBill(basecost, ft, service);

            }

            else if (subdbox.SelectedIndex == 1)
            {
                service = 24.62;
                ft = unit * 0.20;
                basecost = 0;
                int remaining = unit;

                var tiers = new List<(int limit, double rate)>
                {
                    (150,  3.2484),
                    (250,  4.2218),
                    (int.MaxValue, 4.4217)
                };

                foreach (var (limit, rate) in tiers)
                {
                    if (remaining <= 0) break;

                    int used = Math.Min(remaining, limit);
                    basecost += used * rate;
                    remaining -= used;
                }

                ShowFinalBill(basecost, ft, service);

            }

            else if (subdbox.SelectedIndex == 2)
            {
                if (rd24V.Checked)
                {
                    service = 312.24;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 5.1135) + (opunit * 2.6037);

                    ShowFinalBill(basecost, ft, service);
                    rd24V.Checked = false;
                }

                if (rd12V.Checked)
                {
                    service = 24.62;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 5.7982) + (opunit * 2.6369);

                    ShowFinalBill(basecost, ft, service);
                    rd12V.Checked = false;
                }
            }
        }

        private void typ2cal()
        {
            if (subdbox.SelectedIndex == 0)
            {
                if (rd24V.Checked)
                {
                    service = 312.24;
                    ft = (unit) * 0.20;
                    basecost = (unit * 3.9086);

                    ShowFinalBill(basecost, ft, service);
                    rd24V.Checked = false;
                }

                else if (rd12V.Checked)
                {
                    service = 33.29;
                    ft = unit * 0.20;
                    basecost = 0;
                    int remaining = unit;

                    var tiers = new List<(int limit, double rate)>
                    {
                    (150,  3.2484),
                    (250,  4.2218),
                    (int.MaxValue, 4.4217)
                     };

                    foreach (var (limit, rate) in tiers)
                    {
                        if (remaining <= 0) break;

                        int used = Math.Min(remaining, limit);
                        basecost += used * rate;
                        remaining -= used;
                    }

                    ShowFinalBill(basecost, ft, service);
                    rd12V.Checked = false;
                }
            }

            else if (subdbox.SelectedIndex == 1)
            {
                if (rd24V.Checked)
                {
                    service = 312.24;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 5.1135) + (opunit * 2.6037);

                    ShowFinalBill(basecost, ft, service);
                    rd24V.Checked = false;
                }

                else if (rd12V.Checked)
                {
                    service = 33.29;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 5.7982) + (opunit * 2.6369);

                    ShowFinalBill(basecost, ft, service);
                    rd12V.Checked = false;
                }

            }
        }

        private void typ3cal()
        {
            if (subdbox.SelectedIndex == 0)
            {
                if (rd12V.Checked)
                {
                    service = 312.24;
                    ft = (unit) * 0.20;
                    basecost = (unit * 3.1751) + (dmunit * 221.50);
                    ShowFinalBill(basecost, ft, service);
                }

                else if (rd24V.Checked)
                {
                    service = 312.24;
                    ft = (unit) * 0.20;
                    basecost = (unit * 3.1471) + (dmunit * 196.26);

                    ShowFinalBill(basecost, ft, service);
                }

                else if (rd69V.Checked)
                {
                    service = 312.24;
                    ft = (unit) * 0.20;
                    basecost = (unit * 3.1097) + (dmunit * 175.70);

                    ShowFinalBill(basecost, ft, service);
                }
            }

            else if (subdbox.SelectedIndex == 1)
            {
                if (rd12V.Checked)
                {
                    service = 312.24;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 4.3297) + (opunit * 2.6369) + (dmunit * 210.00);

                    ShowFinalBill(basecost, ft, service);
                }

                else if (rd24V.Checked)
                {
                    service = 312.24;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 4.1839) + (opunit * 2.6037) + (dmunit * 132.93);

                    ShowFinalBill(basecost, ft, service);
                }

                else if (rd69V.Checked)
                {
                    service = 312.24;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 4.1025) + (opunit * 2.5849) + (dmunit * 74.14);

                    ShowFinalBill(basecost, ft, service);
                }
            }
        }
        private void typ4cal()
        {
            if (subdbox.SelectedIndex == 0)
            {
                if (rd12V.Checked)
                {
                    service = 312.24;
                    ft = (unit) * 0.20;
                    basecost = (unit * 3.1751) + (dmunit * 332.71);

                    if (ppunit > unit)
                    {
                        basecost += (ppunit - unit) * 68.22;
                    }

                    ShowFinalBill(basecost, ft, service);
                }

                else if (rd24V.Checked)
                {
                    service = 312.24;
                    ft = (unit) * 0.20;
                    basecost = (unit * 3.1471) + (dmunit * 285.05);

                    if (ppunit > unit)
                    {
                        basecost += (ppunit - unit) * 58.88;
                    }

                    ShowFinalBill(basecost, ft, service);
                }

                else if (rd69V.Checked)
                {
                    service = 312.24;
                    ft = (unit) * 0.20;
                    basecost = (unit * 3.1097) + (dmunit * 224.30);

                    if (ppunit > unit)
                    {
                        basecost += (ppunit - unit) * 29.91;
                    }

                    ShowFinalBill(basecost, ft, service);
                }
            }

            else if (subdbox.SelectedIndex == 1)
            {
                if (rd12V.Checked)
                {
                    service = 312.24;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 4.3297) + (opunit * 2.6369) + (dmunit * 210.00);

                    ShowFinalBill(basecost, ft, service);
                }

                else if (rd24V.Checked)
                {
                    service = 312.24;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 4.1839) + (opunit * 2.6037) + (dmunit * 132.93);

                    ShowFinalBill(basecost, ft, service);
                }

                else if (rd69V.Checked)
                {
                    service = 312.24;
                    ft = (unit + opunit) * 0.20;
                    basecost = (unit * 4.1025) + (opunit * 2.5849) + (dmunit * 74.14);

                    ShowFinalBill(basecost, ft, service);
                }
            }
        }

        private void typ5cal()
        {

        }

        private void typ6cal()
        {

        }

        private void typ7cal()
        {

        }

        private void typ8cal()
        {

        }

    }
}
