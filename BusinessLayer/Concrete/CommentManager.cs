using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        ICommentDal _CommentDal;  //ICommentDal dan atama yapıyoruz.

        public CommentManager(ICommentDal commentDal)  //Constuctor yapıyoruz.
        {
            _CommentDal = commentDal;
        }

        public void TDelete(Comment t)
        {
            _CommentDal.Delete(t);            
        }

        public Comment TGetById(int id)
        {
            return _CommentDal.GetbyID(id);
        }

        public List<Comment> TGetList()
        {
            return _CommentDal.GetList();
        }

        public void TInsert(Comment t)
        {
            _CommentDal.Insert(t);         
        }

        public void TUpdate(Comment t)
        {
            _CommentDal.Update(t);
        }
    }
}
