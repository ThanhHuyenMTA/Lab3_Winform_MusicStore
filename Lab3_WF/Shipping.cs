using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_WF
{
    public partial class Shipping : Form
    {

        Thuctap_MusicDataContext db = new Thuctap_MusicDataContext();
        public Shipping()
        {
            InitializeComponent();
        }
        // khai báo một thuộc tính để lưu giữ thông điệp nhận từ ShopingUC
        private List<CartModel> message;

        internal List<CartModel> Message
        {
            get { return message; }
            set { message = value; }
        }
        //end
        private void Shipping_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString().Trim();
            List<CartModel> listC = message; //gán list = dữ liệu được lấy từ ShopingUC
            float tongtien = 0;
            for (int i = 0; i < listC.Count(); i++)
                tongtien += listC[i].SumPrice;
            txtTotal.Text = tongtien.ToString();

        }

        private void btnSaveuser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = txtFirstname.Text;
            user.LastName = txtLastname.Text;
            user.Address = txtAdress.Text;
            user.City = txtCity.Text;
            user.State = txtState.Text;
            user.Country = txtCountry.Text;
            user.Phone = txtPhone.Text;
            user.Email = txtEmail.Text;
            DateTime orderDate = DateTime.Parse(txtDate.Text);
            float total = float.Parse(txtTotal.Text);
            if (user.FirstName != null && user.LastName != null)
            {
                //cach luu tru vao database
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
                //kiểm tra trong giỏ hàng có album hay không
                //nếu có thì thực hiện lưu
                if (message.Count != 0)
                {
                    List<User> listUser = db.Users.ToList();
                    int user_id = listUser.Last().UserID;
                    Order order = new Order();
                    order.User_ID = user_id;
                    order.OrderDate = orderDate;
                    order.Total = total;
                    db.Orders.InsertOnSubmit(order);
                    db.SubmitChanges();

                    List<Order> listOrder = db.Orders.ToList();
                    int order_id = listOrder.Last().OrderID;
                    for (int i = 0; i < message.Count(); i++)
                    {
                        OrdeDetal orderDetal = new OrdeDetal();
                        orderDetal.Order_ID = order_id;
                        orderDetal.Album_ID = message[i].AlbumId1;
                        orderDetal.Quantity = message[i].CountQuantity1;
                        orderDetal.Total_OD = message[i].SumPrice;
                        db.OrdeDetals.InsertOnSubmit(orderDetal);
                        db.SubmitChanges();
                    }

                }
                Form1 form1 = new Form1();
                Shipping fmshipping = new Shipping();
                fmshipping.Hide();
                form1.Chuyenform = true;
                form1.Show();

            }


        }
    }
}
