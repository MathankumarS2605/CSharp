namespace MVCNorthwind.Models
{
    public class RepositoryEmployee
    {
        private readonly NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext northwindContext) {
            _context = northwindContext;
        }
        public List<Employee> Employees()
        {
            return _context.Employees.ToList();
        }
    }
}
