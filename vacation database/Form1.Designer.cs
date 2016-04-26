namespace Vacation_database
{
    partial class Vacation_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacation_Database));
            this.locationImage = new System.Windows.Forms.PictureBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.locationSelect = new System.Windows.Forms.ComboBox();
            this.locationDateLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.bedsLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.availableTextBox = new System.Windows.Forms.TextBox();
            this.bedsTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.availableToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bedsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.priceToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ratingToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.purchaseToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cancelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dateToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.locationImage)).BeginInit();
            this.SuspendLayout();
            // 
            // locationImage
            // 
            this.locationImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.locationImage.Image = ((System.Drawing.Image)(resources.GetObject("locationImage.Image")));
            this.locationImage.ImageLocation = "";
            this.locationImage.Location = new System.Drawing.Point(237, 28);
            this.locationImage.Name = "locationImage";
            this.locationImage.Size = new System.Drawing.Size(375, 375);
            this.locationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.locationImage.TabIndex = 0;
            this.locationImage.TabStop = false;
            this.pictureToolTip.SetToolTip(this.locationImage, "Picture of location (if available)");
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(12, 407);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(75, 23);
            this.purchaseButton.TabIndex = 1;
            this.purchaseButton.Text = "Purchase";
            this.purchaseToolTip.SetToolTip(this.purchaseButton, "All purchases are final");
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // locationSelect
            // 
            this.locationSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationSelect.Location = new System.Drawing.Point(12, 28);
            this.locationSelect.Name = "locationSelect";
            this.locationSelect.Size = new System.Drawing.Size(143, 21);
            this.locationSelect.TabIndex = 0;
            this.locationToolTip.SetToolTip(this.locationSelect, "Select location");
            this.locationSelect.SelectedIndexChanged += new System.EventHandler(this.locationSelect_SelectedIndexChanged);
            // 
            // locationDateLabel
            // 
            this.locationDateLabel.AutoSize = true;
            this.locationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDateLabel.Location = new System.Drawing.Point(12, 9);
            this.locationDateLabel.Name = "locationDateLabel";
            this.locationDateLabel.Size = new System.Drawing.Size(204, 16);
            this.locationDateLabel.TabIndex = 2;
            this.locationDateLabel.Text = "Select desired location and date:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceLabel.Location = new System.Drawing.Point(12, 105);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 17);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price: ";
            this.priceToolTip.SetToolTip(this.priceLabel, "Price is in USD unless otherwise noted");
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.Location = new System.Drawing.Point(12, 180);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(76, 16);
            this.availableLabel.TabIndex = 4;
            this.availableLabel.Text = "Availability:";
            this.availableToolTip.SetToolTip(this.availableLabel, "Room is available or not");
            // 
            // bedsLabel
            // 
            this.bedsLabel.AutoSize = true;
            this.bedsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedsLabel.Location = new System.Drawing.Point(12, 255);
            this.bedsLabel.Name = "bedsLabel";
            this.bedsLabel.Size = new System.Drawing.Size(107, 16);
            this.bedsLabel.TabIndex = 5;
            this.bedsLabel.Text = "Number of beds:";
            this.bedsToolTip.SetToolTip(this.bedsLabel, "Number of beds in room, upto 2 people per bed");
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(12, 330);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(50, 16);
            this.ratingLabel.TabIndex = 6;
            this.ratingLabel.Text = "Rating:";
            this.ratingToolTip.SetToolTip(this.ratingLabel, "Average rating the hotel has recived out of 5");
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(125, 407);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelToolTip.SetToolTip(this.cancelButton, "Cancel purchase and close application");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(125, 105);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // availableTextBox
            // 
            this.availableTextBox.Location = new System.Drawing.Point(125, 180);
            this.availableTextBox.Name = "availableTextBox";
            this.availableTextBox.ReadOnly = true;
            this.availableTextBox.Size = new System.Drawing.Size(100, 20);
            this.availableTextBox.TabIndex = 9;
            // 
            // bedsTextBox
            // 
            this.bedsTextBox.Location = new System.Drawing.Point(125, 255);
            this.bedsTextBox.Name = "bedsTextBox";
            this.bedsTextBox.ReadOnly = true;
            this.bedsTextBox.Size = new System.Drawing.Size(100, 20);
            this.bedsTextBox.TabIndex = 10;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(125, 330);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.ReadOnly = true;
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 11;
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureLabel.Location = new System.Drawing.Point(234, 9);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(52, 16);
            this.pictureLabel.TabIndex = 12;
            this.pictureLabel.Text = "Picture:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 55);
            this.dateTimePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2015, 4, 26, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 13;
            this.dateToolTip.SetToolTip(this.dateTimePicker, "Select date");
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // Vacation_Database
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.bedsTextBox);
            this.Controls.Add(this.availableTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.bedsLabel);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.locationDateLabel);
            this.Controls.Add(this.locationSelect);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.locationImage);
            this.Name = "Vacation_Database";
            this.Text = "Vacation Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox locationImage;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.ComboBox locationSelect;
        private System.Windows.Forms.Label locationDateLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Label bedsLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox availableTextBox;
        private System.Windows.Forms.TextBox bedsTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.ToolTip availableToolTip;
        private System.Windows.Forms.ToolTip pictureToolTip;
        private System.Windows.Forms.ToolTip priceToolTip;
        private System.Windows.Forms.ToolTip bedsToolTip;
        private System.Windows.Forms.ToolTip ratingToolTip;
        private System.Windows.Forms.ToolTip purchaseToolTip;
        private System.Windows.Forms.ToolTip cancelToolTip;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ToolTip locationToolTip;
        private System.Windows.Forms.ToolTip dateToolTip;
    }
}

