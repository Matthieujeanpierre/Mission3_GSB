namespace Mission3_GSB
{
    partial class FrmListeMedicaments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valider = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListeMedicamentsOffert = new System.Windows.Forms.DataGridView();
            this.idRapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BdgOffert = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeMedicamentsOffert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdgOffert)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Column1,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamilleDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn,
            this.familleDataGridViewTextBoxColumn,
            this.offrirDataGridViewTextBoxColumn,
            this.valider});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            this.nomCommercialDataGridViewTextBoxColumn.Width = 125;
            // 
            // idFamilleDataGridViewTextBoxColumn
            // 
            this.idFamilleDataGridViewTextBoxColumn.DataPropertyName = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.HeaderText = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idFamilleDataGridViewTextBoxColumn.Name = "idFamilleDataGridViewTextBoxColumn";
            this.idFamilleDataGridViewTextBoxColumn.Width = 125;
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "composition";
            this.compositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            this.compositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "effets";
            this.effetsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            this.effetsDataGridViewTextBoxColumn.Width = 125;
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            this.contreIndicationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // familleDataGridViewTextBoxColumn
            // 
            this.familleDataGridViewTextBoxColumn.DataPropertyName = "famille";
            this.familleDataGridViewTextBoxColumn.HeaderText = "famille";
            this.familleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familleDataGridViewTextBoxColumn.Name = "familleDataGridViewTextBoxColumn";
            this.familleDataGridViewTextBoxColumn.Width = 125;
            // 
            // offrirDataGridViewTextBoxColumn
            // 
            this.offrirDataGridViewTextBoxColumn.DataPropertyName = "offrir";
            this.offrirDataGridViewTextBoxColumn.HeaderText = "offrir";
            this.offrirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offrirDataGridViewTextBoxColumn.Name = "offrirDataGridViewTextBoxColumn";
            this.offrirDataGridViewTextBoxColumn.Width = 125;
            // 
            // valider
            // 
            this.valider.HeaderText = "Confirmation";
            this.valider.MinimumWidth = 6;
            this.valider.Name = "valider";
            this.valider.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Mission3_GSB.medicament);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "SaveButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(335, 452);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(178, 78);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "DeleteButton";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste de medicaments ";
            // 
            // ListeMedicamentsOffert
            // 
            this.ListeMedicamentsOffert.AutoGenerateColumns = false;
            this.ListeMedicamentsOffert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeMedicamentsOffert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRapportDataGridViewTextBoxColumn,
            this.idMedicamentDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.medicamentDataGridViewTextBoxColumn,
            this.rapportDataGridViewTextBoxColumn});
            this.ListeMedicamentsOffert.DataSource = this.BdgOffert;
            this.ListeMedicamentsOffert.Location = new System.Drawing.Point(736, 71);
            this.ListeMedicamentsOffert.Name = "ListeMedicamentsOffert";
            this.ListeMedicamentsOffert.RowHeadersWidth = 51;
            this.ListeMedicamentsOffert.RowTemplate.Height = 24;
            this.ListeMedicamentsOffert.Size = new System.Drawing.Size(574, 298);
            this.ListeMedicamentsOffert.TabIndex = 4;
            // 
            // idRapportDataGridViewTextBoxColumn
            // 
            this.idRapportDataGridViewTextBoxColumn.DataPropertyName = "idRapport";
            this.idRapportDataGridViewTextBoxColumn.HeaderText = "idRapport";
            this.idRapportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRapportDataGridViewTextBoxColumn.Name = "idRapportDataGridViewTextBoxColumn";
            this.idRapportDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMedicamentDataGridViewTextBoxColumn
            // 
            this.idMedicamentDataGridViewTextBoxColumn.DataPropertyName = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.HeaderText = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMedicamentDataGridViewTextBoxColumn.Name = "idMedicamentDataGridViewTextBoxColumn";
            this.idMedicamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "quantite";
            this.quantiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicamentDataGridViewTextBoxColumn
            // 
            this.medicamentDataGridViewTextBoxColumn.DataPropertyName = "medicament";
            this.medicamentDataGridViewTextBoxColumn.HeaderText = "medicament";
            this.medicamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicamentDataGridViewTextBoxColumn.Name = "medicamentDataGridViewTextBoxColumn";
            this.medicamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // rapportDataGridViewTextBoxColumn
            // 
            this.rapportDataGridViewTextBoxColumn.DataPropertyName = "rapport";
            this.rapportDataGridViewTextBoxColumn.HeaderText = "rapport";
            this.rapportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rapportDataGridViewTextBoxColumn.Name = "rapportDataGridViewTextBoxColumn";
            this.rapportDataGridViewTextBoxColumn.Width = 125;
            // 
            // BdgOffert
            // 
            this.BdgOffert.DataSource = typeof(Mission3_GSB.offrir);
            this.BdgOffert.CurrentChanged += new System.EventHandler(this.BdgOffert_CurrentChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(886, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste medicaments offerts";
            // 
            // FrmListeMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 707);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListeMedicamentsOffert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListeMedicaments";
            this.Text = "Liste des medicaments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeMedicamentsOffert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdgOffert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn valider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListeMedicamentsOffert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource BdgOffert;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRapportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rapportDataGridViewTextBoxColumn;
    }
}