using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace BLNavdurga
{
   public class BLAddExamNotes
    {
        public static DataTable GetData()
        {
            return BLAddExamNotes.GetData();
        }

        public static DataTable GetExamNotesType()
        {
            string sQuery = "Select 'All' examnotestype Union SELECT distinct examnotestype FROM db_navdurgahospital.tbl_examinationnotes;";
            return DLNavdurga.DLAddExamNotes.GetExamNotesType(sQuery);

        }

        public static DataTable GetExamNotesDetails(string sExamNotesType)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_examinationnotes;";
            if (sExamNotesType == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_examinationnotes;";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_examinationnotes where ExamNotesType = '" + sExamNotesType + "';";
            }
            return DLAddExamNotes.GetExamNotesDetails(sQuery);
        }

        public static DataTable GetExamNotes(string sExamNotesType)
        {
            string sQuery = "select Examnotes from db_navdurgahospital.tbl_examinationnotes;";
            if (sExamNotesType == "All")
            {
                sQuery = "select Examnotes from db_navdurgahospital.tbl_examinationnotes;";
            }
            else
            {
                sQuery = "select Examnotes from db_navdurgahospital.tbl_examinationnotes where Examnotestype= '" + sExamNotesType + "';";
            }
            return DLAddExamNotes.GetExamNotesDetails(sQuery);
        }

        public static bool SaveExamNotesDetails(DataTable dtExamNotes)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_examinationnotes;";
            return DLAddExamNotes.SaveExamNotesDetails(sQuery, dtExamNotes);
        }

    }
}
