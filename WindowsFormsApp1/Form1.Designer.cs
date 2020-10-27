namespace TD_Game
{
    partial class towerDefense
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
            this.mainArea = new System.Windows.Forms.Panel();
            this.towersButton = new System.Windows.Forms.Button();
            this.abilitiesButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.upgradesButton = new System.Windows.Forms.Button();
            this.tpLabel = new System.Windows.Forms.Label();
            this.tomesLabel = new System.Windows.Forms.Label();
            this.coresLabel = new System.Windows.Forms.Label();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.enemiesButton = new System.Windows.Forms.Button();
            this.mainArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainArea
            // 
            this.mainArea.Controls.Add(this.enemiesButton);
            this.mainArea.Controls.Add(this.tutorialButton);
            this.mainArea.Controls.Add(this.coresLabel);
            this.mainArea.Controls.Add(this.tomesLabel);
            this.mainArea.Controls.Add(this.tpLabel);
            this.mainArea.Controls.Add(this.upgradesButton);
            this.mainArea.Controls.Add(this.quitButton);
            this.mainArea.Controls.Add(this.abilitiesButton);
            this.mainArea.Controls.Add(this.towersButton);
            this.mainArea.Location = new System.Drawing.Point(1, 1);
            this.mainArea.Name = "mainArea";
            this.mainArea.Size = new System.Drawing.Size(1263, 681);
            this.mainArea.TabIndex = 0;
            // 
            // towersButton
            // 
            this.towersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.towersButton.Location = new System.Drawing.Point(11, 11);
            this.towersButton.Name = "towersButton";
            this.towersButton.Size = new System.Drawing.Size(138, 62);
            this.towersButton.TabIndex = 0;
            this.towersButton.Text = "Towers";
            this.towersButton.UseVisualStyleBackColor = true;
            // 
            // abilitiesButton
            // 
            this.abilitiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilitiesButton.Location = new System.Drawing.Point(11, 160);
            this.abilitiesButton.Name = "abilitiesButton";
            this.abilitiesButton.Size = new System.Drawing.Size(138, 62);
            this.abilitiesButton.TabIndex = 1;
            this.abilitiesButton.Text = "Abilities";
            this.abilitiesButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(11, 606);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(138, 62);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // upgradesButton
            // 
            this.upgradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgradesButton.Location = new System.Drawing.Point(11, 311);
            this.upgradesButton.Name = "upgradesButton";
            this.upgradesButton.Size = new System.Drawing.Size(138, 62);
            this.upgradesButton.TabIndex = 3;
            this.upgradesButton.Text = "Upgrades";
            this.upgradesButton.UseVisualStyleBackColor = true;
            // 
            // tpLabel
            // 
            this.tpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLabel.Location = new System.Drawing.Point(11, 76);
            this.tpLabel.Name = "tpLabel";
            this.tpLabel.Size = new System.Drawing.Size(138, 81);
            this.tpLabel.TabIndex = 4;
            this.tpLabel.Text = "You have 0 permits. Get more by leveling up or killing enemies.";
            this.tpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tomesLabel
            // 
            this.tomesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomesLabel.Location = new System.Drawing.Point(11, 224);
            this.tomesLabel.Name = "tomesLabel";
            this.tomesLabel.Size = new System.Drawing.Size(138, 84);
            this.tomesLabel.TabIndex = 5;
            this.tomesLabel.Text = "You have 0 tomes. Get more by leveling up or killing enemies.";
            this.tomesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // coresLabel
            // 
            this.coresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coresLabel.Location = new System.Drawing.Point(11, 376);
            this.coresLabel.Name = "coresLabel";
            this.coresLabel.Size = new System.Drawing.Size(138, 102);
            this.coresLabel.TabIndex = 6;
            this.coresLabel.Text = "You have 0 cores. Get more by leveling up or killing enemies.";
            this.coresLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tutorialButton
            // 
            this.tutorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialButton.Location = new System.Drawing.Point(11, 538);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(138, 62);
            this.tutorialButton.TabIndex = 7;
            this.tutorialButton.Text = "Tutorial";
            this.tutorialButton.UseVisualStyleBackColor = true;
            // 
            // enemiesButton
            // 
            this.enemiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemiesButton.Location = new System.Drawing.Point(11, 470);
            this.enemiesButton.Name = "enemiesButton";
            this.enemiesButton.Size = new System.Drawing.Size(138, 62);
            this.enemiesButton.TabIndex = 8;
            this.enemiesButton.Text = "Enemies";
            this.enemiesButton.UseVisualStyleBackColor = true;
            // 
            // towerDefense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainArea);
            this.Name = "towerDefense";
            this.Text = "Tower Defense";
            this.mainArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainArea;
        private System.Windows.Forms.Button upgradesButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button abilitiesButton;
        private System.Windows.Forms.Button towersButton;
        private System.Windows.Forms.Label coresLabel;
        private System.Windows.Forms.Label tomesLabel;
        private System.Windows.Forms.Label tpLabel;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Button enemiesButton;
    }
}

