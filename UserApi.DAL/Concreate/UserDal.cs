using System.Threading.Tasks;

namespace UserApi.DAL.Concreate
{
    using UserApi.DAL.Abstract;
    using UserApi.Entities;
    using DAL.Context;
    public class UserDal : IUserDal
    {
        private UserContext Db;
        public UserDal(UserContext db)
        {
            Db = db;
        }

        public void SaveUser(User user)
        {
             Db.Set<User>().Add(user);
             Db.SaveChanges();
        }
    }
}
