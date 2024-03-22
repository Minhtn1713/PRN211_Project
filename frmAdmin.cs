using CoffeeShopManager.DAO;
using CoffeeShopManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManager
{
    public partial class frmAdmin : Form
    {
        BindingSource drinkList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountlist = new BindingSource();
        public Account loginAccount;
        public frmAdmin()
        {
            InitializeComponent();
            loadAll();
        }
        #region Method
        void loadAll()
        {
            dgvDrink.DataSource = drinkList;
            dgvAccount.DataSource = accountlist;
            dgvCategory.DataSource = categoryList;
            dgvTable.DataSource = tableList;
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            loadListBillByDate(dtpFromDate.Value, dtpEndDate.Value);
            loadDateTimePickerBill();
            loadListDrink();
            LoadAccount();
            addDrinkBinding();
            loadListCategory();
            loadCategoryToComboBox(cbDrinkCategory);
            loadListTable();
            addFinalPriceCol();
        }
        #region Drink
        List<Drink> SearchDrinkByName(string name)
        {
            List<Drink> listdrinks = DrinkDAO.Instance.SearchDrinkByName(name);

            return listdrinks;
        }
        void loadListDrink()
        {
            drinkList.DataSource = DrinkDAO.Instance.GetListDrink();

        }
        void addDrinkBinding()
        {
            txtDrinkName.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtDrinkID.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Category
        void loadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();
            txtCategoryID.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        void loadCategoryToComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
            cb.Refresh();
        }
        #endregion

        #region Account
        void LoadAccount()
        {
            accountlist.DataSource = AccountDAO.Instance.GetListAccount();
            txtAccountUsername.DataBindings.Clear();
            txtAccountDisplayName.DataBindings.Clear();
            nbAccountType.DataBindings.Clear();
            txtAccountUsername.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "userName", true, DataSourceUpdateMode.Never));
            txtAccountDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "displayName", true, DataSourceUpdateMode.Never));
            nbAccountType.DataBindings.Add(new Binding("Value", dgvAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }
        void addAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.checkAccountExist(txtAccountUsername.Text) == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }
            if (AccountDAO.Instance.InsertAccountAdmin(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
            LoadAccount();
        }
        void updateAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccountAdmin(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật khoản thất bại!");
            }
            LoadAccount();
        }
        void deleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Không thể xóa tài khoản đang được đăng nhập");
                return;
            }
            if (AccountDAO.Instance.DeleteAccountAdmin(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa nhật khoản thất bại!");
            }
            LoadAccount();
        }
        void resetPassword(string userName)
        {
            if (AccountDAO.Instance.resetPassword(userName))
            {
                MessageBox.Show("Đặt mật khẩu về mặc định thành công");
            }
            else
            {
                MessageBox.Show("Đặt mật khẩu về mặc định thất bại!");
            }
            LoadAccount();
        }
        #endregion

        #region Bill
        void loadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpEndDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void loadListBillByDate(DateTime dateCheckin, DateTime dateCheckout)
        {
            dgvBill.DataSource = BillDAO.Instance.GetListBillByDate(dateCheckin, dateCheckout);

        }
        double DgvSum(int cellIndex)
        {
            double sum = 0;
            for (int i = 0; i < dgvBill.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvBill.Rows[i].Cells[cellIndex].Value);
            }
            return sum;
        }
        void addFinalPriceCol()
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "finalPrice";
            column.Name = "Tổng cuối";
            dgvBill.Columns.Add(column);
        }

        #endregion

        #region Table
        void loadListTable()
        {
            tableList.DataSource = TableDAO.Instance.loadTableList();
            txtTableID.DataBindings.Clear();
            txtTableName.DataBindings.Clear();
            txtTableID.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTableName.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #endregion

        #region Events 
        #region frmAdmin
        private void frmAdmin_Shown(object sender, EventArgs e)
        {
            btnSearchBill.PerformClick();
        }
        #endregion

        #region Bill
        private void btnSearchBill_Click(object sender, EventArgs e)
        {

            loadListBillByDate(dtpFromDate.Value, dtpEndDate.Value);
            double sum = DgvSum(5);
            dgvBill.Rows[0].Cells[0].Value = sum.ToString("c");
            dgvBill.Columns[5].DefaultCellStyle.Format = "c";
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            dgvBill.SelectAll();
            DataObject copydata = dgvBill.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            object missdata = System.Reflection.Missing.Value;
            workbook = application.Workbooks.Add(missdata);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, 1];
            xlr.Select();
            worksheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        #endregion

        #region Drink
        private void btnViewDrink_Click(object sender, EventArgs e)
        {
            loadListDrink();
        }
        private void btnAddDrink_Click(object sender, EventArgs e)
        {

            string name = txtDrinkName.Text;
            if (DrinkDAO.Instance.checkDrinkExist(name) == 1)
            {
                MessageBox.Show("Đồ uống đã tồn tại");
                return;
            }
            int idCategory = (cbDrinkCategory.SelectedItem as Category).ID;
            double price = Convert.ToDouble(txtPrice.Text);
            if (DrinkDAO.Instance.InsertDrink(name, idCategory, price))
            {
                MessageBox.Show("Thêm thành công");
                loadListDrink();
                if (insertDrink != null)
                {
                    insertDrink(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }
        private void btnEditDrink_Click(object sender, EventArgs e)
        {
            string name = txtDrinkName.Text;
            int idCategory = (cbDrinkCategory.SelectedItem as Category).ID;
            double price = Convert.ToDouble(txtPrice.Text);
            int idDrink = Convert.ToInt32(txtDrinkID.Text);
            if (DrinkDAO.Instance.UpdateDrink(idDrink, name, idCategory, price))
            {
                MessageBox.Show("Sửa thành công");
                loadListDrink();
                if (insertDrink != null)
                {
                    insertDrink(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa");
            }

            loadCategoryToComboBox(cbDrinkCategory);
        }
        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            int idDrink = Convert.ToInt32(txtDrinkID.Text);
            if (DrinkDAO.Instance.DeleteDrink(idDrink))
            {
                MessageBox.Show("Xóa thành công");
                loadListDrink();
                if (deleteDrink != null)
                {
                    deleteDrink(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
            loadCategoryToComboBox(cbDrinkCategory);
        }
        private void txtDrinkID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDrink.SelectedCells.Count > 0)
                {
                    int id = (int)dgvDrink.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cbDrinkCategory.Refresh();
                    cbDrinkCategory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbDrinkCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbDrinkCategory.SelectedIndex = index;
                }
            }
            catch { }
        }
        private void btnSearchDrink_Click(object sender, EventArgs e)
        {
            drinkList.DataSource = SearchDrinkByName(txtSearchDrinkName.Text);
        }

        #endregion

        #region Category
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            if (CategoryDAO.Instance.checkCategoryExist(name) == 1)
            {
                MessageBox.Show("Danh mục đã tồn tại");
                return;
            }
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm thành công");
                loadListCategory();
                if (insertCategory != null)
                {
                    insertCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
            loadCategoryToComboBox(cbDrinkCategory);
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int idCategory = Convert.ToInt32(txtCategoryID.Text);
            if (CategoryDAO.Instance.UpdateCategory(name, idCategory))
            {
                MessageBox.Show("Sửa thành công");
                loadListCategory();
                if (updateCategory != null)
                {
                    updateCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa");
            }
            loadCategoryToComboBox(cbDrinkCategory);
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int idCategory = Convert.ToInt32(txtCategoryID.Text);
            if (CategoryDAO.Instance.DeleteCategory(idCategory))
            {
                MessageBox.Show("Xóa thành công");
                loadListCategory();
                if (deleteCategory != null)
                {
                    deleteCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
            loadCategoryToComboBox(cbDrinkCategory);
        }
        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            loadListCategory();
        }
        #endregion

        #region Table
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            if (TableDAO.Instance.checkTableExist(name) == 1)
            {
                MessageBox.Show("Bàn đã tồn tại");
                return;
            }
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm thành công");
                loadListCategory();
                if (insertTable != null)
                {
                    insertTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
            loadListTable();
        }
        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txtTableName.Text;
            int idTable = Convert.ToInt32(txtTableID.Text);
            if (TableDAO.Instance.UpdateTable(idTable, name))
            {
                MessageBox.Show("Sửa thành công");
                loadListCategory();
                if (updateTable != null)
                {
                    updateTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
            loadListTable();
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int idTable = Convert.ToInt32(txtTableID.Text);
            if (TableDAO.Instance.DeleteTable(idTable))
            {
                MessageBox.Show("Xóa thành công");
                loadListCategory();
                if (deleteTable != null)
                {
                    deleteTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
            loadListTable();
        }
        private void btnViewTable_Click(object sender, EventArgs e)
        {
            loadListTable();
        }
        #endregion

        #region Account
        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void txbAccountType_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAddAcount_Click(object sender, EventArgs e)
        {
            string userName = txtAccountUsername.Text;
            string displayName = txtAccountDisplayName.Text;
            int type = Convert.ToInt32(nbAccountType.Value);
            addAccount(userName, displayName, type);
        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txtAccountUsername.Text;
            string displayName = txtAccountDisplayName.Text;
            int type = Convert.ToInt32(nbAccountType.Value);
            updateAccount(userName, displayName, type);
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtAccountUsername.Text;
            deleteAccount(userName);
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtAccountUsername.Text;
            resetPassword(userName);
        }
        #endregion
        #endregion

        #region EventHandler
        #region Category
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        #endregion
        #region Drink
        private event EventHandler insertDrink;
        public event EventHandler InsertDrink
        {
            add { insertDrink += value; }
            remove { insertDrink -= value; }
        }

        private event EventHandler deleteDrink;
        public event EventHandler DeleteDrink
        {
            add { deleteDrink += value; }
            remove { deleteDrink -= value; }
        }

        private event EventHandler updateDrink;
        public event EventHandler UpdateDrink
        {
            add { updateDrink += value; }
            remove { updateDrink -= value; }
        }
        #endregion
        #region Table
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }













        #endregion

        #endregion
    }
}
