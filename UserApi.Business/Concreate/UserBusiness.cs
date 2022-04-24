using System.Threading.Tasks;

namespace UserApi.Business.Concreate
{
    using UserApi.Business.Abstract;
    using UserApi.DAL.Abstract;
    using UserApi.Entities;

    public class UserBusiness : IUserBusiness
    {
        private IUserDal _IUserDal = null;

        public UserBusiness(IUserDal userDal)
        {
            _IUserDal = userDal;
        }

        public void SaveUser(User user)
        {
            _IUserDal.SaveUser(user);
        }
    }
}
