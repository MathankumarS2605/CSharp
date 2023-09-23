using Microsoft.EntityFrameworkCore;

namespace MVCEFApp.Models
{
    public class RepositoryDoctor
    {
        public static List<Doctor>  GetDoctors()
        {
            HospitalDbContext context = new HospitalDbContext();
            var list=context.Doctors.ToList();
            return list;
        }
        public static Doctor GetDoctorById(int id) { 
            HospitalDbContext db = new HospitalDbContext();
            var doctor = db.Doctors.Find(id);
            return doctor;
        }
        public static void AddNewDoctor(Doctor doctor)
        {
            HospitalDbContext ctx= new HospitalDbContext(); 
            ctx.Doctors.Add(doctor);
            ctx.SaveChanges();
        }
        public static void ModifyDoctor(Doctor doctor) {
            HospitalDbContext ctx=new HospitalDbContext();
            ctx.Entry(doctor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
        } 
        public static void RemoveDoctor(int id)
        {
            HospitalDbContext hospitalDbContext = new HospitalDbContext();
            Doctor doctor = hospitalDbContext.Doctors.Find(id);
            hospitalDbContext.Doctors.Remove(doctor);
            hospitalDbContext.SaveChanges();
        }

    }
}
