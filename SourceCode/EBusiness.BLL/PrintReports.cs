using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace EBusiness.BLL
{
    public class PrintReports
    {
        private PrintDocument pDoc;
        private PrintPreviewDialog pPreviewDialog;
        DataGridView dGrid;
        


        public  void PrintReport(DataGridView dGrid)
        {
            this.dGrid = dGrid;
            pDoc = new PrintDocument();
            pDoc.PrintPage += new PrintPageEventHandler(pDoc_PrintPage);

            pPreviewDialog = new PrintPreviewDialog();
            pPreviewDialog.Document = pDoc;
            pPreviewDialog.Show();
            pDoc.Print();
        }
        void pDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = -110;
            int y = 30;
            int cell_height = 0;
            dGrid.ColumnHeadersVisible = true;
            int colCount = dGrid.ColumnCount;
            int rowCount = dGrid.RowCount;
            int current_col = 0;
            int current_row = 0;
            string value = "";
            Rectangle cell_border;
            SolidBrush brush = new SolidBrush(Color.Black);
            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    x += dGrid[current_col, current_row].Size.Width;
                    cell_height = dGrid[current_col, current_row].Size.Height;
                    cell_border = new Rectangle(x, y, dGrid[current_col, current_row].Size.Width, dGrid[current_col, current_row].Size.Height);
                    value = dGrid[current_col, current_row].Value.ToString();
                    g.DrawRectangle(new Pen(Color.Black), cell_border);
                    g.DrawString(value, new Font("tahoma", 6), brush, x, y);
                    current_col++;      //increment the currnet column
                }

                current_col = 0;
                current_row++;          //increment the current row
                x = -110;
                y += cell_height;
            }
        }
        
    }
}
