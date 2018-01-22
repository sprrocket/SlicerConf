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
            System.Windows.Forms.Label maxBuildXLabel;
            System.Windows.Forms.Label maxBuildYLabel;
            System.Windows.Forms.Label maxBuildZLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label bottomShellsLabel;
            System.Windows.Forms.Label layerHeightLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label perimetersLabel;
            System.Windows.Forms.Label topShellsLabel;
            System.Windows.Forms.Label heatbedEnabledLabel;
            System.Windows.Forms.Label heatbedTemperatureLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label printTemperatureLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrinterSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddImageButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrinterAddBtn = new System.Windows.Forms.Button();
            this.SettingAddBtn = new System.Windows.Forms.Button();
            this.FilamentAddBtn = new System.Windows.Forms.Button();
            this.maxBuildXTextBox = new System.Windows.Forms.TextBox();
            this.maxBuildYTextBox = new System.Windows.Forms.TextBox();
            this.maxBuildZTextBox = new System.Windows.Forms.TextBox();
            this.PrintersComboBox = new System.Windows.Forms.ComboBox();
            this.bottomShellsTextBox = new System.Windows.Forms.TextBox();
            this.layerHeightTextBox = new System.Windows.Forms.TextBox();
            this.SettingsComboBox = new System.Windows.Forms.ComboBox();
            this.perimetersTextBox = new System.Windows.Forms.TextBox();
            this.topShellsTextBox = new System.Windows.Forms.TextBox();
            this.heatbedEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.heatbedTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.FilamentComboBox = new System.Windows.Forms.ComboBox();
            this.printTemperatureTextBox = new System.Windows.Forms.TextBox();
            maxBuildXLabel = new System.Windows.Forms.Label();
            maxBuildYLabel = new System.Windows.Forms.Label();
            maxBuildZLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            bottomShellsLabel = new System.Windows.Forms.Label();
            layerHeightLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            perimetersLabel = new System.Windows.Forms.Label();
            topShellsLabel = new System.Windows.Forms.Label();
            heatbedEnabledLabel = new System.Windows.Forms.Label();
            heatbedTemperatureLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            printTemperatureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterSettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maxBuildXLabel
            // 
            maxBuildXLabel.AutoSize = true;
            maxBuildXLabel.Location = new System.Drawing.Point(12, 36);
            maxBuildXLabel.Name = "maxBuildXLabel";
            maxBuildXLabel.Size = new System.Drawing.Size(66, 13);
            maxBuildXLabel.TabIndex = 9;
            maxBuildXLabel.Text = "Max Build X:";
            // 
            // maxBuildYLabel
            // 
            maxBuildYLabel.AutoSize = true;
            maxBuildYLabel.Location = new System.Drawing.Point(12, 62);
            maxBuildYLabel.Name = "maxBuildYLabel";
            maxBuildYLabel.Size = new System.Drawing.Size(66, 13);
            maxBuildYLabel.TabIndex = 11;
            maxBuildYLabel.Text = "Max Build Y:";
            // 
            // maxBuildZLabel
            // 
            maxBuildZLabel.AutoSize = true;
            maxBuildZLabel.Location = new System.Drawing.Point(12, 88);
            maxBuildZLabel.Name = "maxBuildZLabel";
            maxBuildZLabel.Size = new System.Drawing.Size(66, 13);
            maxBuildZLabel.TabIndex = 13;
            maxBuildZLabel.Text = "Max Build Z:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(71, 13);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "Printer Name:";
            // 
            // bottomShellsLabel
            // 
            bottomShellsLabel.AutoSize = true;
            bottomShellsLabel.Location = new System.Drawing.Point(271, 36);
            bottomShellsLabel.Name = "bottomShellsLabel";
            bottomShellsLabel.Size = new System.Drawing.Size(74, 13);
            bottomShellsLabel.TabIndex = 17;
            bottomShellsLabel.Text = "Bottom Shells:";
            // 
            // layerHeightLabel
            // 
            layerHeightLabel.AutoSize = true;
            layerHeightLabel.Location = new System.Drawing.Point(271, 62);
            layerHeightLabel.Name = "layerHeightLabel";
            layerHeightLabel.Size = new System.Drawing.Size(70, 13);
            layerHeightLabel.TabIndex = 19;
            layerHeightLabel.Text = "Layer Height:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(271, 9);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(74, 13);
            nameLabel1.TabIndex = 21;
            nameLabel1.Text = "Setting Name:";
            // 
            // perimetersLabel
            // 
            perimetersLabel.AutoSize = true;
            perimetersLabel.Location = new System.Drawing.Point(271, 91);
            perimetersLabel.Name = "perimetersLabel";
            perimetersLabel.Size = new System.Drawing.Size(59, 13);
            perimetersLabel.TabIndex = 23;
            perimetersLabel.Text = "Perimeters:";
            // 
            // topShellsLabel
            // 
            topShellsLabel.AutoSize = true;
            topShellsLabel.Location = new System.Drawing.Point(271, 117);
            topShellsLabel.Name = "topShellsLabel";
            topShellsLabel.Size = new System.Drawing.Size(60, 13);
            topShellsLabel.TabIndex = 25;
            topShellsLabel.Text = "Top Shells:";
            // 
            // heatbedEnabledLabel
            // 
            heatbedEnabledLabel.AutoSize = true;
            heatbedEnabledLabel.Location = new System.Drawing.Point(531, 38);
            heatbedEnabledLabel.Name = "heatbedEnabledLabel";
            heatbedEnabledLabel.Size = new System.Drawing.Size(93, 13);
            heatbedEnabledLabel.TabIndex = 27;
            heatbedEnabledLabel.Text = "Heatbed Enabled:";
            // 
            // heatbedTemperatureLabel
            // 
            heatbedTemperatureLabel.AutoSize = true;
            heatbedTemperatureLabel.Location = new System.Drawing.Point(531, 66);
            heatbedTemperatureLabel.Name = "heatbedTemperatureLabel";
            heatbedTemperatureLabel.Size = new System.Drawing.Size(114, 13);
            heatbedTemperatureLabel.TabIndex = 29;
            heatbedTemperatureLabel.Text = "Heatbed Temperature:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(531, 9);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(80, 13);
            nameLabel2.TabIndex = 31;
            nameLabel2.Text = "Filament Name:";
            // 
            // printTemperatureLabel
            // 
            printTemperatureLabel.AutoSize = true;
            printTemperatureLabel.Location = new System.Drawing.Point(531, 92);
            printTemperatureLabel.Name = "printTemperatureLabel";
            printTemperatureLabel.Size = new System.Drawing.Size(94, 13);
            printTemperatureLabel.TabIndex = 33;
            printTemperatureLabel.Text = "Print Temperature:";
            // 
            // PrinterBindingSource
            // 
            this.PrinterBindingSource.DataSource = typeof(SlicerConf.Data.Printer);
            this.PrinterBindingSource.CurrentChanged += new System.EventHandler(this.PrinterBindingSource_CurrentChanged);
            this.PrinterBindingSource.CurrentItemChanged += new System.EventHandler(this.PictureBindingSource_CurrentChanged);
            // 
            // PrinterSettingBindingSource
            // 
            this.PrinterSettingBindingSource.DataSource = typeof(SlicerConf.Data.PrinterSetting);
            this.PrinterSettingBindingSource.CurrentChanged += new System.EventHandler(this.PictureBindingSource_CurrentChanged);
            // 
            // FilamentBindingSource
            // 
            this.FilamentBindingSource.DataSource = typeof(SlicerConf.Data.Filament);
            this.FilamentBindingSource.CurrentChanged += new System.EventHandler(this.PictureBindingSource_CurrentChanged);
            // 
            // AddImageButton
            // 
            this.AddImageButton.Image = global::SlicerConf.Properties.Resources.Add_thin_10x_16x;
            this.AddImageButton.Location = new System.Drawing.Point(277, 392);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(20, 20);
            this.AddImageButton.TabIndex = 4;
            this.AddImageButton.UseVisualStyleBackColor = true;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.PictureBindingSource, "img", true));
            this.PictureBox.Location = new System.Drawing.Point(15, 170);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(256, 245);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // PictureBindingSource
            // 
            this.PictureBindingSource.DataSource = typeof(SlicerConf.Data.Picture);
            this.PictureBindingSource.Filter = "";
            this.PictureBindingSource.CurrentChanged += new System.EventHandler(this.PictureBindingSource_CurrentChanged);
            // 
            // PrinterAddBtn
            // 
            this.PrinterAddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrinterAddBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinterAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrinterAddBtn.Image")));
            this.PrinterAddBtn.Location = new System.Drawing.Point(211, 6);
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
            this.SettingAddBtn.Location = new System.Drawing.Point(478, 6);
            this.SettingAddBtn.Name = "SettingAddBtn";
            this.SettingAddBtn.Size = new System.Drawing.Size(20, 20);
            this.SettingAddBtn.TabIndex = 6;
            this.SettingAddBtn.UseVisualStyleBackColor = true;
            this.SettingAddBtn.Click += new System.EventHandler(this.SettingAddBtn_Click);
            // 
            // FilamentAddBtn
            // 
            this.FilamentAddBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.FilamentAddBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilamentAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("FilamentAddBtn.Image")));
            this.FilamentAddBtn.Location = new System.Drawing.Point(778, 6);
            this.FilamentAddBtn.Name = "FilamentAddBtn";
            this.FilamentAddBtn.Size = new System.Drawing.Size(20, 20);
            this.FilamentAddBtn.TabIndex = 6;
            this.FilamentAddBtn.UseVisualStyleBackColor = true;
            this.FilamentAddBtn.Click += new System.EventHandler(this.FilamentAddBtn_Click);
            // 
            // maxBuildXTextBox
            // 
            this.maxBuildXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterBindingSource, "MaxBuildX", true));
            this.maxBuildXTextBox.Location = new System.Drawing.Point(84, 33);
            this.maxBuildXTextBox.Name = "maxBuildXTextBox";
            this.maxBuildXTextBox.Size = new System.Drawing.Size(121, 20);
            this.maxBuildXTextBox.TabIndex = 10;
            // 
            // maxBuildYTextBox
            // 
            this.maxBuildYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterBindingSource, "MaxBuildY", true));
            this.maxBuildYTextBox.Location = new System.Drawing.Point(84, 59);
            this.maxBuildYTextBox.Name = "maxBuildYTextBox";
            this.maxBuildYTextBox.Size = new System.Drawing.Size(121, 20);
            this.maxBuildYTextBox.TabIndex = 12;
            // 
            // maxBuildZTextBox
            // 
            this.maxBuildZTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterBindingSource, "MaxBuildZ", true));
            this.maxBuildZTextBox.Location = new System.Drawing.Point(84, 85);
            this.maxBuildZTextBox.Name = "maxBuildZTextBox";
            this.maxBuildZTextBox.Size = new System.Drawing.Size(121, 20);
            this.maxBuildZTextBox.TabIndex = 14;
            // 
            // PrintersComboBox
            // 
            this.PrintersComboBox.DataSource = this.PrinterBindingSource;
            this.PrintersComboBox.DisplayMember = "Name";
            this.PrintersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrintersComboBox.FormattingEnabled = true;
            this.PrintersComboBox.Location = new System.Drawing.Point(84, 6);
            this.PrintersComboBox.Name = "PrintersComboBox";
            this.PrintersComboBox.Size = new System.Drawing.Size(121, 21);
            this.PrintersComboBox.TabIndex = 16;
            this.PrintersComboBox.SelectedIndexChanged += new System.EventHandler(this.PrintersComboBox_SelectedIndexChanged);
            // 
            // bottomShellsTextBox
            // 
            this.bottomShellsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterSettingBindingSource, "BottomShells", true));
            this.bottomShellsTextBox.Location = new System.Drawing.Point(351, 33);
            this.bottomShellsTextBox.Name = "bottomShellsTextBox";
            this.bottomShellsTextBox.Size = new System.Drawing.Size(121, 20);
            this.bottomShellsTextBox.TabIndex = 18;
            // 
            // layerHeightTextBox
            // 
            this.layerHeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterSettingBindingSource, "LayerHeight", true));
            this.layerHeightTextBox.Location = new System.Drawing.Point(351, 59);
            this.layerHeightTextBox.Name = "layerHeightTextBox";
            this.layerHeightTextBox.Size = new System.Drawing.Size(121, 20);
            this.layerHeightTextBox.TabIndex = 20;
            // 
            // SettingsComboBox
            // 
            this.SettingsComboBox.DataSource = this.PrinterSettingBindingSource;
            this.SettingsComboBox.DisplayMember = "Name";
            this.SettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingsComboBox.FormattingEnabled = true;
            this.SettingsComboBox.Location = new System.Drawing.Point(351, 6);
            this.SettingsComboBox.Name = "SettingsComboBox";
            this.SettingsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SettingsComboBox.TabIndex = 22;
            this.SettingsComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingsComboBox_SelectedIndexChanged);
            // 
            // perimetersTextBox
            // 
            this.perimetersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterSettingBindingSource, "Perimeters", true));
            this.perimetersTextBox.Location = new System.Drawing.Point(351, 88);
            this.perimetersTextBox.Name = "perimetersTextBox";
            this.perimetersTextBox.Size = new System.Drawing.Size(121, 20);
            this.perimetersTextBox.TabIndex = 24;
            // 
            // topShellsTextBox
            // 
            this.topShellsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrinterSettingBindingSource, "TopShells", true));
            this.topShellsTextBox.Location = new System.Drawing.Point(351, 114);
            this.topShellsTextBox.Name = "topShellsTextBox";
            this.topShellsTextBox.Size = new System.Drawing.Size(121, 20);
            this.topShellsTextBox.TabIndex = 26;
            // 
            // heatbedEnabledCheckBox
            // 
            this.heatbedEnabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.FilamentBindingSource, "HeatbedEnabled", true));
            this.heatbedEnabledCheckBox.Location = new System.Drawing.Point(651, 33);
            this.heatbedEnabledCheckBox.Name = "heatbedEnabledCheckBox";
            this.heatbedEnabledCheckBox.Size = new System.Drawing.Size(121, 24);
            this.heatbedEnabledCheckBox.TabIndex = 28;
            this.heatbedEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // heatbedTemperatureTextBox
            // 
            this.heatbedTemperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FilamentBindingSource, "HeatbedTemperature", true));
            this.heatbedTemperatureTextBox.Location = new System.Drawing.Point(651, 63);
            this.heatbedTemperatureTextBox.Name = "heatbedTemperatureTextBox";
            this.heatbedTemperatureTextBox.Size = new System.Drawing.Size(121, 20);
            this.heatbedTemperatureTextBox.TabIndex = 30;
            // 
            // FilamentComboBox
            // 
            this.FilamentComboBox.DataSource = this.FilamentBindingSource;
            this.FilamentComboBox.DisplayMember = "Name";
            this.FilamentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilamentComboBox.FormattingEnabled = true;
            this.FilamentComboBox.Location = new System.Drawing.Point(651, 6);
            this.FilamentComboBox.Name = "FilamentComboBox";
            this.FilamentComboBox.Size = new System.Drawing.Size(121, 21);
            this.FilamentComboBox.TabIndex = 32;
            this.FilamentComboBox.SelectedIndexChanged += new System.EventHandler(this.FilamentComboBox_SelectedIndexChanged);
            // 
            // printTemperatureTextBox
            // 
            this.printTemperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FilamentBindingSource, "PrintTemperature", true));
            this.printTemperatureTextBox.Location = new System.Drawing.Point(651, 89);
            this.printTemperatureTextBox.Name = "printTemperatureTextBox";
            this.printTemperatureTextBox.Size = new System.Drawing.Size(121, 20);
            this.printTemperatureTextBox.TabIndex = 34;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 435);
            this.Controls.Add(heatbedEnabledLabel);
            this.Controls.Add(this.heatbedEnabledCheckBox);
            this.Controls.Add(heatbedTemperatureLabel);
            this.Controls.Add(this.heatbedTemperatureTextBox);
            this.Controls.Add(nameLabel2);
            this.Controls.Add(this.FilamentComboBox);
            this.Controls.Add(printTemperatureLabel);
            this.Controls.Add(this.printTemperatureTextBox);
            this.Controls.Add(bottomShellsLabel);
            this.Controls.Add(this.bottomShellsTextBox);
            this.Controls.Add(layerHeightLabel);
            this.Controls.Add(this.layerHeightTextBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.SettingsComboBox);
            this.Controls.Add(perimetersLabel);
            this.Controls.Add(this.perimetersTextBox);
            this.Controls.Add(topShellsLabel);
            this.Controls.Add(this.topShellsTextBox);
            this.Controls.Add(maxBuildXLabel);
            this.Controls.Add(this.maxBuildXTextBox);
            this.Controls.Add(maxBuildYLabel);
            this.Controls.Add(this.maxBuildYTextBox);
            this.Controls.Add(maxBuildZLabel);
            this.Controls.Add(this.maxBuildZTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.PrintersComboBox);
            this.Controls.Add(this.FilamentAddBtn);
            this.Controls.Add(this.SettingAddBtn);
            this.Controls.Add(this.PrinterAddBtn);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.AddImageButton);
            this.Name = "MainForm";
            this.Text = "SlicerConf";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrinterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterSettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource PrinterBindingSource;
        private System.Windows.Forms.BindingSource PrinterSettingBindingSource;
        private System.Windows.Forms.BindingSource FilamentBindingSource;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.BindingSource PictureBindingSource;
        private System.Windows.Forms.Button PrinterAddBtn;
        private System.Windows.Forms.Button SettingAddBtn;
        private System.Windows.Forms.Button FilamentAddBtn;
        private System.Windows.Forms.TextBox maxBuildXTextBox;
        private System.Windows.Forms.TextBox maxBuildYTextBox;
        private System.Windows.Forms.TextBox maxBuildZTextBox;
        private System.Windows.Forms.ComboBox PrintersComboBox;
        private System.Windows.Forms.TextBox bottomShellsTextBox;
        private System.Windows.Forms.TextBox layerHeightTextBox;
        private System.Windows.Forms.ComboBox SettingsComboBox;
        private System.Windows.Forms.TextBox perimetersTextBox;
        private System.Windows.Forms.TextBox topShellsTextBox;
        private System.Windows.Forms.CheckBox heatbedEnabledCheckBox;
        private System.Windows.Forms.TextBox heatbedTemperatureTextBox;
        private System.Windows.Forms.ComboBox FilamentComboBox;
        private System.Windows.Forms.TextBox printTemperatureTextBox;
    }
}

