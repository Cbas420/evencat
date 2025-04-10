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
            this.panelSelectButton.Location = new System.Drawing.Point(266, 45);
            this.panelSelectButton.Name = "panelSelectButton";
            this.panelSelectButton.Size = new System.Drawing.Size(446, 426);
            this.panelSelectButton.TabIndex = 3;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(183, 274);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(122, 32);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSpacesManagement
            // 
            this.buttonSpacesManagement.Location = new System.Drawing.Point(180, 75);
            this.buttonSpacesManagement.Name = "buttonSpacesManagement";
            this.buttonSpacesManagement.Size = new System.Drawing.Size(125, 49);
            this.buttonSpacesManagement.TabIndex = 0;
            this.buttonSpacesManagement.Text = "Spaces management";
            this.buttonSpacesManagement.UseVisualStyleBackColor = true;
            this.buttonSpacesManagement.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUsersManagement
            // 
            this.buttonUsersManagement.Location = new System.Drawing.Point(183, 183);
            this.buttonUsersManagement.Name = "buttonUsersManagement";
            this.buttonUsersManagement.Size = new System.Drawing.Size(122, 48);
            this.buttonUsersManagement.TabIndex = 1;
            this.buttonUsersManagement.Text = "Users management";
            this.buttonUsersManagement.UseVisualStyleBackColor = true;
            this.buttonUsersManagement.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormSelectOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(967, 531);
            this.Controls.Add(this.panelSelectButton);
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