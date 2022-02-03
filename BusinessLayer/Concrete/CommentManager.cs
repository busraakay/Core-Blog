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
    public class CommentManager : ICommentService
    {
        ICommentDal _commnetDal;

        public CommentManager(ICommentDal commnetDal)
        {
            _commnetDal = commnetDal;
        }

        public void TAdd(Comment t)
        {
            _commnetDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            return _commnetDal.GetAllList();
        }

        public List<Comment> GetListByBlog(int id)
        {
            return _commnetDal.GetAllList(x => x.BlogID == id);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
