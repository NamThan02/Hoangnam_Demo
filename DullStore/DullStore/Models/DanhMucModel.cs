using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DullStore.Models
{
    public class DanhMucModel
    {
        public List<SanPhamModel> ListLacoste { get; set; }

        public List<SanPhamModel> ListCanifa { get; set; }

        public List<SanPhamModel> ListAristino { get; set; }

        public List<SanPhamModel> ListBiluxury { get; set; }

        public List<SanPhamModel> ListpoloRalphLauren { get; set; }

        public List<SanPhamModel> D1 { get; set; }
        public List<SanPhamModel> D2 { get; set; }
        public List<SanPhamModel> D3 { get; set; }

        public DanhMucModel()
        {
            ListLacoste = new List<SanPhamModel>();
            ListLacoste.Add(new SanPhamModel("/Content/Image/Lacoste_1.jpg"));
            ListLacoste.Add(new SanPhamModel("/Content/Image/Lacoste_2.jpg"));
            ListLacoste.Add(new SanPhamModel("/Content/Image/Lacoste_3.jpg"));

            ListCanifa = new List<SanPhamModel>();
            ListCanifa.Add(new SanPhamModel("/Content/Image/Canifa_1.jpg"));
            ListCanifa.Add(new SanPhamModel("/Content/Image/Canifa_2.jpg"));

            ListAristino = new List<SanPhamModel>();
            ListAristino.Add(new SanPhamModel("/Content/Image/Aristino_1.jpg"));

            ListBiluxury = new List<SanPhamModel>();
            ListBiluxury.Add(new SanPhamModel("/Content/Image/Biluxury.jpg"));

            ListpoloRalphLauren = new List<SanPhamModel>();
            ListpoloRalphLauren.Add(new SanPhamModel("/Content/Image/poloRalphLauren_1.jpg"));
            ListpoloRalphLauren.Add(new SanPhamModel("/Content/Image/poloRalphLauren_2.jpg"));

            D1 = new List<SanPhamModel>();
            D1.Add(new SanPhamModel("/Content/Image/Lacoste_1.jpg"));
            D1.Add(new SanPhamModel("/Content/Image/Lacoste_2.jpg"));
            D1.Add(new SanPhamModel("/Content/Image/Lacoste_3.jpg"));

            D2 = new List<SanPhamModel>();
            D2.Add(new SanPhamModel("/Content/Image/Canifa_1.jpg"));
            D2.Add(new SanPhamModel("/Content/Image/Canifa_2.jpg"));
            D2.Add(new SanPhamModel("/Content/Image/Aristino_1.jpg"));

            D3 = new List<SanPhamModel>();
            D3.Add(new SanPhamModel("/Content/Image/Biluxury.jpg"));
            D3.Add(new SanPhamModel("/Content/Image/poloRalphLauren_1.jpg"));
            D3.Add(new SanPhamModel("/Content/Image/poloRalphLauren_2.jpg"));
        }
    }
}