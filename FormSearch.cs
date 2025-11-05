using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4_Variant16
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        public void ShowResults(List<DataGridViewRow> results)
        {
            dgwResults.Columns.Add("colLastName", "Фамилия");
            dgwResults.Columns.Add("colFirstName", "Имя");
            // Добавьте остальные колонки аналогично...

            foreach (DataGridViewRow row in results)
            {
                int newRowIndex = dgwResults.Rows.Add();
                dgwResults.Rows[newRowIndex].Cells[0].Value = row.Cells["colLastName"].Value;
                // Аналогично для остальных
            }
        }
    }
}