using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asclepius_Health_Care___Desktop_App.UserControls.Admin
{
    public partial class AdminMain : UserControl
    {
        public AdminMain()
        {
            InitializeComponent();
            AdminRight ar = new AdminRight();
            panel2.Controls.Add(ar);

            TopSquare ts = new TopSquare();
            panel1.Controls.Add(ts);
        }
    }
}
