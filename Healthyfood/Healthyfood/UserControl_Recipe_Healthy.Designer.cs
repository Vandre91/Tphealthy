namespace Healthyfood
{
    partial class UserControl_Recipe_Healthy
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Le abdul",
            "belle et bien présenter"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Recipe_Healthy));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_calories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Back = new System.Windows.Forms.Button();
            this.panel_Show_Recipes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Describe = new System.Windows.Forms.RichTextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Heat = new System.Windows.Forms.Button();
            this.button_Back_Panel = new System.Windows.Forms.Button();
            this.panel_Show_Recipes.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Description,
            this.columnHeader_calories});
            this.listView1.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(4, 16);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 435);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 107;
            // 
            // columnHeader_Description
            // 
            this.columnHeader_Description.Text = "Déscription";
            this.columnHeader_Description.Width = 400;
            // 
            // columnHeader_calories
            // 
            this.columnHeader_calories.Text = "Calories";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1466380345_Circle_Green.png");
            this.imageList1.Images.SetKeyName(1, "1466380352_Circle_Red.png");
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Back.Location = new System.Drawing.Point(511, 459);
            this.button_Back.Margin = new System.Windows.Forms.Padding(4);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(123, 28);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "Retour";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // panel_Show_Recipes
            // 
            this.panel_Show_Recipes.Controls.Add(this.label1);
            this.panel_Show_Recipes.Controls.Add(this.richTextBox1);
            this.panel_Show_Recipes.Controls.Add(this.richTextBox_Describe);
            this.panel_Show_Recipes.Controls.Add(this.label_Name);
            this.panel_Show_Recipes.Controls.Add(this.button_Read);
            this.panel_Show_Recipes.Controls.Add(this.button_Heat);
            this.panel_Show_Recipes.Controls.Add(this.button_Back_Panel);
            this.panel_Show_Recipes.Location = new System.Drawing.Point(127, 50);
            this.panel_Show_Recipes.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Show_Recipes.Name = "panel_Show_Recipes";
            this.panel_Show_Recipes.Size = new System.Drawing.Size(488, 279);
            this.panel_Show_Recipes.TabIndex = 2;
            this.panel_Show_Recipes.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(271, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 34);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(201, 61);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // richTextBox_Describe
            // 
            this.richTextBox_Describe.Location = new System.Drawing.Point(40, 103);
            this.richTextBox_Describe.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_Describe.Name = "richTextBox_Describe";
            this.richTextBox_Describe.Size = new System.Drawing.Size(404, 120);
            this.richTextBox_Describe.TabIndex = 5;
            this.richTextBox_Describe.Text = "";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(36, 14);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(45, 17);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "Name";
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(196, 231);
            this.button_Read.Margin = new System.Windows.Forms.Padding(4);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(100, 28);
            this.button_Read.TabIndex = 2;
            this.button_Read.Text = "Lire";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Heat
            // 
            this.button_Heat.Location = new System.Drawing.Point(40, 231);
            this.button_Heat.Margin = new System.Windows.Forms.Padding(4);
            this.button_Heat.Name = "button_Heat";
            this.button_Heat.Size = new System.Drawing.Size(100, 28);
            this.button_Heat.TabIndex = 1;
            this.button_Heat.Text = "Manger";
            this.button_Heat.UseVisualStyleBackColor = true;
            this.button_Heat.Click += new System.EventHandler(this.button_Heat_Click);
            // 
            // button_Back_Panel
            // 
            this.button_Back_Panel.Location = new System.Drawing.Point(368, 231);
            this.button_Back_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Back_Panel.Name = "button_Back_Panel";
            this.button_Back_Panel.Size = new System.Drawing.Size(100, 28);
            this.button_Back_Panel.TabIndex = 0;
            this.button_Back_Panel.Text = "Retour";
            this.button_Back_Panel.UseVisualStyleBackColor = true;
            this.button_Back_Panel.Click += new System.EventHandler(this.button_Back_Panel_Click);
            // 
            // UserControl_Recipe_Healthy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Show_Recipes);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Recipe_Healthy";
            this.Size = new System.Drawing.Size(1015, 678);
            this.Enter += new System.EventHandler(this.UserControl_Recipe_Healthy_Enter);
            this.panel_Show_Recipes.ResumeLayout(false);
            this.panel_Show_Recipes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Description;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Panel panel_Show_Recipes;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Heat;
        private System.Windows.Forms.Button button_Back_Panel;
        private System.Windows.Forms.RichTextBox richTextBox_Describe;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_calories;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
