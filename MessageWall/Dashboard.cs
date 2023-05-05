using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void HelloWorldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {firstNameText.Text}");
            firstNameText.Text = string.Empty;
        }
    }
}
