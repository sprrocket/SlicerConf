﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicerConf.Data
{
    public class dbHelper
    {
        SlicerConfDBModelContainer db = new SlicerConfDBModelContainer();
        public void AddPrinter(string name)
        {
            //SlicerConfDBModelContainer db = new SlicerConfDBModelContainer();
            Printer printer = new Printer { Name = name};
            db.Printers.Add(printer);
            db.SaveChanges();
        }

        public IQueryable GetPrinters()
        {
            //SlicerConfDBModelContainer db = new SlicerConfDBModelContainer();
            IQueryable<Printer> printersQuery = from p in db.Printers
                                                select p;
            return printersQuery;
        }

        public List<Printer> printersList()
        {
            List<Printer> p = (from b in db.Printers
                              select b).ToList();

            return p;
        }
    }
}
