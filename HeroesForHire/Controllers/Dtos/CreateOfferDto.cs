using System;
using FluentValidation;

namespace HeroesForHire.Controllers.Dtos
{
    public class CreateOfferDto
    {
        public string TaskId { get; set; }
        public Guid OrderId { get; set; }
        public Guid SelectedHero { get; set; }
    }
    
    public class CreateOfferDtoValidator : AbstractValidator<CreateOfferDto>
    {
        public CreateOfferDtoValidator()
        {
            RuleFor(x => x.TaskId).NotEmpty();
            RuleFor(x => x.OrderId).NotEmpty();
            RuleFor(x => x.SelectedHero).NotEmpty();
        }
    }
}