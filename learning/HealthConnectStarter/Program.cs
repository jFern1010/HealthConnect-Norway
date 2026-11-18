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
    new Patient
    {
        Id = 4,
        FirstName = "Lars",
        LastName = "Berg",
        DateOfBirth = new DateOnly(2027, 1, 1),
        Gender = "male",
    },
    new Patient
    {
        Id = 5,
        FirstName = "Lara",
        LastName = " ",
        DateOfBirth = new DateOnly(2009, 1, 2),
        Gender = "female",
    }
};

Console.WriteLine("Welcome to HealthConnectStarter!");
Console.WriteLine($"Registered Patients: {patients.Count}");
Console.WriteLine();

var validPatients = new List<Patient>();
var rejectedPatients = new List<RejectedPatient>();
foreach (var patient in patients)
{
    try
    {
        patient.Validate();
        Console.WriteLine($"[OK] {patient.Id} {patient.GetFullName()} ({patient.GetInitials()}) - born {patient.DateOfBirth}, {patient.Gender}");
        validPatients.Add(patient);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"[REJECTED] {ex.Message}");
        rejectedPatients.Add(new RejectedPatient(patient, ex.Message));
    }
}
Console.WriteLine($"Valid: {validPatients.Count}, Rejected: {rejectedPatients.Count}");

int searchId = 4;
Patient? found = null;

foreach (var patient in validPatients)
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
foreach (var patient in validPatients)
{
    if (patient.Gender == "female")
    {
        femaleCount++;
    }
}

Console.WriteLine($"Female count: {femaleCount}");

foreach (var rejected in rejectedPatients)
{
    Console.WriteLine($"Rejected patient {rejected.Patient.GetFullName()} Reason: {rejected.Reason}");
}
