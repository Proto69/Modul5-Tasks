namespace Клиника_за_домашни_любимци
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Pet> pets = new(); 
            Dictionary<string, Clinic> clinics = new();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                try
                {
                    switch (input[0])
                    {
                        case "Create":
                            if (input[1] == "Pet")
                            {
                                Pet pet = new(input[2], int.Parse(input[3]), input[4]);
                                pets.Add(pet.Name, pet);
                            }
                            else if (input[1] == "Clinic")
                            {
                                Clinic clinic = new(input[2], int.Parse(input[3]));
                                clinics.Add(clinic.Name, clinic);
                            }
                            break;
                        case "HasEmptyRooms":
                            Console.WriteLine(clinics[input[1]].HasEmptyRooms());
                            break;
                        case "Release":
                            Console.WriteLine(clinics[input[1]].Release());
                            break;
                        case "Add":
                            Console.WriteLine(clinics[input[2]].Add(pets[input[1]]));
                            break;
                        case "Print":
                            if (input.Count == 2)
                            {
                                clinics[input[1]].PrintAllRooms();
                            }
                            else
                            {
                                clinics[input[1]].PrintRoom(int.Parse(input[2]));
                            }
                            break;
                    }
                }
                catch(Exception k)
                {
                    Console.WriteLine(k.Message);
                }
            }

        }
    }
}