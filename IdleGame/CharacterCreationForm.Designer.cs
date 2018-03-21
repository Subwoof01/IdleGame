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
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnSorcerer = new System.Windows.Forms.Button();
            this.btnRanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWarrior
            // 
            this.btnWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarrior.Location = new System.Drawing.Point(12, 12);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(164, 46);
            this.btnWarrior.TabIndex = 0;
            this.btnWarrior.Text = "Warrior";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // btnSorcerer
            // 
            this.btnSorcerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorcerer.Location = new System.Drawing.Point(12, 64);
            this.btnSorcerer.Name = "btnSorcerer";
            this.btnSorcerer.Size = new System.Drawing.Size(164, 46);
            this.btnSorcerer.TabIndex = 1;
            this.btnSorcerer.Text = "Sorcerer";
            this.btnSorcerer.UseVisualStyleBackColor = true;
            this.btnSorcerer.Click += new System.EventHandler(this.btnSorcerer_Click);
            // 
            // btnRanger
            // 
            this.btnRanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanger.Location = new System.Drawing.Point(12, 116);
            this.btnRanger.Name = "btnRanger";
            this.btnRanger.Size = new System.Drawing.Size(164, 46);
            this.btnRanger.TabIndex = 2;
            this.btnRanger.Text = "Ranger";
            this.btnRanger.UseVisualStyleBackColor = true;
            this.btnRanger.Click += new System.EventHandler(this.btnRanger_Click);
            // 
            // CharacterCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 176);
            this.Controls.Add(this.btnRanger);
            this.Controls.Add(this.btnSorcerer);
            this.Controls.Add(this.btnWarrior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CharacterCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterCreationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnSorcerer;
        private System.Windows.Forms.Button btnRanger;
    }
}