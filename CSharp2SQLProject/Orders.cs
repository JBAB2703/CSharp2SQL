using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2SQLProject {
    class Order {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string CustomerId { get; set; }
        public string Code { get; set; }

        public Order(int Id, DateTime Date, string Note, string CustomerId) {

            this.Id = Id;
            this.Date = Date;
            this.Note = Note;
            this.CustomerId = CustomerId;
            this.Code = Code;
        }
    }
}      