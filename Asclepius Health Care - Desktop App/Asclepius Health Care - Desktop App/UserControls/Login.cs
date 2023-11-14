using Asclepius_Health_Care___Desktop_App.Services;
using Asclepius_Health_Care___Desktop_App.SessionData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asclepius_Health_Care___Desktop_App.UserControls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        public event EventHandler LoginSuccessful;

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication auth = new Authentication();
            SessionDatas.Role = auth.Login(textBox1.Text, textBox2.Text);

            if (SessionDatas.Role == null)
            {
                MessageBox.Show("Invalid Login!");
            }         
            else
            {
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
