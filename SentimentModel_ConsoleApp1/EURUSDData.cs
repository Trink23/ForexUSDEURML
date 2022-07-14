using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentModel_ConsoleApp1
{
    internal class EURUSDData
    {
        [ColumnName(@"Date")]
        public string Date { get; set; }

        [ColumnName(@"Time")]
        public string Time { get; set; }

        [ColumnName(@"BO")]
        public float BO { get; set; }

        [ColumnName(@"BH")]
        public float BH { get; set; }

        [ColumnName(@"BL")]
        public float BL { get; set; }

        [ColumnName(@"BC")]
        public float BC { get; set; }

        [ColumnName(@"BCh")]
        public float BCh { get; set; }

        [ColumnName(@"AO")]
        public float AO { get; set; }

        [ColumnName(@"AH")]
        public float AH { get; set; }

        [ColumnName(@"AL")]
        public float AL { get; set; }

        [ColumnName(@"AC")]
        public float AC { get; set; }

        [ColumnName(@"ACh")]
        public float ACh { get; set; }
    }
}
