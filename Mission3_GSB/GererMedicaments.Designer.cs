namespace Mission3_GSB
{
    partial class GererMedicaments
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Mission3_GSB.famille);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label2.Location = new System.Drawing.Point(287, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste de Familles";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(180, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Liste Medicaments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ajouter une famille";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSource1;
            this.comboBox1.DisplayMember = "id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(180, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Liste des medicaments offerts";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // GererMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 403);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "GererMedicaments";
            this.Text = "GererMedicaments";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
    }
}