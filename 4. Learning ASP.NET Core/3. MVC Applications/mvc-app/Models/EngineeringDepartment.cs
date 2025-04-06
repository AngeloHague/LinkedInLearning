namespace mvc_app.Models;

public class EngineeringDepartment
{
    public string[] CurrentSoftwareProjects { get; set; }

    public EngineeringDepartment()
    {
        // retrive data from DB or web service
        // hardcode for example
        CurrentSoftwareProjects = [
            "Project A",
            "Project B",
            "Project C",
            "Project D",
            "Project E"
    ];
    }
}