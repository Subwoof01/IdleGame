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
            this.actionSpeedBarEnemy = new IdleGame.ExperienceBar();
            this.manaBarEnemy = new IdleGame.ManaBar();
            this.healthBarEnemy = new IdleGame.HealthBar();
            this.actionSpeedBar = new IdleGame.ExperienceBar();
            this.manaBar = new IdleGame.ManaBar();
            this.healthBar = new IdleGame.HealthBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(188, 59);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(60, 13);
            this.lblMana.TabIndex = 32;
            this.lblMana.Text = "9999/9999";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Location = new System.Drawing.Point(188, 32);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(60, 13);
            this.lblHealth.TabIndex = 31;
            this.lblHealth.Text = "9999/9999";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(97, 9);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(59, 13);
            this.lblClass.TabIndex = 30;
            this.lblClass.Text = "Adventurer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // lbCombatLog
            // 
            this.lbCombatLog.FormattingEnabled = true;
            this.lbCombatLog.Location = new System.Drawing.Point(396, 147);
            this.lbCombatLog.Name = "lbCombatLog";
            this.lbCombatLog.Size = new System.Drawing.Size(199, 160);
            this.lbCombatLog.TabIndex = 37;
            // 
            // lblManaEnemy
            // 
            this.lblManaEnemy.AutoSize = true;
            this.lblManaEnemy.Location = new System.Drawing.Point(534, 59);
            this.lblManaEnemy.Name = "lblManaEnemy";
            this.lblManaEnemy.Size = new System.Drawing.Size(60, 13);
            this.lblManaEnemy.TabIndex = 41;
            this.lblManaEnemy.Text = "9999/9999";
            // 
            // lblHealthEnemy
            // 
            this.lblHealthEnemy.AutoSize = true;
            this.lblHealthEnemy.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthEnemy.Location = new System.Drawing.Point(534, 32);
            this.lblHealthEnemy.Name = "lblHealthEnemy";
            this.lblHealthEnemy.Size = new System.Drawing.Size(60, 13);
            this.lblHealthEnemy.TabIndex = 40;
            this.lblHealthEnemy.Text = "9999/9999";
            // 
            // lblEnemyType
            // 
            this.lblEnemyType.AutoSize = true;
            this.lblEnemyType.Location = new System.Drawing.Point(443, 9);
            this.lblEnemyType.Name = "lblEnemyType";
            this.lblEnemyType.Size = new System.Drawing.Size(59, 13);
            this.lblEnemyType.TabIndex = 39;
            this.lblEnemyType.Text = "Adventurer";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Location = new System.Drawing.Point(358, 9);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(35, 13);
            this.lblEnemyName.TabIndex = 38;
            this.lblEnemyName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(5, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 2);
            this.label1.TabIndex = 46;
            this.label1.Text = " ";
            // 
            // tbCurrentAction
            // 
            this.tbCurrentAction.Location = new System.Drawing.Point(88, 102);
            this.tbCurrentAction.Name = "tbCurrentAction";
            this.tbCurrentAction.ReadOnly = true;
            this.tbCurrentAction.Size = new System.Drawing.Size(160, 20);
            this.tbCurrentAction.TabIndex = 47;
            // 
            // lblCurrentActionStatic
            // 
            this.lblCurrentActionStatic.AutoSize = true;
            this.lblCurrentActionStatic.Location = new System.Drawing.Point(12, 105);
            this.lblCurrentActionStatic.Name = "lblCurrentActionStatic";
            this.lblCurrentActionStatic.Size = new System.Drawing.Size(76, 13);
            this.lblCurrentActionStatic.TabIndex = 48;
            this.lblCurrentActionStatic.Text = "Current action:";
            // 
            // lblCurrentActionEnemyStatic
            // 
            this.lblCurrentActionEnemyStatic.AutoSize = true;
            this.lblCurrentActionEnemyStatic.Location = new System.Drawing.Point(358, 105);
            this.lblCurrentActionEnemyStatic.Name = "lblCurrentActionEnemyStatic";
            this.lblCurrentActionEnemyStatic.Size = new System.Drawing.Size(76, 13);
            this.lblCurrentActionEnemyStatic.TabIndex = 50;
            this.lblCurrentActionEnemyStatic.Text = "Current action:";
            // 
            // tbCurrentActionEnemy
            // 
            this.tbCurrentActionEnemy.Location = new System.Drawing.Point(434, 102);
            this.tbCurrentActionEnemy.Name = "tbCurrentActionEnemy";
            this.tbCurrentActionEnemy.ReadOnly = true;
            this.tbCurrentActionEnemy.Size = new System.Drawing.Size(160, 20);
            this.tbCurrentActionEnemy.TabIndex = 49;
            // 
            // lblCombatLogStatic
            // 
            this.lblCombatLogStatic.AutoSize = true;
            this.lblCombatLogStatic.Location = new System.Drawing.Point(393, 131);
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
            this.btnWeaponAttack.Location = new System.Drawing.Point(12, 147);
            this.btnWeaponAttack.Name = "btnWeaponAttack";
            this.btnWeaponAttack.Size = new System.Drawing.Size(75, 35);
            this.btnWeaponAttack.TabIndex = 52;
            this.btnWeaponAttack.Text = "Weapon Attack";
            this.btnWeaponAttack.UseVisualStyleBackColor = true;
            this.btnWeaponAttack.Click += new System.EventHandler(this.btnWeaponAttack_Click);
            // 
            // actionSpeedBarEnemy
            // 
            this.actionSpeedBarEnemy.Location = new System.Drawing.Point(361, 82);
            this.actionSpeedBarEnemy.Name = "actionSpeedBarEnemy";
            this.actionSpeedBarEnemy.Size = new System.Drawing.Size(233, 14);
            this.actionSpeedBarEnemy.TabIndex = 44;
            // 
            // manaBarEnemy
            // 
            this.manaBarEnemy.Location = new System.Drawing.Point(361, 56);
            this.manaBarEnemy.Name = "manaBarEnemy";
            this.manaBarEnemy.Size = new System.Drawing.Size(167, 20);
            this.manaBarEnemy.TabIndex = 43;
            // 
            // healthBarEnemy
            // 
            this.healthBarEnemy.Location = new System.Drawing.Point(361, 25);
            this.healthBarEnemy.Name = "healthBarEnemy";
            this.healthBarEnemy.Size = new System.Drawing.Size(167, 25);
            this.healthBarEnemy.TabIndex = 42;
            // 
            // actionSpeedBar
            // 
            this.actionSpeedBar.Location = new System.Drawing.Point(15, 82);
            this.actionSpeedBar.Name = "actionSpeedBar";
            this.actionSpeedBar.Size = new System.Drawing.Size(233, 14);
            this.actionSpeedBar.TabIndex = 36;
            // 
            // manaBar
            // 
            this.manaBar.Location = new System.Drawing.Point(15, 56);
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(167, 20);
            this.manaBar.TabIndex = 35;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(15, 25);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(167, 25);
            this.healthBar.TabIndex = 34;
            // 
            // CombatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 319);
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
            this.Name = "CombatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}