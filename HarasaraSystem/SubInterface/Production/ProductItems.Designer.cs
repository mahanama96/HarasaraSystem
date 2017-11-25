namespace HarasaraSystem.SubInterface.Production
{
    partial class ProductItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductItems));
            this.txtPid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuThinButton2 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.SuspendLayout();
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(90, 12);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(100, 20);
            this.txtPid.TabIndex = 0;
            this.txtPid.TextChanged += new System.EventHandler(this.txtPid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qty";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(90, 112);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(100, 20);
            this.txtItemId.TabIndex = 6;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(90, 152);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(100, 20);
            this.txtqty.TabIndex = 7;
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(85, 62);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(105, 21);
            this.cmbItemName.TabIndex = 10;
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged);
            this.cmbItemName.TextChanged += new System.EventHandler(this.cmbItemName_TextChanged);
            // 
            // bunifuThinButton1
            // 
            this.bunifuThinButton1.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton1.BackgroundImage")));
            this.bunifuThinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton1.ButtonText = "Add items";
            this.bunifuThinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton1.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton1.Iconimage = null;
            this.bunifuThinButton1.IconVisible = true;
            this.bunifuThinButton1.IconZoom = 90D;
            this.bunifuThinButton1.ImageIconOverlay = false;
            this.bunifuThinButton1.Location = new System.Drawing.Point(24, 406);
            this.bunifuThinButton1.Name = "bunifuThinButton1";
            this.bunifuThinButton1.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton1.TabIndex = 11;
            this.bunifuThinButton1.Click += new System.EventHandler(this.bunifuThinButton1_Click);
            // 
            // bunifuThinButton2
            // 
            this.bunifuThinButton2.BackColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton2.BackgroundImage")));
            this.bunifuThinButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton2.ButtonText = "Back";
            this.bunifuThinButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton2.ForeColorHoverState = System.Drawing.Color.White;
            this.bunifuThinButton2.Iconimage = null;
            this.bunifuThinButton2.IconVisible = true;
            this.bunifuThinButton2.IconZoom = 90D;
            this.bunifuThinButton2.ImageIconOverlay = false;
            this.bunifuThinButton2.Location = new System.Drawing.Point(24, 463);
            this.bunifuThinButton2.Name = "bunifuThinButton2";
            this.bunifuThinButton2.Size = new System.Drawing.Size(184, 36);
            this.bunifuThinButton2.TabIndex = 12;
            this.bunifuThinButton2.Click += new System.EventHandler(this.bunifuThinButton2_Click);
            // 
            // ProductItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 586);
            this.Controls.Add(this.bunifuThinButton2);
            this.Controls.Add(this.bunifuThinButton1);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 46);
            this.MaximizeBox = false;
            this.Name = "ProductItems";
            this.Text = "ProductItems";
            this.Load += new System.EventHandler(this.ProductItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.ComboBox cmbItemName;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuThinButton2;
    }
}