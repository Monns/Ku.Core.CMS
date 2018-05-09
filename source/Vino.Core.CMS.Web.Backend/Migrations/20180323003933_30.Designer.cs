﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Ku.Core.CMS.Data.Common;
using Ku.Core.CMS.Domain.Enum;
using Ku.Core.CMS.Domain.Enum.Content;
using Ku.Core.CMS.Domain.Enum.Mall;
using Ku.Core.CMS.Domain.Enum.Material;
using Ku.Core.CMS.Domain.Enum.System;
using Ku.Core.CMS.Domain.Enum.WeChat;

namespace Ku.Core.CMS.Web.Backend.Migrations
{
    [DbContext(typeof(VinoDbContext))]
    [Migration("20180323003933_30")]
    partial class _30
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Content.Article", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Author")
                        .HasMaxLength(32);

                    b.Property<string>("Content");

                    b.Property<short>("ContentType");

                    b.Property<string>("CoverData")
                        .HasMaxLength(512);

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Keyword")
                        .HasMaxLength(256);

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Provenance")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("PublishedTime");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("Visits");

                    b.HasKey("Id");

                    b.ToTable("content_article");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Mall.DeliveryTemplet", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("ChargeConfig");

                    b.Property<short>("ChargeMode");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("EffectiveTime");

                    b.Property<DateTime?>("ExpireTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnable");

                    b.Property<bool>("IsSnapshot");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<long?>("OriginId");

                    b.Property<int>("SnapshotCount");

                    b.HasKey("Id");

                    b.ToTable("mall_delivery_templet");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Mall.Payment", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("EffectiveTime");

                    b.Property<DateTime?>("ExpireTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnable");

                    b.Property<bool>("IsMobile");

                    b.Property<bool>("IsSnapshot");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<long?>("OriginId");

                    b.Property<string>("PaymentConfig");

                    b.Property<short>("PaymentMode");

                    b.Property<int>("SnapshotCount");

                    b.HasKey("Id");

                    b.ToTable("mall_payment");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Mall.Product", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Content");

                    b.Property<short>("ContentType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("EffectiveTime");

                    b.Property<DateTime?>("ExpireTime");

                    b.Property<string>("ImageData")
                        .HasMaxLength(3000);

                    b.Property<string>("Intro")
                        .HasMaxLength(512);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSnapshot");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("OrderIndex");

                    b.Property<long?>("OriginId");

                    b.Property<string>("PriceRange")
                        .HasMaxLength(32);

                    b.Property<string>("Properties")
                        .HasMaxLength(2000);

                    b.Property<int>("Sales");

                    b.Property<int>("SnapshotCount");

                    b.Property<short>("Status");

                    b.Property<int>("Stock");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("Visits");

                    b.HasKey("Id");

                    b.ToTable("mall_product");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Mall.ProductSku", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("CoverImage")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("GainPoints");

                    b.Property<bool>("IsDeleted");

                    b.Property<decimal>("MarketPrice");

                    b.Property<int>("OrderIndex");

                    b.Property<short>("PointsGainRule");

                    b.Property<decimal>("Price");

                    b.Property<long>("ProductId");

                    b.Property<int>("Sales");

                    b.Property<short>("Status");

                    b.Property<int>("Stock");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("mall_product_sku");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Material.MaterialGroup", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("CreateUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<short>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CreateUserId");

                    b.ToTable("material_group");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Material.Picture", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FileName")
                        .HasMaxLength(128);

                    b.Property<string>("FilePath")
                        .HasMaxLength(256);

                    b.Property<long>("FileSize");

                    b.Property<string>("FileType")
                        .HasMaxLength(20);

                    b.Property<string>("Folder")
                        .HasMaxLength(256);

                    b.Property<long?>("GroupId");

                    b.Property<bool>("IsCompressed");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Md5Code")
                        .HasMaxLength(32);

                    b.Property<string>("ThumbPath")
                        .HasMaxLength(256);

                    b.Property<string>("Title")
                        .HasMaxLength(128);

                    b.Property<long>("UploadUserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UploadUserId");

                    b.ToTable("material_picture");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Membership.Member", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int?>("Factor");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnable");

                    b.Property<string>("LastLoginIp")
                        .HasMaxLength(40);

                    b.Property<DateTime?>("LastLoginTime");

                    b.Property<int>("Level");

                    b.Property<long?>("MemberTypeId");

                    b.Property<string>("Mobile")
                        .HasMaxLength(11);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("Points");

                    b.Property<short>("Sex");

                    b.HasKey("Id");

                    b.HasIndex("MemberTypeId");

                    b.ToTable("membership_member");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Membership.MemberType", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("OrderIndex");

                    b.HasKey("Id");

                    b.ToTable("membership_member_type");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.Function", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("AuthCode")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("HasSub");

                    b.Property<bool>("IsEnable");

                    b.Property<int>("Level");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<long?>("ParentId");

                    b.HasKey("Id");

                    b.ToTable("system_function");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.Menu", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("AuthCode")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("HasSubMenu");

                    b.Property<string>("Icon")
                        .HasMaxLength(20);

                    b.Property<bool>("IsShow");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("OrderIndex");

                    b.Property<long?>("ParentId");

                    b.Property<string>("Url")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("system_menu");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.Role", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnable");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Remarks")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("system_role");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.RoleFunction", b =>
                {
                    b.Property<long>("RoleId");

                    b.Property<long>("FunctionId");

                    b.HasKey("RoleId", "FunctionId");

                    b.HasIndex("FunctionId");

                    b.ToTable("system_role_function");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.Sms", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Content")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Data")
                        .HasMaxLength(512);

                    b.Property<DateTime>("ExpireTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Mobile")
                        .HasMaxLength(11);

                    b.Property<string>("Signature")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("system_sms");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.SmsQueue", b =>
                {
                    b.Property<long>("Id");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("SendTime");

                    b.Property<long>("SmsId");

                    b.Property<short>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SmsId");

                    b.ToTable("system_sms_queue");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.User", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int?>("Factor");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnable");

                    b.Property<string>("LastLoginIp")
                        .HasMaxLength(40);

                    b.Property<DateTime?>("LastLoginTime");

                    b.Property<string>("Mobile")
                        .HasMaxLength(11);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Remarks")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("system_user");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.UserActionLog", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("ActionName")
                        .HasMaxLength(30);

                    b.Property<string>("ActionResult")
                        .HasMaxLength(500);

                    b.Property<string>("ControllerName")
                        .HasMaxLength(30);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Ip")
                        .HasMaxLength(46);

                    b.Property<string>("Method")
                        .HasMaxLength(10);

                    b.Property<string>("Operation")
                        .HasMaxLength(40);

                    b.Property<string>("QueryString")
                        .HasMaxLength(256);

                    b.Property<string>("Url")
                        .HasMaxLength(256);

                    b.Property<string>("UrlReferrer")
                        .HasMaxLength(256);

                    b.Property<string>("UserAgent")
                        .HasMaxLength(256);

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("system_action_log");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.UserRole", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("system_user_role");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxAccount", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("AppId")
                        .HasMaxLength(32);

                    b.Property<string>("AppSecret")
                        .HasMaxLength(512);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Image")
                        .HasMaxLength(256);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("OriginalId")
                        .HasMaxLength(50);

                    b.Property<string>("Token")
                        .HasMaxLength(30);

                    b.Property<short>("Type");

                    b.Property<string>("WeixinId")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("wechat_account");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxMenu", b =>
                {
                    b.Property<long>("Id");

                    b.Property<long>("AccountId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsIndividuation");

                    b.Property<string>("MenuData");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime?>("PublishTime");

                    b.Property<string>("WxMenuId")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("wechat_menu");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxQrcode", b =>
                {
                    b.Property<long>("Id");

                    b.Property<long>("AccountId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long?>("CreateUserId");

                    b.Property<string>("EventKey")
                        .HasMaxLength(64);

                    b.Property<int>("ExpireSeconds");

                    b.Property<bool>("IsDeleted");

                    b.Property<short>("PeriodType");

                    b.Property<string>("Purpose")
                        .HasMaxLength(128);

                    b.Property<int>("ScanCount");

                    b.Property<int>("SceneId");

                    b.Property<short>("SceneType");

                    b.Property<string>("Ticket")
                        .HasMaxLength(256);

                    b.Property<string>("Url")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CreateUserId");

                    b.ToTable("wechat_qrcode");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxUser", b =>
                {
                    b.Property<long>("Id");

                    b.Property<long>("AccountId");

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("HeadImgUrl")
                        .HasMaxLength(500);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSubscribe");

                    b.Property<string>("Language")
                        .HasMaxLength(20);

                    b.Property<string>("NickName")
                        .HasMaxLength(100);

                    b.Property<string>("OpenId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Province")
                        .HasMaxLength(100);

                    b.Property<string>("Remark")
                        .HasMaxLength(30);

                    b.Property<short>("Sex");

                    b.Property<DateTime?>("SubscribeTime");

                    b.Property<string>("UnionId")
                        .HasMaxLength(64);

                    b.Property<string>("UserTags")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("wechat_user");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxUserTag", b =>
                {
                    b.Property<long>("Id");

                    b.Property<long>("AccountId");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("wechat_user_tag");
                });

            modelBuilder.Entity("Vino.Core.TimedTask.TimedTask", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<bool>("AutoReset");

                    b.Property<DateTime>("BeginTime");

                    b.Property<DateTime>("ExpireTime");

                    b.Property<string>("Identifier")
                        .HasMaxLength(256);

                    b.Property<int>("Interval");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.Property<int>("RunTimes");

                    b.HasKey("Id");

                    b.ToTable("TimedTasks");
                });

            modelBuilder.Entity("Vino.Core.TimedTask.TimedTaskLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginTime");

                    b.Property<long>("Duration");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Result")
                        .HasMaxLength(20);

                    b.Property<string>("TaskId")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TimedTaskLogs");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Mall.ProductSku", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.Mall.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Material.MaterialGroup", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.User", "CreateUser")
                        .WithMany()
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Material.Picture", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.Material.MaterialGroup", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.User", "UploadUser")
                        .WithMany()
                        .HasForeignKey("UploadUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.Membership.Member", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.Membership.MemberType", "MemberType")
                        .WithMany()
                        .HasForeignKey("MemberTypeId");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.Menu", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.Menu", "Parent")
                        .WithMany("SubMenus")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.RoleFunction", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.Role", "Role")
                        .WithMany("RoleFunctions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.SmsQueue", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.Sms", "Sms")
                        .WithMany()
                        .HasForeignKey("SmsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.UserActionLog", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.System.UserRole", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vino.Core.CMS.Domain.Entity.System.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxMenu", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.WeChat.WxAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("Vino.Core.CMS.Domain.Entity.WeChat.WxMenuMatchRule", "MatchRule", b1 =>
                        {
                            b1.Property<long>("WxMenuId");

                            b1.Property<string>("City")
                                .HasMaxLength(40);

                            b1.Property<string>("Client")
                                .HasMaxLength(1);

                            b1.Property<string>("Country")
                                .HasMaxLength(40);

                            b1.Property<string>("Language")
                                .HasMaxLength(10);

                            b1.Property<string>("Province")
                                .HasMaxLength(40);

                            b1.Property<string>("Sex")
                                .HasMaxLength(1);

                            b1.Property<string>("TagId")
                                .HasMaxLength(20);

                            b1.ToTable("wechat_menu");

                            b1.HasOne("Vino.Core.CMS.Domain.Entity.WeChat.WxMenu")
                                .WithOne("MatchRule")
                                .HasForeignKey("Vino.Core.CMS.Domain.Entity.WeChat.WxMenuMatchRule", "WxMenuId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxQrcode", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.WeChat.WxAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vino.Core.CMS.Domain.Entity.WeChat.WxUser", "CreateUser")
                        .WithMany()
                        .HasForeignKey("CreateUserId");
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxUser", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.WeChat.WxAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vino.Core.CMS.Domain.Entity.WeChat.WxUserTag", b =>
                {
                    b.HasOne("Vino.Core.CMS.Domain.Entity.WeChat.WxAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
