using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab4_Variant16
{
    public partial class FormMain : Form
    {
        private readonly string xmlFilePath = "users.xml";

        public FormMain()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadXmlIfExists();
        }

        private void ConfigureDataGridView()
        {
            dgwUsers.Columns.Clear();

            // === Столбцы ===
            dgwUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLastName",
                HeaderText = "Фамилия",
                Width = 120
            });

            dgwUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFirstName",
                HeaderText = "Имя",
                Width = 100
            });

            dgwUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMiddleName",
                HeaderText = "Отчество",
                Width = 120
            });

            dgwUsers.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colActive",
                HeaderText = "Активен",
                Width = 70
            });

            dgwUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRegDate",
                HeaderText = "Дата регистрации",
                Width = 130
            });

            var colGender = new DataGridViewComboBoxColumn
            {
                Name = "colGender",
                HeaderText = "Пол",
                Width = 80
            };
            colGender.Items.Add("Мужской");
            colGender.Items.Add("Женский");
            dgwUsers.Columns.Add(colGender);

            dgwUsers.Columns.Add(new DataGridViewImageColumn
            {
                Name = "colPhoto",
                HeaderText = "Фото",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 80
            });

            // === Настройки ===
            dgwUsers.CellClick += DgwUsers_CellClick;
            dgwUsers.MultiSelect = false;
            dgwUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwUsers.AllowUserToAddRows = false;
            dgwUsers.AllowUserToDeleteRows = false;
        }

        private void LoadXmlIfExists()
        {
            if (File.Exists(xmlFilePath))
                LoadFromXml();
        }

        private void DgwUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwUsers.SelectedRows.Count == 0) return;

            var row = dgwUsers.SelectedRows[0];
            txtLastName.Text = row.Cells["colLastName"].Value?.ToString() ?? "";
            txtFirstName.Text = row.Cells["colFirstName"].Value?.ToString() ?? "";
            txtMiddleName.Text = row.Cells["colMiddleName"].Value?.ToString() ?? "";
            cbActive.Checked = row.Cells["colActive"].Value is bool b && b;
            dtpRegDate.Value = row.Cells["colRegDate"].Value is DateTime dt ? dt : DateTime.Now;
            cmbGender.Text = row.Cells["colGender"].Value?.ToString() ?? "";
            pbPhoto.Image = row.Cells["colPhoto"].Value as Image;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idx = dgwUsers.Rows.Add();
            FillRow(dgwUsers.Rows[idx]);
            ClearInputFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FillRow(dgwUsers.SelectedRows[0]);
            ClearInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgwUsers.Rows.Remove(dgwUsers.SelectedRows[0]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgwUsers.Rows.Count > 0 && MessageBox.Show("Очистить всю таблицу?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgwUsers.Rows.Clear();
            }
        }

        private void btnSaveXml_Click(object sender, EventArgs e) => SaveToXml();
        private void btnLoadXml_Click(object sender, EventArgs e) => LoadFromXml();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var results = new System.Collections.Generic.List<DataGridViewRow>();
            string query = txtSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgwUsers.Rows)
            {
                if (row.Cells["colLastName"].Value?.ToString().ToLower().Contains(query) == true)
                {
                    results.Add(row);
                }
            }

            using (var form = new FormSearch())
            {
                form.ShowResults(results);
                form.ShowDialog();
            }
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbPhoto.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void FillRow(DataGridViewRow row)
        {
            row.Cells["colLastName"].Value = txtLastName.Text;
            row.Cells["colFirstName"].Value = txtFirstName.Text;
            row.Cells["colMiddleName"].Value = txtMiddleName.Text;
            row.Cells["colActive"].Value = cbActive.Checked;
            row.Cells["colRegDate"].Value = dtpRegDate.Value;
            row.Cells["colGender"].Value = cmbGender.Text;
            row.Cells["colPhoto"].Value = pbPhoto.Image;
        }

        private void ClearInputFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            cbActive.Checked = false;
            dtpRegDate.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            pbPhoto.Image = null;
        }

        private void SaveToXml()
        {
            var ds = new DataSet();
            var dt = new DataTable("Users");
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("Active", typeof(bool));
            dt.Columns.Add("RegDate", typeof(DateTime));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Photo", typeof(byte[]));

            foreach (DataGridViewRow row in dgwUsers.Rows)
            {
                var dr = dt.NewRow();
                dr["LastName"] = row.Cells["colLastName"].Value;
                dr["FirstName"] = row.Cells["colFirstName"].Value;
                dr["MiddleName"] = row.Cells["colMiddleName"].Value;
                dr["Active"] = row.Cells["colActive"].Value;
                dr["RegDate"] = row.Cells["colRegDate"].Value;
                dr["Gender"] = row.Cells["colGender"].Value;

                if (row.Cells["colPhoto"].Value is Image img)
                {
                    using (var ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        dr["Photo"] = ms.ToArray();
                    }
                }
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);
            try
            {
                ds.WriteXml(xmlFilePath);
                MessageBox.Show("Данные сохранены в users.xml", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void LoadFromXml()
        {
            if (!File.Exists(xmlFilePath))
            {
                MessageBox.Show("Файл users.xml не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgwUsers.Rows.Count > 0)
            {
                if (MessageBox.Show("Таблица не пуста. Очистить перед загрузкой?", "Загрузка", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                dgwUsers.Rows.Clear();
            }

            var ds = new DataSet();
            ds.ReadXml(xmlFilePath);

            if (!ds.Tables.Contains("Users")) return;

            foreach (DataRow dr in ds.Tables["Users"].Rows)
            {
                int idx = dgwUsers.Rows.Add();
                var row = dgwUsers.Rows[idx];
                row.Cells["colLastName"].Value = dr["LastName"];
                row.Cells["colFirstName"].Value = dr["FirstName"];
                row.Cells["colMiddleName"].Value = dr["MiddleName"];
                row.Cells["colActive"].Value = dr["Active"];
                row.Cells["colRegDate"].Value = dr["RegDate"];
                row.Cells["colGender"].Value = dr["Gender"];

                if (dr["Photo"] is byte[] bytes && bytes.Length > 0)
                {
                    using (var ms = new MemoryStream(bytes))
                    {
                        row.Cells["colPhoto"].Value = Image.FromStream(ms);
                    }
                }
            }

            MessageBox.Show("Данные загружены из users.xml", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}