using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolutionValidator;

public class SudokuWork
{
    public static bool ValidateSolution(int[][] board)
    {
        int count = 0;
        int counter = 0;
        string arrayInString = "";
        int[] arr = new int[board.Length];
        //testHorizontally
        for (int i = 0; i < board.Length; i++)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (var j = 0; j < board[i].Length; j++)
            {
                if (list.Contains(board[i][j]))
                {
                    list.Remove(board[i][j]);
                }
                else { return false; }
            }
        }
        //testVertically
        for (int i = 0; i < board.Length; i++)
        {
            if (counter == 9) { counter = 0; break; }
            for (int j = 0; j < board[i].Length; j++)
            {
                counter++;
                List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                for (int a = 0; a < board.Length; a++)
                {
                    arrayInString = arrayInString + board[i][j].ToString() + ' ';
                    i++;
                }
                i = 0;
                arrayInString = arrayInString.Remove(arrayInString.Length - 1, 1);
                string[] numbers = arrayInString.Split(' ');
                foreach (string number in numbers)
                {
                    int h = int.Parse(number);
                    arr[i] = h;
                    i++;
                }
                i = 0;
                for (int k = 0; k < arr.Length; k++)
                {
                    if (list.Contains(arr[i]))
                    {
                        list.Remove(arr[i]);
                    }
                    else
                    {
                        return false;
                    }
                    i++;
                }
                arrayInString = "";
                i = 0;
            }
        }
        //test_3X3
        for (int i = 0; i < board.Length;)
        {
            for (int j = 0; ; j++)
            {
                List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                if (counter == 3 && count >= 3 && count <= 5) { counter = 0; j = 3; i++; }
                else if (counter == 3 && count >= 6 && count <= 9) { counter = 0; j = 6; i++; }
                else if (counter == 3) { counter = 0; j = 0; i++; }
                if (arrayInString.Length == 18)
                {
                    arrayInString = arrayInString.Remove(arrayInString.Length - 1, 1);
                    string[] numbers = arrayInString.Split(' ');
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        foreach (string number in numbers)
                        {
                            int h = int.Parse(number);
                            arr[k] = h;
                            k++;
                        }
                        for (int c = 0; c < numbers.Length; c++)
                        {
                            if (list.Contains(arr[c]))
                            {
                                list.Remove(arr[c]);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        count++;
                        arrayInString = "";
                        if (count == 3) { j = 3; i = 0; }
                        if (count == 6) { j = 6; i = 0; }
                        if (count == 9)
                        {
                            return true;
                        }
                    }
                }
                arrayInString = arrayInString + board[i][j].ToString() + ' ';
                counter++;
            }
        }
        return true;
    }
}
