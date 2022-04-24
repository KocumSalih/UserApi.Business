using System.Threading.Tasks;

namespace UserApi.Business.Abstract
{
    using UserApi.Entities;

    public interface IUserBusiness
    {
        void SaveUser(User user);
    }
}
