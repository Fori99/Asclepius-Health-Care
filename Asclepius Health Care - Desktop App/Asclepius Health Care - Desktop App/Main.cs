using Asclepius_Health_Care___Desktop_App.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asclepius_Health_Care___Desktop_App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Login login_user_control = new Login();

           panel1.Controls.Add(login_user_control);


        }
    }
}
