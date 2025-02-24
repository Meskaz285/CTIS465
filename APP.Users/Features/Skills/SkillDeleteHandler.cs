using APP.Users.Domain;
using CORE.APP.Features;
using MediatR;


namespace APP.Users.Features.Skills
{
    public class SkillDeleteHandler : IRequestHandler<SkillDeleteRequest, CommandResponse>
    {
        private readonly UsersDbContext _db;
        public SkillDeleteHandler(UsersDbContext db)
        {
            _db = db;
        }

        public async Task<CommandResponse> Handle(SkillDeleteRequest request, CancellationToken cancellationToken)
        {
            var skill = _db.Skills.FirstOrDefault(s => s.Id == request.Id);
            if (skill == null)
                return new CommandResponse(false, "Skill not found!");

            _db.Skills.Remove(skill);
            await _db.SaveChangesAsync(cancellationToken);
            return new CommandResponse(true, "Skill deleted successfully.", request.Id);
        }
    }
}