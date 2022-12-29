﻿// <auto-generated />
using System;
using KalanchoeAI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KalanchoeAI.Migrations
{
    [DbContext(typeof(KalanchoeAIDatabaseContext))]
    partial class KalanchoeAIDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("KalanchoeAI.Models.Channel", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CommunityId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ChannelId");

                    b.HasIndex("CommunityId");

                    b.ToTable("Channel");
                });

            modelBuilder.Entity("KalanchoeAI.Models.ChannelComment", b =>
                {
                    b.Property<int>("ChannelCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChannelCommentValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ChannelId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChannelCommentId");

                    b.HasIndex("ChannelId");

                    b.ToTable("ChannelComment");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Chat", b =>
                {
                    b.Property<int>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("KalanchoeAI.Models.ChatComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChatValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("TimePosted")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("ChatComment");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Community", b =>
                {
                    b.Property<int>("CommunityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommunityId");

                    b.HasIndex("UserId");

                    b.ToTable("Community");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Follower", b =>
                {
                    b.Property<int?>("FollowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FollowerId");

                    b.HasIndex("UserId");

                    b.ToTable("Follower");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CommunityId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateLeft")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MemberId");

                    b.HasIndex("CommunityId");

                    b.HasIndex("UserId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("TEXT");

                    b.Property<string>("MessageValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("NoteValue")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PanelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("NoteId");

                    b.HasIndex("PanelId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Panel", b =>
                {
                    b.Property<int>("PanelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PanelId");

                    b.HasIndex("UserId");

                    b.ToTable("Panel");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Post", b =>
                {
                    b.Property<int?>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostValue")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("KalanchoeAI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Joined")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Channel", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Community", "Community")
                        .WithMany("Channels")
                        .HasForeignKey("CommunityId");

                    b.Navigation("Community");
                });

            modelBuilder.Entity("KalanchoeAI.Models.ChannelComment", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Channel", "Channel")
                        .WithMany("ChannelComments")
                        .HasForeignKey("ChannelId");

                    b.Navigation("Channel");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Chat", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Chats")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.ChatComment", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Chat", "Chat")
                        .WithMany("ChatComments")
                        .HasForeignKey("ChatId");

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Comment", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Community", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Communities")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Follower", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Followers")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Member", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Community", "Community")
                        .WithMany("Members")
                        .HasForeignKey("CommunityId");

                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Members")
                        .HasForeignKey("UserId");

                    b.Navigation("Community");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Message", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Note", b =>
                {
                    b.HasOne("KalanchoeAI.Models.Panel", "Panel")
                        .WithMany("Notes")
                        .HasForeignKey("PanelId");

                    b.Navigation("Panel");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Panel", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Panels")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Post", b =>
                {
                    b.HasOne("KalanchoeAI.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Channel", b =>
                {
                    b.Navigation("ChannelComments");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Chat", b =>
                {
                    b.Navigation("ChatComments");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Community", b =>
                {
                    b.Navigation("Channels");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Panel", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("KalanchoeAI.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("KalanchoeAI.Models.User", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("Comments");

                    b.Navigation("Communities");

                    b.Navigation("Followers");

                    b.Navigation("Members");

                    b.Navigation("Messages");

                    b.Navigation("Panels");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}