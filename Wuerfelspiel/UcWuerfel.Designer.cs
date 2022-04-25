
namespace Wuerfelspiel
{
    partial class UcWuerfel
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWürfelNr = new System.Windows.Forms.Label();
            this.tbxAugenAnzah = new System.Windows.Forms.TextBox();
            this.btnGesichert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWürfelNr
            // 
            this.lblWürfelNr.AutoSize = true;
            this.lblWürfelNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.9434F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWürfelNr.Location = new System.Drawing.Point(22, 0);
            this.lblWürfelNr.Name = "lblWürfelNr";
            this.lblWürfelNr.Size = new System.Drawing.Size(106, 29);
            this.lblWürfelNr.TabIndex = 1;
            this.lblWürfelNr.Text = "Würfel N";
            // 
            // tbxAugenAnzah
            // 
            this.tbxAugenAnzah.BackColor = System.Drawing.SystemColors.Window;
            this.tbxAugenAnzah.Location = new System.Drawing.Point(27, 55);
            this.tbxAugenAnzah.Multiline = true;
            this.tbxAugenAnzah.Name = "tbxAugenAnzah";
            this.tbxAugenAnzah.Size = new System.Drawing.Size(100, 20);
            this.tbxAugenAnzah.TabIndex = 2;
            // 
            // btnGesichert
            // 
            this.btnGesichert.Location = new System.Drawing.Point(37, 106);
            this.btnGesichert.Name = "btnGesichert";
            this.btnGesichert.Size = new System.Drawing.Size(75, 23);
            this.btnGesichert.TabIndex = 3;
            this.btnGesichert.Text = "Sichern?";
            this.btnGesichert.UseVisualStyleBackColor = true;
            this.btnGesichert.Click += new System.EventHandler(this.btnGesichert_Click);
            // 
            // UcWuerfel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGesichert);
            this.Controls.Add(this.tbxAugenAnzah);
            this.Controls.Add(this.lblWürfelNr);
            this.Name = "UcWuerfel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWürfelNr;
        private System.Windows.Forms.TextBox tbxAugenAnzah;
        private System.Windows.Forms.Button btnGesichert;
    }
}
