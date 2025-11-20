using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace DVLD_System_Version2
{

    static internal class clsMyWFL
    {
        static internal void DealWithException(ref Exception exception)
        {
            if( exception != null)
            {
                MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!EventLog.SourceExists("DVLDSystemApp"))
                {
                    EventLog.CreateEventSource("DVLDSystemApp", "Application");
                }
                EventLog.WriteEntry("DVLDSystemApp",exception.Message,EventLogEntryType.Error);
                exception = null;
            }
        }

        static internal void ChangeDataGridViewColumnsLayout(DataGridView tabel,DataGridViewAutoSizeColumnMode Mode)
        {
            foreach(DataGridViewColumn column in tabel.Columns)
            {
                column.AutoSizeMode = Mode;
            }
        }
        /*static internal void ChangeDataGridViewColumnsLayout(Guna2DataGridView tabel, DataGridViewAutoSizeColumnMode Mode)
        {
            foreach (DataGridViewColumn column in tabel.Columns)
            {
                column.AutoSizeMode = Mode;
            }
        }*/
        /*static internal void IncreaseDataGridViewFontSize(Guna2DataGridView tabel, float Seed)
        {
            if (tabel.Font.Size > 26) return;
            tabel.Font = new System.Drawing.Font(tabel.Font.FontFamily, tabel.Font.Size + Seed,
                tabel.Font.Style, tabel.Font.Unit, tabel.Font.GdiCharSet, tabel.Font.GdiVerticalFont);
            tabel.RowsDefaultCellStyle.Font = new System.Drawing.Font(
                tabel.RowsDefaultCellStyle.Font.FontFamily,
                tabel.RowsDefaultCellStyle.Font.Size + Seed,
                tabel.RowsDefaultCellStyle.Font.Style,
                tabel.RowsDefaultCellStyle.Font.Unit,
                tabel.RowsDefaultCellStyle.Font.GdiCharSet,
                tabel.RowsDefaultCellStyle.Font.GdiVerticalFont);
            ChangeDataGridViewRowsHeight(tabel, tabel.Rows[0].Height + (int)(Seed > 4 ? (Seed / 4) : 1));


        }*/
        static internal void IncreaseDataGridViewFontSize(DataGridView tabel, float Seed)
        {
            if (tabel.Font.Size > 26) return;
            tabel.Font = new System.Drawing.Font(tabel.Font.FontFamily, tabel.Font.Size + Seed,
                tabel.Font.Style, tabel.Font.Unit, tabel.Font.GdiCharSet, tabel.Font.GdiVerticalFont);

            tabel.RowsDefaultCellStyle.Font = new System.Drawing.Font(
                tabel.RowsDefaultCellStyle.Font.FontFamily,
                tabel.RowsDefaultCellStyle.Font.Size + Seed,
                tabel.RowsDefaultCellStyle.Font.Style,
                tabel.RowsDefaultCellStyle.Font.Unit,
                tabel.RowsDefaultCellStyle.Font.GdiCharSet,
                tabel.RowsDefaultCellStyle.Font.GdiVerticalFont);
            //ChangeDataGridViewRowsHeight(tabel, tabel.Rows[0].Height + (int)(Seed > 4 ? (Seed / 4) : 1));

        }
        static internal void DecreaseDataGridViewFontSize(DataGridView tabel, float Seed)
        {
            if (tabel.Font.Size < 6) return;
            tabel.Font = new System.Drawing.Font(tabel.Font.FontFamily, tabel.Font.Size - Seed,
                tabel.Font.Style, tabel.Font.Unit, tabel.Font.GdiCharSet, tabel.Font.GdiVerticalFont);
            tabel.RowsDefaultCellStyle.Font = new System.Drawing.Font(
                tabel.RowsDefaultCellStyle.Font.FontFamily,
                tabel.RowsDefaultCellStyle.Font.Size - Seed,
                tabel.RowsDefaultCellStyle.Font.Style,
                tabel.RowsDefaultCellStyle.Font.Unit,
                tabel.RowsDefaultCellStyle.Font.GdiCharSet,
                tabel.RowsDefaultCellStyle.Font.GdiVerticalFont);


        }
        /*static internal void DecreaseDataGridViewFontSize(Guna2DataGridView tabel, float Seed)
        {
            if (tabel.Font.Size < 6) return;
            tabel.Font = new System.Drawing.Font(tabel.Font.FontFamily, tabel.Font.Size - Seed,
                tabel.Font.Style, tabel.Font.Unit, tabel.Font.GdiCharSet, tabel.Font.GdiVerticalFont);
            tabel.RowsDefaultCellStyle.Font = new System.Drawing.Font(
                tabel.RowsDefaultCellStyle.Font.FontFamily,
                tabel.RowsDefaultCellStyle.Font.Size - Seed,
                tabel.RowsDefaultCellStyle.Font.Style,
                tabel.RowsDefaultCellStyle.Font.Unit,
                tabel.RowsDefaultCellStyle.Font.GdiCharSet,
                tabel.RowsDefaultCellStyle.Font.GdiVerticalFont);


        }*/
        static internal void FillComboBoxFromDataTable(ComboBox comboBox, DataTable dataTable,string ColumnName)
        {
            foreach(DataRow Row in dataTable.Rows)
            {
                comboBox.Items.Add(Row[ColumnName]);
            }
        }
        /*static internal void FillComboBoxFromDataTable(Guna2ComboBox comboBox, DataTable dataTable, string ColumnName)
        {
            foreach (DataRow Row in dataTable.Rows)
            {
                comboBox.Items.Add(Row[ColumnName]);
            }
        }*/
        static internal void CenterControlInParentVertically(Control control,Control Parent)
        {
            control.Location = new Point
                (control.Location.X, Parent.Size.Height / 2 - control.Height / 2);
        }
        static internal void CenterControlInParentHorizontally(Control control, Control Parent)
        {
            control.Location = new Point
                (Parent.Size.Width / 2 - control.Width / 2, control.Location.Y);

        }
        static internal void CenterControlInParent(Control control, Control Parent)
        {
            CenterControlInParentHorizontally (control, Parent);
            CenterControlInParentVertically (control, Parent);

        }
        static internal void ChangeDataGridViewColumnsWidth(DataGridView table,int Width)
        {
            foreach(DataGridViewColumn Column in table.Columns)
            {
                Column.Width = Width;
            }
        }
        static internal void ChangeDataGridViewRowsHeight(DataGridView table, int Height)
        {
            foreach(DataGridViewRow Row in table.Rows)
            {
                Row.Height = Height;
            }
        }
    }
}
