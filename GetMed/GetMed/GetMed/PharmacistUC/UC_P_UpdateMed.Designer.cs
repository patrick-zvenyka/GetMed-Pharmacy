namespace GetMed.PharmacistUC
{
    partial class UC_P_UpdateMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_UpdateMed));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtMedName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMedNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPricePerUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtManDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Update Medicine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.txtMedID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedID.ForeColor = System.Drawing.Color.Black;
            this.txtMedID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedID.HoverState.Parent = this.txtMedID;
            this.txtMedID.Location = new System.Drawing.Point(38, 101);
            this.txtMedID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.PasswordChar = '\0';
            this.txtMedID.PlaceholderText = "Medicine ID";
            this.txtMedID.SelectedText = "";
            this.txtMedID.ShadowDecoration.Parent = this.txtMedID;
            this.txtMedID.Size = new System.Drawing.Size(214, 36);
            this.txtMedID.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 16;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.HoverState.Image")));
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(174, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(78, 34);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtMedName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedName.ForeColor = System.Drawing.Color.Black;
            this.txtMedName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedName.HoverState.Parent = this.txtMedName;
            this.txtMedName.Location = new System.Drawing.Point(38, 200);
            this.txtMedName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.PasswordChar = '\0';
            this.txtMedName.PlaceholderText = "Medicine Name";
            this.txtMedName.SelectedText = "";
            this.txtMedName.ShadowDecoration.Parent = this.txtMedName;
            this.txtMedName.Size = new System.Drawing.Size(214, 36);
            this.txtMedName.TabIndex = 22;
            // 
            // txtMedNum
            // 
            this.txtMedNum.BorderRadius = 16;
            this.txtMedNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedNum.DefaultText = "";
            this.txtMedNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedNum.DisabledState.Parent = this.txtMedNum;
            this.txtMedNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedNum.FocusedState.Parent = this.txtMedNum;
            this.txtMedNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedNum.ForeColor = System.Drawing.Color.Black;
            this.txtMedNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedNum.HoverState.Parent = this.txtMedNum;
            this.txtMedNum.Location = new System.Drawing.Point(38, 270);
            this.txtMedNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMedNum.Name = "txtMedNum";
            this.txtMedNum.PasswordChar = '\0';
            this.txtMedNum.PlaceholderText = "Medicine Number";
            this.txtMedNum.SelectedText = "";
            this.txtMedNum.ShadowDecoration.Parent = this.txtMedNum;
            this.txtMedNum.Size = new System.Drawing.Size(214, 36);
            this.txtMedNum.TabIndex = 23;
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.BorderRadius = 16;
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.DefaultText = "";
            this.txtPricePerUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.DisabledState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.FocusedState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.HoverState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Location = new System.Drawing.Point(38, 337);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.PlaceholderText = "Price Per Unit";
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.ShadowDecoration.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Size = new System.Drawing.Size(214, 36);
            this.txtPricePerUnit.TabIndex = 24;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderRadius = 16;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(487, 101);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "Available Quantity";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(214, 36);
            this.txtQuantity.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Add Quantity";
            // 
            // txtAddQuantity
            // 
            this.txtAddQuantity.BorderRadius = 16;
            this.txtAddQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddQuantity.DefaultText = "0";
            this.txtAddQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddQuantity.DisabledState.Parent = this.txtAddQuantity;
            this.txtAddQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuantity.FocusedState.Parent = this.txtAddQuantity;
            this.txtAddQuantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtAddQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuantity.HoverState.Parent = this.txtAddQuantity;
            this.txtAddQuantity.Location = new System.Drawing.Point(593, 172);
            this.txtAddQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddQuantity.Name = "txtAddQuantity";
            this.txtAddQuantity.PasswordChar = '\0';
            this.txtAddQuantity.PlaceholderText = "Add Quantity";
            this.txtAddQuantity.SelectedText = "";
            this.txtAddQuantity.SelectionStart = 1;
            this.txtAddQuantity.ShadowDecoration.Parent = this.txtAddQuantity;
            this.txtAddQuantity.Size = new System.Drawing.Size(108, 36);
            this.txtAddQuantity.TabIndex = 27;
            this.txtAddQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtManDate
            // 
            this.txtManDate.BorderRadius = 16;
            this.txtManDate.BorderThickness = 1;
            this.txtManDate.CheckedState.Parent = this.txtManDate;
            this.txtManDate.FillColor = System.Drawing.Color.White;
            this.txtManDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtManDate.HoverState.Parent = this.txtManDate;
            this.txtManDate.Location = new System.Drawing.Point(487, 261);
            this.txtManDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtManDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtManDate.Name = "txtManDate";
            this.txtManDate.ShadowDecoration.Parent = this.txtManDate;
            this.txtManDate.Size = new System.Drawing.Size(214, 36);
            this.txtManDate.TabIndex = 28;
            this.txtManDate.Value = new System.DateTime(2022, 5, 3, 11, 34, 37, 563);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Manufactured Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Expiry Date";
            // 
            // txtExpDate
            // 
            this.txtExpDate.BorderRadius = 16;
            this.txtExpDate.BorderThickness = 1;
            this.txtExpDate.CheckedState.Parent = this.txtExpDate;
            this.txtExpDate.FillColor = System.Drawing.Color.White;
            this.txtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpDate.HoverState.Parent = this.txtExpDate;
            this.txtExpDate.Location = new System.Drawing.Point(487, 332);
            this.txtExpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ShadowDecoration.Parent = this.txtExpDate;
            this.txtExpDate.Size = new System.Drawing.Size(214, 36);
            this.txtExpDate.TabIndex = 31;
            this.txtExpDate.Value = new System.DateTime(2022, 5, 3, 11, 34, 37, 568);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 16;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(487, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(77, 45);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 16;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(18, 18);
            this.btnReset.Location = new System.Drawing.Point(624, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(77, 45);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_P_UpdateMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManDate);
            this.Controls.Add(this.txtAddQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.txtMedNum);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMedID);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_UpdateMed";
            this.Size = new System.Drawing.Size(870, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMedID;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtMedName;
        private Guna.UI2.WinForms.Guna2TextBox txtMedNum;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerUnit;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtAddQuantity;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtManDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpDate;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
