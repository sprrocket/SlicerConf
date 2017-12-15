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
            this.printersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // printersComboBox
            // 
            this.printersComboBox.FormattingEnabled = true;
            this.printersComboBox.Location = new System.Drawing.Point(13, 13);
            this.printersComboBox.Name = "printersComboBox";
            this.printersComboBox.Size = new System.Drawing.Size(121, 21);
            this.printersComboBox.TabIndex = 0;
            this.printersComboBox.SelectedIndexChanged += new System.EventHandler(this.printersComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 368);
            this.Controls.Add(this.printersComboBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox printersComboBox;
    }
}

