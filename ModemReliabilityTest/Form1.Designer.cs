namespace ModemReliabilityTest
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
            this.dns_total = new System.Windows.Forms.Label();
            this.nodns_total = new System.Windows.Forms.Label();
            this.dns_failures = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dns_tot = new System.Windows.Forms.Label();
            this.ip_tot = new System.Windows.Forms.Label();
            this.dns_fail = new System.Windows.Forms.Label();
            this.ip_fail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dns_total
            // 
            this.dns_total.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dns_total.Location = new System.Drawing.Point(17, 13);
            this.dns_total.Name = "dns_total";
            this.dns_total.Size = new System.Drawing.Size(169, 20);
            this.dns_total.Text = "Total Req - with DNS";
            // 
            // nodns_total
            // 
            this.nodns_total.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.nodns_total.Location = new System.Drawing.Point(17, 56);
            this.nodns_total.Name = "nodns_total";
            this.nodns_total.Size = new System.Drawing.Size(169, 20);
            this.nodns_total.Text = "Total Req - no DNS";
            // 
            // dns_failures
            // 
            this.dns_failures.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dns_failures.Location = new System.Drawing.Point(17, 104);
            this.dns_failures.Name = "dns_failures";
            this.dns_failures.Size = new System.Drawing.Size(169, 20);
            this.dns_failures.Text = "failures - with DNS";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.Text = "failures - no DNS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dns_tot
            // 
            this.dns_tot.Location = new System.Drawing.Point(207, 13);
            this.dns_tot.Name = "dns_tot";
            this.dns_tot.Size = new System.Drawing.Size(100, 20);
            this.dns_tot.Text = "0";
            // 
            // ip_tot
            // 
            this.ip_tot.Location = new System.Drawing.Point(207, 56);
            this.ip_tot.Name = "ip_tot";
            this.ip_tot.Size = new System.Drawing.Size(100, 20);
            this.ip_tot.Text = "0";
            // 
            // dns_fail
            // 
            this.dns_fail.Location = new System.Drawing.Point(207, 104);
            this.dns_fail.Name = "dns_fail";
            this.dns_fail.Size = new System.Drawing.Size(100, 20);
            this.dns_fail.Text = "0";
            // 
            // ip_fail
            // 
            this.ip_fail.Location = new System.Drawing.Point(207, 148);
            this.ip_fail.Name = "ip_fail";
            this.ip_fail.Size = new System.Drawing.Size(100, 20);
            this.ip_fail.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.ControlBox = false;
            this.Controls.Add(this.ip_fail);
            this.Controls.Add(this.dns_fail);
            this.Controls.Add(this.ip_tot);
            this.Controls.Add(this.dns_tot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dns_failures);
            this.Controls.Add(this.nodns_total);
            this.Controls.Add(this.dns_total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dns_total;
        private System.Windows.Forms.Label nodns_total;
        private System.Windows.Forms.Label dns_failures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dns_tot;
        private System.Windows.Forms.Label ip_tot;
        private System.Windows.Forms.Label dns_fail;
        private System.Windows.Forms.Label ip_fail;
    }
}

