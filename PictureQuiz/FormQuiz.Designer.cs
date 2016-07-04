namespace PictureQuiz
{
    partial class FormQuiz
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
            this.labelState = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRound = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAntwort4 = new System.Windows.Forms.Label();
            this.labelAntwort3 = new System.Windows.Forms.Label();
            this.labelAntwort2 = new System.Windows.Forms.Label();
            this.labelAntwort1 = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.pictureBoxAudienceJoker = new System.Windows.Forms.PictureBox();
            this.pictureBoxFiftyFiftyJoker = new System.Windows.Forms.PictureBox();
            this.pictureBoxTelephoneJoker = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudienceJoker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiftyFiftyJoker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelephoneJoker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelState.Location = new System.Drawing.Point(976, 27);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(72, 13);
            this.labelState.TabIndex = 29;
            this.labelState.Text = "Stand 2016";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRound});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRound
            // 
            this.toolStripStatusLabelRound.Name = "toolStripStatusLabelRound";
            this.toolStripStatusLabelRound.Size = new System.Drawing.Size(242, 17);
            this.toolStripStatusLabelRound.Text = "Klicken Sie auf \"neu\" um das Quiz zu starten!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItemNew.Text = "Neu";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // labelAntwort4
            // 
            this.labelAntwort4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAntwort4.Location = new System.Drawing.Point(779, 404);
            this.labelAntwort4.Name = "labelAntwort4";
            this.labelAntwort4.Size = new System.Drawing.Size(281, 130);
            this.labelAntwort4.TabIndex = 23;
            this.labelAntwort4.Text = "Answer 4";
            this.labelAntwort4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAntwort3
            // 
            this.labelAntwort3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAntwort3.Location = new System.Drawing.Point(523, 404);
            this.labelAntwort3.Name = "labelAntwort3";
            this.labelAntwort3.Size = new System.Drawing.Size(250, 130);
            this.labelAntwort3.TabIndex = 22;
            this.labelAntwort3.Text = "Answer 3";
            this.labelAntwort3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAntwort2
            // 
            this.labelAntwort2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAntwort2.Location = new System.Drawing.Point(243, 404);
            this.labelAntwort2.Name = "labelAntwort2";
            this.labelAntwort2.Size = new System.Drawing.Size(274, 130);
            this.labelAntwort2.TabIndex = 21;
            this.labelAntwort2.Text = "Answer 2";
            this.labelAntwort2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAntwort1
            // 
            this.labelAntwort1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAntwort1.Location = new System.Drawing.Point(-6, 404);
            this.labelAntwort1.Name = "labelAntwort1";
            this.labelAntwort1.Size = new System.Drawing.Size(255, 130);
            this.labelAntwort1.TabIndex = 20;
            this.labelAntwort1.Text = "Answer 1";
            this.labelAntwort1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(27, 108);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(977, 104);
            this.labelQuestion.TabIndex = 17;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAudienceJoker
            // 
            this.pictureBoxAudienceJoker.Enabled = false;
            this.pictureBoxAudienceJoker.Image = global::PictureQuiz.Properties.Resources.publikumsjoker;
            this.pictureBoxAudienceJoker.Location = new System.Drawing.Point(649, 30);
            this.pictureBoxAudienceJoker.Name = "pictureBoxAudienceJoker";
            this.pictureBoxAudienceJoker.Size = new System.Drawing.Size(100, 75);
            this.pictureBoxAudienceJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAudienceJoker.TabIndex = 28;
            this.pictureBoxAudienceJoker.TabStop = false;
            this.pictureBoxAudienceJoker.Click += new System.EventHandler(this.pictureBoxAudienceJoker_Click);
            this.pictureBoxAudienceJoker.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxAudienceJoker.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pictureBoxFiftyFiftyJoker
            // 
            this.pictureBoxFiftyFiftyJoker.Enabled = false;
            this.pictureBoxFiftyFiftyJoker.Image = global::PictureQuiz.Properties.Resources._50_50__joker_;
            this.pictureBoxFiftyFiftyJoker.Location = new System.Drawing.Point(463, 30);
            this.pictureBoxFiftyFiftyJoker.Name = "pictureBoxFiftyFiftyJoker";
            this.pictureBoxFiftyFiftyJoker.Size = new System.Drawing.Size(100, 75);
            this.pictureBoxFiftyFiftyJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFiftyFiftyJoker.TabIndex = 27;
            this.pictureBoxFiftyFiftyJoker.TabStop = false;
            this.pictureBoxFiftyFiftyJoker.Click += new System.EventHandler(this.pictureBoxFiftyFiftyJoker_Click);
            this.pictureBoxFiftyFiftyJoker.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxFiftyFiftyJoker.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pictureBoxTelephoneJoker
            // 
            this.pictureBoxTelephoneJoker.Enabled = false;
            this.pictureBoxTelephoneJoker.Image = global::PictureQuiz.Properties.Resources.telefonjoker;
            this.pictureBoxTelephoneJoker.Location = new System.Drawing.Point(289, 30);
            this.pictureBoxTelephoneJoker.Name = "pictureBoxTelephoneJoker";
            this.pictureBoxTelephoneJoker.Size = new System.Drawing.Size(100, 75);
            this.pictureBoxTelephoneJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTelephoneJoker.TabIndex = 26;
            this.pictureBoxTelephoneJoker.TabStop = false;
            this.pictureBoxTelephoneJoker.Click += new System.EventHandler(this.pictureBoxTelephoneJoker_Click);
            this.pictureBoxTelephoneJoker.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBoxTelephoneJoker.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::PictureQuiz.Properties.Resources.roman_numeral_IV;
            this.pictureBox4.Location = new System.Drawing.Point(829, 215);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 175);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::PictureQuiz.Properties.Resources.roman_numeral_III;
            this.pictureBox3.Location = new System.Drawing.Point(551, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::PictureQuiz.Properties.Resources.roman_numeral_II;
            this.pictureBox2.Location = new System.Drawing.Point(292, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::PictureQuiz.Properties.Resources.roman_numeral_I;
            this.pictureBox1.Location = new System.Drawing.Point(27, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 556);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.pictureBoxAudienceJoker);
            this.Controls.Add(this.pictureBoxFiftyFiftyJoker);
            this.Controls.Add(this.pictureBoxTelephoneJoker);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelAntwort4);
            this.Controls.Add(this.labelAntwort3);
            this.Controls.Add(this.labelAntwort2);
            this.Controls.Add(this.labelAntwort1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormQuiz";
            this.Text = "Bilderquiz";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudienceJoker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiftyFiftyJoker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelephoneJoker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.PictureBox pictureBoxAudienceJoker;
        private System.Windows.Forms.PictureBox pictureBoxFiftyFiftyJoker;
        private System.Windows.Forms.PictureBox pictureBoxTelephoneJoker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRound;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.Label labelAntwort4;
        private System.Windows.Forms.Label labelAntwort3;
        private System.Windows.Forms.Label labelAntwort2;
        private System.Windows.Forms.Label labelAntwort1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

