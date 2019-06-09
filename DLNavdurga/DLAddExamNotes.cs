using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLNavdurga
{
    public class DLAddExamNotes
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetExamNotesType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static DataTable GetExamNotesDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static bool SaveExamNotesDetails(string sQuery, DataTable dtExamNotes)
        {
            return DLCommon.SaveDataTable(sQuery, dtExamNotes);
        }
    }
}
