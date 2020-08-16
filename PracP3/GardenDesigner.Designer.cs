namespace PracP4
{
  partial class GardenDesigner
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
      if (disposing && (components != null)) {
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.pictureBoxGarden = new System.Windows.Forms.PictureBox();
            this.nameLabel_ = new System.Windows.Forms.Label();
            this.sizeLabel_ = new System.Windows.Forms.Label();
            this.priceLabel_ = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(492, 202);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(194, 26);
            this.textBoxPrice.TabIndex = 14;
            this.textBoxPrice.Text = "1.50";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSize.Location = new System.Drawing.Point(492, 125);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(194, 26);
            this.textBoxSize.TabIndex = 13;
            this.textBoxSize.Text = "8";
            // 
            // pictureBoxGarden
            // 
            this.pictureBoxGarden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGarden.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxGarden.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxGarden.Name = "pictureBoxGarden";
            this.pictureBoxGarden.Size = new System.Drawing.Size(417, 379);
            this.pictureBoxGarden.TabIndex = 8;
            this.pictureBoxGarden.TabStop = false;
            this.pictureBoxGarden.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGarden_Paint);
            this.pictureBoxGarden.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGarden_MouseClick);
            // 
            // nameLabel_
            // 
            this.nameLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel_.AutoSize = true;
            this.nameLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel_.Location = new System.Drawing.Point(426, 51);
            this.nameLabel_.Name = "nameLabel_";
            this.nameLabel_.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.nameLabel_.Size = new System.Drawing.Size(60, 26);
            this.nameLabel_.TabIndex = 9;
            this.nameLabel_.Text = "Name:";
            // 
            // sizeLabel_
            // 
            this.sizeLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeLabel_.AutoSize = true;
            this.sizeLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel_.Location = new System.Drawing.Point(426, 128);
            this.sizeLabel_.Name = "sizeLabel_";
            this.sizeLabel_.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.sizeLabel_.Size = new System.Drawing.Size(49, 26);
            this.sizeLabel_.TabIndex = 10;
            this.sizeLabel_.Text = "Size:";
            // 
            // priceLabel_
            // 
            this.priceLabel_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel_.AutoSize = true;
            this.priceLabel_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel_.Location = new System.Drawing.Point(426, 205);
            this.priceLabel_.Name = "priceLabel_";
            this.priceLabel_.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.priceLabel_.Size = new System.Drawing.Size(54, 26);
            this.priceLabel_.TabIndex = 11;
            this.priceLabel_.Text = "Price:";
            this.priceLabel_.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.priceLabel_.UseMnemonic = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(492, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 26);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.Text = "Daisy";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.Location = new System.Drawing.Point(492, 351);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(194, 31);
            this.buttonFinish.TabIndex = 15;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // GardenDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 385);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.pictureBoxGarden);
            this.Controls.Add(this.nameLabel_);
            this.Controls.Add(this.sizeLabel_);
            this.Controls.Add(this.priceLabel_);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonFinish);
            this.Name = "GardenDesigner";
            this.Text = "Garden Designer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.PictureBox pictureBoxGarden;
        private System.Windows.Forms.Label nameLabel_;
        private System.Windows.Forms.Label sizeLabel_;
        private System.Windows.Forms.Label priceLabel_;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonFinish;
    }
}

