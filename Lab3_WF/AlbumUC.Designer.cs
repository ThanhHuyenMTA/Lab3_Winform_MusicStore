namespace Lab3_WF
{
    partial class AlbumUC
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
            this.txtTitleA = new System.Windows.Forms.TextBox();
            this.txtPriceA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataAlbum = new System.Windows.Forms.DataGridView();
            this.AlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.btnEditAlbum = new System.Windows.Forms.Button();
            this.btnDeleteAlbum = new System.Windows.Forms.Button();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.btnCancelAlbum = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitleA
            // 
            this.txtTitleA.Location = new System.Drawing.Point(150, 164);
            this.txtTitleA.Name = "txtTitleA";
            this.txtTitleA.Size = new System.Drawing.Size(187, 20);
            this.txtTitleA.TabIndex = 0;
            // 
            // txtPriceA
            // 
            this.txtPriceA.Location = new System.Drawing.Point(150, 222);
            this.txtPriceA.Name = "txtPriceA";
            this.txtPriceA.Size = new System.Drawing.Size(187, 20);
            this.txtPriceA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataAlbum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(426, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 529);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Album";
            // 
            // dataAlbum
            // 
            this.dataAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumID,
            this.Genre_ID,
            this.Artist_ID,
            this.Title,
            this.Price,
            this.AlbumUrl});
            this.dataAlbum.Location = new System.Drawing.Point(30, 34);
            this.dataAlbum.Name = "dataAlbum";
            this.dataAlbum.Size = new System.Drawing.Size(793, 465);
            this.dataAlbum.TabIndex = 0;
            this.dataAlbum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAlbum_CellClick);
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
            this.Title.FillWeight = 200F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 200;
            this.Title.Name = "Title";
            this.Title.Width = 200;
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
            this.AlbumUrl.FillWeight = 150F;
            this.AlbumUrl.HeaderText = "AlbumUrl";
            this.AlbumUrl.Name = "AlbumUrl";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlbum.Location = new System.Drawing.Point(21, 383);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(75, 31);
            this.btnAddAlbum.TabIndex = 4;
            this.btnAddAlbum.Text = "Add";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // btnEditAlbum
            // 
            this.btnEditAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAlbum.Location = new System.Drawing.Point(164, 309);
            this.btnEditAlbum.Name = "btnEditAlbum";
            this.btnEditAlbum.Size = new System.Drawing.Size(75, 31);
            this.btnEditAlbum.TabIndex = 4;
            this.btnEditAlbum.Text = "Edit";
            this.btnEditAlbum.UseVisualStyleBackColor = true;
            this.btnEditAlbum.Click += new System.EventHandler(this.btnEditAlbum_Click);
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAlbum.Location = new System.Drawing.Point(164, 383);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteAlbum.TabIndex = 4;
            this.btnDeleteAlbum.Text = "Delete";
            this.btnDeleteAlbum.UseVisualStyleBackColor = true;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.btnDeleteAlbum_Click);
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAlbum.Location = new System.Drawing.Point(313, 309);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(75, 31);
            this.btnSaveAlbum.TabIndex = 4;
            this.btnSaveAlbum.Text = "Save";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // btnCancelAlbum
            // 
            this.btnCancelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAlbum.Location = new System.Drawing.Point(313, 383);
            this.btnCancelAlbum.Name = "btnCancelAlbum";
            this.btnCancelAlbum.Size = new System.Drawing.Size(75, 31);
            this.btnCancelAlbum.TabIndex = 4;
            this.btnCancelAlbum.Text = "Cancel";
            this.btnCancelAlbum.UseVisualStyleBackColor = true;
            this.btnCancelAlbum.Click += new System.EventHandler(this.btnCancelAlbum_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(150, 51);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(187, 21);
            this.cmbGenre.TabIndex = 5;
            // 
            // cmbArtist
            // 
            this.cmbArtist.FormattingEnabled = true;
            this.cmbArtist.Location = new System.Drawing.Point(150, 112);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(187, 21);
            this.cmbArtist.TabIndex = 6;
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterAll.Location = new System.Drawing.Point(21, 456);
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(367, 36);
            this.btnFilterAll.TabIndex = 7;
            this.btnFilterAll.Text = "Filter All";
            this.btnFilterAll.UseVisualStyleBackColor = true;
            this.btnFilterAll.Click += new System.EventHandler(this.btnFilterAll_Click);
            // 
            // AlbumUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFilterAll);
            this.Controls.Add(this.cmbArtist);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.btnCancelAlbum);
            this.Controls.Add(this.btnSaveAlbum);
            this.Controls.Add(this.btnDeleteAlbum);
            this.Controls.Add(this.btnEditAlbum);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPriceA);
            this.Controls.Add(this.txtTitleA);
            this.Name = "AlbumUC";
            this.Size = new System.Drawing.Size(1327, 614);
            this.Load += new System.EventHandler(this.AlbumUC_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitleA;
        private System.Windows.Forms.TextBox txtPriceA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataAlbum;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Button btnEditAlbum;
        private System.Windows.Forms.Button btnDeleteAlbum;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.Button btnCancelAlbum;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumUrl;
        private System.Windows.Forms.Button btnFilterAll;
    }
}
