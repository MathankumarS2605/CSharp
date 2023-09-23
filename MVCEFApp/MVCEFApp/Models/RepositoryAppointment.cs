namespace MVCEFApp.Models
{
    public class RepositoryAppointment
    {
        public static List<Appointment> GetAppiontments()
        {
            HospitalDbContext context = new HospitalDbContext();
            var list = context.Appointments.ToList();
            return list;
        }
        public static Appointment GetAppointmentById(int id)
        {
            HospitalDbContext db = new HospitalDbContext();
            Appointment appointment = db.Appointments.Find(id);
            return appointment;
        }
        public static void AddNewAppointment(Appointment appointment)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Appointments.Add(appointment);
            ctx.SaveChanges();
        }
        public static void ModifyAppointment(Appointment appointment)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemovePatient(int id)
        {
            HospitalDbContext hospitalDbContext = new HospitalDbContext();
            Appointment appointment = hospitalDbContext.Appointments.Find(id);
            hospitalDbContext.Appointments.Remove(appointment);
            hospitalDbContext.SaveChanges();
        }
    }
}
