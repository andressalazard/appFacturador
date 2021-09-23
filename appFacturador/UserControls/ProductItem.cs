using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFacturador.UserControls
{
    public partial class ProductItem : UserControl
    {
        #region Attributes

        private int _productID;
        private string _productTitle;
        private string _productCategory;
        private decimal _productPrice;
        private bool _isSelected;
        private int _selectedUnits;

        public event EventHandler<ProductItem> ProductIsSelectedEvent;
        
        #endregion

        public ProductItem()
        {
            InitializeComponent();
            this.IsSelected = false;
        }

        public ProductItem(int prodID, string prodTitle, decimal prodPrice, string prodCategory) {
            Console.WriteLine($"prodID: {prodID}, prodTitle: {prodTitle}, prodPrice: {prodPrice}, prodCategory: {prodCategory}");


            InitializeComponent();
            this.ProductID = prodID;
            this.ProductTitle = prodTitle;
            this.ProductPrice = prodPrice;
            this.ProductCategory = prodCategory;
            this.IsSelected = false;

            
        }



        #region Getter-Setter Methods

        

        
        [Category("Custom Props")]
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }


        [Category("Custom Props")]
        public string ProductTitle
        {
            get { return _productTitle; }
            set { _productTitle = value;  lblProductTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string ProductCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; lblProductCategory.Text = $"({value})"; }
        }

        [Category("Custom Props")]
        public decimal ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; lblProductPrice.Text = $"{String.Format("${0:0.00}",value)}"; }
        }



        [Category("Custom Props")]
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }

        [Category("Custom Props")]
        public int SelectedUnits
        {
            get { return _selectedUnits; }
            set { _selectedUnits = value; txtProductUnits.Text = Convert.ToString(value); }
        }

        #endregion

        #region EventsHandlers
       
        private void ckBoxProduct_CheckedChanged_1(object sender, EventArgs e)
        {
            this.reviewCheckStatus();
        }

        private void btnDecrement_Click_1(object sender, EventArgs e)
        {
            this.DecrementUnitsValue();
            ProductIsSelectedEvent?.Invoke(this, this);
        }

        private void btnIncrement_Click_1(object sender, EventArgs e)
        {
            this.IncrementUnitsValue();
            ProductIsSelectedEvent?.Invoke(this, this);
        }

        #endregion

        #region Component-Methods
        private void IncrementUnitsValue() {
            int units = this.SelectedUnits;
            if (units < 10) {
                this.SelectedUnits++;
            } 
        }

        private void DecrementUnitsValue() {
            int units = this.SelectedUnits;
            if (units > 1)
            {
                this.SelectedUnits--;
            }
        }

        private void DisableButtons() {
            btnDecrement.Enabled = false;
            btnIncrement.Enabled = false;
        }

        private void EnableButtons() {
            btnIncrement.Enabled = true;
            btnDecrement.Enabled = true;
        }

        private void ClearTxtValue() {
            txtProductUnits.Text = "";
        }

        public void ResetProductItem() {
            DisableItem();
            ckBoxProduct.Checked = false;
            ProductIsSelectedEvent?.Invoke(this, this);
        }

        private void DisableItem() {
            this.DisableButtons();
            this.ClearTxtValue();
            this.IsSelected = false;
            this.lblSelected.Visible = false;
        }


        private void reviewCheckStatus() {
            if (ckBoxProduct.Checked == true)
            {
                this.lblSelected.Visible = true;
                this.EnableButtons();
                this.SelectedUnits = 1;
                this.IsSelected = true;
            }
            else {
                DisableItem();
            }
            ProductIsSelectedEvent?.Invoke(this, this);
        }

        #endregion
    }
}
