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
        private bool hasEmpty;

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
            if (currentRoom == rooms)
                this.hasEmpty = false;
            moves++;
            if (!petRooms.ContainsKey(currentRoom))
            {
                petRooms.Add(currentRoom, pet);
                return true;
            }
            return false;
            //Console.WriteLine("Added");
        }
        public bool Release()
        {
            int room = this.rooms / 2 + 1;
            Reset();
            while (true)
            {
                if (petRooms.ContainsKey(room))
                {
                    petRooms.Remove(room);
                    return true;
                }
                room++;
                if (room == this.rooms)
                    room = 1;
                if (room == this.rooms / 2 + 1)
                    return false;
                
            }
        }
        public bool HasEmptyRooms()
        {
            return this.hasEmpty;
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
            hasEmpty = true;
        }

    }
}
