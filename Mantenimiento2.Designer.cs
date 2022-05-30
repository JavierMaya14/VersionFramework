namespace VersionFramework
{
    partial class Mantenimiento2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento2));
            this.correctivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet9 = new VersionFramework.HospitalDataSet9();
            this.correctivosTableAdapter = new VersionFramework.HospitalDataSet9TableAdapters.CorrectivosTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.últimomtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.próximomtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSPreventivoDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet19 = new VersionFramework.HospitalDataSet19();
            this.hospitalDataSet18 = new VersionFramework.HospitalDataSet18();
            this.hospitalDataSet18BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correctivosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.correctivosTableAdapter1 = new VersionFramework.HospitalDataSet18TableAdapters.CorrectivosTableAdapter();
            this.pSPreventivo_DataTableAdapter = new VersionFramework.HospitalDataSet19TableAdapters.PSPreventivo_DataTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.correctivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSPreventivoDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet18BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctivosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // correctivosBindingSource
            // 
            this.correctivosBindingSource.DataMember = "Correctivos";
            this.correctivosBindingSource.DataSource = this.hospitalDataSet9;
            // 
            // hospitalDataSet9
            // 
            this.hospitalDataSet9.DataSetName = "HospitalDataSet9";
            this.hospitalDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // correctivosTableAdapter
            // 
            this.correctivosTableAdapter.ClearBeforeFill = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AllowUserToResizeColumns = false;
            this.advancedDataGridView1.AllowUserToResizeRows = false;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.noSerieDataGridViewTextBoxColumn,
            this.últimomtoDataGridViewTextBoxColumn,
            this.próximomtoDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.pSPreventivoDataBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.advancedDataGridView1.Location = new System.Drawing.Point(7, 53);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.advancedDataGridView1.Size = new System.Drawing.Size(818, 607);
            this.advancedDataGridView1.TabIndex = 4;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // noSerieDataGridViewTextBoxColumn
            // 
            this.noSerieDataGridViewTextBoxColumn.DataPropertyName = "No_Serie";
            this.noSerieDataGridViewTextBoxColumn.HeaderText = "No_Serie";
            this.noSerieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.noSerieDataGridViewTextBoxColumn.Name = "noSerieDataGridViewTextBoxColumn";
            this.noSerieDataGridViewTextBoxColumn.ReadOnly = true;
            this.noSerieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // últimomtoDataGridViewTextBoxColumn
            // 
            this.últimomtoDataGridViewTextBoxColumn.DataPropertyName = "Último_mto";
            this.últimomtoDataGridViewTextBoxColumn.HeaderText = "Último_mto";
            this.últimomtoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.últimomtoDataGridViewTextBoxColumn.Name = "últimomtoDataGridViewTextBoxColumn";
            this.últimomtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.últimomtoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // próximomtoDataGridViewTextBoxColumn
            // 
            this.próximomtoDataGridViewTextBoxColumn.DataPropertyName = "Próximo_mto";
            this.próximomtoDataGridViewTextBoxColumn.HeaderText = "Próximo_mto";
            this.próximomtoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.próximomtoDataGridViewTextBoxColumn.Name = "próximomtoDataGridViewTextBoxColumn";
            this.próximomtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.próximomtoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pSPreventivoDataBindingSource
            // 
            this.pSPreventivoDataBindingSource.DataMember = "PSPreventivo_Data";
            this.pSPreventivoDataBindingSource.DataSource = this.hospitalDataSet19;
            // 
            // hospitalDataSet19
            // 
            this.hospitalDataSet19.DataSetName = "HospitalDataSet19";
            this.hospitalDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDataSet18
            // 
            this.hospitalDataSet18.DataSetName = "HospitalDataSet18";
            this.hospitalDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDataSet18BindingSource
            // 
            this.hospitalDataSet18BindingSource.DataSource = this.hospitalDataSet18;
            this.hospitalDataSet18BindingSource.Position = 0;
            // 
            // correctivosBindingSource1
            // 
            this.correctivosBindingSource1.DataMember = "Correctivos";
            this.correctivosBindingSource1.DataSource = this.hospitalDataSet18BindingSource;
            // 
            // correctivosTableAdapter1
            // 
            this.correctivosTableAdapter1.ClearBeforeFill = true;
            // 
            // pSPreventivo_DataTableAdapter
            // 
            this.pSPreventivo_DataTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 41);
            this.label1.TabIndex = 94;
            this.label1.Text = "Agenda de Preventivos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mantenimiento2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenimiento2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CorrectivoPSalud";
            this.Load += new System.EventHandler(this.Mantenimiento2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.correctivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSPreventivoDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet18BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctivosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HospitalDataSet9 hospitalDataSet9;
        private System.Windows.Forms.BindingSource correctivosBindingSource;
        private HospitalDataSet9TableAdapters.CorrectivosTableAdapter correctivosTableAdapter;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.BindingSource hospitalDataSet18BindingSource;
        private HospitalDataSet18 hospitalDataSet18;
        private System.Windows.Forms.BindingSource correctivosBindingSource1;
        private HospitalDataSet18TableAdapters.CorrectivosTableAdapter correctivosTableAdapter1;
        private HospitalDataSet19 hospitalDataSet19;
        private System.Windows.Forms.BindingSource pSPreventivoDataBindingSource;
        private HospitalDataSet19TableAdapters.PSPreventivo_DataTableAdapter pSPreventivo_DataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn últimomtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn próximomtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}