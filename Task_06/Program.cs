using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;

// Домашнє завдання №1
// Завдання 6

namespace Classes
{
    class Program
    {
        class Address
        {
            private string index, country, city, street, house, apartment;

            public string Index { get { return index; } set { index = value; } }
            public string Country { get { return country; } set { country = value; } }
            public string City { get { return city; } set { city = value; } }
            public string Street { get { return street; } set { street = value; } }
            public string House { get { return house; } set { house = value; } }
            public string Apartment { get { return apartment; } set { apartment = value; } }

            public Address(string index, string country, string city, string street, string house, string apartment)
            {
                this.index = index;
                this.country = country;
                this.city = city;
                this.street = street;
                this.house = house;
                this.apartment = apartment;
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Address address = new Address("71001", "Україна", "Одеса", "Дерибасовська", "50", "251");

            Console.WriteLine("Адреса: " + address.Index + " " + address.Country + ", " + address.City + " вул. " + address.Street + " " + address.House + " кв. " + address.Apartment);



            // Delay.
            Console.ReadKey();
        }
    }
}



