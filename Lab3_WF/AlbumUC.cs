using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_WF
{
    public partial class AlbumUC : UserControl
    {
        Thuctap_MusicDataContext db = new Thuctap_MusicDataContext();

        public AlbumUC()
        {
            InitializeComponent();
        }

        private void AlbumUC_Load(object sender, EventArgs e)
        {
            dataAlbum.Rows.Clear();
            var list = from album in db.Albums
                       select album;
            dataAlbum.DataSource = list;
            var modelGenre = from Al in db.Genres.ToList() select Al.GenreName;
            cmbGenre.DataSource = modelGenre.ToList();
            var modelArtist = from Al in db.Artists.ToList() select Al.ArtistName;
            cmbArtist.DataSource = modelArtist.ToList();
            txtPriceA.Enabled = false;
            txtTitleA.Enabled = false;
            btnSaveAlbum.Enabled = false;
            btnCancelAlbum.Enabled = false;

        }
        //nut Filter
        private void button1_Click(object sender, EventArgs e)
        {
            string nameArtis = cmbArtist.SelectedItem as string;
            Artist artist = db.Artists.SingleOrDefault(n => n.ArtistName == nameArtis);
            int artist_id = artist.ArtistID;
            string nameGenre = cmbGenre.SelectedItem as string;
            Genre genre = db.Genres.SingleOrDefault(n => n.GenreName == nameGenre);
            int genre_id = genre.GenreID;
            var listAlbum = db.Albums.Where(n => n.Artist_ID == artist_id && n.Genre_ID == genre_id).ToList();
            dataAlbum.DataSource = null;
            dataAlbum.DataSource = listAlbum;
            //Fix các cột cho căng hết chiều rộng của dataGridView
            dataAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dataAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataAlbum.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
            int AlbumId = Int32.Parse(dataAlbum.Rows[i].Cells[0].Value.ToString());

            int id_genre = Int32.Parse(dataAlbum.Rows[i].Cells["Genre_ID"].Value.ToString());
            int id_artist = Int32.Parse(dataAlbum.Rows[i].Cells["Artist_ID"].Value.ToString());
            Genre genre =db.Genres.First(n=>n.GenreID ==id_genre);
            Artist artist = db.Artists.First(n => n.ArtistID == id_artist);
            string Title = dataAlbum.Rows[i].Cells["Title"].Value.ToString();
            float price = float.Parse(dataAlbum.Rows[i].Cells["Price"].Value.ToString());
            txtTitleA.Text = Title;
            txtPriceA.Text = price.ToString();
            cmbArtist.Text =artist.ArtistName;
            cmbGenre.Text = genre.GenreName;
            
        }

        private void btnFilterAll_Click(object sender, EventArgs e)
        {
            dataAlbum.DataSource = null;
            var list = from album in db.Albums
                       select album;
            dataAlbum.DataSource = list;
            //Fix các cột cho căng hết chiều rộng của dataGridView
            dataAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var modelGenre = from Al in db.Genres.ToList() select Al.GenreName;
            cmbGenre.DataSource = modelGenre.ToList();
            var modelArtist = from Al in db.Artists.ToList() select Al.ArtistName;
            cmbArtist.DataSource = modelArtist.ToList(); 
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            btnDeleteAlbum.Enabled = false;
            btnEditAlbum.Enabled = false;
            btnFilterAll.Enabled = false;
            button1.Enabled = false;
            txtPriceA.Enabled = true;
            txtTitleA.Enabled = true;
            btnSaveAlbum.Enabled = true;
            btnCancelAlbum.Enabled = true;            
        }

        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            Genre G = db.Genres.SingleOrDefault(n => n.GenreName == cmbGenre.Text);
            Artist A = db.Artists.SingleOrDefault(n => n.ArtistName == cmbArtist.Text);
            int genre_id = G.GenreID;
            int artist_id = A.ArtistID;
            string title = txtTitleA.Text;
            float price = float.Parse(txtPriceA.Text);
            if(btnAddAlbum.Enabled ==true)
            {
                Album album = new Album();
                album.Genre_ID = genre_id;
                album.Artist_ID = artist_id;
                album.Title = title;
                album.Price = price;
                db.Albums.InsertOnSubmit(album);
                db.SubmitChanges();
            }
            if(btnEditAlbum.Enabled==true)
            {
                int i = dataAlbum.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                int AlbumId = Int32.Parse(dataAlbum.Rows[i].Cells[0].Value.ToString());
                Album editAlbum = db.Albums.SingleOrDefault(n => n.AlbumID == AlbumId);
                editAlbum.Genre_ID = genre_id;
                editAlbum.Artist_ID = artist_id;
                editAlbum.Title = title;
                editAlbum.Price = price;
                db.SubmitChanges();
            }
            txtPriceA.Enabled = false;
            txtTitleA.Enabled = false;
            btnSaveAlbum.Enabled = false;
            btnCancelAlbum.Enabled = false;

            btnDeleteAlbum.Enabled = true;
            btnAddAlbum.Enabled = true;
            btnEditAlbum.Enabled = true;
            btnFilterAll.Enabled = true;
            button1.Enabled = true;
            //load lai du lieu
            dataAlbum.DataSource = null;
            var list = from album in db.Albums
                       select album;
            dataAlbum.DataSource = list;
            //Fix các cột cho căng hết chiều rộng của dataGridView
            dataAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEditAlbum_Click(object sender, EventArgs e)
        {
            btnDeleteAlbum.Enabled = false;
            btnAddAlbum.Enabled = false;
            btnFilterAll.Enabled = false;
            button1.Enabled = false;
            txtPriceA.Enabled = true;
            txtTitleA.Enabled = true;
            btnSaveAlbum.Enabled = true;
            btnCancelAlbum.Enabled = true;       
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            btnEditAlbum.Enabled = false;
            btnAddAlbum.Enabled = false;
            btnFilterAll.Enabled = false;
            button1.Enabled = false;
            txtPriceA.Enabled = true;
            txtTitleA.Enabled = true;
            btnSaveAlbum.Enabled = true;
            btnCancelAlbum.Enabled = true;
            DialogResult HopthoaiTB = MessageBox.Show("Do you want to delete that album", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (HopthoaiTB == DialogResult.Yes)
            {
                int i = dataAlbum.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                int AlbumId = Int32.Parse(dataAlbum.Rows[i].Cells[0].Value.ToString());
                Album deleteAlbum = db.Albums.SingleOrDefault(n => n.AlbumID == AlbumId);
                db.Albums.DeleteOnSubmit(deleteAlbum);
                db.SubmitChanges();    
            }
            txtPriceA.Enabled = false;
            txtTitleA.Enabled = false;
            btnSaveAlbum.Enabled = false;
            btnCancelAlbum.Enabled = false;

            btnDeleteAlbum.Enabled = true;
            btnAddAlbum.Enabled = true;
            btnEditAlbum.Enabled = true;
            btnFilterAll.Enabled = true;
            button1.Enabled = true;
            dataAlbum.DataSource = null;
            var list = from album in db.Albums
                       select album;
            dataAlbum.DataSource = list;
            //Fix các cột cho căng hết chiều rộng của dataGridView
            dataAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCancelAlbum_Click(object sender, EventArgs e)
        {
            txtPriceA.Enabled = false;
            txtTitleA.Enabled = false;
            btnSaveAlbum.Enabled = false;
            btnCancelAlbum.Enabled = false;

            btnDeleteAlbum.Enabled = true;
            btnAddAlbum.Enabled = true;
            btnEditAlbum.Enabled = true;
            btnFilterAll.Enabled = true;
            button1.Enabled = true;
            dataAlbum.DataSource = null;
            var list = from album in db.Albums
                       select album;
            dataAlbum.DataSource = list;
            //Fix các cột cho căng hết chiều rộng của dataGridView
            dataAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }      
        
       
    }
}
