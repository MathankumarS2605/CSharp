using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace NorthWindMVC.Models
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public  List<Employee> AllEmployees()
        {
           NorthwindContext ctx=new NorthwindContext();
            return ctx.Employees.ToList();  
        }    
    }
}
