using ConsoleClassTask2.Classes;

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
