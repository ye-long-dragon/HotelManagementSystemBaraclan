using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystemBaraclan
{
    public partial class Sign_inScreen : UserControl
    {
        public Sign_inScreen()
        {
            InitializeComponent();
            bool admin = true;
        }
        bool admin = true;

        private void kryptonButton2_MouseHover(object sender, EventArgs e)
        {
            if (admin == true)
            {
                IdentificationPanel.StateCommon.Color1 = Color.FromKnownColor(KnownColor.Gold);
                IdentificationPanel.StateCommon.Color2 = Color.FromKnownColor(KnownColor.Gold);
            }
           
        }
    }
}
