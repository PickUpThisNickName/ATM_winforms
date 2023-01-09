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
    public partial class SetCash : Form
    {

        public ATM _atm;
        public List<List<string>> arr = new List<List<string>>();

        public SetCash(ATM atm)
        {
            _atm = atm;
            InitializeComponent();
            foreach (var item in _atm.GetBancnotesType())
                comboBox1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                ListViewItem lv1 = new ListViewItem(new string[] { 
                    comboBox1.SelectedItem.ToString(), numericUpDown1.Value.ToString() });
                listView1.Items.Add(lv1);
            }
            else
                MessageBox.Show("Не выбран номинал купюры");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string Nom = listView1.Items[i].SubItems[0].Text;
                    string Col = listView1.Items[i].SubItems[1].Text;
                    arr.Add(new List<string>() { Nom, Col });
                    _atm.AddCash(arr);
                    this.Close();
                }
            }
            else
                MessageBox.Show("В списке нет ни одного элемента");
        }
    }
}
