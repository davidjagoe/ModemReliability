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
            this.dns_failures = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.n_requests = new System.Windows.Forms.Label();
            this.n_failures = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dns_total
            // 
            this.dns_total.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dns_total.Location = new System.Drawing.Point(17, 13);
            this.dns_total.Name = "dns_total";
            this.dns_total.Size = new System.Drawing.Size(169, 20);
            this.dns_total.Text = "Total Req";
            this.dns_total.ParentChanged += new System.EventHandler(this.dns_total_ParentChanged);
            // 
            // dns_failures
            // 
            this.dns_failures.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dns_failures.Location = new System.Drawing.Point(17, 104);
            this.dns_failures.Name = "dns_failures";
            this.dns_failures.Size = new System.Drawing.Size(169, 20);
            this.dns_failures.Text = "Failures";
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
            // n_requests
            // 
            this.n_requests.Location = new System.Drawing.Point(207, 13);
            this.n_requests.Name = "n_requests";
            this.n_requests.Size = new System.Drawing.Size(100, 20);
            this.n_requests.Text = "0";
            // 
            // n_failures
            // 
            this.n_failures.Location = new System.Drawing.Point(207, 104);
            this.n_failures.Name = "n_failures";
            this.n_failures.Size = new System.Drawing.Size(100, 20);
            this.n_failures.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.n_failures);
            this.Controls.Add(this.n_requests);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dns_failures);
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
        private System.Windows.Forms.Label dns_failures;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label n_requests;
        private System.Windows.Forms.Label n_failures;
    }
}

