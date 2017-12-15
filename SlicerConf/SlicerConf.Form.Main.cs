using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlicerConf
{
    public partial class MainForm : Form
    {
        SlicerConf.Data.SlicerConfDBModelContainer ctx = new Data.SlicerConfDBModelContainer();
        public MainForm()
        {
            InitializeComponent();
        }

        private void PopulateSettingsComboBox()
        {
            //I'M SO SMART FOR THIS
            //IT READS THE PRINTER DROPDOWN
            //AND SELECTS ONLY THE PRINTERSETTINGS WITH MATCHING ID'S
            //asdjfkaljsdfkjasdlkfjafs
            PrinterSettingBindingSource.DataSource = (from setting in ctx.PrinterSettings
                                                      where setting.PrinterId == ctx.Printers.Where(p => p.Name == PrintersComboBox.Text).FirstOrDefault().Id
                                                      select setting).ToList();
        }

        private void PrintersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            PopulateSettingsComboBox();
        }

        private void SettingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrinterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //preload database to context interface
            ctx.Printers.Load();
            ctx.PrinterSettings.Load();
            ctx.Filaments.Load();
            ctx.Pictures.Load();

            PrinterBindingSource.DataSource = ctx.Printers.Local.ToBindingList();//The right-hand expression: DbContext<POCO<ObservableList<BindingList
            FilamentBindingSource.DataSource = ctx.Filaments.Local.ToBindingList();
            PopulateSettingsComboBox();
            
            

        }

        private void MaxBuildXTextBox_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
