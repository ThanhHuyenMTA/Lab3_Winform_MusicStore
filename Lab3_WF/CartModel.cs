using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_WF
{
    class CartModel
    {
        private int AlbumId;

        public int AlbumId1
        {
            get { return AlbumId; }
            set { AlbumId = value; }
        }
        private int CountQuantity;

        public int CountQuantity1
        {
            get { return CountQuantity; }
            set { CountQuantity = value; }
        }
        private float UnitPrice;

        public float UnitPrice1
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }
        }


        private float sumPrice;

        public float SumPrice
        {
            get { return sumPrice; }
            set { sumPrice = value; }
        }

        
        public CartModel() { }
        public CartModel(int albumID, int countQuantity, float price, float sumPrice)
        {
            this.AlbumId = albumID;
            this.CountQuantity = countQuantity;
            this.UnitPrice = price;
            this.sumPrice = sumPrice;
        }      
    }
}
