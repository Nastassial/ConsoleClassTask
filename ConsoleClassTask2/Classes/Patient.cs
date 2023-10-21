namespace ConsoleClassTask2.Classes;

internal class Patient
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

        _doctor = Plan.Description switch
        {
            "1" => new Surgeon(),
            "2" => new Dentist(),
            _ => new Therapist()
        };

        Console.WriteLine(_doctor.Cure());
    }
}
