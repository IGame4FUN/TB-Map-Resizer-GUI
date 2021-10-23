
namespace WinFormsApp1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.checkBox_TerrainMap = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_size_x = new System.Windows.Forms.TextBox();
            this.txt_size_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_shift_y = new System.Windows.Forms.TextBox();
            this.txt_shift_x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.HueSDown = new System.Windows.Forms.Button();
            this.SDown = new System.Windows.Forms.Button();
            this.LDown = new System.Windows.Forms.Button();
            this.HueSUp = new System.Windows.Forms.Button();
            this.SUp = new System.Windows.Forms.Button();
            this.LUp = new System.Windows.Forms.Button();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picboxMap = new System.Windows.Forms.PictureBox();
            this.lbl_empty = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_NW = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(43, 380);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(80, 30);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // checkBox_TerrainMap
            // 
            this.checkBox_TerrainMap.AutoSize = true;
            this.checkBox_TerrainMap.Checked = true;
            this.checkBox_TerrainMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TerrainMap.Enabled = false;
            this.checkBox_TerrainMap.ForeColor = System.Drawing.Color.Gray;
            this.checkBox_TerrainMap.Location = new System.Drawing.Point(6, 19);
            this.checkBox_TerrainMap.Name = "checkBox_TerrainMap";
            this.checkBox_TerrainMap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_TerrainMap.Size = new System.Drawing.Size(90, 19);
            this.checkBox_TerrainMap.TabIndex = 1;
            this.checkBox_TerrainMap.Text = "Terrain Map";
            this.checkBox_TerrainMap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_TerrainMap.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox2.Size = new System.Drawing.Size(64, 19);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Entities";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 69);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox3.Size = new System.Drawing.Size(89, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Water Maps";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "fileToDisplay";
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txt_size_x
            // 
            this.txt_size_x.Location = new System.Drawing.Point(25, 346);
            this.txt_size_x.Name = "txt_size_x";
            this.txt_size_x.Size = new System.Drawing.Size(41, 23);
            this.txt_size_x.TabIndex = 9;
            this.txt_size_x.Text = "4";
            this.txt_size_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_size_x.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_size_y
            // 
            this.txt_size_y.Location = new System.Drawing.Point(93, 346);
            this.txt_size_y.Name = "txt_size_y";
            this.txt_size_y.Size = new System.Drawing.Size(41, 23);
            this.txt_size_y.TabIndex = 10;
            this.txt_size_y.Text = "4";
            this.txt_size_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "X:";
            // 
            // txt_shift_y
            // 
            this.txt_shift_y.BackColor = System.Drawing.Color.White;
            this.txt_shift_y.Location = new System.Drawing.Point(93, 317);
            this.txt_shift_y.Name = "txt_shift_y";
            this.txt_shift_y.Size = new System.Drawing.Size(41, 23);
            this.txt_shift_y.TabIndex = 8;
            this.txt_shift_y.Text = "0";
            this.txt_shift_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_shift_x
            // 
            this.txt_shift_x.Location = new System.Drawing.Point(25, 317);
            this.txt_shift_x.Name = "txt_shift_x";
            this.txt_shift_x.Size = new System.Drawing.Size(41, 23);
            this.txt_shift_x.TabIndex = 7;
            this.txt_shift_x.Text = "0";
            this.txt_shift_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Shift";
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = global::TB_Map_Resizer_GUI.Properties.Resources.ArrowLeft;
            this.btnLeft.Location = new System.Drawing.Point(66, 188);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(32, 32);
            this.btnLeft.TabIndex = 19;
            this.btnLeft.TabStop = false;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::TB_Map_Resizer_GUI.Properties.Resources.ArrowRight;
            this.btnRight.Location = new System.Drawing.Point(130, 188);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(32, 32);
            this.btnRight.TabIndex = 0;
            this.btnRight.TabStop = false;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Image = global::TB_Map_Resizer_GUI.Properties.Resources.ArrowUp;
            this.btnUp.Location = new System.Drawing.Point(98, 156);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(32, 32);
            this.btnUp.TabIndex = 21;
            this.btnUp.TabStop = false;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Image = global::TB_Map_Resizer_GUI.Properties.Resources.ArrowDown;
            this.btnDown.Location = new System.Drawing.Point(98, 220);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(32, 32);
            this.btnDown.TabIndex = 22;
            this.btnDown.TabStop = false;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCenter.FlatAppearance.BorderSize = 0;
            this.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter.Image = global::TB_Map_Resizer_GUI.Properties.Resources.Dot2;
            this.btnCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCenter.Location = new System.Drawing.Point(104, 194);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(20, 20);
            this.btnCenter.TabIndex = 23;
            this.btnCenter.TabStop = false;
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // HueSDown
            // 
            this.HueSDown.AccessibleName = "HueDown";
            this.HueSDown.Location = new System.Drawing.Point(109, 45);
            this.HueSDown.Name = "HueSDown";
            this.HueSDown.Size = new System.Drawing.Size(25, 25);
            this.HueSDown.TabIndex = 27;
            this.HueSDown.TabStop = false;
            this.HueSDown.Text = "\\/";
            this.HueSDown.UseVisualStyleBackColor = true;
            this.HueSDown.Click += new System.EventHandler(this.HueSDown_Click);
            // 
            // SDown
            // 
            this.SDown.AccessibleName = "SDOWN";
            this.SDown.Location = new System.Drawing.Point(144, 45);
            this.SDown.Name = "SDown";
            this.SDown.Size = new System.Drawing.Size(25, 25);
            this.SDown.TabIndex = 28;
            this.SDown.TabStop = false;
            this.SDown.Text = "\\/";
            this.SDown.UseVisualStyleBackColor = true;
            this.SDown.Click += new System.EventHandler(this.SDown_Click);
            // 
            // LDown
            // 
            this.LDown.AccessibleName = "LDOWN";
            this.LDown.Location = new System.Drawing.Point(179, 45);
            this.LDown.Name = "LDown";
            this.LDown.Size = new System.Drawing.Size(25, 25);
            this.LDown.TabIndex = 29;
            this.LDown.TabStop = false;
            this.LDown.Text = "\\/";
            this.LDown.UseVisualStyleBackColor = true;
            this.LDown.Click += new System.EventHandler(this.LDown_Click);
            // 
            // HueSUp
            // 
            this.HueSUp.AccessibleName = "HueUp";
            this.HueSUp.Location = new System.Drawing.Point(109, 14);
            this.HueSUp.Name = "HueSUp";
            this.HueSUp.Size = new System.Drawing.Size(25, 25);
            this.HueSUp.TabIndex = 30;
            this.HueSUp.TabStop = false;
            this.HueSUp.Text = "^";
            this.HueSUp.UseVisualStyleBackColor = true;
            this.HueSUp.Click += new System.EventHandler(this.HueSUp_Click);
            // 
            // SUp
            // 
            this.SUp.AccessibleName = "SUP";
            this.SUp.Location = new System.Drawing.Point(144, 14);
            this.SUp.Name = "SUp";
            this.SUp.Size = new System.Drawing.Size(25, 25);
            this.SUp.TabIndex = 31;
            this.SUp.TabStop = false;
            this.SUp.Text = "^";
            this.SUp.UseVisualStyleBackColor = true;
            this.SUp.Click += new System.EventHandler(this.SUp_Click);
            // 
            // LUp
            // 
            this.LUp.AccessibleName = "LUP";
            this.LUp.Location = new System.Drawing.Point(179, 14);
            this.LUp.Name = "LUp";
            this.LUp.Size = new System.Drawing.Size(25, 25);
            this.LUp.TabIndex = 32;
            this.LUp.TabStop = false;
            this.LUp.Text = "^";
            this.LUp.UseVisualStyleBackColor = true;
            this.LUp.Click += new System.EventHandler(this.LUp_Click);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(108, 81);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(29, 23);
            this.txtH.TabIndex = 4;
            this.txtH.Text = "16";
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(143, 81);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(29, 23);
            this.txtS.TabIndex = 5;
            this.txtS.Text = "0.85";
            this.txtS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(178, 81);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(29, 23);
            this.txtL.TabIndex = 6;
            this.txtL.Text = "0.45";
            this.txtL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtL.TextChanged += new System.EventHandler(this.txtL_TextChanged);
            this.txtL.Enter += new System.EventHandler(this.txtL_Enter);
            this.txtL.Leave += new System.EventHandler(this.txtL_Leave);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(178, 346);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(23, 23);
            this.txtHeight.TabIndex = 11;
            this.txtHeight.Text = "0";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "H";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(6, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picboxMap);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1MinSize = 256;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_empty);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.HueSUp);
            this.splitContainer1.Panel2.Controls.Add(this.txtHeight);
            this.splitContainer1.Panel2.Controls.Add(this.SUp);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.btnCenter);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.btnDown);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtS);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnUp);
            this.splitContainer1.Panel2.Controls.Add(this.txt_shift_y);
            this.splitContainer1.Panel2.Controls.Add(this.txtL);
            this.splitContainer1.Panel2.Controls.Add(this.txt_shift_x);
            this.splitContainer1.Panel2.Controls.Add(this.btnRight);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtH);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnLeft);
            this.splitContainer1.Panel2.Controls.Add(this.txt_size_y);
            this.splitContainer1.Panel2.Controls.Add(this.txt_size_x);
            this.splitContainer1.Panel2.Controls.Add(this.LUp);
            this.splitContainer1.Panel2.Controls.Add(this.HueSDown);
            this.splitContainer1.Panel2.Controls.Add(this.btnGenerate);
            this.splitContainer1.Panel2.Controls.Add(this.SDown);
            this.splitContainer1.Panel2.Controls.Add(this.LDown);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox2);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_TerrainMap);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox3);
            this.splitContainer1.Panel2MinSize = 221;
            this.splitContainer1.Size = new System.Drawing.Size(661, 415);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.TabIndex = 38;
            this.splitContainer1.TabStop = false;
            // 
            // picboxMap
            // 
            this.picboxMap.Location = new System.Drawing.Point(9, 8);
            this.picboxMap.Name = "picboxMap";
            this.picboxMap.Size = new System.Drawing.Size(319, 332);
            this.picboxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxMap.TabIndex = 7;
            this.picboxMap.TabStop = false;
            // 
            // lbl_empty
            // 
            this.lbl_empty.AutoSize = true;
            this.lbl_empty.Location = new System.Drawing.Point(25, 265);
            this.lbl_empty.Name = "lbl_empty";
            this.lbl_empty.Size = new System.Drawing.Size(41, 15);
            this.lbl_empty.TabIndex = 30;
            this.lbl_empty.Text = "Empty";
            this.lbl_empty.Visible = false;
            // 
            // panel_NW
            // 
            this.panel_NW.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_NW.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panel_NW.Location = new System.Drawing.Point(0, 0);
            this.panel_NW.Name = "panel_NW";
            this.panel_NW.Size = new System.Drawing.Size(8, 8);
            this.panel_NW.TabIndex = 39;
            this.panel_NW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_NW_MouseDown);
            this.panel_NW.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_NW_MouseMove);
            this.panel_NW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_NW_MouseUp);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 465);
            this.Controls.Add(this.panel_NW);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(661, 462);
            this.Name = "Form1";
            this.Text = "TB Map Resizer - Build Dojando";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox checkBox_TerrainMap;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_size_x;
        private System.Windows.Forms.TextBox txt_size_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_shift_y;
        private System.Windows.Forms.TextBox txt_shift_x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button HueSDown;
        private System.Windows.Forms.Button SDown;
        private System.Windows.Forms.Button LDown;
        private System.Windows.Forms.Button HueSUp;
        private System.Windows.Forms.Button SUp;
        private System.Windows.Forms.Button LUp;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picboxMap;
        private System.Windows.Forms.Label lbl_empty;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_NW;
    }
}

