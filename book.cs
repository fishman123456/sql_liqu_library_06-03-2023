using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_liqu_library_06_03_2023
{
    public class book
    {

        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }

        public book() { }
        public book(string _Title, int _Price, int _Pages)
        {
            Title = _Title;
            Price = _Price;
            Pages = _Pages;
        }
    }
}
