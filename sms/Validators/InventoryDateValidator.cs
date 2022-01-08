using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using sms.Models;

namespace ERPSystem.Validators
{
    public class InventoryDateValidator : AbstractValidator<Inventory>
    {
        public InventoryDateValidator()
        {
            RuleFor(m => m.InventoryDate)
                .LessThan(m => m.DecommissionDate)
                .WithMessage("Дата оприбуткування повинна бути до дати списання");

            RuleFor(m => m.DecommissionDate)
                .GreaterThan(m => m.InventoryDate)
                .WithMessage("Дата списання повинна бути пізніше дати оприбуткування");
        }
    }
}
