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
        private void DoneButton_Click(object sender, EventArgs e)
        {
            double itog = Convert.ToDouble(Unput_TBox.Text);
            #region конвертация милиметров
            if ((FirstCBox.Text == "Квадратные милиметры") && (TwoCBox.Text == "Квадратные милиметры"))
            {
                FinalLabel.Text = itog + " мм в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные милиметры") && (TwoCBox.Text == "Квадратные сантиметры"))
            {
                FinalLabel.Text = (itog / 10) + " cм в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные милиметры") && (TwoCBox.Text == "Квадратные метры"))
            {
                FinalLabel.Text = (itog / 1000) + " м в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные милиметры") && (TwoCBox.Text == "Квадратные километры"))
            {
                FinalLabel.Text = (itog / 1000000) + " км в квадрате";
            }
            #endregion
            #region конвертация сантиметров
            if ((FirstCBox.Text == "Квадратные сантиметры") && (TwoCBox.Text == "Квадратные милиметры"))
            {
                FinalLabel.Text = (itog * 10) + " мм в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные сантиметры") && (TwoCBox.Text == "Квадратные сантиметры"))
            {
                FinalLabel.Text = itog + " cм в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные сантиметры") && (TwoCBox.Text == "Квадратные метры"))
            {
                FinalLabel.Text = (itog * 100) + " м в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные сантиметры") && (TwoCBox.Text == "Квадратные километры"))
            {
                FinalLabel.Text = (itog / 100000) + " км в квадрате";
            }
            #endregion
            #region конвертация метров
            if ((FirstCBox.Text == "Квадратные метры") && (TwoCBox.Text == "Квадратные милиметры"))
            {
                FinalLabel.Text = (itog * 1000) + " мм в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные метры") && (TwoCBox.Text == "Квадратные сантиметры"))
            {
                FinalLabel.Text = (itog * 100) + " cм в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные метры") && (TwoCBox.Text == "Квадратные метры"))
            {
                FinalLabel.Text = itog + " м в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные метры") && (TwoCBox.Text == "Квадратные километры"))
            {
                FinalLabel.Text = (itog / 1000) + " км в квадрате";
            }
            #endregion
            #region конвертация километров
            if ((FirstCBox.Text == "Квадратные километры") && (TwoCBox.Text == "Квадратные милиметры"))
            {
                FinalLabel.Text = (itog * 1000000) + " мм в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные километры") && (TwoCBox.Text == "Квадратные сантиметры"))
            {
                FinalLabel.Text = (itog * 100000) + " cм в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные километры") && (TwoCBox.Text == "Квадратные метры"))
            {
                FinalLabel.Text = (itog * 1000) + " м в квадрате";
            }
            if ((FirstCBox.Text == "Квадратные километры") && (TwoCBox.Text == "Квадратные километры"))
            {
                FinalLabel.Text = itog + " км в квадрате";
            }
            #endregion
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
