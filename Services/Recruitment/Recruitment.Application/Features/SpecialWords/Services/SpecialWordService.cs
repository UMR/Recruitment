﻿using Recruitment.Application.Features.UpperCaseWords;

namespace Recruitment.Application.Features.SpecialWords;

public class UpperCaseWordService:IUpperCaseWordService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly ISpecialWordRepository _specialWordRepository;

    public UpperCaseWordService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, ISpecialWordRepository specialWordRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _specialWordRepository = specialWordRepository;
    }

    public async Task<List<UpperCaseWordListDto>> GetAllAsync()
    {
        var entitiesFromRepo = await _specialWordRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<UpperCaseWordListDto>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<UpperCaseWordListDto> GetByIdAsync(long id)
    {
        var entityFromRepo = await _specialWordRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<UpperCaseWordListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistWordAsync(string word, long? id = null)
    {
        return await _specialWordRepository.IsExistWordAsync(word, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateSpecialWordDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateUpperCaseWordDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new SpecialWord
        {
            Word = request.Word            
        };
        await _specialWordRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(long id, UpdateUpperCaseWordDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateUpperCaseWordDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.Id)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _specialWordRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        entity.Id = request.Id;
        entity.Word = request.Word;        
        await _specialWordRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(long id)
    {
        var response = new BaseCommandResponse();
        var entity = await _specialWordRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        await _specialWordRepository.DeleteAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
