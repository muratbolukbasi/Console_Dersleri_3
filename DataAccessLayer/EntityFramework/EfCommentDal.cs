using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public void CommentListWithLocationAndMember()
        {
            //ENTİTY FRAMEWORK İLE JOİN YAPMA
            Context c = new Context();

            var yorumlar = (from x in c.Comments
                            join y in c.Locations
                            on
                            x.LocationID equals y.LocationID
                            join z in c.Members
                            on
                            x.MemberID equals z.MemberID
                            select new
                            {
                                x.CommentID,
                                y.LocationName,
                                z.MemberName,
                                z.MemberSurname,
                                x.CommentContent
                            }).ToList();
            foreach (var item in yorumlar)
            {
                Console.WriteLine(item.CommentID + " " + item.LocationName + " " + item.MemberName + " " + item.MemberSurname + " " + item.CommentContent);
                Console.WriteLine("--------------------------");
            }
        }


    }
}
