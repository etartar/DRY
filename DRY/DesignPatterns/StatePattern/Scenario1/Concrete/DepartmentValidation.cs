using DRY.DesignPatterns.StatePattern.Enums;
using DRY.DesignPatterns.StatePattern.Scenario1.Abstract;

namespace DRY.DesignPatterns.StatePattern.Scenario1.Concrete
{
    public class DepartmentValidation : IValidation
    {
        public Department _department;

        public DepartmentValidation(Department department, IValidation subValidationCriteria) : base(subValidationCriteria)
        {
            _department = department;
        }

        public override bool Validate(Employee employee)
        {
            return employee.department == _department && _subValidationCriteria.Validate(employee);
        }
    }
}
