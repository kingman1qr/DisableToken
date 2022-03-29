
namespace DisableToken
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HeadPnl = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.HeadServerLbl = new System.Windows.Forms.Label();
            this.CreditsBtn = new System.Windows.Forms.Button();
            this.ColorBackPnl = new RoundPanel();
            this.UserLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DisableTokenBtn = new System.Windows.Forms.Button();
            this.roundPanel14 = new RoundPanel();
            this.TokenTxt = new System.Windows.Forms.TextBox();
            this.HeadPnl.SuspendLayout();
            this.ColorBackPnl.SuspendLayout();
            this.roundPanel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPnl
            // 
            this.HeadPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.HeadPnl.Controls.Add(this.btnClose);
            this.HeadPnl.Controls.Add(this.btnMini);
            this.HeadPnl.Controls.Add(this.HeadServerLbl);
            this.HeadPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPnl.Location = new System.Drawing.Point(0, 0);
            this.HeadPnl.Name = "HeadPnl";
            this.HeadPnl.Size = new System.Drawing.Size(424, 21);
            this.HeadPnl.TabIndex = 3;
            this.HeadPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.HeadPnl_Paint);
            this.HeadPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPnl_MouseDown);
            this.HeadPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadPnl_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(398, -4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 32);
            this.btnClose.TabIndex = 6171;
            this.btnClose.Text = "r";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnMini.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(372, -2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(26, 23);
            this.btnMini.TabIndex = 6170;
            this.btnMini.Text = "0";
            this.btnMini.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // HeadServerLbl
            // 
            this.HeadServerLbl.AutoSize = true;
            this.HeadServerLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.HeadServerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.HeadServerLbl.Location = new System.Drawing.Point(1, 3);
            this.HeadServerLbl.Name = "HeadServerLbl";
            this.HeadServerLbl.Size = new System.Drawing.Size(95, 16);
            this.HeadServerLbl.TabIndex = 6169;
            this.HeadServerLbl.Text = "Disable Token";
            this.HeadServerLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadServerLbl_MouseDown);
            this.HeadServerLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadServerLbl_MouseMove);
            // 
            // CreditsBtn
            // 
            this.CreditsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CreditsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CreditsBtn.FlatAppearance.BorderSize = 0;
            this.CreditsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CreditsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CreditsBtn.ForeColor = System.Drawing.Color.Silver;
            this.CreditsBtn.Location = new System.Drawing.Point(14, 129);
            this.CreditsBtn.Name = "CreditsBtn";
            this.CreditsBtn.Size = new System.Drawing.Size(400, 21);
            this.CreditsBtn.TabIndex = 6466;
            this.CreditsBtn.Text = "Kingman Server";
            this.CreditsBtn.UseVisualStyleBackColor = false;
            this.CreditsBtn.Click += new System.EventHandler(this.CreditsBtn_Click);
            // 
            // ColorBackPnl
            // 
            this.ColorBackPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ColorBackPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ColorBackPnl.Controls.Add(this.UserLbl);
            this.ColorBackPnl.Controls.Add(this.label14);
            this.ColorBackPnl.Controls.Add(this.DisableTokenBtn);
            this.ColorBackPnl.Controls.Add(this.roundPanel14);
            this.ColorBackPnl.Location = new System.Drawing.Point(15, 34);
            this.ColorBackPnl.Name = "ColorBackPnl";
            this.ColorBackPnl.Radius = 16;
            this.ColorBackPnl.Size = new System.Drawing.Size(400, 91);
            this.ColorBackPnl.TabIndex = 6465;
            this.ColorBackPnl.Thickness = 5F;
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.UserLbl.ForeColor = System.Drawing.Color.Silver;
            this.UserLbl.Location = new System.Drawing.Point(55, 48);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(29, 16);
            this.UserLbl.TabIndex = 6391;
            this.UserLbl.Text = "N/A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(16, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 6390;
            this.label14.Text = "USER:";
            // 
            // DisableTokenBtn
            // 
            this.DisableTokenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.DisableTokenBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.DisableTokenBtn.FlatAppearance.BorderSize = 0;
            this.DisableTokenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.DisableTokenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisableTokenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold);
            this.DisableTokenBtn.ForeColor = System.Drawing.Color.Silver;
            this.DisableTokenBtn.Location = new System.Drawing.Point(252, 51);
            this.DisableTokenBtn.Name = "DisableTokenBtn";
            this.DisableTokenBtn.Size = new System.Drawing.Size(133, 25);
            this.DisableTokenBtn.TabIndex = 6385;
            this.DisableTokenBtn.Text = "DISABLE TOKEN";
            this.DisableTokenBtn.UseVisualStyleBackColor = false;
            this.DisableTokenBtn.Click += new System.EventHandler(this.DisableTokenBtn_Click);
            // 
            // roundPanel14
            // 
            this.roundPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.roundPanel14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.roundPanel14.Controls.Add(this.TokenTxt);
            this.roundPanel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.roundPanel14.Location = new System.Drawing.Point(15, 16);
            this.roundPanel14.Name = "roundPanel14";
            this.roundPanel14.Radius = 16;
            this.roundPanel14.Size = new System.Drawing.Size(370, 26);
            this.roundPanel14.TabIndex = 6384;
            this.roundPanel14.Thickness = 5F;
            // 
            // TokenTxt
            // 
            this.TokenTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.TokenTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TokenTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.TokenTxt.Location = new System.Drawing.Point(3, 4);
            this.TokenTxt.Name = "TokenTxt";
            this.TokenTxt.Size = new System.Drawing.Size(364, 18);
            this.TokenTxt.TabIndex = 6153;
            this.TokenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TokenTxt.TextChanged += new System.EventHandler(this.TokenTxt_TextChanged);
            this.TokenTxt.Enter += new System.EventHandler(this.TokenTxt_Enter);
            this.TokenTxt.Leave += new System.EventHandler(this.TokenTxt_Leave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(424, 154);
            this.Controls.Add(this.CreditsBtn);
            this.Controls.Add(this.ColorBackPnl);
            this.Controls.Add(this.HeadPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.HeadPnl.ResumeLayout(false);
            this.HeadPnl.PerformLayout();
            this.ColorBackPnl.ResumeLayout(false);
            this.ColorBackPnl.PerformLayout();
            this.roundPanel14.ResumeLayout(false);
            this.roundPanel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeadPnl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Label HeadServerLbl;
        private RoundPanel roundPanel14;
        public System.Windows.Forms.TextBox TokenTxt;
        private RoundPanel ColorBackPnl;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button DisableTokenBtn;
        private System.Windows.Forms.Button CreditsBtn;
    }
}

