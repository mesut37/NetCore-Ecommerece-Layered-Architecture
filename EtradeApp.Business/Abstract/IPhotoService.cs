using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Business
{
    public interface IPhotoService
    {
        void AddPhoto(Photo photo);
        List<Photo> GetPhotosofProduct(int productId);
        void Delete(int photoId);
    }
}
