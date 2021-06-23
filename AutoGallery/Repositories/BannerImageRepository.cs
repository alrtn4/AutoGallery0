using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoGallery.Models;

namespace AutoGallery.Repositories
{
    public class BannerImageRepository : IRepository
    {
        private readonly MyDbContext _context;

        //public BannerImageRepository()
        //{

        //}
        public BannerImageRepository(MyDbContext context)
        {
            _context = context;
        }
        public List<BannerImage> GetBannerImage()
        {
            return _context.BannerImages.ToList();
        }

        public void AddBannerImage(BannerImage bannerImage)
        {
            _context.BannerImages.Add(bannerImage);

            _context.SaveChanges();
        }

    }
}