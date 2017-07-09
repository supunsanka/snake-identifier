using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeIdApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAppear_Click(object sender, EventArgs e)
        {
            SearchByApp frm = new SearchByApp();
            LoadPage(frm);
            //frm.ShowDialog();
        }

        private void LoadPage(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = HomePanel.Panel2.BackColor;
            HomePanel.Panel2.Controls.Add(form);
            form.Show();
            this.Text = form.Text;
        }
    }
}
