
namespace AdventureGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.king = new System.Windows.Forms.Button();
            this.queen = new System.Windows.Forms.Button();
            this.knight = new System.Windows.Forms.Button();
            this.troll = new System.Windows.Forms.Button();
            this.axe = new System.Windows.Forms.Button();
            this.bow = new System.Windows.Forms.Button();
            this.Knife = new System.Windows.Forms.Button();
            this.sword = new System.Windows.Forms.Button();
            this.characterPanel = new System.Windows.Forms.Panel();
            this.weaponPanel = new System.Windows.Forms.Panel();
            this.weapons = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.characters = new System.Windows.Forms.Button();
            this.characterPanel.SuspendLayout();
            this.weaponPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // king
            // 
            this.king.Location = new System.Drawing.Point(3, 13);
            this.king.Name = "king";
            this.king.Size = new System.Drawing.Size(98, 62);
            this.king.TabIndex = 0;
            this.king.Tag = "character";
            this.king.Text = "King";
            this.king.UseVisualStyleBackColor = true;
            this.king.Click += new System.EventHandler(this.king_Click);
            // 
            // queen
            // 
            this.queen.Location = new System.Drawing.Point(3, 105);
            this.queen.Name = "queen";
            this.queen.Size = new System.Drawing.Size(98, 62);
            this.queen.TabIndex = 1;
            this.queen.Tag = "character";
            this.queen.Text = "Queen";
            this.queen.UseVisualStyleBackColor = true;
            this.queen.Click += new System.EventHandler(this.queen_Click);
            // 
            // knight
            // 
            this.knight.Location = new System.Drawing.Point(5, 194);
            this.knight.Name = "knight";
            this.knight.Size = new System.Drawing.Size(98, 62);
            this.knight.TabIndex = 2;
            this.knight.Tag = "character";
            this.knight.Text = "Knight";
            this.knight.UseVisualStyleBackColor = true;
            this.knight.Click += new System.EventHandler(this.knight_Click);
            // 
            // troll
            // 
            this.troll.Location = new System.Drawing.Point(5, 280);
            this.troll.Name = "troll";
            this.troll.Size = new System.Drawing.Size(98, 62);
            this.troll.TabIndex = 3;
            this.troll.Tag = "character";
            this.troll.Text = "Troll";
            this.troll.UseVisualStyleBackColor = true;
            this.troll.Click += new System.EventHandler(this.troll_Click);
            // 
            // axe
            // 
            this.axe.Location = new System.Drawing.Point(2, 194);
            this.axe.Name = "axe";
            this.axe.Size = new System.Drawing.Size(98, 62);
            this.axe.TabIndex = 4;
            this.axe.Tag = "weapon";
            this.axe.Text = "Axe";
            this.axe.UseVisualStyleBackColor = true;
            this.axe.Click += new System.EventHandler(this.axe_Click);
            // 
            // bow
            // 
            this.bow.Location = new System.Drawing.Point(0, 105);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(98, 62);
            this.bow.TabIndex = 5;
            this.bow.Tag = "weapon";
            this.bow.Text = "Bow and Arrow";
            this.bow.UseVisualStyleBackColor = true;
            this.bow.Click += new System.EventHandler(this.bow_Click);
            // 
            // Knife
            // 
            this.Knife.Location = new System.Drawing.Point(2, 13);
            this.Knife.Name = "Knife";
            this.Knife.Size = new System.Drawing.Size(98, 62);
            this.Knife.TabIndex = 6;
            this.Knife.Tag = "weapon";
            this.Knife.Text = "Knife";
            this.Knife.UseVisualStyleBackColor = true;
            this.Knife.Click += new System.EventHandler(this.Knife_Click);
            // 
            // sword
            // 
            this.sword.Location = new System.Drawing.Point(2, 280);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(98, 62);
            this.sword.TabIndex = 7;
            this.sword.Tag = "weapon";
            this.sword.Text = "Sword";
            this.sword.UseVisualStyleBackColor = true;
            this.sword.Click += new System.EventHandler(this.sword_Click);
            // 
            // characterPanel
            // 
            this.characterPanel.Controls.Add(this.king);
            this.characterPanel.Controls.Add(this.queen);
            this.characterPanel.Controls.Add(this.knight);
            this.characterPanel.Controls.Add(this.troll);
            this.characterPanel.Location = new System.Drawing.Point(12, 52);
            this.characterPanel.Name = "characterPanel";
            this.characterPanel.Size = new System.Drawing.Size(103, 386);
            this.characterPanel.TabIndex = 10;
            // 
            // weaponPanel
            // 
            this.weaponPanel.Controls.Add(this.Knife);
            this.weaponPanel.Controls.Add(this.bow);
            this.weaponPanel.Controls.Add(this.axe);
            this.weaponPanel.Controls.Add(this.sword);
            this.weaponPanel.Location = new System.Drawing.Point(685, 52);
            this.weaponPanel.Name = "weaponPanel";
            this.weaponPanel.Size = new System.Drawing.Size(103, 386);
            this.weaponPanel.TabIndex = 11;
            // 
            // weapons
            // 
            this.weapons.Location = new System.Drawing.Point(271, 411);
            this.weapons.Name = "weapons";
            this.weapons.Size = new System.Drawing.Size(127, 27);
            this.weapons.TabIndex = 10;
            this.weapons.Text = "Weapons";
            this.weapons.UseVisualStyleBackColor = true;
            this.weapons.Click += new System.EventHandler(this.weapons_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 342);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(404, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 342);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // characters
            // 
            this.characters.Location = new System.Drawing.Point(404, 411);
            this.characters.Name = "characters";
            this.characters.Size = new System.Drawing.Size(127, 27);
            this.characters.TabIndex = 13;
            this.characters.Text = "Characters";
            this.characters.UseVisualStyleBackColor = true;
            this.characters.Click += new System.EventHandler(this.characters_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.characters);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.weapons);
            this.Controls.Add(this.weaponPanel);
            this.Controls.Add(this.characterPanel);
            this.Name = "Form1";
            this.Text = "Action Adventure";
            this.characterPanel.ResumeLayout(false);
            this.weaponPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button king;
        private System.Windows.Forms.Button queen;
        private System.Windows.Forms.Button knight;
        private System.Windows.Forms.Button troll;
        private System.Windows.Forms.Button axe;
        private System.Windows.Forms.Button bow;
        private System.Windows.Forms.Button Knife;
        private System.Windows.Forms.Button sword;
        private System.Windows.Forms.Panel characterPanel;
        private System.Windows.Forms.Panel weaponPanel;
        private System.Windows.Forms.Button weapons;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button characters;
    }
}

