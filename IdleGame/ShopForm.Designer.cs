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
            this.btnBuy = new System.Windows.Forms.Button();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.tcBuy = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpArmour = new System.Windows.Forms.TabPage();
            this.tpWeapons = new System.Windows.Forms.TabPage();
            this.lbGeneral = new System.Windows.Forms.ListBox();
            this.lbArmour = new System.Windows.Forms.ListBox();
            this.lbWeapons = new System.Windows.Forms.ListBox();
            this.lblSpaceStatic = new System.Windows.Forms.Label();
            this.lblGoldStatic = new System.Windows.Forms.Label();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.tbInventorySpace = new System.Windows.Forms.TextBox();
            this.tcBuy.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpArmour.SuspendLayout();
            this.tpWeapons.SuspendLayout();
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
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(12, 139);
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
            this.lbInventory.Location = new System.Drawing.Point(80, 165);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(213, 95);
            this.lbInventory.TabIndex = 65;
            this.lbInventory.SelectedIndexChanged += new System.EventHandler(this.lbInventory_SelectedIndexChanged);
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
            // tcBuy
            // 
            this.tcBuy.Controls.Add(this.tpGeneral);
            this.tcBuy.Controls.Add(this.tpArmour);
            this.tcBuy.Controls.Add(this.tpWeapons);
            this.tcBuy.Location = new System.Drawing.Point(12, 12);
            this.tcBuy.Name = "tcBuy";
            this.tcBuy.SelectedIndex = 0;
            this.tcBuy.Size = new System.Drawing.Size(281, 121);
            this.tcBuy.TabIndex = 68;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.lbGeneral);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(273, 95);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tpArmour
            // 
            this.tpArmour.Controls.Add(this.lbArmour);
            this.tpArmour.Location = new System.Drawing.Point(4, 22);
            this.tpArmour.Name = "tpArmour";
            this.tpArmour.Padding = new System.Windows.Forms.Padding(3);
            this.tpArmour.Size = new System.Drawing.Size(273, 95);
            this.tpArmour.TabIndex = 1;
            this.tpArmour.Text = "Armour";
            this.tpArmour.UseVisualStyleBackColor = true;
            // 
            // tpWeapons
            // 
            this.tpWeapons.Controls.Add(this.lbWeapons);
            this.tpWeapons.Location = new System.Drawing.Point(4, 22);
            this.tpWeapons.Name = "tpWeapons";
            this.tpWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tpWeapons.Size = new System.Drawing.Size(273, 95);
            this.tpWeapons.TabIndex = 2;
            this.tpWeapons.Text = "Weapons";
            this.tpWeapons.UseVisualStyleBackColor = true;
            // 
            // lbGeneral
            // 
            this.lbGeneral.FormattingEnabled = true;
            this.lbGeneral.Location = new System.Drawing.Point(0, 0);
            this.lbGeneral.Name = "lbGeneral";
            this.lbGeneral.Size = new System.Drawing.Size(273, 95);
            this.lbGeneral.TabIndex = 0;
            // 
            // lbArmour
            // 
            this.lbArmour.FormattingEnabled = true;
            this.lbArmour.Location = new System.Drawing.Point(0, 0);
            this.lbArmour.Name = "lbArmour";
            this.lbArmour.Size = new System.Drawing.Size(273, 95);
            this.lbArmour.TabIndex = 1;
            this.lbArmour.SelectedIndexChanged += new System.EventHandler(this.lbArmour_SelectedIndexChanged);
            // 
            // lbWeapons
            // 
            this.lbWeapons.FormattingEnabled = true;
            this.lbWeapons.Location = new System.Drawing.Point(0, 0);
            this.lbWeapons.Name = "lbWeapons";
            this.lbWeapons.Size = new System.Drawing.Size(273, 95);
            this.lbWeapons.TabIndex = 1;
            this.lbWeapons.SelectedIndexChanged += new System.EventHandler(this.lbWeapons_SelectedIndexChanged);
            // 
            // lblSpaceStatic
            // 
            this.lblSpaceStatic.AutoSize = true;
            this.lblSpaceStatic.Location = new System.Drawing.Point(218, 144);
            this.lblSpaceStatic.Name = "lblSpaceStatic";
            this.lblSpaceStatic.Size = new System.Drawing.Size(33, 13);
            this.lblSpaceStatic.TabIndex = 72;
            this.lblSpaceStatic.Text = "Slots:";
            // 
            // lblGoldStatic
            // 
            this.lblGoldStatic.AutoSize = true;
            this.lblGoldStatic.Location = new System.Drawing.Point(137, 144);
            this.lblGoldStatic.Name = "lblGoldStatic";
            this.lblGoldStatic.Size = new System.Drawing.Size(32, 13);
            this.lblGoldStatic.TabIndex = 71;
            this.lblGoldStatic.Text = "Gold:";
            // 
            // tbGold
            // 
            this.tbGold.HideSelection = false;
            this.tbGold.Location = new System.Drawing.Point(175, 141);
            this.tbGold.Name = "tbGold";
            this.tbGold.ReadOnly = true;
            this.tbGold.Size = new System.Drawing.Size(37, 20);
            this.tbGold.TabIndex = 70;
            this.tbGold.Text = "99999";
            // 
            // tbInventorySpace
            // 
            this.tbInventorySpace.HideSelection = false;
            this.tbInventorySpace.Location = new System.Drawing.Point(256, 141);
            this.tbInventorySpace.Name = "tbInventorySpace";
            this.tbInventorySpace.ReadOnly = true;
            this.tbInventorySpace.Size = new System.Drawing.Size(37, 20);
            this.tbInventorySpace.TabIndex = 69;
            this.tbInventorySpace.Text = "00/20";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 270);
            this.Controls.Add(this.lblSpaceStatic);
            this.Controls.Add(this.lblGoldStatic);
            this.Controls.Add(this.tbGold);
            this.Controls.Add(this.tbInventorySpace);
            this.Controls.Add(this.tcBuy);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.lbInventory);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.tbItemStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.tcBuy.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpArmour.ResumeLayout(false);
            this.tpWeapons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItemStats;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox lbInventory;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.TabControl tcBuy;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpArmour;
        private System.Windows.Forms.TabPage tpWeapons;
        private System.Windows.Forms.ListBox lbGeneral;
        private System.Windows.Forms.ListBox lbArmour;
        private System.Windows.Forms.ListBox lbWeapons;
        private System.Windows.Forms.Label lblSpaceStatic;
        private System.Windows.Forms.Label lblGoldStatic;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.TextBox tbInventorySpace;
    }
}