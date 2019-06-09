using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NavdurgaHospital
{
    public partial class PrintBill : Form
    {
        Bitmap bitmap;

        public PrintBill()
        {
            InitializeComponent();

            
        }

        private void PrintBill_Load(object sender, EventArgs e)
        {
            //BindDataGridView();
        }

        //private void BindDataGridView()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
        //                        new DataColumn("Name", typeof(string)),
        //                        new DataColumn("Country",typeof(string)) });
        //    dt.Rows.Add(1, "John Hammond", "United States");
        //    dt.Rows.Add(2, "Mudassar Khan", "India");
        //    dt.Rows.Add(3, "Suzanne Mathews", "France");
        //    dt.Rows.Add(4, "Robert Schidner", "Russia");
        //    this.dataGridView1.DataSource = dt;
        //}

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Add a Panel control.
            Panel panel = new Panel();
            this.Controls.Add(panel);

            //Create a Bitmap of size same as that of the Form.
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);

            //Copy screen area that that the Panel covers.
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            //Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
