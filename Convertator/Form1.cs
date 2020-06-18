using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void UnputTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            e.Handled = true;
        }
        private void UnputTBox_TextChanged(object sender, EventArgs e)
        {
            if (Unput_TBox.Text.Length == 0)
                Done_Button.Enabled = false;
            else
                Done_Button.Enabled = true;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            double doubleVariable = Convert.ToDouble(Unput_TBox.Text);
            double itog = 0;
            switch (TwoCBox.SelectedIndex)
            {
                case 0: itog = doubleVariable * 1; break; // миллиметры
                case 1: itog = doubleVariable * 10; break; // сантиметры
                case 2: itog = doubleVariable * 1000; break; // метры
                case 3: itog = doubleVariable * 1000000; break; // километры
            }
            FinalLabel.Text = "Итог: " + itog + "";
        }
    }
}