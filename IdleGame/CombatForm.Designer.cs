namespace IdleGame
{
    partial class CombatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatForm));
            this.lblMana = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbCombatLog = new System.Windows.Forms.ListBox();
            this.lblManaEnemy = new System.Windows.Forms.Label();
            this.lblHealthEnemy = new System.Windows.Forms.Label();
            this.lblEnemyType = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCurrentAction = new System.Windows.Forms.TextBox();
            this.lblCurrentActionStatic = new System.Windows.Forms.Label();
            this.lblCurrentActionEnemyStatic = new System.Windows.Forms.Label();
            this.tbCurrentActionEnemy = new System.Windows.Forms.TextBox();
            this.lblCombatLogStatic = new System.Windows.Forms.Label();
            this.timerAction = new System.Windows.Forms.Timer(this.components);
            this.btnWeaponAttack = new System.Windows.Forms.Button();
            this.pbActionBarSlot9 = new System.Windows.Forms.PictureBox();
            this.pbActionBarSlot8 = new System.Windows.Forms.PictureBox();
            this.pbActionBarSlot7 = new System.Windows.Forms.PictureBox();
            this.pbActionBarSlot6 = new System.Windows.Forms.PictureBox();
            this.pbActionBarSlot5 = new System.Windows.Forms.PictureBox();
            this.pbActionBarSlot4 = new System.Windows.Forms.PictureBox();
            this.pbActionBarSlot3 = new System.Windows.Forms.PictureBox();
            this.pbActionBarSlot2 = new System.Windows.Forms.PictureBox();
            this.pbActionBarSlot1 = new System.Windows.Forms.PictureBox();
            this.ttActionSlot1 = new System.Windows.Forms.ToolTip(this.components);
            this.ttActionSlot2 = new System.Windows.Forms.ToolTip(this.components);
            this.ttActionSlot3 = new System.Windows.Forms.ToolTip(this.components);
            this.ttActionSlot4 = new System.Windows.Forms.ToolTip(this.components);
            this.ttActionSlot5 = new System.Windows.Forms.ToolTip(this.components);
            this.ttActionSlot6 = new System.Windows.Forms.ToolTip(this.components);
            this.ttActionSlot7 = new System.Windows.Forms.ToolTip(this.components);
            this.ttActionSlot8 = new System.Windows.Forms.ToolTip(this.components);
            this.ttActionSlot9 = new System.Windows.Forms.ToolTip(this.components);
            this.actionSpeedBarEnemy = new IdleGame.ExperienceBar();
            this.manaBarEnemy = new IdleGame.ManaBar();
            this.healthBarEnemy = new IdleGame.HealthBar();
            this.actionSpeedBar = new IdleGame.ExperienceBar();
            this.manaBar = new IdleGame.ManaBar();
            this.healthBar = new IdleGame.HealthBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(265, 59);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(60, 13);
            this.lblMana.TabIndex = 32;
            this.lblMana.Text = "9999/9999";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Location = new System.Drawing.Point(265, 32);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(60, 13);
            this.lblHealth.TabIndex = 31;
            this.lblHealth.Text = "9999/9999";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(174, 9);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(59, 13);
            this.lblClass.TabIndex = 30;
            this.lblClass.Text = "Adventurer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // lbCombatLog
            // 
            this.lbCombatLog.FormattingEnabled = true;
            this.lbCombatLog.Location = new System.Drawing.Point(426, 147);
            this.lbCombatLog.Name = "lbCombatLog";
            this.lbCombatLog.Size = new System.Drawing.Size(310, 69);
            this.lbCombatLog.TabIndex = 37;
            // 
            // lblManaEnemy
            // 
            this.lblManaEnemy.AutoSize = true;
            this.lblManaEnemy.Location = new System.Drawing.Point(611, 59);
            this.lblManaEnemy.Name = "lblManaEnemy";
            this.lblManaEnemy.Size = new System.Drawing.Size(60, 13);
            this.lblManaEnemy.TabIndex = 41;
            this.lblManaEnemy.Text = "9999/9999";
            // 
            // lblHealthEnemy
            // 
            this.lblHealthEnemy.AutoSize = true;
            this.lblHealthEnemy.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthEnemy.Location = new System.Drawing.Point(611, 32);
            this.lblHealthEnemy.Name = "lblHealthEnemy";
            this.lblHealthEnemy.Size = new System.Drawing.Size(60, 13);
            this.lblHealthEnemy.TabIndex = 40;
            this.lblHealthEnemy.Text = "9999/9999";
            // 
            // lblEnemyType
            // 
            this.lblEnemyType.AutoSize = true;
            this.lblEnemyType.Location = new System.Drawing.Point(520, 9);
            this.lblEnemyType.Name = "lblEnemyType";
            this.lblEnemyType.Size = new System.Drawing.Size(59, 13);
            this.lblEnemyType.TabIndex = 39;
            this.lblEnemyType.Text = "Adventurer";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Location = new System.Drawing.Point(435, 9);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(35, 13);
            this.lblEnemyName.TabIndex = 38;
            this.lblEnemyName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(7, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 2);
            this.label1.TabIndex = 46;
            this.label1.Text = " ";
            // 
            // tbCurrentAction
            // 
            this.tbCurrentAction.Location = new System.Drawing.Point(165, 102);
            this.tbCurrentAction.Name = "tbCurrentAction";
            this.tbCurrentAction.ReadOnly = true;
            this.tbCurrentAction.Size = new System.Drawing.Size(160, 20);
            this.tbCurrentAction.TabIndex = 47;
            // 
            // lblCurrentActionStatic
            // 
            this.lblCurrentActionStatic.AutoSize = true;
            this.lblCurrentActionStatic.Location = new System.Drawing.Point(89, 105);
            this.lblCurrentActionStatic.Name = "lblCurrentActionStatic";
            this.lblCurrentActionStatic.Size = new System.Drawing.Size(76, 13);
            this.lblCurrentActionStatic.TabIndex = 48;
            this.lblCurrentActionStatic.Text = "Current action:";
            // 
            // lblCurrentActionEnemyStatic
            // 
            this.lblCurrentActionEnemyStatic.AutoSize = true;
            this.lblCurrentActionEnemyStatic.Location = new System.Drawing.Point(435, 105);
            this.lblCurrentActionEnemyStatic.Name = "lblCurrentActionEnemyStatic";
            this.lblCurrentActionEnemyStatic.Size = new System.Drawing.Size(76, 13);
            this.lblCurrentActionEnemyStatic.TabIndex = 50;
            this.lblCurrentActionEnemyStatic.Text = "Current action:";
            // 
            // tbCurrentActionEnemy
            // 
            this.tbCurrentActionEnemy.Location = new System.Drawing.Point(511, 102);
            this.tbCurrentActionEnemy.Name = "tbCurrentActionEnemy";
            this.tbCurrentActionEnemy.ReadOnly = true;
            this.tbCurrentActionEnemy.Size = new System.Drawing.Size(160, 20);
            this.tbCurrentActionEnemy.TabIndex = 49;
            // 
            // lblCombatLogStatic
            // 
            this.lblCombatLogStatic.AutoSize = true;
            this.lblCombatLogStatic.Location = new System.Drawing.Point(423, 131);
            this.lblCombatLogStatic.Name = "lblCombatLogStatic";
            this.lblCombatLogStatic.Size = new System.Drawing.Size(67, 13);
            this.lblCombatLogStatic.TabIndex = 51;
            this.lblCombatLogStatic.Text = "Combat Log:";
            // 
            // timerAction
            // 
            this.timerAction.Enabled = true;
            this.timerAction.Interval = 10;
            this.timerAction.Tick += new System.EventHandler(this.timerAction_Tick);
            // 
            // btnWeaponAttack
            // 
            this.btnWeaponAttack.Location = new System.Drawing.Point(12, 132);
            this.btnWeaponAttack.Name = "btnWeaponAttack";
            this.btnWeaponAttack.Size = new System.Drawing.Size(75, 35);
            this.btnWeaponAttack.TabIndex = 52;
            this.btnWeaponAttack.Text = "Weapon Attack";
            this.btnWeaponAttack.UseVisualStyleBackColor = true;
            this.btnWeaponAttack.Click += new System.EventHandler(this.btnWeaponAttack_Click);
            // 
            // pbActionBarSlot9
            // 
            this.pbActionBarSlot9.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot9.Location = new System.Drawing.Point(380, 175);
            this.pbActionBarSlot9.Name = "pbActionBarSlot9";
            this.pbActionBarSlot9.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot9.TabIndex = 61;
            this.pbActionBarSlot9.TabStop = false;
            this.pbActionBarSlot9.Click += new System.EventHandler(this.pbActionBarSlot9_Click);
            // 
            // pbActionBarSlot8
            // 
            this.pbActionBarSlot8.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot8.Location = new System.Drawing.Point(334, 175);
            this.pbActionBarSlot8.Name = "pbActionBarSlot8";
            this.pbActionBarSlot8.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot8.TabIndex = 60;
            this.pbActionBarSlot8.TabStop = false;
            this.pbActionBarSlot8.Click += new System.EventHandler(this.pbActionBarSlot8_Click);
            // 
            // pbActionBarSlot7
            // 
            this.pbActionBarSlot7.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot7.Location = new System.Drawing.Point(288, 175);
            this.pbActionBarSlot7.Name = "pbActionBarSlot7";
            this.pbActionBarSlot7.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot7.TabIndex = 59;
            this.pbActionBarSlot7.TabStop = false;
            this.pbActionBarSlot7.Click += new System.EventHandler(this.pbActionBarSlot7_Click);
            // 
            // pbActionBarSlot6
            // 
            this.pbActionBarSlot6.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot6.Location = new System.Drawing.Point(242, 175);
            this.pbActionBarSlot6.Name = "pbActionBarSlot6";
            this.pbActionBarSlot6.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot6.TabIndex = 58;
            this.pbActionBarSlot6.TabStop = false;
            this.pbActionBarSlot6.Click += new System.EventHandler(this.pbActionBarSlot6_Click);
            // 
            // pbActionBarSlot5
            // 
            this.pbActionBarSlot5.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot5.Location = new System.Drawing.Point(196, 175);
            this.pbActionBarSlot5.Name = "pbActionBarSlot5";
            this.pbActionBarSlot5.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot5.TabIndex = 57;
            this.pbActionBarSlot5.TabStop = false;
            this.pbActionBarSlot5.Click += new System.EventHandler(this.pbActionBarSlot5_Click);
            // 
            // pbActionBarSlot4
            // 
            this.pbActionBarSlot4.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot4.Location = new System.Drawing.Point(150, 175);
            this.pbActionBarSlot4.Name = "pbActionBarSlot4";
            this.pbActionBarSlot4.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot4.TabIndex = 56;
            this.pbActionBarSlot4.TabStop = false;
            this.pbActionBarSlot4.Click += new System.EventHandler(this.pbActionBarSlot4_Click);
            // 
            // pbActionBarSlot3
            // 
            this.pbActionBarSlot3.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot3.Location = new System.Drawing.Point(104, 175);
            this.pbActionBarSlot3.Name = "pbActionBarSlot3";
            this.pbActionBarSlot3.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot3.TabIndex = 55;
            this.pbActionBarSlot3.TabStop = false;
            this.pbActionBarSlot3.Click += new System.EventHandler(this.pbActionBarSlot3_Click);
            // 
            // pbActionBarSlot2
            // 
            this.pbActionBarSlot2.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot2.Location = new System.Drawing.Point(58, 175);
            this.pbActionBarSlot2.Name = "pbActionBarSlot2";
            this.pbActionBarSlot2.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot2.TabIndex = 54;
            this.pbActionBarSlot2.TabStop = false;
            this.pbActionBarSlot2.Click += new System.EventHandler(this.pbActionBarSlot2_Click);
            // 
            // pbActionBarSlot1
            // 
            this.pbActionBarSlot1.Image = global::IdleGame.Properties.Resources.ActionBarSlot;
            this.pbActionBarSlot1.Location = new System.Drawing.Point(12, 175);
            this.pbActionBarSlot1.Name = "pbActionBarSlot1";
            this.pbActionBarSlot1.Size = new System.Drawing.Size(40, 40);
            this.pbActionBarSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActionBarSlot1.TabIndex = 53;
            this.pbActionBarSlot1.TabStop = false;
            this.pbActionBarSlot1.Click += new System.EventHandler(this.pbActionBarSlot1_Click);
            // 
            // ttActionSlot1
            // 
            this.ttActionSlot1.AutomaticDelay = 50;
            this.ttActionSlot1.AutoPopDelay = 5000;
            this.ttActionSlot1.InitialDelay = 50;
            this.ttActionSlot1.ReshowDelay = 10;
            // 
            // ttActionSlot2
            // 
            this.ttActionSlot2.AutomaticDelay = 50;
            this.ttActionSlot2.AutoPopDelay = 5000;
            this.ttActionSlot2.InitialDelay = 50;
            this.ttActionSlot2.ReshowDelay = 10;
            // 
            // ttActionSlot3
            // 
            this.ttActionSlot3.AutomaticDelay = 50;
            this.ttActionSlot3.AutoPopDelay = 5000;
            this.ttActionSlot3.InitialDelay = 50;
            this.ttActionSlot3.ReshowDelay = 10;
            // 
            // ttActionSlot4
            // 
            this.ttActionSlot4.AutomaticDelay = 50;
            this.ttActionSlot4.AutoPopDelay = 5000;
            this.ttActionSlot4.InitialDelay = 50;
            this.ttActionSlot4.ReshowDelay = 10;
            // 
            // ttActionSlot5
            // 
            this.ttActionSlot5.AutomaticDelay = 50;
            this.ttActionSlot5.AutoPopDelay = 5000;
            this.ttActionSlot5.InitialDelay = 50;
            this.ttActionSlot5.ReshowDelay = 10;
            // 
            // ttActionSlot6
            // 
            this.ttActionSlot6.AutomaticDelay = 50;
            this.ttActionSlot6.AutoPopDelay = 5000;
            this.ttActionSlot6.InitialDelay = 50;
            this.ttActionSlot6.ReshowDelay = 10;
            // 
            // ttActionSlot7
            // 
            this.ttActionSlot7.AutomaticDelay = 50;
            this.ttActionSlot7.AutoPopDelay = 5000;
            this.ttActionSlot7.InitialDelay = 50;
            this.ttActionSlot7.ReshowDelay = 10;
            // 
            // ttActionSlot8
            // 
            this.ttActionSlot8.AutomaticDelay = 50;
            this.ttActionSlot8.AutoPopDelay = 5000;
            this.ttActionSlot8.InitialDelay = 50;
            this.ttActionSlot8.ReshowDelay = 10;
            // 
            // ttActionSlot9
            // 
            this.ttActionSlot9.AutomaticDelay = 50;
            this.ttActionSlot9.AutoPopDelay = 5000;
            this.ttActionSlot9.InitialDelay = 50;
            this.ttActionSlot9.ReshowDelay = 10;
            // 
            // actionSpeedBarEnemy
            // 
            this.actionSpeedBarEnemy.Location = new System.Drawing.Point(438, 82);
            this.actionSpeedBarEnemy.Name = "actionSpeedBarEnemy";
            this.actionSpeedBarEnemy.Size = new System.Drawing.Size(233, 14);
            this.actionSpeedBarEnemy.TabIndex = 44;
            // 
            // manaBarEnemy
            // 
            this.manaBarEnemy.Location = new System.Drawing.Point(438, 56);
            this.manaBarEnemy.Name = "manaBarEnemy";
            this.manaBarEnemy.Size = new System.Drawing.Size(167, 20);
            this.manaBarEnemy.TabIndex = 43;
            // 
            // healthBarEnemy
            // 
            this.healthBarEnemy.Location = new System.Drawing.Point(438, 25);
            this.healthBarEnemy.Name = "healthBarEnemy";
            this.healthBarEnemy.Size = new System.Drawing.Size(167, 25);
            this.healthBarEnemy.TabIndex = 42;
            // 
            // actionSpeedBar
            // 
            this.actionSpeedBar.Location = new System.Drawing.Point(92, 82);
            this.actionSpeedBar.Name = "actionSpeedBar";
            this.actionSpeedBar.Size = new System.Drawing.Size(233, 14);
            this.actionSpeedBar.TabIndex = 36;
            // 
            // manaBar
            // 
            this.manaBar.Location = new System.Drawing.Point(92, 56);
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(167, 20);
            this.manaBar.TabIndex = 35;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(92, 25);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(167, 25);
            this.healthBar.TabIndex = 34;
            // 
            // CombatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 226);
            this.Controls.Add(this.pbActionBarSlot9);
            this.Controls.Add(this.pbActionBarSlot8);
            this.Controls.Add(this.pbActionBarSlot7);
            this.Controls.Add(this.pbActionBarSlot6);
            this.Controls.Add(this.pbActionBarSlot5);
            this.Controls.Add(this.pbActionBarSlot4);
            this.Controls.Add(this.pbActionBarSlot3);
            this.Controls.Add(this.pbActionBarSlot2);
            this.Controls.Add(this.pbActionBarSlot1);
            this.Controls.Add(this.btnWeaponAttack);
            this.Controls.Add(this.lblCombatLogStatic);
            this.Controls.Add(this.lblCurrentActionEnemyStatic);
            this.Controls.Add(this.tbCurrentActionEnemy);
            this.Controls.Add(this.lblCurrentActionStatic);
            this.Controls.Add(this.tbCurrentAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.actionSpeedBarEnemy);
            this.Controls.Add(this.manaBarEnemy);
            this.Controls.Add(this.lblManaEnemy);
            this.Controls.Add(this.lblHealthEnemy);
            this.Controls.Add(this.lblEnemyType);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.healthBarEnemy);
            this.Controls.Add(this.lbCombatLog);
            this.Controls.Add(this.actionSpeedBar);
            this.Controls.Add(this.manaBar);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.healthBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CombatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActionBarSlot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ManaBar manaBar;
        private HealthBar healthBar;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblName;
        private ExperienceBar actionSpeedBar;
        private System.Windows.Forms.ListBox lbCombatLog;
        private ExperienceBar actionSpeedBarEnemy;
        private ManaBar manaBarEnemy;
        private System.Windows.Forms.Label lblManaEnemy;
        private System.Windows.Forms.Label lblHealthEnemy;
        private System.Windows.Forms.Label lblEnemyType;
        private System.Windows.Forms.Label lblEnemyName;
        private HealthBar healthBarEnemy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentAction;
        private System.Windows.Forms.Label lblCurrentActionStatic;
        private System.Windows.Forms.Label lblCurrentActionEnemyStatic;
        private System.Windows.Forms.TextBox tbCurrentActionEnemy;
        private System.Windows.Forms.Label lblCombatLogStatic;
        private System.Windows.Forms.Timer timerAction;
        private System.Windows.Forms.Button btnWeaponAttack;
        private System.Windows.Forms.PictureBox pbActionBarSlot9;
        private System.Windows.Forms.PictureBox pbActionBarSlot8;
        private System.Windows.Forms.PictureBox pbActionBarSlot7;
        private System.Windows.Forms.PictureBox pbActionBarSlot6;
        private System.Windows.Forms.PictureBox pbActionBarSlot5;
        private System.Windows.Forms.PictureBox pbActionBarSlot4;
        private System.Windows.Forms.PictureBox pbActionBarSlot3;
        private System.Windows.Forms.PictureBox pbActionBarSlot2;
        private System.Windows.Forms.PictureBox pbActionBarSlot1;
        private System.Windows.Forms.ToolTip ttActionSlot1;
        private System.Windows.Forms.ToolTip ttActionSlot2;
        private System.Windows.Forms.ToolTip ttActionSlot3;
        private System.Windows.Forms.ToolTip ttActionSlot4;
        private System.Windows.Forms.ToolTip ttActionSlot5;
        private System.Windows.Forms.ToolTip ttActionSlot6;
        private System.Windows.Forms.ToolTip ttActionSlot7;
        private System.Windows.Forms.ToolTip ttActionSlot8;
        private System.Windows.Forms.ToolTip ttActionSlot9;
    }
}