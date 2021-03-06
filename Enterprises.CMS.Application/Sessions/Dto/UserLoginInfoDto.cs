﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.Sessions.Dto
{
    [AutoMapFrom(typeof(Users.User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        /// <summary>
        /// 名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string EmailAddress { get; set; }
    }
}
