namespace TicariOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btunCustomers = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.btnCommission = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btunCustomers
            // 
            this.btunCustomers.BackColor = System.Drawing.Color.DarkRed;
            this.btunCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btunCustomers.FlatAppearance.BorderSize = 0;
            this.btunCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btunCustomers.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btunCustomers.ForeColor = System.Drawing.Color.White;
            this.btunCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btunCustomers.Image")));
            this.btunCustomers.Location = new System.Drawing.Point(169, 185);
            this.btunCustomers.Name = "btunCustomers";
            this.btunCustomers.Size = new System.Drawing.Size(282, 170);
            this.btunCustomers.TabIndex = 8;
            this.btunCustomers.Text = "Müşteriler";
            this.btunCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btunCustomers.UseVisualStyleBackColor = false;
            this.btunCustomers.Click += new System.EventHandler(this.btunCustomers_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.DarkRed;
            this.btnBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnBrand.Image")));
            this.btnBrand.Location = new System.Drawing.Point(1155, 460);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(282, 170);
            this.btnBrand.TabIndex = 15;
            this.btnBrand.Text = "Markalar";
            this.btnBrand.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrand.UseVisualStyleBackColor = false;
            // 
            // btnPerson
            // 
            this.btnPerson.BackColor = System.Drawing.Color.DarkRed;
            this.btnPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerson.FlatAppearance.BorderSize = 0;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPerson.ForeColor = System.Drawing.Color.White;
            this.btnPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnPerson.Image")));
            this.btnPerson.Location = new System.Drawing.Point(495, 185);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(282, 170);
            this.btnPerson.TabIndex = 9;
            this.btnPerson.Text = "Personeller";
            this.btnPerson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerson.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.DarkRed;
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.Location = new System.Drawing.Point(1155, 185);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(282, 170);
            this.btnCategories.TabIndex = 14;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.DarkRed;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.Location = new System.Drawing.Point(825, 185);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(282, 170);
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "Ürünler";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnPromotion
            // 
            this.btnPromotion.BackColor = System.Drawing.Color.DarkRed;
            this.btnPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromotion.FlatAppearance.BorderSize = 0;
            this.btnPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromotion.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPromotion.ForeColor = System.Drawing.Color.White;
            this.btnPromotion.Image = ((System.Drawing.Image)(resources.GetObject("btnPromotion.Image")));
            this.btnPromotion.Location = new System.Drawing.Point(495, 460);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(282, 169);
            this.btnPromotion.TabIndex = 13;
            this.btnPromotion.Text = "Promosyon";
            this.btnPromotion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPromotion.UseVisualStyleBackColor = false;
            // 
            // btnCommission
            // 
            this.btnCommission.BackColor = System.Drawing.Color.DarkRed;
            this.btnCommission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommission.FlatAppearance.BorderSize = 0;
            this.btnCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommission.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCommission.ForeColor = System.Drawing.Color.White;
            this.btnCommission.Image = ((System.Drawing.Image)(resources.GetObject("btnCommission.Image")));
            this.btnCommission.Location = new System.Drawing.Point(825, 460);
            this.btnCommission.Name = "btnCommission";
            this.btnCommission.Size = new System.Drawing.Size(282, 170);
            this.btnCommission.TabIndex = 11;
            this.btnCommission.Text = "Siparişler";
            this.btnCommission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCommission.UseVisualStyleBackColor = false;
            this.btnCommission.Click += new System.EventHandler(this.btnCommission_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.DarkRed;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.Location = new System.Drawing.Point(169, 460);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(282, 169);
            this.btnStock.TabIndex = 12;
            this.btnStock.Text = "Stoklar";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1454, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 69);
            this.btnExit.TabIndex = 16;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1607, 814);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btunCustomers);
            this.Controls.Add(this.btnBrand);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnPromotion);
            this.Controls.Add(this.btnCommission);
            this.Controls.Add(this.btnStock);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btunCustomers;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnCommission;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnExit;
    }
}

