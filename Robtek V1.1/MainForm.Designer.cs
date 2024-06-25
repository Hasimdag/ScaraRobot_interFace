namespace Robtek_V1._1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.magnet_btn = new System.Windows.Forms.Button();
            this.gripper_btn = new System.Windows.Forms.Button();
            this.Vakum_btn = new System.Windows.Forms.Button();
            this.Kontrol_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2TaskBarProgress1 = new Guna.UI2.WinForms.Guna2TaskBarProgress(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.magnet_btn);
            this.panel1.Controls.Add(this.gripper_btn);
            this.panel1.Controls.Add(this.Vakum_btn);
            this.panel1.Controls.Add(this.Kontrol_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 760);
            this.panel1.TabIndex = 3;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 12;
            // 
            // magnet_btn
            // 
            this.magnet_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.magnet_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.magnet_btn.FlatAppearance.BorderSize = 0;
            this.magnet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magnet_btn.ForeColor = System.Drawing.Color.White;
            this.magnet_btn.Image = global::Robtek_V1._1.Properties.Resources.magnet;
            this.magnet_btn.Location = new System.Drawing.Point(0, 361);
            this.magnet_btn.Name = "magnet_btn";
            this.magnet_btn.Size = new System.Drawing.Size(326, 65);
            this.magnet_btn.TabIndex = 11;
            this.magnet_btn.Text = "Mıknatıs Modülü";
            this.magnet_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.magnet_btn.UseVisualStyleBackColor = false;
            this.magnet_btn.Click += new System.EventHandler(this.magnet_btn_Click);
            this.magnet_btn.Leave += new System.EventHandler(this.magnet_btn_Leave);
            // 
            // gripper_btn
            // 
            this.gripper_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gripper_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gripper_btn.FlatAppearance.BorderSize = 0;
            this.gripper_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gripper_btn.ForeColor = System.Drawing.Color.White;
            this.gripper_btn.Image = global::Robtek_V1._1.Properties.Resources.robotic_hand;
            this.gripper_btn.Location = new System.Drawing.Point(0, 296);
            this.gripper_btn.Name = "gripper_btn";
            this.gripper_btn.Size = new System.Drawing.Size(326, 65);
            this.gripper_btn.TabIndex = 10;
            this.gripper_btn.Text = "Gripper Modülü";
            this.gripper_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.gripper_btn.UseVisualStyleBackColor = true;
            this.gripper_btn.Click += new System.EventHandler(this.gripper_btn_Click);
            this.gripper_btn.Leave += new System.EventHandler(this.gripper_btn_Leave);
            // 
            // Vakum_btn
            // 
            this.Vakum_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Vakum_btn.FlatAppearance.BorderSize = 0;
            this.Vakum_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vakum_btn.ForeColor = System.Drawing.Color.White;
            this.Vakum_btn.Image = global::Robtek_V1._1.Properties.Resources.suction_tube;
            this.Vakum_btn.Location = new System.Drawing.Point(0, 231);
            this.Vakum_btn.Name = "Vakum_btn";
            this.Vakum_btn.Size = new System.Drawing.Size(326, 65);
            this.Vakum_btn.TabIndex = 7;
            this.Vakum_btn.Text = "Vakum Modülü";
            this.Vakum_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Vakum_btn.UseVisualStyleBackColor = true;
            this.Vakum_btn.Click += new System.EventHandler(this.Vakum_btn_Click);
            this.Vakum_btn.Leave += new System.EventHandler(this.Vakum_btn_Leave);
            // 
            // Kontrol_btn
            // 
            this.Kontrol_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Kontrol_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kontrol_btn.FlatAppearance.BorderSize = 0;
            this.Kontrol_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kontrol_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Kontrol_btn.Image = global::Robtek_V1._1.Properties.Resources.home;
            this.Kontrol_btn.Location = new System.Drawing.Point(0, 166);
            this.Kontrol_btn.Name = "Kontrol_btn";
            this.Kontrol_btn.Size = new System.Drawing.Size(326, 65);
            this.Kontrol_btn.TabIndex = 6;
            this.Kontrol_btn.Text = "Kontrol Paneli";
            this.Kontrol_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Kontrol_btn.UseVisualStyleBackColor = false;
            this.Kontrol_btn.Click += new System.EventHandler(this.Kontrol_btn_Click);
            this.Kontrol_btn.Leave += new System.EventHandler(this.Kontrol_btn_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 166);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Robtek, A.Ş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Robtek_V1._1.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(40, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main_panel
            // 
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Main_panel.Location = new System.Drawing.Point(326, 42);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(1231, 718);
            this.Main_panel.TabIndex = 6;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1183, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 41);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1132, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 41);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.guna2ControlBox1);
            this.panel4.Controls.Add(this.guna2ControlBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(326, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1231, 46);
            this.panel4.TabIndex = 4;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // guna2TaskBarProgress1
            // 
            this.guna2TaskBarProgress1.TargetForm = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1557, 760);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Kontrol_btn;
        private System.Windows.Forms.Button Vakum_btn;
        private System.Windows.Forms.Button gripper_btn;
        private System.Windows.Forms.Button magnet_btn;
        private System.Windows.Forms.Panel pnlNav;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TaskBarProgress guna2TaskBarProgress1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel Main_panel;
    }
}