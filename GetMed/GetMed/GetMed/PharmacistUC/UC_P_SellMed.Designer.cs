namespace GetMed.PharmacistUC
{
    partial class UC_P_SellMed
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_SellMed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSync = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBoxMedicines = new System.Windows.Forms.ListBox();
            this.txtMedID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMedName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUnits = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtExpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAdd2Chart = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtRemoveItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchasePrint = new Guna.UI2.WinForms.Guna2Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Payment Form";
            // 
            // btnSync
            // 
            this.btnSync.CheckedState.Parent = this.btnSync;
            this.btnSync.CustomImages.Parent = this.btnSync;
            this.btnSync.FillColor = System.Drawing.Color.White;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.HoverState.Parent = this.btnSync;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.Location = new System.Drawing.Point(821, 30);
            this.btnSync.Name = "btnSync";
            this.btnSync.ShadowDecoration.Parent = this.btnSync;
            this.btnSync.Size = new System.Drawing.Size(24, 35);
            this.btnSync.TabIndex = 22;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 16;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(15, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search medicine.......";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(152, 36);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listBoxMedicines
            // 
            this.listBoxMedicines.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMedicines.FormattingEnabled = true;
            this.listBoxMedicines.ItemHeight = 17;
            this.listBoxMedicines.Location = new System.Drawing.Point(15, 94);
            this.listBoxMedicines.Name = "listBoxMedicines";
            this.listBoxMedicines.Size = new System.Drawing.Size(200, 327);
            this.listBoxMedicines.TabIndex = 24;
            this.listBoxMedicines.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicines_SelectedIndexChanged);
            // 
            // txtMedID
            // 
            this.txtMedID.BorderRadius = 16;
            this.txtMedID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedID.DefaultText = "";
            this.txtMedID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedID.DisabledState.Parent = this.txtMedID;
            this.txtMedID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedID.FocusedState.Parent = this.txtMedID;
            this.txtMedID.ForeColor = System.Drawing.Color.Black;
            this.txtMedID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedID.HoverState.Parent = this.txtMedID;
            this.txtMedID.Location = new System.Drawing.Point(244, 52);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.PasswordChar = '\0';
            this.txtMedID.PlaceholderText = "Mdicine ID";
            this.txtMedID.ReadOnly = true;
            this.txtMedID.SelectedText = "";
            this.txtMedID.ShadowDecoration.Parent = this.txtMedID;
            this.txtMedID.Size = new System.Drawing.Size(152, 36);
            this.txtMedID.TabIndex = 25;
            this.txtMedID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMedName
            // 
            this.txtMedName.BorderRadius = 16;
            this.txtMedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedName.DefaultText = "";
            this.txtMedName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedName.DisabledState.Parent = this.txtMedName;
            this.txtMedName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedName.FocusedState.Parent = this.txtMedName;
            this.txtMedName.ForeColor = System.Drawing.Color.Black;
            this.txtMedName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedName.HoverState.Parent = this.txtMedName;
            this.txtMedName.Location = new System.Drawing.Point(244, 117);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.PasswordChar = '\0';
            this.txtMedName.PlaceholderText = "Medicine Name";
            this.txtMedName.ReadOnly = true;
            this.txtMedName.SelectedText = "";
            this.txtMedName.ShadowDecoration.Parent = this.txtMedName;
            this.txtMedName.Size = new System.Drawing.Size(152, 36);
            this.txtMedName.TabIndex = 26;
            this.txtMedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 16;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(503, 52);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Price Per Unit";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(152, 36);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnits
            // 
            this.txtUnits.BorderRadius = 16;
            this.txtUnits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnits.DefaultText = "";
            this.txtUnits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnits.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnits.DisabledState.Parent = this.txtUnits;
            this.txtUnits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnits.FocusedState.Parent = this.txtUnits;
            this.txtUnits.ForeColor = System.Drawing.Color.Black;
            this.txtUnits.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnits.HoverState.Parent = this.txtUnits;
            this.txtUnits.Location = new System.Drawing.Point(503, 117);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.PasswordChar = '\0';
            this.txtUnits.PlaceholderText = "No of Units";
            this.txtUnits.SelectedText = "";
            this.txtUnits.ShadowDecoration.Parent = this.txtUnits;
            this.txtUnits.Size = new System.Drawing.Size(152, 36);
            this.txtUnits.TabIndex = 28;
            this.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnits.TextChanged += new System.EventHandler(this.txtUnits_TextChanged);
            // 
            // txtExpDate
            // 
            this.txtExpDate.BorderRadius = 16;
            this.txtExpDate.BorderThickness = 1;
            this.txtExpDate.CheckedState.Parent = this.txtExpDate;
            this.txtExpDate.FillColor = System.Drawing.Color.White;
            this.txtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpDate.HoverState.Parent = this.txtExpDate;
            this.txtExpDate.Location = new System.Drawing.Point(244, 169);
            this.txtExpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ShadowDecoration.Parent = this.txtExpDate;
            this.txtExpDate.Size = new System.Drawing.Size(152, 36);
            this.txtExpDate.TabIndex = 29;
            this.txtExpDate.Value = new System.DateTime(2022, 5, 13, 11, 19, 21, 127);
            // 
            // btnAdd2Chart
            // 
            this.btnAdd2Chart.BorderRadius = 16;
            this.btnAdd2Chart.CheckedState.Parent = this.btnAdd2Chart;
            this.btnAdd2Chart.CustomImages.Parent = this.btnAdd2Chart;
            this.btnAdd2Chart.FillColor = System.Drawing.Color.White;
            this.btnAdd2Chart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd2Chart.ForeColor = System.Drawing.Color.White;
            this.btnAdd2Chart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd2Chart.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnAdd2Chart.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.HoverState.Image")));
            this.btnAdd2Chart.HoverState.Parent = this.btnAdd2Chart;
            this.btnAdd2Chart.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd2Chart.Image")));
            this.btnAdd2Chart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd2Chart.Location = new System.Drawing.Point(683, 110);
            this.btnAdd2Chart.Name = "btnAdd2Chart";
            this.btnAdd2Chart.ShadowDecoration.Parent = this.btnAdd2Chart;
            this.btnAdd2Chart.Size = new System.Drawing.Size(62, 43);
            this.btnAdd2Chart.TabIndex = 30;
            this.btnAdd2Chart.Click += new System.EventHandler(this.btnAdd2Chart_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderRadius = 16;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(503, 169);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "Total";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(152, 36);
            this.txtTotalPrice.TabIndex = 31;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(244, 266);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(579, 191);
            this.guna2DataGridView1.TabIndex = 32;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // txtRemoveItem
            // 
            this.txtRemoveItem.BorderRadius = 16;
            this.txtRemoveItem.CheckedState.Parent = this.txtRemoveItem;
            this.txtRemoveItem.CustomImages.Parent = this.txtRemoveItem;
            this.txtRemoveItem.FillColor = System.Drawing.Color.White;
            this.txtRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRemoveItem.ForeColor = System.Drawing.Color.White;
            this.txtRemoveItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRemoveItem.HoverState.FillColor = System.Drawing.Color.Silver;
            this.txtRemoveItem.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.HoverState.Image")));
            this.txtRemoveItem.HoverState.Parent = this.txtRemoveItem;
            this.txtRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("txtRemoveItem.Image")));
            this.txtRemoveItem.ImageSize = new System.Drawing.Size(30, 30);
            this.txtRemoveItem.Location = new System.Drawing.Point(15, 429);
            this.txtRemoveItem.Name = "txtRemoveItem";
            this.txtRemoveItem.ShadowDecoration.Parent = this.txtRemoveItem;
            this.txtRemoveItem.Size = new System.Drawing.Size(62, 33);
            this.txtRemoveItem.TabIndex = 33;
            this.txtRemoveItem.Click += new System.EventHandler(this.txtRemoveItem_Click);
            // 
            // btnPurchasePrint
            // 
            this.btnPurchasePrint.BorderRadius = 16;
            this.btnPurchasePrint.CheckedState.Parent = this.btnPurchasePrint;
            this.btnPurchasePrint.CustomImages.Parent = this.btnPurchasePrint;
            this.btnPurchasePrint.FillColor = System.Drawing.Color.White;
            this.btnPurchasePrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPurchasePrint.ForeColor = System.Drawing.Color.White;
            this.btnPurchasePrint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPurchasePrint.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnPurchasePrint.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.HoverState.Image")));
            this.btnPurchasePrint.HoverState.Parent = this.btnPurchasePrint;
            this.btnPurchasePrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchasePrint.Image")));
            this.btnPurchasePrint.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPurchasePrint.Location = new System.Drawing.Point(118, 429);
            this.btnPurchasePrint.Name = "btnPurchasePrint";
            this.btnPurchasePrint.ShadowDecoration.Parent = this.btnPurchasePrint;
            this.btnPurchasePrint.Size = new System.Drawing.Size(62, 33);
            this.btnPurchasePrint.TabIndex = 34;
            this.btnPurchasePrint.Click += new System.EventHandler(this.btnPurchasePrint_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Silver;
            this.totalLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(500, 224);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(155, 23);
            this.totalLabel.TabIndex = 35;
            this.totalLabel.Text = "RTGS$. 00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expiry date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Per Unit";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No of Units";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.Name = "Column6";
            // 
            // UC_P_SellMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.btnPurchasePrint);
            this.Controls.Add(this.txtRemoveItem);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btnAdd2Chart);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.txtMedID);
            this.Controls.Add(this.listBoxMedicines);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_SellMed";
            this.Size = new System.Drawing.Size(870, 493);
            this.Load += new System.EventHandler(this.UC_P_SellMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSync;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ListBox listBoxMedicines;
        private Guna.UI2.WinForms.Guna2TextBox txtMedID;
        private Guna.UI2.WinForms.Guna2TextBox txtMedName;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtUnits;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpDate;
        private Guna.UI2.WinForms.Guna2Button btnAdd2Chart;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button txtRemoveItem;
        private Guna.UI2.WinForms.Guna2Button btnPurchasePrint;
        private System.Windows.Forms.Label totalLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
