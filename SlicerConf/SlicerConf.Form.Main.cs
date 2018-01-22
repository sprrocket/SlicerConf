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

        private void PopulatePictureBox()
        {
            if (FilamentBindingSource.Current != null && PrinterBindingSource.Current != null && PrinterSettingBindingSource != null)
            {
                var queryable = from picture in ctx.Pictures
                                where picture.PrinterId == ((Data.Printer)PrinterBindingSource.Current).Id &&
                                picture.PrinterSettingId == ((Data.PrinterSetting)PrinterSettingBindingSource.Current).Id &&
                                picture.FilamentId == ((Data.Filament)FilamentBindingSource.Current).Id
                                select picture;
                if (!queryable.Any()) { PictureBox.Image = null; }
                else
                {
                    PictureBox.Image = Image.FromStream(new MemoryStream(queryable.Single().img));
                }
            }
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

        private void FilamentComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                PictureBox.ImageLocation = dlg.FileName;
                byte[] imageToPut = ImageHelper.ConvertFileToByteArray(dlg.FileName);
                ctx.Pictures.Add(new Data.Picture {
                    Name = "test", img = ImageHelper.ConvertFileToByteArray(dlg.FileName),
                    FilamentId = ((Data.Filament)FilamentBindingSource.Current).Id,
                    PrinterId= ((Data.Printer)PrinterBindingSource.Current).Id,
                    PrinterSettingId=((Data.PrinterSetting)PrinterSettingBindingSource.Current).Id
                });
                ctx.SaveChanges();
            }

        }

        private void PictureBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PopulatePictureBox();
        }

        private void MaxBuildXTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ctx.SaveChanges();
        }

        private void PrinterAddBtn_Click(object sender, EventArgs e)
        {
            AddItemDialog dlg = new AddItemDialog
            {
                Text = "Add Printer"
            };
            if (dlg.ShowDialog() == DialogResult.OK) {
                if (!(from printer in ctx.Printers where printer.Name == dlg.NewItemName.Text select printer).Any())
                {
                    ctx.Printers.Add(new Data.Printer { Name = dlg.NewItemName.Text });
                    ctx.SaveChanges();
                    PrintersComboBox.SelectedIndex = PrintersComboBox.FindStringExact(dlg.NewItemName.Text);
                }
                else
                {
                    MessageBox.Show("Duplicate Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SettingAddBtn_Click(object sender, EventArgs e)
        {
            AddItemDialog dlg = new AddItemDialog
            {
                Text = "Add Setting"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!(from setting in ctx.PrinterSettings where setting.Name == dlg.NewItemName.Text select setting).Any())
                {
                    ctx.PrinterSettings.Add(new Data.PrinterSetting {
                        Name = dlg.NewItemName.Text,
                        PrinterId = ((Data.Printer)PrinterBindingSource.Current).Id
                    });
                    ctx.SaveChanges();
                    SettingsComboBox.SelectedIndex = SettingsComboBox.FindStringExact(dlg.NewItemName.Text);
                }
                else
                {
                    MessageBox.Show("Duplicate Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FilamentAddBtn_Click(object sender, EventArgs e)
        {
            AddItemDialog dlg = new AddItemDialog
            {
                Text = "Add Setting"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!(from filament in ctx.Filaments where filament.Name == dlg.NewItemName.Text select filament).Any())
                {
                    ctx.Filaments.Add(new Data.Filament
                    {
                        Name = dlg.NewItemName.Text
                    });
                    ctx.SaveChanges();
                    FilamentComboBox.SelectedIndex = FilamentComboBox.FindStringExact(dlg.NewItemName.Text);
                }
                else
                {
                    MessageBox.Show("Duplicate Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PopulatePictureBox();
        }
    }
}
