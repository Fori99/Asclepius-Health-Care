using Asclepius_Health_Care___Desktop_App.SessionData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asclepius_Health_Care___Desktop_App.UserControls
{
    public partial class TopSquare : UserControl
    {
        public TopSquare()
        {
            InitializeComponent();

            string imagePath = "";

            if (SessionDatas.Role == "admin")
            {
                //imagePath = Path.Combine(Application.StartupPath, "Images", $"admin_icon.png");
                imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Images\admin_icon.png");
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                label1.Text = SessionDatas.FullName;
                int leftPosition = (200 - label1.Width) / 2;
                label1.Left = leftPosition;
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
