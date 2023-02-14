namespace Capstone_BMS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reserveDeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserveDeskToolStripMenuItem,
            this.availabilityToolStripMenuItem,
            this.searchDeskToolStripMenuItem,
            this.deleteDeskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reserveDeskToolStripMenuItem
            // 
            this.reserveDeskToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reserveDeskToolStripMenuItem.Name = "reserveDeskToolStripMenuItem";
            this.reserveDeskToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.reserveDeskToolStripMenuItem.Text = "Search";
            this.reserveDeskToolStripMenuItem.Click += new System.EventHandler(this.reserveDeskToolStripMenuItem_Click);
            // 
            // availabilityToolStripMenuItem
            // 
            this.availabilityToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.availabilityToolStripMenuItem.Name = "availabilityToolStripMenuItem";
            this.availabilityToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.availabilityToolStripMenuItem.Text = "Reserve";
            this.availabilityToolStripMenuItem.Click += new System.EventHandler(this.availabilityToolStripMenuItem_Click);
            // 
            // searchDeskToolStripMenuItem
            // 
            this.searchDeskToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchDeskToolStripMenuItem.Name = "searchDeskToolStripMenuItem";
            this.searchDeskToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.searchDeskToolStripMenuItem.Text = "My Bookings";
            this.searchDeskToolStripMenuItem.Click += new System.EventHandler(this.searchDeskToolStripMenuItem_Click);
            // 
            // deleteDeskToolStripMenuItem
            // 
            this.deleteDeskToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteDeskToolStripMenuItem.Name = "deleteDeskToolStripMenuItem";
            this.deleteDeskToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.deleteDeskToolStripMenuItem.Text = "Logout";
            this.deleteDeskToolStripMenuItem.Click += new System.EventHandler(this.deleteDeskToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookMySeat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reserveDeskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDeskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDeskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

