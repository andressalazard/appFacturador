
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridSummary = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSavePurchase = new System.Windows.Forms.Button();
            this.btnChangeClient = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 106);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChangeClient);
            this.panel3.Controls.Add(this.btnClearFields);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(448, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 97);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(131, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 52);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Client";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel5.Controls.Add(this.lblClientName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 25);
            this.panel5.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.Orange;
            this.lblClientName.Location = new System.Drawing.Point(6, 2);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(193, 21);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "<FirstName LastName>";
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
            this.label1.Location = new System.Drawing.Point(3, 11);
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
            // btnSavePurchase
            // 
            this.btnSavePurchase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSavePurchase.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSavePurchase.Image = global::appFacturador.Properties.Resources.baseline_done_black_24dp;
            this.btnSavePurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePurchase.Location = new System.Drawing.Point(0, 285);
            this.btnSavePurchase.Name = "btnSavePurchase";
            this.btnSavePurchase.Padding = new System.Windows.Forms.Padding(47, 0, 47, 0);
            this.btnSavePurchase.Size = new System.Drawing.Size(237, 29);
            this.btnSavePurchase.TabIndex = 2;
            this.btnSavePurchase.Text = "Save Summary";
            this.btnSavePurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePurchase.UseVisualStyleBackColor = true;
            this.btnSavePurchase.Click += new System.EventHandler(this.btnSavePurchase_Click);
            // 
            // btnChangeClient
            // 
            this.btnChangeClient.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnChangeClient.Image = global::appFacturador.Properties.Resources.outline_person_black_24dp;
            this.btnChangeClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeClient.Location = new System.Drawing.Point(27, 60);
            this.btnChangeClient.Name = "btnChangeClient";
            this.btnChangeClient.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnChangeClient.Size = new System.Drawing.Size(152, 32);
            this.btnChangeClient.TabIndex = 4;
            this.btnChangeClient.Text = "Change Client";
            this.btnChangeClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeClient.UseVisualStyleBackColor = true;
            this.btnChangeClient.Click += new System.EventHandler(this.btnChangeClient_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClearFields.Image = global::appFacturador.Properties.Resources.outline_remove_shopping_cart_black_24dp;
            this.btnClearFields.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearFields.Location = new System.Drawing.Point(185, 60);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClearFields.Size = new System.Drawing.Size(136, 32);
            this.btnClearFields.TabIndex = 2;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // label5
            // 
            this.label5.Image = global::appFacturador.Properties.Resources.outline_account_circle_black_24dp;
            this.label5.Location = new System.Drawing.Point(154, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 27);
            this.label5.TabIndex = 2;
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
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSummary)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnChangeClient;
    }
}