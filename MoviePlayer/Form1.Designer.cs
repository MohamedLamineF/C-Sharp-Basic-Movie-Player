namespace MoviePlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnPreviouss = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMute);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnRewind);
            this.panel2.Controls.Add(this.btnPreviouss);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 37);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.wmp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 413);
            this.panel3.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(12, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Video Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(800, 413);
            this.wmp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::MoviePlayer.Properties.Resources.fast_forward_96px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(524, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::MoviePlayer.Properties.Resources.end_96px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(562, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnRewind
            // 
            this.btnRewind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRewind.BackColor = System.Drawing.Color.Transparent;
            this.btnRewind.BackgroundImage = global::MoviePlayer.Properties.Resources.rewind_96px;
            this.btnRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRewind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRewind.Location = new System.Drawing.Point(306, 2);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(32, 32);
            this.btnRewind.TabIndex = 3;
            this.btnRewind.UseVisualStyleBackColor = false;
            this.btnRewind.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnPreviouss
            // 
            this.btnPreviouss.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPreviouss.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviouss.BackgroundImage = global::MoviePlayer.Properties.Resources.skip_to_start_96px;
            this.btnPreviouss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreviouss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviouss.Location = new System.Drawing.Point(268, 3);
            this.btnPreviouss.Name = "btnPreviouss";
            this.btnPreviouss.Size = new System.Drawing.Size(32, 32);
            this.btnPreviouss.TabIndex = 2;
            this.btnPreviouss.UseVisualStyleBackColor = false;
            this.btnPreviouss.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.AccessibleName = "Play";
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::MoviePlayer.Properties.Resources.play_64px;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location = new System.Drawing.Point(369, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::MoviePlayer.Properties.Resources.stop_64px;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Location = new System.Drawing.Point(445, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::MoviePlayer.Properties.Resources.pause_64px;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(407, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(32, 32);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.AutoEllipsis = true;
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BackgroundImage = global::MoviePlayer.Properties.Resources.import_64px;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Location = new System.Drawing.Point(755, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(32, 32);
            this.btnImport.TabIndex = 0;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMute
            // 
            this.btnMute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.btnMute.BackgroundImage = global::MoviePlayer.Properties.Resources.sound_96px;
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMute.Location = new System.Drawing.Point(717, 3);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(32, 32);
            this.btnMute.TabIndex = 6;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Button btnPreviouss;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMute;
    }
}

