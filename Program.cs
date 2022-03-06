using Matrix = LR_1.Matrix_LR1_14;
using RationalNumber = LR_1.RationalNumber_LR1_19;

namespace oop_asu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //#region Lab1_14
            //Matrix matrix = new Matrix(4);

            //matrix.InitializeMatrix();

            //matrix.PrintMatrix();

            //Console.WriteLine(matrix.GetTraceOfMatrix() + "\n");

            //Console.WriteLine(matrix.GetSumOfElementsAboveMainDiagonal() + "\n");

            //Console.WriteLine(matrix.GetSumOfElementsBeloveMainDiagonal() + "\n");
            //#endregion

            #region Lab1_19
            RationalNumber rationalNumber = new RationalNumber(5, 6);

            var newNumb = rationalNumber.Add(new RationalNumber(-3, 2));

            RationalNumber.PrintRationalNumber(newNumb);

            newNumb = rationalNumber.Discard(new RationalNumber(7, 6));

            RationalNumber.PrintRationalNumber(newNumb);

            newNumb = newNumb.Multiply(new RationalNumber(2, 8));

            RationalNumber.PrintRationalNumber(newNumb);

            newNumb = newNumb.Divide(new RationalNumber(3, 2));

            RationalNumber.PrintRationalNumber(newNumb);
            #endregion


        }


    }
}