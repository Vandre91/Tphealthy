namespace Healthyfood
{
    partial class UserControl_RecipeExpiration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_RecipeExpiration));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Show_Recipes = new System.Windows.Forms.Panel();
            this.button_Back_Panel = new System.Windows.Forms.Button();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Heat = new System.Windows.Forms.Button();
            this.richTextBox_Describe = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_Show_Recipes.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(880, 554);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Enter += new System.EventHandler(this.listView1_Enter);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Calories";
            this.columnHeader3.Width = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(892, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_Show_Recipes
            // 
            this.panel_Show_Recipes.Controls.Add(this.button_Back_Panel);
            this.panel_Show_Recipes.Controls.Add(this.button_Read);
            this.panel_Show_Recipes.Controls.Add(this.button_Heat);
            this.panel_Show_Recipes.Controls.Add(this.richTextBox_Describe);
            this.panel_Show_Recipes.Controls.Add(this.richTextBox1);
            this.panel_Show_Recipes.Controls.Add(this.label_Name);
            this.panel_Show_Recipes.Location = new System.Drawing.Point(144, 190);
            this.panel_Show_Recipes.Name = "panel_Show_Recipes";
            this.panel_Show_Recipes.Size = new System.Drawing.Size(488, 279);
            this.panel_Show_Recipes.TabIndex = 2;
            // 
            // button_Back_Panel
            // 
            this.button_Back_Panel.Location = new System.Drawing.Point(299, 235);
            this.button_Back_Panel.Name = "button_Back_Panel";
            this.button_Back_Panel.Size = new System.Drawing.Size(75, 23);
            this.button_Back_Panel.TabIndex = 5;
            this.button_Back_Panel.Text = "Retour";
            this.button_Back_Panel.UseVisualStyleBackColor = true;
            this.button_Back_Panel.Click += new System.EventHandler(this.button_Back_Panel_Click);
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(175, 235);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(75, 23);
            this.button_Read.TabIndex = 4;
            this.button_Read.Text = "Lire";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Heat
            // 
            this.button_Heat.Location = new System.Drawing.Point(39, 235);
            this.button_Heat.Name = "button_Heat";
            this.button_Heat.Size = new System.Drawing.Size(75, 23);
            this.button_Heat.TabIndex = 3;
            this.button_Heat.Text = "Manger";
            this.button_Heat.UseVisualStyleBackColor = true;
            this.button_Heat.Click += new System.EventHandler(this.button_Heat_Click);
            // 
            // richTextBox_Describe
            // 
            this.richTextBox_Describe.Location = new System.Drawing.Point(39, 97);
            this.richTextBox_Describe.Name = "richTextBox_Describe";
            this.richTextBox_Describe.Size = new System.Drawing.Size(404, 120);
            this.richTextBox_Describe.TabIndex = 2;
            this.richTextBox_Describe.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(201, 61);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(36, 10);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(46, 17);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1466380345_Circle_Green.png");
            this.imageList1.Images.SetKeyName(1, "1466380352_Circle_Red.png");
            // 
            // UserControl_RecipeExpiration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Healthyfood.Properties.Resources.backshowprofil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel_Show_Recipes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "UserControl_RecipeExpiration";
            this.Size = new System.Drawing.Size(1015, 678);
            this.panel_Show_Recipes.ResumeLayout(false);
            this.panel_Show_Recipes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_Show_Recipes;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox_Describe;
        private System.Windows.Forms.Button button_Back_Panel;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Heat;
        private System.Windows.Forms.ImageList imageList1;
    }
}
