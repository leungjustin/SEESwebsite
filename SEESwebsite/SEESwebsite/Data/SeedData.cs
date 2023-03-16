using Microsoft.AspNetCore.Identity;
using SEESwebsite.Models;

namespace SEESwebsite.Data
{
    public class SeedData
    {
        public static void Seed(AppDbContext context, IServiceProvider services)
        {
            if (!context.Events.Any())
            {
                #region employee seed data
                var userManager = services.GetRequiredService<UserManager<Employee>>();
                const string SEED_PASSWORD = "password";
                Employee employee = new Employee { Email = "employee-se1@sees.com" };
                var result = userManager.CreateAsync(employee, SEED_PASSWORD).Result;
                #endregion

                #region venue seed data
                Venue venue = new Venue
                {
                    VenueName = "University of Oregon",
                    Address = "1585 E 13th Ave",
                    City = "Eugene",
                    State = "OR",
                    ZipCode = "97403"
                };
                context.Venues.Add(venue);
                context.SaveChanges();
                #endregion

                #region event seed data
                Event securityEvent = new Event
                {
                    EventName = "Concert Security",
                    EventStartDate = DateTime.Now,
                    EventEndDate = DateTime.Now,
                    Venue = venue,
                    EventNotes = "Door security for UO concert."
                };
                context.Events.Add(securityEvent);
                context.SaveChanges();
                #endregion

                #region shift seed data
                Shift shift = new Shift
                {
                    ShiftStartTime = DateTime.Now,
                    ShiftEndTime = DateTime.Now,
                    Event = securityEvent,
                    Employee = employee
                };
                context.Shifts.Add(shift);
                context.SaveChanges();
                #endregion

                #region incident report seed data
                IncidentReport incidentReport = new IncidentReport
                {
                    Employee = employee,
                    IncidentDate = DateTime.Now,
                    Event = securityEvent,
                    Subject = "This is a subject line",
                    ReportDetails = "These are the details of the incident report.",
                    WasReviewed = false
                };
                context.IncidentReports.Add(incidentReport);
                context.SaveChanges();
                #endregion
            }
        }
    }
}
