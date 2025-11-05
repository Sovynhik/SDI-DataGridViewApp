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

        public void ShowResults(List<DataGridViewRow> rows)
        {
            dgwResults.Rows.Clear();
            dgwResults.Columns.Clear();

            // Добавляем столбцы
            dgwResults.Columns.Add("colLastName", "Фамилия");
            dgwResults.Columns.Add("colFirstName", "Имя");
            dgwResults.Columns.Add("colMiddleName", "Отчество");
            dgwResults.Columns.Add("colGender", "Пол");

            // Заполняем строки
            foreach (var row in rows)
            {
                dgwResults.Rows.Add(
                    row.Cells["colLastName"].Value,
                    row.Cells["colFirstName"].Value,
                    row.Cells["colMiddleName"].Value,
                    row.Cells["colGender"].Value
                );
            }
        }
    }
}