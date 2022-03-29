
namespace Math_game
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
            this.components = new System.ComponentModel.Container();
            this.Donebtn = new System.Windows.Forms.Button();
            this.Startbtn = new System.Windows.Forms.Button();
            this.ansertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plustxt = new System.Windows.Forms.Label();
            this.timertxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Donebtn
            // 
            this.Donebtn.BackColor = System.Drawing.Color.Silver;
            this.Donebtn.Enabled = false;
            this.Donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Donebtn.Location = new System.Drawing.Point(12, 213);
            this.Donebtn.Name = "Donebtn";
            this.Donebtn.Size = new System.Drawing.Size(542, 37);
            this.Donebtn.TabIndex = 0;
            this.Donebtn.Text = "Done";
            this.Donebtn.UseVisualStyleBackColor = false;
            this.Donebtn.Click += new System.EventHandler(this.Donebtn_Click);
            // 
            // Startbtn
            // 
            this.Startbtn.BackColor = System.Drawing.Color.Silver;
            this.Startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Startbtn.Location = new System.Drawing.Point(12, 266);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(542, 37);
            this.Startbtn.TabIndex = 1;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = false;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // ansertxt
            // 
            this.ansertxt.BackColor = System.Drawing.Color.Silver;
            this.ansertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ansertxt.Location = new System.Drawing.Point(12, 177);
            this.ansertxt.Name = "ansertxt";
            this.ansertxt.Size = new System.Drawing.Size(542, 13);
            this.ansertxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(151, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // plustxt
            // 
            this.plustxt.AutoSize = true;
            this.plustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plustxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.plustxt.Location = new System.Drawing.Point(91, 60);
            this.plustxt.Name = "plustxt";
            this.plustxt.Size = new System.Drawing.Size(43, 44);
            this.plustxt.TabIndex = 5;
            this.plustxt.Text = "+";
            // 
            // timertxt
            // 
            this.timertxt.AutoSize = true;
            this.timertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timertxt.ForeColor = System.Drawing.Color.Black;
            this.timertxt.Location = new System.Drawing.Point(319, 60);
            this.timertxt.Name = "timertxt";
            this.timertxt.Size = new System.Drawing.Size(0, 44);
            this.timertxt.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(566, 315);
            this.Controls.Add(this.timertxt);
            this.Controls.Add(this.plustxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ansertxt);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.Donebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Donebtn;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.TextBox ansertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plustxt;
        private System.Windows.Forms.Label timertxt;
        private System.Windows.Forms.Timer timer1;
    }
}

