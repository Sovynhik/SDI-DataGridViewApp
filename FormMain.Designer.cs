using System.Drawing;
using System.Windows.Forms;

namespace Lab4_Variant16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnBrowsePhoto = new System.Windows.Forms.Button();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutMain.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutMain
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            this.tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            this.tableLayoutMain.Controls.Add(this.panelInput, 0, 0);
            this.tableLayoutMain.Controls.Add(this.dgwUsers, 1, 0);
            this.tableLayoutMain.Controls.Add(this.panelButtons, 0, 1);
            this.tableLayoutMain.Controls.Add(this.panelSearch, 1, 1);
            this.tableLayoutMain.Dock = DockStyle.Fill;
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            this.tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            // panelInput
            this.panelInput.ColumnCount = 2;
            this.panelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            this.panelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.panelInput.Controls.Add(this.lblLastName, 0, 0);
            this.panelInput.Controls.Add(this.txtLastName, 1, 0);
            this.panelInput.Controls.Add(this.lblFirstName, 0, 1);
            this.panelInput.Controls.Add(this.txtFirstName, 1, 1);
            this.panelInput.Controls.Add(this.lblMiddleName, 0, 2);
            this.panelInput.Controls.Add(this.txtMiddleName, 1, 2);
            this.panelInput.Controls.Add(this.lblActive, 0, 3);
            this.panelInput.Controls.Add(this.cbActive, 1, 3);
            this.panelInput.Controls.Add(this.lblRegDate, 0, 4);
            this.panelInput.Controls.Add(this.dtpRegDate, 1, 4);
            this.panelInput.Controls.Add(this.lblGender, 0, 5);
            this.panelInput.Controls.Add(this.cmbGender, 1, 5);
            this.panelInput.Controls.Add(this.lblPhoto, 0, 6);
            this.panelInput.Controls.Add(this.pbPhoto, 1, 6);
            this.panelInput.Controls.Add(this.btnBrowsePhoto, 1, 7);
            this.panelInput.Dock = DockStyle.Fill;
            this.panelInput.RowCount = 8;
            for (int i = 0; i < 8; i++) this.panelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));

            // Labels
            this.lblLastName.Text = "Фамилия:"; this.lblLastName.AutoSize = true; this.lblLastName.Anchor = AnchorStyles.Right;
            this.lblFirstName.Text = "Имя:"; this.lblFirstName.AutoSize = true; this.lblFirstName.Anchor = AnchorStyles.Right;
            this.lblMiddleName.Text = "Отчество:"; this.lblMiddleName.AutoSize = true; this.lblMiddleName.Anchor = AnchorStyles.Right;
            this.lblActive.Text = "Активен:"; this.lblActive.AutoSize = true; this.lblActive.Anchor = AnchorStyles.Right;
            this.lblRegDate.Text = "Дата рег.:"; this.lblRegDate.AutoSize = true; this.lblRegDate.Anchor = AnchorStyles.Right;
            this.lblGender.Text = "Пол:"; this.lblGender.AutoSize = true; this.lblGender.Anchor = AnchorStyles.Right;
            this.lblPhoto.Text = "Фото:"; this.lblPhoto.AutoSize = true; this.lblPhoto.Anchor = AnchorStyles.Right;

            // Input controls
            this.txtLastName.Dock = DockStyle.Fill;
            this.txtFirstName.Dock = DockStyle.Fill;
            this.txtMiddleName.Dock = DockStyle.Fill;
            this.cbActive.AutoSize = true;
            this.dtpRegDate.Format = DateTimePickerFormat.Short;
            this.dtpRegDate.Dock = DockStyle.Fill;
            this.cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbGender.Dock = DockStyle.Fill;
            this.pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbPhoto.BorderStyle = BorderStyle.FixedSingle;
            this.pbPhoto.Dock = DockStyle.Fill;
            this.btnBrowsePhoto.Text = "Обзор...";
            this.btnBrowsePhoto.Dock = DockStyle.Top;
            this.btnBrowsePhoto.Click += btnBrowsePhoto_Click;

            // dgwUsers
            this.dgwUsers.Dock = DockStyle.Fill;

            // panelButtons
            this.panelButtons.ColumnCount = 3;
            for (int i = 0; i < 3; i++) this.panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.panelButtons.RowCount = 2;
            for (int i = 0; i < 2; i++) this.panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelButtons.Controls.Add(this.btnAdd, 0, 0);
            this.panelButtons.Controls.Add(this.btnEdit, 1, 0);
            this.panelButtons.Controls.Add(this.btnDelete, 2, 0);
            this.panelButtons.Controls.Add(this.btnClear, 0, 1);
            this.panelButtons.Controls.Add(this.btnSaveXml, 1, 1);
            this.panelButtons.Controls.Add(this.btnLoadXml, 2, 1);
            this.panelButtons.Dock = DockStyle.Fill;

            // Buttons
            this.btnAdd.Text = "Добавить"; this.btnAdd.Dock = DockStyle.Fill; this.btnAdd.Click += btnAdd_Click;
            this.btnEdit.Text = "Изменить"; this.btnEdit.Dock = DockStyle.Fill; this.btnEdit.Click += btnEdit_Click;
            this.btnDelete.Text = "Удалить"; this.btnDelete.Dock = DockStyle.Fill; this.btnDelete.Click += btnDelete_Click;
            this.btnClear.Text = "Очистить"; this.btnClear.Dock = DockStyle.Fill; this.btnClear.Click += btnClear_Click;
            this.btnSaveXml.Text = "Сохранить XML"; this.btnSaveXml.Dock = DockStyle.Fill; this.btnSaveXml.Click += btnSaveXml_Click;
            this.btnLoadXml.Text = "Загрузить XML"; this.btnLoadXml.Dock = DockStyle.Fill; this.btnLoadXml.Click += btnLoadXml_Click;

            // panelSearch
            this.panelSearch.Dock = DockStyle.Fill;
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.lblSearch.Text = "Поиск:"; this.lblSearch.AutoSize = true;
            this.txtSearch.Width = 200;
            this.btnSearch.Text = "Найти"; this.btnSearch.Click += btnSearch_Click;

            // Form
            this.ClientSize = new Size(900, 500);
            this.Controls.Add(this.tableLayoutMain);
            this.Text = "База пользователей (Вариант 16)";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.tableLayoutMain.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel panelInput;
        private Label lblLastName, lblFirstName, lblMiddleName, lblActive, lblRegDate, lblGender, lblPhoto;
        private TextBox txtLastName, txtFirstName, txtMiddleName, txtSearch;
        private CheckBox cbActive;
        private DateTimePicker dtpRegDate;
        private ComboBox cmbGender;
        private PictureBox pbPhoto;
        private Button btnBrowsePhoto;
        private DataGridView dgwUsers;
        private TableLayoutPanel panelButtons;
        private Button btnAdd, btnEdit, btnDelete, btnClear, btnSaveXml, btnLoadXml;
        private FlowLayoutPanel panelSearch;
        private Label lblSearch;
        private Button btnSearch;
    }
}