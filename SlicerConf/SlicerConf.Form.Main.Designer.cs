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
            this.PrintersComboBox = new System.Windows.Forms.ComboBox();
            this.PrinterSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printerLabel = new System.Windows.Forms.Label();
            this.SettingsComboBox = new System.Windows.Forms.ComboBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.Filament = new System.Windows.Forms.Label();
            this.FilamentComboBox = new System.Windows.Forms.ComboBox();
            this.FilamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaxBuildXTextBox = new System.Windows.Forms.TextBox();
            this.MaxBuildXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterSettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilamentBindingSource)).BeginInit();
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
            // PrinterSettingBindingSource
            // 
            this.PrinterSettingBindingSource.DataSource = typeof(SlicerConf.Data.PrinterSetting);
            // 
            // PrinterBindingSource
            // 
            this.PrinterBindingSource.DataSource = typeof(SlicerConf.Data.Printer);
            this.PrinterBindingSource.CurrentChanged += new System.EventHandler(this.PrinterBindingSource_CurrentChanged);
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
            this.MaxBuildXTextBox.Location = new System.Drawing.Point(185, 25);
            this.MaxBuildXTextBox.Name = "MaxBuildXTextBox";
            this.MaxBuildXTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxBuildXTextBox.TabIndex = 2;
            this.MaxBuildXTextBox.Validated += new System.EventHandler(this.MaxBuildXTextBox_Validated);
            // 
            // MaxBuildXLabel
            // 
            this.MaxBuildXLabel.AutoSize = true;
            this.MaxBuildXLabel.Location = new System.Drawing.Point(182, 9);
            this.MaxBuildXLabel.Name = "MaxBuildXLabel";
            this.MaxBuildXLabel.Size = new System.Drawing.Size(66, 13);
            this.MaxBuildXLabel.TabIndex = 3;
            this.MaxBuildXLabel.Text = "Max Build: X";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 419);
            this.Controls.Add(this.MaxBuildXLabel);
            this.Controls.Add(this.MaxBuildXTextBox);
            this.Controls.Add(this.Filament);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.printerLabel);
            this.Controls.Add(this.FilamentComboBox);
            this.Controls.Add(this.SettingsComboBox);
            this.Controls.Add(this.PrintersComboBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrinterSettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilamentBindingSource)).EndInit();
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
    }
}

