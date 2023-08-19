using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCollection
{
    public class ProductIcomparable:IComparable<ProductIcomparable>
    {
        private int price;
        private string name;
        public ProductIcomparable(int price,string name)
        {
            this.price = price;
            this.name = name;
        }

        public int CompareTo(ProductIcomparable other)
        {
           if(this.price < other.price)
            {
                return -1;
            }
           else if(this.price > other.price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
