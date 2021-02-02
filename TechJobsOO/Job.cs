using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
       

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType positiontype, CoreCompetency CoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = positiontype;
            JobCoreCompetency = CoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            return "\n" + "Id: " + $"{this.Id}" + "\n"
                                + "Name: " + $"{this.Name}" + "\n"
                                + "EmployerName: " + $"{ this.EmployerName}" + "\n"
                                + "EmployerLocation: " + $"{ this.EmployerLocation}" + "\n"
                                + "JobType: " + $"{ this.JobType}" + "\n"
                                + "JobCoreCompetency: " + $"{this.JobCoreCompetency}"+ "\n";
        }


        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
