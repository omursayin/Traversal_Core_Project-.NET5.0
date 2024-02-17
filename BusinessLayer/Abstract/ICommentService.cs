using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetDestinationByID(int id);
        List<Comment> TGetListCommentWithDestination();
        public List<Comment> TGetListCommentWithDestinationAndUser(int id);
    }
}
