namespace Lab4
{
    partial class ProgramForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
            // Form
            //
            this.KeyPreview = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 533);
            this.Name = "dvd_screen_saver";
            this.Text = "DVD Screen Saver";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.MinimumSize = new Size(400, 200);
            //
            // button1
            //
            this.button1 = new System.Windows.Forms.Button();
            this.button1.Location = new System.Drawing.Point(20, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button1.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Text = "Create Circle";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.Controls.Add(this.button1);
            //
            // button2
            //
            this.button2 = new System.Windows.Forms.Button();
            this.button2.Location = new System.Drawing.Point(140, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 0;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button2.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Text = "Create Square";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.Controls.Add(this.button2);
            //
            // button3
            //
            this.button3 = new System.Windows.Forms.Button();
            this.button3.Location = new System.Drawing.Point(260, 17);
            this.button3.Name = "button2";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 0;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.button3.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Text = "Create Rhomb";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.Controls.Add(this.button3);
            //
            // Form controls collection
            //
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.button1,
                this.button2,
                this.button3
            });
            this.ResumeLayout(false);
        }

        #endregion

        // Control declarations
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
