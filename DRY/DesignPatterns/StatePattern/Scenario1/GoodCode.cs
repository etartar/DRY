using DRY.DesignPatterns.StatePattern.Enums;
using DRY.DesignPatterns.StatePattern.Scenario1.Abstract;
using DRY.DesignPatterns.StatePattern.Scenario1.Concrete;
using System.Collections.Generic;

namespace DRY.DesignPatterns.StatePattern.Scenario1
{
    public class GoodCode
    {
        public static Designation GetDesignation(Employee employee)
        {
            IList<IValidation> validations = DesignationFactory.GetAllDesignationCriteria();
            foreach (IValidation validation in validations)
            {
                if (validation.Validate(employee))
                    return validation._designation;
            }

            return Designation.UNKNOWN;
        }
    }
}
