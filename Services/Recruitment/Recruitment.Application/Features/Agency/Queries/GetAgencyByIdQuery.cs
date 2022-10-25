using AutoMapper;
using MediatR;
using Recruitment.Application.Contracts.Persistence;

namespace Recruitment.Application.Features.Menu.Queries
{
    public record GetAgencyByIdQuery : IRequest<AgencyDto> 
    {
        public int Id { get; set; }
    }

    public class GetAgencyQueryHandler : IRequestHandler<GetAgencyByIdQuery, AgencyDto>
    {
        private readonly IAgencyRepository _agencyRepository;
        private readonly IMapper _mapper;

        public GetAgencyQueryHandler(IAgencyRepository agencyRepository, IMapper mapper)
        {
            _agencyRepository = agencyRepository;
            _mapper = mapper;
        }

        public async Task<AgencyDto> Handle(GetAgencyByIdQuery request, CancellationToken cancellationToken)
        {
            var agencyFromRepo = await _agencyRepository.GetAgencyById(request.Id);
            return _mapper.Map<AgencyDto>(agencyFromRepo);
        }
    }
}
