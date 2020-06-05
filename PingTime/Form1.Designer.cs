namespace PingTime
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
            this.btnPing8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPing1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputIP = new System.Windows.Forms.TextBox();
            this.btnPingFav = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPing8
            // 
            this.btnPing8.BackColor = System.Drawing.Color.Black;
            this.btnPing8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing8.ForeColor = System.Drawing.Color.Lime;
            this.btnPing8.Location = new System.Drawing.Point(53, 98);
            this.btnPing8.Name = "btnPing8";
            this.btnPing8.Size = new System.Drawing.Size(120, 49);
            this.btnPing8.TabIndex = 0;
            this.btnPing8.Text = "Ping 8.8.8.8";
            this.btnPing8.UseVisualStyleBackColor = false;
            this.btnPing8.Click += new System.EventHandler(this.btnPing8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(45, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Results:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(246, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ping 4.2.2.4";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPing1
            // 
            this.btnPing1.BackColor = System.Drawing.Color.Black;
            this.btnPing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing1.ForeColor = System.Drawing.Color.Lime;
            this.btnPing1.Location = new System.Drawing.Point(433, 98);
            this.btnPing1.Name = "btnPing1";
            this.btnPing1.Size = new System.Drawing.Size(120, 49);
            this.btnPing1.TabIndex = 5;
            this.btnPing1.Text = "Ping 1.1.1.1";
            this.btnPing1.UseVisualStyleBackColor = false;
            this.btnPing1.Click += new System.EventHandler(this.btnPing1_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.FormattingEnabled = true;
            this.lblResult.ItemHeight = 18;
            this.lblResult.Location = new System.Drawing.Point(49, 210);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(504, 94);
            this.lblResult.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(143, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Programmer:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(433, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(46, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Favorit IP: ";
            // 
            // txtInputIP
            // 
            this.txtInputIP.BackColor = System.Drawing.Color.Black;
            this.txtInputIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputIP.ForeColor = System.Drawing.Color.Yellow;
            this.txtInputIP.Location = new System.Drawing.Point(179, 33);
            this.txtInputIP.Multiline = true;
            this.txtInputIP.Name = "txtInputIP";
            this.txtInputIP.Size = new System.Drawing.Size(209, 39);
            this.txtInputIP.TabIndex = 10;
            // 
            // btnPingFav
            // 
            this.btnPingFav.BackColor = System.Drawing.Color.Black;
            this.btnPingFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPingFav.ForeColor = System.Drawing.Color.Lime;
            this.btnPingFav.Location = new System.Drawing.Point(397, 33);
            this.btnPingFav.Name = "btnPingFav";
            this.btnPingFav.Size = new System.Drawing.Size(75, 37);
            this.btnPingFav.TabIndex = 11;
            this.btnPingFav.Text = "Ping";
            this.btnPingFav.UseVisualStyleBackColor = false;
            this.btnPingFav.Click += new System.EventHandler(this.btnPingFav_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Black;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.Lime;
            this.btnClean.Location = new System.Drawing.Point(478, 33);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 37);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PingTime.Properties.Resources.bin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 403);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnPingFav);
            this.Controls.Add(this.txtInputIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPing1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPing8);
            this.Name = "Form1";
            this.Text = "Ping Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPing8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPing1;
        private System.Windows.Forms.ListBox lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputIP;
        private System.Windows.Forms.Button btnPingFav;
        private System.Windows.Forms.Button btnClean;
    }
}

