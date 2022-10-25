using AutoMapper;
using MediatR;
using Recruitment.Application.Contracts.Persistence;
using Recruitment.Application.Features.Menu.Queries;

namespace Recruitment.Application.Features.Agency.Queries
{
    public record GetAgenciesQuery : IRequest<List<AgencyDto>>;

    public class GetAgenciesQueryHandler : IRequestHandler<GetAgenciesQuery, List<AgencyDto>>
    {
        private readonly IAgencyRepository _agencyRepository;
        private readonly IMapper _mapper;

        public GetAgenciesQueryHandler(IAgencyRepository agencyRepository, IMapper mapper)
        {
            _agencyRepository = agencyRepository;
            _mapper = mapper;
        }

        public async Task<List<AgencyDto>> Handle(GetAgenciesQuery request, CancellationToken cancellationToken)
        {
            var agenciesFromRepo = await _agencyRepository.GetAgencies();
            return _mapper.Map<List<AgencyDto>>(agenciesFromRepo);
        }
    }
}
