using DRY.DesignPatterns.StatePattern.Enums;
using DRY.DesignPatterns.StatePattern.Scenario1.Concrete;

namespace DRY.DesignPatterns.StatePattern.Scenario1.Abstract
{
    public abstract class IValidation
    {
        public Designation _designation;

        public IValidation _subValidationCriteria;

        protected IValidation(IValidation subValidationCriteria)
        {
            _subValidationCriteria = subValidationCriteria;
        }

        public abstract bool Validate(Employee employee);
    }
}
