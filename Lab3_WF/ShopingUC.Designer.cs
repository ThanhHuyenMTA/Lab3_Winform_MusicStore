namespace Lab3_WF
{
    partial class ShopingUC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataAlbum1 = new System.Windows.Forms.DataGridView();
            this.AlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCart = new System.Windows.Forms.DataGridView();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.AddCart = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxArtis = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AlbumId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountQuantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlbum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataAlbum1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 442);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of album";
            // 
            // dataAlbum1
            // 
            this.dataAlbum1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlbum1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumID,
            this.Genre_ID,
            this.Artist_ID,
            this.Title,
            this.Price,
            this.AlbumUrl});
            this.dataAlbum1.Location = new System.Drawing.Point(6, 40);
            this.dataAlbum1.Name = "dataAlbum1";
            this.dataAlbum1.Size = new System.Drawing.Size(694, 383);
            this.dataAlbum1.TabIndex = 0;
            // 
            // AlbumID
            // 
            this.AlbumID.DataPropertyName = "AlbumID";
            this.AlbumID.HeaderText = "AlbumID";
            this.AlbumID.Name = "AlbumID";
            // 
            // Genre_ID
            // 
            this.Genre_ID.DataPropertyName = "Genre_ID";
            this.Genre_ID.HeaderText = "GenreID";
            this.Genre_ID.Name = "Genre_ID";
            // 
            // Artist_ID
            // 
            this.Artist_ID.DataPropertyName = "Artist_ID";
            this.Artist_ID.HeaderText = "ArtistID";
            this.Artist_ID.Name = "Artist_ID";
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 250F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 250;
            this.Title.Name = "Title";
            this.Title.Width = 250;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // AlbumUrl
            // 
            this.AlbumUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlbumUrl.DataPropertyName = "AlbumUrl";
            this.AlbumUrl.HeaderText = "AlbumUrl";
            this.AlbumUrl.MinimumWidth = 100;
            this.AlbumUrl.Name = "AlbumUrl";
            // 
            // dataCart
            // 
            this.dataCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumId1,
            this.CountQuantity1,
            this.UnitPrice1,
            this.SumPrice});
            this.dataCart.Location = new System.Drawing.Point(15, 40);
            this.dataCart.Name = "dataCart";
            this.dataCart.Size = new System.Drawing.Size(484, 366);
            this.dataCart.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(1012, 503);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(120, 30);
            this.btnCheckOut.TabIndex = 22;
            this.btnCheckOut.Text = "Check out...";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(430, 503);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 30);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Artis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Genre";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.BackgroundImage = global::Lab3_WF.Properties.Resources._242988___Copy;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(749, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 23);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddCart
            // 
            this.AddCart.BackgroundImage = global::Lab3_WF.Properties.Resources._242988;
            this.AddCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddCart.Location = new System.Drawing.Point(749, 105);
            this.AddCart.Name = "AddCart";
            this.AddCart.Size = new System.Drawing.Size(46, 23);
            this.AddCart.TabIndex = 15;
            this.AddCart.UseVisualStyleBackColor = true;
            this.AddCart.Click += new System.EventHandler(this.AddCart_Click);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(191, 485);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(183, 21);
            this.comboBoxGenre.TabIndex = 23;
            // 
            // comboBoxArtis
            // 
            this.comboBoxArtis.FormattingEnabled = true;
            this.comboBoxArtis.Location = new System.Drawing.Point(191, 534);
            this.comboBoxArtis.Name = "comboBoxArtis";
            this.comboBoxArtis.Size = new System.Drawing.Size(183, 21);
            this.comboBoxArtis.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataCart);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(801, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 442);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Cart (USD)";
            // 
            // AlbumId1
            // 
            this.AlbumId1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AlbumId1.DataPropertyName = "AlbumId1";
            this.AlbumId1.FillWeight = 80F;
            this.AlbumId1.HeaderText = "AlbumID";
            this.AlbumId1.MinimumWidth = 80;
            this.AlbumId1.Name = "AlbumId1";
            this.AlbumId1.Width = 80;
            // 
            // CountQuantity1
            // 
            this.CountQuantity1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CountQuantity1.DataPropertyName = "CountQuantity1";
            this.CountQuantity1.FillWeight = 80F;
            this.CountQuantity1.HeaderText = "Count";
            this.CountQuantity1.MinimumWidth = 80;
            this.CountQuantity1.Name = "CountQuantity1";
            this.CountQuantity1.Width = 80;
            // 
            // UnitPrice1
            // 
            this.UnitPrice1.DataPropertyName = "UnitPrice1";
            this.UnitPrice1.HeaderText = "UnitPrice";
            this.UnitPrice1.Name = "UnitPrice1";
            // 
            // SumPrice
            // 
            this.SumPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SumPrice.DataPropertyName = "SumPrice";
            this.SumPrice.FillWeight = 150F;
            this.SumPrice.HeaderText = "SumPrice";
            this.SumPrice.MinimumWidth = 150;
            this.SumPrice.Name = "SumPrice";
            // 
            // ShopingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxArtis);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddCart);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShopingUC";
            this.Size = new System.Drawing.Size(1445, 621);
            this.Load += new System.EventHandler(this.ShopingUC_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAlbum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataAlbum1;
        private System.Windows.Forms.DataGridView dataCart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AddCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxArtis;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumUrl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountQuantity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumPrice;
    }
}
