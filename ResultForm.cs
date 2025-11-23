using System.Collections.Generic;
using System.Windows.Forms;

namespace PhoneBook_V16
{
    // Форма для отображения результатов поиска
    public partial class ResultForm : Form
    {
        /// <summary>
        /// Конструктор формы, принимающий список строк DataGridView для отображения.
        /// </summary>
        /// <param name="rows">Список строк DataGridView, найденных при поиске.</param>
        public ResultForm(List<DataGridViewRow> rows)
        {
            InitializeComponent();

            // Заполнение таблицы результатов данными из списка
            foreach (DataGridViewRow row in rows)
            {
                int n = dgvResult.Rows.Add();
                dgvResult.Rows[n].Cells["LastName"].Value = row.Cells["LastName"].Value;
                dgvResult.Rows[n].Cells["FirstName"].Value = row.Cells["FirstName"].Value;
                dgvResult.Rows[n].Cells["Patronymic"].Value = row.Cells["Patronymic"].Value;
                dgvResult.Rows[n].Cells["Organization"].Value = row.Cells["Organization"].Value;
                dgvResult.Rows[n].Cells["Phone"].Value = row.Cells["Phone"].Value;
            }
        }
    }
}