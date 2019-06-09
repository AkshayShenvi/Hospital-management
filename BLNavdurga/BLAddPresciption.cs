using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DLNavdurga;

namespace BLNavdurga
{
    public class BLAddPresciption
    {
        public static DataTable GetData()
        {
            return BLAddPresciption.GetData();
        }

        public static DataTable GetMedicineType()
        {
            string sQuery = "Select 'All' MedicineType Union SELECT distinct MedicineType FROM db_navdurgahospital.tbl_prescription;";

            return DLNavdurga.DLAddPrescription.GetMedicineType(sQuery);
        }

        public static DataTable GetPrescriptionDetails(string sMedicineType)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_prescription;";
            if(sMedicineType == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_prescription;";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_prescription where MedicineType = '"+ sMedicineType+"';";
            }
            return DLAddPrescription.GetPrescriptionDetails(sQuery);
        }

        public static DataTable GetPrescription(string sMedicineType)
        {
            string sQuery = "select MedicineName from db_navdurgahospital.tbl_prescription;";
            if (sMedicineType == "All")
            {
                 sQuery = "select MedicineName from db_navdurgahospital.tbl_prescription;";
            }
            else
            {
                sQuery = "select MedicineName from db_navdurgahospital.tbl_prescription where MedicineType= '" + sMedicineType + "';";
            }
            return DLAddPrescription.GetPrescriptionDetails(sQuery);
        }

        public static bool SavePrescriptionDetails(DataTable dtPrescription)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_prescription;";
            return DLAddPrescription.SavePrescriptionDetails(sQuery, dtPrescription);
        }
    }
}