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
    public partial class ShopingUC : UserControl
    {
        Thuctap_MusicDataContext db = new Thuctap_MusicDataContext();
        List<CartModel> listCart = new List<CartModel>();

        public ShopingUC()
        {
            InitializeComponent();
            
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Shipping a = new Shipping();
            a.Message = listCart.ToList(); //gán message bên Shipping cho listCart ->để truyền dữ liệu sang form Shipping
            a.Show();
        }

        private void ShopingUC_Load(object sender, EventArgs e)
        {
            dataAlbum1.Rows.Clear();
            var data = db.Albums.ToList();
            dataAlbum1.DataSource = data;
            //Hien thi danh sach Geren
            var modelGenre = from Al in db.Genres.ToList() select Al.GenreName;
            comboBoxGenre.DataSource = modelGenre.ToList();
            var modelArtist = from Al in db.Artists.ToList() select Al.ArtistName;
            comboBoxArtis.DataSource = modelArtist.ToList();           
            
        }
      
        
       
        private void AddCart_Click(object sender, EventArgs e)
        {
            dataCart.DataSource = null;         
            AddCarta();
            CapNhatCart();
            dataCart.DataSource = listCart.ToList();
            //Fix các cột cho căng hết chiều rộng của dataGridView
            dataCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void AddCarta()
        {
             int index = dataAlbum1.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
            CartModel a = new CartModel();
            a.AlbumId1 =Int32.Parse(dataAlbum1.Rows[index].Cells[0].Value.ToString());
            a.CountQuantity1=1;
            a.UnitPrice1 = float.Parse(dataAlbum1.Rows[index].Cells["Price"].Value.ToString());
            a.SumPrice =(float)(a.CountQuantity1 * a.UnitPrice1);
            listCart.Add(a);
        }
       
        private void CapNhatCart()
        {
            for(int i=0;i<listCart.Count();i++)
            {
                for(int j=listCart.Count()-1;j>0;j--)
                {
                    if(listCart[i].AlbumId1 ==listCart[j].AlbumId1 && i!=j)
                    {
                        listCart[i].CountQuantity1 = listCart[i].CountQuantity1 + 1;
                        listCart[i].SumPrice = listCart[i].UnitPrice1 * listCart[i].CountQuantity1;
                        listCart.Remove(listCart[j]);
                    }
                }
            }        
        }

        //Phan xoa san pham trong cart
        private void button4_Click(object sender, EventArgs e)
        {
            DeleteCart();
            dataCart.DataSource = null;
            dataCart.DataSource = listCart.ToList();
            //Fix các cột cho căng hết chiều rộng của dataGridView
            dataCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        private void DeleteCart()
        {
            int i = dataCart.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
            int AlbumId1 = Int32.Parse(dataCart.Rows[i].Cells[0].Value.ToString());                       
            int CountQuantity = Int32.Parse(dataCart.Rows[i].Cells["CountQuantity1"].Value.ToString());
            float UnitPrice1 = float.Parse(dataCart.Rows[i].Cells["UnitPrice1"].Value.ToString());
            if (CountQuantity != 1)
            {
               int CountQuantity1 = CountQuantity - 1;
               float SumPrice = (float)(CountQuantity1 * UnitPrice1);
               CartModel b = new CartModel(AlbumId1, CountQuantity1,UnitPrice1, SumPrice);
               listCart.Add(b);
            }
            var st = listCart.Find(c => c.AlbumId1 == AlbumId1);
            listCart.Remove(st);
        }
        //tim kiem theo ten Genre va Artist
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string nameArtis = comboBoxArtis.SelectedItem as string;
            Artist artist = db.Artists.SingleOrDefault(n => n.ArtistName == nameArtis);
            int artist_id = artist.ArtistID;
            string nameGenre = comboBoxGenre.SelectedItem as string;
            Genre genre = db.Genres.SingleOrDefault(n => n.GenreName == nameGenre);
            int genre_id =genre.GenreID;
            var listAlbum = db.Albums.Where(n => n.Artist_ID == artist_id && n.Genre_ID == genre_id).ToList();
            dataAlbum1.DataSource = null;
            dataAlbum1.DataSource = listAlbum;
            //Fix các cột cho căng hết chiều rộng của dataGridView
            dataAlbum1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        
       
    }
}
