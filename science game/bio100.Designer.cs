
namespace WindowsFormsApp1
{
    partial class bio100
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
            this.answertxt = new System.Windows.Forms.TextBox();
            this.elementtxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timertxt = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answertxt
            // 
            this.answertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answertxt.Location = new System.Drawing.Point(222, 138);
            this.answertxt.Name = "answertxt";
            this.answertxt.Size = new System.Drawing.Size(120, 31);
            this.answertxt.TabIndex = 1;
            // 
            // elementtxt
            // 
            this.elementtxt.AutoSize = true;
            this.elementtxt.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementtxt.Location = new System.Drawing.Point(141, 44);
            this.elementtxt.Name = "elementtxt";
            this.elementtxt.Size = new System.Drawing.Size(209, 63);
            this.elementtxt.TabIndex = 2;
            this.elementtxt.Text = "Element";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 63);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score";
            // 
            // checkbtn
            // 
            this.checkbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbtn.Location = new System.Drawing.Point(343, 192);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(189, 67);
            this.checkbtn.TabIndex = 4;
            this.checkbtn.Text = "Check";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timertxt
            // 
            this.timertxt.AutoSize = true;
            this.timertxt.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timertxt.Location = new System.Drawing.Point(472, 26);
            this.timertxt.Name = "timertxt";
            this.timertxt.Size = new System.Drawing.Size(155, 63);
            this.timertxt.TabIndex = 5;
            this.timertxt.Text = "Timer";
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn.Location = new System.Drawing.Point(27, 192);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(189, 67);
            this.Startbtn.TabIndex = 6;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // bio100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(765, 260);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.timertxt);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elementtxt);
            this.Controls.Add(this.answertxt);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bio100";
            this.Text = "bio100";
            this.Load += new System.EventHandler(this.bio100_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox answertxt;
        private System.Windows.Forms.Label elementtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timertxt;
        private System.Windows.Forms.Button Startbtn;
    }
}