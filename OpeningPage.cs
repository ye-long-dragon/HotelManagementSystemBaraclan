using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace HotelManagementSystemBaraclan
{
    public partial class Main : KryptonForm
    {

        /*
        128, 0, 0 - Maroon - 800000
        159, 6, 6 - Dark Red - 9F0606
        252, 171, 16 - Dandelion - FCAB10
        255, 215, 0 - Yellow - FFD700
        255, 250, 224 - Eggshell White - FFFAE0
        255, 255, 255 - White - FFFFFF
         */




        public Main()
        {
            InitializeComponent();
            Log_inPage log_InPage1 = new Log_inPage();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            log_inPage1.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void managementButton_Click(object sender, EventArgs e)
        {

            log_inPage1.Show();
            startLabel1.Hide();
            startLabel2.Hide();
            userKrypton.Hide();
            managementButton.Hide();
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = Color.FromArgb(0, 128, 0, 0);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = Color.FromArgb(0, 128, 0, 0);

        }
    }
}

