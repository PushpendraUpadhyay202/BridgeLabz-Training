using System;
using System.Collections.Generic;
using System.Text;

namespace Parcel_Tracker
{
    class ParcelLinkedList
    {
        private ListNode head;
        private ListNode tail;
        private int size;

        private class ListNode
        {
            public Parcel ParcelData;
            public ListNode Next;
            public ListNode Prev;

            public ListNode(Parcel parcel)
            {
                ParcelData = parcel;
            }
        }

        public void InsertAtEnd(Parcel parcel)
        {
            ListNode node = new ListNode(parcel);

            if (head == null)
            {
                head = tail = node;
                size++;
                return;
            }
            node.Prev = tail;
            tail.Next = node;
            tail = node;
            size++;
        }

        public Parcel RemoveFromEnd()
        {
            if (size == 0)
            {
                return null;
            }
            Parcel removedParcel = null;

            // When there's only one node
            if (size == 1)
            {
                removedParcel = head.ParcelData;
                head = tail = null;
                size--;
                return removedParcel;
            }

            ListNode oldTail = tail;
            removedParcel = oldTail.ParcelData;
            tail = tail.Prev;
            tail.Next = null;
            oldTail.Prev = null;

            size--;
            return removedParcel;
        }

        public Parcel RemoveFromStart()
        {
            if (size == 0)
            {
                return null;
            }

            Parcel removedParcel = null;

            if (size == 1)
            {
                removedParcel = head.ParcelData;
                head = tail = null;
                size--;
                return removedParcel;
            }

            ListNode oldHead = head;
            removedParcel = oldHead.ParcelData;
            head = head.Next;
            head.Prev = null;
            oldHead.Next = null;
            size--;
            return removedParcel;
        }

        public Parcel RemoveByParcelName(string parcelName)
        {
            if (size == 0)
            {
                return null;
            }

            ListNode temp = head;

            while (temp != null && !temp.ParcelData.GetParcelName().Equals(parcelName))
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                return null;
            }

            if (temp == head)
            {
                return RemoveFromStart();
            }

            if (temp == tail)
            {
                return RemoveFromEnd();
            }

            Parcel removedParcel = temp.ParcelData;
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
            temp.Next = null;
            temp.Prev = null;
            size--;
            return removedParcel;
        }

        public Parcel RemoveByParcelId(int parcelId)
        {
            if (size == 0)
            {
                return null;
            }

            ListNode temp = head;

            while (temp != null && !(temp.ParcelData.GetParcelId() == parcelId))
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                return null;
            }

            if (temp == head)
            {
                return RemoveFromStart();
            }

            if (temp == tail)
            {
                return RemoveFromEnd();
            }

            Parcel removedParcel = temp.ParcelData;
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
            temp.Next = null;
            temp.Prev = null;
            size--;
            return removedParcel;
        }

        public void PrintList()
        {

            ListNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.ParcelData);
                temp = temp.Next;
            }
        }

        public bool IsParcelPresent(int parcelId)
        {
            ListNode temp = head;
            while (temp != null)
            {
                if (temp.ParcelData.GetParcelId() == parcelId)
                {
                    return true;
                }

                temp = temp.Next;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Size()
        {
            return size;
        }

        public Parcel FindParcelById(int parcelId)
        {
            ListNode temp = head;
            while (temp != null)
            {
                if (temp.ParcelData.GetParcelId() == parcelId)
                {
                    return temp.ParcelData;
                }
                temp = temp.Next;
            }

            return null;
        }
    }
}
