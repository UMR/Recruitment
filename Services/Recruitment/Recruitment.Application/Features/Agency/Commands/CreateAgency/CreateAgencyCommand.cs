using AutoMapper;
using MediatR;
using Recruitment.Application.Contracts.Persistence;

namespace Recruitment.Application.Features.Agency.Commands.CreateAgency
{
    public class CreateAgencyCommand:IRequest<int>
    {
        public string AgencyName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        
    }

    public class CreateAgencyCommandHandler : IRequestHandler<CreateAgencyCommand, int>
    {
        private readonly IAgencyRepository _agencyRepository;
        private readonly IMapper _mapper;

        public CreateAgencyCommandHandler(IAgencyRepository agencyRepository, IMapper mapper)
        {
            _agencyRepository = agencyRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateAgencyCommand request, CancellationToken cancellationToken)
        {
            var agency = new Domain.Entities.Agency();
            agency.AgencyName = request.AgencyName;
            agency.CreatedBy = request.CreatedBy;
            agency.CreatedDate = DateTime.Now;

            return await _agencyRepository.CreateAgency(agency);

        }
    }
}
