using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Manager
{
    internal class CircularLinkedList
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

        public void InsertAtHead(Vehicle vehicle)
        {
            ListNode node = new ListNode(vehicle);

            if (size == 0)
            {
                head = tail = node;
                head.Next = head;
                size++;
                return;
            }

            node.Next = head;
            tail.Next = node;
            head = node;
            size++;
            return;
        }

        public void InsertAtTail(Vehicle vehicle)
        {
            ListNode node = new ListNode(vehicle);

            if (size == 0)
            {
                head = tail = node;
                head.Next = head;
                size++;
                return;
            }

            tail.Next = node;
            node.Next = head;
            tail = node;
            size++;
            return;
        }

        public Vehicle DeleteFromHead()
        {
            if (size == 0)
            {
                return null;
            }

            Vehicle removedVehicle = null;

            if (size == 1)
            {
                removedVehicle = head.VehicleData;
                head = tail = null;
                size--;
                return removedVehicle;
            }

            removedVehicle = head.VehicleData;
            tail.Next = head.Next;
            head = head.Next;
            size--;
            return removedVehicle;
        }

        public Vehicle DeleteFromTail()
        {
            if (size == 0)
            {
                return null;
            }
            Vehicle removedVehicle = null;

            if (size == 1)
            {
                removedVehicle = head.VehicleData;
                head = tail = null;
                size--;
                return removedVehicle;
            }

            ListNode temp = head;

            while (temp.Next != tail)
            {
                temp = temp.Next;
            }

            removedVehicle = tail.VehicleData;
            temp.Next = head;
            tail = temp;
            size--;
            return removedVehicle;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Size()
        {
            return size;
        }

        public void PrintList()
        {
            if (head == null)
            {
                return;
            }

            ListNode temp = head;

            do
            {
                Console.WriteLine(temp.VehicleData);
                temp = temp.Next;
            } while (temp != head);
        }

    }
}
