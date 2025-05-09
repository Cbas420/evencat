namespace evencat
{
    partial class FormSelectOption
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
            this.panelSelectButton = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonSpacesManagement = new System.Windows.Forms.Button();
            this.buttonUsersManagement = new System.Windows.Forms.Button();
            this.panelSelectButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelectButton
            // 
            this.panelSelectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSelectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSelectButton.Controls.Add(this.buttonLogOut);
            this.panelSelectButton.Controls.Add(this.buttonSpacesManagement);
            this.panelSelectButton.Controls.Add(this.buttonUsersManagement);
            this.panelSelectButton.Location = new System.Drawing.Point(264, 26);
            this.panelSelectButton.Name = "panelSelectButton";
            this.panelSelectButton.Size = new System.Drawing.Size(446, 464);
            this.panelSelectButton.TabIndex = 3;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Image = global::evencat.Resource1.logOutIcon;
            this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.Location = new System.Drawing.Point(140, 266);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonLogOut.Size = new System.Drawing.Size(161, 80);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Log out       ";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonSpacesManagement
            // 
            this.buttonSpacesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpacesManagement.Image = global::evencat.Resource1.spacesManagementIcon;
            this.buttonSpacesManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSpacesManagement.Location = new System.Drawing.Point(99, 40);
            this.buttonSpacesManagement.Name = "buttonSpacesManagement";
            this.buttonSpacesManagement.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonSpacesManagement.Size = new System.Drawing.Size(280, 106);
            this.buttonSpacesManagement.TabIndex = 0;
            this.buttonSpacesManagement.Text = "Spaces       \r\nmanagement";
            this.buttonSpacesManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSpacesManagement.UseVisualStyleBackColor = true;
            this.buttonSpacesManagement.Click += new System.EventHandler(this.buttonSpacesManagement_Click);
            // 
            // buttonUsersManagement
            // 
            this.buttonUsersManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersManagement.Image = global::evencat.Resource1.usersManagementIcon;
            this.buttonUsersManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsersManagement.Location = new System.Drawing.Point(120, 167);
            this.buttonUsersManagement.Name = "buttonUsersManagement";
            this.buttonUsersManagement.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonUsersManagement.Size = new System.Drawing.Size(228, 78);
            this.buttonUsersManagement.TabIndex = 1;
            this.buttonUsersManagement.Text = "Users         \r\nmanagement";
            this.buttonUsersManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUsersManagement.UseVisualStyleBackColor = true;
            this.buttonUsersManagement.Click += new System.EventHandler(this.buttonUsersManagement_Click);
            // 
            // FormSelectOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(138)))), ((int)(((byte)(191)))));
            this.BackgroundImage = global::evencat.Resource1.backgroundUsersPanel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 531);
            this.Controls.Add(this.panelSelectButton);
            this.DoubleBuffered = true;
            this.Name = "FormSelectOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSelectOption_Load);
            this.panelSelectButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSelectButton;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonSpacesManagement;
        private System.Windows.Forms.Button buttonUsersManagement;
    }
}