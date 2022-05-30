namespace VersionFramework
{
    partial class Capacitación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capacitación));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.capacitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet20 = new VersionFramework.HospitalDataSet20();
            this.capacitacionesTableAdapter = new VersionFramework.HospitalDataSet20TableAdapters.CapacitacionesTableAdapter();
            this.Guardar_Capacitacion = new System.Windows.Forms.Button();
            this.txtMarcaCap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModeloCap = new System.Windows.Forms.TextBox();
            this.txtNomCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.advancedDataGridView2 = new ADGV.AdvancedDataGridView();
            this.nombredelEquipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitudesCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet21 = new VersionFramework.HospitalDataSet21();
            this.solicitudes_CapTableAdapter = new VersionFramework.HospitalDataSet21TableAdapters.Solicitudes_CapTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHorasEstimadas = new System.Windows.Forms.MaskedTextBox();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.nombredelEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProgramadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasEstimadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet25 = new VersionFramework.HospitalDataSet25();
            this.capacitacionesTableAdapter1 = new VersionFramework.HospitalDataSet25TableAdapters.CapacitacionesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet25)).BeginInit();
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
            // Guardar_Capacitacion
            // 
            this.Guardar_Capacitacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_Capacitacion.Location = new System.Drawing.Point(672, 618);
            this.Guardar_Capacitacion.Name = "Guardar_Capacitacion";
            this.Guardar_Capacitacion.Size = new System.Drawing.Size(121, 31);
            this.Guardar_Capacitacion.TabIndex = 91;
            this.Guardar_Capacitacion.Text = "Guardar";
            this.Guardar_Capacitacion.UseVisualStyleBackColor = true;
            this.Guardar_Capacitacion.Click += new System.EventHandler(this.Guardar_Capacitacion_Click_1);
            // 
            // txtMarcaCap
            // 
            this.txtMarcaCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaCap.Location = new System.Drawing.Point(806, 499);
            this.txtMarcaCap.Name = "txtMarcaCap";
            this.txtMarcaCap.Size = new System.Drawing.Size(178, 26);
            this.txtMarcaCap.TabIndex = 88;
            this.txtMarcaCap.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(622, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 85;
            this.label7.Text = "Fijar fecha";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 32);
            this.label5.TabIndex = 83;
            this.label5.Text = "Agendar capacitación";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtModeloCap
            // 
            this.txtModeloCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloCap.Location = new System.Drawing.Point(806, 465);
            this.txtModeloCap.Name = "txtModeloCap";
            this.txtModeloCap.Size = new System.Drawing.Size(178, 26);
            this.txtModeloCap.TabIndex = 82;
            this.txtModeloCap.TextChanged += new System.EventHandler(this.txtSerieI_TextChanged);
            // 
            // txtNomCap
            // 
            this.txtNomCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCap.Location = new System.Drawing.Point(806, 434);
            this.txtNomCap.Name = "txtNomCap";
            this.txtNomCap.Size = new System.Drawing.Size(178, 26);
            this.txtNomCap.TabIndex = 81;
            this.txtNomCap.TextChanged += new System.EventHandler(this.txtNombreI_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(622, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 80;
            this.label4.Text = "Modelo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(595, 342);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 332);
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(622, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 84;
            this.label6.Text = "Marca";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(806, 532);
            this.txtFecha.Mask = "00/00/0000 00:00";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(178, 26);
            this.txtFecha.TabIndex = 92;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1044, 41);
            this.label1.TabIndex = 93;
            this.label1.Text = "Próximas capacitaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 41);
            this.label2.TabIndex = 94;
            this.label2.Text = "Solicitudes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.advancedDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.advancedDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredelEquipoDataGridViewTextBoxColumn1,
            this.modeloDataGridViewTextBoxColumn1,
            this.marcaDataGridViewTextBoxColumn});
            this.advancedDataGridView2.DataSource = this.solicitudesCapBindingSource;
            this.advancedDataGridView2.DateWithTime = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.advancedDataGridView2.Location = new System.Drawing.Point(25, 386);
            this.advancedDataGridView2.Name = "advancedDataGridView2";
            this.advancedDataGridView2.Size = new System.Drawing.Size(534, 288);
            this.advancedDataGridView2.TabIndex = 95;
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
            // solicitudesCapBindingSource
            // 
            this.solicitudesCapBindingSource.DataMember = "Solicitudes_Cap";
            this.solicitudesCapBindingSource.DataSource = this.hospitalDataSet21;
            // 
            // hospitalDataSet21
            // 
            this.hospitalDataSet21.DataSetName = "HospitalDataSet21";
            this.hospitalDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudes_CapTableAdapter
            // 
            this.solicitudes_CapTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(622, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 96;
            this.label8.Text = "Horas estimadas";
            // 
            // txtHorasEstimadas
            // 
            this.txtHorasEstimadas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasEstimadas.Location = new System.Drawing.Point(806, 564);
            this.txtHorasEstimadas.Mask = "99999";
            this.txtHorasEstimadas.Name = "txtHorasEstimadas";
            this.txtHorasEstimadas.Size = new System.Drawing.Size(178, 26);
            this.txtHorasEstimadas.TabIndex = 97;
            this.txtHorasEstimadas.ValidatingType = typeof(int);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredelEquipoDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn1,
            this.fechaProgramadaDataGridViewTextBoxColumn,
            this.horasEstimadasDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.capacitacionesBindingSource1;
            this.advancedDataGridView1.DateWithTime = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.advancedDataGridView1.Location = new System.Drawing.Point(32, 72);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(978, 261);
            this.advancedDataGridView1.TabIndex = 98;
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
            // capacitacionesBindingSource1
            // 
            this.capacitacionesBindingSource1.DataMember = "Capacitaciones";
            this.capacitacionesBindingSource1.DataSource = this.hospitalDataSet25;
            // 
            // hospitalDataSet25
            // 
            this.hospitalDataSet25.DataSetName = "HospitalDataSet25";
            this.hospitalDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capacitacionesTableAdapter1
            // 
            this.capacitacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(806, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 99;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Capacitación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1040, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.txtHorasEstimadas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.advancedDataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.Guardar_Capacitacion);
            this.Controls.Add(this.txtMarcaCap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModeloCap);
            this.Controls.Add(this.txtNomCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capacitación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacitación";
            this.Load += new System.EventHandler(this.Capacitación_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HospitalDataSet20 hospitalDataSet20;
        private System.Windows.Forms.BindingSource capacitacionesBindingSource;
        private HospitalDataSet20TableAdapters.CapacitacionesTableAdapter capacitacionesTableAdapter;
        private System.Windows.Forms.Button Guardar_Capacitacion;
        private System.Windows.Forms.TextBox txtMarcaCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModeloCap;
        private System.Windows.Forms.TextBox txtNomCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ADGV.AdvancedDataGridView advancedDataGridView2;
        private HospitalDataSet21 hospitalDataSet21;
        private System.Windows.Forms.BindingSource solicitudesCapBindingSource;
        private HospitalDataSet21TableAdapters.Solicitudes_CapTableAdapter solicitudes_CapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelEquipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtHorasEstimadas;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private HospitalDataSet25 hospitalDataSet25;
        private System.Windows.Forms.BindingSource capacitacionesBindingSource1;
        private HospitalDataSet25TableAdapters.CapacitacionesTableAdapter capacitacionesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProgramadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasEstimadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}