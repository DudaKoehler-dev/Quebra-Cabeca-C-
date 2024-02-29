namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnmona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(190, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Noite Estrelada";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(631, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Desenvolvimento de Sistemas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmona
            // 
            this.btnmona.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnmona.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnmona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmona.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmona.ForeColor = System.Drawing.Color.White;
            this.btnmona.Location = new System.Drawing.Point(190, 370);
            this.btnmona.Margin = new System.Windows.Forms.Padding(4);
            this.btnmona.Name = "btnmona";
            this.btnmona.Size = new System.Drawing.Size(284, 100);
            this.btnmona.TabIndex = 2;
            this.btnmona.Text = "Monalisa";
            this.btnmona.UseVisualStyleBackColor = false;
            this.btnmona.Click += new System.EventHandler(this.btnmona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 87);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quebra-Cabeça";
            // 
            // btnarte
            // 
            this.btnarte.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnarte.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnarte.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarte.ForeColor = System.Drawing.Color.White;
            this.btnarte.Location = new System.Drawing.Point(631, 370);
            this.btnarte.Margin = new System.Windows.Forms.Padding(4);
            this.btnarte.Name = "btnarte";
            this.btnarte.Size = new System.Drawing.Size(284, 100);
            this.btnarte.TabIndex = 4;
            this.btnarte.Text = "Persistência da Memória";
            this.btnarte.UseVisualStyleBackColor = false;
            this.btnarte.Click += new System.EventHandler(this.btnarte_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmona);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Quebra-Cabeça";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnmona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnarte;
    }
}