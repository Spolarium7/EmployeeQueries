using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoshenJimenez.EmployeeQueries.Windows.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<DataAccess>
    {
        protected override void Seed(DataAccess context)
        {
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063560"),
                FirstName = "Liliana",
                LastName = "Vess",
                Assignment = Models.Enums.Assignment.Field,
                EmailAddress = "lvess@mailinator.com",
                Salary = decimal.Parse("90000"),
                Status = Models.Enums.Status.Regular
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063561"),
                FirstName = "Jace",
                LastName = "Beleren",
                Assignment = Models.Enums.Assignment.Office,
                EmailAddress = "jbeleren@mailinator.com",
                Salary = decimal.Parse("110000"),
                Status = Models.Enums.Status.Regular
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063562"),
                FirstName = "Elspeth",
                LastName = "Tirel",
                Assignment = Models.Enums.Assignment.Office,
                EmailAddress = "etirel@mailinator.com",
                Salary = decimal.Parse("100500"),
                Status = Models.Enums.Status.Probationary
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063563"),
                FirstName = "Garruk",
                LastName = "Wildspeaker",
                Assignment = Models.Enums.Assignment.Office,
                EmailAddress = "gwildspeaker@mailinator.com",
                Salary = decimal.Parse("100800"),
                Status = Models.Enums.Status.Probationary
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063564"),
                FirstName = "Chandra",
                LastName = "Nalaar",
                Assignment = Models.Enums.Assignment.Office,
                EmailAddress = "cnalaar@mailinator.com",
                Salary = decimal.Parse("101000"),
                Status = Models.Enums.Status.Regular
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063565"),
                FirstName = "Sorin",
                LastName = "Markov",
                Assignment = Models.Enums.Assignment.Office,
                EmailAddress = "smarkov@mailinator.com",
                Salary = decimal.Parse("105000"),
                Status = Models.Enums.Status.Regular
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063566"),
                FirstName = "Tamiyo",
                LastName = "Moonsage",
                Assignment = Models.Enums.Assignment.Field,
                EmailAddress = "tmoonsage@mailinator.com",
                Salary = decimal.Parse("109000"),
                Status = Models.Enums.Status.Probationary
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063567"),
                FirstName = "Gideon",
                LastName = "Jura",
                Assignment = Models.Enums.Assignment.Field,
                EmailAddress = "gjura@mailinator.com",
                Salary = decimal.Parse("100400"),
                Status = Models.Enums.Status.Probationary
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063568"),
                FirstName = "Nissa",
                LastName = "Revane",
                Assignment = Models.Enums.Assignment.Field,
                EmailAddress = "nrevane@mailinator.com",
                Salary = decimal.Parse("100900"),
                Status = Models.Enums.Status.Regular
            });
            context.Employees.Add(new Models.Employee()
            {
                Id = Guid.Parse("56bac4c3-ef14-4f17-905d-5fb554063569"),
                FirstName = "Koth",
                LastName = "Hammer",
                Assignment = Models.Enums.Assignment.Field,
                EmailAddress = "khammer@mailinator.com",
                Salary = decimal.Parse("100800"),
                Status = Models.Enums.Status.Regular
            });
            context.SaveChanges();
        }
    }
}
