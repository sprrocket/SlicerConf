namespace SlicerConf
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PrintersComboBox = new System.Windows.Forms.ComboBox();
            this.PrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrinterSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printerLabel = new System.Windows.Forms.Label();
            this.SettingsComboBox = new System.Windows.Forms.ComboBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.Filament = new System.Windows.Forms.Label();
            this.FilamentComboBox = new System.Windows.Forms.ComboBox();
            this.FilamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaxBuildXTextBox = new System.Windows.Forms.TextBox();
            this.MaxBuildXLabel = new System.Windows.Forms.Label();
            this.AddImageButton = new System.Windows.Forms.Button();
            this.ExamplePictureBox = new System.Windows.Forms.PictureBox();
            this.PictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrinterAddBtn = new System.Windows.Forms.Button();
            this.SettingAddBtn = new System.Windows.Forms.Button();
            this.FilamentAddBtn = new System.Windows.Forms.Button();
            this.MaxBuildYTextBox = new System.Windows.Forms.TextBox();
            this.MaxBuildYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterSettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintersComboBox
            // 
            this.PrintersComboBox.DataSource = this.PrinterBindingSource;
            this.PrintersComboBox.DisplayMember = "Name";
            this.PrintersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrintersComboBox.FormattingEnabled = true;
            this.PrintersComboBox.Location = new System.Drawing.Point(15, 25);
            this.PrintersComboBox.Name = "PrintersComboBox";
            this.PrintersComboBox.Size = new System.Drawing.Size(121, 21);
            this.PrintersComboBox.TabIndex = 0;
            this.PrintersComboBox.SelectedIndexChanged += new System.EventHandler(this.PrintersComboBox_SelectedIndexChanged);
            // 
            // PrinterBindingSource
            // 
            this.PrinterBindingSource.DataSource = typeof(SlicerConf.Data.Printer);
            this.PrinterBindingSource.CurrentChanged += new System.EventHandler(this.PrinterBindingSource_CurrentChanged);
            // 
            // PrinterSettingBindingSource
            // 
            this.PrinterSettingBindingSource.DataSource = typeof(SlicerConf.Data.PrinterSetting);
            // 
            // printerLabel
            // 
            this.printerLabel.AutoSize = true;
            this.printerLabel.Location = new System.Drawing.Point(12, 9);
            this.printerLabel.Name = "printerLabel";
            this.printerLabel.Size = new System.Drawing.Size(37, 13);
            this.printerLabel.TabIndex = 1;
            this.printerLabel.Text = "Printer";
            // 
            // SettingsComboBox
            // 
            this.SettingsComboBox.DataSource = this.PrinterSettingBindingSource;
            this.SettingsComboBox.DisplayMember = "Name";
            this.SettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingsComboBox.FormattingEnabled = true;
            this.SettingsComboBox.Location = new System.Drawing.Point(15, 65);
            this.SettingsComboBox.Name = "SettingsComboBox";
            this.SettingsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SettingsComboBox.TabIndex = 0;
            this.SettingsComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingsComboBox_SelectedIndexChanged);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(12, 49);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(40, 13);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "Setting";
            // 
            // Filament
            // 
            this.Filament.AutoSize = true;
            this.Filament.Location = new System.Drawing.Point(12, 89);
            this.Filament.Name = "Filament";
            this.Filament.Size = new System.Drawing.Size(46, 13);
            this.Filament.TabIndex = 1;
            this.Filament.Text = "Filament";
            // 
            // FilamentComboBox
            // 
            this.FilamentComboBox.DataSource = this.FilamentBindingSource;
            this.FilamentComboBox.DisplayMember = "Name";
            this.FilamentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilamentComboBox.FormattingEnabled = true;
            this.FilamentComboBox.Location = new System.Drawing.Point(15, 105);
            this.FilamentComboBox.Name = "FilamentComboBox";
            this.FilamentComboBox.Size = new System.Drawing.Size(121, 21);
            this.FilamentComboBox.TabIndex = 0;
            this.FilamentComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingsComboBox_SelectedIndexChanged);
            // 
            // FilamentBindingSource
            // 
            this.FilamentBindingSource.DataSource = typeof(SlicerConf.Data.Filament);
            // 
            // MaxBuildXTextBox
            // 
            this.MaxBuildXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterBindingSource, "MaxBuildX", true));
            this.MaxBuildXTextBox.Location = new System.Drawing.Point(187, 26);
            this.MaxBuildXTextBox.Name = "MaxBuildXTextBox";
            this.MaxBuildXTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxBuildXTextBox.TabIndex = 2;
            this.MaxBuildXTextBox.TextChanged += new System.EventHandler(this.MaxBuildXTextBox_TextChanged);
            this.MaxBuildXTextBox.Validated += new System.EventHandler(this.MaxBuildXTextBox_Validated);
            // 
            // MaxBuildXLabel
            // 
            this.MaxBuildXLabel.AutoSize = true;
            this.MaxBuildXLabel.Location = new System.Drawing.Point(184, 10);
            this.MaxBuildXLabel.Name = "MaxBuildXLabel";
            this.MaxBuildXLabel.Size = new System.Drawing.Size(66, 13);
            this.MaxBuildXLabel.TabIndex = 3;
            this.MaxBuildXLabel.Text = "Max Build: X";
            // 
            // AddImageButton
            // 
            this.AddImageButton.Location = new System.Drawing.Point(304, 384);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(75, 23);
            this.AddImageButton.TabIndex = 4;
            this.AddImageButton.Text = "Add Image";
            this.AddImageButton.UseVisualStyleBackColor = true;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // ExamplePictureBox
            // 
            this.ExamplePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExamplePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.PictureBindingSource, "img", true));
            this.ExamplePictureBox.Location = new System.Drawing.Point(304, 244);
            this.ExamplePictureBox.Name = "ExamplePictureBox";
            this.ExamplePictureBox.Size = new System.Drawing.Size(132, 134);
            this.ExamplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExamplePictureBox.TabIndex = 5;
            this.ExamplePictureBox.TabStop = false;
            // 
            // PictureBindingSource
            // 
            this.PictureBindingSource.DataSource = typeof(SlicerConf.Data.Picture);
            this.PictureBindingSource.CurrentChanged += new System.EventHandler(this.PictureBindingSource_CurrentChanged);
            // 
            // PrinterAddBtn
            // 
            this.PrinterAddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrinterAddBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinterAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrinterAddBtn.Image")));
            this.PrinterAddBtn.Location = new System.Drawing.Point(142, 26);
            this.PrinterAddBtn.Name = "PrinterAddBtn";
            this.PrinterAddBtn.Size = new System.Drawing.Size(20, 20);
            this.PrinterAddBtn.TabIndex = 6;
            this.PrinterAddBtn.UseVisualStyleBackColor = true;
            this.PrinterAddBtn.Click += new System.EventHandler(this.PrinterAddBtn_Click);
            // 
            // SettingAddBtn
            // 
            this.SettingAddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingAddBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingAddBtn.Image")));
            this.SettingAddBtn.Location = new System.Drawing.Point(142, 66);
            this.SettingAddBtn.Name = "SettingAddBtn";
            this.SettingAddBtn.Size = new System.Drawing.Size(20, 20);
            this.SettingAddBtn.TabIndex = 6;
            this.SettingAddBtn.UseVisualStyleBackColor = true;
            // 
            // FilamentAddBtn
            // 
            this.FilamentAddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.FilamentAddBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilamentAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("FilamentAddBtn.Image")));
            this.FilamentAddBtn.Location = new System.Drawing.Point(142, 106);
            this.FilamentAddBtn.Name = "FilamentAddBtn";
            this.FilamentAddBtn.Size = new System.Drawing.Size(20, 20);
            this.FilamentAddBtn.TabIndex = 6;
            this.FilamentAddBtn.UseVisualStyleBackColor = true;
            // 
            // MaxBuildYTextBox
            // 
            this.MaxBuildYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterBindingSource, "MaxBuildY", true));
            this.MaxBuildYTextBox.Location = new System.Drawing.Point(293, 26);
            this.MaxBuildYTextBox.Name = "MaxBuildYTextBox";
            this.MaxBuildYTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxBuildYTextBox.TabIndex = 2;
            this.MaxBuildYTextBox.Validated += new System.EventHandler(this.MaxBuildXTextBox_Validated);
            // 
            // MaxBuildYLabel
            // 
            this.MaxBuildYLabel.AutoSize = true;
            this.MaxBuildYLabel.Location = new System.Drawing.Point(290, 10);
            this.MaxBuildYLabel.Name = "MaxBuildYLabel";
            this.MaxBuildYLabel.Size = new System.Drawing.Size(66, 13);
            this.MaxBuildYLabel.TabIndex = 3;
            this.MaxBuildYLabel.Text = "Max Build: Y";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 419);
            this.Controls.Add(this.FilamentAddBtn);
            this.Controls.Add(this.SettingAddBtn);
            this.Controls.Add(this.PrinterAddBtn);
            this.Controls.Add(this.ExamplePictureBox);
            this.Controls.Add(this.AddImageButton);
            this.Controls.Add(this.MaxBuildYLabel);
            this.Controls.Add(this.MaxBuildXLabel);
            this.Controls.Add(this.MaxBuildYTextBox);
            this.Controls.Add(this.MaxBuildXTextBox);
            this.Controls.Add(this.Filament);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.printerLabel);
            this.Controls.Add(this.FilamentComboBox);
            this.Controls.Add(this.SettingsComboBox);
            this.Controls.Add(this.PrintersComboBox);
            this.Name = "MainForm";
            this.Text = "SlicerConf";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrinterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterSettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox PrintersComboBox;
        private System.Windows.Forms.BindingSource PrinterBindingSource;
        private System.Windows.Forms.Label printerLabel;
        public System.Windows.Forms.ComboBox SettingsComboBox;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.BindingSource PrinterSettingBindingSource;
        private System.Windows.Forms.Label Filament;
        public System.Windows.Forms.ComboBox FilamentComboBox;
        private System.Windows.Forms.BindingSource FilamentBindingSource;
        private System.Windows.Forms.TextBox MaxBuildXTextBox;
        private System.Windows.Forms.Label MaxBuildXLabel;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.PictureBox ExamplePictureBox;
        private System.Windows.Forms.BindingSource PictureBindingSource;
        private System.Windows.Forms.Button PrinterAddBtn;
        private System.Windows.Forms.Button SettingAddBtn;
        private System.Windows.Forms.Button FilamentAddBtn;
        private System.Windows.Forms.TextBox MaxBuildYTextBox;
        private System.Windows.Forms.Label MaxBuildYLabel;
    }
}

