using SlicerConf.Biz;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
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
            PictureBindingSource.DataSource = ctx.Pictures.Local.ToBindingList();


        }

        private void PrinterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PrinterSettingBindingSource.DataSource = (from setting in ctx.PrinterSettings
                                                      where setting.PrinterId == ((Data.Printer)PrinterBindingSource.Current).Id
                                                      select setting).ToList();
        }

        private void PictureBindingSource_CurrentChanged(object sender, EventArgs e)//Called every time the other entries are changed
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
                    PictureBox.Image = Image.FromStream(new MemoryStream(queryable.First().img));
                }
            }
        }

        private void EditImageButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Open Image"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var queryable = from picture in ctx.Pictures    //query for an existing image
                                where picture.PrinterId == ((Data.Printer)PrinterBindingSource.Current).Id &&
                                picture.PrinterSettingId == ((Data.PrinterSetting)PrinterSettingBindingSource.Current).Id &&
                                picture.FilamentId == ((Data.Filament)FilamentBindingSource.Current).Id
                                select picture;

                PictureBox.ImageLocation = dlg.FileName;
                byte[] imageToPut = ImageHelper.ConvertFileToByteArray(dlg.FileName);

                //if no items were found in the query, add new entry
                if (!queryable.Any()) {
                    ctx.Pictures.Add(new Data.Picture
                    {
                        Name = "test",
                        img = ImageHelper.ConvertFileToByteArray(dlg.FileName),
                        FilamentId = ((Data.Filament)FilamentBindingSource.Current).Id,
                        PrinterId = ((Data.Printer)PrinterBindingSource.Current).Id,
                        PrinterSettingId = ((Data.PrinterSetting)PrinterSettingBindingSource.Current).Id
                    });
                    ctx.SaveChanges();
                }
                //if a query came up with a result, replace the image
                else
                {
                    queryable.First().img = ImageHelper.ConvertFileToByteArray(dlg.FileName);
                }
                
            }
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
    }
}
