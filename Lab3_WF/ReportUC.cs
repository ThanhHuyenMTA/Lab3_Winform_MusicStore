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
    public partial class ReportUC : UserControl
    {
        Thuctap_MusicDataContext db = new Thuctap_MusicDataContext();
        public ReportUC()
        {
            InitializeComponent();
        }

        private void ReportUC_Load(object sender, EventArgs e)
        {
            dataOrder.Controls.Clear();
            dataOrderDetail.Controls.Clear();

            ///Load chi tiết đơn hàng vừa mới thêm
            //đưa ra Order mới nhất (vừa được thêm vào)
            List<Order> listOrder = db.Orders.ToList();
            Order order = listOrder.Last();
            //dua ra chi tiet nguoi da mua album 

            var model = from orderA in db.GetTable<Order>() 
                        from userA in db.GetTable<User>()
                        where orderA.OrderID ==order.OrderID && userA.UserID ==orderA.User_ID
                        select new { orderA.OrderID,orderA.OrderDate,userA.FirstName,userA.LastName,userA.Address,userA.City,userA.State,userA.Country,userA.Phone, userA.Email,orderA.Total };
            
            dataOrder.DataSource = model;
            User user = db.Users.SingleOrDefault(n => n.UserID == order.User_ID);
            txtDate.Text = order.OrderDate.ToString();
            txtName.Text = user.LastName;
            List<OrdeDetal> listOrdeDetal = db.OrdeDetals.Where(n => n.Order_ID == order.OrderID).ToList();
            dataOrderDetail.DataSource = listOrdeDetal;
            ///Kêt thúc
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            var model = from orderA in db.GetTable<Order>()
                        from userA in db.GetTable<User>()
                        where userA.UserID == orderA.User_ID
                        select new { orderA.OrderID, orderA.OrderDate, userA.FirstName, userA.LastName, userA.Address, userA.City, userA.State, userA.Country, userA.Phone, userA.Email, orderA.Total };
            dataOrder.DataSource = null;
            dataOrder.DataSource = model;
            List<OrdeDetal> listOrdeDetal = db.OrdeDetals.ToList();
            dataOrderDetail.DataSource = null;
            dataOrderDetail.DataSource = listOrdeDetal;

        }
    }
}
