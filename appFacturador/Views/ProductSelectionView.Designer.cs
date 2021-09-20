
namespace appFacturador.Views
{
    partial class ProductSelectionView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSelectionView));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSavePurchase = new System.Windows.Forms.Button();
            this.gridSummary = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnClearFields);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 106);
            this.panel2.TabIndex = 1;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClearFields.Location = new System.Drawing.Point(647, 71);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(122, 32);
            this.btnClearFields.TabIndex = 2;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F);
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(531, 316);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSavePurchase);
            this.panel1.Controls.Add(this.gridSummary);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(549, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 316);
            this.panel1.TabIndex = 3;
            // 
            // btnSavePurchase
            // 
            this.btnSavePurchase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSavePurchase.Location = new System.Drawing.Point(0, 285);
            this.btnSavePurchase.Name = "btnSavePurchase";
            this.btnSavePurchase.Size = new System.Drawing.Size(237, 29);
            this.btnSavePurchase.TabIndex = 2;
            this.btnSavePurchase.Text = "Save Summary";
            this.btnSavePurchase.UseVisualStyleBackColor = true;
            this.btnSavePurchase.Click += new System.EventHandler(this.btnSavePurchase_Click);
            // 
            // gridSummary
            // 
            this.gridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSummary.Location = new System.Drawing.Point(1, 35);
            this.gridSummary.Name = "gridSummary";
            this.gridSummary.Size = new System.Drawing.Size(235, 246);
            this.gridSummary.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(237, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Purchase Summary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblClientName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(479, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 65);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(77, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Client";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblClientName.Location = new System.Drawing.Point(87, 36);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(134, 15);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "<FirstName LastName>";
            // 
            // ProductSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "ProductSelectionView";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.ProductSelectionView_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSavePurchase;
        private System.Windows.Forms.DataGridView gridSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label4;
    }
}