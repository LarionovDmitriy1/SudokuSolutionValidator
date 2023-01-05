using SudokuSolutionValidator;

int[][] array = new int[9][];

array[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[1] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[2] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[4] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[5] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[6] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[7] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array[8] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = SudokuWork.ValidateSolution(array);
Console.WriteLine(result);