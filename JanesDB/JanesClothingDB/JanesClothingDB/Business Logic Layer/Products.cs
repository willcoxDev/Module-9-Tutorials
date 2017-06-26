using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanesClothingDB.Business_Logic_Layer
{
    class Products
    {
        //Declare properties of a Customer
        private string productDescription, genderType, brand, colourFast;
        private int productID;
        private float price;

        //Set-Get properties
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public string GenderType
        {
            get { return genderType; }
            set { genderType = value; }
        }

        public string ColourFast
        {
            get { return colourFast; }
            set { colourFast = value; }
        }

        //Declaring Default Constructor
        public Products() { }

        //Parameterised Constructor
        public Products(int productid, string brand, string productdescription, float price, string gendertype, string colourfast)
        {
            ProductID = productid;
            Brand = brand;
            ProductDescription = productdescription;
            Price = price;
            GenderType = gendertype;
            ColourFast = colourfast;
        }

    }
}
