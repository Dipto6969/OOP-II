namespace Shop
{
    partial class Form1
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.ShowNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AddShopButton = new System.Windows.Forms.Button();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ShopIdLabel = new System.Windows.Forms.Label();
            this.ShopIdTextbox = new System.Windows.Forms.TextBox();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.ProductNameTextbox = new System.Windows.Forms.TextBox();
            this.ProductIdTextbox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ShowIdLabel = new System.Windows.Forms.Label();
            this.ShowNameTextbox = new System.Windows.Forms.TextBox();
            this.ShowIdTextbox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShopNameLabel = new System.Windows.Forms.Label();
            this.ShowTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.BackColor = System.Drawing.Color.Wheat;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(36, 26);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(91, 25);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Shop Id :";
            // 
            // ShowNameLabel
            // 
            this.ShowNameLabel.AutoSize = true;
            this.ShowNameLabel.BackColor = System.Drawing.Color.Wheat;
            this.ShowNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNameLabel.Location = new System.Drawing.Point(676, 93);
            this.ShowNameLabel.Name = "ShowNameLabel";
            this.ShowNameLabel.Size = new System.Drawing.Size(127, 25);
            this.ShowNameLabel.TabIndex = 1;
            this.ShowNameLabel.Text = "Shop Name :";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Wheat;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(36, 107);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(148, 25);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Shop Address :";
            // 
            // IdTextbox
            // 
            this.IdTextbox.BackColor = System.Drawing.Color.Wheat;
            this.IdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextbox.Location = new System.Drawing.Point(189, 21);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(225, 30);
            this.IdTextbox.TabIndex = 3;
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.BackColor = System.Drawing.Color.Wheat;
            this.AddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextbox.Location = new System.Drawing.Point(190, 104);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(225, 30);
            this.AddressTextbox.TabIndex = 4;
            this.AddressTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.Color.Wheat;
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextbox.Location = new System.Drawing.Point(190, 63);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(225, 30);
            this.NameTextbox.TabIndex = 5;
            this.NameTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddShopButton
            // 
            this.AddShopButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddShopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShopButton.Location = new System.Drawing.Point(433, 145);
            this.AddShopButton.Name = "AddShopButton";
            this.AddShopButton.Size = new System.Drawing.Size(178, 37);
            this.AddShopButton.TabIndex = 6;
            this.AddShopButton.Text = "Add Shop";
            this.AddShopButton.UseVisualStyleBackColor = false;
            this.AddShopButton.Click += new System.EventHandler(this.AddShopButton_Click);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.BackColor = System.Drawing.Color.Wheat;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(36, 267);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(142, 25);
            this.ProductNameLabel.TabIndex = 7;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.BackColor = System.Drawing.Color.Wheat;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(36, 351);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(85, 25);
            this.QuantityLabel.TabIndex = 9;
            this.QuantityLabel.Text = "Quantity";
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.BackColor = System.Drawing.Color.Wheat;
            this.ProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdLabel.Location = new System.Drawing.Point(36, 226);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(111, 25);
            this.ProductIdLabel.TabIndex = 10;
            this.ProductIdLabel.Text = "Product Id :";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Wheat;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(36, 310);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(62, 25);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Price:";
            // 
            // ShopIdLabel
            // 
            this.ShopIdLabel.AutoSize = true;
            this.ShopIdLabel.BackColor = System.Drawing.Color.Wheat;
            this.ShopIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopIdLabel.Location = new System.Drawing.Point(36, 393);
            this.ShopIdLabel.Name = "ShopIdLabel";
            this.ShopIdLabel.Size = new System.Drawing.Size(91, 25);
            this.ShopIdLabel.TabIndex = 12;
            this.ShopIdLabel.Text = "Shop Id :";
            // 
            // ShopIdTextbox
            // 
            this.ShopIdTextbox.BackColor = System.Drawing.Color.Wheat;
            this.ShopIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopIdTextbox.Location = new System.Drawing.Point(190, 393);
            this.ShopIdTextbox.Name = "ShopIdTextbox";
            this.ShopIdTextbox.Size = new System.Drawing.Size(225, 30);
            this.ShopIdTextbox.TabIndex = 13;
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.BackColor = System.Drawing.Color.Wheat;
            this.QuantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextbox.Location = new System.Drawing.Point(190, 351);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(225, 30);
            this.QuantityTextbox.TabIndex = 14;
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.BackColor = System.Drawing.Color.Wheat;
            this.PriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextbox.Location = new System.Drawing.Point(190, 307);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(225, 30);
            this.PriceTextbox.TabIndex = 15;
            // 
            // ProductNameTextbox
            // 
            this.ProductNameTextbox.BackColor = System.Drawing.Color.Wheat;
            this.ProductNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTextbox.Location = new System.Drawing.Point(190, 264);
            this.ProductNameTextbox.Name = "ProductNameTextbox";
            this.ProductNameTextbox.Size = new System.Drawing.Size(225, 30);
            this.ProductNameTextbox.TabIndex = 16;
            // 
            // ProductIdTextbox
            // 
            this.ProductIdTextbox.BackColor = System.Drawing.Color.Wheat;
            this.ProductIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdTextbox.Location = new System.Drawing.Point(189, 226);
            this.ProductIdTextbox.Name = "ProductIdTextbox";
            this.ProductIdTextbox.Size = new System.Drawing.Size(225, 30);
            this.ProductIdTextbox.TabIndex = 17;
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(433, 393);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(178, 37);
            this.AddProductButton.TabIndex = 18;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ShowIdLabel
            // 
            this.ShowIdLabel.AutoSize = true;
            this.ShowIdLabel.BackColor = System.Drawing.Color.Wheat;
            this.ShowIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIdLabel.Location = new System.Drawing.Point(676, 44);
            this.ShowIdLabel.Name = "ShowIdLabel";
            this.ShowIdLabel.Size = new System.Drawing.Size(91, 25);
            this.ShowIdLabel.TabIndex = 19;
            this.ShowIdLabel.Text = "Shop Id :";
            // 
            // ShowNameTextbox
            // 
            this.ShowNameTextbox.BackColor = System.Drawing.Color.Wheat;
            this.ShowNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNameTextbox.Location = new System.Drawing.Point(818, 90);
            this.ShowNameTextbox.Name = "ShowNameTextbox";
            this.ShowNameTextbox.Size = new System.Drawing.Size(225, 30);
            this.ShowNameTextbox.TabIndex = 20;
            // 
            // ShowIdTextbox
            // 
            this.ShowIdTextbox.BackColor = System.Drawing.Color.Wheat;
            this.ShowIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIdTextbox.Location = new System.Drawing.Point(818, 39);
            this.ShowIdTextbox.Name = "ShowIdTextbox";
            this.ShowIdTextbox.Size = new System.Drawing.Size(225, 30);
            this.ShowIdTextbox.TabIndex = 21;
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(865, 145);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(178, 37);
            this.ShowButton.TabIndex = 22;
            this.ShowButton.Text = "Show Products";
            this.ShowButton.UseVisualStyleBackColor = false;
            // 
            // ShopNameLabel
            // 
            this.ShopNameLabel.AutoSize = true;
            this.ShopNameLabel.BackColor = System.Drawing.Color.Wheat;
            this.ShopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopNameLabel.Location = new System.Drawing.Point(36, 68);
            this.ShopNameLabel.Name = "ShopNameLabel";
            this.ShopNameLabel.Size = new System.Drawing.Size(127, 25);
            this.ShopNameLabel.TabIndex = 23;
            this.ShopNameLabel.Text = "Shop Name :";
            // 
            // ShowTextbox
            // 
            this.ShowTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 139.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTextbox.Location = new System.Drawing.Point(653, 226);
            this.ShowTextbox.Name = "ShowTextbox";
            this.ShowTextbox.Size = new System.Drawing.Size(390, 271);
            this.ShowTextbox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 541);
            this.Controls.Add(this.ShowTextbox);
            this.Controls.Add(this.ShopNameLabel);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ShowIdTextbox);
            this.Controls.Add(this.ShowNameTextbox);
            this.Controls.Add(this.ShowIdLabel);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductIdTextbox);
            this.Controls.Add(this.ProductNameTextbox);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.ShopIdTextbox);
            this.Controls.Add(this.ShopIdLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.AddShopButton);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ShowNameLabel);
            this.Controls.Add(this.IdLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label ShowNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Button AddShopButton;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ShopIdLabel;
        private System.Windows.Forms.TextBox ShopIdTextbox;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.TextBox ProductNameTextbox;
        private System.Windows.Forms.TextBox ProductIdTextbox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label ShowIdLabel;
        private System.Windows.Forms.TextBox ShowNameTextbox;
        private System.Windows.Forms.TextBox ShowIdTextbox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label ShopNameLabel;
        private System.Windows.Forms.TextBox ShowTextbox;
    }
}

