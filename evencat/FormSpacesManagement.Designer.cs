namespace evencat
{
    partial class FormSpacesManagement
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
            this.labelSpacesManagement = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.comboBoxCurrentState = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSpaceName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCreateSpace = new System.Windows.Forms.Button();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.buttonCreateActivity = new System.Windows.Forms.Button();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewSpaces = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenuIcon = new System.Windows.Forms.PictureBox();
            this.buttonCheckAllActivities = new System.Windows.Forms.Button();
            this.espaiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metresquadratsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadiresfixesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSpacesDataGrid = new System.Windows.Forms.BindingSource(this.components);
            this.panelSearch.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSpacesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpacesManagement
            // 
            this.labelSpacesManagement.AutoSize = true;
            this.labelSpacesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpacesManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSpacesManagement.Location = new System.Drawing.Point(146, -6);
            this.labelSpacesManagement.Name = "labelSpacesManagement";
            this.labelSpacesManagement.Size = new System.Drawing.Size(681, 65);
            this.labelSpacesManagement.TabIndex = 2;
            this.labelSpacesManagement.Text = "SPACES MANAGEMENT";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelSearch.Controls.Add(this.comboBoxCurrentState);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxSpaceName);
            this.panelSearch.Location = new System.Drawing.Point(49, 99);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(859, 41);
            this.panelSearch.TabIndex = 3;
            // 
            // comboBoxCurrentState
            // 
            this.comboBoxCurrentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrentState.FormattingEnabled = true;
            this.comboBoxCurrentState.Location = new System.Drawing.Point(597, 7);
            this.comboBoxCurrentState.Name = "comboBoxCurrentState";
            this.comboBoxCurrentState.Size = new System.Drawing.Size(140, 26);
            this.comboBoxCurrentState.TabIndex = 7;
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
            // textBoxSpaceName
            // 
            this.textBoxSpaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpaceName.Location = new System.Drawing.Point(16, 7);
            this.textBoxSpaceName.Name = "textBoxSpaceName";
            this.textBoxSpaceName.Size = new System.Drawing.Size(575, 26);
            this.textBoxSpaceName.TabIndex = 4;
            this.textBoxSpaceName.Leave += new System.EventHandler(this.textSpaceName_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(811, 161);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 30);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(689, 161);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 30);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonCreateSpace
            // 
            this.buttonCreateSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSpace.Location = new System.Drawing.Point(532, 161);
            this.buttonCreateSpace.Name = "buttonCreateSpace";
            this.buttonCreateSpace.Size = new System.Drawing.Size(135, 30);
            this.buttonCreateSpace.TabIndex = 10;
            this.buttonCreateSpace.Text = "Create space";
            this.buttonCreateSpace.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Location = new System.Drawing.Point(56, 165);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(140, 26);
            this.comboBoxOrderBy.TabIndex = 8;
            // 
            // buttonCreateActivity
            // 
            this.buttonCreateActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateActivity.Location = new System.Drawing.Point(747, 491);
            this.buttonCreateActivity.Name = "buttonCreateActivity";
            this.buttonCreateActivity.Size = new System.Drawing.Size(161, 26);
            this.buttonCreateActivity.TabIndex = 8;
            this.buttonCreateActivity.Text = "Create activity";
            this.buttonCreateActivity.UseVisualStyleBackColor = true;
            this.buttonCreateActivity.Click += new System.EventHandler(this.buttonCreateActivity_Click);
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panelDataGridView.Controls.Add(this.dataGridViewSpaces);
            this.panelDataGridView.Location = new System.Drawing.Point(49, 210);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(869, 275);
            this.panelDataGridView.TabIndex = 8;
            // 
            // dataGridViewSpaces
            // 
            this.dataGridViewSpaces.AutoGenerateColumns = false;
            this.dataGridViewSpaces.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSpaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSpaces.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSpaces.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSpaces.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSpaces.ColumnHeadersHeight = 35;
            this.dataGridViewSpaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.espaiidDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.ubicacioDataGridViewTextBoxColumn,
            this.metresquadratsDataGridViewTextBoxColumn,
            this.cadiresfixesDataGridViewTextBoxColumn});
            this.dataGridViewSpaces.DataSource = this.bindingSourceSpacesDataGrid;
            this.dataGridViewSpaces.EnableHeadersVisualStyles = false;
            this.dataGridViewSpaces.Location = new System.Drawing.Point(16, 5);
            this.dataGridViewSpaces.Name = "dataGridViewSpaces";
            this.dataGridViewSpaces.RowHeadersVisible = false;
            this.dataGridViewSpaces.Size = new System.Drawing.Size(843, 247);
            this.dataGridViewSpaces.TabIndex = 5;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::evencat.Resource1.evencatLogoWhite;
            this.pictureBoxLogo.Location = new System.Drawing.Point(902, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxMenuIcon
            // 
            this.pictureBoxMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenuIcon.Image = global::evencat.Resource1.menuIconWhite;
            this.pictureBoxMenuIcon.Location = new System.Drawing.Point(12, 15);
            this.pictureBoxMenuIcon.Name = "pictureBoxMenuIcon";
            this.pictureBoxMenuIcon.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuIcon.TabIndex = 1;
            this.pictureBoxMenuIcon.TabStop = false;
            this.pictureBoxMenuIcon.Click += new System.EventHandler(this.pictureBoxMenuIcon_Click);
            // 
            // buttonCheckAllActivities
            // 
            this.buttonCheckAllActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckAllActivities.Location = new System.Drawing.Point(49, 491);
            this.buttonCheckAllActivities.Name = "buttonCheckAllActivities";
            this.buttonCheckAllActivities.Size = new System.Drawing.Size(234, 26);
            this.buttonCheckAllActivities.TabIndex = 11;
            this.buttonCheckAllActivities.Text = "Check all activities";
            this.buttonCheckAllActivities.UseVisualStyleBackColor = true;
            // 
            // espaiidDataGridViewTextBoxColumn
            // 
            this.espaiidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.espaiidDataGridViewTextBoxColumn.DataPropertyName = "espai_id";
            this.espaiidDataGridViewTextBoxColumn.FillWeight = 150F;
            this.espaiidDataGridViewTextBoxColumn.HeaderText = "espai_id";
            this.espaiidDataGridViewTextBoxColumn.Name = "espaiidDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // ubicacioDataGridViewTextBoxColumn
            // 
            this.ubicacioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ubicacioDataGridViewTextBoxColumn.DataPropertyName = "ubicacio";
            this.ubicacioDataGridViewTextBoxColumn.FillWeight = 150F;
            this.ubicacioDataGridViewTextBoxColumn.HeaderText = "ubicacio";
            this.ubicacioDataGridViewTextBoxColumn.Name = "ubicacioDataGridViewTextBoxColumn";
            // 
            // metresquadratsDataGridViewTextBoxColumn
            // 
            this.metresquadratsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.metresquadratsDataGridViewTextBoxColumn.DataPropertyName = "metres_quadrats";
            this.metresquadratsDataGridViewTextBoxColumn.FillWeight = 150F;
            this.metresquadratsDataGridViewTextBoxColumn.HeaderText = "metres_quadrats";
            this.metresquadratsDataGridViewTextBoxColumn.Name = "metresquadratsDataGridViewTextBoxColumn";
            // 
            // cadiresfixesDataGridViewTextBoxColumn
            // 
            this.cadiresfixesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cadiresfixesDataGridViewTextBoxColumn.DataPropertyName = "cadires_fixes";
            this.cadiresfixesDataGridViewTextBoxColumn.FillWeight = 150F;
            this.cadiresfixesDataGridViewTextBoxColumn.HeaderText = "cadires_fixes";
            this.cadiresfixesDataGridViewTextBoxColumn.Name = "cadiresfixesDataGridViewTextBoxColumn";
            // 
            // bindingSourceSpacesDataGrid
            // 
            this.bindingSourceSpacesDataGrid.DataSource = typeof(evencat.Models.Espais);
            // 
            // FormSpacesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(967, 531);
            this.Controls.Add(this.buttonCheckAllActivities);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.buttonCreateActivity);
            this.Controls.Add(this.comboBoxOrderBy);
            this.Controls.Add(this.buttonCreateSpace);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.labelSpacesManagement);
            this.Controls.Add(this.pictureBoxMenuIcon);
            this.Name = "FormSpacesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formSpacesManagement_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSpacesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSpacesManagement;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxSpaceName;
        private System.Windows.Forms.ComboBox comboBoxCurrentState;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCreateSpace;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Button buttonCreateActivity;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewSpaces;
        private System.Windows.Forms.PictureBox pictureBoxMenuIcon;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.BindingSource bindingSourceSpacesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn espaiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metresquadratsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadiresfixesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCheckAllActivities;
    }
}