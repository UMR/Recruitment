namespace Recruitment.Application.Features.ManageRole;

internal class CreateRoleDtoValidator  : AbstractValidator<CreateRoleDto>
{
    private readonly IRoleService _roleService;
    public CreateRoleDtoValidator(IRoleService roleService)
    {
        _roleService = roleService;

        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

        RuleFor(x => x)
           .Must(x => !IsExistRoleAsync(x.Name))
           .WithMessage("Role Name already exist");
    }

    private bool IsExistRoleAsync(string role)
    {
        return _roleService.IsExistAsync(role).Result;
    }
}
