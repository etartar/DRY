using DRY.DesignPatterns.StatePattern.Enums;
using DRY.DesignPatterns.StatePattern.Scenario1.Abstract;

namespace DRY.DesignPatterns.StatePattern.Scenario1.Concrete
{
    public class QualificationValidation : IValidation
    {
        public Degree _qualification;

        public QualificationValidation(Degree qualification, IValidation subValidationCriteria) : base(subValidationCriteria)
        {
            _qualification = qualification;
        }

        public override bool Validate(Employee employee)
        {
            return (employee.qualification == _qualification) && _subValidationCriteria.Validate(employee);
        }
    }
}
