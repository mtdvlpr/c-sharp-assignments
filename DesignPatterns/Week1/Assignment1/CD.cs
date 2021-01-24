using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CD : BookStoreItem
    {
        public string Artist { get; set; }

        public CD(string title, float price, int numberOfItems, string artist)
            : base(title, price, numberOfItems)
        {
            Artist = artist;
        }

        public override string ToString()
        {
            return $"[CD] {Artist} - {Title}, {Price:0.00} ({NumberOfItems}x)";
        }
    }
}
