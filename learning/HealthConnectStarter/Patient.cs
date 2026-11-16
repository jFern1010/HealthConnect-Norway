namespace HealthConnectStarter;

public class Patient
{
    public  int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public required string Gender { get; set; }

    public string GetFullName() => $"{FirstName} {LastName}";

    public string GetInitials() => $"{FirstName[0]}.{LastName[0]}.";
}