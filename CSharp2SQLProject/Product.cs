using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2SQLProject {
    class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        

        public Product(int Id, string Name, decimal Price) {

            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            
        }
    }
}
