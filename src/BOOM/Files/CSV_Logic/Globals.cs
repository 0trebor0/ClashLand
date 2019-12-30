﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRepublic.Boom.Files.CSV_Helpers;
using CRepublic.Boom.Files.CSV_Reader;

namespace CRepublic.Boom.Files.CSV_Logic
{
    internal class Globals : Data
    {
        public Globals(Row _Row, DataTable _DataTable) : base(_Row, _DataTable)
        {
            Load(Row);
            //LoadData(this, this.GetType(), _Row);
        }
        public string Name { get; set; }
        public int NumberValue { get; set; }
        public bool BooleanValue { get; set; }
        public string TextValue { get; set; }
        public int[] NumberArray { get; set; }
    }
}
