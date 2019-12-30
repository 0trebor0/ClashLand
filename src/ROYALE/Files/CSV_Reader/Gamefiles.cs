﻿namespace CRepublic.Royale.Files.CSV_Reader
{
    using CRepublic.Royale.Files.CSV_Helpers;
    using System.Collections.Generic;
    using CRepublic.Royale.Logic.Enums;


    internal class Gamefiles
    {
        internal readonly Dictionary<int, DataTable> DataTables = new Dictionary<int, DataTable>();


        internal Gamefiles()
        {
            this.DataTables = new Dictionary<int, DataTable>(CSV.Gamefiles.Count);
        }

        internal DataTable Get(int _Index)
        {
            return this.DataTables[_Index];
        }

        internal DataTable Get(Gamefile _Index)
        {
            return this.DataTables[(int)_Index];
        }

        internal Data GetWithGlobalID(int GlobalID)
        {
            int Type = 0;

            while (GlobalID >= 1000000)
            {
                Type += 1;
                GlobalID -= 1000000;
            }

            return this.DataTables[Type].GetDataWithInstanceID(GlobalID);
        }

        internal void Initialize(Table _Table, int _Index)
        {
            this.DataTables.Add(_Index, new DataTable(_Table, _Index));
        }
    }
}