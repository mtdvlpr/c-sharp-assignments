using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }

        public Magazine(string title, float price, int numberOfItems, DayOfWeek releaseDay) 
            : base(title, price, numberOfItems)
        {
            ReleaseDay = releaseDay;
        }

        public override string ToString()
        {
            return $"[Magazine] {Title} - {ReleaseDay}, {Price:0.00} ({NumberOfItems}x)";
        }
    }
}
