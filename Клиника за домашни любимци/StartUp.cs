namespace Клиника_за_домашни_любимци
{
    public class StartUp
    {
        static void Main()
        {
            Clinic clinic = new(5);
            Pet pet1 = new("1", 10, "");
            Pet pet2 = new("2", 10, "");
            Pet pet3 = new("3", 10, "");
            Pet pet4 = new("4", 10, "");
            Pet pet5 = new("5", 10, "");
            clinic.Add(pet1);
            clinic.Add(pet2);
            clinic.Add(pet3);
            clinic.Add(pet4);
            clinic.Add(pet5);
            clinic.Add(pet5);
            clinic.Add(pet5);
        }
    }
}