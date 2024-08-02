/*
Создайте приложение для учета сотрудников, которое должно хранить
следующую информацию:
 Ф.И.О;
 должность;
 заработная плата;
 корпоративный email.
Для хранения данных сотрудников используйте класс
List<T>.
Приложение должно предоставлять следующую функциональность:
 добавлять сотрудников;
 удалять сотрудников;
 изменять информацию о сотрудниках;
 поиск сотрудников по параметрам;
 сортировка сотрудников по параметрам;  сортировка сотрудников по параметрам.
  */

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============");
            EmployeeAccounting.AddEmployee(new Employee("Emily", "Johnson", "Marie", "Data Scientist", 105000, "emily.johnson@company.com"));
            EmployeeAccounting.AddEmployee(new Employee("John", "Doe", "Michael", "Software Engineer", 85000, "john.doe@company.com"));
            EmployeeAccounting.AddEmployee(new Employee("Jane", "Smith", "Alice", "Product Manager", 95000, "jane.smith@company.com"));
            EmployeeAccounting.AddEmployee(new Employee("Alex", "Brown", "James", "UX Designer", 75000, "alex.brown@company.com"));
            EmployeeAccounting.Show();

            Console.WriteLine("===============");
            FullName removeFullName = new FullName("Emily", "Johnson", "Marie");
            bool emplIsRemove = EmployeeAccounting.RemoveEmployee(removeFullName);
            Console.WriteLine(emplIsRemove ? $"--{removeFullName} successfully deleted" : $"--Error deleted {removeFullName}");

            Console.WriteLine("===============");
            FullName changeFullName = new FullName("John", "Doe", "Michael");
            Employee emplChangeData = EmployeeAccounting.FindEmployee(EmployeeAccounting.FindByFullName(changeFullName));
            Console.WriteLine(emplChangeData); 
            bool emplDataIsChange = EmployeeAccounting.ChangeEmployeeData(changeFullName, (empl) => { empl.Salary = 100; });
            Console.WriteLine((emplDataIsChange ? $"--Salary successfully changed" : "--Error changed"));
            Console.WriteLine(emplChangeData); 

            Console.WriteLine("===============");
            Console.WriteLine(EmployeeAccounting.FindEmployee(EmployeeAccounting.FindByFullName(changeFullName)));
            Console.WriteLine(EmployeeAccounting.FindEmployee(EmployeeAccounting.FindByEmail("alex.brown@company.com")));

            Console.WriteLine("===============");
            EmployeeAccounting.SortList(EmployeeAccounting.SortByName());
            EmployeeAccounting.Show();

        }
    }
}
