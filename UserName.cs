using System;

class UserName {
    static void Main(string[] args)
    {
        Console.WriteLine("Input NumberCar 1 = MG EP, 2 = MG ZS EV, 3 = Nissan Leaf, 4 = Fomm One, 5 = Audi e-Tron");
        double M1 = double.Parse(Console.ReadLine());
        
        if (M1 == 1)
        {
            Console.WriteLine("Input Name");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Input kWhCar");
            double kWhCar1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0}", Name1);
            Console.WriteLine("KwhCar : {0}",kWhCar1);
            Console.WriteLine("Quick Charge Max : 7.03 kWh/S");
            Console.WriteLine("Normal Charge : 3.51 kWh/H" );
            Console.WriteLine("Distance : 380 k");
            Console.WriteLine("Top speed : 185 kWh/H");
            Console.WriteLine("Price : 9.88 Bath");            
        }

        if (M1 == 2)
        {
            Console.WriteLine("Input Name");
            string Name2 = Console.ReadLine();
            Console.WriteLine("Input kWhCar");
            double kWhCar2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0}", Name2);
            Console.WriteLine("KwhCar : {0}",kWhCar2);
            Console.WriteLine("Quick Charge Max : 6.84 kWh/S");
            Console.WriteLine("Normal Charge : 3.42 kWh/H" );
            Console.WriteLine("Distance : 337 k");
            Console.WriteLine("Top speed : 150 kWh/H");
            Console.WriteLine("Price : 1.19 Bath");  
        }

        if (M1 == 3)
        {
            Console.WriteLine("Input Name");
            string Name3 = Console.ReadLine();
            Console.WriteLine("Input kWhCar");
            double kWhCar3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0}", Name3);
            Console.WriteLine("KwhCar : {0}",kWhCar3);
            Console.WriteLine("Quick Charge Max : 3.33 kWh/S");
            Console.WriteLine("Normal Charge : 1.66 kWh/H" );
            Console.WriteLine("Distance : 311 k");
            Console.WriteLine("Top speed : 144 kWh/H");
            Console.WriteLine("Price : 1.49 Bath"); 
        }

        if (M1 == 4)
        {
            Console.WriteLine("Input Name");
            string Name4 = Console.ReadLine();
            Console.WriteLine("Input kWhCar");
            double  kWhCar4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0}", Name4);
            Console.WriteLine("KwhCar : {0}",kWhCar4);
            Console.WriteLine("Quick Charge Max : 0.49 kWh/S");
            Console.WriteLine("Normal Charge : 0.24 kWh/H" );
            Console.WriteLine("Distance : 160 k");
            Console.WriteLine("Top speed : 80 kWh/H");
            Console.WriteLine("Price : 6.64 Bath"); 
        }

        if (M1 == 5)
        {
            Console.WriteLine("Input Name");
            string Name5 = Console.ReadLine();
            Console.WriteLine("Input kWhCar");
            double kWhCar5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0}", Name5);
            Console.WriteLine("KwhCar : {0}",kWhCar5);
            Console.WriteLine("Quick Charge Max :  10.55kWh/S");
            Console.WriteLine("Normal Charge :5.27 kWh/H" );
            Console.WriteLine("Distance : 504 k");
            Console.WriteLine("Top speed : 250 kWh/H");
            Console.WriteLine("Price : 5.299 Bath"); 
        }
    }
}
