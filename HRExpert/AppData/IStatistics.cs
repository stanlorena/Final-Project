using System;
using System.Collections.Generic;
using System.Text;

namespace AppData
{
    public interface IStatistics
    {
        public int GetNrFemei();
        public int GetNrBarbati();
        public int GetNrPersoane();
        public int GetNrContracte();
        public int GetContractePerNedeterminata();
        public int GetContractePerDeterminata();
        public double GetSalariuMediu();

    }
}
