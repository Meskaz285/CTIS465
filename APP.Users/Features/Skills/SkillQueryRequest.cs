using APP.Users.Domain;
using CORE.APP.Features;
using MediatR;


namespace APP.Users.Features.Skills
{
    public class SkillQueryRequest : Request, IRequest<IQueryable<Skill>>
    {
        // Optionally, add filtering or sorting properties here.
    }
}