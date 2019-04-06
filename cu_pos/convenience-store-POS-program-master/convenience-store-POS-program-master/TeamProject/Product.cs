using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Product
    {
        public string category;
        public string name;
        public int price;
        public int amount;

        public Product(string category, string name, int price)
        {
            this.category = category;
            this.name = name;
            this.price = price;
        }
        public Product() { }

    }

    class Food:Product
    {
        public DateTime e_date;
        Boolean discard;        //유통기한이 유효:true 지남:false

        public Food(string category, string name, int price, string e_date) : base(category, name, price)
        {
            this.e_date = DateTime.Parse(e_date);
            DiscardSet();
        }

        //현재시간과 유통기한을 비교하여 discard 세팅
        public void DiscardSet()    
        {
            if (DateTime.Compare(this.e_date, DateTime.Now) > 0)
                this.discard = true;
            else
                this.discard = false;
        }
    }

}
