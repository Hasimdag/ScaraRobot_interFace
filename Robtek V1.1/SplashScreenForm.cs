using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robtek_V1._1
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();


            
           
            
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = (BackColor);
        }
    }
}
