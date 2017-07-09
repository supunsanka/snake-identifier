using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeIdApp
{
    public partial class SearchByApp : Form
    {
        public SearchByApp()
        {
            InitializeComponent();
            FillColors();
        }

        private void FillColors()
        {
            colorPickerEye.AddStandardColors();
            colorPickerTougue.AddStandardColors();
            colorPickerWound.AddStandardColors();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadPage(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = splitContainer1.Panel2.BackColor;
            splitContainer1.Panel2.Controls.Add(form);
            form.Show();
            this.Text = form.Text;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            Color eye = colorPickerEye.SelectedItem == null ? Color.Empty : colorPickerEye.SelectedItem.Color;
            Color tounge = colorPickerTougue.SelectedItem == null ? Color.Empty : colorPickerTougue.SelectedItem.Color;
            Color wound = colorPickerWound.SelectedItem == null ? Color.Empty : colorPickerWound.SelectedItem.Color;
            List<string> snakes= PredictSnake.GetInstance().GetSnake(eye, tounge, wound, new List<string>(Regex.Split(txtSwell.Text, Environment.NewLine)), new List<string>(Regex.Split(txtSymp.Text, Environment.NewLine)));

            if (snakes.ToArray().Count() == 0)
            {
                MessageBox.Show("Unable to Determine Snake");
            }
           // else if (snakes.ToArray().Count() == 1)
           // {
           //     SnakeInfo win = new SnakeInfo(snakes.First());
           //     LoadPage(win);
           // }
            else
            {
                /*string message = "More than one snake match the search." + Environment.NewLine + "Probale snakes: " + snakes.Aggregate((prev, next) => prev + " or " + next);
                if (MessageBox.Show(message, "Multiple possiblities", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (string snake in snakes)
                    {
                        SnakeInfo win = new SnakeInfo(snake);
                        win.Show();
                    }
                }*/
                SnakeInfo win = new SnakeInfo(snakes.First());
                LoadPage(win);
            }
        }
    }
}
