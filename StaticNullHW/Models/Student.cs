using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNullHW.Models
{
    internal class Student
    {
        private static string _fullName;
        private static string _groupNo;
        
        public static string FullName
        {
            get { return _fullName; }
            set
            {
               

                while (!CheckFullName(value))
                {
                    Console.WriteLine("Full Name Duzgun daxil edin! ");
                    value = Console.ReadLine();
                }
                Console.WriteLine("FullName duzgun daxil edildi!!!!!");
                _fullName= value;

                
            }
        }

        public static string GroupNo
        {
            get { return _groupNo; }
            set
            {


                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Group NO Duzgun daxil edin! ");
                    value = Console.ReadLine();
                }
                Console.WriteLine("GroupNO duzgun daxil edildi!!!!!");

                _groupNo = value;

            }
        }




        public static bool CheckGroupNo(string groupName)
        {

            

                int count = 0;
            if (groupName.Length != 4)
            {
                return false;
            }

            for (int i = 0; i < groupName.Length; i++)
            {
                if (char.IsUpper(groupName[i]) && i==0)
                {
                    count++;
                }
                else if (char.IsDigit(groupName[i]))
                {
                    count++;
                }
            }
                
                    

                
                if (count != 4)
                {
                    return false;
                }
                return true;
            
        }


        public static bool CheckFullName(string fullName)
        {
            int count = 0;
            for (int i = 0; i < fullName.Length; i++)
            {
                if (char.IsUpper(fullName[i]) && i==0)
                {
                    count++;
                }else if (char.IsWhiteSpace(fullName[i]))
                {
                    count++;
                   if (char.IsUpper(fullName[i + 1]))
                    {
                        count++;
                    }
                }
            }

            return count == 3 ? true : false;
        }


    }
}
