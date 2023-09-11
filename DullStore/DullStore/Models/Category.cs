using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DullStore.Models
{
    public class Category
    {
        public List<string> listdm { get; set; }
        public Category()
        {
            listdm = new List<string>();
            listdm.Add("Lacoste ");
            listdm.Add("Canifa");
            listdm.Add("Aristino ");
            listdm.Add("Biluxury");
            listdm.Add("polo Ralph Lauren");
        }
    }
}