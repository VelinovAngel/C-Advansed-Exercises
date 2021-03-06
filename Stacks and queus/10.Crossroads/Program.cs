﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightInterval = int.Parse(Console.ReadLine());
            int freeWindowInterval = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command = string.Empty;
            bool crash = false;
            string crashedCar = string.Empty;
            int hitIndex = -1;
            int passedCars = 0;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    int currentGreenLight = greenLightInterval;

                    while (cars.Any() && currentGreenLight > 0)
                    {
                        string currentCar = cars.Peek();
                        int carLenght = currentCar.Length;

                        if (carLenght <= currentGreenLight)
                        {
                            currentGreenLight -= carLenght;
                            passedCars++;
                            cars.Dequeue();
                        }
                        else
                        {
                            carLenght -= currentGreenLight;
                            if (carLenght <= freeWindowInterval)
                            {
                                passedCars++;
                                cars.Dequeue();
                            }
                            else
                            {
                                crash = true;
                                crashedCar = currentCar;
                                hitIndex = currentGreenLight + freeWindowInterval;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                if (crash)
                {
                    break;
                }
            }


            if (crash)
            {
                Console.WriteLine($"A crash happened!");
                Console.WriteLine($"{crashedCar} was hit at {crashedCar[hitIndex]}.");
            }
            else
            {
                Console.WriteLine($"Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }

        }
    }
}
