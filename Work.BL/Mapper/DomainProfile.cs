using AutoMapper;
using Work.BL.Models;
using Work.DAL.Entity;

namespace Work.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Post, PostVM>();
            CreateMap<PostVM, Post>();
            
            CreateMap<Project, ProjectVM>();
            CreateMap<ProjectVM, Project>();
            
            CreateMap<ProjectAttachments, ProjectAttachmentsVM>();
            CreateMap<ProjectAttachmentsVM, ProjectAttachments>();
            

            CreateMap<Chat ,ChatVM>();
            CreateMap<ChatVM, Chat>();

            CreateMap<Reply ,ReplyVM>();
            CreateMap<ReplyVM, Reply>();

            CreateMap<Request, RequestVM>();
            CreateMap<RequestVM, Request>();

            CreateMap<Rate, RateVM>();
            CreateMap<RateVM, Rate>();
        }
    }
}
