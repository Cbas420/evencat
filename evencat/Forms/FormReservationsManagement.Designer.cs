namespace evencat
{
    partial class FormReservationsManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservationsManagement));
            this.labelReservationsManagement = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchUser = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenuIcon = new System.Windows.Forms.PictureBox();
            this.reservaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datareservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butacaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceReserves = new System.Windows.Forms.BindingSource(this.components);
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReserves)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReservationsManagement
            // 
            this.labelReservationsManagement.AutoSize = true;
            this.labelReservationsManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationsManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReservationsManagement.Location = new System.Drawing.Point(122, 21);
            this.labelReservationsManagement.Name = "labelReservationsManagement";
            this.labelReservationsManagement.Size = new System.Drawing.Size(738, 54);
            this.labelReservationsManagement.TabIndex = 13;
            this.labelReservationsManagement.Text = "RESERVATIONS MANAGEMENT";
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
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchUser
            // 
            this.textBoxSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchUser.Location = new System.Drawing.Point(16, 7);
            this.textBoxSearchUser.Name = "textBoxSearchUser";
            this.textBoxSearchUser.Size = new System.Drawing.Size(704, 26);
            this.textBoxSearchUser.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(49, 501);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 30);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxSearchUser);
            this.panelSearch.Location = new System.Drawing.Point(49, 109);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(859, 41);
            this.panelSearch.TabIndex = 14;
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToAddRows = false;
            this.dataGridViewReservations.AllowUserToDeleteRows = false;
            this.dataGridViewReservations.AutoGenerateColumns = false;
            this.dataGridViewReservations.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReservations.ColumnHeadersHeight = 35;
            this.dataGridViewReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservaidDataGridViewTextBoxColumn,
            this.datareservaDataGridViewTextBoxColumn,
            this.usuariidDataGridViewTextBoxColumn,
            this.eventidDataGridViewTextBoxColumn,
            this.butacaidDataGridViewTextBoxColumn});
            this.dataGridViewReservations.DataSource = this.bindingSourceReserves;
            this.dataGridViewReservations.EnableHeadersVisualStyles = false;
            this.dataGridViewReservations.Location = new System.Drawing.Point(16, 5);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.ReadOnly = true;
            this.dataGridViewReservations.RowHeadersVisible = false;
            this.dataGridViewReservations.Size = new System.Drawing.Size(510, 247);
            this.dataGridViewReservations.TabIndex = 5;
            this.dataGridViewReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservations_CellClick);
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panelDataGridView.Controls.Add(this.dataGridViewReservations);
            this.panelDataGridView.Location = new System.Drawing.Point(49, 220);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(539, 275);
            this.panelDataGridView.TabIndex = 18;
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserEmail.Location = new System.Drawing.Point(620, 314);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.Size = new System.Drawing.Size(322, 24);
            this.textBoxUserEmail.TabIndex = 21;
            this.textBoxUserEmail.Text = "Email";
            this.textBoxUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(620, 270);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(322, 24);
            this.textBoxUserName.TabIndex = 20;
            this.textBoxUserName.Text = "Name";
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEventName.Location = new System.Drawing.Point(620, 359);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(322, 24);
            this.textBoxEventName.TabIndex = 22;
            this.textBoxEventName.Text = "Event name";
            this.textBoxEventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(49, 186);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 23;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFilter.Location = new System.Drawing.Point(491, 182);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(97, 30);
            this.buttonApplyFilter.TabIndex = 24;
            this.buttonApplyFilter.Text = "Apply";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(276, 186);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 25;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::evencat.Resource1.evencatLogoWhite;
            this.pictureBoxLogo.Location = new System.Drawing.Point(902, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 15;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxMenuIcon
            // 
            this.pictureBoxMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenuIcon.Image = global::evencat.Resource1.exitArrowIcon;
            this.pictureBoxMenuIcon.Location = new System.Drawing.Point(12, 25);
            this.pictureBoxMenuIcon.Name = "pictureBoxMenuIcon";
            this.pictureBoxMenuIcon.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuIcon.TabIndex = 12;
            this.pictureBoxMenuIcon.TabStop = false;
            this.pictureBoxMenuIcon.Click += new System.EventHandler(this.pictureBoxMenuIcon_Click);
            // 
            // reservaidDataGridViewTextBoxColumn
            // 
            this.reservaidDataGridViewTextBoxColumn.DataPropertyName = "reserva_id";
            this.reservaidDataGridViewTextBoxColumn.HeaderText = "reserva_id";
            this.reservaidDataGridViewTextBoxColumn.Name = "reservaidDataGridViewTextBoxColumn";
            this.reservaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datareservaDataGridViewTextBoxColumn
            // 
            this.datareservaDataGridViewTextBoxColumn.DataPropertyName = "data_reserva";
            this.datareservaDataGridViewTextBoxColumn.HeaderText = "data_reserva";
            this.datareservaDataGridViewTextBoxColumn.Name = "datareservaDataGridViewTextBoxColumn";
            this.datareservaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datareservaDataGridViewTextBoxColumn.Width = 110;
            // 
            // usuariidDataGridViewTextBoxColumn
            // 
            this.usuariidDataGridViewTextBoxColumn.DataPropertyName = "usuari_id";
            this.usuariidDataGridViewTextBoxColumn.HeaderText = "usuari_id";
            this.usuariidDataGridViewTextBoxColumn.Name = "usuariidDataGridViewTextBoxColumn";
            this.usuariidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "event_id";
            this.eventidDataGridViewTextBoxColumn.HeaderText = "event_id";
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            this.eventidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // butacaidDataGridViewTextBoxColumn
            // 
            this.butacaidDataGridViewTextBoxColumn.DataPropertyName = "butaca_id";
            this.butacaidDataGridViewTextBoxColumn.HeaderText = "butaca_id";
            this.butacaidDataGridViewTextBoxColumn.Name = "butacaidDataGridViewTextBoxColumn";
            this.butacaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceReserves
            // 
            this.bindingSourceReserves.DataSource = typeof(evencat.Models.Reserves);
            // 
            // FormReservationsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 543);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.textBoxEventName);
            this.Controls.Add(this.textBoxUserEmail);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelReservationsManagement);
            this.Controls.Add(this.pictureBoxMenuIcon);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReservationsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReservationsManagement";
            this.Load += new System.EventHandler(this.FormReservationsManagement_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReserves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelReservationsManagement;
        private System.Windows.Forms.PictureBox pictureBoxMenuIcon;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchUser;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.BindingSource bindingSourceReserves;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datareservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn butacaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}