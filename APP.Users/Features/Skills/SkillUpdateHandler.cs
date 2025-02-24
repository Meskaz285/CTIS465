
using CORE.APP.Features;
using MediatR;


namespace APP.Users.Features.Skills
{
    public class SkillUpdateHandler : IRequestHandler<SkillUpdateRequest, CommandResponse>
    {
        private readonly UsersDbContext _db;
        public SkillUpdateHandler(UsersDbContext db)
        {
            _db = db;
        }

        public async Task<CommandResponse> Handle(SkillUpdateRequest request, CancellationToken cancellationToken)
        {
            var skill = _db.Skills.FirstOrDefault(s => s.Id == request.Id);
            if (skill == null)
                return new CommandResponse(false, "Skill not found!");

            // Optionally, check for duplicate names
            if (_db.Skills.Any(s => s.Name == request.Name && s.Id != request.Id))
                return new CommandResponse(false, "Another skill with the same name exists!");

            skill.Name = request.Name;
            await _db.SaveChangesAsync(cancellationToken);
            return new CommandResponse(true, "Skill updated successfully.", skill.Id);
        }
    }
}