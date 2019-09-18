using EtradeApp.Business.Abstract;
using EtradeApp.DataAccess.Abstract;
using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Business.Concrete
{
   public class PhotoManager:IPhotoService
    {
        private IPhotoDal _photoDal;

        public PhotoManager(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }
        public void AddPhoto(Photo photo)
        {
            _photoDal.Add(photo);
        }

        public List<Photo> GetPhotosofProduct(int productId)
        {
            return _photoDal.GetList(p => p.ProductId == productId);
        }

        public void Delete(int photoId)
        {
            _photoDal.Delete(new Photo { PhotoId = photoId });
        }

    }
}
