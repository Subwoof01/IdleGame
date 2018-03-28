namespace IdleGame
{
    partial class TravelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelForm));
            this.pbSelectedBanner = new System.Windows.Forms.PictureBox();
            this.btnCave = new System.Windows.Forms.Button();
            this.btnGraveyard = new System.Windows.Forms.Button();
            this.btnForest = new System.Windows.Forms.Button();
            this.btnMountains = new System.Windows.Forms.Button();
            this.btnRuins = new System.Windows.Forms.Button();
            this.btnEthereal = new System.Windows.Forms.Button();
            this.btnUnderworld = new System.Windows.Forms.Button();
            this.btnHuntingGround = new System.Windows.Forms.Button();
            this.lblLevelingZonesStatic = new System.Windows.Forms.Label();
            this.lblEndGameZonesStatic = new System.Windows.Forms.Label();
            this.btnArena = new System.Windows.Forms.Button();
            this.lblZoneName = new System.Windows.Forms.Label();
            this.tbEnemyTypes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUnques = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnTown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSelectedBanner
            // 
            this.pbSelectedBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbSelectedBanner.Image")));
            this.pbSelectedBanner.Location = new System.Drawing.Point(242, 32);
            this.pbSelectedBanner.Name = "pbSelectedBanner";
            this.pbSelectedBanner.Size = new System.Drawing.Size(307, 92);
            this.pbSelectedBanner.TabIndex = 8;
            this.pbSelectedBanner.TabStop = false;
            // 
            // btnCave
            // 
            this.btnCave.Location = new System.Drawing.Point(12, 104);
            this.btnCave.Name = "btnCave";
            this.btnCave.Size = new System.Drawing.Size(138, 26);
            this.btnCave.TabIndex = 9;
            this.btnCave.Text = "Cave (Lv10-20)";
            this.btnCave.UseVisualStyleBackColor = true;
            this.btnCave.Click += new System.EventHandler(this.btnCave_Click);
            // 
            // btnGraveyard
            // 
            this.btnGraveyard.Location = new System.Drawing.Point(12, 136);
            this.btnGraveyard.Name = "btnGraveyard";
            this.btnGraveyard.Size = new System.Drawing.Size(138, 26);
            this.btnGraveyard.TabIndex = 10;
            this.btnGraveyard.Text = "Graveyard (Lv20-40)";
            this.btnGraveyard.UseVisualStyleBackColor = true;
            this.btnGraveyard.Click += new System.EventHandler(this.btnGraveyard_Click);
            // 
            // btnForest
            // 
            this.btnForest.Enabled = false;
            this.btnForest.Location = new System.Drawing.Point(12, 72);
            this.btnForest.Name = "btnForest";
            this.btnForest.Size = new System.Drawing.Size(138, 26);
            this.btnForest.TabIndex = 11;
            this.btnForest.Text = "Forest (Lv1-10)";
            this.btnForest.UseVisualStyleBackColor = true;
            this.btnForest.Click += new System.EventHandler(this.btnForest_Click);
            // 
            // btnMountains
            // 
            this.btnMountains.Location = new System.Drawing.Point(12, 168);
            this.btnMountains.Name = "btnMountains";
            this.btnMountains.Size = new System.Drawing.Size(138, 26);
            this.btnMountains.TabIndex = 12;
            this.btnMountains.Text = "Mountains (Lv40-55)";
            this.btnMountains.UseVisualStyleBackColor = true;
            this.btnMountains.Click += new System.EventHandler(this.btnMountains_Click);
            // 
            // btnRuins
            // 
            this.btnRuins.Location = new System.Drawing.Point(12, 200);
            this.btnRuins.Name = "btnRuins";
            this.btnRuins.Size = new System.Drawing.Size(138, 26);
            this.btnRuins.TabIndex = 13;
            this.btnRuins.Text = "Ruins (Lv55-70)";
            this.btnRuins.UseVisualStyleBackColor = true;
            this.btnRuins.Click += new System.EventHandler(this.btnRuins_Click);
            // 
            // btnEthereal
            // 
            this.btnEthereal.Location = new System.Drawing.Point(12, 232);
            this.btnEthereal.Name = "btnEthereal";
            this.btnEthereal.Size = new System.Drawing.Size(138, 26);
            this.btnEthereal.TabIndex = 14;
            this.btnEthereal.Text = "Ethereal Plane (Lv70-90)";
            this.btnEthereal.UseVisualStyleBackColor = true;
            this.btnEthereal.Click += new System.EventHandler(this.btnEthereal_Click);
            // 
            // btnUnderworld
            // 
            this.btnUnderworld.Location = new System.Drawing.Point(12, 264);
            this.btnUnderworld.Name = "btnUnderworld";
            this.btnUnderworld.Size = new System.Drawing.Size(138, 26);
            this.btnUnderworld.TabIndex = 15;
            this.btnUnderworld.Text = "The Underworld (Lv90+)";
            this.btnUnderworld.UseVisualStyleBackColor = true;
            this.btnUnderworld.Click += new System.EventHandler(this.btnUnderworld_Click);
            // 
            // btnHuntingGround
            // 
            this.btnHuntingGround.Location = new System.Drawing.Point(12, 357);
            this.btnHuntingGround.Name = "btnHuntingGround";
            this.btnHuntingGround.Size = new System.Drawing.Size(159, 26);
            this.btnHuntingGround.TabIndex = 16;
            this.btnHuntingGround.Text = "The Hunting Grounds (Lv80+)";
            this.btnHuntingGround.UseVisualStyleBackColor = true;
            this.btnHuntingGround.Click += new System.EventHandler(this.btnHuntingGround_Click);
            // 
            // lblLevelingZonesStatic
            // 
            this.lblLevelingZonesStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelingZonesStatic.Location = new System.Drawing.Point(12, 49);
            this.lblLevelingZonesStatic.Name = "lblLevelingZonesStatic";
            this.lblLevelingZonesStatic.Size = new System.Drawing.Size(138, 23);
            this.lblLevelingZonesStatic.TabIndex = 17;
            this.lblLevelingZonesStatic.Text = "Leveling Zones";
            this.lblLevelingZonesStatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndGameZonesStatic
            // 
            this.lblEndGameZonesStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndGameZonesStatic.Location = new System.Drawing.Point(12, 302);
            this.lblEndGameZonesStatic.Name = "lblEndGameZonesStatic";
            this.lblEndGameZonesStatic.Size = new System.Drawing.Size(159, 20);
            this.lblEndGameZonesStatic.TabIndex = 18;
            this.lblEndGameZonesStatic.Text = "End Game Zones";
            this.lblEndGameZonesStatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArena
            // 
            this.btnArena.Location = new System.Drawing.Point(12, 325);
            this.btnArena.Name = "btnArena";
            this.btnArena.Size = new System.Drawing.Size(159, 26);
            this.btnArena.TabIndex = 19;
            this.btnArena.Text = "The Arena (Lv65+)";
            this.btnArena.UseVisualStyleBackColor = true;
            this.btnArena.Click += new System.EventHandler(this.btnArena_Click);
            // 
            // lblZoneName
            // 
            this.lblZoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoneName.Location = new System.Drawing.Point(242, 9);
            this.lblZoneName.Name = "lblZoneName";
            this.lblZoneName.Size = new System.Drawing.Size(307, 20);
            this.lblZoneName.TabIndex = 20;
            this.lblZoneName.Text = "Forest (Lv1-10)";
            this.lblZoneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEnemyTypes
            // 
            this.tbEnemyTypes.Location = new System.Drawing.Point(242, 150);
            this.tbEnemyTypes.Multiline = true;
            this.tbEnemyTypes.Name = "tbEnemyTypes";
            this.tbEnemyTypes.ReadOnly = true;
            this.tbEnemyTypes.Size = new System.Drawing.Size(130, 122);
            this.tbEnemyTypes.TabIndex = 21;
            this.tbEnemyTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enemy Types";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Unique Drops";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUnques
            // 
            this.tbUnques.Location = new System.Drawing.Point(419, 150);
            this.tbUnques.Multiline = true;
            this.tbUnques.Name = "tbUnques";
            this.tbUnques.ReadOnly = true;
            this.tbUnques.Size = new System.Drawing.Size(130, 122);
            this.tbUnques.TabIndex = 23;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(378, 250);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(35, 22);
            this.btnGo.TabIndex = 25;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnTown
            // 
            this.btnTown.Location = new System.Drawing.Point(12, 12);
            this.btnTown.Name = "btnTown";
            this.btnTown.Size = new System.Drawing.Size(138, 26);
            this.btnTown.TabIndex = 26;
            this.btnTown.Text = "Town (Quest-Hub)";
            this.btnTown.UseVisualStyleBackColor = true;
            this.btnTown.Click += new System.EventHandler(this.btnTown_Click);
            // 
            // TravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(560, 392);
            this.Controls.Add(this.btnTown);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUnques);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEnemyTypes);
            this.Controls.Add(this.lblZoneName);
            this.Controls.Add(this.btnArena);
            this.Controls.Add(this.lblEndGameZonesStatic);
            this.Controls.Add(this.lblLevelingZonesStatic);
            this.Controls.Add(this.btnHuntingGround);
            this.Controls.Add(this.btnUnderworld);
            this.Controls.Add(this.btnEthereal);
            this.Controls.Add(this.btnRuins);
            this.Controls.Add(this.btnMountains);
            this.Controls.Add(this.btnForest);
            this.Controls.Add(this.btnGraveyard);
            this.Controls.Add(this.btnCave);
            this.Controls.Add(this.pbSelectedBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TravelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSelectedBanner;
        private System.Windows.Forms.Button btnCave;
        private System.Windows.Forms.Button btnGraveyard;
        private System.Windows.Forms.Button btnForest;
        private System.Windows.Forms.Button btnMountains;
        private System.Windows.Forms.Button btnRuins;
        private System.Windows.Forms.Button btnEthereal;
        private System.Windows.Forms.Button btnUnderworld;
        private System.Windows.Forms.Button btnHuntingGround;
        private System.Windows.Forms.Label lblLevelingZonesStatic;
        private System.Windows.Forms.Label lblEndGameZonesStatic;
        private System.Windows.Forms.Button btnArena;
        private System.Windows.Forms.Label lblZoneName;
        private System.Windows.Forms.TextBox tbEnemyTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUnques;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnTown;
    }
}