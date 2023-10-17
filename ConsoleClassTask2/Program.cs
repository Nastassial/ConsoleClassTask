/*
Каждый врач имеет метод «лечить», но каждый врач лечит по-своему.
*/

List<Doctor> doctors = new List<Doctor>()
{
    new Doctor("Вася", "хирург"),
    new Doctor("Петя", "терапевт"),
    new Doctor("Катя", "дантист")
};

List<Patient> patients = new List<Patient>()
{
    new Patient("Маша"),
    new Patient("Света", new CurePlan("1")),
    new Patient("Игорь")
};

public class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }
}

public class Doctor : Person
{
    public string? Post { get; }

    public Doctor(string name) : base(name)
    { }
    public Doctor(string name, string post): base(name) 
    {
        Post = post;
    }

    public void Cure() { }
}

public class Patient : Person
{
    public CurePlan? Plan { get; set; }

    public Doctor? Doctor { get; set; }
    public Patient(string name) : base(name) { }
    public Patient(string name, CurePlan plan) : this(name) 
    {
        Plan = plan;
    }
    public Patient(string name, CurePlan plan, Doctor doctor) : this(name, plan)
    {
        Doctor = doctor;
    }

    public void SetDoctor()
    {
        Doctor = Plan.Description switch
        {
            "1" => new Doctor("Вася", "хирург"),
            "2" => new Doctor("Вася", "дантист"),
            _ => new Doctor("Катя", "терапевт")
        };

        Doctor.Cure();
    }
}

public class CurePlan
{
    public string Description { get; set; }

    public CurePlan(string description)
    {
        Description = description;
    }
}