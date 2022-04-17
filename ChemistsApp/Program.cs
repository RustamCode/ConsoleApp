using System;
using System.Collections.Generic;
using Business.Services;
using Entities.Models;
using Utilities.Helper;

namespace ChemistsApp
{
    class Program
    {
        //private static BaseService baseService;
        //public Program(BaseService ba)
        //{
        //    baseService = new BaseService();
        //}
        
        static void Main(string[] args)
        {
            Extention.Print(ConsoleColor.Blue, "Welcome");
            while(true)
            {
                BaseService baseService = new BaseService();
                Extention.Print(ConsoleColor.Cyan, "1-Create Base\n" +
                    "2-Update Base\n" +
                    "3-Remove Base\n" +
                    "4-Get Base\n"+
                    "5-GetAll Bases");
                
                string num = Console.ReadLine();
                int input;


                bool IsNum = int.TryParse(num, out input);
                if(IsNum&&input<7&&input>0)
                {

                    switch (input)
                    {
                        case 1:
                        EnterName:
                            Extention.Print(ConsoleColor.Green, $"Base Name :");
                            string name = Console.ReadLine();
                            Extention.Print(ConsoleColor.Green, $"Base Size :");
                            string baseSize = Console.ReadLine();
                            int size;


                            bool isSize = int.TryParse(baseSize, out size);
                            if (isSize)
                            {

                                Base Base = new Base
                                {
                                    Name = name,
                                    MaxSize = size
                                };
                                
                                baseService.Create(Base);
                                Extention.Print(ConsoleColor.Green, $"{Base.Name} created");
                            }
                            else
                            {
                                Extention.Print(ConsoleColor.Red, "Enter True");
                                goto EnterName;
                            }
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            string name2 = Console.ReadLine();
                           Base  list = baseService.GetBase(name2);
                          
                            
                                Extention.Print(ConsoleColor.Green, $"{list.Name}");
                            
                            break;
                    }
                }
            }
        }
    }
}
