using System;

namespace T07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string mesec May-, June-, July, August, September- или October- 
            string month = Console.ReadLine();
            //int брой нощувки 
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceAppartment = 0;
            switch (month)
            {
                case "May":
                case "October": 
                {
                        //Студио – 50 лв./нощувка ako nights >7 ima 5% namalenie ako >14 ima 30%
                        //Апартамент – 65 лв./ нощувка ako nights >14 10% namal. 
                        
                        //studioPrice= nights*0.50
                        
                        if (nights > 7 && nights <= 14)
                        {
                            priceStudio = nights * 50;
                            priceStudio = priceStudio - priceStudio * 0.05;
                            priceAppartment = nights * 65;
                        }
                        else if (nights > 14)
                        {
                            priceStudio = nights * 50;
                            priceStudio = priceStudio - priceStudio * 0.30;
                            priceAppartment = nights * 65;
                            priceAppartment = priceAppartment - priceAppartment * 0.10;
                        } 
                        else
                        {
                            priceStudio = nights * 50;
                            priceAppartment = nights * 65;
                        }
                        
                }
                    break;
                case "June":
                case "September":
                    {
                        //Студио – 75.20 лв./ нощувка ako nights >14  20% namalenie
                        //Апартамент – 68.70 лв./ нощувка ako nights >14 10% namalenie 
                        if (nights > 14)
                        {
                            priceStudio = nights * 75.20;
                            priceStudio = priceStudio - priceStudio * 0.20;
                            priceAppartment = nights * 68.70;
                            priceAppartment = priceAppartment - priceAppartment * 0.10;
                        } 
                        else
                        {
                            priceStudio = nights * 75.20;
                            priceAppartment = nights * 68.70;
                        }


                    }
                    break;
                case "July":
                case "August":
                    {
                        //Студио – 76 лв./ нощувка
                        //Апартамент – 77 лв./ нощувка ako nights >14 10% namalenie 
                        if (nights > 14)
                        {
                            priceStudio = nights * 76;
                            priceAppartment = nights * 77;
                            priceAppartment = priceAppartment - priceAppartment * 0.10;
                        }
                        else
                        {
                            priceStudio = nights * 76;
                            priceAppartment = nights * 77;
                        }

                    }
                    break; 
            }
            Console.WriteLine($"Apartment: {priceAppartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");

            //отпечатване 	На първия ред: “Apartment: {цена за целият престой} lv.”
            //	На втория ред: “Studio: { цена за целият престой} lv.“

        }
    }
}
