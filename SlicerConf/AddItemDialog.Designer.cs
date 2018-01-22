namespace SlicerConf
{
    partial class AddItemDialog
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
            this.NewItemName = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewItemName
            // 
            this.NewItemName.Location = new System.Drawing.Point(13, 13);
            this.NewItemName.Name = "NewItemName";
            this.NewItemName.Size = new System.Drawing.Size(170, 20);
            this.NewItemName.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(189, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddItemDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 50);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NewItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddItemDialog";
            this.Text = "AddItemDialog";
            this.Load += new System.EventHandler(this.AddItemDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBtn;
        public System.Windows.Forms.TextBox NewItemName;
    }
}