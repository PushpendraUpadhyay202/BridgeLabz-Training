using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Manager
{

    internal class Queue
    {
        private ListNode head;
        private ListNode tail;
        private int size;

        private class ListNode
        {
            public Vehicle VehicleData;
            public ListNode Next;

            public ListNode(Vehicle vehicleData)
            {
                VehicleData = vehicleData;
            }
        }

        public void Enqueue(Vehicle vehicle)
        {
            ListNode node = new ListNode(vehicle);

            if (size == 0)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            size++;
        }

        public Vehicle Dequeue()
        {
            if (size == 0)
            {
                return null;
            }

            Vehicle removedVehicle = head.VehicleData;

            if (size == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
            }
            size--;
            return removedVehicle;
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

    }

}
