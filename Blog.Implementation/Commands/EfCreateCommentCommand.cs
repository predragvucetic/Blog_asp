using AutoMapper;
using Blog.Application.Commands;
using Blog.Application.DataTransfer;
using Blog.Domain;
using Blog.EfDataAccess;
using Blog.Implementation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Implementation.Commands
{
    public class EfCreateCommentCommand : ICreateCommentCommand
    {
        private readonly BlogContext _context;
        private readonly CreateCommentValidator _validator;
        private readonly IMapper _mapper;

        public EfCreateCommentCommand(BlogContext context, CreateCommentValidator validator, IMapper mapper)
        {
            _context = context;
            _validator = validator;
            _mapper = mapper;
        }

        public int Id => 19;

        public string Name => "Create New Comment";

        public void Execute(CommentDto request)
        {
            _validator.ValidateAndThrow(request);

            var comment = _mapper.Map<Comment>(request);

            _context.Comments.Add(comment);

            _context.SaveChanges();
        }
    }
}
