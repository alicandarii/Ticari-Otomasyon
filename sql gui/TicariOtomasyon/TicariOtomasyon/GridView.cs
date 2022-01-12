using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace TicariOtomasyon
{
     class GridView
    {
        public void GridDesigner(DataGridView gridView)
        {
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(83, 195, 237);
            gridView.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            gridView.DefaultCellStyle.BackColor = Color.FromArgb(196, 223, 186);
            gridView.DefaultCellStyle.SelectionBackColor = Color.White;
            gridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 53, 71);
        }
    }
}
