namespace VersionFramework
{
    partial class ManualesChequeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualesChequeo));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnManuales = new System.Windows.Forms.Button();
            this.axAcroPDF2 = new AxAcroPDFLib.AxAcroPDF();
            this.tablaRevision = new System.Windows.Forms.CheckedListBox();
            this.fechaHoy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRevision = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.hospitalDataSet26 = new VersionFramework.HospitalDataSet26();
            this.revisionDiariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revisionDiariaTableAdapter = new VersionFramework.HospitalDataSet26TableAdapters.RevisionDiariaTableAdapter();
            this.revisionD = new System.Windows.Forms.DataGridView();
            this.nombredelEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDiariaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet27 = new VersionFramework.HospitalDataSet27();
            this.revisionDiariaTableAdapter1 = new VersionFramework.HospitalDataSet27TableAdapters.RevisionDiariaTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisionDiariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisionD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisionDiariaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet27)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1115, 41);
            this.label1.TabIndex = 95;
            this.label1.Text = "Checklist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // btnManuales
            // 
            this.btnManuales.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManuales.Location = new System.Drawing.Point(28, 74);
            this.btnManuales.Name = "btnManuales";
            this.btnManuales.Size = new System.Drawing.Size(207, 43);
            this.btnManuales.TabIndex = 97;
            this.btnManuales.Text = "Consultar manuales";
            this.btnManuales.UseVisualStyleBackColor = true;
            this.btnManuales.Click += new System.EventHandler(this.btnManuales_Click);
            // 
            // axAcroPDF2
            // 
            this.axAcroPDF2.Enabled = true;
            this.axAcroPDF2.Location = new System.Drawing.Point(28, 133);
            this.axAcroPDF2.Name = "axAcroPDF2";
            this.axAcroPDF2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF2.OcxState")));
            this.axAcroPDF2.Size = new System.Drawing.Size(755, 588);
            this.axAcroPDF2.TabIndex = 98;
            // 
            // tablaRevision
            // 
            this.tablaRevision.BackColor = System.Drawing.Color.White;
            this.tablaRevision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaRevision.CheckOnClick = true;
            this.tablaRevision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaRevision.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaRevision.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tablaRevision.FormattingEnabled = true;
            this.tablaRevision.Location = new System.Drawing.Point(800, 231);
            this.tablaRevision.Name = "tablaRevision";
            this.tablaRevision.Size = new System.Drawing.Size(249, 144);
            this.tablaRevision.Sorted = true;
            this.tablaRevision.TabIndex = 99;
            // 
            // fechaHoy
            // 
            this.fechaHoy.BackColor = System.Drawing.Color.White;
            this.fechaHoy.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaHoy.Location = new System.Drawing.Point(802, 194);
            this.fechaHoy.Name = "fechaHoy";
            this.fechaHoy.Size = new System.Drawing.Size(247, 36);
            this.fechaHoy.TabIndex = 101;
            this.fechaHoy.Text = "label2";
            this.fechaHoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fechaHoy.Click += new System.EventHandler(this.fechaHoy_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(802, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 36);
            this.label2.TabIndex = 102;
            this.label2.Text = "Revisión día:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(835, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 103;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRevision
            // 
            this.txtRevision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevision.Location = new System.Drawing.Point(808, 503);
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.Size = new System.Drawing.Size(235, 26);
            this.txtRevision.TabIndex = 104;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(876, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 105;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hospitalDataSet26
            // 
            this.hospitalDataSet26.DataSetName = "HospitalDataSet26";
            this.hospitalDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revisionDiariaBindingSource
            // 
            this.revisionDiariaBindingSource.DataMember = "RevisionDiaria";
            this.revisionDiariaBindingSource.DataSource = this.hospitalDataSet26;
            // 
            // revisionDiariaTableAdapter
            // 
            this.revisionDiariaTableAdapter.ClearBeforeFill = true;
            // 
            // revisionD
            // 
            this.revisionD.AllowUserToAddRows = false;
            this.revisionD.AllowUserToDeleteRows = false;
            this.revisionD.AllowUserToResizeColumns = false;
            this.revisionD.AllowUserToResizeRows = false;
            this.revisionD.AutoGenerateColumns = false;
            this.revisionD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.revisionD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revisionD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredelEquipoDataGridViewTextBoxColumn});
            this.revisionD.DataSource = this.revisionDiariaBindingSource1;
            this.revisionD.Location = new System.Drawing.Point(588, 455);
            this.revisionD.Name = "revisionD";
            this.revisionD.Size = new System.Drawing.Size(92, 100);
            this.revisionD.TabIndex = 106;
            // 
            // nombredelEquipoDataGridViewTextBoxColumn
            // 
            this.nombredelEquipoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_del_Equipo";
            this.nombredelEquipoDataGridViewTextBoxColumn.HeaderText = "Nombre_del_Equipo";
            this.nombredelEquipoDataGridViewTextBoxColumn.Name = "nombredelEquipoDataGridViewTextBoxColumn";
            // 
            // revisionDiariaBindingSource1
            // 
            this.revisionDiariaBindingSource1.DataMember = "RevisionDiaria";
            this.revisionDiariaBindingSource1.DataSource = this.hospitalDataSet27;
            // 
            // hospitalDataSet27
            // 
            this.hospitalDataSet27.DataSetName = "HospitalDataSet27";
            this.hospitalDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revisionDiariaTableAdapter1
            // 
            this.revisionDiariaTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(877, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 34);
            this.button3.TabIndex = 107;
            this.button3.Text = "Cargar pendientes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(802, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 63);
            this.label3.TabIndex = 108;
            this.label3.Text = "Agregar equipo";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(927, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 27);
            this.button4.TabIndex = 109;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ManualesChequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 733);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtRevision);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaHoy);
            this.Controls.Add(this.tablaRevision);
            this.Controls.Add(this.btnManuales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axAcroPDF2);
            this.Controls.Add(this.revisionD);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManualesChequeo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManualesChequeo";
            this.Load += new System.EventHandler(this.ManualesChequeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisionDiariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisionD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisionDiariaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet27)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnManuales;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private System.Windows.Forms.CheckedListBox tablaRevision;
        private System.Windows.Forms.Label fechaHoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRevision;
        private System.Windows.Forms.Button button2;
        private HospitalDataSet26 hospitalDataSet26;
        private System.Windows.Forms.BindingSource revisionDiariaBindingSource;
        private HospitalDataSet26TableAdapters.RevisionDiariaTableAdapter revisionDiariaTableAdapter;
        private System.Windows.Forms.DataGridView revisionD;
        private HospitalDataSet27 hospitalDataSet27;
        private System.Windows.Forms.BindingSource revisionDiariaBindingSource1;
        private HospitalDataSet27TableAdapters.RevisionDiariaTableAdapter revisionDiariaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}