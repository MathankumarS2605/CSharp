
using System.ComponentModel.DataAnnotations;
using System.IO.IsolatedStorage;


Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
string dobString = String.Empty;
try
{
    dobString = Console.ReadLine();
    if (dobString == null)
    {
        Console.WriteLine("Date Of Birth is NULL!!!");
        return;
    }
    // Parse the date of birth
    DateTime dob = DateTime.Parse(dobString);



    // Calculate the age
    DateTime now = DateTime.Now;
    int ageYears = now.Year - dob.Year;
    if (now < dob.AddYears(ageYears))
    {
        ageYears--;
        Console.WriteLine(now + " < " + dob.AddYears(ageYears));
    }
    Console.WriteLine(now + " < " + dob.AddYears(ageYears));
    int ageMonths = now.Month - dob.Month;
    if (now < dob.AddMonths(ageMonths).AddDays(now.Day - dob.Day))
    {
        ageMonths--;
    }
    int ageDays = now.Day - dob.Day;
    if (now.Day < dob.Day)
    {
        ageDays += DateTime.DaysInMonth(now.Year, now.Month);
    }
    // Print the age
    Console.WriteLine(
        $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
    );
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

