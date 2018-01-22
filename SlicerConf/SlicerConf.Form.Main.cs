using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using SlicerConf.Biz;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlicerConf
{
    public partial class MainForm : Form
    {
        Data.SlicerConfDBModelContainer ctx = new Data.SlicerConfDBModelContainer();
        public MainForm()
        {
            InitializeComponent();
        }

        private void PopulateSettingsComboBox()
        {
            int currentId = ((Data.Printer)PrinterBindingSource.Current).Id;
            PrinterSettingBindingSource.DataSource = (from setting in ctx.PrinterSettings
                                                      where setting.PrinterId == currentId
                                                      select setting).ToList();
        }

        private void PrintersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void SettingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrinterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PopulateSettingsComboBox();
            ctx.SaveChanges();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //preload database to context interface
            ctx.Printers.Load();
            ctx.PrinterSettings.Load();
            ctx.Filaments.Load();
            ctx.Pictures.Load();

            //TODO: Add dev note for ObservableList/BindingList usage
            //The right-hand expression below: DbContext < POCO < ObservableList < BindingList
            PrinterBindingSource.DataSource = ctx.Printers.Local.ToBindingList();
            FilamentBindingSource.DataSource = ctx.Filaments.Local.ToBindingList();
            //PopulateSettingsComboBox(); //not needed, populates when PrinterSettingsBox inits
            PictureBindingSource.DataSource = ctx.Pictures.Local.ToBindingList();
            //PictureBindingSource.DataSource = Biz.ImageHelper.ConvertByteToImage((from b in ctx.Pictures select b.img).FirstOrDefault());
            

        }

        private void MaxBuildXTextBox_Validated(object sender, EventArgs e)
        {
            
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "OpenImage"
            };
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                ExamplePictureBox.ImageLocation = dlg.FileName;
                byte[] imageToPut = ImageHelper.ConvertFileToByteArray(dlg.FileName);
                ctx.Pictures.Add(new Data.Picture { Name = "test", img = ImageHelper.ConvertFileToByteArray(dlg.FileName)});
                ctx.SaveChanges();
            }

        }

        private void PictureBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MaxBuildXTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ctx.SaveChanges();
        }

        private void PrinterAddBtn_Click(object sender, EventArgs e)
        {
            AddItemDialog addPrinterDialog = new AddItemDialog
            {
                Text = "Add Printer"
            };
            //addPrinterDialog.ShowDialog(this);
            if (addPrinterDialog.ShowDialog() == DialogResult.OK) {
                this.ctx.Printers.Add(new Data.Printer { Name = addPrinterDialog.NewItemName.Text });
                this.ctx.SaveChanges();
            }

        }
    }
}
