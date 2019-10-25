namespace TimeArtSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CheckForNewMessages = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Game1 = new System.Windows.Forms.Timer(this.components);
            this.Game2 = new System.Windows.Forms.Timer(this.components);
            this.Game3 = new System.Windows.Forms.Timer(this.components);
            this.Game4 = new System.Windows.Forms.Timer(this.components);
            this.lamp8 = new System.Windows.Forms.PictureBox();
            this.lamp7 = new System.Windows.Forms.PictureBox();
            this.lamp6 = new System.Windows.Forms.PictureBox();
            this.lamp5 = new System.Windows.Forms.PictureBox();
            this.lamp4 = new System.Windows.Forms.PictureBox();
            this.lamp3 = new System.Windows.Forms.PictureBox();
            this.lamp2 = new System.Windows.Forms.PictureBox();
            this.lamp1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show_hide = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.fullscreen = new System.Windows.Forms.Button();
            this.start_stop = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.cover = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lamp8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckForNewMessages
            // 
            this.CheckForNewMessages.Interval = 20;
            this.CheckForNewMessages.Tick += new System.EventHandler(this.CheckForNewMessages_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lamp8);
            this.panel1.Controls.Add(this.lamp7);
            this.panel1.Controls.Add(this.lamp6);
            this.panel1.Controls.Add(this.lamp5);
            this.panel1.Controls.Add(this.lamp4);
            this.panel1.Controls.Add(this.lamp3);
            this.panel1.Controls.Add(this.lamp2);
            this.panel1.Controls.Add(this.lamp1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 527);
            this.panel1.TabIndex = 5;
            // 
            // Game1
            // 
            this.Game1.Interval = 2000;
            this.Game1.Tick += new System.EventHandler(this.Game1_Tick);
            // 
            // Game2
            // 
            this.Game2.Tick += new System.EventHandler(this.Game2_Tick);
            // 
            // Game3
            // 
            this.Game3.Tick += new System.EventHandler(this.Game3_Tick);
            // 
            // Game4
            // 
            this.Game4.Tick += new System.EventHandler(this.Game4_Tick);
            // 
            // lamp8
            // 
            this.lamp8.BackColor = System.Drawing.Color.DarkGray;
            this.lamp8.Image = global::TimeArtSimulator.Properties.Resources.lamp8;
            this.lamp8.Location = new System.Drawing.Point(2364, 105);
            this.lamp8.Name = "lamp8";
            this.lamp8.Size = new System.Drawing.Size(200, 286);
            this.lamp8.TabIndex = 12;
            this.lamp8.TabStop = false;
            // 
            // lamp7
            // 
            this.lamp7.BackColor = System.Drawing.Color.DarkGray;
            this.lamp7.Image = global::TimeArtSimulator.Properties.Resources.lamp7;
            this.lamp7.Location = new System.Drawing.Point(2193, 176);
            this.lamp7.Name = "lamp7";
            this.lamp7.Size = new System.Drawing.Size(168, 266);
            this.lamp7.TabIndex = 11;
            this.lamp7.TabStop = false;
            // 
            // lamp6
            // 
            this.lamp6.BackColor = System.Drawing.Color.DarkGray;
            this.lamp6.Image = global::TimeArtSimulator.Properties.Resources.lamp6;
            this.lamp6.Location = new System.Drawing.Point(2023, 237);
            this.lamp6.Name = "lamp6";
            this.lamp6.Size = new System.Drawing.Size(156, 266);
            this.lamp6.TabIndex = 10;
            this.lamp6.TabStop = false;
            // 
            // lamp5
            // 
            this.lamp5.BackColor = System.Drawing.Color.DarkGray;
            this.lamp5.Image = global::TimeArtSimulator.Properties.Resources.lamp5;
            this.lamp5.Location = new System.Drawing.Point(1879, 282);
            this.lamp5.Name = "lamp5";
            this.lamp5.Size = new System.Drawing.Size(133, 257);
            this.lamp5.TabIndex = 9;
            this.lamp5.TabStop = false;
            // 
            // lamp4
            // 
            this.lamp4.BackColor = System.Drawing.Color.DarkGray;
            this.lamp4.Image = global::TimeArtSimulator.Properties.Resources.lamp4;
            this.lamp4.Location = new System.Drawing.Point(1743, 343);
            this.lamp4.Name = "lamp4";
            this.lamp4.Size = new System.Drawing.Size(130, 225);
            this.lamp4.TabIndex = 8;
            this.lamp4.TabStop = false;
            // 
            // lamp3
            // 
            this.lamp3.BackColor = System.Drawing.Color.DarkGray;
            this.lamp3.Image = global::TimeArtSimulator.Properties.Resources.lamp3;
            this.lamp3.Location = new System.Drawing.Point(1640, 389);
            this.lamp3.Name = "lamp3";
            this.lamp3.Size = new System.Drawing.Size(99, 212);
            this.lamp3.TabIndex = 7;
            this.lamp3.TabStop = false;
            // 
            // lamp2
            // 
            this.lamp2.BackColor = System.Drawing.Color.DarkGray;
            this.lamp2.Image = global::TimeArtSimulator.Properties.Resources.lamp2;
            this.lamp2.Location = new System.Drawing.Point(1526, 405);
            this.lamp2.Name = "lamp2";
            this.lamp2.Size = new System.Drawing.Size(97, 225);
            this.lamp2.TabIndex = 6;
            this.lamp2.TabStop = false;
            // 
            // lamp1
            // 
            this.lamp1.BackColor = System.Drawing.Color.DarkGray;
            this.lamp1.Image = global::TimeArtSimulator.Properties.Resources.lamp1;
            this.lamp1.Location = new System.Drawing.Point(1434, 450);
            this.lamp1.Name = "lamp1";
            this.lamp1.Size = new System.Drawing.Size(86, 218);
            this.lamp1.TabIndex = 5;
            this.lamp1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeArtSimulator.Properties.Resources.permanent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3200, 1272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // show_hide
            // 
            this.show_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.show_hide.FlatAppearance.BorderSize = 0;
            this.show_hide.Image = global::TimeArtSimulator.Properties.Resources.down;
            this.show_hide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_hide.Location = new System.Drawing.Point(239, 528);
            this.show_hide.Name = "show_hide";
            this.show_hide.Size = new System.Drawing.Size(125, 33);
            this.show_hide.TabIndex = 6;
            this.show_hide.Text = "Nascondi log";
            this.show_hide.UseVisualStyleBackColor = true;
            this.show_hide.Click += new System.EventHandler(this.Show_hide_Click);
            // 
            // clean
            // 
            this.clean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clean.FlatAppearance.BorderSize = 0;
            this.clean.Image = global::TimeArtSimulator.Properties.Resources.clean;
            this.clean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clean.Location = new System.Drawing.Point(119, 528);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(114, 33);
            this.clean.TabIndex = 3;
            this.clean.Text = "Pulisci log";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // fullscreen
            // 
            this.fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscreen.FlatAppearance.BorderSize = 0;
            this.fullscreen.Image = global::TimeArtSimulator.Properties.Resources.fullscreen;
            this.fullscreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fullscreen.Location = new System.Drawing.Point(847, 528);
            this.fullscreen.Name = "fullscreen";
            this.fullscreen.Size = new System.Drawing.Size(151, 33);
            this.fullscreen.TabIndex = 7;
            this.fullscreen.Text = "Schermo intero";
            this.fullscreen.UseVisualStyleBackColor = true;
            this.fullscreen.Click += new System.EventHandler(this.Fullscreen_Click);
            // 
            // start_stop
            // 
            this.start_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.start_stop.FlatAppearance.BorderSize = 0;
            this.start_stop.Image = global::TimeArtSimulator.Properties.Resources.stop;
            this.start_stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start_stop.Location = new System.Drawing.Point(12, 528);
            this.start_stop.Name = "start_stop";
            this.start_stop.Size = new System.Drawing.Size(101, 33);
            this.start_stop.TabIndex = 1;
            this.start_stop.Text = "Ferma bot";
            this.start_stop.UseVisualStyleBackColor = true;
            this.start_stop.Click += new System.EventHandler(this.Start_stop_Click);
            // 
            // log
            // 
            this.log.AcceptsReturn = true;
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(0, 562);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.log.Size = new System.Drawing.Size(1010, 132);
            this.log.TabIndex = 2;
            this.log.TextChanged += new System.EventHandler(this.Log_TextChanged);
            // 
            // cover
            // 
            this.cover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cover.Location = new System.Drawing.Point(0, 526);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(1010, 110);
            this.cover.TabIndex = 8;
            this.cover.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 694);
            this.Controls.Add(this.log);
            this.Controls.Add(this.start_stop);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.show_hide);
            this.Controls.Add(this.fullscreen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lamp8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lamp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer CheckForNewMessages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox lamp1;
        private System.Windows.Forms.PictureBox lamp2;
        private System.Windows.Forms.PictureBox lamp8;
        private System.Windows.Forms.PictureBox lamp7;
        private System.Windows.Forms.PictureBox lamp6;
        private System.Windows.Forms.PictureBox lamp5;
        private System.Windows.Forms.PictureBox lamp4;
        private System.Windows.Forms.PictureBox lamp3;
        private System.Windows.Forms.Timer Game1;
        private System.Windows.Forms.Timer Game2;
        private System.Windows.Forms.Timer Game3;
        private System.Windows.Forms.Timer Game4;
        private System.Windows.Forms.Button show_hide;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button fullscreen;
        private System.Windows.Forms.Button start_stop;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.PictureBox cover;
    }
}

