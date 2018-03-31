namespace IdleGame
{
    partial class SkillBookPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSkillType = new System.Windows.Forms.Label();
            this.lblSkillNextRank = new System.Windows.Forms.Label();
            this.lblSkillLearned = new System.Windows.Forms.Label();
            this.pbSkill = new System.Windows.Forms.PictureBox();
            this.ttSkillEffect = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkillType
            // 
            this.lblSkillType.AutoSize = true;
            this.lblSkillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillType.Location = new System.Drawing.Point(46, 30);
            this.lblSkillType.Name = "lblSkillType";
            this.lblSkillType.Size = new System.Drawing.Size(25, 13);
            this.lblSkillType.TabIndex = 3;
            this.lblSkillType.Text = "123";
            // 
            // lblSkillNextRank
            // 
            this.lblSkillNextRank.AutoSize = true;
            this.lblSkillNextRank.Location = new System.Drawing.Point(46, 16);
            this.lblSkillNextRank.Name = "lblSkillNextRank";
            this.lblSkillNextRank.Size = new System.Drawing.Size(25, 13);
            this.lblSkillNextRank.TabIndex = 2;
            this.lblSkillNextRank.Text = "123";
            // 
            // lblSkillLearned
            // 
            this.lblSkillLearned.AutoSize = true;
            this.lblSkillLearned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillLearned.Location = new System.Drawing.Point(46, 3);
            this.lblSkillLearned.Name = "lblSkillLearned";
            this.lblSkillLearned.Size = new System.Drawing.Size(28, 13);
            this.lblSkillLearned.TabIndex = 1;
            this.lblSkillLearned.Text = "123";
            // 
            // pbSkill
            // 
            this.pbSkill.Location = new System.Drawing.Point(3, 3);
            this.pbSkill.Name = "pbSkill";
            this.pbSkill.Size = new System.Drawing.Size(40, 40);
            this.pbSkill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSkill.TabIndex = 0;
            this.pbSkill.TabStop = false;
            this.pbSkill.Click += new System.EventHandler(this.pbSkill_Click);
            // 
            // ttSkillEffect
            // 
            this.ttSkillEffect.AutomaticDelay = 50;
            this.ttSkillEffect.AutoPopDelay = 5000;
            this.ttSkillEffect.InitialDelay = 50;
            this.ttSkillEffect.ReshowDelay = 10;
            // 
            // SkillBookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblSkillType);
            this.Controls.Add(this.lblSkillNextRank);
            this.Controls.Add(this.pbSkill);
            this.Controls.Add(this.lblSkillLearned);
            this.Name = "SkillBookPanel";
            this.Size = new System.Drawing.Size(77, 46);
            ((System.ComponentModel.ISupportInitialize)(this.pbSkill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbSkill;
        public System.Windows.Forms.Label lblSkillType;
        public System.Windows.Forms.Label lblSkillNextRank;
        public System.Windows.Forms.Label lblSkillLearned;
        public System.Windows.Forms.ToolTip ttSkillEffect;
    }
}
