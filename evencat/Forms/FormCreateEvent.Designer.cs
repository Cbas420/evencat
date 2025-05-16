namespace evencat.Forms
{
    partial class FormCreateEvent
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
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCreateEvent = new System.Windows.Forms.Label();
            this.pictureBoxMenuIcon = new System.Windows.Forms.PictureBox();
            this.textBoxSearchSpace = new System.Windows.Forms.TextBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewSpaces = new System.Windows.Forms.DataGridView();
            this.textBoxEventImage = new System.Windows.Forms.TextBox();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.labelNewEvent = new System.Windows.Forms.Label();
            this.panelNewEvent = new System.Windows.Forms.Panel();
            this.espaiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metresquadratsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadiresfixesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSpaces = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuIcon)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            this.panelNewEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateEvent.Location = new System.Drawing.Point(71, 271);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(138, 27);
            this.buttonCreateEvent.TabIndex = 32;
            this.buttonCreateEvent.Text = "CREATE";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::evencat.Resource1.evencatLogoWhite;
            this.pictureBoxLogo.Location = new System.Drawing.Point(902, 35);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 36;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCreateEvent
            // 
            this.labelCreateEvent.AutoSize = true;
            this.labelCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCreateEvent.Location = new System.Drawing.Point(256, 20);
            this.labelCreateEvent.Name = "labelCreateEvent";
            this.labelCreateEvent.Size = new System.Drawing.Size(464, 65);
            this.labelCreateEvent.TabIndex = 34;
            this.labelCreateEvent.Text = "CREATE EVENT";
            // 
            // pictureBoxMenuIcon
            // 
            this.pictureBoxMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenuIcon.Image = global::evencat.Resource1.exitArrowIcon;
            this.pictureBoxMenuIcon.Location = new System.Drawing.Point(12, 38);
            this.pictureBoxMenuIcon.Name = "pictureBoxMenuIcon";
            this.pictureBoxMenuIcon.Size = new System.Drawing.Size(53, 53);
            this.pictureBoxMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuIcon.TabIndex = 33;
            this.pictureBoxMenuIcon.TabStop = false;
            this.pictureBoxMenuIcon.Click += new System.EventHandler(this.pictureBoxMenuIcon_Click);
            // 
            // textBoxSearchSpace
            // 
            this.textBoxSearchSpace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchSpace.Location = new System.Drawing.Point(16, 9);
            this.textBoxSearchSpace.Name = "textBoxSearchSpace";
            this.textBoxSearchSpace.Size = new System.Drawing.Size(704, 19);
            this.textBoxSearchSpace.TabIndex = 4;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxSearchSpace);
            this.panelSearch.Location = new System.Drawing.Point(49, 122);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(859, 41);
            this.panelSearch.TabIndex = 35;
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
            // dataGridViewSpaces
            // 
            this.dataGridViewSpaces.AllowUserToAddRows = false;
            this.dataGridViewSpaces.AllowUserToDeleteRows = false;
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
            this.dataGridViewSpaces.DataSource = this.bindingSourceSpaces;
            this.dataGridViewSpaces.EnableHeadersVisualStyles = false;
            this.dataGridViewSpaces.Location = new System.Drawing.Point(18, 5);
            this.dataGridViewSpaces.Name = "dataGridViewSpaces";
            this.dataGridViewSpaces.ReadOnly = true;
            this.dataGridViewSpaces.RowHeadersVisible = false;
            this.dataGridViewSpaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSpaces.Size = new System.Drawing.Size(580, 293);
            this.dataGridViewSpaces.TabIndex = 5;
            // 
            // textBoxEventImage
            // 
            this.textBoxEventImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEventImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEventImage.Location = new System.Drawing.Point(18, 205);
            this.textBoxEventImage.Name = "textBoxEventImage";
            this.textBoxEventImage.Size = new System.Drawing.Size(255, 24);
            this.textBoxEventImage.TabIndex = 40;
            this.textBoxEventImage.Text = "Image (URL)";
            this.textBoxEventImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEventName.Location = new System.Drawing.Point(18, 105);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(255, 24);
            this.textBoxEventName.TabIndex = 38;
            this.textBoxEventName.Text = "Name";
            this.textBoxEventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panelDataGridView.Controls.Add(this.dataGridViewSpaces);
            this.panelDataGridView.Location = new System.Drawing.Point(37, 195);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(615, 313);
            this.panelDataGridView.TabIndex = 37;
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEventDescription.Location = new System.Drawing.Point(18, 155);
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(255, 24);
            this.textBoxEventDescription.TabIndex = 39;
            this.textBoxEventDescription.Text = "Description";
            this.textBoxEventDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNewEvent
            // 
            this.labelNewEvent.AutoSize = true;
            this.labelNewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewEvent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewEvent.Location = new System.Drawing.Point(23, 7);
            this.labelNewEvent.Name = "labelNewEvent";
            this.labelNewEvent.Size = new System.Drawing.Size(249, 54);
            this.labelNewEvent.TabIndex = 44;
            this.labelNewEvent.Text = "New Event";
            // 
            // panelNewEvent
            // 
            this.panelNewEvent.Controls.Add(this.labelNewEvent);
            this.panelNewEvent.Controls.Add(this.buttonCreateEvent);
            this.panelNewEvent.Controls.Add(this.textBoxEventName);
            this.panelNewEvent.Controls.Add(this.textBoxEventDescription);
            this.panelNewEvent.Controls.Add(this.textBoxEventImage);
            this.panelNewEvent.Location = new System.Drawing.Point(658, 195);
            this.panelNewEvent.Name = "panelNewEvent";
            this.panelNewEvent.Size = new System.Drawing.Size(297, 313);
            this.panelNewEvent.TabIndex = 45;
            // 
            // espaiidDataGridViewTextBoxColumn
            // 
            this.espaiidDataGridViewTextBoxColumn.DataPropertyName = "espai_id";
            this.espaiidDataGridViewTextBoxColumn.HeaderText = "espai_id";
            this.espaiidDataGridViewTextBoxColumn.Name = "espaiidDataGridViewTextBoxColumn";
            this.espaiidDataGridViewTextBoxColumn.ReadOnly = true;
            this.espaiidDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacioDataGridViewTextBoxColumn
            // 
            this.ubicacioDataGridViewTextBoxColumn.DataPropertyName = "ubicacio";
            this.ubicacioDataGridViewTextBoxColumn.HeaderText = "ubicacio";
            this.ubicacioDataGridViewTextBoxColumn.Name = "ubicacioDataGridViewTextBoxColumn";
            this.ubicacioDataGridViewTextBoxColumn.ReadOnly = true;
            this.ubicacioDataGridViewTextBoxColumn.Width = 110;
            // 
            // metresquadratsDataGridViewTextBoxColumn
            // 
            this.metresquadratsDataGridViewTextBoxColumn.DataPropertyName = "metres_quadrats";
            this.metresquadratsDataGridViewTextBoxColumn.HeaderText = "metres_quadrats";
            this.metresquadratsDataGridViewTextBoxColumn.Name = "metresquadratsDataGridViewTextBoxColumn";
            this.metresquadratsDataGridViewTextBoxColumn.ReadOnly = true;
            this.metresquadratsDataGridViewTextBoxColumn.Width = 145;
            // 
            // cadiresfixesDataGridViewTextBoxColumn
            // 
            this.cadiresfixesDataGridViewTextBoxColumn.DataPropertyName = "cadires_fixes";
            this.cadiresfixesDataGridViewTextBoxColumn.HeaderText = "cadires_fixes";
            this.cadiresfixesDataGridViewTextBoxColumn.Name = "cadiresfixesDataGridViewTextBoxColumn";
            this.cadiresfixesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cadiresfixesDataGridViewTextBoxColumn.Width = 145;
            // 
            // bindingSourceSpaces
            // 
            this.bindingSourceSpaces.DataSource = typeof(evencat.Models.Espais);
            // 
            // FormCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 543);
            this.Controls.Add(this.panelNewEvent);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelCreateEvent);
            this.Controls.Add(this.pictureBoxMenuIcon);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelDataGridView);
            this.Name = "FormCreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateEvent";
            this.Load += new System.EventHandler(this.FormCreateEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuIcon)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            this.panelNewEvent.ResumeLayout(false);
            this.panelNewEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSpaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCreateEvent;
        private System.Windows.Forms.PictureBox pictureBoxMenuIcon;
        private System.Windows.Forms.TextBox textBoxSearchSpace;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewSpaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn espaiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metresquadratsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadiresfixesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceSpaces;
        private System.Windows.Forms.TextBox textBoxEventImage;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.Label labelNewEvent;
        private System.Windows.Forms.Panel panelNewEvent;
    }
}