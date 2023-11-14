using Asclepius_Health_Care___Desktop_App.SessionData;
using Asclepius_Health_Care___Desktop_App.UserControls;
using Asclepius_Health_Care___Desktop_App.UserControls.Admin;
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

            login_user_control.LoginSuccessful += OnLoginSuccessful;
        }

        private void OnLoginSuccessful(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            if(SessionDatas.Role == "admin")
            {
                AdminMain am = new AdminMain();
                panel1.Controls.Add(am);
            }
            else if (SessionDatas.Role == "doctor")
            {

            }
            else if (SessionDatas.Role == "frontdesk")
            {

            }
            else if (SessionDatas.Role == "laboratory")
            {

            }
        }
    }
}
