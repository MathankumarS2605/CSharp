namespace MVCEFApp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatients()
        {
            HospitalDbContext context = new HospitalDbContext();
            var list = context.Patients.ToList();
            return list;
        }
        public static Patient GetPatientsById(int id)
        {
            HospitalDbContext db = new HospitalDbContext();
            var doctor = db.Patients.Find(id);
            return doctor;
        }
        public static void AddNewPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Patients.Add(patient);
            ctx.SaveChanges();
        }
        public static void ModifyPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(patient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemovePatient(int id)
        {
            HospitalDbContext hospitalDbContext = new HospitalDbContext();
            Patient patient = hospitalDbContext.Patients.Find(id);
            hospitalDbContext.Patients.Remove(patient);
            hospitalDbContext.SaveChanges();
        }
    }
}
