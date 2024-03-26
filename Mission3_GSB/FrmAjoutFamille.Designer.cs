namespace Mission3_GSB
{
    partial class FrmAjoutFamille
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBELLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(300, 170);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(193, 22);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(300, 256);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(100, 22);
            this.textBoxLibelle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label3.Location = new System.Drawing.Point(217, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ajout de Famille";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Mission3_GSB.famille);
            // 
            // FrmAjoutFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLibelle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutFamille";
            this.Text = "FrmAjoutFamille";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}