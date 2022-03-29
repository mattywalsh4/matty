
namespace science_game
{
    partial class med
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
            this.elementtxt = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.timertxt = new System.Windows.Forms.Label();
            this.checkbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.answertxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // elementtxt
            // 
            this.elementtxt.AutoSize = true;
            this.elementtxt.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementtxt.Location = new System.Drawing.Point(138, 38);
            this.elementtxt.Name = "elementtxt";
            this.elementtxt.Size = new System.Drawing.Size(209, 63);
            this.elementtxt.TabIndex = 3;
            this.elementtxt.Text = "Element";
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn.Location = new System.Drawing.Point(82, 180);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(189, 67);
            this.Startbtn.TabIndex = 11;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            // 
            // timertxt
            // 
            this.timertxt.AutoSize = true;
            this.timertxt.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timertxt.Location = new System.Drawing.Point(527, 14);
            this.timertxt.Name = "timertxt";
            this.timertxt.Size = new System.Drawing.Size(155, 63);
            this.timertxt.TabIndex = 10;
            this.timertxt.Text = "Timer";
            // 
            // checkbtn
            // 
            this.checkbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbtn.Location = new System.Drawing.Point(398, 180);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(189, 67);
            this.checkbtn.TabIndex = 9;
            this.checkbtn.Text = "Check";
            this.checkbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 63);
            this.label3.TabIndex = 8;
            this.label3.Text = "Score";
            // 
            // answertxt
            // 
            this.answertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answertxt.Location = new System.Drawing.Point(277, 126);
            this.answertxt.Name = "answertxt";
            this.answertxt.Size = new System.Drawing.Size(120, 31);
            this.answertxt.TabIndex = 7;
            // 
            // med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(765, 260);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.timertxt);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answertxt);
            this.Controls.Add(this.elementtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "med";
            this.Text = "med";
            this.Load += new System.EventHandler(this.med_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label elementtxt;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Label timertxt;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox answertxt;
        private System.Windows.Forms.Timer timer1;
    }
}