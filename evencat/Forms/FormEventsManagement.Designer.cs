namespace evencat
{
    partial class FormEventsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventsManagement));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelEventsManagement = new System.Windows.Forms.Label();
            this.pictureBoxMenuIcon = new System.Windows.Forms.PictureBox();
            this.comboBoxCurrentStatus = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.imatge_promocional_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.buttonSaveEdit = new System.Windows.Forms.Button();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espaiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organitzadoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEventsDataGrid = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuIcon)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::evencat.Resource1.evencatLogoWhite;
            this.pictureBoxLogo.Location = new System.Drawing.Point(902, 17);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 15;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelEventsManagement
            // 
            this.labelEventsManagement.AutoSize = true;
            this.labelEventsManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEventsManagement.Location = new System.Drawing.Point(146, -1);
            this.labelEventsManagement.Name = "labelEventsManagement";
            this.labelEventsManagement.Size = new System.Drawing.Size(678, 65);
            this.labelEventsManagement.TabIndex = 13;
            this.labelEventsManagement.Text = "EVENTS MANAGEMENT";
            // 
            // pictureBoxMenuIcon
            // 
            this.pictureBoxMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenuIcon.Image = global::evencat.Resource1.exitArrowIcon;
            this.pictureBoxMenuIcon.Location = new System.Drawing.Point(12, 20);
            this.pictureBoxMenuIcon.Name = "pictureBoxMenuIcon";
            this.pictureBoxMenuIcon.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuIcon.TabIndex = 12;
            this.pictureBoxMenuIcon.TabStop = false;
            this.pictureBoxMenuIcon.Click += new System.EventHandler(this.pictureBoxMenuIcon_Click);
            // 
            // comboBoxCurrentStatus
            // 
            this.comboBoxCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrentStatus.FormattingEnabled = true;
            this.comboBoxCurrentStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "Finished",
            "Cancelled"});
            this.comboBoxCurrentStatus.Location = new System.Drawing.Point(597, 7);
            this.comboBoxCurrentStatus.Name = "comboBoxCurrentStatus";
            this.comboBoxCurrentStatus.Size = new System.Drawing.Size(140, 26);
            this.comboBoxCurrentStatus.TabIndex = 7;
            this.comboBoxCurrentStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrentStatus_SelectedIndexChanged);
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
            // textBoxEventName
            // 
            this.textBoxEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEventName.Location = new System.Drawing.Point(16, 7);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(575, 26);
            this.textBoxEventName.TabIndex = 4;
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBoxOrderBy.Location = new System.Drawing.Point(56, 170);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(140, 26);
            this.comboBoxOrderBy.TabIndex = 16;
            this.comboBoxOrderBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderBy_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(821, 179);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 30);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelSearch.Controls.Add(this.comboBoxCurrentStatus);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxEventName);
            this.panelSearch.Location = new System.Drawing.Point(49, 104);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(859, 41);
            this.panelSearch.TabIndex = 14;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AllowUserToAddRows = false;
            this.dataGridViewEvents.AllowUserToDeleteRows = false;
            this.dataGridViewEvents.AutoGenerateColumns = false;
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEvents.ColumnHeadersHeight = 35;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventidDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.descripcioDataGridViewTextBoxColumn,
            this.datahoraDataGridViewTextBoxColumn,
            this.estatDataGridViewTextBoxColumn,
            this.espaiidDataGridViewTextBoxColumn,
            this.organitzadoridDataGridViewTextBoxColumn,
            this.imatge_promocional_url});
            this.dataGridViewEvents.DataSource = this.bindingSourceEventsDataGrid;
            this.dataGridViewEvents.EnableHeadersVisualStyles = false;
            this.dataGridViewEvents.Location = new System.Drawing.Point(16, 0);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.RowHeadersVisible = false;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(843, 260);
            this.dataGridViewEvents.TabIndex = 5;
            this.dataGridViewEvents.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewEvents_CellValidating);
            // 
            // imatge_promocional_url
            // 
            this.imatge_promocional_url.DataPropertyName = "imatge_promocional_url";
            this.imatge_promocional_url.HeaderText = "imatge_promocional_url";
            this.imatge_promocional_url.Name = "imatge_promocional_url";
            this.imatge_promocional_url.ReadOnly = true;
            this.imatge_promocional_url.Width = 210;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panelDataGridView.Controls.Add(this.dataGridViewEvents);
            this.panelDataGridView.Location = new System.Drawing.Point(49, 215);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(869, 275);
            this.panelDataGridView.TabIndex = 18;
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateEvent.Location = new System.Drawing.Point(747, 496);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(161, 26);
            this.buttonCreateEvent.TabIndex = 19;
            this.buttonCreateEvent.Text = "Create event";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelEdit.Location = new System.Drawing.Point(152, 496);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(97, 30);
            this.buttonCancelEdit.TabIndex = 25;
            this.buttonCancelEdit.Text = "Cancel";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Visible = false;
            this.buttonCancelEdit.Click += new System.EventHandler(this.buttonCancelEdit_Click);
            // 
            // buttonSaveEdit
            // 
            this.buttonSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveEdit.Location = new System.Drawing.Point(49, 496);
            this.buttonSaveEdit.Name = "buttonSaveEdit";
            this.buttonSaveEdit.Size = new System.Drawing.Size(97, 30);
            this.buttonSaveEdit.TabIndex = 24;
            this.buttonSaveEdit.Text = "Save";
            this.buttonSaveEdit.UseVisualStyleBackColor = true;
            this.buttonSaveEdit.Visible = false;
            this.buttonSaveEdit.Click += new System.EventHandler(this.buttonSaveEdit_Click);
            // 
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "event_id";
            this.eventidDataGridViewTextBoxColumn.HeaderText = "event_id";
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            this.eventidDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventidDataGridViewTextBoxColumn.Width = 110;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcioDataGridViewTextBoxColumn
            // 
            this.descripcioDataGridViewTextBoxColumn.DataPropertyName = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.HeaderText = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.Name = "descripcioDataGridViewTextBoxColumn";
            this.descripcioDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcioDataGridViewTextBoxColumn.Width = 180;
            // 
            // datahoraDataGridViewTextBoxColumn
            // 
            this.datahoraDataGridViewTextBoxColumn.DataPropertyName = "data_hora";
            this.datahoraDataGridViewTextBoxColumn.HeaderText = "data_hora";
            this.datahoraDataGridViewTextBoxColumn.Name = "datahoraDataGridViewTextBoxColumn";
            this.datahoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.datahoraDataGridViewTextBoxColumn.Width = 180;
            // 
            // estatDataGridViewTextBoxColumn
            // 
            this.estatDataGridViewTextBoxColumn.DataPropertyName = "estat";
            this.estatDataGridViewTextBoxColumn.HeaderText = "estat";
            this.estatDataGridViewTextBoxColumn.Name = "estatDataGridViewTextBoxColumn";
            this.estatDataGridViewTextBoxColumn.ReadOnly = true;
            this.estatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estatDataGridViewTextBoxColumn.Width = 80;
            // 
            // espaiidDataGridViewTextBoxColumn
            // 
            this.espaiidDataGridViewTextBoxColumn.DataPropertyName = "espai_id";
            this.espaiidDataGridViewTextBoxColumn.HeaderText = "espai_id";
            this.espaiidDataGridViewTextBoxColumn.Name = "espaiidDataGridViewTextBoxColumn";
            this.espaiidDataGridViewTextBoxColumn.ReadOnly = true;
            this.espaiidDataGridViewTextBoxColumn.Width = 110;
            // 
            // organitzadoridDataGridViewTextBoxColumn
            // 
            this.organitzadoridDataGridViewTextBoxColumn.DataPropertyName = "organitzador_id";
            this.organitzadoridDataGridViewTextBoxColumn.HeaderText = "organitzador_id";
            this.organitzadoridDataGridViewTextBoxColumn.Name = "organitzadoridDataGridViewTextBoxColumn";
            this.organitzadoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.organitzadoridDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSourceEventsDataGrid
            // 
            this.bindingSourceEventsDataGrid.DataSource = typeof(evencat.Models.Esdeveniments);
            // 
            // FormEventsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 531);
            this.Controls.Add(this.buttonCancelEdit);
            this.Controls.Add(this.buttonSaveEdit);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelEventsManagement);
            this.Controls.Add(this.pictureBoxMenuIcon);
            this.Controls.Add(this.comboBoxOrderBy);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.buttonCreateEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEventsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEventsManagement";
            this.Load += new System.EventHandler(this.FormEventsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuIcon)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelEventsManagement;
        private System.Windows.Forms.PictureBox pictureBoxMenuIcon;
        private System.Windows.Forms.ComboBox comboBoxCurrentStatus;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.BindingSource bindingSourceEventsDataGrid;
        private System.Windows.Forms.Button buttonCancelEdit;
        private System.Windows.Forms.Button buttonSaveEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espaiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organitzadoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imatge_promocional_url;
    }
}