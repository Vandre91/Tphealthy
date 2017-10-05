namespace Healthyfood
{
    partial class UserControl_Reserve
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Reserve));
            this.button_Add_Remove = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.userControl_Show1 = new Healthyfood.UserControl_Show_Reserve();
            this.userControl_Reserve_Add_Remove1 = new Healthyfood.UserControl_Reserve_Add_Remove();
            this.userControl_Show_Reserve21 = new Healthyfood.UserControl_Show_Reserve2();
            this.SuspendLayout();
            // 
            // button_Add_Remove
            // 
            this.button_Add_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Add_Remove.BackgroundImage")));
            this.button_Add_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Add_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_Remove.Location = new System.Drawing.Point(216, 113);
            this.button_Add_Remove.Name = "button_Add_Remove";
            this.button_Add_Remove.Size = new System.Drawing.Size(222, 58);
            this.button_Add_Remove.TabIndex = 0;
            this.button_Add_Remove.Text = "Ajouter/Retirer";
            this.button_Add_Remove.UseVisualStyleBackColor = true;
            this.button_Add_Remove.Click += new System.EventHandler(this.button_Add_Remove_Click);
            // 
            // button_Show
            // 
            this.button_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Show.BackgroundImage")));
            this.button_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.Location = new System.Drawing.Point(216, 203);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(222, 58);
            this.button_Show.TabIndex = 1;
            this.button_Show.Text = "Visualiser";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(528, 362);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 2;
            this.button_Back.Text = "Retour";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // userControl_Show1
            // 
            this.userControl_Show1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Show1.Name = "userControl_Show1";
            this.userControl_Show1.Size = new System.Drawing.Size(249, 228);
            this.userControl_Show1.TabIndex = 4;
            this.userControl_Show1.Visible = false;
            // 
            // userControl_Reserve_Add_Remove1
            // 
            this.userControl_Reserve_Add_Remove1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Reserve_Add_Remove1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Reserve_Add_Remove1.Name = "userControl_Reserve_Add_Remove1";
            this.userControl_Reserve_Add_Remove1.Size = new System.Drawing.Size(647, 406);
            this.userControl_Reserve_Add_Remove1.TabIndex = 3;
            this.userControl_Reserve_Add_Remove1.Visible = false;
            // 
            // userControl_Show_Reserve21
            // 
            this.userControl_Show_Reserve21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Show_Reserve21.Location = new System.Drawing.Point(0, 0);
            this.userControl_Show_Reserve21.Name = "userControl_Show_Reserve21";
            this.userControl_Show_Reserve21.Size = new System.Drawing.Size(647, 406);
            this.userControl_Show_Reserve21.TabIndex = 5;
            this.userControl_Show_Reserve21.Visible = false;
            // 
            // UserControl_Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.userControl_Show_Reserve21);
            this.Controls.Add(this.userControl_Show1);
            this.Controls.Add(this.userControl_Reserve_Add_Remove1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.button_Add_Remove);
            this.Name = "UserControl_Reserve";
            this.Size = new System.Drawing.Size(647, 406);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add_Remove;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Back;
        private UserControl_Reserve_Add_Remove userControl_Reserve_Add_Remove1;
        private UserControl_Show_Reserve userControl_Show1;
        private UserControl_Show_Reserve2 userControl_Show_Reserve21;
    }
}
