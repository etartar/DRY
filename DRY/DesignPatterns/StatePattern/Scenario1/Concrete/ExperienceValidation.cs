using DRY.DesignPatterns.StatePattern.Scenario1.Abstract;

namespace DRY.DesignPatterns.StatePattern.Scenario1.Concrete
{
    public class ExperienceValidation : IValidation
    {
        public int _minExp;
        public int _maxExp;

        public ExperienceValidation(int minExp, int maxExp, IValidation subValidationCriteria) : base(subValidationCriteria)
        {
            _minExp = minExp;
            _maxExp = maxExp;
        }

        public override bool Validate(Employee employee)
        {
            return (employee.yearsOfExperience >= _minExp && employee.yearsOfExperience < _maxExp) 
                    && _subValidationCriteria.Validate(employee);
        }
    }
}
