using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinformSqliteConf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGate_Click(object sender, EventArgs e)
        {
            // Read key API_IP
            TxtIP.Text = ConfParser.ReadKey("API", "IP");
            // Read key API_Port
            TxtPort.Text = ConfParser.ReadKey("API", "Port");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtIP.Text) || !string.IsNullOrEmpty(TxtPort.Text))
            {
                try
                {
                    // Write key API_IP
                    ConfParser.WriteKey("API", "IP", TxtIP.Text);
                    // Write key API_Port
                    ConfParser.WriteKey("API", "Port", TxtPort.Text);
                    MessageBox.Show("Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Fill the textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}