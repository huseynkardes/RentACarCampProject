using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.CreateBrand
{
	public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
	{
		public CreateBrandCommandValidator() {

			RuleFor(c => c.Name).NotEmpty().WithMessage("Lütfen bu alanı doldurunuz");
			RuleFor(c =>c.Name).MinimumLength(2).WithMessage("Marka adı en az 2 karakterli olmalıdır.");
		}
	}
}
