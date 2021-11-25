namespace HangMan
{
    partial class Splash
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
            this.newGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.letterTexBox = new System.Windows.Forms.TextBox();
            this.letterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(43, 143);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 1;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
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
            this.comboBox1.Location = new System.Drawing.Point(43, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // letterTexBox
            // 
            this.letterTexBox.Location = new System.Drawing.Point(43, 43);
            this.letterTexBox.MaxLength = 1;
            this.letterTexBox.Name = "letterTexBox";
            this.letterTexBox.Size = new System.Drawing.Size(109, 20);
            this.letterTexBox.TabIndex = 9;
            this.letterTexBox.Visible = false;
            // 
            // letterLbl
            // 
            this.letterLbl.AutoSize = true;
            this.letterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLbl.Location = new System.Drawing.Point(40, 27);
            this.letterLbl.Name = "letterLbl";
            this.letterLbl.Size = new System.Drawing.Size(59, 13);
            this.letterLbl.TabIndex = 10;
            this.letterLbl.Text = "Player One";
            this.letterLbl.Visible = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 200);
            this.Controls.Add(this.letterLbl);
            this.Controls.Add(this.letterTexBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.newGameBtn);
            this.Name = "Splash";
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox letterTexBox;
        private System.Windows.Forms.Label letterLbl;
    }
}