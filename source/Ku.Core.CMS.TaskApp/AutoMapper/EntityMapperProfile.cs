﻿//----------------------------------------------------------------
// Copyright (C) 2018 vino 版权所有
//
// 文件名：EntityMapperProfile.cs
// 功能描述：AutoMapper初始化
//
// 创建者：kulend@qq.com
// 创建时间：2018-02-04 19:13
// 说明：此代码由工具自动生成，对此文件的更改可能会导致不正确的行为，
// 并且如果重新生成代码，这些更改将会丢失。
//
//----------------------------------------------------------------

using AutoMapper;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ku.Core.CMS.TaskApp.AutoMapper
{
    public class EntityMapperProfile: Profile
    {
        public EntityMapperProfile()
        {
            CreateMap<Domain.Entity.System.User, Domain.Dto.System.UserDto>();
            CreateMap<Domain.Dto.System.UserDto, Domain.Entity.System.User>();
            CreateMap<Domain.Entity.System.Role, Domain.Dto.System.RoleDto>();
            CreateMap<Domain.Dto.System.RoleDto, Domain.Entity.System.Role>();
            CreateMap<Domain.Entity.System.UserActionLog, Domain.Dto.System.UserActionLogDto>();
            CreateMap<Domain.Dto.System.UserActionLogDto, Domain.Entity.System.UserActionLog>();
            CreateMap<Domain.Entity.System.Function, Domain.Dto.System.FunctionDto>();
            CreateMap<Domain.Dto.System.FunctionDto, Domain.Entity.System.Function>();
            CreateMap<Domain.Entity.System.Menu, Domain.Dto.System.MenuDto>();
            CreateMap<Domain.Dto.System.MenuDto, Domain.Entity.System.Menu>();
            CreateMap<Domain.Entity.System.Sms, Domain.Dto.System.SmsDto>().ForMember(x => x.Data, opt => {
                opt.ResolveUsing<JsonDeserializeResolver<IDictionary<string, string>>, string>(x => x.Data);
            });
            CreateMap<Domain.Dto.System.SmsDto, Domain.Entity.System.Sms>().ForMember(x => x.Data, opt => {
                opt.ResolveUsing<JsonSerializeResolver, object>(x => x.Data);
            });
            CreateMap<Domain.Entity.System.SmsQueue, Domain.Dto.System.SmsQueueDto>();
            CreateMap<Domain.Dto.System.SmsQueueDto, Domain.Entity.System.SmsQueue>();
            CreateMap<Domain.Entity.System.SmsAccount, Domain.Dto.System.SmsAccountDto>().ForMember(x => x.ParameterConfig, opt => {
                opt.ResolveUsing<JsonDeserializeResolver<IDictionary<string, string>>, string>(x => x.ParameterConfig);
            });
            CreateMap<Domain.Dto.System.SmsAccountDto, Domain.Entity.System.SmsAccount>().ForMember(x => x.ParameterConfig, opt => {
                opt.ResolveUsing<JsonSerializeResolver, object>(x => x.ParameterConfig);
            });
            CreateMap<Domain.Entity.System.SmsTemplet, Domain.Dto.System.SmsTempletDto>();
            CreateMap<Domain.Dto.System.SmsTempletDto, Domain.Entity.System.SmsTemplet>();
            CreateMap<Domain.Entity.Membership.Member, Domain.Dto.Membership.MemberDto>();
            CreateMap<Domain.Dto.Membership.MemberDto, Domain.Entity.Membership.Member>();
            CreateMap<Domain.Entity.Membership.MemberType, Domain.Dto.Membership.MemberTypeDto>();
            CreateMap<Domain.Dto.Membership.MemberTypeDto, Domain.Entity.Membership.MemberType>();
            CreateMap<Domain.Entity.WeChat.WxAccount, Domain.Dto.WeChat.WxAccountDto>();
            CreateMap<Domain.Dto.WeChat.WxAccountDto, Domain.Entity.WeChat.WxAccount>();
            CreateMap<Domain.Entity.WeChat.WxMenu, Domain.Dto.WeChat.WxMenuDto>();
            CreateMap<Domain.Dto.WeChat.WxMenuDto, Domain.Entity.WeChat.WxMenu>();
            CreateMap<Domain.Entity.WeChat.WxUserTag, Domain.Dto.WeChat.WxUserTagDto>();
            CreateMap<Domain.Dto.WeChat.WxUserTagDto, Domain.Entity.WeChat.WxUserTag>();
            CreateMap<Domain.Entity.WeChat.WxUser, Domain.Dto.WeChat.WxUserDto>();
            CreateMap<Domain.Dto.WeChat.WxUserDto, Domain.Entity.WeChat.WxUser>();
            CreateMap<Domain.Entity.WeChat.WxQrcode, Domain.Dto.WeChat.WxQrcodeDto>();
            CreateMap<Domain.Dto.WeChat.WxQrcodeDto, Domain.Entity.WeChat.WxQrcode>();
            CreateMap<Domain.Entity.Material.Picture, Domain.Dto.Material.PictureDto>();
            CreateMap<Domain.Dto.Material.PictureDto, Domain.Entity.Material.Picture>();
            CreateMap<Domain.Entity.Material.MaterialGroup, Domain.Dto.Material.MaterialGroupDto>();
            CreateMap<Domain.Dto.Material.MaterialGroupDto, Domain.Entity.Material.MaterialGroup>();
            CreateMap<Domain.Entity.Content.Article, Domain.Dto.Content.ArticleDto>();
            CreateMap<Domain.Dto.Content.ArticleDto, Domain.Entity.Content.Article>();
            CreateMap<Domain.Entity.Mall.DeliveryTemplet, Domain.Dto.Mall.DeliveryTempletDto>();
            CreateMap<Domain.Dto.Mall.DeliveryTempletDto, Domain.Entity.Mall.DeliveryTemplet>();
            CreateMap<Domain.Entity.Mall.Payment, Domain.Dto.Mall.PaymentDto>().ForMember(x=>x.PaymentConfig, opt=>{
                opt.ResolveUsing<JsonDeserializeResolver<IDictionary<string, string>>, string>(x => x.PaymentConfig);
            });
            CreateMap<Domain.Dto.Mall.PaymentDto, Domain.Entity.Mall.Payment>().ForMember(x=>x.PaymentConfig, opt=> {
                opt.ResolveUsing<JsonSerializeResolver, object>(x => x.PaymentConfig);
            });
            CreateMap<Domain.Entity.Mall.Product, Domain.Dto.Mall.ProductDto>().ForMember(x => x.Properties, opt => {
                opt.ResolveUsing<JsonDeserializeResolver<List<Domain.Dto.Mall.ProductPropertyItem>>, string>(x => x.Properties);
            });
            CreateMap<Domain.Dto.Mall.ProductDto, Domain.Entity.Mall.Product>().ForMember(x => x.Properties, opt => {
                opt.ResolveUsing<JsonSerializeResolver, object>(x => x.Properties);
            });
            CreateMap<Domain.Entity.Mall.ProductSku, Domain.Dto.Mall.ProductSkuDto>();
            CreateMap<Domain.Dto.Mall.ProductSkuDto, Domain.Entity.Mall.ProductSku>();
        }

        private class JsonSerializeResolver : IMemberValueResolver<object, object, object, string>
        {
            public string Resolve(object source, object destination, object sourceMember, string destMember, ResolutionContext context)
            {
                if (sourceMember == null)
                {
                    return null;
                }
                return JsonConvert.SerializeObject(sourceMember);
            }
        }

        private class JsonDeserializeResolver<T> : IMemberValueResolver<object, object, string, T>
        {
            public T Resolve(object source, object destination, string sourceMember, T destMember, ResolutionContext context)
            {
                if (context.Items.ContainsKey("JsonDeserializeIgnore") 
                    && (bool)context.Items["JsonDeserializeIgnore"])
                {
                    return default(T);
                }
                if (sourceMember == null)
                {
                    return default(T);
                }
                return JsonConvert.DeserializeObject<T>(sourceMember);
            }
        }
    }
}
