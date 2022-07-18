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
        [LoadColumn(0), ColumnName(@"Date")]
        public string Date { get; set; }

        [LoadColumn(1), ColumnName(@"Time")]
        public string Time { get; set; }

        [LoadColumn(2), ColumnName(@"BO")]
        public float BO { get; set; }

        [LoadColumn(3), ColumnName(@"BH")]
        public float BH { get; set; }

        [LoadColumn(4), ColumnName(@"BL")]
        public float BL { get; set; }

        [LoadColumn(5), ColumnName(@"BC")]
        public float BC { get; set; }

        [LoadColumn(6), ColumnName(@"BCh")]
        public float BCh { get; set; }

        [LoadColumn(7), ColumnName(@"AO")]
        public float AO { get; set; }

        [LoadColumn(8), ColumnName(@"AH")]
        public float AH { get; set; }

        [LoadColumn(9), ColumnName(@"AL")]
        public float AL { get; set; }

        [LoadColumn(10), ColumnName(@"AC")]
        public float AC { get; set; }

        [LoadColumn(11), ColumnName(@"ACh")]
        public float ACh { get; set; }
    }
}
