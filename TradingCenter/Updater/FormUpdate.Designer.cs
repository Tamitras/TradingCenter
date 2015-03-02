namespace Updater
{
    partial class FormUpdate
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
            this.btnSetReady = new System.Windows.Forms.Button();
            this.btnAbortUpdate = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetReady
            // 
            this.btnSetReady.Enabled = false;
            this.btnSetReady.Location = new System.Drawing.Point(220, 76);
            this.btnSetReady.Name = "btnSetReady";
            this.btnSetReady.Size = new System.Drawing.Size(118, 34);
            this.btnSetReady.TabIndex = 0;
            this.btnSetReady.Text = "Abschließen";
            this.btnSetReady.UseVisualStyleBackColor = true;
            // 
            // btnAbortUpdate
            // 
            this.btnAbortUpdate.Location = new System.Drawing.Point(344, 76);
            this.btnAbortUpdate.Name = "btnAbortUpdate";
            this.btnAbortUpdate.Size = new System.Drawing.Size(118, 34);
            this.btnAbortUpdate.TabIndex = 1;
            this.btnAbortUpdate.Text = "Abbrechen";
            this.btnAbortUpdate.UseVisualStyleBackColor = true;
            this.btnAbortUpdate.Click += new System.EventHandler(this.btnAbortUpdate_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(450, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uploading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "sfdsfdsf";
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 122);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAbortUpdate);
            this.Controls.Add(this.btnSetReady);
            this.Name = "FormUpdate";
            this.Text = "TradingCenter";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetReady;
        private System.Windows.Forms.Button btnAbortUpdate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

