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
    public partial class GetForm : Form
    {
        public ATM _atm;
        public GetForm(ATM atm)
        {
            InitializeComponent();
            _atm = atm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(numericUpDown1.Value.ToString());
            if (sum <= _atm.GetBalance())
            {
                GetCash getCash = new GetCash(_atm, sum, radioButton2.Checked);
                getCash.ShowDialog();
                _atm = getCash._atm;
                if (getCash.ok)
                    MessageBox.Show("Вы забрали деньги, ваш баланс уменьшился");
                else
                    MessageBox.Show("Вы не забрали деньги, ваш баланс не изменился");
                this.Close();
            }
            else
                MessageBox.Show("На счете недостаточно средств для выдачи запрошенной суммы");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
