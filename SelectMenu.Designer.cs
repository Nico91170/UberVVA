namespace UberVVA
{
    partial class SelectionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.GBmenu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TBnameNourriture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbAffichageMenus = new System.Windows.Forms.ListBox();
            this.BTafficherMenu = new System.Windows.Forms.Button();
            this.GBmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "On vous souhaite un bon appétit d\'avance !";
            // 
            // GBmenu
            // 
            this.GBmenu.Controls.Add(this.button1);
            this.GBmenu.Controls.Add(this.textBox4);
            this.GBmenu.Controls.Add(this.textBox3);
            this.GBmenu.Controls.Add(this.textBox2);
            this.GBmenu.Controls.Add(this.TBnameNourriture);
            this.GBmenu.Controls.Add(this.label5);
            this.GBmenu.Controls.Add(this.label4);
            this.GBmenu.Controls.Add(this.label3);
            this.GBmenu.Controls.Add(this.label2);
            this.GBmenu.Location = new System.Drawing.Point(589, 95);
            this.GBmenu.Name = "GBmenu";
            this.GBmenu.Size = new System.Drawing.Size(499, 427);
            this.GBmenu.TabIndex = 1;
            this.GBmenu.TabStop = false;
            this.GBmenu.Text = "Menu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Commander";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 280);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 194);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 49);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // TBnameNourriture
            // 
            this.TBnameNourriture.Location = new System.Drawing.Point(210, 74);
            this.TBnameNourriture.Name = "TBnameNourriture";
            this.TBnameNourriture.Size = new System.Drawing.Size(100, 20);
            this.TBnameNourriture.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description de la nourriture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Type nourriture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom de la nourriture";
            // 
            // LbAffichageMenus
            // 
            this.LbAffichageMenus.FormattingEnabled = true;
            this.LbAffichageMenus.Location = new System.Drawing.Point(84, 95);
            this.LbAffichageMenus.Name = "LbAffichageMenus";
            this.LbAffichageMenus.Size = new System.Drawing.Size(338, 433);
            this.LbAffichageMenus.TabIndex = 2;
            // 
            // BTafficherMenu
            // 
            this.BTafficherMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTafficherMenu.Location = new System.Drawing.Point(140, 534);
            this.BTafficherMenu.Name = "BTafficherMenu";
            this.BTafficherMenu.Size = new System.Drawing.Size(224, 33);
            this.BTafficherMenu.TabIndex = 3;
            this.BTafficherMenu.Text = "Afficher les menus disponible";
            this.BTafficherMenu.UseVisualStyleBackColor = true;
            // 
            // SelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1178, 579);
            this.Controls.Add(this.BTafficherMenu);
            this.Controls.Add(this.LbAffichageMenus);
            this.Controls.Add(this.GBmenu);
            this.Controls.Add(this.label1);
            this.Name = "SelectionMenu";
            this.Text = "Selection des Menus";
            this.GBmenu.ResumeLayout(false);
            this.GBmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBmenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TBnameNourriture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox LbAffichageMenus;
        private System.Windows.Forms.Button BTafficherMenu;
    }
}