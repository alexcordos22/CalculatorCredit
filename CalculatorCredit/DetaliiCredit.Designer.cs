
namespace CalculatorCredit
{
    partial class frmDetaliiCredit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOptiuniCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniCreditRataLunara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniCreditDurata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniCreditExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNouaCalculatie = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.txtRataLunara = new System.Windows.Forms.TextBox();
            this.txtRataDobanda = new System.Windows.Forms.TextBox();
            this.txtNumarPlati = new System.Windows.Forms.TextBox();
            this.txtSumaImprumutata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsOptiuni = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuniCredit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(958, 33);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(958, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOptiuniCredit
            // 
            this.mnuOptiuniCredit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuniCreditRataLunara,
            this.mnuOptiuniCreditDurata,
            this.mnuOptiuniCreditExit});
            this.mnuOptiuniCredit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mnuOptiuniCredit.Name = "mnuOptiuniCredit";
            this.mnuOptiuniCredit.Size = new System.Drawing.Size(93, 29);
            this.mnuOptiuniCredit.Text = "&Optiuni";
            // 
            // mnuOptiuniCreditRataLunara
            // 
            this.mnuOptiuniCreditRataLunara.Name = "mnuOptiuniCreditRataLunara";
            this.mnuOptiuniCreditRataLunara.Size = new System.Drawing.Size(208, 30);
            this.mnuOptiuniCreditRataLunara.Text = "&Rata Lunara";
            this.mnuOptiuniCreditRataLunara.Click += new System.EventHandler(this.mnuOptiuniCreditRataLunara_Click);
            // 
            // mnuOptiuniCreditDurata
            // 
            this.mnuOptiuniCreditDurata.Name = "mnuOptiuniCreditDurata";
            this.mnuOptiuniCreditDurata.Size = new System.Drawing.Size(208, 30);
            this.mnuOptiuniCreditDurata.Text = "&Durata";
            this.mnuOptiuniCreditDurata.Click += new System.EventHandler(this.mnuOptiuniCreditDurata_Click);
            // 
            // mnuOptiuniCreditExit
            // 
            this.mnuOptiuniCreditExit.Name = "mnuOptiuniCreditExit";
            this.mnuOptiuniCreditExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuOptiuniCreditExit.Size = new System.Drawing.Size(208, 30);
            this.mnuOptiuniCreditExit.Text = "&Ieșire";
            this.mnuOptiuniCreditExit.Click += new System.EventHandler(this.mnuOptiuniCreditExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 417);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit1);
            this.groupBox2.Controls.Add(this.lstAfisare);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(546, 0);
            this.groupBox2.MinimumSize = new System.Drawing.Size(472, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 417);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amortizare";
            // 
            // btnExit1
            // 
            this.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit1.ForeColor = System.Drawing.Color.Turquoise;
            this.btnExit1.Location = new System.Drawing.Point(200, 299);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(212, 52);
            this.btnExit1.TabIndex = 9;
            this.btnExit1.Text = "Ieșire";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 20;
            this.lstAfisare.Location = new System.Drawing.Point(36, 46);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(504, 224);
            this.lstAfisare.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNouaCalculatie);
            this.groupBox1.Controls.Add(this.btnCalculeaza);
            this.groupBox1.Controls.Add(this.txtRataLunara);
            this.groupBox1.Controls.Add(this.txtRataDobanda);
            this.groupBox1.Controls.Add(this.txtNumarPlati);
            this.groupBox1.Controls.Add(this.txtSumaImprumutata);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(480, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii ";
            // 
            // btnNouaCalculatie
            // 
            this.btnNouaCalculatie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouaCalculatie.ForeColor = System.Drawing.Color.Lime;
            this.btnNouaCalculatie.Location = new System.Drawing.Point(275, 299);
            this.btnNouaCalculatie.Name = "btnNouaCalculatie";
            this.btnNouaCalculatie.Size = new System.Drawing.Size(212, 52);
            this.btnNouaCalculatie.TabIndex = 5;
            this.btnNouaCalculatie.Text = "Noua Calculație";
            this.btnNouaCalculatie.UseVisualStyleBackColor = true;
            this.btnNouaCalculatie.Click += new System.EventHandler(this.btnNouaCalculatie_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculeaza.ForeColor = System.Drawing.Color.Yellow;
            this.btnCalculeaza.Location = new System.Drawing.Point(34, 299);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(212, 52);
            this.btnCalculeaza.TabIndex = 4;
            this.btnCalculeaza.Text = "Calculează";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // txtRataLunara
            // 
            this.txtRataLunara.Location = new System.Drawing.Point(291, 222);
            this.txtRataLunara.Multiline = true;
            this.txtRataLunara.Name = "txtRataLunara";
            this.txtRataLunara.Size = new System.Drawing.Size(185, 25);
            this.txtRataLunara.TabIndex = 3;
            this.txtRataLunara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRataDobanda
            // 
            this.txtRataDobanda.Location = new System.Drawing.Point(291, 175);
            this.txtRataDobanda.Multiline = true;
            this.txtRataDobanda.Name = "txtRataDobanda";
            this.txtRataDobanda.Size = new System.Drawing.Size(185, 25);
            this.txtRataDobanda.TabIndex = 2;
            this.txtRataDobanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumarPlati
            // 
            this.txtNumarPlati.Location = new System.Drawing.Point(331, 124);
            this.txtNumarPlati.Multiline = true;
            this.txtNumarPlati.Name = "txtNumarPlati";
            this.txtNumarPlati.Size = new System.Drawing.Size(110, 25);
            this.txtNumarPlati.TabIndex = 1;
            this.txtNumarPlati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumaImprumutata
            // 
            this.txtSumaImprumutata.Location = new System.Drawing.Point(291, 72);
            this.txtSumaImprumutata.Multiline = true;
            this.txtSumaImprumutata.Name = "txtSumaImprumutata";
            this.txtSumaImprumutata.Size = new System.Drawing.Size(185, 25);
            this.txtSumaImprumutata.TabIndex = 0;
            this.txtSumaImprumutata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(76, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rata Lunară";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(88, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dobânda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(70, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Durata lunară";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suma Împrumutată";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsOptiuni});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1122, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsOptiuni
            // 
            this.tlsOptiuni.Name = "tlsOptiuni";
            this.tlsOptiuni.Size = new System.Drawing.Size(58, 20);
            this.tlsOptiuni.Text = "Optiuni";
            // 
            // frmDetaliiCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDetaliiCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalii Credit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetaliiAngajati_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCredit;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCreditRataLunara;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCreditDurata;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCreditExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtRataLunara;
        internal System.Windows.Forms.TextBox txtRataDobanda;
        internal System.Windows.Forms.TextBox txtNumarPlati;
        internal System.Windows.Forms.TextBox txtSumaImprumutata;
        internal System.Windows.Forms.ListBox lstAfisare;
        internal System.Windows.Forms.ToolStripStatusLabel tlsOptiuni;
        internal System.Windows.Forms.Button btnExit1;
        internal System.Windows.Forms.Button btnNouaCalculatie;
        internal System.Windows.Forms.Button btnCalculeaza;
    }
}