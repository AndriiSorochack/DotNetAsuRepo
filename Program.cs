
namespace Lab1_14
{
    public class Program
    {
        /*Створити клас – квадратна матриця.У закритій частині описати поля: розмір матриці та двовимірний масив 
         * для зберігання її елементів (цілих чисел). Визначити конструктор та деструктор, функції 
         * для введення та виведення значень елементів матриці, обчислення сліду матриці (суми елемен
         * тів головної діагоналі), сум елементів вище та нижче головної діагоналі.*/
        public static void Main(string[] args)
        {
            Matrix_LR1_14 matrix = new Matrix_LR1_14(4);

            matrix.InitializeMatrix();

            matrix.PrintMatrix();

            Console.WriteLine(matrix.GetTraceOfMatrix() + "\n");

            Console.WriteLine(matrix.GetSumOfElementsAboveMainDiagonal() + "\n");

            Console.WriteLine(matrix.GetSumOfElementsBeloveMainDiagonal() + "\n");
        }

        
    }
}