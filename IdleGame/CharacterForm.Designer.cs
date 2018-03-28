namespace IdleGame
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.lblNameStatic = new System.Windows.Forms.Label();
            this.tbNameSet = new System.Windows.Forms.TextBox();
            this.btnSetName = new System.Windows.Forms.Button();
            this.lblClassStatic = new System.Windows.Forms.Label();
            this.lblLevelStatic = new System.Windows.Forms.Label();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.tbSkillPoints = new System.Windows.Forms.TextBox();
            this.lblSkillPointsStatic = new System.Windows.Forms.Label();
            this.btnTalentTree = new System.Windows.Forms.Button();
            this.btnSpells = new System.Windows.Forms.Button();
            this.tbExperience = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStrengthStatic = new System.Windows.Forms.Label();
            this.tbStrength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIntelligenceStatic = new System.Windows.Forms.Label();
            this.tbIntelligence = new System.Windows.Forms.TextBox();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.tbDexterity = new System.Windows.Forms.TextBox();
            this.btnIncreaseStrength = new System.Windows.Forms.Button();
            this.btnIncreaseIntelligence = new System.Windows.Forms.Button();
            this.btnIncreaseDexterity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHealthStatic = new System.Windows.Forms.Label();
            this.tbHealth = new System.Windows.Forms.TextBox();
            this.lblPhysicalDamageStatic = new System.Windows.Forms.Label();
            this.tbPhysicalDamage = new System.Windows.Forms.TextBox();
            this.lblMana = new System.Windows.Forms.Label();
            this.tbMana = new System.Windows.Forms.TextBox();
            this.lblArmour = new System.Windows.Forms.Label();
            this.tbArmour = new System.Windows.Forms.TextBox();
            this.lblFireDamageStatic = new System.Windows.Forms.Label();
            this.tbFireDamageIncrease = new System.Windows.Forms.TextBox();
            this.lblCriticalStrikeChance = new System.Windows.Forms.Label();
            this.tbCriticalChance = new System.Windows.Forms.TextBox();
            this.lblCriticalDamage = new System.Windows.Forms.Label();
            this.tbCriticalDamage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPhysicalReduction = new System.Windows.Forms.Label();
            this.tbPhysicalReduction = new System.Windows.Forms.TextBox();
            this.lblFireResistance = new System.Windows.Forms.Label();
            this.tbFireResistance = new System.Windows.Forms.TextBox();
            this.lblHealthRegeneration = new System.Windows.Forms.Label();
            this.tbHealthRegeneration = new System.Windows.Forms.TextBox();
            this.lblManaRegeneration = new System.Windows.Forms.Label();
            this.tbManaRegeneration = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPhysicalDamageIncrease = new System.Windows.Forms.TextBox();
            this.lblPhysicalDamageIncrease = new System.Windows.Forms.Label();
            this.tbLightningDamageIncrease = new System.Windows.Forms.TextBox();
            this.lblLightningDamageIncrease = new System.Windows.Forms.Label();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.tbTalentPoints = new System.Windows.Forms.TextBox();
            this.lblTalentPointsStatic = new System.Windows.Forms.Label();
            this.tbLightningResistance = new System.Windows.Forms.TextBox();
            this.lblLightningResistance = new System.Windows.Forms.Label();
            this.tbColdResistance = new System.Windows.Forms.TextBox();
            this.lblColdResistance = new System.Windows.Forms.Label();
            this.tbPoisonResistance = new System.Windows.Forms.TextBox();
            this.lblPoisonResistance = new System.Windows.Forms.Label();
            this.tbColdDamageIncrease = new System.Windows.Forms.TextBox();
            this.lblColdDamageIncreaseStatic = new System.Windows.Forms.Label();
            this.tbPoisonDamageIncrease = new System.Windows.Forms.TextBox();
            this.lblPoisonDamageIncreaseStatic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameStatic
            // 
            this.lblNameStatic.AutoSize = true;
            this.lblNameStatic.Location = new System.Drawing.Point(15, 9);
            this.lblNameStatic.Name = "lblNameStatic";
            this.lblNameStatic.Size = new System.Drawing.Size(38, 13);
            this.lblNameStatic.TabIndex = 0;
            this.lblNameStatic.Text = "Name:";
            // 
            // tbNameSet
            // 
            this.tbNameSet.HideSelection = false;
            this.tbNameSet.Location = new System.Drawing.Point(59, 6);
            this.tbNameSet.Name = "tbNameSet";
            this.tbNameSet.Size = new System.Drawing.Size(100, 20);
            this.tbNameSet.TabIndex = 1;
            this.tbNameSet.Text = "Name";
            // 
            // btnSetName
            // 
            this.btnSetName.Location = new System.Drawing.Point(165, 6);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(34, 20);
            this.btnSetName.TabIndex = 2;
            this.btnSetName.Text = "Set";
            this.btnSetName.UseVisualStyleBackColor = true;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // lblClassStatic
            // 
            this.lblClassStatic.AutoSize = true;
            this.lblClassStatic.Location = new System.Drawing.Point(18, 35);
            this.lblClassStatic.Name = "lblClassStatic";
            this.lblClassStatic.Size = new System.Drawing.Size(35, 13);
            this.lblClassStatic.TabIndex = 3;
            this.lblClassStatic.Text = "Class:";
            // 
            // lblLevelStatic
            // 
            this.lblLevelStatic.AutoSize = true;
            this.lblLevelStatic.Location = new System.Drawing.Point(18, 61);
            this.lblLevelStatic.Name = "lblLevelStatic";
            this.lblLevelStatic.Size = new System.Drawing.Size(36, 13);
            this.lblLevelStatic.TabIndex = 6;
            this.lblLevelStatic.Text = "Level:";
            // 
            // tbLevel
            // 
            this.tbLevel.HideSelection = false;
            this.tbLevel.Location = new System.Drawing.Point(59, 58);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.ReadOnly = true;
            this.tbLevel.Size = new System.Drawing.Size(19, 20);
            this.tbLevel.TabIndex = 7;
            this.tbLevel.Text = "99";
            // 
            // tbSkillPoints
            // 
            this.tbSkillPoints.HideSelection = false;
            this.tbSkillPoints.Location = new System.Drawing.Point(82, 84);
            this.tbSkillPoints.Name = "tbSkillPoints";
            this.tbSkillPoints.ReadOnly = true;
            this.tbSkillPoints.Size = new System.Drawing.Size(25, 20);
            this.tbSkillPoints.TabIndex = 26;
            this.tbSkillPoints.Text = "999";
            // 
            // lblSkillPointsStatic
            // 
            this.lblSkillPointsStatic.AutoSize = true;
            this.lblSkillPointsStatic.Location = new System.Drawing.Point(12, 87);
            this.lblSkillPointsStatic.Name = "lblSkillPointsStatic";
            this.lblSkillPointsStatic.Size = new System.Drawing.Size(61, 13);
            this.lblSkillPointsStatic.TabIndex = 25;
            this.lblSkillPointsStatic.Text = "Skill Points:";
            // 
            // btnTalentTree
            // 
            this.btnTalentTree.Location = new System.Drawing.Point(129, 584);
            this.btnTalentTree.Name = "btnTalentTree";
            this.btnTalentTree.Size = new System.Drawing.Size(58, 20);
            this.btnTalentTree.TabIndex = 29;
            this.btnTalentTree.Text = "Talents";
            this.btnTalentTree.UseVisualStyleBackColor = true;
            this.btnTalentTree.Click += new System.EventHandler(this.btnTalentTree_Click);
            // 
            // btnSpells
            // 
            this.btnSpells.Location = new System.Drawing.Point(65, 584);
            this.btnSpells.Name = "btnSpells";
            this.btnSpells.Size = new System.Drawing.Size(58, 20);
            this.btnSpells.TabIndex = 30;
            this.btnSpells.Text = "Spells";
            this.btnSpells.UseVisualStyleBackColor = true;
            this.btnSpells.Click += new System.EventHandler(this.btnSpells_Click);
            // 
            // tbExperience
            // 
            this.tbExperience.HideSelection = false;
            this.tbExperience.Location = new System.Drawing.Point(144, 58);
            this.tbExperience.Name = "tbExperience";
            this.tbExperience.ReadOnly = true;
            this.tbExperience.Size = new System.Drawing.Size(89, 20);
            this.tbExperience.TabIndex = 47;
            this.tbExperience.Text = "9999999/9999999";
            this.tbExperience.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "EXP:";
            // 
            // lblStrengthStatic
            // 
            this.lblStrengthStatic.AutoSize = true;
            this.lblStrengthStatic.Location = new System.Drawing.Point(12, 115);
            this.lblStrengthStatic.Name = "lblStrengthStatic";
            this.lblStrengthStatic.Size = new System.Drawing.Size(50, 13);
            this.lblStrengthStatic.TabIndex = 8;
            this.lblStrengthStatic.Text = "Strength:";
            // 
            // tbStrength
            // 
            this.tbStrength.HideSelection = false;
            this.tbStrength.Location = new System.Drawing.Point(75, 112);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.ReadOnly = true;
            this.tbStrength.Size = new System.Drawing.Size(32, 20);
            this.tbStrength.TabIndex = 9;
            this.tbStrength.Text = "999";
            this.tbStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 2);
            this.label1.TabIndex = 10;
            this.label1.Text = " ";
            // 
            // lblIntelligenceStatic
            // 
            this.lblIntelligenceStatic.AutoSize = true;
            this.lblIntelligenceStatic.Location = new System.Drawing.Point(12, 140);
            this.lblIntelligenceStatic.Name = "lblIntelligenceStatic";
            this.lblIntelligenceStatic.Size = new System.Drawing.Size(64, 13);
            this.lblIntelligenceStatic.TabIndex = 11;
            this.lblIntelligenceStatic.Text = "Intelligence:";
            // 
            // tbIntelligence
            // 
            this.tbIntelligence.HideSelection = false;
            this.tbIntelligence.Location = new System.Drawing.Point(75, 137);
            this.tbIntelligence.Name = "tbIntelligence";
            this.tbIntelligence.ReadOnly = true;
            this.tbIntelligence.Size = new System.Drawing.Size(32, 20);
            this.tbIntelligence.TabIndex = 12;
            this.tbIntelligence.Text = "999";
            this.tbIntelligence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Location = new System.Drawing.Point(12, 165);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(51, 13);
            this.lblDexterity.TabIndex = 13;
            this.lblDexterity.Text = "Dexterity:";
            // 
            // tbDexterity
            // 
            this.tbDexterity.HideSelection = false;
            this.tbDexterity.Location = new System.Drawing.Point(75, 162);
            this.tbDexterity.Name = "tbDexterity";
            this.tbDexterity.ReadOnly = true;
            this.tbDexterity.Size = new System.Drawing.Size(32, 20);
            this.tbDexterity.TabIndex = 14;
            this.tbDexterity.Text = "999";
            this.tbDexterity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIncreaseStrength
            // 
            this.btnIncreaseStrength.Enabled = false;
            this.btnIncreaseStrength.Location = new System.Drawing.Point(113, 112);
            this.btnIncreaseStrength.Name = "btnIncreaseStrength";
            this.btnIncreaseStrength.Size = new System.Drawing.Size(19, 20);
            this.btnIncreaseStrength.TabIndex = 15;
            this.btnIncreaseStrength.Text = "+";
            this.btnIncreaseStrength.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncreaseStrength.UseVisualStyleBackColor = true;
            this.btnIncreaseStrength.Click += new System.EventHandler(this.btnIncreaseStrength_Click);
            // 
            // btnIncreaseIntelligence
            // 
            this.btnIncreaseIntelligence.Enabled = false;
            this.btnIncreaseIntelligence.Location = new System.Drawing.Point(113, 137);
            this.btnIncreaseIntelligence.Name = "btnIncreaseIntelligence";
            this.btnIncreaseIntelligence.Size = new System.Drawing.Size(19, 20);
            this.btnIncreaseIntelligence.TabIndex = 16;
            this.btnIncreaseIntelligence.Text = "+";
            this.btnIncreaseIntelligence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncreaseIntelligence.UseVisualStyleBackColor = true;
            this.btnIncreaseIntelligence.Click += new System.EventHandler(this.btnIncreaseIntelligence_Click);
            // 
            // btnIncreaseDexterity
            // 
            this.btnIncreaseDexterity.Enabled = false;
            this.btnIncreaseDexterity.Location = new System.Drawing.Point(113, 162);
            this.btnIncreaseDexterity.Name = "btnIncreaseDexterity";
            this.btnIncreaseDexterity.Size = new System.Drawing.Size(19, 20);
            this.btnIncreaseDexterity.TabIndex = 17;
            this.btnIncreaseDexterity.Text = "+";
            this.btnIncreaseDexterity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncreaseDexterity.UseVisualStyleBackColor = true;
            this.btnIncreaseDexterity.Click += new System.EventHandler(this.btnIncreaseDexterity_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 2);
            this.label2.TabIndex = 18;
            this.label2.Text = " ";
            // 
            // lblHealthStatic
            // 
            this.lblHealthStatic.AutoSize = true;
            this.lblHealthStatic.Location = new System.Drawing.Point(141, 115);
            this.lblHealthStatic.Name = "lblHealthStatic";
            this.lblHealthStatic.Size = new System.Drawing.Size(41, 13);
            this.lblHealthStatic.TabIndex = 19;
            this.lblHealthStatic.Text = "Health:";
            // 
            // tbHealth
            // 
            this.tbHealth.HideSelection = false;
            this.tbHealth.Location = new System.Drawing.Point(188, 112);
            this.tbHealth.Name = "tbHealth";
            this.tbHealth.ReadOnly = true;
            this.tbHealth.Size = new System.Drawing.Size(45, 20);
            this.tbHealth.TabIndex = 20;
            this.tbHealth.Text = "9999";
            this.tbHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhysicalDamageStatic
            // 
            this.lblPhysicalDamageStatic.AutoSize = true;
            this.lblPhysicalDamageStatic.Location = new System.Drawing.Point(12, 193);
            this.lblPhysicalDamageStatic.Name = "lblPhysicalDamageStatic";
            this.lblPhysicalDamageStatic.Size = new System.Drawing.Size(92, 13);
            this.lblPhysicalDamageStatic.TabIndex = 21;
            this.lblPhysicalDamageStatic.Text = "Physical Damage:";
            // 
            // tbPhysicalDamage
            // 
            this.tbPhysicalDamage.HideSelection = false;
            this.tbPhysicalDamage.Location = new System.Drawing.Point(171, 190);
            this.tbPhysicalDamage.Name = "tbPhysicalDamage";
            this.tbPhysicalDamage.ReadOnly = true;
            this.tbPhysicalDamage.Size = new System.Drawing.Size(62, 20);
            this.tbPhysicalDamage.TabIndex = 22;
            this.tbPhysicalDamage.Text = "99999";
            this.tbPhysicalDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(141, 140);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(37, 13);
            this.lblMana.TabIndex = 23;
            this.lblMana.Text = "Mana:";
            // 
            // tbMana
            // 
            this.tbMana.HideSelection = false;
            this.tbMana.Location = new System.Drawing.Point(188, 137);
            this.tbMana.Name = "tbMana";
            this.tbMana.ReadOnly = true;
            this.tbMana.Size = new System.Drawing.Size(45, 20);
            this.tbMana.TabIndex = 24;
            this.tbMana.Text = "9999";
            this.tbMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblArmour
            // 
            this.lblArmour.AutoSize = true;
            this.lblArmour.Location = new System.Drawing.Point(141, 165);
            this.lblArmour.Name = "lblArmour";
            this.lblArmour.Size = new System.Drawing.Size(43, 13);
            this.lblArmour.TabIndex = 27;
            this.lblArmour.Text = "Armour:";
            // 
            // tbArmour
            // 
            this.tbArmour.HideSelection = false;
            this.tbArmour.Location = new System.Drawing.Point(188, 162);
            this.tbArmour.Name = "tbArmour";
            this.tbArmour.ReadOnly = true;
            this.tbArmour.Size = new System.Drawing.Size(45, 20);
            this.tbArmour.TabIndex = 28;
            this.tbArmour.Text = "9999";
            this.tbArmour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFireDamageStatic
            // 
            this.lblFireDamageStatic.AutoSize = true;
            this.lblFireDamageStatic.Location = new System.Drawing.Point(12, 245);
            this.lblFireDamageStatic.Name = "lblFireDamageStatic";
            this.lblFireDamageStatic.Size = new System.Drawing.Size(114, 13);
            this.lblFireDamageStatic.TabIndex = 31;
            this.lblFireDamageStatic.Text = "Fire Damage Increase:";
            // 
            // tbFireDamageIncrease
            // 
            this.tbFireDamageIncrease.HideSelection = false;
            this.tbFireDamageIncrease.Location = new System.Drawing.Point(171, 242);
            this.tbFireDamageIncrease.Name = "tbFireDamageIncrease";
            this.tbFireDamageIncrease.ReadOnly = true;
            this.tbFireDamageIncrease.Size = new System.Drawing.Size(62, 20);
            this.tbFireDamageIncrease.TabIndex = 32;
            this.tbFireDamageIncrease.Text = "99%";
            this.tbFireDamageIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCriticalStrikeChance
            // 
            this.lblCriticalStrikeChance.AutoSize = true;
            this.lblCriticalStrikeChance.Location = new System.Drawing.Point(12, 349);
            this.lblCriticalStrikeChance.Name = "lblCriticalStrikeChance";
            this.lblCriticalStrikeChance.Size = new System.Drawing.Size(111, 13);
            this.lblCriticalStrikeChance.TabIndex = 33;
            this.lblCriticalStrikeChance.Text = "Critical Strike Chance:";
            // 
            // tbCriticalChance
            // 
            this.tbCriticalChance.HideSelection = false;
            this.tbCriticalChance.Location = new System.Drawing.Point(171, 346);
            this.tbCriticalChance.Name = "tbCriticalChance";
            this.tbCriticalChance.ReadOnly = true;
            this.tbCriticalChance.Size = new System.Drawing.Size(62, 20);
            this.tbCriticalChance.TabIndex = 34;
            this.tbCriticalChance.Text = "99.99%";
            this.tbCriticalChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCriticalDamage
            // 
            this.lblCriticalDamage.AutoSize = true;
            this.lblCriticalDamage.Location = new System.Drawing.Point(12, 375);
            this.lblCriticalDamage.Name = "lblCriticalDamage";
            this.lblCriticalDamage.Size = new System.Drawing.Size(126, 13);
            this.lblCriticalDamage.TabIndex = 35;
            this.lblCriticalDamage.Text = "Critical Damage Multipier:";
            // 
            // tbCriticalDamage
            // 
            this.tbCriticalDamage.HideSelection = false;
            this.tbCriticalDamage.Location = new System.Drawing.Point(171, 372);
            this.tbCriticalDamage.Name = "tbCriticalDamage";
            this.tbCriticalDamage.ReadOnly = true;
            this.tbCriticalDamage.Size = new System.Drawing.Size(62, 20);
            this.tbCriticalDamage.TabIndex = 36;
            this.tbCriticalDamage.Text = "999%";
            this.tbCriticalDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(3, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 2);
            this.label5.TabIndex = 37;
            this.label5.Text = " ";
            // 
            // lblPhysicalReduction
            // 
            this.lblPhysicalReduction.AutoSize = true;
            this.lblPhysicalReduction.Location = new System.Drawing.Point(12, 403);
            this.lblPhysicalReduction.Name = "lblPhysicalReduction";
            this.lblPhysicalReduction.Size = new System.Drawing.Size(144, 13);
            this.lblPhysicalReduction.TabIndex = 38;
            this.lblPhysicalReduction.Text = "Physical Damage Reduction:";
            // 
            // tbPhysicalReduction
            // 
            this.tbPhysicalReduction.HideSelection = false;
            this.tbPhysicalReduction.Location = new System.Drawing.Point(171, 400);
            this.tbPhysicalReduction.Name = "tbPhysicalReduction";
            this.tbPhysicalReduction.ReadOnly = true;
            this.tbPhysicalReduction.Size = new System.Drawing.Size(62, 20);
            this.tbPhysicalReduction.TabIndex = 39;
            this.tbPhysicalReduction.Text = "99%";
            this.tbPhysicalReduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFireResistance
            // 
            this.lblFireResistance.AutoSize = true;
            this.lblFireResistance.Location = new System.Drawing.Point(12, 429);
            this.lblFireResistance.Name = "lblFireResistance";
            this.lblFireResistance.Size = new System.Drawing.Size(126, 13);
            this.lblFireResistance.TabIndex = 40;
            this.lblFireResistance.Text = "Fire Damage Resistance:";
            // 
            // tbFireResistance
            // 
            this.tbFireResistance.HideSelection = false;
            this.tbFireResistance.Location = new System.Drawing.Point(171, 426);
            this.tbFireResistance.Name = "tbFireResistance";
            this.tbFireResistance.ReadOnly = true;
            this.tbFireResistance.Size = new System.Drawing.Size(62, 20);
            this.tbFireResistance.TabIndex = 41;
            this.tbFireResistance.Text = "99%";
            this.tbFireResistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHealthRegeneration
            // 
            this.lblHealthRegeneration.AutoSize = true;
            this.lblHealthRegeneration.Location = new System.Drawing.Point(12, 533);
            this.lblHealthRegeneration.Name = "lblHealthRegeneration";
            this.lblHealthRegeneration.Size = new System.Drawing.Size(108, 13);
            this.lblHealthRegeneration.TabIndex = 42;
            this.lblHealthRegeneration.Text = "Health Regeneration:";
            // 
            // tbHealthRegeneration
            // 
            this.tbHealthRegeneration.HideSelection = false;
            this.tbHealthRegeneration.Location = new System.Drawing.Point(171, 530);
            this.tbHealthRegeneration.Name = "tbHealthRegeneration";
            this.tbHealthRegeneration.ReadOnly = true;
            this.tbHealthRegeneration.Size = new System.Drawing.Size(62, 20);
            this.tbHealthRegeneration.TabIndex = 43;
            this.tbHealthRegeneration.Text = "999/s";
            this.tbHealthRegeneration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblManaRegeneration
            // 
            this.lblManaRegeneration.AutoSize = true;
            this.lblManaRegeneration.Location = new System.Drawing.Point(12, 559);
            this.lblManaRegeneration.Name = "lblManaRegeneration";
            this.lblManaRegeneration.Size = new System.Drawing.Size(104, 13);
            this.lblManaRegeneration.TabIndex = 44;
            this.lblManaRegeneration.Text = "Mana Regeneration:";
            // 
            // tbManaRegeneration
            // 
            this.tbManaRegeneration.HideSelection = false;
            this.tbManaRegeneration.Location = new System.Drawing.Point(171, 556);
            this.tbManaRegeneration.Name = "tbManaRegeneration";
            this.tbManaRegeneration.ReadOnly = true;
            this.tbManaRegeneration.Size = new System.Drawing.Size(62, 20);
            this.tbManaRegeneration.TabIndex = 45;
            this.tbManaRegeneration.Text = "999/s";
            this.tbManaRegeneration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(3, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 2);
            this.label11.TabIndex = 48;
            this.label11.Text = " ";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(3, 584);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(50, 20);
            this.btnReload.TabIndex = 49;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 21);
            this.button1.TabIndex = 50;
            this.button1.Text = "+exp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPhysicalDamageIncrease
            // 
            this.tbPhysicalDamageIncrease.HideSelection = false;
            this.tbPhysicalDamageIncrease.Location = new System.Drawing.Point(171, 216);
            this.tbPhysicalDamageIncrease.Name = "tbPhysicalDamageIncrease";
            this.tbPhysicalDamageIncrease.ReadOnly = true;
            this.tbPhysicalDamageIncrease.Size = new System.Drawing.Size(62, 20);
            this.tbPhysicalDamageIncrease.TabIndex = 52;
            this.tbPhysicalDamageIncrease.Text = "99%";
            this.tbPhysicalDamageIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhysicalDamageIncrease
            // 
            this.lblPhysicalDamageIncrease.AutoSize = true;
            this.lblPhysicalDamageIncrease.Location = new System.Drawing.Point(12, 219);
            this.lblPhysicalDamageIncrease.Name = "lblPhysicalDamageIncrease";
            this.lblPhysicalDamageIncrease.Size = new System.Drawing.Size(136, 13);
            this.lblPhysicalDamageIncrease.TabIndex = 51;
            this.lblPhysicalDamageIncrease.Text = "Physical Damage Increase:";
            // 
            // tbLightningDamageIncrease
            // 
            this.tbLightningDamageIncrease.HideSelection = false;
            this.tbLightningDamageIncrease.Location = new System.Drawing.Point(171, 268);
            this.tbLightningDamageIncrease.Name = "tbLightningDamageIncrease";
            this.tbLightningDamageIncrease.ReadOnly = true;
            this.tbLightningDamageIncrease.Size = new System.Drawing.Size(62, 20);
            this.tbLightningDamageIncrease.TabIndex = 54;
            this.tbLightningDamageIncrease.Text = "99%";
            this.tbLightningDamageIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLightningDamageIncrease
            // 
            this.lblLightningDamageIncrease.AutoSize = true;
            this.lblLightningDamageIncrease.Location = new System.Drawing.Point(12, 271);
            this.lblLightningDamageIncrease.Name = "lblLightningDamageIncrease";
            this.lblLightningDamageIncrease.Size = new System.Drawing.Size(140, 13);
            this.lblLightningDamageIncrease.TabIndex = 53;
            this.lblLightningDamageIncrease.Text = "Lightning Damage Increase:";
            // 
            // tbClass
            // 
            this.tbClass.HideSelection = false;
            this.tbClass.Location = new System.Drawing.Point(59, 32);
            this.tbClass.Name = "tbClass";
            this.tbClass.ReadOnly = true;
            this.tbClass.Size = new System.Drawing.Size(100, 20);
            this.tbClass.TabIndex = 55;
            this.tbClass.Text = "Class";
            // 
            // tbTalentPoints
            // 
            this.tbTalentPoints.HideSelection = false;
            this.tbTalentPoints.Location = new System.Drawing.Point(214, 84);
            this.tbTalentPoints.Name = "tbTalentPoints";
            this.tbTalentPoints.ReadOnly = true;
            this.tbTalentPoints.Size = new System.Drawing.Size(19, 20);
            this.tbTalentPoints.TabIndex = 57;
            this.tbTalentPoints.Text = "99";
            // 
            // lblTalentPointsStatic
            // 
            this.lblTalentPointsStatic.AutoSize = true;
            this.lblTalentPointsStatic.Location = new System.Drawing.Point(141, 87);
            this.lblTalentPointsStatic.Name = "lblTalentPointsStatic";
            this.lblTalentPointsStatic.Size = new System.Drawing.Size(72, 13);
            this.lblTalentPointsStatic.TabIndex = 56;
            this.lblTalentPointsStatic.Text = "Talent Points:";
            // 
            // tbLightningResistance
            // 
            this.tbLightningResistance.HideSelection = false;
            this.tbLightningResistance.Location = new System.Drawing.Point(171, 452);
            this.tbLightningResistance.Name = "tbLightningResistance";
            this.tbLightningResistance.ReadOnly = true;
            this.tbLightningResistance.Size = new System.Drawing.Size(62, 20);
            this.tbLightningResistance.TabIndex = 59;
            this.tbLightningResistance.Text = "99%";
            this.tbLightningResistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLightningResistance
            // 
            this.lblLightningResistance.AutoSize = true;
            this.lblLightningResistance.Location = new System.Drawing.Point(12, 455);
            this.lblLightningResistance.Name = "lblLightningResistance";
            this.lblLightningResistance.Size = new System.Drawing.Size(152, 13);
            this.lblLightningResistance.TabIndex = 58;
            this.lblLightningResistance.Text = "Lightning Damage Resistance:";
            // 
            // tbColdResistance
            // 
            this.tbColdResistance.HideSelection = false;
            this.tbColdResistance.Location = new System.Drawing.Point(171, 478);
            this.tbColdResistance.Name = "tbColdResistance";
            this.tbColdResistance.ReadOnly = true;
            this.tbColdResistance.Size = new System.Drawing.Size(62, 20);
            this.tbColdResistance.TabIndex = 61;
            this.tbColdResistance.Text = "99%";
            this.tbColdResistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColdResistance
            // 
            this.lblColdResistance.AutoSize = true;
            this.lblColdResistance.Location = new System.Drawing.Point(12, 481);
            this.lblColdResistance.Name = "lblColdResistance";
            this.lblColdResistance.Size = new System.Drawing.Size(130, 13);
            this.lblColdResistance.TabIndex = 60;
            this.lblColdResistance.Text = "Cold Damage Resistance:";
            // 
            // tbPoisonResistance
            // 
            this.tbPoisonResistance.HideSelection = false;
            this.tbPoisonResistance.Location = new System.Drawing.Point(171, 504);
            this.tbPoisonResistance.Name = "tbPoisonResistance";
            this.tbPoisonResistance.ReadOnly = true;
            this.tbPoisonResistance.Size = new System.Drawing.Size(62, 20);
            this.tbPoisonResistance.TabIndex = 63;
            this.tbPoisonResistance.Text = "99%";
            this.tbPoisonResistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPoisonResistance
            // 
            this.lblPoisonResistance.AutoSize = true;
            this.lblPoisonResistance.Location = new System.Drawing.Point(12, 507);
            this.lblPoisonResistance.Name = "lblPoisonResistance";
            this.lblPoisonResistance.Size = new System.Drawing.Size(141, 13);
            this.lblPoisonResistance.TabIndex = 62;
            this.lblPoisonResistance.Text = "Poison Damage Resistance:";
            // 
            // tbColdDamageIncrease
            // 
            this.tbColdDamageIncrease.HideSelection = false;
            this.tbColdDamageIncrease.Location = new System.Drawing.Point(171, 294);
            this.tbColdDamageIncrease.Name = "tbColdDamageIncrease";
            this.tbColdDamageIncrease.ReadOnly = true;
            this.tbColdDamageIncrease.Size = new System.Drawing.Size(62, 20);
            this.tbColdDamageIncrease.TabIndex = 65;
            this.tbColdDamageIncrease.Text = "99%";
            this.tbColdDamageIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColdDamageIncreaseStatic
            // 
            this.lblColdDamageIncreaseStatic.AutoSize = true;
            this.lblColdDamageIncreaseStatic.Location = new System.Drawing.Point(12, 297);
            this.lblColdDamageIncreaseStatic.Name = "lblColdDamageIncreaseStatic";
            this.lblColdDamageIncreaseStatic.Size = new System.Drawing.Size(118, 13);
            this.lblColdDamageIncreaseStatic.TabIndex = 64;
            this.lblColdDamageIncreaseStatic.Text = "Cold Damage Increase:";
            // 
            // tbPoisonDamageIncrease
            // 
            this.tbPoisonDamageIncrease.HideSelection = false;
            this.tbPoisonDamageIncrease.Location = new System.Drawing.Point(171, 320);
            this.tbPoisonDamageIncrease.Name = "tbPoisonDamageIncrease";
            this.tbPoisonDamageIncrease.ReadOnly = true;
            this.tbPoisonDamageIncrease.Size = new System.Drawing.Size(62, 20);
            this.tbPoisonDamageIncrease.TabIndex = 67;
            this.tbPoisonDamageIncrease.Text = "99%";
            this.tbPoisonDamageIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPoisonDamageIncreaseStatic
            // 
            this.lblPoisonDamageIncreaseStatic.AutoSize = true;
            this.lblPoisonDamageIncreaseStatic.Location = new System.Drawing.Point(12, 323);
            this.lblPoisonDamageIncreaseStatic.Name = "lblPoisonDamageIncreaseStatic";
            this.lblPoisonDamageIncreaseStatic.Size = new System.Drawing.Size(129, 13);
            this.lblPoisonDamageIncreaseStatic.TabIndex = 66;
            this.lblPoisonDamageIncreaseStatic.Text = "Poison Damage Increase:";
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 609);
            this.Controls.Add(this.tbPoisonDamageIncrease);
            this.Controls.Add(this.lblPoisonDamageIncreaseStatic);
            this.Controls.Add(this.tbColdDamageIncrease);
            this.Controls.Add(this.lblColdDamageIncreaseStatic);
            this.Controls.Add(this.tbPoisonResistance);
            this.Controls.Add(this.lblPoisonResistance);
            this.Controls.Add(this.tbColdResistance);
            this.Controls.Add(this.lblColdResistance);
            this.Controls.Add(this.tbLightningResistance);
            this.Controls.Add(this.lblLightningResistance);
            this.Controls.Add(this.tbTalentPoints);
            this.Controls.Add(this.lblTalentPointsStatic);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.tbLightningDamageIncrease);
            this.Controls.Add(this.lblLightningDamageIncrease);
            this.Controls.Add(this.tbPhysicalDamageIncrease);
            this.Controls.Add(this.lblPhysicalDamageIncrease);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbExperience);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbManaRegeneration);
            this.Controls.Add(this.lblManaRegeneration);
            this.Controls.Add(this.tbHealthRegeneration);
            this.Controls.Add(this.lblHealthRegeneration);
            this.Controls.Add(this.tbFireResistance);
            this.Controls.Add(this.lblFireResistance);
            this.Controls.Add(this.tbPhysicalReduction);
            this.Controls.Add(this.lblPhysicalReduction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCriticalDamage);
            this.Controls.Add(this.lblCriticalDamage);
            this.Controls.Add(this.tbCriticalChance);
            this.Controls.Add(this.lblCriticalStrikeChance);
            this.Controls.Add(this.tbFireDamageIncrease);
            this.Controls.Add(this.lblFireDamageStatic);
            this.Controls.Add(this.btnSpells);
            this.Controls.Add(this.btnTalentTree);
            this.Controls.Add(this.tbArmour);
            this.Controls.Add(this.lblArmour);
            this.Controls.Add(this.tbSkillPoints);
            this.Controls.Add(this.lblSkillPointsStatic);
            this.Controls.Add(this.tbMana);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.tbPhysicalDamage);
            this.Controls.Add(this.lblPhysicalDamageStatic);
            this.Controls.Add(this.tbHealth);
            this.Controls.Add(this.lblHealthStatic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIncreaseDexterity);
            this.Controls.Add(this.btnIncreaseIntelligence);
            this.Controls.Add(this.btnIncreaseStrength);
            this.Controls.Add(this.tbDexterity);
            this.Controls.Add(this.lblDexterity);
            this.Controls.Add(this.tbIntelligence);
            this.Controls.Add(this.lblIntelligenceStatic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStrength);
            this.Controls.Add(this.lblStrengthStatic);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.lblLevelStatic);
            this.Controls.Add(this.lblClassStatic);
            this.Controls.Add(this.btnSetName);
            this.Controls.Add(this.tbNameSet);
            this.Controls.Add(this.lblNameStatic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameStatic;
        private System.Windows.Forms.TextBox tbNameSet;
        private System.Windows.Forms.Label lblClassStatic;
        private System.Windows.Forms.Label lblLevelStatic;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.TextBox tbSkillPoints;
        private System.Windows.Forms.Label lblSkillPointsStatic;
        private System.Windows.Forms.Button btnTalentTree;
        private System.Windows.Forms.Button btnSpells;
        private System.Windows.Forms.TextBox tbExperience;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStrengthStatic;
        private System.Windows.Forms.TextBox tbStrength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIntelligenceStatic;
        private System.Windows.Forms.TextBox tbIntelligence;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.TextBox tbDexterity;
        private System.Windows.Forms.Button btnIncreaseStrength;
        private System.Windows.Forms.Button btnIncreaseIntelligence;
        private System.Windows.Forms.Button btnIncreaseDexterity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHealthStatic;
        private System.Windows.Forms.TextBox tbHealth;
        private System.Windows.Forms.Label lblPhysicalDamageStatic;
        private System.Windows.Forms.TextBox tbPhysicalDamage;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.TextBox tbMana;
        private System.Windows.Forms.Label lblArmour;
        private System.Windows.Forms.TextBox tbArmour;
        private System.Windows.Forms.Label lblFireDamageStatic;
        private System.Windows.Forms.TextBox tbFireDamageIncrease;
        private System.Windows.Forms.Label lblCriticalStrikeChance;
        private System.Windows.Forms.TextBox tbCriticalChance;
        private System.Windows.Forms.Label lblCriticalDamage;
        private System.Windows.Forms.TextBox tbCriticalDamage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPhysicalReduction;
        private System.Windows.Forms.TextBox tbPhysicalReduction;
        private System.Windows.Forms.Label lblFireResistance;
        private System.Windows.Forms.TextBox tbFireResistance;
        private System.Windows.Forms.Label lblHealthRegeneration;
        private System.Windows.Forms.TextBox tbHealthRegeneration;
        private System.Windows.Forms.Label lblManaRegeneration;
        private System.Windows.Forms.TextBox tbManaRegeneration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPhysicalDamageIncrease;
        private System.Windows.Forms.Label lblPhysicalDamageIncrease;
        private System.Windows.Forms.TextBox tbLightningDamageIncrease;
        private System.Windows.Forms.Label lblLightningDamageIncrease;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.TextBox tbTalentPoints;
        private System.Windows.Forms.Label lblTalentPointsStatic;
        private System.Windows.Forms.TextBox tbLightningResistance;
        private System.Windows.Forms.Label lblLightningResistance;
        private System.Windows.Forms.TextBox tbColdResistance;
        private System.Windows.Forms.Label lblColdResistance;
        private System.Windows.Forms.TextBox tbPoisonResistance;
        private System.Windows.Forms.Label lblPoisonResistance;
        private System.Windows.Forms.TextBox tbColdDamageIncrease;
        private System.Windows.Forms.Label lblColdDamageIncreaseStatic;
        private System.Windows.Forms.TextBox tbPoisonDamageIncrease;
        private System.Windows.Forms.Label lblPoisonDamageIncreaseStatic;
    }
}