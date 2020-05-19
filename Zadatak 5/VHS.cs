using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5
{
    class VHS : IItem
    {
        public string Title { get; private set; }
        public double Price { get; private set; }

        public VHS(string title, double price)
        {
            this.Title = title;
            this.Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return "VHS: " + this.Title + Environment.NewLine + "-> Price: " + this.Price;
        }

    }
}
