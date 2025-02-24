using APP.Users.Domain;
using CORE.APP.Features;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace APP.Users.Features.Skills
{
    public class SkillCreateRequest : Request, IRequest<CommandResponse>
    {
        [Required, StringLength(125)]
        public string? Name { get; set; }
    }
}