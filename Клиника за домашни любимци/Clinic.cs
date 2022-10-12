using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клиника_за_домашни_любимци
{
    public class Clinic
    {
        private int rooms;
        private Dictionary<int, Pet> petRooms;
        private int currentRoom;
        private int moves;

        public Clinic(int rooms)
        {
            if (rooms % 2 == 0)
                throw new ArgumentException("Invalid count of rooms!");
            petRooms = new();
            this.rooms = rooms;
            this.currentRoom = rooms / 2 + 1;
            moves = 0;
        }

        public void Add(Pet pet)
        {
            if (currentRoom == rooms)
                throw new IndexOutOfRangeException("No more rooms!");
            if (moves % 2 == 0)
            {
                currentRoom += moves;
            }
            else
            {
                currentRoom -= moves;
            }
            moves++;
            petRooms.Add(currentRoom ,pet);
        }
        public void Remove(Pet pet, int room)
        {
           // petRooms[room].Remove(pet);
        }
        public void PrintRoom(int room)
        {
            /*foreach (var pet in petRooms[room])
            {
                Console.WriteLine(pet);
            }*/
        }
        public void PrintAllRooms()
        {
            foreach (var room in petRooms)
            {
                Console.WriteLine(room);
            }
        }

    }
}
