using CORE.APP.Features;
using MediatR;

namespace APP.Users.Features.Skills
{
    public class SkillDeleteRequest : Request, IRequest<CommandResponse>
    {
        public new int Id { get; set; }
    }
}