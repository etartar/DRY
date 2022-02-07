using DRY.DesignPatterns.StatePattern.Scenario1.Concrete;
using DRY.DesignPatterns.StatePattern.Scenario1.Enum;

namespace DRY.DesignPatterns.StatePattern.Scenario1
{
    public class BadCode
    {
        public static Designation GetDesignation(Employee employee)
        {
            if (employee.department == Department.SALES)
            {
                if (employee.yearsOfExperience < 5)
                {
                    if (employee.qualification == Degree.HIGH_SCHOOL)
                        return Designation.ASSISTANT_SALES_ASSOCIATE;
                    else if (employee.qualification == Degree.BBA)
                        return Designation.SALES_ASSOCIATE;
                    else if (employee.qualification == Degree.MBA)
                        return Designation.SALES_MANAGER;
                    else
                        return Designation.UNKNOWN;
                }
                else if (employee.yearsOfExperience >= 5 && employee.yearsOfExperience < 10)
                {
                    if (employee.qualification == Degree.HIGH_SCHOOL)
                        return Designation.SALES_ASSOCIATE;
                    else if (employee.qualification == Degree.BBA)
                        return Designation.Account_Executive;
                    else if (employee.qualification == Degree.MBA)
                        return Designation.SENIOR_SALES_MANAGER;
                    else
                        return Designation.UNKNOWN;
                }
                else
                {
                    return Designation.REGIONAL_HEAD;
                }
            }
            else if (employee.department == Department.ENGINEERING)
            {
                if (employee.yearsOfExperience < 5)
                {
                    if (employee.qualification == Degree.Btech || employee.qualification == Degree.BE)
                        return Designation.ASSISTANT_ENGINEER;
                    else if (employee.qualification == Degree.Mtech || employee.qualification == Degree.Phd)
                        return Designation.ASSOCIATE_ENGINEER;
                    else 
                        return Designation.UNKNOWN;
                }
                else
                {
                    if (employee.qualification == Degree.Btech || employee.qualification == Degree.BE)
                        return Designation.ASSOCIATE_ENGINEER;
                    else if (employee.qualification == Degree.Mtech || employee.qualification == Degree.Phd)
                        return Designation.ENGINEER_LEAD;
                    else 
                        return Designation.UNKNOWN;
                }
            }
            else
            {
                return Designation.UNKNOWN;
            }
        }
    }
}
