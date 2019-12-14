using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace HeThongSapLich.Class
{
    class ExportToExcel
    {
        public void Export(DataTable dt, string sheetName, string title)
        {

            //Tạo các đối tượng Excel

            Excel.Application oExcel = new Excel.Application();

            Excel.Workbooks oBooks;

            Excel.Sheets oSheets;

            Excel.Workbook oBook;

            Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Excel.Range head = oSheet.get_Range("C1", "J1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Excel.Range cl1 = oSheet.get_Range("C5", "C5");
            cl1.Value2 = "Mã lịch";
            cl1.ColumnWidth = 15.0;

            Excel.Range cl2 = oSheet.get_Range("D5", "D5");
            cl2.Value2 = "Mã phòng";
            cl2.ColumnWidth = 12.0;

            Excel.Range cl3 = oSheet.get_Range("E5", "E5");
            cl3.Value2 = "Mã giảng viên";
            cl3.ColumnWidth = 15.0;

            Excel.Range cl4 = oSheet.get_Range("F5", "F5");
            cl4.Value2 = "Tên giảng viên";
            cl4.ColumnWidth = 36.0;

            Excel.Range cl5 = oSheet.get_Range("G5");
            cl5.Value2 = "Môn";
            cl5.ColumnWidth = 40.0;

            Excel.Range cl6 = oSheet.get_Range("H5", "H5");
            cl6.Value2 = "Mã LHP";
            cl6.ColumnWidth = 20.0;

            Excel.Range cl7 = oSheet.get_Range("I5", "I5");
            cl7.Value2 = "Ngày thi";
            cl7.ColumnWidth = 20.0;

            Excel.Range cl8 = oSheet.get_Range("J5", "J5");
            cl8.Value2 = "Ca thi";
            cl8.ColumnWidth = 10.0;

            Excel.Range rowHead = oSheet.get_Range("C5", "J5");
            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            string[,] arr = new string[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c].ToString();
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string[] temp = arr[i, 6].Split(' ');

                arr[i, 6] = temp[0];
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 6;

            int columnStart = 3;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = columnStart + dt.Columns.Count - 1;

            // Ô bắt đầu điền dữ liệu

            Excel.Range c1 = (Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Excel.Range c2 = (Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Excel.Range range = oSheet.get_Range(c1, c2);
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Excel.Range c3 = (Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
