namespace IdleGame
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.btnHead = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnChest = new System.Windows.Forms.Button();
            this.btnWeapon = new System.Windows.Forms.Button();
            this.lblChest = new System.Windows.Forms.Label();
            this.lblMainHand = new System.Windows.Forms.Label();
            this.btnDrop = new System.Windows.Forms.Button();
            this.tbHeadEquipped = new System.Windows.Forms.TextBox();
            this.tbChestEquipped = new System.Windows.Forms.TextBox();
            this.tbMainHandEquipped = new System.Windows.Forms.TextBox();
            this.btnHeadUnequip = new System.Windows.Forms.Button();
            this.btnHeadShow = new System.Windows.Forms.Button();
            this.btnChestShow = new System.Windows.Forms.Button();
            this.btnChestUnequip = new System.Windows.Forms.Button();
            this.btnWeaponShow = new System.Windows.Forms.Button();
            this.btnWeaponUnequip = new System.Windows.Forms.Button();
            this.tbInventorySpace = new System.Windows.Forms.TextBox();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.lblGoldStatic = new System.Windows.Forms.Label();
            this.lblSpaceStatic = new System.Windows.Forms.Label();
            this.tbItemStats = new System.Windows.Forms.TextBox();
            this.btnSpawnArmour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.Location = new System.Drawing.Point(149, 12);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(213, 121);
            this.lbInventory.TabIndex = 0;
            this.lbInventory.SelectedIndexChanged += new System.EventHandler(this.lbInventory_SelectedIndexChanged);
            // 
            // btnHead
            // 
            this.btnHead.Location = new System.Drawing.Point(77, 12);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(44, 37);
            this.btnHead.TabIndex = 1;
            this.btnHead.Text = "Head";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(109, 171);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(36, 13);
            this.lblHead.TabIndex = 2;
            this.lblHead.Text = "Head:";
            // 
            // btnChest
            // 
            this.btnChest.Location = new System.Drawing.Point(77, 55);
            this.btnChest.Name = "btnChest";
            this.btnChest.Size = new System.Drawing.Size(44, 78);
            this.btnChest.TabIndex = 3;
            this.btnChest.Text = "Chest";
            this.btnChest.UseVisualStyleBackColor = true;
            this.btnChest.Click += new System.EventHandler(this.btnChest_Click);
            // 
            // btnWeapon
            // 
            this.btnWeapon.Location = new System.Drawing.Point(12, 55);
            this.btnWeapon.Name = "btnWeapon";
            this.btnWeapon.Size = new System.Drawing.Size(59, 78);
            this.btnWeapon.TabIndex = 9;
            this.btnWeapon.Text = "Weapon";
            this.btnWeapon.UseVisualStyleBackColor = true;
            this.btnWeapon.Click += new System.EventHandler(this.btnWeapon_Click);
            // 
            // lblChest
            // 
            this.lblChest.AutoSize = true;
            this.lblChest.Location = new System.Drawing.Point(108, 197);
            this.lblChest.Name = "lblChest";
            this.lblChest.Size = new System.Drawing.Size(37, 13);
            this.lblChest.TabIndex = 12;
            this.lblChest.Text = "Chest:";
            // 
            // lblMainHand
            // 
            this.lblMainHand.AutoSize = true;
            this.lblMainHand.Location = new System.Drawing.Point(94, 223);
            this.lblMainHand.Name = "lblMainHand";
            this.lblMainHand.Size = new System.Drawing.Size(51, 13);
            this.lblMainHand.TabIndex = 19;
            this.lblMainHand.Text = "Weapon:";
            // 
            // btnDrop
            // 
            this.btnDrop.Location = new System.Drawing.Point(308, 139);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(54, 20);
            this.btnDrop.TabIndex = 21;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // tbHeadEquipped
            // 
            this.tbHeadEquipped.HideSelection = false;
            this.tbHeadEquipped.Location = new System.Drawing.Point(149, 168);
            this.tbHeadEquipped.Name = "tbHeadEquipped";
            this.tbHeadEquipped.ReadOnly = true;
            this.tbHeadEquipped.Size = new System.Drawing.Size(213, 20);
            this.tbHeadEquipped.TabIndex = 48;
            this.tbHeadEquipped.Text = "ItemName";
            // 
            // tbChestEquipped
            // 
            this.tbChestEquipped.HideSelection = false;
            this.tbChestEquipped.Location = new System.Drawing.Point(149, 194);
            this.tbChestEquipped.Name = "tbChestEquipped";
            this.tbChestEquipped.ReadOnly = true;
            this.tbChestEquipped.Size = new System.Drawing.Size(213, 20);
            this.tbChestEquipped.TabIndex = 49;
            this.tbChestEquipped.Text = "ItemName";
            // 
            // tbMainHandEquipped
            // 
            this.tbMainHandEquipped.HideSelection = false;
            this.tbMainHandEquipped.Location = new System.Drawing.Point(149, 220);
            this.tbMainHandEquipped.Name = "tbMainHandEquipped";
            this.tbMainHandEquipped.ReadOnly = true;
            this.tbMainHandEquipped.Size = new System.Drawing.Size(213, 20);
            this.tbMainHandEquipped.TabIndex = 50;
            this.tbMainHandEquipped.Text = "ItemName";
            // 
            // btnHeadUnequip
            // 
            this.btnHeadUnequip.Location = new System.Drawing.Point(12, 168);
            this.btnHeadUnequip.Name = "btnHeadUnequip";
            this.btnHeadUnequip.Size = new System.Drawing.Size(22, 20);
            this.btnHeadUnequip.TabIndex = 51;
            this.btnHeadUnequip.Text = "-";
            this.btnHeadUnequip.UseVisualStyleBackColor = true;
            this.btnHeadUnequip.Click += new System.EventHandler(this.btnHeadUnequip_Click);
            // 
            // btnHeadShow
            // 
            this.btnHeadShow.Location = new System.Drawing.Point(40, 168);
            this.btnHeadShow.Name = "btnHeadShow";
            this.btnHeadShow.Size = new System.Drawing.Size(45, 20);
            this.btnHeadShow.TabIndex = 52;
            this.btnHeadShow.Text = "Show";
            this.btnHeadShow.UseVisualStyleBackColor = true;
            this.btnHeadShow.Click += new System.EventHandler(this.btnHeadShow_Click);
            // 
            // btnChestShow
            // 
            this.btnChestShow.Location = new System.Drawing.Point(40, 194);
            this.btnChestShow.Name = "btnChestShow";
            this.btnChestShow.Size = new System.Drawing.Size(45, 20);
            this.btnChestShow.TabIndex = 54;
            this.btnChestShow.Text = "Show";
            this.btnChestShow.UseVisualStyleBackColor = true;
            this.btnChestShow.Click += new System.EventHandler(this.btnChestShow_Click);
            // 
            // btnChestUnequip
            // 
            this.btnChestUnequip.Location = new System.Drawing.Point(12, 194);
            this.btnChestUnequip.Name = "btnChestUnequip";
            this.btnChestUnequip.Size = new System.Drawing.Size(22, 20);
            this.btnChestUnequip.TabIndex = 53;
            this.btnChestUnequip.Text = "-";
            this.btnChestUnequip.UseVisualStyleBackColor = true;
            this.btnChestUnequip.Click += new System.EventHandler(this.btnChestUnequip_Click);
            // 
            // btnWeaponShow
            // 
            this.btnWeaponShow.Location = new System.Drawing.Point(40, 220);
            this.btnWeaponShow.Name = "btnWeaponShow";
            this.btnWeaponShow.Size = new System.Drawing.Size(45, 20);
            this.btnWeaponShow.TabIndex = 56;
            this.btnWeaponShow.Text = "Show";
            this.btnWeaponShow.UseVisualStyleBackColor = true;
            this.btnWeaponShow.Click += new System.EventHandler(this.btnWeaponShow_Click);
            // 
            // btnWeaponUnequip
            // 
            this.btnWeaponUnequip.Location = new System.Drawing.Point(12, 220);
            this.btnWeaponUnequip.Name = "btnWeaponUnequip";
            this.btnWeaponUnequip.Size = new System.Drawing.Size(22, 20);
            this.btnWeaponUnequip.TabIndex = 55;
            this.btnWeaponUnequip.Text = "-";
            this.btnWeaponUnequip.UseVisualStyleBackColor = true;
            this.btnWeaponUnequip.Click += new System.EventHandler(this.btnWeaponUnequip_Click);
            // 
            // tbInventorySpace
            // 
            this.tbInventorySpace.HideSelection = false;
            this.tbInventorySpace.Location = new System.Drawing.Point(265, 139);
            this.tbInventorySpace.Name = "tbInventorySpace";
            this.tbInventorySpace.ReadOnly = true;
            this.tbInventorySpace.Size = new System.Drawing.Size(37, 20);
            this.tbInventorySpace.TabIndex = 57;
            this.tbInventorySpace.Text = "00/20";
            // 
            // tbGold
            // 
            this.tbGold.HideSelection = false;
            this.tbGold.Location = new System.Drawing.Point(184, 139);
            this.tbGold.Name = "tbGold";
            this.tbGold.ReadOnly = true;
            this.tbGold.Size = new System.Drawing.Size(37, 20);
            this.tbGold.TabIndex = 58;
            this.tbGold.Text = "99999";
            // 
            // lblGoldStatic
            // 
            this.lblGoldStatic.AutoSize = true;
            this.lblGoldStatic.Location = new System.Drawing.Point(146, 142);
            this.lblGoldStatic.Name = "lblGoldStatic";
            this.lblGoldStatic.Size = new System.Drawing.Size(32, 13);
            this.lblGoldStatic.TabIndex = 59;
            this.lblGoldStatic.Text = "Gold:";
            // 
            // lblSpaceStatic
            // 
            this.lblSpaceStatic.AutoSize = true;
            this.lblSpaceStatic.Location = new System.Drawing.Point(227, 142);
            this.lblSpaceStatic.Name = "lblSpaceStatic";
            this.lblSpaceStatic.Size = new System.Drawing.Size(33, 13);
            this.lblSpaceStatic.TabIndex = 60;
            this.lblSpaceStatic.Text = "Slots:";
            // 
            // tbItemStats
            // 
            this.tbItemStats.Location = new System.Drawing.Point(368, 12);
            this.tbItemStats.Multiline = true;
            this.tbItemStats.Name = "tbItemStats";
            this.tbItemStats.ReadOnly = true;
            this.tbItemStats.Size = new System.Drawing.Size(172, 228);
            this.tbItemStats.TabIndex = 61;
            this.tbItemStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSpawnArmour
            // 
            this.btnSpawnArmour.Location = new System.Drawing.Point(12, 12);
            this.btnSpawnArmour.Name = "btnSpawnArmour";
            this.btnSpawnArmour.Size = new System.Drawing.Size(59, 37);
            this.btnSpawnArmour.TabIndex = 62;
            this.btnSpawnArmour.Text = "Spawn Armour";
            this.btnSpawnArmour.UseVisualStyleBackColor = true;
            this.btnSpawnArmour.Click += new System.EventHandler(this.btnSpawnArmour_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 249);
            this.Controls.Add(this.btnSpawnArmour);
            this.Controls.Add(this.tbItemStats);
            this.Controls.Add(this.lblSpaceStatic);
            this.Controls.Add(this.lblGoldStatic);
            this.Controls.Add(this.tbGold);
            this.Controls.Add(this.tbInventorySpace);
            this.Controls.Add(this.btnWeaponShow);
            this.Controls.Add(this.btnWeaponUnequip);
            this.Controls.Add(this.btnChestShow);
            this.Controls.Add(this.btnChestUnequip);
            this.Controls.Add(this.btnHeadShow);
            this.Controls.Add(this.btnHeadUnequip);
            this.Controls.Add(this.tbMainHandEquipped);
            this.Controls.Add(this.tbChestEquipped);
            this.Controls.Add(this.tbHeadEquipped);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.lblMainHand);
            this.Controls.Add(this.lblChest);
            this.Controls.Add(this.btnWeapon);
            this.Controls.Add(this.btnChest);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnHead);
            this.Controls.Add(this.lbInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbInventory;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnChest;
        private System.Windows.Forms.Button btnWeapon;
        private System.Windows.Forms.Label lblChest;
        private System.Windows.Forms.Label lblMainHand;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.TextBox tbHeadEquipped;
        private System.Windows.Forms.TextBox tbChestEquipped;
        private System.Windows.Forms.TextBox tbMainHandEquipped;
        private System.Windows.Forms.Button btnHeadUnequip;
        private System.Windows.Forms.Button btnHeadShow;
        private System.Windows.Forms.Button btnChestShow;
        private System.Windows.Forms.Button btnChestUnequip;
        private System.Windows.Forms.Button btnWeaponShow;
        private System.Windows.Forms.Button btnWeaponUnequip;
        private System.Windows.Forms.TextBox tbInventorySpace;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.Label lblGoldStatic;
        private System.Windows.Forms.Label lblSpaceStatic;
        private System.Windows.Forms.TextBox tbItemStats;
        private System.Windows.Forms.Button btnSpawnArmour;
    }
}