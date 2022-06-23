namespace MouseUtilsRewrite
{
    partial class MouseUtilsRewrite
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseUtilsRewrite));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gmc_checkbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.coordinates = new System.Windows.Forms.Label();
            this.gc_checkbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hex = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rgb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateTick = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Live_checkbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.live_coordinates = new System.Windows.Forms.Label();
            this.live_rgb = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.live_hex = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.livelog_checkbox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MouseUtils Rewrite";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Help!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Get mouse coordinates";
            // 
            // gmc_checkbox
            // 
            this.gmc_checkbox.AutoSize = true;
            this.gmc_checkbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gmc_checkbox.Location = new System.Drawing.Point(40, 240);
            this.gmc_checkbox.Name = "gmc_checkbox";
            this.gmc_checkbox.Size = new System.Drawing.Size(71, 17);
            this.gmc_checkbox.TabIndex = 7;
            this.gmc_checkbox.Text = "Activated";
            this.gmc_checkbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "coordinates:";
            // 
            // coordinates
            // 
            this.coordinates.AutoSize = true;
            this.coordinates.Location = new System.Drawing.Point(220, 280);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(35, 13);
            this.coordinates.TabIndex = 9;
            this.coordinates.Text = "empty";
            this.coordinates.Click += new System.EventHandler(this.coordinates_Click);
            // 
            // gc_checkbox
            // 
            this.gc_checkbox.AutoSize = true;
            this.gc_checkbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_checkbox.Location = new System.Drawing.Point(40, 380);
            this.gc_checkbox.Name = "gc_checkbox";
            this.gc_checkbox.Size = new System.Drawing.Size(71, 17);
            this.gc_checkbox.TabIndex = 10;
            this.gc_checkbox.Text = "Activated";
            this.gc_checkbox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Get color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hex:";
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Location = new System.Drawing.Point(220, 420);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(35, 13);
            this.hex.TabIndex = 13;
            this.hex.Text = "empty";
            this.hex.Click += new System.EventHandler(this.hex_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "RGB:";
            // 
            // rgb
            // 
            this.rgb.AutoSize = true;
            this.rgb.Location = new System.Drawing.Point(220, 440);
            this.rgb.Name = "rgb";
            this.rgb.Size = new System.Drawing.Size(35, 13);
            this.rgb.TabIndex = 15;
            this.rgb.Text = "empty";
            this.rgb.Click += new System.EventHandler(this.rgb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Log";
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.LightCyan;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.log.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.log.Location = new System.Drawing.Point(20, 580);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(420, 220);
            this.log.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MouseUtilsRewrite.Properties.Resources._5a37c6dad46796_55558059151360482687;
            this.pictureBox4.Location = new System.Drawing.Point(40, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::MouseUtilsRewrite.Properties.Resources.line_40962;
            this.pictureBox3.Location = new System.Drawing.Point(20, 500);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(420, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::MouseUtilsRewrite.Properties.Resources.line_40962;
            this.pictureBox2.Location = new System.Drawing.Point(20, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::MouseUtilsRewrite.Properties.Resources.line_40962;
            this.pictureBox1.Location = new System.Drawing.Point(20, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateTick
            // 
            this.UpdateTick.Interval = 50;
            this.UpdateTick.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = global::MouseUtilsRewrite.Properties.Resources.line_40962;
            this.pictureBox5.Location = new System.Drawing.Point(0, 60);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(460, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(160, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Live statistics";
            // 
            // Live_checkbox
            // 
            this.Live_checkbox.AutoSize = true;
            this.Live_checkbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Live_checkbox.Location = new System.Drawing.Point(40, 100);
            this.Live_checkbox.Name = "Live_checkbox";
            this.Live_checkbox.Size = new System.Drawing.Size(71, 17);
            this.Live_checkbox.TabIndex = 22;
            this.Live_checkbox.Text = "Activated";
            this.Live_checkbox.UseVisualStyleBackColor = true;
            this.Live_checkbox.CheckedChanged += new System.EventHandler(this.Live_checkbox_update);
            this.Live_checkbox.CheckStateChanged += new System.EventHandler(this.Live_checkbox_update);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "coordinates: ";
            // 
            // live_coordinates
            // 
            this.live_coordinates.AutoSize = true;
            this.live_coordinates.Location = new System.Drawing.Point(140, 160);
            this.live_coordinates.Name = "live_coordinates";
            this.live_coordinates.Size = new System.Drawing.Size(35, 13);
            this.live_coordinates.TabIndex = 24;
            this.live_coordinates.Text = "empty";
            // 
            // live_rgb
            // 
            this.live_rgb.AutoSize = true;
            this.live_rgb.Location = new System.Drawing.Point(320, 160);
            this.live_rgb.Name = "live_rgb";
            this.live_rgb.Size = new System.Drawing.Size(35, 13);
            this.live_rgb.TabIndex = 28;
            this.live_rgb.Text = "empty";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "RGB:";
            // 
            // live_hex
            // 
            this.live_hex.AutoSize = true;
            this.live_hex.Location = new System.Drawing.Point(320, 140);
            this.live_hex.Name = "live_hex";
            this.live_hex.Size = new System.Drawing.Size(35, 13);
            this.live_hex.TabIndex = 26;
            this.live_hex.Text = "empty";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Hex:";
            // 
            // value1
            // 
            this.value1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.value1.Location = new System.Drawing.Point(400, 100);
            this.value1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.value1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(40, 20);
            this.value1.TabIndex = 29;
            this.value1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.value1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "ms:";
            // 
            // livelog_checkbox
            // 
            this.livelog_checkbox.AutoSize = true;
            this.livelog_checkbox.Location = new System.Drawing.Point(40, 120);
            this.livelog_checkbox.Name = "livelog_checkbox";
            this.livelog_checkbox.Size = new System.Drawing.Size(44, 17);
            this.livelog_checkbox.TabIndex = 31;
            this.livelog_checkbox.Text = "Log";
            this.livelog_checkbox.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Hotkey:  K";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 480);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Hotkey:  L";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label16.Location = new System.Drawing.Point(40, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Github";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(380, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Textdocument|*.log\n|Textdocument|*.txt";
            // 
            // MouseUtilsRewrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(461, 825);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.livelog_checkbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.live_rgb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.live_hex);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.live_coordinates);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Live_checkbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rgb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gc_checkbox);
            this.Controls.Add(this.coordinates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gmc_checkbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MouseUtilsRewrite";
            this.Opacity = 0.95D;
            this.Text = "MouseUtilsRewrite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MouseUtilsRewrite_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox gmc_checkbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label coordinates;
        private System.Windows.Forms.CheckBox gc_checkbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rgb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Live_checkbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer UpdateTick;
        private System.Windows.Forms.Label live_coordinates;
        private System.Windows.Forms.Label live_rgb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label live_hex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown value1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox livelog_checkbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

