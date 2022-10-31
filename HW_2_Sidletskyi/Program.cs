using HW_2_Sidletskyi;

Console.WriteLine("Task 1.1");
Matrix matrix1 = new Matrix(3, 4);
matrix1.InitializeByVerticalSnake();
matrix1.Print();
Console.WriteLine();

Console.WriteLine("Task 1.2");
Matrix matrix1_2 = new Matrix(4, 4);
matrix1_2.InitializeByDiagonalSnake();
matrix1_2.Print();
Console.WriteLine();

Console.WriteLine("Task 1.3");
Matrix matrix1_3 = new Matrix(3, 4);
matrix1_3.InitializeBySpiralSnake();
matrix1_3.Print();
Console.WriteLine();

Console.WriteLine("Task 2");
MatrixBigestLine matrix2 = new MatrixBigestLine(3, 5);
matrix2.Print();
matrix2.ColorOfTheBigestHorizontalLine();
