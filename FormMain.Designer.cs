namespace Lab4_Variant16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPhoto = new System.Windows.Forms.DataGridViewImageColumn();
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
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutMain.Controls.Add(this.panelInput, 0, 0);
            this.tableLayoutMain.Controls.Add(this.dgwUsers, 1, 0);
            this.tableLayoutMain.Controls.Add(this.panelButtons, 0, 1);
            this.tableLayoutMain.Controls.Add(this.panelSearch, 1, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMain.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // panelInput
            // 
            this.panelInput.ColumnCount = 2;
            this.panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(3, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.RowCount = 8;
            for (int i = 0; i < 7; i++)
                this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelInput.Size = new System.Drawing.Size(308, 368);
            this.panelInput.TabIndex = 0;
            // 
            // dgwUsers
            // 
            this.dgwUsers.AllowUserToAddRows = false;
            this.dgwUsers.AllowUserToDeleteRows = false;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colActive,
            this.colRegDate,
            this.colGender,
            this.colPhoto});
            this.dgwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUsers.Location = new System.Drawing.Point(317, 3);
            this.dgwUsers.MultiSelect = false;
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUsers.Size = new System.Drawing.Size(580, 368);
            this.dgwUsers.TabIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Фамилия";
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 120;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "Имя";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Width = 100;
            // 
            // colMiddleName
            // 
            this.colMiddleName.HeaderText = "Отчество";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Width = 120;
            // 
            // colActive
            // 
            this.colActive.HeaderText = "Активен";
            this.colActive.Name = "colActive";
            // 
            // colRegDate
            // 
            this.colRegDate.HeaderText = "Дата регистрации";
            this.colRegDate.Name = "colRegDate";
            this.colRegDate.Width = 130;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Пол";
            this.colGender.Name = "colGender";
            this.colGender.Items.AddRange(new object[] { "М", "Ж" });
            // 
            // colPhoto
            // 
            this.colPhoto.HeaderText = "Фото";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colPhoto.Width = 80;
            // 
            // panelButtons
            // 
            this.panelButtons.ColumnCount = 3;
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.panelButtons.Controls.Add(this.btnAdd, 0, 0);
            this.panelButtons.Controls.Add(this.btnEdit, 1, 0);
            this.panelButtons.Controls.Add(this.btnDelete, 2, 0);
            this.panelButtons.Controls.Add(this.btnClear, 0, 1);
            this.panelButtons.Controls.Add(this.btnSaveXml, 1, 1);
            this.panelButtons.Controls.Add(this.btnLoadXml, 2, 1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 377);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.RowCount = 2;
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButtons.Size = new System.Drawing.Size(308, 120);
            this.panelButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 54);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(317, 377);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(580, 120);
            this.panelSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Поиск:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База пользователей (Вариант 16)";
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

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel panelInput;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnBrowsePhoto;
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGender;
        private System.Windows.Forms.DataGridViewImageColumn colPhoto;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.FlowLayoutPanel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}