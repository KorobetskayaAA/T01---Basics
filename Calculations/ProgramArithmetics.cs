using System;

namespace Calculations
{
    class ProgramArithmetics
    {
        static void Main(string[] args)
        {
            #region Integers
            Console.WriteLine("int");
            int leftInt = 234, rightInt = 99;
            int sumInt = leftInt + rightInt;
            int difInt = leftInt - rightInt;
            int mulInt = leftInt * rightInt;
            int divInt = leftInt / rightInt;
            int modInt = leftInt % rightInt;
            Console.WriteLine(leftInt + " + " + rightInt + " = " + sumInt);
            Console.WriteLine(leftInt + " - " + rightInt + " = " + difInt);
            Console.WriteLine(leftInt + " * " + rightInt + " = " + mulInt);
            Console.WriteLine(leftInt + " / " + rightInt + " = " + divInt);
            Console.WriteLine(leftInt + " % " + rightInt + " = " + modInt);
            Console.WriteLine();
            #endregion

            #region Bytes
            Console.WriteLine("byte");
            byte leftByte = 234, rightByte = 99;
            byte sumByte = (byte)(leftByte + rightByte);
            byte difByte = (byte)(leftByte - rightByte);
            byte mulByte = (byte)(leftByte * rightByte);
            byte divByte = (byte)(leftByte / rightByte);
            byte modByte = (byte)(leftByte % rightByte);
            Console.WriteLine(leftByte + " + " + rightByte + " = " + sumByte);
            Console.WriteLine(leftByte + " - " + rightByte + " = " + difByte);
            Console.WriteLine(leftByte + " * " + rightByte + " = " + mulByte);
            Console.WriteLine(leftByte + " / " + rightByte + " = " + divByte);
            Console.WriteLine(leftByte + " % " + rightByte + " = " + modByte);
            Console.WriteLine();
            #endregion

            #region Doubles
            Console.WriteLine("double");
            double leftDbl = 1000.2, rightDbl = 1.1;
            double sumDbl = leftDbl + rightDbl;
            double difDbl = leftDbl - rightDbl;
            double mulDbl = leftDbl * rightDbl;
            double divDbl = leftDbl / rightDbl;
            double modDbl = leftDbl % rightDbl;
            Console.WriteLine(leftDbl + " + " + rightDbl + " = " + sumDbl);
            Console.WriteLine(leftDbl + " - " + rightDbl + " = " + difDbl);
            Console.WriteLine(leftDbl + " * " + rightDbl + " = " + mulDbl);
            Console.WriteLine(leftDbl + " / " + rightDbl + " = " + divDbl);
            Console.WriteLine(leftDbl + " % " + rightDbl + " = " + modDbl);
            Console.WriteLine();
            #endregion

            #region Floats
            Console.WriteLine("float");
            float leftFlt = 1000.2f, rightFlt = 1.1f;
            float sumFlt = leftFlt + rightFlt;
            float difFlt = leftFlt - rightFlt;
            float mulFlt = leftFlt * rightFlt;
            float divFlt = leftFlt / rightFlt;
            float modFlt = leftFlt % rightFlt;
            Console.WriteLine(leftFlt + " + " + rightFlt + " = " + sumFlt);
            Console.WriteLine(leftFlt + " - " + rightFlt + " = " + difFlt);
            Console.WriteLine(leftFlt + " * " + rightFlt + " = " + mulFlt);
            Console.WriteLine(leftFlt + " / " + rightFlt + " = " + divFlt);
            Console.WriteLine(leftFlt + " % " + rightFlt + " = " + modFlt);
            Console.WriteLine();
            #endregion

            #region Decimals
            Console.WriteLine("decimal");
            decimal leftDec = 1000.2m, rightDec = 1.1m;
            decimal sumDec = leftDec + rightDec;
            decimal difDec = leftDec - rightDec;
            decimal mulDec = leftDec * rightDec;
            decimal divDec = leftDec / rightDec;
            decimal modDec = leftDec % rightDec;
            Console.WriteLine(leftDec + " + " + rightDec + " = " + sumDec);
            Console.WriteLine(leftDec + " - " + rightDec + " = " + difDec);
            Console.WriteLine(leftDec + " * " + rightDec + " = " + mulDec);
            Console.WriteLine(leftDec + " / " + rightDec + " = " + divDec);
            Console.WriteLine(leftDec + " % " + rightDec + " = " + modDec);
            Console.WriteLine();
            #endregion
        }
    }
}
