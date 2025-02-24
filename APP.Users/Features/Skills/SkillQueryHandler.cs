using APP.Users.Domain;
using MediatR;


namespace APP.Users.Features.Skills
{
    public class SkillQueryHandler : IRequestHandler<SkillQueryRequest, IQueryable<Skill>>
    {
        private readonly UsersDbContext _db;
        public SkillQueryHandler(UsersDbContext db)
        {
            _db = db;
        }

        public Task<IQueryable<Skill>> Handle(SkillQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_db.Skills.AsQueryable());
        }
    }
}