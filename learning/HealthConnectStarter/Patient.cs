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

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(FirstName))
            throw new ArgumentException($"Patient {Id}: first name is required.");
        
        if (string.IsNullOrWhiteSpace(LastName))
            throw new ArgumentException($"Patient {Id}: last name is required.");

        if (DateOfBirth > DateOnly.FromDateTime(DateTime.Now))
            throw new ArgumentException($"Patient {Id}: date of birth cannot be in the future");
    }
}