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
            //SlicerConf.Data.SlicerConfDBModelContainer ctx = new Data.SlicerConfDBModelContainer();
            //var printerlist = (from r in ctx.Printers select r);
            //var namelist = (from t in printerlist select Name);
            //List<string> list = new List<string>();
            //foreach(SlicerConf.Data.Printer p in ctx.Printers)
            //{
            //    list.Add(p.Name);
            //}
            //printersComboBox.DataSource = list;
            

            SettingsComboBox.DataSource = PrinterSettingBindingSource;
            SettingsComboBox.DisplayMember = "Name";
            //MaxBuildXTextBox.DataBindings.Add("Text", PrinterBindingSource, "MaxBuildX");

        }

        private void PopulateSettingsComboBox()
        {
            //var settingList = from setting in ctx.PrinterSettings
            //                  where setting.PrinterId == ctx.Printers.Where(p=> p.Name == printersComboBox.Text).FirstOrDefault().Id
            //                  select setting;
            //printerSettingBindingSource.DataSource = settingList.ToList();
            PrinterSettingBindingSource.DataSource = (from setting in ctx.PrinterSettings
                                                      where setting.PrinterId == ctx.Printers.Where(p => p.Name == PrintersComboBox.Text).FirstOrDefault().Id
                                                      select setting).ToList();
        }

        private void PrintersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            PopulateSettingsComboBox();
            PrinterBindingSource.ResumeBinding();
        }

        private void SettingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrinterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //ctx.SaveChanges();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //preload database to context interface
            ctx.Printers.Load();
            ctx.PrinterSettings.Load();
            ctx.Filaments.Load();
            ctx.Pictures.Load();
            PrinterBindingSource.DataSource = ctx.Printers.Local.ToBindingList();//The right-hand expression: DbContext<POCO<ObservableList<BindingList
            //PrintersComboBox.DataSource = PrinterBindingSource;
            FilamentBindingSource.DataSource = ctx.Filaments.Local.ToBindingList();
            PopulateSettingsComboBox();
            
            

        }

        private void MaxBuildXTextBox_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
