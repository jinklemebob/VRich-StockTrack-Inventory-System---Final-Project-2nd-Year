using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2ndYear
{
    
    public partial class ucDashboard : UserControl
    {
        public String Username;

        public ucDashboard()
        {
            InitializeComponent();
        }
        public ucDashboard(String Username)
        {

            InitializeComponent();
            this.Username = Username;
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome, " + Username + "!";
        }
    }
}
