namespace evencat
{
    partial class FormStart
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.pictureBoxLogoWhite = new System.Windows.Forms.PictureBox();
            this.labelEvencat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Location = new System.Drawing.Point(398, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 477);
            this.panel1.TabIndex = 0;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNext.Location = new System.Drawing.Point(105, 267);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonNext.Size = new System.Drawing.Size(209, 54);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(17, 123);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(371, 110);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "START USING \r\nOUR APP";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogoWhite
            // 
            this.pictureBoxLogoWhite.Image = global::evencat.Resource1.evencatLogoWhite2;
            this.pictureBoxLogoWhite.Location = new System.Drawing.Point(84, 48);
            this.pictureBoxLogoWhite.Name = "pictureBoxLogoWhite";
            this.pictureBoxLogoWhite.Size = new System.Drawing.Size(230, 224);
            this.pictureBoxLogoWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoWhite.TabIndex = 1;
            this.pictureBoxLogoWhite.TabStop = false;
            // 
            // labelEvencat
            // 
            this.labelEvencat.AutoSize = true;
            this.labelEvencat.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvencat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEvencat.Location = new System.Drawing.Point(109, 275);
            this.labelEvencat.Name = "labelEvencat";
            this.labelEvencat.Size = new System.Drawing.Size(194, 40);
            this.labelEvencat.TabIndex = 2;
            this.labelEvencat.Text = "EVENCAT";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(138)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEvencat);
            this.Controls.Add(this.pictureBoxLogoWhite);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoWhite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogoWhite;
        private System.Windows.Forms.Label labelEvencat;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonNext;
    }
}

