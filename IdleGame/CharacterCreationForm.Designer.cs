namespace IdleGame
{
    partial class CharacterCreationForm
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
            this.lblNameStatic = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblClassStatic = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblBaseStatic = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.tbMaxHealth = new System.Windows.Forms.TextBox();
            this.tbMaxMana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStrength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIntelligence = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDexterity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblNameStatic
            // 
            this.lblNameStatic.AutoSize = true;
            this.lblNameStatic.Location = new System.Drawing.Point(15, 9);
            this.lblNameStatic.Name = "lblNameStatic";
            this.lblNameStatic.Size = new System.Drawing.Size(38, 13);
            this.lblNameStatic.TabIndex = 3;
            this.lblNameStatic.Text = "Name:";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(56, 6);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(121, 20);
            this.tbPlayerName.TabIndex = 4;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Warrior",
            "Sorcerer",
            "Ranger"});
            this.cbClass.Location = new System.Drawing.Point(56, 32);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 21);
            this.cbClass.TabIndex = 5;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // lblClassStatic
            // 
            this.lblClassStatic.AutoSize = true;
            this.lblClassStatic.Location = new System.Drawing.Point(15, 35);
            this.lblClassStatic.Name = "lblClassStatic";
            this.lblClassStatic.Size = new System.Drawing.Size(35, 13);
            this.lblClassStatic.TabIndex = 6;
            this.lblClassStatic.Text = "Class:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(102, 209);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblBaseStatic
            // 
            this.lblBaseStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseStatic.Location = new System.Drawing.Point(18, 56);
            this.lblBaseStatic.Name = "lblBaseStatic";
            this.lblBaseStatic.Size = new System.Drawing.Size(159, 16);
            this.lblBaseStatic.TabIndex = 8;
            this.lblBaseStatic.Text = "Base Attributes";
            this.lblBaseStatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(15, 82);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(41, 13);
            this.lblHealth.TabIndex = 9;
            this.lblHealth.Text = "Health:";
            // 
            // tbMaxHealth
            // 
            this.tbMaxHealth.Location = new System.Drawing.Point(126, 79);
            this.tbMaxHealth.Name = "tbMaxHealth";
            this.tbMaxHealth.ReadOnly = true;
            this.tbMaxHealth.Size = new System.Drawing.Size(51, 20);
            this.tbMaxHealth.TabIndex = 10;
            this.tbMaxHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMaxMana
            // 
            this.tbMaxMana.Location = new System.Drawing.Point(126, 105);
            this.tbMaxMana.Name = "tbMaxMana";
            this.tbMaxMana.ReadOnly = true;
            this.tbMaxMana.Size = new System.Drawing.Size(51, 20);
            this.tbMaxMana.TabIndex = 12;
            this.tbMaxMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mana:";
            // 
            // tbStrength
            // 
            this.tbStrength.Location = new System.Drawing.Point(126, 131);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.ReadOnly = true;
            this.tbStrength.Size = new System.Drawing.Size(51, 20);
            this.tbStrength.TabIndex = 14;
            this.tbStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Strength:";
            // 
            // tbIntelligence
            // 
            this.tbIntelligence.Location = new System.Drawing.Point(126, 157);
            this.tbIntelligence.Name = "tbIntelligence";
            this.tbIntelligence.ReadOnly = true;
            this.tbIntelligence.Size = new System.Drawing.Size(51, 20);
            this.tbIntelligence.TabIndex = 16;
            this.tbIntelligence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Intelligence:";
            // 
            // tbDexterity
            // 
            this.tbDexterity.Location = new System.Drawing.Point(126, 183);
            this.tbDexterity.Name = "tbDexterity";
            this.tbDexterity.ReadOnly = true;
            this.tbDexterity.Size = new System.Drawing.Size(51, 20);
            this.tbDexterity.TabIndex = 18;
            this.tbDexterity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dexterity:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(18, 209);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // CharacterCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 238);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbDexterity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIntelligence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStrength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaxMana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaxHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblBaseStatic);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblClassStatic);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.lblNameStatic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CharacterCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterCreationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameStatic;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblClassStatic;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblBaseStatic;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox tbMaxHealth;
        private System.Windows.Forms.TextBox tbMaxMana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStrength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIntelligence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDexterity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
    }
}