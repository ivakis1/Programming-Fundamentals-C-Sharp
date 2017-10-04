//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace P05_ParkingValidation
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var registeredNumbers = new Dictionary<string, string>();

//        }
//        static string ReadingNumbers()
//        {
//            var count = int.Parse(Console.ReadLine());
//            for (int i = 0; i < count; i++)
//            {
//                var number = Console.ReadLine().Split();

//                if (number[0] == "register")
//                {
//                    RegisterNumber(number[1], number[2]);
//                }
//                else if (number[0] == "unregister")
//                {
//                    UnregisterNumber(number[1]);
//                }
//            }
//        }
//        static new Dictionary<string, string> RegisterNumber(string user, string number)
//        {
//            string userToRegistrate = user;
//            string numberToRegistrate = number;

//            bool isLongEnough = numberToRegistrate.Length == 8 ? true : false;

//            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

//            var firstTwoSigns = userToRegistrate.Take(2).ToArray();

//            var firstLetter = false;
//            var secondLetter = false;
                
//                for (int j = 0; j < alpha.Length; j++)
//                {
//                    if (firstTwoSigns[0] == alpha[j])
//                    {
//                        firstLetter = true;
//                    }
//                    if (firstTwoSigns[1] == alpha[j])
//                    {
//                        secondLetter = true;
//                    }
//                }          
            
//            var numberDigits = numberToRegistrate.Skip(2).Take(numberToRegistrate.Length - 2).ToList();

//            var firstDigit = false;
//            var secondDigit = false;
//            var tirthDigit = false;
//            var fourthDigit = false;

//            char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

//            for (int i = 0; i < numberDigits.Count; i++)
//            {
//                for (int j = 0; j < digits.Length; j++)
//                {
//                    if (numberDigits[0] == digits[j] )
//                    {
//                        firstDigit = true;
//                    }
//                    if (numberDigits[1] == digits[j])
//                    {
//                        secondDigit = true;
//                    }
//                    if (numberDigits[2] == digits[j])
//                    {
//                        tirthDigit = true;
//                    }
//                    if (numberDigits[3] == digits[j])
//                    {
//                        fourthDigit = true;
//                    }
//                }
//            }

//            var preLastLetter = false;
//            var lastLetter = false;

//            var lastLetters = numberToRegistrate.Skip(6).Take(2).ToArray();

//              for (int j = 0; j < alpha.Length; j++)
//                {
//                    if (lastLetters[0] == alpha[j])
//                    {
//                        preLastLetter = true;
//                    }
//                    if (lastLetters[1] == alpha[j])
//                    {
//                        preLastLetter = true;
//                    }
//                }
//            bool corectNumber = false;

//            if (isLongEnough && firstLetter && secondLetter && firstDigit && secondDigit && tirthDigit &&
//                fourthDigit && preLastLetter && lastLetter)
//            {
//                corectNumber = true;
//            }

//            var registeredNumbers = new Dictionary<string, string>();

//            if (corectNumber && !registeredNumbers.ContainsKey(userToRegistrate)
//                && !registeredNumbers.ContainsValue(numberToRegistrate))
//            {
//                registeredNumbers.Add(userToRegistrate, numberToRegistrate);
//                Console.WriteLine($"{userToRegistrate} registered {numberToRegistrate} successfully");
//            }
//            if (!corectNumber)
//            {
//                Console.WriteLine($"ERORR: invalid license plate {numberToRegistrate}");
//            }
//            var usersPlate = registeredNumbers[userToRegistrate];

//            if (registeredNumbers.ContainsKey(userToRegistrate) && !registeredNumbers.ContainsValue(numberToRegistrate))
//            {
//                Console.WriteLine($"ERROR: already registered with plate number {usersPlate}");
//            }
//            if (!registeredNumbers.ContainsKey(userToRegistrate) && registeredNumbers.ContainsValue(numberToRegistrate))
//            {
//                Console.WriteLine($"ERROR: license plate {usersPlate} is busy");
//            }
//            return registeredNumbers;
//         }
//    }  
//}
