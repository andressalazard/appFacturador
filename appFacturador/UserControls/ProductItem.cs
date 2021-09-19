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

        private string _productTitle;
        private string _productCategory;
        private bool _isSelected;
        private int _selectedUnits;
        
        #endregion

        public ProductItem()
        {
            InitializeComponent();
        }


        #region Getter-Setter Methods

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
        private void btnDecrement_Click(object sender, EventArgs e)
        {
            this.DecrementUnitsValue();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            this.IncrementUnitsValue();
        }


        private void ckBoxProduct_CheckedChanged(object sender, EventArgs e)
        {
            this.reviewCheckStatus();
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
            if (units > 0)
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


        private void reviewCheckStatus() {
            if (ckBoxProduct.Checked == true)
            {
                this.EnableButtons();
                this.SelectedUnits = 0;
            }
            else {
                this.DisableButtons();
                this.ClearTxtValue();
            }
        }

        #endregion
    }
}
