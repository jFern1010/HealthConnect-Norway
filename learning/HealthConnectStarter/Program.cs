using HealthConnectStarter;

var patients = new List<Patient>
{
    new Patient
    {
        Id = 1,
        FirstName = "Kari",
        LastName = "Nordmann",
        DateOfBirth = new DateOnly(1985, 3, 12),
        Gender = "female",
    },
    new Patient
    {
        Id = 2,
        FirstName = "Ola",
        LastName = "Nordmann",
        DateOfBirth = new DateOnly(1952, 7, 30),
        Gender = "male",
    },
    new Patient
    {
        Id = 3,
        FirstName = "Sigrid",
        LastName = "Hansen",
        DateOfBirth = new DateOnly(2001, 11, 5),
        Gender = "female",
    },
};

Console.WriteLine("Welcome to HealthConnectStarter!");
Console.WriteLine($"Registered Patients: {patients.Count}");
Console.WriteLine();

foreach (var patient in patients)
{
    Console.WriteLine($"{patient.Id} {patient.GetFullName()} ({patient.GetInitials()}) - born {patient.DateOfBirth}, {patient.Gender}");
}
Console.WriteLine();

int searchId = 2;
Patient? found = null;

foreach (var patient in patients)
{
    if (patient.Id == searchId)
    {
        found = patient;
        break;
    }
}

if (found is not null)
{
    Console.WriteLine($"Found patient {searchId}: {found.GetFullName()}");
}
else
{
    Console.WriteLine($"No patient with ID {searchId}");
}

int femaleCount = 0;
foreach (var patient in patients)
{
    if (patient.Gender == "female")
    {
        femaleCount++;
    }
}

Console.WriteLine($"Female count: {femaleCount}");