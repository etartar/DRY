using DRY.DesignPatterns.StatePattern.Scenario1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.DesignPatterns.StatePattern.Scenario1.Concrete
{
    public class DesignationFactory
    {
        public static IList<IValidation> GetAllDesignationCriteria()
        {
            List<IValidation> criterias = new List<IValidation>();

            IValidation assistantSalesAssociate = new DepartmentValidation(Enum.Department.SALES,
                new ExperienceValidation(0, 5, 
                new QualificationValidation(Enum.Degree.HIGH_SCHOOL, null)));

            assistantSalesAssociate._designation = Enum.Designation.ASSISTANT_SALES_ASSOCIATE;

            IValidation salesAssociate1 = new DepartmentValidation(Enum.Department.SALES,
                new ExperienceValidation(0, 5,
                new QualificationValidation(Enum.Degree.BBA, null)));

            salesAssociate1._designation = Enum.Designation.SALES_ASSOCIATE;

            IValidation salesAssociate2 = new DepartmentValidation(Enum.Department.SALES,
                new ExperienceValidation(5, 10,
                new QualificationValidation(Enum.Degree.HIGH_SCHOOL, null)));

            salesAssociate2._designation = Enum.Designation.SALES_ASSOCIATE;

            criterias.Add(assistantSalesAssociate);
            criterias.Add(salesAssociate1);
            criterias.Add(salesAssociate2);

            return criterias;
        }
    }
}
