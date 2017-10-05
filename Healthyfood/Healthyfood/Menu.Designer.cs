namespace Healthyfood
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_Provisions = new System.Windows.Forms.Button();
            this.button_Recette = new System.Windows.Forms.Button();
            this.button_Utilisateur = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saugarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl_Menu1 = new Healthyfood.UserControl_Menu();
            this.userControl_Recipe1 = new Healthyfood.UserControl_Recipe();
            this.userControl_Reserve_Add_Remove1 = new Healthyfood.UserControl_Reserve_Add_Remove();
            this.userControl_Show_Reserve21 = new Healthyfood.UserControl_Show_Reserve2();
            this.userControl_Profil1 = new Healthyfood.UserControl_Profil();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Provisions
            // 
            this.button_Provisions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Provisions.BackgroundImage = global::Healthyfood.Properties.Resources.fridge;
            this.button_Provisions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Provisions.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Provisions.Location = new System.Drawing.Point(354, 329);
            this.button_Provisions.Name = "button_Provisions";
            this.button_Provisions.Size = new System.Drawing.Size(112, 92);
            this.button_Provisions.TabIndex = 1;
            this.button_Provisions.Text = "Visualiser";
            this.button_Provisions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Provisions.UseVisualStyleBackColor = true;
            this.button_Provisions.Click += new System.EventHandler(this.button_Provisions_Click);
            // 
            // button_Recette
            // 
            this.button_Recette.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Recette.BackgroundImage = global::Healthyfood.Properties.Resources.food1;
            this.button_Recette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Recette.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Recette.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Recette.Location = new System.Drawing.Point(354, 231);
            this.button_Recette.Name = "button_Recette";
            this.button_Recette.Size = new System.Drawing.Size(232, 92);
            this.button_Recette.TabIndex = 2;
            this.button_Recette.Text = "Recettes";
            this.button_Recette.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Recette.UseVisualStyleBackColor = true;
            this.button_Recette.Click += new System.EventHandler(this.button_Recette_Click);
            // 
            // button_Utilisateur
            // 
            this.button_Utilisateur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Utilisateur.BackColor = System.Drawing.Color.Transparent;
            this.button_Utilisateur.BackgroundImage = global::Healthyfood.Properties.Resources.users1;
            this.button_Utilisateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Utilisateur.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Utilisateur.Location = new System.Drawing.Point(236, 231);
            this.button_Utilisateur.Name = "button_Utilisateur";
            this.button_Utilisateur.Size = new System.Drawing.Size(112, 92);
            this.button_Utilisateur.TabIndex = 0;
            this.button_Utilisateur.Text = "Utilisateurs";
            this.button_Utilisateur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Utilisateur.UseVisualStyleBackColor = false;
            this.button_Utilisateur.Click += new System.EventHandler(this.button_Utilisateur_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saugarderToolStripMenuItem,
            this.chargerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // saugarderToolStripMenuItem
            // 
            this.saugarderToolStripMenuItem.Name = "saugarderToolStripMenuItem";
            this.saugarderToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saugarderToolStripMenuItem.Text = "Saugarder";
            this.saugarderToolStripMenuItem.Click += new System.EventHandler(this.saugarderToolStripMenuItem_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = global::Healthyfood.Properties.Resources.liste;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 92);
            this.button1.TabIndex = 7;
            this.button1.Text = "Menu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackgroundImage = global::Healthyfood.Properties.Resources.add;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(236, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 92);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ajouter";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl_Menu1
            // 
            this.userControl_Menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Menu1.Location = new System.Drawing.Point(0, 24);
            this.userControl_Menu1.Name = "userControl_Menu1";
            this.userControl_Menu1.Size = new System.Drawing.Size(761, 550);
            this.userControl_Menu1.TabIndex = 13;
            this.userControl_Menu1.Visible = false;
            // 
            // userControl_Recipe1
            // 
            this.userControl_Recipe1.BackgroundImage = global::Healthyfood.Properties.Resources.cuisine;
            this.userControl_Recipe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl_Recipe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Recipe1.Location = new System.Drawing.Point(0, 24);
            this.userControl_Recipe1.Name = "userControl_Recipe1";
            this.userControl_Recipe1.Size = new System.Drawing.Size(761, 550);
            this.userControl_Recipe1.TabIndex = 12;
            // 
            // userControl_Reserve_Add_Remove1
            // 
            this.userControl_Reserve_Add_Remove1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Reserve_Add_Remove1.Location = new System.Drawing.Point(0, 24);
            this.userControl_Reserve_Add_Remove1.Name = "userControl_Reserve_Add_Remove1";
            this.userControl_Reserve_Add_Remove1.Size = new System.Drawing.Size(761, 550);
            this.userControl_Reserve_Add_Remove1.TabIndex = 11;
            // 
            // userControl_Show_Reserve21
            // 
            this.userControl_Show_Reserve21.BackColor = System.Drawing.Color.White;
            this.userControl_Show_Reserve21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Show_Reserve21.Location = new System.Drawing.Point(0, 24);
            this.userControl_Show_Reserve21.Name = "userControl_Show_Reserve21";
            this.userControl_Show_Reserve21.Size = new System.Drawing.Size(761, 550);
            this.userControl_Show_Reserve21.TabIndex = 10;
            // 
            // userControl_Profil1
            // 
            this.userControl_Profil1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_Profil1.BackgroundImage")));
            this.userControl_Profil1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl_Profil1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Profil1.Location = new System.Drawing.Point(0, 24);
            this.userControl_Profil1.Name = "userControl_Profil1";
            this.userControl_Profil1.Size = new System.Drawing.Size(761, 550);
            this.userControl_Profil1.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Healthyfood.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 574);
            this.Controls.Add(this.userControl_Menu1);
            this.Controls.Add(this.userControl_Recipe1);
            this.Controls.Add(this.userControl_Reserve_Add_Remove1);
            this.Controls.Add(this.userControl_Show_Reserve21);
            this.Controls.Add(this.userControl_Profil1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Recette);
            this.Controls.Add(this.button_Provisions);
            this.Controls.Add(this.button_Utilisateur);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Utilisateur;
        private System.Windows.Forms.Button button_Provisions;
        private System.Windows.Forms.Button button_Recette;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saugarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControl_Profil userControl_Profil1;
        private UserControl_Show_Reserve2 userControl_Show_Reserve21;
        private UserControl_Reserve_Add_Remove userControl_Reserve_Add_Remove1;
        private UserControl_Recipe userControl_Recipe1;
        private UserControl_Menu userControl_Menu1;
    }
}

