using Lab4_Variant16;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab4_Variant16
{
    public partial class FormMain : Form
    {
        private DataSet ds = new DataSet();
        private string xmlFilePath = "users.xml";

        public FormMain()
        {
            InitializeComponent();
            // Инициализация DataGridView
            dgwUsers.CellClick += dgwUsers_CellClick;
            dgwUsers.MultiSelect = false;
            dgwUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwUsers.AllowUserToAddRows = false;
            dgwUsers.AllowUserToDeleteRows = false;
            // Загрузка данных при старте, если файл существует
            if (File.Exists(xmlFilePath))
            {
                LoadFromXml();
            }
        }

        // Обработчик щелчка по ячейке (заполнение полей для редактирования)
        private void dgwUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwUsers.SelectedRows.Count > 0)
            {
                txtLastName.Text = dgwUsers.SelectedRows[0].Cells["colLastName"].Value.ToString();
                txtFirstName.Text = dgwUsers.SelectedRows[0].Cells["colFirstName"].Value.ToString();
                txtMiddleName.Text = dgwUsers.SelectedRows[0].Cells["colMiddleName"].Value.ToString();
                cbActive.Checked = (bool)dgwUsers.SelectedRows[0].Cells["colActive"].Value;
                dtpRegDate.Value = (DateTime)dgwUsers.SelectedRows[0].Cells["colRegDate"].Value;
                cmbGender.Text = dgwUsers.SelectedRows[0].Cells["colGender"].Value.ToString();
                // Для изображения (если есть)
                pbPhoto.Image = (Image)dgwUsers.SelectedRows[0].Cells["colPhoto"].Value;
            }
        }

        // Кнопка "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rowIndex = dgwUsers.Rows.Add();
            dgwUsers.Rows[rowIndex].Cells["colLastName"].Value = txtLastName.Text;
            dgwUsers.Rows[rowIndex].Cells["colFirstName"].Value = txtFirstName.Text;
            dgwUsers.Rows[rowIndex].Cells["colMiddleName"].Value = txtMiddleName.Text;
            dgwUsers.Rows[rowIndex].Cells["colActive"].Value = cbActive.Checked;
            dgwUsers.Rows[rowIndex].Cells["colRegDate"].Value = dtpRegDate.Value;
            dgwUsers.Rows[rowIndex].Cells["colGender"].Value = cmbGender.Text;
            dgwUsers.Rows[rowIndex].Cells["colPhoto"].Value = pbPhoto.Image;
            ClearFields();
        }

        // Кнопка "Изменить"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count > 0)
            {
                dgwUsers.SelectedRows[0].Cells["colLastName"].Value = txtLastName.Text;
                dgwUsers.SelectedRows[0].Cells["colFirstName"].Value = txtFirstName.Text;
                dgwUsers.SelectedRows[0].Cells["colMiddleName"].Value = txtMiddleName.Text;
                dgwUsers.SelectedRows[0].Cells["colActive"].Value = cbActive.Checked;
                dgwUsers.SelectedRows[0].Cells["colRegDate"].Value = dtpRegDate.Value;
                dgwUsers.SelectedRows[0].Cells["colGender"].Value = cmbGender.Text;
                dgwUsers.SelectedRows[0].Cells["colPhoto"].Value = pbPhoto.Image;
                ClearFields();
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.");
            }
        }

        // Кнопка "Удалить"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count > 0)
            {
                dgwUsers.Rows.Remove(dgwUsers.SelectedRows[0]);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }

        // Кнопка "Очистить таблицу"
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgwUsers.Rows.Clear();
            ClearFields();
        }

        // Кнопка "Сохранить как XML"
        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            SaveToXml();
        }

        // Кнопка "Загрузить XML"
        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            LoadFromXml();
        }

        // Кнопка "Поиск" (по фамилии, вывод в модальном окне)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            List<DataGridViewRow> results = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgwUsers.Rows)
            {
                if (row.Cells["colLastName"].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    results.Add(row);
                }
            }
            formSearch.ShowResults(results);
            formSearch.ShowDialog();
        }

        // Метод сохранения в XML
        private void SaveToXml()
        {
            DataTable dt = new DataTable("Users");
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("Active", typeof(bool));
            dt.Columns.Add("RegDate", typeof(DateTime));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Photo", typeof(Image));

            foreach (DataGridViewRow row in dgwUsers.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["LastName"] = row.Cells["colLastName"].Value;
                dr["FirstName"] = row.Cells["colFirstName"].Value;
                dr["MiddleName"] = row.Cells["colMiddleName"].Value;
                dr["Active"] = row.Cells["colActive"].Value;
                dr["RegDate"] = row.Cells["colRegDate"].Value;
                dr["Gender"] = row.Cells["colGender"].Value;
                dr["Photo"] = row.Cells["colPhoto"].Value;
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);
            try
            {
                ds.WriteXml(xmlFilePath);
                MessageBox.Show("Данные сохранены в XML.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        // Метод загрузки из XML
        private void LoadFromXml()
        {
            if (dgwUsers.Rows.Count > 0)
            {
                if (MessageBox.Show("Таблица не пуста. Очистить?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgwUsers.Rows.Clear();
                }
                else
                {
                    return;
                }
            }

            if (File.Exists(xmlFilePath))
            {
                ds.ReadXml(xmlFilePath);
                if (ds.Tables.Contains("Users"))
                {
                    DataTable dt = ds.Tables["Users"];
                    foreach (DataRow dr in dt.Rows)
                    {
                        int rowIndex = dgwUsers.Rows.Add();
                        dgwUsers.Rows[rowIndex].Cells["colLastName"].Value = dr["LastName"];
                        dgwUsers.Rows[rowIndex].Cells["colFirstName"].Value = dr["FirstName"];
                        dgwUsers.Rows[rowIndex].Cells["colMiddleName"].Value = dr["MiddleName"];
                        dgwUsers.Rows[rowIndex].Cells["colActive"].Value = dr["Active"];
                        dgwUsers.Rows[rowIndex].Cells["colRegDate"].Value = dr["RegDate"];
                        dgwUsers.Rows[rowIndex].Cells["colGender"].Value = dr["Gender"];
                        dgwUsers.Rows[rowIndex].Cells["colPhoto"].Value = dr["Photo"];
                    }
                    MessageBox.Show("Данные загружены из XML.");
                }
            }
            else
            {
                MessageBox.Show("XML-файл не найден.");
            }
        }

        // Очистка полей ввода
        private void ClearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            cbActive.Checked = false;
            dtpRegDate.Value = DateTime.Now;
            cmbGender.Text = "";
            pbPhoto.Image = null;
        }
    }
}