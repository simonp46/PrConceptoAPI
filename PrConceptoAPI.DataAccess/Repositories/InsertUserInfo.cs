using PrConceptoAPI.DataAccess.Databases;
using PrConceptoAPI.Domain.Entities;
using PrConceptoAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConceptoAPI.DataAccess.Repositories
{
    public class InsertUserInfo : IInsertUserInfo
    {
        public async Task<ResponseUserInfo> InsertNewUser(UserInfoModel userInfoModel)
        {
            try
            {
                using var context = new dbContext();
                var Info = new UserInfoModel
                {
                    UserName = userInfoModel.UserName,
                    PwdUser = userInfoModel.PwdUser
                };
                context.Add(Info);
                context.SaveChanges();
                return new ResponseUserInfo {Response="Usuario insertado correctamente"};
            }
            catch (Exception ex)
            {
                return new ResponseUserInfo { Response = "Error al insertar Usuario" }; ;
            }
        }
    }
}
