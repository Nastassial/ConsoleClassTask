
List<Patient> patients = new List<Patient>()
{
    new Patient(),
    new Patient(new CurePlan("1")),
    new Patient(new CurePlan("5"))
};

for (int i = 0; i < patients.Count; i++)
{
    Console.Write($"Пациент номер {i + 1}: ");
    patients[i].SetDoctor();
}

public class Doctor
{
    private readonly string _post;

    public Doctor(string post)
    {
        _post = post;
    }

    public string Cure() => _post switch
    {
        "хирург" => "делаем операцию",
        "терапевт" => "пьем таблетки",
        "дантист" => "чистим зубы",
        _ => "Вы здоровы!"
    };
}

public class Patient
{
    public CurePlan? Plan { get; set; }

    private Doctor? _doctor;

    public Patient() { }

    public Patient(CurePlan plan)
    {
        Plan = plan;
    }

    public void SetDoctor()
    {
        if (Plan == null)
        {
            Console.WriteLine("Невозможно назначить врача, т.к. нет плана лечения");
            return;
        }

        _doctor = Plan.GetDescription() switch
        {
            "1" => new Doctor("хирург"),
            "2" => new Doctor("дантист"),
            _ => new Doctor("терапевт")
        };

        Console.WriteLine(_doctor.Cure());
    }
}

public class CurePlan
{
    private string _description;

    public CurePlan(string description)
    {
        _description = description;
    }

    public string GetDescription() => _description;
}