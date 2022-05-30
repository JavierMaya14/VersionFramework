namespace VersionFramework
{
    partial class Capacitacion2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capacitacion2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.capacitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet20 = new VersionFramework.HospitalDataSet20();
            this.capacitacionesTableAdapter = new VersionFramework.HospitalDataSet20TableAdapters.CapacitacionesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarcaS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModeloS = new System.Windows.Forms.TextBox();
            this.txtNomS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.hospitalDataSet21 = new VersionFramework.HospitalDataSet21();
            this.solicitudesCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudes_CapTableAdapter = new VersionFramework.HospitalDataSet21TableAdapters.Solicitudes_CapTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.hospitalDataSet22 = new VersionFramework.HospitalDataSet22();
            this.solicitudesCapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudes_CapTableAdapter1 = new VersionFramework.HospitalDataSet22TableAdapters.Solicitudes_CapTableAdapter();
            this.advancedDataGridView2 = new ADGV.AdvancedDataGridView();
            this.nombredelEquipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalDataSet23 = new VersionFramework.HospitalDataSet23();
            this.capacitacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.capacitacionesTableAdapter1 = new VersionFramework.HospitalDataSet23TableAdapters.CapacitacionesTableAdapter();
            this.hospitalDataSet24 = new VersionFramework.HospitalDataSet24();
            this.capacitacionesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.capacitacionesTableAdapter2 = new VersionFramework.HospitalDataSet24TableAdapters.CapacitacionesTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.nombredelEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProgramadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasEstimadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // capacitacionesBindingSource
            // 
            this.capacitacionesBindingSource.DataMember = "Capacitaciones";
            this.capacitacionesBindingSource.DataSource = this.hospitalDataSet20;
            // 
            // hospitalDataSet20
            // 
            this.hospitalDataSet20.DataSetName = "HospitalDataSet20";
            this.hospitalDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capacitacionesTableAdapter
            // 
            this.capacitacionesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1118, 41);
            this.label1.TabIndex = 94;
            this.label1.Text = "Próximas capacitaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMarcaS
            // 
            this.txtMarcaS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaS.Location = new System.Drawing.Point(860, 511);
            this.txtMarcaS.Name = "txtMarcaS";
            this.txtMarcaS.Size = new System.Drawing.Size(178, 26);
            this.txtMarcaS.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 100;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(720, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 32);
            this.label5.TabIndex = 99;
            this.label5.Text = "Solicitar capacitación";
            // 
            // txtModeloS
            // 
            this.txtModeloS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloS.Location = new System.Drawing.Point(860, 477);
            this.txtModeloS.Name = "txtModeloS";
            this.txtModeloS.Size = new System.Drawing.Size(178, 26);
            this.txtModeloS.TabIndex = 98;
            // 
            // txtNomS
            // 
            this.txtNomS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomS.Location = new System.Drawing.Point(860, 446);
            this.txtNomS.Name = "txtNomS";
            this.txtNomS.Size = new System.Drawing.Size(178, 26);
            this.txtNomS.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 96;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 95;
            this.label3.Text = "Nombre del equipo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(649, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 265);
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // Ingresar
            // 
            this.Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ingresar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(680, 565);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(159, 34);
            this.Ingresar.TabIndex = 105;
            this.Ingresar.Text = "Ingresar solicitud";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // hospitalDataSet21
            // 
            this.hospitalDataSet21.DataSetName = "HospitalDataSet21";
            this.hospitalDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudesCapBindingSource
            // 
            this.solicitudesCapBindingSource.DataMember = "Solicitudes_Cap";
            this.solicitudesCapBindingSource.DataSource = this.hospitalDataSet21;
            // 
            // solicitudes_CapTableAdapter
            // 
            this.solicitudes_CapTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 41);
            this.label2.TabIndex = 107;
            this.label2.Text = "Solicitudes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hospitalDataSet22
            // 
            this.hospitalDataSet22.DataSetName = "HospitalDataSet22";
            this.hospitalDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudesCapBindingSource1
            // 
            this.solicitudesCapBindingSource1.DataMember = "Solicitudes_Cap";
            this.solicitudesCapBindingSource1.DataSource = this.hospitalDataSet22;
            // 
            // solicitudes_CapTableAdapter1
            // 
            this.solicitudes_CapTableAdapter1.ClearBeforeFill = true;
            // 
            // advancedDataGridView2
            // 
            this.advancedDataGridView2.AllowUserToAddRows = false;
            this.advancedDataGridView2.AllowUserToDeleteRows = false;
            this.advancedDataGridView2.AllowUserToResizeColumns = false;
            this.advancedDataGridView2.AllowUserToResizeRows = false;
            this.advancedDataGridView2.AutoGenerateColumns = false;
            this.advancedDataGridView2.AutoGenerateContextFilters = true;
            this.advancedDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredelEquipoDataGridViewTextBoxColumn1,
            this.modeloDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn});
            this.advancedDataGridView2.DataSource = this.solicitudesCapBindingSource1;
            this.advancedDataGridView2.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView2.Location = new System.Drawing.Point(33, 374);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            this.advancedDataGridView2.Size = new System.Drawing.Size(573, 239);
            this.advancedDataGridView2.TabIndex = 108;
            this.advancedDataGridView2.TimeFilter = false;
            // 
            // nombredelEquipoDataGridViewTextBoxColumn1
            // 
            this.nombredelEquipoDataGridViewTextBoxColumn1.DataPropertyName = "Nombre_del_Equipo";
            this.nombredelEquipoDataGridViewTextBoxColumn1.HeaderText = "Nombre_del_Equipo";
            this.nombredelEquipoDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.nombredelEquipoDataGridViewTextBoxColumn1.Name = "nombredelEquipoDataGridViewTextBoxColumn1";
            this.nombredelEquipoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // modeloDataGridViewTextBoxColumn1
            // 
            this.modeloDataGridViewTextBoxColumn1.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.modeloDataGridViewTextBoxColumn1.Name = "modeloDataGridViewTextBoxColumn1";
            this.modeloDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // hospitalDataSet23
            // 
            this.hospitalDataSet23.DataSetName = "HospitalDataSet23";
            this.hospitalDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capacitacionesBindingSource1
            // 
            this.capacitacionesBindingSource1.DataMember = "Capacitaciones";
            this.capacitacionesBindingSource1.DataSource = this.hospitalDataSet23;
            // 
            // capacitacionesTableAdapter1
            // 
            this.capacitacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // hospitalDataSet24
            // 
            this.hospitalDataSet24.DataSetName = "HospitalDataSet24";
            this.hospitalDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capacitacionesBindingSource2
            // 
            this.capacitacionesBindingSource2.DataMember = "Capacitaciones";
            this.capacitacionesBindingSource2.DataSource = this.hospitalDataSet24;
            // 
            // capacitacionesTableAdapter2
            // 
            this.capacitacionesTableAdapter2.ClearBeforeFill = true;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredelEquipoDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn1,
            this.fechaProgramadaDataGridViewTextBoxColumn,
            this.horasEstimadasDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.capacitacionesBindingSource2;
            this.advancedDataGridView1.DateWithTime = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.advancedDataGridView1.Location = new System.Drawing.Point(33, 89);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(1031, 245);
            this.advancedDataGridView1.TabIndex = 109;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // nombredelEquipoDataGridViewTextBoxColumn
            // 
            this.nombredelEquipoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_del_Equipo";
            this.nombredelEquipoDataGridViewTextBoxColumn.HeaderText = "Nombre_del_Equipo";
            this.nombredelEquipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombredelEquipoDataGridViewTextBoxColumn.Name = "nombredelEquipoDataGridViewTextBoxColumn";
            this.nombredelEquipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // marcaDataGridViewTextBoxColumn1
            // 
            this.marcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.marcaDataGridViewTextBoxColumn1.Name = "marcaDataGridViewTextBoxColumn1";
            this.marcaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaProgramadaDataGridViewTextBoxColumn
            // 
            this.fechaProgramadaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Programada";
            this.fechaProgramadaDataGridViewTextBoxColumn.HeaderText = "Fecha_Programada";
            this.fechaProgramadaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaProgramadaDataGridViewTextBoxColumn.Name = "fechaProgramadaDataGridViewTextBoxColumn";
            this.fechaProgramadaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // horasEstimadasDataGridViewTextBoxColumn
            // 
            this.horasEstimadasDataGridViewTextBoxColumn.DataPropertyName = "Horas_Estimadas";
            this.horasEstimadasDataGridViewTextBoxColumn.HeaderText = "Horas_Estimadas";
            this.horasEstimadasDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.horasEstimadasDataGridViewTextBoxColumn.Name = "horasEstimadasDataGridViewTextBoxColumn";
            this.horasEstimadasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(860, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 110;
            this.button1.Text = "Eliminar solicitud";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Capacitacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1119, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.advancedDataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.txtMarcaS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModeloS);
            this.Controls.Add(this.txtNomS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capacitacion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacitacion2";
            this.Load += new System.EventHandler(this.Capacitacion2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HospitalDataSet20 hospitalDataSet20;
        private System.Windows.Forms.BindingSource capacitacionesBindingSource;
        private HospitalDataSet20TableAdapters.CapacitacionesTableAdapter capacitacionesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarcaS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModeloS;
        private System.Windows.Forms.TextBox txtNomS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Ingresar;
        private HospitalDataSet21 hospitalDataSet21;
        private System.Windows.Forms.BindingSource solicitudesCapBindingSource;
        private HospitalDataSet21TableAdapters.Solicitudes_CapTableAdapter solicitudes_CapTableAdapter;
        private System.Windows.Forms.Label label2;
        private HospitalDataSet22 hospitalDataSet22;
        private System.Windows.Forms.BindingSource solicitudesCapBindingSource1;
        private HospitalDataSet22TableAdapters.Solicitudes_CapTableAdapter solicitudes_CapTableAdapter1;
        private ADGV.AdvancedDataGridView advancedDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelEquipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private HospitalDataSet23 hospitalDataSet23;
        private System.Windows.Forms.BindingSource capacitacionesBindingSource1;
        private HospitalDataSet23TableAdapters.CapacitacionesTableAdapter capacitacionesTableAdapter1;
        private HospitalDataSet24 hospitalDataSet24;
        private System.Windows.Forms.BindingSource capacitacionesBindingSource2;
        private HospitalDataSet24TableAdapters.CapacitacionesTableAdapter capacitacionesTableAdapter2;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProgramadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasEstimadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}