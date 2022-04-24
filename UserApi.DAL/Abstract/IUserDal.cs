using System.Threading.Tasks;

namespace UserApi.DAL.Abstract
{
    using UserApi.Entities;

    public interface IUserDal
    {
        void SaveUser(User user);
    }
}
