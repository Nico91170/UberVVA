namespace UberVVA
{
    partial class FromajtMenu
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
            this.labelTitlegm = new System.Windows.Forms.Label();
            this.labelNameNourriture = new System.Windows.Forms.Label();
            this.labelTypeNourriture = new System.Windows.Forms.Label();
            this.labelDescrNourriture = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTvalidergm = new System.Windows.Forms.Button();
            this.linkLbackmenus = new System.Windows.Forms.LinkLabel();
            this.TBnameAM = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitlegm
            // 
            this.labelTitlegm.AutoSize = true;
            this.labelTitlegm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlegm.Location = new System.Drawing.Point(421, 9);
            this.labelTitlegm.Name = "labelTitlegm";
            this.labelTitlegm.Size = new System.Drawing.Size(372, 31);
            this.labelTitlegm.TabIndex = 0;
            this.labelTitlegm.Text = "Veuillez ajouter les Menus !";
            // 
            // labelNameNourriture
            // 
            this.labelNameNourriture.AutoSize = true;
            this.labelNameNourriture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameNourriture.Location = new System.Drawing.Point(83, 82);
            this.labelNameNourriture.Name = "labelNameNourriture";
            this.labelNameNourriture.Size = new System.Drawing.Size(133, 16);
            this.labelNameNourriture.TabIndex = 1;
            this.labelNameNourriture.Text = "Nom de Nourriture";
            // 
            // labelTypeNourriture
            // 
            this.labelTypeNourriture.AutoSize = true;
            this.labelTypeNourriture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeNourriture.Location = new System.Drawing.Point(83, 158);
            this.labelTypeNourriture.Name = "labelTypeNourriture";
            this.labelTypeNourriture.Size = new System.Drawing.Size(137, 16);
            this.labelTypeNourriture.TabIndex = 2;
            this.labelTypeNourriture.Text = "Type de Nourriture";
            // 
            // labelDescrNourriture
            // 
            this.labelDescrNourriture.AutoSize = true;
            this.labelDescrNourriture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrNourriture.Location = new System.Drawing.Point(83, 370);
            this.labelDescrNourriture.Name = "labelDescrNourriture";
            this.labelDescrNourriture.Size = new System.Drawing.Size(180, 16);
            this.labelDescrNourriture.TabIndex = 3;
            this.labelDescrNourriture.Text = "Description de Nourriture";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Entrée",
            "Plat",
            "Dessert"});
            this.comboBox1.Location = new System.Drawing.Point(368, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 338);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 77);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BTvalidergm
            // 
            this.BTvalidergm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTvalidergm.Location = new System.Drawing.Point(368, 456);
            this.BTvalidergm.Name = "BTvalidergm";
            this.BTvalidergm.Size = new System.Drawing.Size(164, 58);
            this.BTvalidergm.TabIndex = 12;
            this.BTvalidergm.Text = "Valider";
            this.BTvalidergm.UseVisualStyleBackColor = true;
            this.BTvalidergm.Click += new System.EventHandler(this.BTvalidergm_Click);
            // 
            // linkLbackmenus
            // 
            this.linkLbackmenus.AutoSize = true;
            this.linkLbackmenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbackmenus.Location = new System.Drawing.Point(1005, 546);
            this.linkLbackmenus.Name = "linkLbackmenus";
            this.linkLbackmenus.Size = new System.Drawing.Size(195, 16);
            this.linkLbackmenus.TabIndex = 13;
            this.linkLbackmenus.TabStop = true;
            this.linkLbackmenus.Text = "Retourner à la page des Menus";
            this.linkLbackmenus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbackmenus_LinkClicked);
            // 
            // TBnameAM
            // 
            this.TBnameAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnameAM.Location = new System.Drawing.Point(368, 82);
            this.TBnameAM.Name = "TBnameAM";
            this.TBnameAM.Size = new System.Drawing.Size(143, 24);
            this.TBnameAM.TabIndex = 14;
            this.TBnameAM.TextChanged += new System.EventHandler(this.TBnameAM_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(368, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 24);
            this.textBox3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prix en €";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(594, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FromajtMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBnameAM);
            this.Controls.Add(this.linkLbackmenus);
            this.Controls.Add(this.BTvalidergm);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDescrNourriture);
            this.Controls.Add(this.labelTypeNourriture);
            this.Controls.Add(this.labelNameNourriture);
            this.Controls.Add(this.labelTitlegm);
            this.Name = "FromajtMenu";
            this.Text = "Ajouter un Menu";
            this.Load += new System.EventHandler(this.Fromgm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlegm;
        private System.Windows.Forms.Label labelNameNourriture;
        private System.Windows.Forms.Label labelTypeNourriture;
        private System.Windows.Forms.Label labelDescrNourriture;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTvalidergm;
        private System.Windows.Forms.LinkLabel linkLbackmenus;
        private System.Windows.Forms.TextBox TBnameAM;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}