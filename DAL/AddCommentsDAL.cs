using Shared;
using System;
namespace DAL
{
    public class AddCommentsDAL
    {
        private readonly BookReadingContext _context;

        public AddCommentsDAL(BookReadingContext dbContext)
        {
            _context = dbContext;
        }

        public void AddComments(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
