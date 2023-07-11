namespace Recruitment.Application.Features.ManageRole;

internal class UpdateRoleDtoValidator: AbstractValidator<UpdateRoleDto>
{
    private readonly IRoleService _roleService;

    public UpdateRoleDtoValidator(IRoleService roleService)
    {
        _roleService = roleService;   

        RuleFor(a => a.Id)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required");            

        RuleFor(a => a.name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(128).WithMessage("{PropertyName} must not exceed 500 characters");

        RuleFor(x => x)
           .Must(x => !IsExistRoleAsync(x.name,x.Id))
           .WithMessage("Role Name already exist");

    }

    private bool IsExistRoleAsync(string role, int id)
    {
        return _roleService.IsExistAsync(role, id).Result;
    }
}

