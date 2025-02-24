using APP.Users.Domain;
using CORE.APP.Features;
using MediatR;


namespace APP.Users.Features.Skills
{
    public class SkillCreateHandler : IRequestHandler<SkillCreateRequest, CommandResponse>
    {
        private readonly UsersDbContext _db;
        public SkillCreateHandler(UsersDbContext db)
        {
            _db = db;
        }

        public async Task<CommandResponse> Handle(SkillCreateRequest request, CancellationToken cancellationToken)
        {
            if (_db.Skills.Any(s => s.Name == request.Name))
                return new CommandResponse(false, "Skill with the same name exists!");

            var skill = new Skill { Name = request.Name };
            _db.Skills.Add(skill);
            await _db.SaveChangesAsync(cancellationToken);
            return new CommandResponse(true, "Skill created successfully.", skill.Id);
        }
    }
}