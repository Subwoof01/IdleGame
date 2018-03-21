namespace IdleGame
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.tbItemStats = new System.Windows.Forms.TextBox();
            this.lbShopItems = new System.Windows.Forms.ListBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnWeapons = new System.Windows.Forms.Button();
            this.btnArmour = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbItemStats
            // 
            this.tbItemStats.Location = new System.Drawing.Point(299, 12);
            this.tbItemStats.Multiline = true;
            this.tbItemStats.Name = "tbItemStats";
            this.tbItemStats.ReadOnly = true;
            this.tbItemStats.Size = new System.Drawing.Size(172, 248);
            this.tbItemStats.TabIndex = 63;
            this.tbItemStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbShopItems
            // 
            this.lbShopItems.FormattingEnabled = true;
            this.lbShopItems.Location = new System.Drawing.Point(80, 12);
            this.lbShopItems.Name = "lbShopItems";
            this.lbShopItems.Size = new System.Drawing.Size(213, 121);
            this.lbShopItems.TabIndex = 62;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(12, 110);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(62, 23);
            this.btnBuy.TabIndex = 64;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.Location = new System.Drawing.Point(80, 139);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(213, 121);
            this.lbInventory.TabIndex = 65;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(12, 237);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(62, 23);
            this.btnSell.TabIndex = 66;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(12, 191);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(62, 40);
            this.btnHeal.TabIndex = 67;
            this.btnHeal.Text = "Heal (100g)";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnWeapons
            // 
            this.btnWeapons.Location = new System.Drawing.Point(12, 41);
            this.btnWeapons.Name = "btnWeapons";
            this.btnWeapons.Size = new System.Drawing.Size(62, 23);
            this.btnWeapons.TabIndex = 68;
            this.btnWeapons.Text = "Weapons";
            this.btnWeapons.UseVisualStyleBackColor = true;
            this.btnWeapons.Click += new System.EventHandler(this.btnWeapons_Click);
            // 
            // btnArmour
            // 
            this.btnArmour.Location = new System.Drawing.Point(12, 70);
            this.btnArmour.Name = "btnArmour";
            this.btnArmour.Size = new System.Drawing.Size(62, 23);
            this.btnArmour.TabIndex = 69;
            this.btnArmour.Text = "Armour";
            this.btnArmour.UseVisualStyleBackColor = true;
            this.btnArmour.Click += new System.EventHandler(this.btnArmour_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(12, 12);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(62, 23);
            this.btnGeneral.TabIndex = 70;
            this.btnGeneral.Text = "General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 270);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnArmour);
            this.Controls.Add(this.btnWeapons);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.lbInventory);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.tbItemStats);
            this.Controls.Add(this.lbShopItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItemStats;
        private System.Windows.Forms.ListBox lbShopItems;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox lbInventory;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnWeapons;
        private System.Windows.Forms.Button btnArmour;
        private System.Windows.Forms.Button btnGeneral;
    }
}