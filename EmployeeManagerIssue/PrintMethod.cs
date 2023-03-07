
namespace EmployeeManagerIssue
{
    public static class PrintMethod
    {
        public static void PrintEmployeeName(IEmployee employee)
        {
            Console.WriteLine("Employee Name is: " + employee.Name);
        }
    }
}
