using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using System.Management;
using System.IO.Ports;

namespace Robtek_V1._1
{



    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private KontrolForm kontrolform;
        private VakumModül vakumModül;
        private GripperForm gripperForm;
   


        public MainForm()
        {
            InitializeComponent();

            panel4.MouseDown += new MouseEventHandler(panel4_MouseDown);
            panel4.MouseMove += new MouseEventHandler(panel4_MouseMove);
            panel4.MouseUp += new MouseEventHandler(panel4_MouseUp);

            

            
            pnlNav.Height = Kontrol_btn.Height;
            pnlNav.Top = Kontrol_btn.Top;
            pnlNav.Left = Kontrol_btn.Left;
            Kontrol_btn.BackColor = Color.FromArgb(46, 51, 73);

            if (kontrolform == null || kontrolform.IsDisposed)
            {
                kontrolform = new KontrolForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Main_panel.Controls.Clear();
                this.Main_panel.Controls.Add(kontrolform);
                kontrolform.Show();
            }
            else
            {
                kontrolform.BringToFront();
            }

        }

        private void Kontrol_btn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Kontrol_btn.Height;
            pnlNav.Top = Kontrol_btn.Top;
            pnlNav.Left = Kontrol_btn.Left;
            Kontrol_btn.BackColor = Color.FromArgb(46, 51, 73);

            if (kontrolform == null || kontrolform.IsDisposed)
            {
                kontrolform = new KontrolForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Main_panel.Controls.Clear();
                this.Main_panel.Controls.Add(kontrolform);
                kontrolform.Show();
            }
            else
            {
                this.Main_panel.Controls.Clear();
                this.Main_panel.Controls.Add(kontrolform);
                kontrolform.BringToFront();
            }

        }



        private void Kontrol_btn_Leave(object sender, EventArgs e)
        {
            Kontrol_btn.BackColor = Color.FromArgb(32, 32, 32);
            
        }

        private void gripper_btn_Click(object sender, EventArgs e)
        {

            pnlNav.Height = gripper_btn.Height;
            pnlNav.Top = gripper_btn.Top;
            gripper_btn.BackColor = Color.FromArgb(46, 51, 73);

            if (gripperForm == null || gripperForm.IsDisposed)
            {
                gripperForm = new GripperForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Main_panel.Controls.Clear();
                this.Main_panel.Controls.Add(gripperForm);
                gripperForm.Show();
            }
            else
            {
                this.Main_panel.Controls.Clear();
                this.Main_panel.Controls.Add(gripperForm);
                gripperForm.BringToFront();
            }

        }

        private void gripper_btn_Leave(object sender, EventArgs e)
        {
            gripper_btn.BackColor = Color.FromArgb(32, 32, 32);
        }

       

       

        private void Vakum_btn_Click(object sender, EventArgs e)
        {

            pnlNav.Height = Vakum_btn.Height;
            pnlNav.Top = Vakum_btn.Top;

            Vakum_btn.BackColor = Color.FromArgb(46, 51, 73);

            if (vakumModül == null || vakumModül.IsDisposed)
            {
                vakumModül = new VakumModül() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Main_panel.Controls.Clear();
                this.Main_panel.Controls.Add(vakumModül);
                vakumModül.Show();
            }
            else
            {
                this.Main_panel.Controls.Clear();
                this.Main_panel.Controls.Add(vakumModül);
                vakumModül.BringToFront();
            }



        }

        private void Vakum_btn_Leave(object sender, EventArgs e)
        {
            Vakum_btn.BackColor = Color.FromArgb(32, 32, 32);
            
        }

        private void magnet_btn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = magnet_btn.Height;
            pnlNav.Top = magnet_btn.Top;

            magnet_btn.BackColor = Color.FromArgb(46, 51, 73);
            
        }


        private void magnet_btn_Leave(object sender, EventArgs e)
        {
            magnet_btn.BackColor = Color.FromArgb(32, 32, 32);
        }

        


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }







        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }




       








    }
}

