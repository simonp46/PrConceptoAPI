using PrConceptoAPI.Domain.Entities;

namespace PrConceptoAPI.Domain.Interfaces
{
    public interface IInsertUserInfo
    {
        Task<ResponseUserInfo> InsertNewUser(UserInfoModel userInfoModel);
    }
}