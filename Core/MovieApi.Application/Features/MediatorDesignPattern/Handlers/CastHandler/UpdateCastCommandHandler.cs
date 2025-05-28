using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandler
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;

        public UpdateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var values= await _context.Casts.FindAsync(request.CastId);
            values.Name = request.Name;
            values.Surname = request.Surname;
            values.Title = request.Title;
            values.ImageUrl = request.ImageUrl;
            values.Overview = request.Overview;
            values.Biography = request.Biography;
            await _context.SaveChangesAsync();
        }
    }
}
