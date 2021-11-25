namespace HangMan
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
            this.phrasePanel = new System.Windows.Forms.Panel();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lettersUsedPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.letterLbl = new System.Windows.Forms.Label();
            this.letterTexBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.drawingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // phrasePanel
            // 
            this.phrasePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phrasePanel.Location = new System.Drawing.Point(150, 12);
            this.phrasePanel.Name = "phrasePanel";
            this.phrasePanel.Size = new System.Drawing.Size(610, 133);
            this.phrasePanel.TabIndex = 1;
            // 
            // drawingPanel
            // 
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingPanel.Controls.Add(this.pictureBox1);
            this.drawingPanel.Location = new System.Drawing.Point(492, 151);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(241, 275);
            this.drawingPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lettersUsedPanel
            // 
            this.lettersUsedPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lettersUsedPanel.Location = new System.Drawing.Point(150, 151);
            this.lettersUsedPanel.Name = "lettersUsedPanel";
            this.lettersUsedPanel.Size = new System.Drawing.Size(336, 275);
            this.lettersUsedPanel.TabIndex = 2;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonPanel.Controls.Add(this.label1);
            this.buttonPanel.Controls.Add(this.comboBox1);
            this.buttonPanel.Controls.Add(this.letterLbl);
            this.buttonPanel.Controls.Add(this.letterTexBox);
            this.buttonPanel.Controls.Add(this.newGameBtn);
            this.buttonPanel.Location = new System.Drawing.Point(5, 12);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(139, 162);
            this.buttonPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Colors",
            "Numbers",
            "Names",
            "Sight Words"});
            this.comboBox1.Location = new System.Drawing.Point(8, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // letterLbl
            // 
            this.letterLbl.AutoSize = true;
            this.letterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLbl.Location = new System.Drawing.Point(5, 108);
            this.letterLbl.Name = "letterLbl";
            this.letterLbl.Size = new System.Drawing.Size(78, 13);
            this.letterLbl.TabIndex = 9;
            this.letterLbl.Text = "Choose a letter";
            this.letterLbl.Visible = false;
            // 
            // letterTexBox
            // 
            this.letterTexBox.Location = new System.Drawing.Point(8, 124);
            this.letterTexBox.MaxLength = 1;
            this.letterTexBox.Name = "letterTexBox";
            this.letterTexBox.Size = new System.Drawing.Size(41, 20);
            this.letterTexBox.TabIndex = 8;
            this.letterTexBox.Visible = false;
            this.letterTexBox.TextChanged += new System.EventHandler(this.LetterTexBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 244);
            this.panel1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(5, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Level";
            this.label2.Visible = false;
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(8, 57);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.lettersUsedPanel);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.phrasePanel);
            this.Name = "Form1";
            this.Text = "Hangman ";
            this.drawingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel phrasePanel;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel lettersUsedPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Label letterLbl;
        private System.Windows.Forms.TextBox letterTexBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newGameBtn;
    }
}

