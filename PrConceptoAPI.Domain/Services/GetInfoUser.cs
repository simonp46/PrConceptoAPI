using PrConceptoAPI.Domain.Entities;
using PrConceptoAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConceptoAPI.Domain.Services
{
    public class GetInfoUser
    {
        public async Task <ResponseUserInfo> GetResponse(IInsertUserInfo insertUserInfo, UserInfoModel userInfoModel)
        {
            ResponseUserInfo response = new ResponseUserInfo();
            try
            {
                response = await insertUserInfo.InsertNewUser(userInfoModel);
                return response;
            }
            catch (Exception ex)
            {
                return response;
            }
        }
    }
}
