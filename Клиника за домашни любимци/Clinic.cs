using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клиника_за_домашни_любимци
{
    public class Clinic
    {
        public string Name { get; set; }
        private int rooms;
        private Dictionary<int, Pet> petRooms;
        private int currentRoom;
        private int moves;

        public Clinic(string name, int rooms)
        {
            if (rooms % 2 == 0)
                throw new ArgumentException("Invalid count of rooms!");
            this.Name = name;
            this.petRooms = new();
            this.rooms = rooms;
            Reset();
        }

        public bool Add(Pet pet)
        {
            if (!HasEmptyRooms())
                return false;
            if (moves % 2 == 0)
            {
                currentRoom += moves;
            }
            else
            {
                currentRoom -= moves;
            }
            if (currentRoom == rooms + 1)
                return false;
            moves++;
            if (!petRooms.ContainsKey(currentRoom))
            {
                petRooms.Add(currentRoom, pet);
                return true;
            }
            return false;
        }
        public bool Release()
        {
            int room = this.rooms / 2 + 1;
            bool result = false;
            Reset();
            for(int i = 1; i <= this.rooms; i++)
            {
                if (petRooms.ContainsKey(room))
                {
                    petRooms.Remove(room);
                    result = true;
                    break;
                }
                room++;
                if (room == this.rooms)
                    room = 1;
            }
            return result;
        }
        public bool HasEmptyRooms()
        {
            for (int i = 1; i <= rooms; i++)
            {
                if (!petRooms.ContainsKey(i))
                    return true;
            }
            return false;
        }
        public void PrintRoom(int room)
        {
            if (petRooms.ContainsKey(room))
                Console.WriteLine(petRooms[room]);
            else 
                Console.WriteLine("Room empty");
        }
        public void PrintAllRooms()
        {
            for (int i = 1; i <= rooms; i++)
            {
                if (petRooms.ContainsKey(i))
                    Console.WriteLine(petRooms[i]);
                else
                    Console.WriteLine("Room empty");
            }
        }
        public void Reset()
        {
            this.moves = 0;
            this.currentRoom = this.rooms / 2 + 1;
        }

    }
}
