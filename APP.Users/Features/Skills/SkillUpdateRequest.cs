using CORE.APP.Features;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace APP.Users.Features.Skills
{
    public class SkillUpdateRequest : Request, IRequest<CommandResponse>
    {
        public new int Id { get; set; }

        [Required, StringLength(125)]
        public string? Name { get; set; }
    }
}