using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PhoneBook_V16
{
    // Главная форма приложения "Телефонная книга"
    public partial class MainForm : Form
    {
        // Путь к XML-файлу для сохранения/загрузки данных
        private readonly string xmlFilePath = "phonebook.xml";

        // Конструктор формы
        public MainForm()
        {
            InitializeComponent();
            LoadXmlIfExists();
        }

        // Проверяет наличие файла phonebook.xml и загружает данные, если он существует
        private void LoadXmlIfExists()
        {
            if (File.Exists(xmlFilePath))
                LoadFromXml();
        }

        // Обработчик события: при выборе строки в таблице заполняет поля ввода
        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                var row = dgvContacts.SelectedRows[0];
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtPatronymic.Text = row.Cells["Patronymic"].Value?.ToString() ?? "";
                txtOrganization.Text = row.Cells["Organization"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            }
        }

        // Обработчик кнопки: Добавление новой записи в таблицу
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Фамилия и имя обязательны!", "Ошибка");
                return;
            }

            // Добавляем новую строку и заполняем ее данными из полей ввода
            int n = dgvContacts.Rows.Add();
            dgvContacts.Rows[n].Cells["LastName"].Value = txtLastName.Text.Trim();
            dgvContacts.Rows[n].Cells["FirstName"].Value = txtFirstName.Text.Trim();
            dgvContacts.Rows[n].Cells["Patronymic"].Value = txtPatronymic.Text.Trim();
            dgvContacts.Rows[n].Cells["Organization"].Value = txtOrganization.Text.Trim();
            dgvContacts.Rows[n].Cells["Phone"].Value = txtPhone.Text.Trim();

            // Перемещаем фокус на новую строку
            dgvContacts.FirstDisplayedScrollingRowIndex = n;
            dgvContacts.CurrentCell = dgvContacts.Rows[n].Cells[0];
            dgvContacts.Rows[n].Selected = true;

            ClearInputFields();
        }

        // Обработчик кнопки: Редактирование выбранной записи
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для редактирования.", "Внимание");
                return;
            }

            // Обновляем данные выбранной строки
            var row = dgvContacts.SelectedRows[0];
            row.Cells["LastName"].Value = txtLastName.Text.Trim();
            row.Cells["FirstName"].Value = txtFirstName.Text.Trim();
            row.Cells["Patronymic"].Value = txtPatronymic.Text.Trim();
            row.Cells["Organization"].Value = txtOrganization.Text.Trim();
            row.Cells["Phone"].Value = txtPhone.Text.Trim();

            ClearInputFields();
        }

        // Обработчик кнопки: Удаление выбранной записи
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.", "Внимание");
                return;
            }

            dgvContacts.Rows.Remove(dgvContacts.SelectedRows[0]);
        }

        // Обработчик кнопки: Очистка всей таблицы
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvContacts.Rows.Count > 0 &&
                MessageBox.Show("Очистить всю таблицу?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvContacts.Rows.Clear();
            }
        }

        // Обработчик кнопки: Вызов метода сохранения в XML
        private void btnSave_Click(object sender, EventArgs e) => SaveToXml();

        // Обработчик кнопки: Вызов метода загрузки из XML
        private void btnLoad_Click(object sender, EventArgs e) => LoadFromXml();

        // Обработчик кнопки: Поиск контактов по названию организации
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Введите название организации для поиска.", "Поиск");
                return;
            }

            // Ищем строки, где название организации совпадает с поисковым запросом
            var results = dgvContacts.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Organization"].Value?.ToString()
                    .Equals(query, StringComparison.OrdinalIgnoreCase) == true)
                .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("По указанной организации ничего не найдено.", "Результат");
                return;
            }

            // Открываем форму с результатами поиска
            new ResultForm(results).ShowDialog();
        }

        // Очищает все текстовые поля ввода на форме
        private void ClearInputFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPatronymic.Clear();
            txtOrganization.Clear();
            txtPhone.Clear();
            txtSearch.Clear(); // Очистка поля поиска после использования
        }

        // Сохраняет данные из DataGridView в XML-файл
        private void SaveToXml()
        {
            if (dgvContacts.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста — нечего сохранять.", "Сохранение");
                return;
            }

            try
            {
                // Создание структур DataSet/DataTable
                var ds = new DataSet("PhoneBook");
                var dt = new DataTable("Contact");
                dt.Columns.Add("LastName", typeof(string));
                dt.Columns.Add("FirstName", typeof(string));
                dt.Columns.Add("Patronymic", typeof(string));
                dt.Columns.Add("Organization", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                ds.Tables.Add(dt);

                // Копирование данных из DataGridView в DataTable
                foreach (DataGridViewRow r in dgvContacts.Rows)
                {
                    var row = dt.NewRow();
                    row["LastName"] = r.Cells["LastName"].Value?.ToString() ?? "";
                    row["FirstName"] = r.Cells["FirstName"].Value?.ToString() ?? "";
                    row["Patronymic"] = r.Cells["Patronymic"].Value?.ToString() ?? "";
                    row["Organization"] = r.Cells["Organization"].Value?.ToString() ?? "";
                    row["Phone"] = r.Cells["Phone"].Value?.ToString() ?? "";
                    dt.Rows.Add(row);
                }

                // Запись в XML-файл
                ds.WriteXml(xmlFilePath, XmlWriteMode.WriteSchema);
                MessageBox.Show("Данные успешно сохранены в phonebook.xml", "Готово");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка");
            }
        }

        // Загружает данные из XML-файла в DataGridView
        private void LoadFromXml()
        {
            if (!File.Exists(xmlFilePath))
            {
                MessageBox.Show("Файл phonebook.xml не найден.", "Ошибка");
                return;
            }

            // Запрос на очистку перед загрузкой, если таблица не пуста
            if (dgvContacts.Rows.Count > 0)
            {
                if (MessageBox.Show("Таблица не пуста. Очистить перед загрузкой?", "Загрузка", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                dgvContacts.Rows.Clear();
            }

            try
            {
                // Чтение данных из XML-файла
                var ds = new DataSet();
                ds.ReadXml(xmlFilePath);

                // Проверка наличия таблицы "Contact"
                if (!ds.Tables.Contains("Contact"))
                {
                    MessageBox.Show("Файл XML не содержит таблицу 'Contact'.", "Ошибка");
                    return;
                }

                // Заполнение DataGridView данными из DataTable
                foreach (DataRow row in ds.Tables["Contact"].Rows)
                {
                    int n = dgvContacts.Rows.Add();
                    dgvContacts.Rows[n].Cells["LastName"].Value = row["LastName"];
                    dgvContacts.Rows[n].Cells["FirstName"].Value = row["FirstName"];
                    dgvContacts.Rows[n].Cells["Patronymic"].Value = row["Patronymic"];
                    dgvContacts.Rows[n].Cells["Organization"].Value = row["Organization"];
                    dgvContacts.Rows[n].Cells["Phone"].Value = row["Phone"];
                }

                MessageBox.Show("Данные успешно загружены из phonebook.xml", "Готово");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка");
            }
        }
    }
}