namespace evencat.Forms
{
    partial class FormCreateSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateSpace));
            this.textBoxNumberSeats = new System.Windows.Forms.TextBox();
            this.buttonCreateSpace = new System.Windows.Forms.Button();
            this.textBoxSquareMeters = new System.Windows.Forms.TextBox();
            this.comboBoxSeatType = new System.Windows.Forms.ComboBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumberSeats
            // 
            this.textBoxNumberSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberSeats.Location = new System.Drawing.Point(68, 310);
            this.textBoxNumberSeats.Name = "textBoxNumberSeats";
            this.textBoxNumberSeats.Size = new System.Drawing.Size(322, 24);
            this.textBoxNumberSeats.TabIndex = 26;
            this.textBoxNumberSeats.Text = "Number of seats";
            this.textBoxNumberSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCreateSpace
            // 
            this.buttonCreateSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSpace.Location = new System.Drawing.Point(141, 410);
            this.buttonCreateSpace.Name = "buttonCreateSpace";
            this.buttonCreateSpace.Size = new System.Drawing.Size(138, 27);
            this.buttonCreateSpace.TabIndex = 25;
            this.buttonCreateSpace.Text = "CREATE";
            this.buttonCreateSpace.UseVisualStyleBackColor = true;
            this.buttonCreateSpace.Click += new System.EventHandler(this.buttonCreateSpace_Click);
            // 
            // textBoxSquareMeters
            // 
            this.textBoxSquareMeters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSquareMeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSquareMeters.Location = new System.Drawing.Point(68, 210);
            this.textBoxSquareMeters.Name = "textBoxSquareMeters";
            this.textBoxSquareMeters.Size = new System.Drawing.Size(322, 24);
            this.textBoxSquareMeters.TabIndex = 22;
            this.textBoxSquareMeters.Text = "Square meters";
            this.textBoxSquareMeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxSeatType
            // 
            this.comboBoxSeatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeatType.FormattingEnabled = true;
            this.comboBoxSeatType.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxSeatType.Location = new System.Drawing.Point(68, 260);
            this.comboBoxSeatType.Name = "comboBoxSeatType";
            this.comboBoxSeatType.Size = new System.Drawing.Size(322, 28);
            this.comboBoxSeatType.TabIndex = 21;
            this.comboBoxSeatType.Text = "Select seating type";
            this.comboBoxSeatType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeatType_SelectedIndexChanged);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(68, 160);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(322, 24);
            this.textBoxLocation.TabIndex = 20;
            this.textBoxLocation.Text = "Location";
            this.textBoxLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(68, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(322, 24);
            this.textBoxName.TabIndex = 19;
            this.textBoxName.Text = "Name";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.labelDescription);
            this.panelTitle.Location = new System.Drawing.Point(23, 16);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(367, 69);
            this.panelTitle.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::evencat.Resource1.evencatLogoBlack;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(67, 1);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(295, 39);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "CREATE SPACE";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreateSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 453);
            this.Controls.Add(this.textBoxNumberSeats);
            this.Controls.Add(this.buttonCreateSpace);
            this.Controls.Add(this.textBoxSquareMeters);
            this.Controls.Add(this.comboBoxSeatType);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateSpace";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberSeats;
        private System.Windows.Forms.Button buttonCreateSpace;
        private System.Windows.Forms.TextBox textBoxSquareMeters;
        private System.Windows.Forms.ComboBox comboBoxSeatType;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDescription;
    }
}