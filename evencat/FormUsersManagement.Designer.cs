namespace evencat
{
    partial class FormUsersManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonCreateReservation = new System.Windows.Forms.Button();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUsersManagement = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ColumnUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserPasswordHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserRegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panelDataGridView.Controls.Add(this.dataGridViewUsers);
            this.panelDataGridView.Location = new System.Drawing.Point(49, 213);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(869, 275);
            this.panelDataGridView.TabIndex = 15;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.ColumnHeadersHeight = 35;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUserId,
            this.ColumnUserEmail,
            this.ColumnUserPasswordHash,
            this.ColumnUserRole,
            this.ColumnUserRegisterDate,
            this.ColumnUserCreatedBy});
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.Location = new System.Drawing.Point(7, 5);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.Size = new System.Drawing.Size(852, 259);
            this.dataGridViewUsers.TabIndex = 5;
            // 
            // buttonCreateReservation
            // 
            this.buttonCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateReservation.Location = new System.Drawing.Point(747, 494);
            this.buttonCreateReservation.Name = "buttonCreateReservation";
            this.buttonCreateReservation.Size = new System.Drawing.Size(161, 26);
            this.buttonCreateReservation.TabIndex = 16;
            this.buttonCreateReservation.Text = "Create reservation";
            this.buttonCreateReservation.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Location = new System.Drawing.Point(56, 168);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(140, 26);
            this.comboBoxOrderBy.TabIndex = 17;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUser.Location = new System.Drawing.Point(532, 164);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(135, 30);
            this.buttonCreateUser.TabIndex = 20;
            this.buttonCreateUser.Text = "Create user";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(689, 164);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 30);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(811, 164);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 30);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelSearch.Controls.Add(this.comboBoxUserType);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxUserName);
            this.panelSearch.Location = new System.Drawing.Point(49, 102);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(859, 41);
            this.panelSearch.TabIndex = 13;
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Location = new System.Drawing.Point(597, 7);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(140, 26);
            this.comboBoxUserType.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(744, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(97, 30);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(16, 7);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(575, 26);
            this.textBoxUserName.TabIndex = 4;
            // 
            // labelUsersManagement
            // 
            this.labelUsersManagement.AutoSize = true;
            this.labelUsersManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsersManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsersManagement.Location = new System.Drawing.Point(146, -3);
            this.labelUsersManagement.Name = "labelUsersManagement";
            this.labelUsersManagement.Size = new System.Drawing.Size(646, 65);
            this.labelUsersManagement.TabIndex = 12;
            this.labelUsersManagement.Text = "USERS MANAGEMENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::evencat.Resource1.evencatLogoWhite;
            this.pictureBox1.Location = new System.Drawing.Point(902, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::evencat.Resource1.menuIconWhite;
            this.pictureBox2.Location = new System.Drawing.Point(12, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ColumnUserId
            // 
            this.ColumnUserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUserId.FillWeight = 150F;
            this.ColumnUserId.HeaderText = "id";
            this.ColumnUserId.Name = "ColumnUserId";
            // 
            // ColumnUserEmail
            // 
            this.ColumnUserEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUserEmail.FillWeight = 150F;
            this.ColumnUserEmail.HeaderText = "email";
            this.ColumnUserEmail.Name = "ColumnUserEmail";
            // 
            // ColumnUserPasswordHash
            // 
            this.ColumnUserPasswordHash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUserPasswordHash.FillWeight = 150F;
            this.ColumnUserPasswordHash.HeaderText = "password_hash";
            this.ColumnUserPasswordHash.Name = "ColumnUserPasswordHash";
            // 
            // ColumnUserRole
            // 
            this.ColumnUserRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUserRole.FillWeight = 150F;
            this.ColumnUserRole.HeaderText = "role";
            this.ColumnUserRole.Name = "ColumnUserRole";
            // 
            // ColumnUserRegisterDate
            // 
            this.ColumnUserRegisterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUserRegisterDate.FillWeight = 150F;
            this.ColumnUserRegisterDate.HeaderText = "register_date";
            this.ColumnUserRegisterDate.Name = "ColumnUserRegisterDate";
            // 
            // ColumnUserCreatedBy
            // 
            this.ColumnUserCreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUserCreatedBy.FillWeight = 150F;
            this.ColumnUserCreatedBy.HeaderText = "created_by";
            this.ColumnUserCreatedBy.Name = "ColumnUserCreatedBy";
            // 
            // FormUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.buttonCreateReservation);
            this.Controls.Add(this.comboBoxOrderBy);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.labelUsersManagement);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormUsersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUsersManagement";
            this.Load += new System.EventHandler(this.FormUsersManagement_Load);
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonCreateReservation;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUsersManagement;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserPasswordHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserRegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserCreatedBy;
    }
}