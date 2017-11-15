using System;

class InstructionSet_broken
{
    static void Main()
    {
        string instruction = Console.ReadLine();
        long result = 0;

        while (instruction != "END")
        {
            string[] codeArgs = instruction.Split(' ');

            switch (codeArgs[0])
            {
                case "INC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = operandOne++;
                        break;
                    }
                case "DEC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = operandOne--;
                        break;
                    }
                case "ADD":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = (long)operandOne * operandTwo;
                        break;
                    }
            }
            instruction = Console.ReadLine();

        }

        Console.WriteLine(result);
    }
}