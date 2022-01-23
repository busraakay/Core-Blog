using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogListWithCategoryByWriterBm(int id)
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAllList(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetAllList();
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetAllList().Take(3).ToList();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetAllList(x => x.WriterID == id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
