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
    public partial class frmManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccountType(loginAccount.Type); }
        }

        public frmManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            loadTable();
            loadCategory();
        }

        #region Method
        void changeAccountType(int type)
        {
            if (type == 1)
            {
                itAdmin.Enabled = true;
            }
            else
            {
                itAdmin.Enabled = false;
            }
        }

        void loadTable()
        {
            flbTable.Controls.Clear();
            List<Table> listTable = TableDAO.Instance.loadTableList();
            foreach (Table item in listTable)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = item.Name + Environment.NewLine + "(" + item.Status + ")";
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Brown;
                        break;
                }


                flbTable.Controls.Add(btn);

            }
        }

        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
        }

        void loadDrinkbyCategoryId(int id)
        {
            List<Drink> listDrink = DrinkDAO.Instance.GetDrinkByCategoryID(id);
            cbDrink.DataSource = listDrink;
            cbDrink.DisplayMember = "name";
        }
        void ShowBill(int id)
        {
            lstvBill.Items.Clear();
            List<Menu> listMenu = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listMenu)
            {
                ListViewItem lstvItem = new ListViewItem(item.DrinkName.ToString());
                lstvItem.SubItems.Add(item.Count.ToString());
                lstvItem.SubItems.Add(item.Price.ToString());
                lstvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lstvBill.Items.Add(lstvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTotalPrice.Text = totalPrice.ToString("c1", culture);

        }
        #endregion

        #region Event
        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPay_Click(this, new EventArgs());
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(this, new EventArgs());
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lstvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);

        }

        private void itLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itPersonalInfo_Click(object sender, EventArgs e)
        {
            frmAccountInfo frmAccountInfo = new frmAccountInfo(LoginAccount);

            frmAccountInfo.ShowDialog();

        }

        private void itAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.InsertDrink += frmAdmin_InsertDrink;
            frmAdmin.DeleteDrink += frmAdmin_DeleteDrink;
            frmAdmin.UpdateDrink += frmAdmin_UpdateDrink;

            frmAdmin.InsertCategory += frmAdmin_InsertCategory;
            frmAdmin.DeleteCategory += frmAdmin_DeleteCategory;
            frmAdmin.UpdateCategory += frmAdmin_UpdateCategory;

            frmAdmin.InsertTable += frmAdmin_InsertTable;
            frmAdmin.DeleteTable += frmAdmin_DeleteTable;
            frmAdmin.UpdateTable += frmAdmin_UpdateTable;

            frmAdmin.loginAccount = LoginAccount;
            frmAdmin.ShowDialog();
        }

        #region EventHandle Category
        private void frmAdmin_UpdateCategory(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            loadTable();
            loadCategory();
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }
        }

        private void frmAdmin_DeleteCategory(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            loadTable();
            loadCategory();
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }
        }

        private void frmAdmin_InsertCategory(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            loadTable();
            loadCategory();
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }
        }
        #endregion

        #region EventHandle Drink
        private void frmAdmin_UpdateDrink(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }

        }

        private void frmAdmin_DeleteDrink(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }

            loadTable();
        }

        private void frmAdmin_InsertDrink(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }

        }
        #endregion

        #region EventHandle Table
        private void frmAdmin_UpdateTable(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            loadTable();
            loadCategory();
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }
        }

        private void frmAdmin_DeleteTable(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            loadTable();
            loadCategory();
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }
        }

        private void frmAdmin_InsertTable(object? sender, EventArgs e)
        {
            loadDrinkbyCategoryId((cbCategory.SelectedItem as Category).ID);
            loadTable();
            loadCategory();
            if (lstvBill.Tag != null)
            {
                ShowBill((lstvBill.Tag as Table).ID);
            }
        }

        #endregion
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            Category selected = cb.SelectedItem as Category;
            if (cb.SelectedItem == null)
            {
                return;
            }
            id = selected.ID;
            loadDrinkbyCategoryId(id);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = lstvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.ID);
            int idDrink = (cbDrink.SelectedItem as Drink).ID;
            int count = (int)nbDrinkCount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), idDrink, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idDrink, count);
            }
            ShowBill(table.ID);
            loadTable();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Table table = lstvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableId(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(",")[0]);
            double finalPrice = Convert.ToDouble(totalPrice - ((totalPrice / 100) * discount));
            string text = finalPrice.ToString("c");
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có muốn thanh toán cho bàn {0}\n Tổng tiền (Đã bao gồm giảm giá)= {1}đ", table.Name, text), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.Checkout(idBill, discount, (float)finalPrice);
                    ShowBill(table.ID);
                    loadTable();
                }
            }

        }

        #endregion

        
    }
}
