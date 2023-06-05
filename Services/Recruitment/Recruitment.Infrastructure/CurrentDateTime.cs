using Recruitment.Application.Contracts.Infrastructure;

namespace Recruitment.Infrastructure;

public class CurrentDateTime : IDateTime
{
    public DateTime Now => DateTime.Now;

    public int CurrentYear => DateTime.Now.Year;

    public int CurrentMonth => DateTime.Now.Month;

    public int CurrentDay => DateTime.Now.Day;
}
