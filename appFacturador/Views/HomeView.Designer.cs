
namespace appFacturador.Forms
{
    partial class HomeView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowProductsView = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 96);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facturero Electrónico";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.btnShowProductsView);
            this.panel3.Controls.Add(this.btnCreateClient);
            this.panel3.Controls.Add(this.btnSearchClient);
            this.panel3.Location = new System.Drawing.Point(18, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 283);
            this.panel3.TabIndex = 3;
            // 
            // btnShowProductsView
            // 
            this.btnShowProductsView.Font = new System.Drawing.Font("FontAwesome", 21.75F);
            this.btnShowProductsView.Location = new System.Drawing.Point(352, 38);
            this.btnShowProductsView.Name = "btnShowProductsView";
            this.btnShowProductsView.Size = new System.Drawing.Size(270, 92);
            this.btnShowProductsView.TabIndex = 5;
            this.btnShowProductsView.Text = "Consultar Productos";
            this.btnShowProductsView.UseVisualStyleBackColor = true;
            this.btnShowProductsView.Visible = false;
            this.btnShowProductsView.Click += new System.EventHandler(this.btnShowProductsView_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Font = new System.Drawing.Font("FontAwesome", 21.75F);
            this.btnCreateClient.Location = new System.Drawing.Point(75, 38);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(271, 92);
            this.btnCreateClient.TabIndex = 4;
            this.btnCreateClient.Text = "Crear Cliente";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("FontAwesome", 21.75F);
            this.btnSearchClient.Location = new System.Drawing.Point(75, 136);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(271, 92);
            this.btnSearchClient.TabIndex = 3;
            this.btnSearchClient.Text = "Consultar Cliente";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Button btnShowProductsView;
    }
}