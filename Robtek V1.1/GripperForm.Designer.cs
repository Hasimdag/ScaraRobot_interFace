﻿namespace Robtek_V1._1
{
    partial class GripperForm
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
            this.move_listview = new System.Windows.Forms.ListView();
            this.loop_label = new System.Windows.Forms.Label();
            this.timeout_texbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x_axis_text_Side = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.y_axis_text_Side = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.z_axis_text_Side = new System.Windows.Forms.TextBox();
            this.move_button = new System.Windows.Forms.Button();
            this.pozisyon_ekle_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.run_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.item_delete_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.jointslider1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.jointslider3 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.jointslider4 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.jointslider2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.jointspeedslider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.jointaccelerationslider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.jointgripperslider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.j1label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.j2label = new System.Windows.Forms.Label();
            this.j3label = new System.Windows.Forms.Label();
            this.j4label = new System.Windows.Forms.Label();
            this.gripperlabel = new System.Windows.Forms.Label();
            this.accelerationlabel = new System.Windows.Forms.Label();
            this.speedlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // move_listview
            // 
            this.move_listview.CheckBoxes = true;
            this.move_listview.FullRowSelect = true;
            this.move_listview.GridLines = true;
            this.move_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.move_listview.HideSelection = false;
            this.move_listview.Location = new System.Drawing.Point(8, 361);
            this.move_listview.Name = "move_listview";
            this.move_listview.Size = new System.Drawing.Size(1212, 342);
            this.move_listview.TabIndex = 0;
            this.move_listview.UseCompatibleStateImageBehavior = false;
            this.move_listview.View = System.Windows.Forms.View.Details;
            // 
            // loop_label
            // 
            this.loop_label.AutoSize = true;
            this.loop_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loop_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loop_label.ForeColor = System.Drawing.SystemColors.Control;
            this.loop_label.Location = new System.Drawing.Point(935, 292);
            this.loop_label.Name = "loop_label";
            this.loop_label.Size = new System.Drawing.Size(106, 17);
            this.loop_label.TabIndex = 6;
            this.loop_label.Text = "Bekleme Süresi";
            // 
            // timeout_texbox
            // 
            this.timeout_texbox.Location = new System.Drawing.Point(952, 312);
            this.timeout_texbox.Multiline = true;
            this.timeout_texbox.Name = "timeout_texbox";
            this.timeout_texbox.Size = new System.Drawing.Size(70, 19);
            this.timeout_texbox.TabIndex = 7;
            this.timeout_texbox.Text = "0";
            this.timeout_texbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeout_texbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeout_texbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pozisyonları Ayarla";
            // 
            // x_axis_text_Side
            // 
            this.x_axis_text_Side.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.x_axis_text_Side.Location = new System.Drawing.Point(718, 79);
            this.x_axis_text_Side.Multiline = true;
            this.x_axis_text_Side.Name = "x_axis_text_Side";
            this.x_axis_text_Side.Size = new System.Drawing.Size(100, 27);
            this.x_axis_text_Side.TabIndex = 9;
            this.x_axis_text_Side.Text = "5";
            this.x_axis_text_Side.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x_axis_text_Side.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x_axis_text_Side_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(651, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "X axis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(843, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Y axis:";
            // 
            // y_axis_text_Side
            // 
            this.y_axis_text_Side.Location = new System.Drawing.Point(900, 79);
            this.y_axis_text_Side.Multiline = true;
            this.y_axis_text_Side.Name = "y_axis_text_Side";
            this.y_axis_text_Side.Size = new System.Drawing.Size(100, 27);
            this.y_axis_text_Side.TabIndex = 12;
            this.y_axis_text_Side.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y_axis_text_Side_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1025, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Z axis:";
            // 
            // z_axis_text_Side
            // 
            this.z_axis_text_Side.Location = new System.Drawing.Point(1096, 79);
            this.z_axis_text_Side.Multiline = true;
            this.z_axis_text_Side.Name = "z_axis_text_Side";
            this.z_axis_text_Side.Size = new System.Drawing.Size(100, 27);
            this.z_axis_text_Side.TabIndex = 14;
            this.z_axis_text_Side.KeyDown += new System.Windows.Forms.KeyEventHandler(this.z_axis_text_Side_KeyDown);
            // 
            // move_button
            // 
            this.move_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.move_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.move_button.ForeColor = System.Drawing.SystemColors.Control;
            this.move_button.Location = new System.Drawing.Point(718, 140);
            this.move_button.Name = "move_button";
            this.move_button.Size = new System.Drawing.Size(342, 41);
            this.move_button.TabIndex = 16;
            this.move_button.Text = "Pozisyona Hareket Et";
            this.move_button.UseVisualStyleBackColor = false;
            this.move_button.Click += new System.EventHandler(this.button7_Click);
            // 
            // pozisyon_ekle_button
            // 
            this.pozisyon_ekle_button.BackColor = System.Drawing.Color.White;
            this.pozisyon_ekle_button.Image = global::Robtek_V1._1.Properties.Resources.add;
            this.pozisyon_ekle_button.Location = new System.Drawing.Point(1117, 130);
            this.pozisyon_ekle_button.Name = "pozisyon_ekle_button";
            this.pozisyon_ekle_button.Size = new System.Drawing.Size(56, 51);
            this.pozisyon_ekle_button.TabIndex = 15;
            this.pozisyon_ekle_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pozisyon_ekle_button.UseVisualStyleBackColor = false;
            this.pozisyon_ekle_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Image = global::Robtek_V1._1.Properties.Resources.open_folder;
            this.button5.Location = new System.Drawing.Point(803, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 5;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Image = global::Robtek_V1._1.Properties.Resources.save1;
            this.button4.Location = new System.Drawing.Point(737, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 4;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // run_button
            // 
            this.run_button.BackColor = System.Drawing.Color.White;
            this.run_button.Image = global::Robtek_V1._1.Properties.Resources.play;
            this.run_button.Location = new System.Drawing.Point(1050, 275);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(60, 60);
            this.run_button.TabIndex = 3;
            this.run_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.run_button.UseVisualStyleBackColor = false;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.Silver;
            this.stop_button.Enabled = false;
            this.stop_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stop_button.Image = global::Robtek_V1._1.Properties.Resources.pause__2_;
            this.stop_button.Location = new System.Drawing.Point(1116, 275);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(60, 60);
            this.stop_button.TabIndex = 2;
            this.stop_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // item_delete_button
            // 
            this.item_delete_button.BackColor = System.Drawing.Color.White;
            this.item_delete_button.Image = global::Robtek_V1._1.Properties.Resources.delete;
            this.item_delete_button.Location = new System.Drawing.Point(869, 275);
            this.item_delete_button.Name = "item_delete_button";
            this.item_delete_button.Size = new System.Drawing.Size(60, 60);
            this.item_delete_button.TabIndex = 1;
            this.item_delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.item_delete_button.UseVisualStyleBackColor = false;
            this.item_delete_button.Click += new System.EventHandler(this.item_delete_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(1093, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pozisyonu Ekle";
            // 
            // jointslider1
            // 
            this.jointslider1.BackColor = System.Drawing.Color.Transparent;
            this.jointslider1.Location = new System.Drawing.Point(42, 79);
            this.jointslider1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.jointslider1.Maximum = 266;
            this.jointslider1.Minimum = -90;
            this.jointslider1.Name = "jointslider1";
            this.jointslider1.Size = new System.Drawing.Size(277, 31);
            this.jointslider1.TabIndex = 18;
            this.jointslider1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jointslider1.Value = 0;
            this.jointslider1.ValueChanged += new System.EventHandler(this.jointslider1_ValueChanged);
            // 
            // jointslider3
            // 
            this.jointslider3.BackColor = System.Drawing.Color.Transparent;
            this.jointslider3.Location = new System.Drawing.Point(42, 236);
            this.jointslider3.Maximum = 162;
            this.jointslider3.Minimum = -162;
            this.jointslider3.Name = "jointslider3";
            this.jointslider3.Size = new System.Drawing.Size(277, 31);
            this.jointslider3.TabIndex = 19;
            this.jointslider3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jointslider3.Value = 0;
            this.jointslider3.ValueChanged += new System.EventHandler(this.jointslider3_ValueChanged);
            // 
            // jointslider4
            // 
            this.jointslider4.BackColor = System.Drawing.Color.Transparent;
            this.jointslider4.Location = new System.Drawing.Point(42, 304);
            this.jointslider4.Maximum = 150;
            this.jointslider4.Name = "jointslider4";
            this.jointslider4.Size = new System.Drawing.Size(277, 31);
            this.jointslider4.TabIndex = 21;
            this.jointslider4.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jointslider4.Value = 0;
            this.jointslider4.ValueChanged += new System.EventHandler(this.jointslider4_ValueChanged);
            // 
            // jointslider2
            // 
            this.jointslider2.BackColor = System.Drawing.Color.Transparent;
            this.jointslider2.Location = new System.Drawing.Point(42, 153);
            this.jointslider2.Maximum = 150;
            this.jointslider2.Minimum = -150;
            this.jointslider2.Name = "jointslider2";
            this.jointslider2.Size = new System.Drawing.Size(277, 31);
            this.jointslider2.TabIndex = 20;
            this.jointslider2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jointslider2.Value = 0;
            this.jointslider2.ValueChanged += new System.EventHandler(this.jointslider2_ValueChanged);
            // 
            // jointspeedslider
            // 
            this.jointspeedslider.BackColor = System.Drawing.Color.Transparent;
            this.jointspeedslider.Location = new System.Drawing.Point(387, 304);
            this.jointspeedslider.Maximum = 4000;
            this.jointspeedslider.Minimum = 500;
            this.jointspeedslider.Name = "jointspeedslider";
            this.jointspeedslider.Size = new System.Drawing.Size(277, 31);
            this.jointspeedslider.TabIndex = 23;
            this.jointspeedslider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jointspeedslider.Value = 500;
            this.jointspeedslider.ValueChanged += new System.EventHandler(this.jointspeedslider_ValueChanged);
            // 
            // jointaccelerationslider
            // 
            this.jointaccelerationslider.BackColor = System.Drawing.Color.Transparent;
            this.jointaccelerationslider.Location = new System.Drawing.Point(387, 230);
            this.jointaccelerationslider.Maximum = 4000;
            this.jointaccelerationslider.Minimum = 500;
            this.jointaccelerationslider.Name = "jointaccelerationslider";
            this.jointaccelerationslider.Size = new System.Drawing.Size(277, 37);
            this.jointaccelerationslider.TabIndex = 22;
            this.jointaccelerationslider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jointaccelerationslider.Value = 500;
            this.jointaccelerationslider.ValueChanged += new System.EventHandler(this.jointaccelerationslider_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(132, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "1. eksen Kontrolü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(132, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "2. eksen Kontrolü :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(132, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "3. eksen Kontrolü :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(132, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Dikey Mil Kontrolü :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(520, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Hız";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(504, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Hızlanma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(481, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Tutucu Seviyesi";
            // 
            // jointgripperslider
            // 
            this.jointgripperslider.BackColor = System.Drawing.Color.Transparent;
            this.jointgripperslider.Location = new System.Drawing.Point(387, 139);
            this.jointgripperslider.Name = "jointgripperslider";
            this.jointgripperslider.Size = new System.Drawing.Size(277, 30);
            this.jointgripperslider.TabIndex = 30;
            this.jointgripperslider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jointgripperslider.Value = 100;
            this.jointgripperslider.ValueChanged += new System.EventHandler(this.jointgripperslider_Scroll);
            // 
            // j1label
            // 
            this.j1label.AutoSize = true;
            this.j1label.ForeColor = System.Drawing.Color.White;
            this.j1label.Location = new System.Drawing.Point(337, 90);
            this.j1label.Name = "j1label";
            this.j1label.Size = new System.Drawing.Size(32, 16);
            this.j1label.TabIndex = 32;
            this.j1label.Text = "-266";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(316, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Bar Değeri:";
            // 
            // j2label
            // 
            this.j2label.AutoSize = true;
            this.j2label.ForeColor = System.Drawing.Color.White;
            this.j2label.Location = new System.Drawing.Point(337, 165);
            this.j2label.Name = "j2label";
            this.j2label.Size = new System.Drawing.Size(32, 16);
            this.j2label.TabIndex = 34;
            this.j2label.Text = "-266";
            // 
            // j3label
            // 
            this.j3label.AutoSize = true;
            this.j3label.ForeColor = System.Drawing.Color.White;
            this.j3label.Location = new System.Drawing.Point(337, 242);
            this.j3label.Name = "j3label";
            this.j3label.Size = new System.Drawing.Size(32, 16);
            this.j3label.TabIndex = 35;
            this.j3label.Text = "-266";
            // 
            // j4label
            // 
            this.j4label.AutoSize = true;
            this.j4label.ForeColor = System.Drawing.Color.White;
            this.j4label.Location = new System.Drawing.Point(337, 312);
            this.j4label.Name = "j4label";
            this.j4label.Size = new System.Drawing.Size(32, 16);
            this.j4label.TabIndex = 36;
            this.j4label.Text = "-266";
            // 
            // gripperlabel
            // 
            this.gripperlabel.AutoSize = true;
            this.gripperlabel.ForeColor = System.Drawing.Color.White;
            this.gripperlabel.Location = new System.Drawing.Point(680, 147);
            this.gripperlabel.Name = "gripperlabel";
            this.gripperlabel.Size = new System.Drawing.Size(32, 16);
            this.gripperlabel.TabIndex = 37;
            this.gripperlabel.Text = "-266";
            // 
            // accelerationlabel
            // 
            this.accelerationlabel.AutoSize = true;
            this.accelerationlabel.ForeColor = System.Drawing.Color.White;
            this.accelerationlabel.Location = new System.Drawing.Point(680, 236);
            this.accelerationlabel.Name = "accelerationlabel";
            this.accelerationlabel.Size = new System.Drawing.Size(32, 16);
            this.accelerationlabel.TabIndex = 38;
            this.accelerationlabel.Text = "-266";
            // 
            // speedlabel
            // 
            this.speedlabel.AutoSize = true;
            this.speedlabel.ForeColor = System.Drawing.Color.White;
            this.speedlabel.Location = new System.Drawing.Point(680, 315);
            this.speedlabel.Name = "speedlabel";
            this.speedlabel.Size = new System.Drawing.Size(32, 16);
            this.speedlabel.TabIndex = 39;
            this.speedlabel.Text = "-266";
            // 
            // GripperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 715);
            this.Controls.Add(this.speedlabel);
            this.Controls.Add(this.accelerationlabel);
            this.Controls.Add(this.gripperlabel);
            this.Controls.Add(this.j4label);
            this.Controls.Add(this.j3label);
            this.Controls.Add(this.j2label);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.j1label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.jointgripperslider);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jointspeedslider);
            this.Controls.Add(this.jointaccelerationslider);
            this.Controls.Add(this.jointslider4);
            this.Controls.Add(this.jointslider2);
            this.Controls.Add(this.jointslider3);
            this.Controls.Add(this.jointslider1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.move_button);
            this.Controls.Add(this.pozisyon_ekle_button);
            this.Controls.Add(this.z_axis_text_Side);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.y_axis_text_Side);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x_axis_text_Side);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeout_texbox);
            this.Controls.Add(this.loop_label);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.item_delete_button);
            this.Controls.Add(this.move_listview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GripperForm";
            this.Text = "GripperForm";
            this.Load += new System.EventHandler(this.GripperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListView move_listview;
        private System.Windows.Forms.Button item_delete_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label loop_label;
        private System.Windows.Forms.TextBox timeout_texbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x_axis_text_Side;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox y_axis_text_Side;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox z_axis_text_Side;
        private System.Windows.Forms.Button pozisyon_ekle_button;
        private System.Windows.Forms.Button move_button;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TrackBar jointslider1;
        private Guna.UI2.WinForms.Guna2TrackBar jointslider3;
        private Guna.UI2.WinForms.Guna2TrackBar jointslider4;
        private Guna.UI2.WinForms.Guna2TrackBar jointslider2;
        private Guna.UI2.WinForms.Guna2TrackBar jointspeedslider;
        private Guna.UI2.WinForms.Guna2TrackBar jointaccelerationslider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TrackBar jointgripperslider;
        private System.Windows.Forms.Label j1label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label j2label;
        private System.Windows.Forms.Label j3label;
        private System.Windows.Forms.Label j4label;
        private System.Windows.Forms.Label gripperlabel;
        private System.Windows.Forms.Label accelerationlabel;
        private System.Windows.Forms.Label speedlabel;
    }
}