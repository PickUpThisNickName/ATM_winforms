using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_winforms
{
    public partial class SetForm : Form
    {
        public ATM _atm;
        public bool Ok = false;
        public SetForm(ATM atm)
        {
            InitializeComponent();
            _atm = atm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetCash cashForm = new SetCash(_atm);
            cashForm.ShowDialog();
            _atm = cashForm._atm;
            List<List<string>> arr = cashForm.arr;

            int lastvalue = 0;
            if (textBox1.Text != "")
                lastvalue = int.Parse(textBox1.Text);
            textBox1.Text = (lastvalue + _atm.CardBalance(arr)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != "")
            {
                _atm.IncrementBalance(int.Parse(textBox1.Text));
                Ok = true;
                this.Close();
            }
            else
                MessageBox.Show("В банкомат не внесено ни одной купюры");
        }

    }
}
