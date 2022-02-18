
namespace CalculatorCredit
{
    partial class frmCalculatorCredit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDurata = new System.Windows.Forms.Button();
            this.btnRataLunara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuOptiuni = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniRataLunara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniDurata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.mnuOptiuni.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDurata);
            this.panel1.Controls.Add(this.btnRataLunara);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 413);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(279, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 78);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDurata
            // 
            this.btnDurata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDurata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurata.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDurata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDurata.Location = new System.Drawing.Point(279, 194);
            this.btnDurata.Name = "btnDurata";
            this.btnDurata.Size = new System.Drawing.Size(270, 78);
            this.btnDurata.TabIndex = 2;
            this.btnDurata.Text = "Durata";
            this.btnDurata.UseVisualStyleBackColor = true;
            this.btnDurata.Click += new System.EventHandler(this.btnDurata_Click);
            // 
            // btnRataLunara
            // 
            this.btnRataLunara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRataLunara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRataLunara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRataLunara.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnRataLunara.Location = new System.Drawing.Point(279, 100);
            this.btnRataLunara.Name = "btnRataLunara";
            this.btnRataLunara.Size = new System.Drawing.Size(270, 78);
            this.btnRataLunara.TabIndex = 1;
            this.btnRataLunara.Text = "Rata Lunară";
            this.btnRataLunara.UseVisualStyleBackColor = true;
            this.btnRataLunara.Click += new System.EventHandler(this.btnRataLunara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectează opțiunea dorită:";
            // 
            // mnuOptiuni
            // 
            this.mnuOptiuni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuOptiuni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnuOptiuni.Location = new System.Drawing.Point(0, 0);
            this.mnuOptiuni.Name = "mnuOptiuni";
            this.mnuOptiuni.Size = new System.Drawing.Size(826, 27);
            this.mnuOptiuni.TabIndex = 1;
            this.mnuOptiuni.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuniRataLunara,
            this.mnuOptiuniDurata,
            this.mnuOptiuniExit});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem1.Text = "&Optiuni";
            // 
            // mnuOptiuniRataLunara
            // 
            this.mnuOptiuniRataLunara.Name = "mnuOptiuniRataLunara";
            this.mnuOptiuniRataLunara.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuOptiuniRataLunara.Size = new System.Drawing.Size(241, 26);
            this.mnuOptiuniRataLunara.Text = "&Rata lunară";
            this.mnuOptiuniRataLunara.Click += new System.EventHandler(this.mnuOptiuniRataLunara_Click);
            // 
            // mnuOptiuniDurata
            // 
            this.mnuOptiuniDurata.Name = "mnuOptiuniDurata";
            this.mnuOptiuniDurata.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuOptiuniDurata.Size = new System.Drawing.Size(241, 26);
            this.mnuOptiuniDurata.Text = "&Durata";
            this.mnuOptiuniDurata.Click += new System.EventHandler(this.mnuOptiuniDurata_Click);
            // 
            // mnuOptiuniExit
            // 
            this.mnuOptiuniExit.Name = "mnuOptiuniExit";
            this.mnuOptiuniExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.mnuOptiuniExit.Size = new System.Drawing.Size(241, 26);
            this.mnuOptiuniExit.Text = "&Exit";
            this.mnuOptiuniExit.Click += new System.EventHandler(this.mnuOptiuniExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 20);
            this.toolStripStatusLabel1.Text = "Optiuni";
            // 
            // frmCalculatorCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 440);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuOptiuni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.mnuOptiuni;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalculatorCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Credit";
            this.Load += new System.EventHandler(this.frmCalculatorCredit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuOptiuni.ResumeLayout(false);
            this.mnuOptiuni.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnuOptiuni;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniRataLunara;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniDurata;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDurata;
        private System.Windows.Forms.Button btnRataLunara;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

