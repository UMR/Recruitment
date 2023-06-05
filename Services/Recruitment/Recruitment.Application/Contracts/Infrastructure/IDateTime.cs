namespace Recruitment.Application.Contracts.Infrastructure
{
    public interface IDateTime
    {
        DateTime Now { get; }

        int CurrentYear { get; }

        int CurrentMonth { get; }

        int CurrentDay { get; }
    }
}
