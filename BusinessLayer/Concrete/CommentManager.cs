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

        public void CommentAdd(Comment comment)
        {
            _commnetDal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return _commnetDal.GetAllList(x => x.BlogID == id);
        }
    }
}
