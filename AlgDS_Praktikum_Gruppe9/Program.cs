﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementierung einer abfrage für die Bedienung der Software möglich über switch case etc -> muss vervollständigt werden 
            Console.WriteLine("Prakikum Gruppe 9");
            Console.Write("Welche Funktion möchten Sie bedienen \n1: MultiSetUnsorted \n2: SetUnsorted \n3: MultiSetSorted \n4: SetSorted \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestMultiSetUnsorted();
                    break;
                case 2:
                    TestSetUnsorted();
                    break;
                case 3:
                    TestMultiSetSorted();
                    break;
                case 4:
                    TestSetSorted();
                    break;
                default:
                    break;
            }
            Console.WriteLine();;
            Console.ReadKey();
        }

        private static void TestSetSorted()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: LinkedList \n2: Array \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestSetSortedLinkedList();
                    break;
                default:
                    break;
            }
        }

        private static void TestMultiSetSorted()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: LinkedList \n2: Array \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestMultiSetSortedLinkedList();
                    break;
                default:
                    break;
            }
        }

        

        private static void TestSetUnsorted()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: LinkedList \n2: Array \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestSetUnsortedLinkedList();
                    break;
                default:
                    break;
            }
        }

        private static void TestMultiSetUnsorted()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: LinkedList \n2: Array \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestMultiSetUnsortedLinkedList();
                    break;
                default:
                    break;
            }
        }
        public static void TestMultiSetSortedLinkedList()
        {
            MultiSetSortedLinkedList multiSetSortedLinkedList = new MultiSetSortedLinkedList();
            multiSetSortedLinkedList.insert(2);
            multiSetSortedLinkedList.insert(2);
            multiSetSortedLinkedList.insert(6);
            multiSetSortedLinkedList.insert(4);
            multiSetSortedLinkedList.insert(4);
            multiSetSortedLinkedList.delete(4);
            multiSetSortedLinkedList.print();
        }
        public static void TestSetSortedLinkedList()
        {
            SetSortedLinkedList setSortedLinkedList = new SetSortedLinkedList();
            setSortedLinkedList.insert(7);
            setSortedLinkedList.insert(11);
            setSortedLinkedList.insert(11);
            setSortedLinkedList.insert(11);
            setSortedLinkedList.insert(9);
            setSortedLinkedList.insert(10);
            setSortedLinkedList.print();
        }

        public static void TestMultiSetUnsortedLinkedList()
        {
            MultiSetUnsortedLinkedList multiSetUnsortedLinkedList = new MultiSetUnsortedLinkedList();
            //Console.Write("Wählen Sie eine Funktion: \n1: Einfügen\n2: Löschen\n3: Suchen\n4: Ausgeben \n5: Automatische Liste Generieren");
            //string eingabe = Console.ReadLine();
            //int auswahl = Convert.ToInt32(eingabe);
            //switch (auswahl)
            //{
            //    case 1:
            //        Console.Write("Welchen Wert wollen Sie Einfügen: ");
            //        string eingabe1 = Console.ReadLine();
            //        int auswahl1 = Convert.ToInt32(eingabe1);
            //        multiSetUnsortedLinkedList.insert(auswahl1);
            //        break;
            //    case 2:
            //        TestSetUnsorted();
            //        break;
            //    case 3:
            //        TestMultiSetSorted();
            //        break;
            //    case 4:
            //        TestSetSorted();
            //        break;
            //    default:
            //        break;
            //}
            multiSetUnsortedLinkedList.insert(3);
            multiSetUnsortedLinkedList.insert(5);
            multiSetUnsortedLinkedList.insert(4);
            multiSetUnsortedLinkedList.insert(4);
            multiSetUnsortedLinkedList.insert(2);
            Console.WriteLine(multiSetUnsortedLinkedList.search(4));
            Console.WriteLine(multiSetUnsortedLinkedList.search(22));
            multiSetUnsortedLinkedList.print();
            multiSetUnsortedLinkedList.delete(5);
            multiSetUnsortedLinkedList.print();
            multiSetUnsortedLinkedList.delete(4);
            multiSetUnsortedLinkedList.print();
            multiSetUnsortedLinkedList.delete(3);
            multiSetUnsortedLinkedList.print();
            multiSetUnsortedLinkedList.delete(2);
            multiSetUnsortedLinkedList.print();
        }

        public static void TestSetUnsortedLinkedList()
        {
            SetUnsortedLinkedList setUnsortedLinkedList = new SetUnsortedLinkedList();
            setUnsortedLinkedList.insert(4);
            setUnsortedLinkedList.insert(4);
            setUnsortedLinkedList.insert(3);
            setUnsortedLinkedList.insert(2);
            setUnsortedLinkedList.print();
            setUnsortedLinkedList.delete(4);
            setUnsortedLinkedList.print();
        }
    }
}
