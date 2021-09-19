
namespace appFacturador.UserControls
{
    partial class ProductItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckBoxProduct = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProductUnits = new System.Windows.Forms.TextBox();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ckBoxProduct);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 70);
            this.panel1.TabIndex = 0;
            // 
            // ckBoxProduct
            // 
            this.ckBoxProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckBoxProduct.Location = new System.Drawing.Point(0, 0);
            this.ckBoxProduct.Name = "ckBoxProduct";
            this.ckBoxProduct.Padding = new System.Windows.Forms.Padding(16);
            this.ckBoxProduct.Size = new System.Drawing.Size(49, 70);
            this.ckBoxProduct.TabIndex = 2;
            this.ckBoxProduct.UseVisualStyleBackColor = true;
            this.ckBoxProduct.CheckedChanged += new System.EventHandler(this.ckBoxProduct_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblProductCategory);
            this.panel2.Controls.Add(this.lblProductTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(55, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 70);
            this.panel2.TabIndex = 3;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Goudy Old Style", 18F);
            this.lblProductTitle.Location = new System.Drawing.Point(3, 5);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(138, 27);
            this.lblProductTitle.TabIndex = 5;
            this.lblProductTitle.Text = "Product Title";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Leelawadee UI", 11F);
            this.lblProductCategory.Location = new System.Drawing.Point(2, 34);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(133, 20);
            this.lblProductCategory.TabIndex = 5;
            this.lblProductCategory.Text = "(product category)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtProductUnits);
            this.panel3.Controls.Add(this.btnIncrement);
            this.panel3.Controls.Add(this.btnDecrement);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(262, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 70);
            this.panel3.TabIndex = 6;
            // 
            // txtProductUnits
            // 
            this.txtProductUnits.Location = new System.Drawing.Point(53, 25);
            this.txtProductUnits.Name = "txtProductUnits";
            this.txtProductUnits.ReadOnly = true;
            this.txtProductUnits.Size = new System.Drawing.Size(100, 20);
            this.txtProductUnits.TabIndex = 11;
            this.txtProductUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIncrement
            // 
            this.btnIncrement.Enabled = false;
            this.btnIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrement.Location = new System.Drawing.Point(159, 25);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(27, 23);
            this.btnIncrement.TabIndex = 9;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Enabled = false;
            this.btnDecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrement.Location = new System.Drawing.Point(19, 25);
            this.btnDecrement.Margin = new System.Windows.Forms.Padding(0);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(29, 23);
            this.btnDecrement.TabIndex = 10;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(543, 81);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtProductUnits;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.CheckBox ckBoxProduct;
    }
}
