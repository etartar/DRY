using DRY.DesignPatterns.StatePattern.Enums;
using DRY.DesignPatterns.StatePattern.Scenario1.Abstract;
using System.Collections.Generic;

namespace DRY.DesignPatterns.StatePattern.Scenario1.Concrete
{
    public class DesignationFactory
    {
        public static IList<IValidation> GetAllDesignationCriteria()
        {
            List<IValidation> criterias = new List<IValidation>();

            IValidation assistantSalesAssociate = new DepartmentValidation(Department.SALES,
                new ExperienceValidation(0, 5, 
                new QualificationValidation(Degree.HIGH_SCHOOL, null)));

            assistantSalesAssociate._designation = Designation.ASSISTANT_SALES_ASSOCIATE;

            IValidation salesAssociate1 = new DepartmentValidation(Department.SALES,
                new ExperienceValidation(0, 5,
                new QualificationValidation(Degree.BBA, null)));

            salesAssociate1._designation = Designation.SALES_ASSOCIATE;

            IValidation salesAssociate2 = new DepartmentValidation(Department.SALES,
                new ExperienceValidation(5, 10,
                new QualificationValidation(Degree.HIGH_SCHOOL, null)));

            salesAssociate2._designation = Designation.SALES_ASSOCIATE;

            criterias.Add(assistantSalesAssociate);
            criterias.Add(salesAssociate1);
            criterias.Add(salesAssociate2);

            return criterias;
        }
    }
}
