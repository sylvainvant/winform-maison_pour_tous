namespace maison_pour_tous
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adherentBox = new System.Windows.Forms.ComboBox();
            this.repreBox = new System.Windows.Forms.ComboBox();
            this.nbBox = new System.Windows.Forms.TextBox();
            this.totoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 404);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adherentBox
            // 
            this.adherentBox.FormattingEnabled = true;
            this.adherentBox.Location = new System.Drawing.Point(429, 44);
            this.adherentBox.Margin = new System.Windows.Forms.Padding(4);
            this.adherentBox.Name = "adherentBox";
            this.adherentBox.Size = new System.Drawing.Size(479, 24);
            this.adherentBox.TabIndex = 2;
            // 
            // repreBox
            // 
            this.repreBox.FormattingEnabled = true;
            this.repreBox.Location = new System.Drawing.Point(429, 119);
            this.repreBox.Margin = new System.Windows.Forms.Padding(4);
            this.repreBox.Name = "repreBox";
            this.repreBox.Size = new System.Drawing.Size(479, 24);
            this.repreBox.TabIndex = 3;
            this.repreBox.SelectedIndexChanged += new System.EventHandler(this.repreBox_SelectedIndexChanged);
            // 
            // nbBox
            // 
            this.nbBox.Location = new System.Drawing.Point(429, 185);
            this.nbBox.Margin = new System.Windows.Forms.Padding(4);
            this.nbBox.Name = "nbBox";
            this.nbBox.Size = new System.Drawing.Size(320, 23);
            this.nbBox.TabIndex = 4;
            this.nbBox.Text = "1";
            this.nbBox.TextChanged += new System.EventHandler(this.nbBox_TextChanged);
            // 
            // totoBox
            // 
            this.totoBox.Enabled = false;
            this.totoBox.Location = new System.Drawing.Point(429, 257);
            this.totoBox.Margin = new System.Windows.Forms.Padding(4);
            this.totoBox.Name = "totoBox";
            this.totoBox.Size = new System.Drawing.Size(320, 23);
            this.totoBox.TabIndex = 5;
            this.totoBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adhérent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Représentation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de personnes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totoBox);
            this.Controls.Add(this.nbBox);
            this.Controls.Add(this.repreBox);
            this.Controls.Add(this.adherentBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox adherentBox;
        private System.Windows.Forms.ComboBox repreBox;
        private System.Windows.Forms.TextBox nbBox;
        private System.Windows.Forms.TextBox totoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

