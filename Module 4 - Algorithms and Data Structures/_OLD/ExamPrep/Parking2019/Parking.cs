using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2019
{
    class Parking
    {
        private Car head;
        private Car tail;
        public int Count { get; private set; }

        public Parking()
        {
            head = null;
            tail = null;
        }

        public void AddCar(string carNum)
        {
            Car a = new Car(carNum);
            if (head == null)
            {
                head = a;
                tail = a;
            }
            else
            {
                tail.Next = a;
                tail = a;
            }
            Count++;
        }

        public void AddFancyCar(string carNum)
        {
            Car a = new Car(carNum);
            if (head == null)
            {
                head = a;
                tail = a;
            }
            else
            {
                a.Next = head;
                head = a;
            }
            Count++;
        }

        public Car CheckCarIsPresent(string reg)
        {
            Car current = head;
            while (current != null)
            {
                if (current.CarNumber == reg)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public bool ReleaseCar(string reg)
        {
            if (head != null && head.CarNumber == reg)
            {
                head = head.Next;
                Count--;
                return true;
            }

            Car current = head.Next;
            Car last = head;

            while (current != null)
            {
                if (current.CarNumber == reg)
                {
                    if (current == tail)
                    {
                        tail = last;
                    }

                    last.Next = current.Next;
                    Count--;
                    return true;
                }
                last = current;
                current = current.Next;
            }

            return false;
        }

        public bool ReleaseCar(int index)
        {
            if (index == 0 && head != null)
            {
                head = head.Next;
                Count--;
                return true;
            }

            Car current = head;
            Car last = head;

            for (int i = 0; i <= index; i++)
            {
                if (current == null)
                {
                    return false;
                }
                last = current;
                current = current.Next;
            }

            if (current == tail)
            {
                tail = last;
            }
            last.Next = current.Next;
            Count--;
            return true;
        }

        public StringBuilder ParkingInformation()
        {
            StringBuilder ret = new StringBuilder();

            Car current = head;
            while (current != null)
            {
                ret.AppendLine(current.ToString());
                current = current.Next;
            }

            return ret;
        }
    }
}
