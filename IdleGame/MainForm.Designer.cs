using IdleGame.ProgressBars;

namespace IdleGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblCurrentTask = new System.Windows.Forms.Label();
            this.btnCharacter = new System.Windows.Forms.Button();
            this.btnTravel = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.experienceBar = new IdleGame.ProgressBars.ExperienceBar();
            this.manaBar = new IdleGame.ProgressBars.ManaBar();
            this.healthBar = new IdleGame.ProgressBars.HealthBar();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(116, 9);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(59, 13);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Adventurer";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(12, 143);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 6;
            this.btnInventory.Text = "Equipment";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lblCurrentTask
            // 
            this.lblCurrentTask.AutoSize = true;
            this.lblCurrentTask.Location = new System.Drawing.Point(53, 99);
            this.lblCurrentTask.Name = "lblCurrentTask";
            this.lblCurrentTask.Size = new System.Drawing.Size(68, 13);
            this.lblCurrentTask.TabIndex = 7;
            this.lblCurrentTask.Text = "Current Task";
            this.lblCurrentTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCharacter
            // 
            this.btnCharacter.Location = new System.Drawing.Point(12, 114);
            this.btnCharacter.Name = "btnCharacter";
            this.btnCharacter.Size = new System.Drawing.Size(75, 23);
            this.btnCharacter.TabIndex = 8;
            this.btnCharacter.Text = "Character";
            this.btnCharacter.UseVisualStyleBackColor = true;
            this.btnCharacter.Click += new System.EventHandler(this.btnCharacter_Click);
            // 
            // btnTravel
            // 
            this.btnTravel.Location = new System.Drawing.Point(100, 143);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(75, 23);
            this.btnTravel.TabIndex = 9;
            this.btnTravel.Text = "Travel";
            this.btnTravel.UseVisualStyleBackColor = true;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(100, 114);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(75, 23);
            this.btnShop.TabIndex = 10;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(62, 172);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(59, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(127, 172);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.DefaultExt = "dat";
            this.loadFileDialog.FileName = "save.dat";
            this.loadFileDialog.Filter = "Save files (*.dat)|*.dat";
            // 
            // experienceBar
            // 
            this.experienceBar.Location = new System.Drawing.Point(12, 81);
            this.experienceBar.Name = "experienceBar";
            this.experienceBar.Size = new System.Drawing.Size(163, 14);
            this.experienceBar.TabIndex = 20;
            // 
            // manaBar
            // 
            this.manaBar.Location = new System.Drawing.Point(12, 53);
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(163, 22);
            this.manaBar.TabIndex = 19;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(12, 25);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(163, 22);
            this.healthBar.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 201);
            this.Controls.Add(this.experienceBar);
            this.Controls.Add(this.manaBar);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnTravel);
            this.Controls.Add(this.btnCharacter);
            this.Controls.Add(this.lblCurrentTask);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblCurrentTask;
        private System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private HealthBar healthBar;
        private ManaBar manaBar;
        private ExperienceBar experienceBar;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
    }
}

