namespace UberVVA
{
    partial class Formgm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CBtypeN = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btvalidergm = new System.Windows.Forms.Button();
            this.btAnnulergm = new System.Windows.Forms.Button();
            this.labelImg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez bien vouloir gérer les menus !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de le Nourriture";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type de nourriture";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(271, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CBtypeN
            // 
            this.CBtypeN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtypeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtypeN.FormattingEnabled = true;
            this.CBtypeN.Items.AddRange(new object[] {
            "Entrée",
            "Plat",
            "Dessert"});
            this.CBtypeN.Location = new System.Drawing.Point(271, 184);
            this.CBtypeN.Name = "CBtypeN";
            this.CBtypeN.Size = new System.Drawing.Size(181, 28);
            this.CBtypeN.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(271, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Btvalidergm
            // 
            this.Btvalidergm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btvalidergm.Location = new System.Drawing.Point(682, 213);
            this.Btvalidergm.Name = "Btvalidergm";
            this.Btvalidergm.Size = new System.Drawing.Size(99, 38);
            this.Btvalidergm.TabIndex = 8;
            this.Btvalidergm.Text = "Valider";
            this.Btvalidergm.UseVisualStyleBackColor = true;
            // 
            // btAnnulergm
            // 
            this.btAnnulergm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnulergm.Location = new System.Drawing.Point(872, 213);
            this.btAnnulergm.Name = "btAnnulergm";
            this.btAnnulergm.Size = new System.Drawing.Size(99, 38);
            this.btAnnulergm.TabIndex = 9;
            this.btAnnulergm.Text = "Annuler";
            this.btAnnulergm.UseVisualStyleBackColor = true;
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImg.Location = new System.Drawing.Point(33, 464);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(59, 20);
            this.labelImg.TabIndex = 10;
            this.labelImg.Text = "Image";
            // 
            // Formgm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 565);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.btAnnulergm);
            this.Controls.Add(this.Btvalidergm);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CBtypeN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formgm";
            this.Text = "Gestion des menus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CBtypeN;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btvalidergm;
        private System.Windows.Forms.Button btAnnulergm;
        private System.Windows.Forms.Label labelImg;
    }
}