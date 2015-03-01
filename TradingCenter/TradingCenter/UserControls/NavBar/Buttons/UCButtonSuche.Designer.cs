namespace TradingCenter.UserControls.NavBar.Buttons
{
    partial class UCButtonSuche
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
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.buttonUsingObjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlayer.BackColor = System.Drawing.Color.Silver;
            this.buttonPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonPlayer.Location = new System.Drawing.Point(3, 2);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(172, 25);
            this.buttonPlayer.TabIndex = 12;
            this.buttonPlayer.Text = "Spieler";
            this.buttonPlayer.UseVisualStyleBackColor = false;
            this.buttonPlayer.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // buttonUsingObjects
            // 
            this.buttonUsingObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUsingObjects.BackColor = System.Drawing.Color.Silver;
            this.buttonUsingObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsingObjects.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonUsingObjects.Location = new System.Drawing.Point(3, 33);
            this.buttonUsingObjects.Name = "buttonUsingObjects";
            this.buttonUsingObjects.Size = new System.Drawing.Size(172, 25);
            this.buttonUsingObjects.TabIndex = 13;
            this.buttonUsingObjects.Text = "Verbrauchsobjekte";
            this.buttonUsingObjects.UseVisualStyleBackColor = false;
            // 
            // UCButtonSuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUsingObjects);
            this.Controls.Add(this.buttonPlayer);
            this.Name = "UCButtonSuche";
            this.Size = new System.Drawing.Size(179, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Button buttonUsingObjects;
    }
}
