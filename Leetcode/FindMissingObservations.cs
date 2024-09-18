﻿namespace Leetcode;

public class FindMissingObservations : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[] rolls = [3, 2, 4, 3];
        int mean = 4;
        int n = 2;
        foreach (var answer in solution.MissingRolls(rolls, mean, n))
        {
            Console.Write(answer + " ");
        }
        Console.WriteLine();

        rolls = [1, 5, 6];
        mean = 3;
        n = 4;
        foreach (var answer in solution.MissingRolls(rolls, mean, n))
        {
            Console.Write(answer + " ");
        }
        Console.WriteLine();

        rolls = [1, 2, 3, 4];
        mean = 6;
        n = 4;
        foreach (var answer in solution.MissingRolls(rolls, mean, n))
        {
            Console.Write(answer + " ");
        }
        Console.WriteLine();

        rolls = [4, 5, 6, 2, 3, 6, 5, 4, 6, 4, 5, 1, 6, 3, 1, 4, 5, 5, 3, 2, 3, 5, 3, 2, 1, 5, 4, 3, 5, 1, 5];
        mean = 4;
        n = 40;
        foreach (var answer in solution.MissingRolls(rolls, mean, n))
        {
            Console.Write(answer + " ");
        }
        Console.WriteLine();

        rolls =
        [
            4, 2, 2, 5, 4, 5, 4, 5, 3, 3, 6, 1, 2, 4, 2, 1, 6, 5, 4, 2, 3, 4, 2, 3, 3, 5, 4, 1, 4, 4, 5, 3, 6, 1, 5, 2,
            3, 3, 6, 1, 6, 4, 1, 3
        ];
        mean = 2;
        n = 53;
        foreach (var answer in solution.MissingRolls(rolls, mean, n))
        {
            Console.Write(answer + " ");
        }
        Console.WriteLine();

        rolls =
        [
            5, 4, 5, 3, 2, 6, 5, 5, 1, 5, 6, 2, 3, 6, 6, 6, 5, 6, 4, 6, 1, 4, 2, 5, 5, 1, 1, 3, 4, 1, 6, 2, 3, 4, 1, 2,
            4, 5, 3, 3, 2, 2, 5, 1, 3, 6, 6, 1, 4, 1, 2, 3, 6, 4, 6, 3, 1, 5, 5, 6, 3, 1, 1, 4, 6, 2, 1, 2, 4, 5, 2, 6,
            5, 2, 4, 6, 2, 1, 5, 1, 3, 3, 3, 6, 4, 6, 4, 4, 1, 5, 5, 4, 5, 6, 6, 1, 4, 5, 2, 3, 6, 6, 5, 2, 6, 5, 5, 6,
            4, 6, 3, 1, 2, 3, 4, 5, 6, 2, 2, 4, 2, 3, 4, 6, 4, 2, 1, 2, 4, 2, 5, 1, 6, 3, 1, 2, 2, 6, 3, 6, 2, 1, 3, 3,
            1, 3, 2, 3, 3, 5, 5, 3, 4, 3, 2, 6, 5, 3, 1, 6, 1, 2, 3, 4, 2, 2, 1, 5, 5, 6, 1, 4, 3, 3, 1, 5, 5, 4, 5, 5,
            6, 6, 3, 3, 2, 2, 5, 3, 6, 1, 4, 5, 4, 2, 6, 4, 3, 2, 2, 5, 3, 6, 6, 2, 4, 2, 3, 3, 6, 5, 5, 6, 6, 5, 5, 1,
            1, 2, 2, 2, 4, 4, 1, 4, 5, 5, 1, 6, 3, 4, 6, 1, 5, 2, 2, 2, 1, 1, 6, 4, 5, 4, 5, 3, 3, 2, 2, 3, 5, 3, 3, 2,
            1, 1, 4, 5, 2, 2, 1, 3, 5, 4, 1, 1, 6, 6, 2, 3, 6, 6, 1, 2, 4, 3, 5, 6, 6, 3, 3, 3, 5, 2, 3, 1, 2, 2, 1, 5,
            2, 1, 3, 1, 1, 5, 5, 4, 6, 2, 5, 6, 2, 2, 1, 2, 6, 2, 1, 6, 2, 6, 2, 2, 5, 1, 2, 6, 4, 3, 2, 1, 1, 3, 1, 1,
            6, 4, 1, 5, 4, 5, 3, 1, 4, 2, 6, 3, 6, 2, 1, 3, 3, 3, 4, 5, 5, 3, 4, 3, 6, 3, 1, 4, 2, 5, 3, 2, 1, 2, 4, 3,
            5, 3, 3, 3, 2, 5, 2, 2, 5, 5, 4, 3, 3, 1, 4, 4, 3, 3, 1, 4, 3, 6, 6, 6, 6, 6, 1, 1, 3, 1, 2, 2, 3, 2, 1, 3,
            5, 2, 5, 1, 5, 1, 2, 1, 2, 2, 3, 5, 1, 5, 5, 4, 1, 5, 4, 6, 4, 6, 3, 1, 6, 4, 6, 3, 4, 2, 6, 6, 1, 2, 6, 6,
            6, 5, 4, 3, 4, 3, 6, 3, 4, 4, 2, 5, 6, 5, 6, 2, 3, 1, 5, 2, 1, 5, 3, 3, 3, 3, 4, 2, 5, 3, 4, 6, 3, 2, 3, 5,
            2, 6, 3, 2, 6, 3, 6, 1, 4, 2, 2, 1, 1, 2, 2, 5, 5, 3, 1, 1, 5, 1, 1, 1, 5, 4, 2, 2, 4, 3, 5, 3, 5, 1, 6, 5
        ];
        mean = 2;
        n = 47945;
        
        foreach (var answer in solution.MissingRolls(rolls, mean, n))
        {
            Console.Write(answer + " ");
        }
        Console.WriteLine();
        
        rolls = [2,2,1,6,6,2,1,6,6,1,1,6,2,6,6,1,3,6,1,3,1,1,5,4,1,5,4,1,1,5,2,3,2,5,4,3,2,1,1,2,1,4,3,3,6,4,6,6,5,3,5,6,6,1,6,2,1,4,5,5,1,1,6,3,1,4,4,3,1,1,3,6,5,3,4,6,2,2,2,4,4,5,5,5,3,4,6,2,4,6,4,4,3,4,2,5,1,3,6,1,2,6,4,5,3,5,5,6,5,2,4,5,3,3,1,6,4,1,5,3,3,4,4,3,4,1,2,1,3,5,3,3,3,2,4,6,4,2,4,3,4,6,6,4,2,5,5,2,2,5,6,6,2,5,3,3,6,3,5,4,2,5,3,1,3,6,3,3,2,2,5,1,2,3,3,3,1,1,2,6,6,1,2,1,5,4,5,1,4,1,2,4,3,4,1,1,5,5,2,5,4,2,6,6,2,3,1,1,5,3,5,2,5,5,4,5,2,2,2,4,3,4,2,6,6,5,4,1,6,5,1,3,1,4,1,1,6,5,2,2,3,5,5,6,1,2,4,6,6,4,3,5,4,4,3,4,1,5,6,5,1,1,5,5,5,2,3,1,2,6,3,4,5,1,6,6,2,5,4,6,4,4,2,4,6,3,5,4,5,2,5,1,6,1,4,2,2,3,6,3,1,3,2,4,4,1,4,1,2,4,3,3,1,1,2,6,5,1,4,5,1,2,5,3,4,4,3,1,2,4,5,4,6,3,4,6,3,1,6,3,1,3,6,4,3,4,2,5,1,6,3,4,4,4,5,3,3,4,6,4,3,5,2,4,2,4,6,6,2,2,6,1,1,3,3,1,2,3,4,2,2,2,4,3,1,5,2,1,3,3,1,2,6,6,6,6,2,6,4,2,1,6,2,1,6,6,6,2,2,5,5,4,3,5,5,3,2,1,1,1,2,2,3,2,3,3,6,1,6,4,3,3,6,2,2,6,1,3,3,5,6,1,3,5,2,5,5,6,3,1,3,4,6,4,2,4,3,5,2,5,3,4,6,1,5,1,4,4,3,1,1,6,6,5,4,4,4,2,5,5,6,1,6,4,5,1,6,4,1,5,3,1,2,4,5,6,4,6,1,5,5,4,5,6,2,2,4,4,5,1,2,1,1,2,1,2,6,2,1,5,4,6,3,5,2,4,6,6,4,2,1,1,3,1,6,3,5,5,1,6,5,2,5,5,5,2,3,4,1,2,1,2,4,4,1,3,3,4,4,4,1,2,2,2,2,5,1,6,1,3,4,5,3,6,5,2,4,4,5,4,2,5,2,2,3,4,4,6,3,4,5,1,2,6,1,4,6,1,3,5,6,2,5,4,4,1,5,1,1,2,3,1,1,2,2,4,4,1,5,5,2,6,6,1,4,2,6,3,4,5,5,2,2,6,1,6,4,5,2,2,1,2,6,5,5,5,5,6,6,4,2,6,5,4,6,3,3,2,5,3,4,6,2,6,3,5,1,2,6,6,6,1,3,4,2,2,4,5,5,5,4,3,2,1,4,6,1,4,3,4,2,4,1,4,6,3,6,3,2,5,3,4,2,2,6,3,3,4,6,4,3,5,2,4,1,4,6,1,4,2,6,6,3,4,3,3,2,1,5,2,6,1,6,4,1,1,2,6,1,4,2,1,2,1,6,2,5,1,5,1,4,6,4,2,5,4,1,4,4,6,6,5,3,5,4,4,4,2,6,5,1,5,1,4,2,6,5,2,5,2,6,4,1,1,2,2,2,6,1,2,3,3,6,5,1,2,1,2,3,5,3,3,2,4,6,5,4,2,6,4,5,3,1,3,3,6,1,6,3,4,1,3,4,1,4,5,6,2,5,6,2,1,5,3,6,4,4,1,2,1,3,4,4,1,6,6,5,2,1,2,6,2,4,6,3,1,1,2,4,1,2,4,6,2,6,4,4,3,1,3,1,6,6,2,5,1,2,6,5,1,5,4,2,6,4,1,5,2,6,2,5,5,5,5,3,4,4,6,1,4,5,4,2,1,5,6,3,6,6,2,2,3,4,4,1,1,4,6,1,1,5,5,5,1,5,2,3,2,2,2,2,4,2,3,2,6,3,3,3,2,2,4,2,4,5,6,4,3,1,6,5,6,5,6,5,5,5,1,2,1,6,1,4,1,6,6,3,6,2,2,1,2,6,3,1,6,4,6,1,2,5,1,3,4,6,2,1,4,3,6,3,5,6,1,6,4,1,3,1,1,2,1,4,4,4,5,2,2,1,1,6,3,3,2,3,1,4,6,1,4,3,1,3,2,3,6,6,3,6,2,3,1,4,4,3,5,1,5,5,5,1,3,2,4,3,1,2,3,5,4,2,4,2,1,2,2,5,2,1,5,6,6,4,4,1,1,5,2,6,4,3,6,3,1,2,3,1,6,2,6,6,6,3,3,5,5,2,4,5,2,6,5,4,6,5,4,1,3,3,1,3,6,1,6,2,2,3,2,4,3,6,2,2,2,1,3,4,6,5,1,6,5,5,6,2,6,6,3,5,4,6,3,2,5,5,1,6,2,6,1,2,6,5,6,5,3,2,2,2,2,1,3,5,5,1,6,4,5,5,5,4,5,1,1,3,3,2,5,5,5,3,5,3,6,2,3,2,3,6,3,5,5,3,4,1,5,4,6,6,4,3,2,1,3,1,3,2,3,4,6,1,1,1,6,6,5,6,4,1,3,4,2,6,3,4,2,1,4,1,6,1,1,6,5,1,4,6,1,2,5,2,4,1,4,6,2,4,1,1,4,3,1,2,6,4,2,2,4,2,3,4,4,3,1,6,2,1,6,2,4,6,4,6,2,6,1,3,3,4,2,5,2,5,6,1,3,2,6,4,4,6,3,3,3,4,5,3,5,2,1,4,3,1,5,3,3,4,3,6,6,6,5,4,2,1,4,2,6,2,3,2,1,4,6,6,4,1,1,1,2,5,1,4,6,3,4,4,6,5,6,3,6,2,4,3,4,6,6,3,3,1,3,5,1,2,2,2,2,6,5,2,3,3,6,6,5,2,4,1,3,1,3,6,5,1,5,1,6,4,2,5,3,6,6,6,6,2,4,3,2,2,6,4,4,3,1,2,1,3,1,5,3,6,3,5,1,1,2,3,1,2,5,4,3,5,5,2,6,4,6,1,3,1,1,2,4,6,6,6,3,4,4,6,3,2,1,1,4,5,4,6,6,1,3,3,4,1,3,2,1,3,3,5,5,4,3,4,6,3,4,5,1,2,2,4,4,5,4,3,2,3,3,1,5,3,5,6,2,5,2,4,6,5,5,2,1,2,5,2,1,2,5,1,3,1,6,5,5,3,4,5,3,6,5,3,1,3,4,6,2,3,3,5,6,6,4,5,5,6,5,2,4,1,5,2,6,4,6,4,5,2,2,4,1,2,1,6,3,2,6,4,2,2,1,3,2,1,6,1,4,3,6,1,3,2,2,2,1,4,3,3,4,4,4,3,6,4,6,1,5,4,4,4,6,6,3,3,6,4,2,1,6,2,6,3,1,3,3,6,2,2,2,6,6,6,6,3,6,6,5,4,1,5,3,6,1,5,6,6,3,6,6,2,4,5,1,4,3,4,1,4,5,2,3,1,1,4,4,2,6,6,6,5,5,2,3,4,5,1,4,2,4,5,4,4,5,1,4,5,5,1,6,6,4,2,6,1,3,1,2,2,5,1,2,4,5,2,2,5,2,1,6,2,5,5,1,2,6,4,2,5,4,1,2,3,6,2,3,6,5,1,6,5,4,5,5,6,3,2,3,6,4,1,3,4,6,5,4,6,2,4,2,6,4,3,5,2,3,5,3,5,1,1,5,5,4,1,5,6,3,5,6,5,2,4,6,3,1,1,6,3,5,4,2,1,4,3,4,5,4,6,6,1,2,5,6,5,3,2,4,6,4,3,4,2,2,2,1,3,4,3,4,4,6,5,5,4,1,5,1,2,6,3,4,5,2,2,2,2,3,4,6,2,4,3,3,6,6,6,1,3,6,3,3,6,4,5,4,1,5,5,3,3,1,6,6,3,2,2,4,5,6,2,6,5,4,4,5,4,6,3,1,2,2,5,5,4,2,4,1,3,1,2,6,3,3,6,2,4,4,5,6,3,3,1,6,3,1,2,2,4,5,6,1,4,2,4,5,5,4,4,4,4,1,3,4,2,6,1,5,1,2,4,6,3,4,4,6,4,3,6,1,2,2,3,1,4,3,6,1,4,5,5,3,1,6,1,1,4,2,5,2,2,5,2,2,5,6,4,2,1,4,6,3,4,2,5,4,5,5,5,2,6,3,3,1,3,2,1,4,2,5,3,6,1,2,5,2,4,6,2,2,6,2,5,4,5,6,1,6,4,2,2,4,2,6,6,6,6,2,4,2,4,2,6,1,1,1,6,3,1,3,4,5,6,2,5,3,2,6,2,4,5,2,1,1,5,3,2,6,1,5,1,5,6,4,5,3,1,3,3,5,6,1,1,4,1,2,4,2,2,4,1,6,3,5,1,4,4,6,3,3,6,4,1,5,5,3,6,3,4,6,4,2,5,1,5,5,2,4,4,5,1,5,5,1,2,2,5,3,3,2,3,3,1,3,6,5,5,4,3,3,5,3,2,3,3,3,5,4,6,2,5,1,3,4,4,2,6,3,2,2,1,1,2,2,6,2,1,4,4,1,4,1,6,5,3,2,4,1,3,1,2,4,1,3,3,1,5,6,1,5,6,2,5,6,5,3,1,1,1,6,3,3,6,5,5,5,3,2,2,1,4,6,1,2,2,5,1,6,2,2,1,5,4,2,3,4,3,1,6,4,6,2,6,1,2,3,3,3,3,6,6,4,2,4,3,4,6,5,2,1,4,6,3,3,2,1,5,2,2,2,1,5,2,3,1,1,5,5,1,4,6,2,5,6,4,6,2,6,5,6,5,2,2,1,2,1,4,4,4,2,2,4,6,3,5,1,4,3,4,1,2,6,5,3,3,5,4,4,4,5,1,2,5,6,6,4,5,4,3,2,1,5,5,3,6,1,4,1,5,1,5,2,4,6,5,3,2,1,6,2,2,4,4,2,4,2,3,1,3,2,5,4,3,5,6,1,1,2,3,2,5,3,6,2,2,4,2,1,4,1,2,6,6,2,2,4,1,6,3,4,1,3,1,1,3,3,5,2,5,1,6,2,2,4,2,2,3,2,1,1,2,2,5,2,1,5,2,3,6,5,3,1,1,2,2,1,1,1,1,1,1,4,3,1,3,4,4,3,2,2,1,1,2,5,5,4,4,1,6,2,6,5,6,6,1,6,2,5,3,1,5,1,1,2,1,3,6,4,3,3,4,6,1,3,6,2,6,5,6,1,1,1,6,4,4,5,5,6,5,1,2,2,5,2,6,1,2,6,3,6,3,4,1,3,1,6,6,4,2,6,1,3,5,3,3,4,1,5,2,6,1,3,1,3,6,3,1,3,3,3,2,1,3,4,2,1,1,2,3,2,5,4,1,1,4,1,2,2,2,4,3,4,3,1,5,2,2,5,4,2,4,3,6,2,3,5,2,4,4,5,3,3,5,1,3,1,2,2,6,2,1,3,4,1,6,1,4,5,1,6,5,4,1,6,3,6,1,1,5,5,5,5,2,2,6,6,2,1,5,3,5,2,2,2,1,5,5,3,3,4,6,4,2,3,5,1,1,2,6,3,6,5,1,3,1,2,6,3,2,1,3,3,6,5,5,1,4,4,5,2,3,6,1,4,3,3,4,4,2,1,4,1,3,3,1,2,6,1,3,6,3,5,6,1,5,1,6,3,2,3,6,5,4,4,3,5,5,4,6,5,4,4,4,4,6,5,4,6,2,4,5,5,4,4,3,5,3,1,6,1,5,2,6,2,5,2,5,4,5,5,3,2,4,5,3,1,2,5,4,1,3,1,3,4,3,5,3,1,2,6,6,1,3,3,5,5,5,2,5,1,6,6,6,1,3,2,4,2,2,2,1,1,2,6,5,5,1,2,4,2,2,3,3,6,4,5,1,2,1,1,3,3,1,3,6,3,6,6,2,4,5,3,5,5,6,1,3,6,1,5,3,2,4,2,6,1,3,4,1,2,6,3,1,2,6,1,2,6,5,1,4,2,5,2,4,4,3,5,5,3,5,1,4,4,2,6,1,1,1,2,5,1,2,5,4,5,2,1,2,4,1,1,5,6,2,1,3,1,2,6,1,3,3,3,2,1,3,1,1,4,1,6,3,5,5,3,1,6,1,3,1,2,6,6,3,2,1,6,3,3,4,4,5,1,4,3,4,4,6,5,3,2,2,4,3,1,3,4,5,3,5,5,6,1,6,1,1,4,3,6,3,2,1,1,6,6,5,6,3,6,3,1,2,2,3,2,6,3,1,1,6,2,1,3,4,2,1,2,6,3,4,3,2,1,1,2,4,5,5,3,4,6,2,6,5,5,2,3,4,2,6,6,2,6,4,2,1,5,3,3,5,6,2,2,6,1,3,6,6,6,5,1,5,4,3,1,6,1,3,5,4,3,5,5,5,3,6,4,6,1,3,6,6,6,3,4,1,4,4,3,6,3,4,6,6,4,3,1,5,1,5,1,6,4,1,2,3,5,6,5,5,2,1,3,6,1,6,1,5,1,2,5,5,3,6,3,1,6,5,4,1,2,5,2,4,6,2,2,5,1,4,5,3,5,3,3,2,2,2,2,5,4,3,4,6,5,5,3,1,3,3,1,4,3,4,4,2,3,4,1,4,3,3,6,5,2,3,3,5,4,4,5,2,3,3,3,5,5,2,6,5,2,1,1,5,5,3,2,4,2,3,1,2,1,5,2,6,1,3,2,4,3,3,1,3,2,1,1,2,5,3,3,3,2,5,4,6,4,6,5,5,1,3,4,5,5,1,1,2,6,6,2,2,1,5,1,5,4,1,6,2,1,1,5,6,4,4,6,5,2,3,5,1,1,1,4,3,3,6,6,2,6,4,6,1,3,3,2,6,2,4,4,2,6,6,6,5,1,1,5,2,3,1,4,2,6,3,1,6,5,4,1,6,1,4,2,4,5,4,6,5,3,3,6,3,6,6,6,3,1,3,1,1,2,4,5,4,6,5,2,6,5,6,5,1,6,5,1,5,5,3,5,2,6,3,6,4,1,2,6,5,2,5,2,1,1,2,2,2,6,1,4,5,3,3,5,2,3,2,4,6,3,2,5,2,5,5,1,4,2,4,3,6,6,4,4,6,4,2,4,1,5,6,5,5,1,2,3,4,5,1,1,1,3,4,4,1,1,3,3,1,4,5,1,1,3,6,5,5,5,2,1,5,2,1,1,2,3,6,2,4,1,5,3,3,1,1,4,4,6,5,3,1,3,1,3,6,2,2,3,6,4,3,6,6,2,6,2,6,6,6,3,1,3,6,3,5,2,3,1,3,2,2,5,5,5,4,2,1,6,3,5,2,5,4,4,4,4,1,1,6,2,3,5,2,3,3,3,2,6,6,2,4,6,2,1,5,1,1,3,5,6,5,3,4,2,5,3,5,1,5,6,6,3,3,3,5,4,6,6,4,1,4,3,6,1,1,4,4,6,1,3,1,4,6,5,1,4,6,1,5,3,2,1,4,6,5,2,4,2,3,1,3,5,5,4,2,6,1,3,3,6,6,6,5,2,3,3,4,1,6,4,3,4,2,4,5,4,6,2,6,6,1,2,1,6,5,1,2,6,3,2,6,4,6,3,5,1,6,6,3,5,1,5,6,3,6,2,1,4,5,5,2,4,4,3,3,5,6,5,5,6,1,2,3,2,4,1,1,3,2,3,1,3,3,1,5,2,5,5,6,2,6,3,3,2,6,6,4,5,6,5,1,1,1,4,3,3,3,4,1,4,4,2,2,1,6,4,4,4,1,1,6,3,5,1,3,1,5,1,3,4,5,4,3,4,2,1,3,2,6,1,3,1,3,4,6,1,5,4,4,6,1,1,1,5,5,2,4,5,2,2,3,2,4,4,3,2,6,4,6,6,3,6,6,6,4,6,6,3,1,4,2,6,3,3,6,3,4,2,4,3,4,4,3,4,5,1,4,1,3,6,3,4,6,3,4,2,6,2,5,1,3,3,2,1,6,5,6,5,1,1,3,5,6,2,2,4,6,5,4,6,6,1,5,1,1,5,3,1,2,5,3,3,5,6,4,6,5,1,6,3,4,4,4,4,5,5,6,6,5,2,2,4,1,4,6,2,4,1,2,3,2,3,4,4,4,4,3,4,1,6,4,4,6,5,3,4,6,1,2,1,4,5,2,2,3,5,2,2,2,6,5,4,3,6,4,3,6,5,4,3,4,4,5,4,2,1,4,4,3,3,6,4,1,5,3,6,3,4,6,4,2,5,3,6,1,6,5,2,1,6,6,4,5,2,1,5,6,3,1,4,3,5,2,5,2,1,1,3,6,1,2,3,6,1,6,3,5,2,4,5,1,5,3,5,5,1,1,5,6,6,6,6,1,3,3,2,1,6,5,5,4,3,2,6,3,4,2,4,3,4,6,3,3,2,1,1,5,3,2,2,6,2,5,1,6,3,2,1,3,2,2,4,5,6,5,5,3,2,1,4,5,3,5,1,1,5,3,5,2,2,5,6,6,6,3,2,3,6,4,5,2,3,5,4,1,2,6,5,1,4,5,2,6,3,3,1,5,4,4,5,1,2,4,5,5,5,6,1,4,3,3,3,2,3,3,3,5,3,6,2,2,3,5,2,5,6,2,2,6,6,1,3,4,5,5,5,6,4,4,2,4,6,2,4,5,3,1,3,2,6,5,3,6,6,5,6,3,3,3,1,5,2,4,5,2,6,3,1,4,3,3,6,3,3,1,1,4,6,4,4,3,1,1,3,1,6,5,3,3,1,5,4,4,4,1,3,2,1,5,2,1,6,1,5,1,4,2,4,2,5,5,1,1,5,4,1,5,6,2,2,5,3,4,2,4,2,2,6,5,5,4,5,5,3,2,4,2,6,1,5,3,4,2,5,4,4,5,1,3,2,6,6,3,2,1,6,2,2,5,4,2,6,4,1,6,6,5,3,2,6,5,4,6,6,6,6,4,4,1,2,3,5,3,1,3,5,6,2,3,1,6,6,4,2,4,2,2,4,4,1,3,4,6,4,3,1,1,5,6,6,2,4,6,3,2,4,2,5,6,3,2,2,6,6,2,2,4,6,3,6,1,5,1,1,5,1,4,1,2,3,5,4,5,1,3,2,1,3,1,4,4,6,6,6,1,5,4,4,3,5,1,2,6,2,6,1,3,3,4,6,3,2,2,2,2,4,1,5,4,3,2,4,5,1,1,6,2,4,4,3,1,2,1,2,1,6,3,5,5,3,5,2,2,6,6,1,2,2,1,5,2,3,6,6,4,6,2,6,2,3,2,4,3,1,1,6,3,4,5,2,3,2,4,4,5,2,3,4,4,5,3,6,4,6,5,5,6,2,4,5,3,6,3,6,6,4,4,5,6,1,1,1,5,5,6,2,2,2,5,4,1,3,3,1,6,4,5,3,5,5,3,1,2,4,1,4,5,6,3,4,2,6,3,2,6,6,4,4,1,3,4,6,2,1,2,4,4,6,1,3,3,3,6,4,4,2,2,2,4,5,3,2,4,4,4,6,3,3,6,1,5,6,4,3,5,2,2,6,4,1,5,2,5,3,1,3,4,1,2,6,4,4,3,4,3,2,4,1,3,6,1,5,4,2,6,6,6,3,2,1,3,4,6,1,6,6,4,1,2,1,2,3,3,4,3,3,6,1,5,2,4,4,5,6,3,2,2,5,6,1,3,4,2,4,1,1,4,4,3,5,2,6,3,1,4,3,2,5,2,5,4,6,1,2,2,3,4,2,4,2,3,6,3,4,1,5,5,4,2,3,4,1,4,4,2,2,2,4,6,6,2,1,1,4,4,5,2,2,6,2,2,5,1,1,3,5,4,3,1,5,3,2,3,3,6,4,5,6,4,6,3,4,3,2,1,5,6,2,4,6,1,1,1,3,3,3,2,4,5,2,5,3,5,2,3,1,2,6,3,2,2,4,4,2,1,1,4,5,3,5,3,5,6,6,3,4,2,1,3,4,1,4,5,3,6,2,5,6,6,6,1,4,5,5,5,2,3,5,6,3,5,3,3,4,6,3,5,4,1,5,4,4,2,2,2,3,5,1,4,5,3,2,3,4,1,2,6,6,5,6,1,5,6,1,6,4,1,6,5,5,1,4,4,6,3,6,6,3,4,3,1,4,6,1,1,5,2,5,2,5,1,1,2,5,1,4,5,4,5,6,3,5,2,3,1,1,4,6,6,5,3,3,5,4,4,3,2,1,1,4,6,2,2,5,1,1,6,2,1,4,6,2,3,1,3,2,3,1,5,6,2,3,2,6,3,3,3,1,4,6,5,1,6,5,3,2,4,4,3,6,2,2,2,3,3,6,4,4,3,1,1,5,4,3,1,3,2,6,1,2,3,2,4,6,4,5,2,3,6,3,2,2,1,1,6,6,5,1,1,1,3,5,2,1,4,1,2,3,3,5,2,1,3,5,2,2,2,1,6,3,4,2,2,6,2,4,6,2,3,3,5,6,5,6,5,4,3,6,5,4,1,3,3,5,5,2,4,2,5,3,6,4,3,5,5,5,5,3,2,4,4,5,2,1,6,2,4,6,2,3,5,2,2,6,3,1,4,5,5,5,3,2,1,6,1,2,1,4,2,6,4,1,5,2,3,3,6,5,5,2,1,5,6,1,6,6,6,5,2,4,3,1,5,1,3,5,6,3,5,2,2,2,6,6,4,3,5,4,2,4,5,3,2,2,4,3,3,5,2,5,6,5,2,5,3,5,1,1,3,5,3,4,2,6,3,5,2,5,4,2,4,2,3,1,4,4,2,3,4,6,1,4,6,5,6,1,4,5,3,3,5,4,6,6,3,2,6,5,5,2,3,6,1,1,3,4,1,6,2,6,3,4,2,1,6,6,2,4,2,4,4,4,2,1,2,5,3,3,1,3,4,2,3,2,4,2,1,5,1,2,3,3,5,5,1,4,4,1,2,5,5,4,4,3,5,6,2,2,5,4,6,1,5,6,3,5,2,4,1,6,1,3,3,2,4,5,3,1,4,5,1,2,1,4,6,4,1,5,2,6,2,1,6,6,6,4,1,6,1,5,4,4,2,4,1,1,2,2,5,4,2,5,6,4,3,3,3,2,3,4,6,6,4,3,6,4,1,2,6,5,2,5,1,3,6,6,2,5,1,6,6,5,2,1,3,2,2,1,3,2,1,5,2,1,5,6,4,6,2,4,4,2,1,4,1,1,4,4,5,1,5,2,3,5,6,2,4,2,2,2,4,1,2,1,5,3,1,2,3,5,1,3,2,2,6,6,1,5,3,5,3,2,6,4,3,2,6,1,1,5,4,2,1,3,3,3,4,2,1,4,6,3,3,3,3,1,1,5,5,4,1,4,6,5,1,1,6,6,5,5,1,5,1,6,6,2,2,6,6,4,1,5,5,2,4,2,5,2,2,4,2,5,6,2,1,6,5,3,3,1,3,6,4,6,3,1,1,4,6,2,6,4,6,3,1,6,2,6,4,6,2,3,1,3,2,2,5,6,2,5,4,2,5,1,2,3,6,2,5,4,1,2,2,1,2,4,5,3,4,6,4,4,6,4,6,1,2,6,6,5,3,1,4,5,6,6,2,5,5,4,5,5,2,5,3,3,3,6,5,2,3,4,6,4,3,5,5,4,5,3,6,6,4,5,2,5,4,2,3,1,5,2,6,6,1,4,4,6,1,3,1,2,5,5,1,1,3,5,2,1,2,1,1,2,1,1,3,6,2,5,4,3,1,4,6,1,6,5,2,5,5,6,2,3,5,4,5,5,3,1,6,1,2,3,6,4,5,2,6,4,6,6,4,6,1,4,3,6,5,5,4,5,1,5,2,3,6,6,2,3,2,2,4,6,4,3,3,1,5,3,6,4,5,5,1,1,1,5,6,6,4,4,1,2,6,5,6,4,6,6,6,5,2,3,1,1,6,4,2,3,1,6,6,5,5,3,2,5,1,4,2,4,2,2,4,4,1,5,2,6,2,4,5,2,3,1,6,6,5,4,2,6,5,3,2,5,6,6,4,5,6,6,5,3,1,5,3,4,1,1,2,1,1,6,2,2,6,1,4,2,4,6,6,4,1,2,5,4,4,3,1,2,1,3,4,4,3,2,6,3,6,6,5,4,1,5,1,4,1,2,3,2,5,2,2,1,2,2,5,1,6,1,4,2,1,5,5,2,4,2,6,6,2,5,5,5,4,4,4,6,3,2,3,4,3,6,5,3,1,1,4,1,2,3,4,3,3,6,2,6,1,4,3,1,5,4,3,5,5,5,1,6,5,5,6,3,4,6,4,6,1,5,3,4,5,4,1,1,2,1,1,6,4,1,6,6,4,3,2,6,5,5,5,2,6,1,6,6,3,6,3,1,6,1,3,5,3,1,3,4,5,4,1,4,5,1,6,6,6,1,2,1,4,5,4,6,2,4,1,1,4,4,5,2,2,3,2,4,3,4,4,6,6,5,2,3,5,6,2,5,4,4,4,2,4,1,5,2,4,2,4,2,3,5,4,4,2,2,5,1,6,3,3,6,2,3,2,5,5,1,2,5,4,1,4,2,3,2,3,4,2,6,2,2,5,2,1,4,1,1,2,6,6,6,2,4,5,3,1,5,5,3,3,5,4,2,4,4,4,6,5,2,5,3,6,4,6,3,6,5,3,2,4,2,6,1,2,5,6,6,1,2,2,5,1,3,4,5,1,3,4,4,2,4,3,6,1,4,1,2,3,1,5,3,6,6,1,5,1,5,6,5,5,5,4,4,2,1,2,3,4,3,6,3,4,6,2,3,4,5,2,5,5,6,4,2,2,4,2,4,6,3,5,1,6,4,1,6,5,1,4,6,5,6,1,2,4,6,2,1,5,4,5,4,2,4,1,6,4,1,1,3,3,2,4,5,4,4,2,6,6,5,3,6,6,4,6,2,4,4,2,3,3,5,6,5,3,3,1,1,6,5,5,6,1,1,3,6,1,5,3,2,3,2,2,5,2,6,5,6,5,3,5,4,2,1,6,5,2,2,3,5,3,5,3,6,4,4,3,5,2,2,3,4,5,3,1,5,2,6,3,2,4,4,5,3,4,3,2,1,4,1,4,6,1,2,6,3,5,3,6,4,4,4,5,4,6,6,2,3,6,1,5,3,4,4,5,4,5,5,4,5,1,4,4,4,3,4,1,4,5,1,5,6,5,3,2,1,6,4,5,4,2,4,3,5,5,1,2,5,5,2,5,1,1,5,1,1,2,5,5,3,2,3,5,6,4,1,4,2,3,6,1,4,2,2,3,3,5,1,1,1,3,3,1,2,2,2,5,4,1,4,3,2,6,1,2,3,3,1,2,1,5,5,3,3,5,6,4,6,2,5,5,1,3,4,4,1,1,1,1,3,1,1,3,3,4,3,1,3,1,3,1,3,5,6,1,3,2,3,3,1,3,2,6,5,1,6,1,2,3,5,5,3,6,5,2,5,6,6,2,5,6,5,5,1,3,6,1,3,3,4,6,5,1,1,5,1,4,5,4,5,5,6,6,6,5,5,5,3,4,5,1,3,4,1,2,5,4,3,1,6,2,4,6,5,5,4,5,4,1,1,2,1,3,5,5,5,2,6,5,4,5,2,6,1,2,3,2,4,5,3,2,5,6,5,4,3,2,5,1,4,5,5,2,4,2,5,1,3,5,3,2,3,6,4,6,4,4,1,1,5,4,2,5,3,4,4,2,4,3,6,3,1,5,2,4,6,5,2,4,4,3,3,4,2,6,2,6,3,2,3,6,1,1,2,1,3,2,6,2,6,2,6,2,4,1,3,6,4,5,2,6,5,6,4,6,1,4,5,4,6,5,3,1,4,5,4,5,3,2,2,3,2,2,3,1,4,3,5,4,1,1,2,5,6,5,2,5,1,6,1,1,2,6,2,6,4,6,1,6,4,1,3,5,2,5,2,4,3,4,5,3,3,5,5,6,4,4,5,3,3,2,2,5,5,1,3,4,2,1,5,5,3,4,5,5,3,3,1,2,6,4,2,5,2,2,5,4,5,2,5,2,4,6,1,4,3,3,1,2,4,1,4,2,1,1,2,3,1,6,6,6,5,5,1,3,1,6,2,1,5,6,1,6,4,5,3,4,1,2,3,6,5,6,4,2,4,6,3,6,4,3,2,6,6,2,1,2,4,1,5,4,2,6,3,4,5,6,4,4,1,1,1,3,1,4,5,6,6,2,1,4,5,4,6,4,2,1,6,4,3,4,2,2,6,5,6,5,3,2,1,4,6,2,2,4,3,4,3,3,5,4,6,4,1,5,4,1,6,4,2,4,5,5,3,5,2,3,1,5,4,3,1,3,3,1,1,2,2,6,6,5,1,5,2,5,5,5,6,3,3,5,4,4,3,3,1,1,4,2,2,3,3,2,2,4,2,4,1,5,2,2,2,3,5,3,1,4,6,6,4,4,6,2,3,4,6,3,4,5,5,1,5,1,6,2,6,2,1,6,5,1,3,3,3,5,1,6,2,4,5,1,6,3,6,1,5,2,1,2,1,1,4,4,2,3,2,1,6,3,3,4,5,1,2,6,6,2,6,2,4,2,5,4,6,1,4,6,6,5,6,4,1,2,1,6,4,6,6,5,3,4,2,6,1,1,4,5,3,3,3,2,3,3,1,2,5,5,1,6,6,2,6,6,1,6,2,5,5,4,3,1,4,1,2,2,1,2,1,3,1,6,4,4,5,5,4,1,1,2,5,6,1,6,6,2,1,5,4,5,2,6,3,5,5,6,1,4,6,5,4,4,4,3,2,6,3,2,2,4,5,4,1,2,5,2,1,4,5,1,2,6,3,2,3,6,6,6,2,2,6,1,4,4,4,5,5,4,5,3,5,3,5,2,6,6,5,6,5,1,5,3,4,5,5,6,4,1,6,2,5,5,5,1,4,2,3,2,3,4,3,2,3,5,6,5,6,6,3,2,6,1,4,6,1,3,4,6,5,5,6,5,6,2,1,6,4,6,5,4,3,1,5,4,6,1,1,6,3,3,3,4,1,5,3,2,4,6,6,3,3,5,5,6,4,1,6,4,6,6,4,3,6,6,3,4,5,6,3,4,2,6,6,2,6,2,4,5,1,1,6,4,1,6,2,3,4,4,6,4,2,4,1,3,3,3,1,2,1,2,1,2,1,4,4,1,2,4,6,1,4,3,1,1,5,6,4,2,1,1,1,5,2,2,4,5,2,6,3,1,4,6,2,4,2,1,6,1,4,4,6,6,6,5,2,2,3,4,6,3,1,2,1,6,4,3,2,4,2,2,4,2,6,1,5,2,3,6,6,3,1,3,3,2,6,4,4,5,4,6,6,1,4,6,2,1,1,1,4,2,3,5,2,5,5,4,3,1,2,1,3,3,1,5,6,1,5,6,6,1,6,5,4,3,5,3,1,1,1,4,2,5,6,2,4,4,6,6,4,3,3,1,6,5,6,4,6,5,2,3,2,1,1,6,5,2,6,1,2,1,5,3,4,3,4,3,4,6,2,1,5,2,4,2,2,4,4,6,1,1,5,4,4,4,3,4,6,1,3,6,1,4,4,4,3,4,5,1,4,2,6,1,6,4,6,6,4,4,1,1,4,4,3,2,3,1,4,3,2,1,6,3,1,2,4,4,3,1,6,1,2,2,1,4,3,4,6,2,2,4,2,4,6,5,2,1,6,2,4,3,3,5,5,3,6,6,5,3,3,4,1,6,4,1,6,5,4,2,6,3,2,3,2,1,3,5,5,2,6,3,1,5,3,3,5,5,6,4,2,3,3,3,4,1,1,5,4,3,3,4,6,5,2,2,4,2,6,4,3,2,4,3,6,1,1,2,6,3,4,4,5,6,6,6,3,5,4,3,6,6,5,3,1,4,4,2,2,2,2,2,2,2,2,6,5,3,4,1,2,5,1,4,1,5,3,4,4,2,5,4,2,2,1,6,3,6,5,2,4,2,1,6,6,1,6,1,6,5,3,6,4,6,4,4,5,2,4,2,3,2,4,1,6,4,6,1,2,3,4,1,2,1,2,6,4,5,4,1,5,6,1,4,3,2,6,5,6,4,3,2,6,6,6,6,5,3,4,5,4,2,4,5,3,4,2,3,5,1,6,6,6,5,1,6,2,3,6,6,5,3,6,5,1,5,4,4,4,6,5,5,4,2,4,5,3,3,1,1,3,6,5,1,2,5,5,6,6,2,1,3,6,1,1,2,5,2,6,6,5,1,1,4,6,4,5,3,5,3,1,5,5,5,2,1,6,1,6,1,1,4,1,5,3,3,5,2,2,2,5,3,6,1,4,4,2,5,2,1,4,5,2,6,4,5,3,2,3,1,2,5,3,4,2,6,3,2,4,1,6,2,4,3,6,1,4,1,5,2,3,4,4,1,6,5,5,2,3,2,2,4,2,6,1,4,5,6,3,1,5,5,6,1,1,2,2,3,3,3,3,1,4,1,5,5,6,1,3,5,5,3,3,4,3,5,4,6,2,3,1,5,2,5,3,6,1,6,3,6,5,5,1,6,1,3,1,5,2,6,2,1,6,6,2,5,5,4,4,1,1,6,4,1,1,3,4,5,2,3,3,4,3,2,3,4,4,1,3,6,2,4,5,5,3,3,2,6,1,5,4,6,3,3,4,4,4,3,4,1,6,4,4,4,4,4,1,1,1,4,2,1,6,6,2,5,1,1,5,1,1,6,1,1,6,4,5,5,5,2,5,3,3,4,4,6,2,4,6,2,2,4,3,3,2,1,4,5,4,1,4,6,6,2,5,2,5,4,3,6,4,3,4,4,3,3,3,2,3,5,5,4,1,1,4,4,5,5,2,3,3,4,5,5,1,5,4,3,1,6,5,1,3,6,3,6,2,4,2,6,3,1,6,5,6,6,4,4,4,6,6,5,6,4,5,1,5,6,6,4,6,2,1,6,3,6,2,4,5,3,2,2,1,2,4,2,2,5,1,5,5,2,6,3,1,4,3,2,2,5,2,6,3,2,2,4,3,3,2,2,5,1,4,5,4,5,6,4,2,2,5,5,1,2,5,4,4,2,5,4,1,5,4,2,5,5,2,1,4,5,3,6,6,6,6,1,1,2,1,6,4,3,3,5,4,3,5,4,5,3,3,5,6,6,5,1,4,6,5,6,4,1,6,1,6,5,4,1,3,2,3,5,4,5,6,5,1,3,4,4,3,4,2,2,6,1,4,4,4,1,5,4,2,2,3,2,3,3,3,2,6,1,4,5,6,3,5,4,2,5,2,5,5,4,4,6,6,2,2,3,3,4,4,5,6,3,6,1,1,5,3,2,5,4,2,6,6,6,3,4,5,1,5,4,6,1,3,4,4,6,3,1,3,5,5,6,1,2,5,6,6,3,3,1,5,5,3,4,6,6,4,4,6,5,4,1,5,1,2,6,5,4,5,6,1,4,5,5,2,6,1,6,6,2,4,6,6,6,6,1,1,5,2,3,2,1,2,5,2,6,1,6,1,3,4,6,5,5,1,1,4,3,1,1,1,4,5,5,4,5,3,2,1,6,1,6,1,6,4,6,2,6,6,3,3,3,6,4,1,4,1,1,5,4,4,6,6,3,1,5,6,6,4,4,5,1,1,2,2,3,6,6,1,4,5,4,6,2,3,6,4,1,6,3,4,1,2,5,5,1,3,2,5,3,1,1,3,4,4,3,4,4,2,6,4,4,3,2,2,3,2,5,1,5,1,2,3,4,5,2,2,3,1,4,1,4,3,1,1,2,1,1,2,4,4,6,4,1,2,1,6,2,6,1,6,1,4,4,6,2,4,3,4,1,5,2,6,3,5,2,5,1,3,3,6,1,2,6,5,2,4,5,4,4,4,6,5,6,3,3,1,4,4,2,4,4,3,6,1,4,1,3,4,2,6,1,2,3,6,1,5,5,4,2,3,1,2,3,4,4,1,4,4,1,5,3,1,6,5,6,6,6,4,2,1,5,5,6,5,4,4,4,4,4,6,2,1,2,5,4,2,1,2,4,4,1,5,3,2,5,3,5,4,2,6,5,4,3,6,6,2,5,5,1,5,2,2,3,4,1,3,4,1,5,1,4,4,2,5,4,1,6,2,5,6,2,1,1,4,2,2,1,2,2,2,5,6,4,1,2,4,3,5,3,4,5,4,4,5,3,4,1,1,5,1,2,1,4,2,5,1,1,1,3,5,6,4,1,5,3,5,3,6,1,4,5,3,3,3,1,4,2,6,2,2,3,4,2,4,1,2,1,4,5,2,1,4,2,3,4,5,3,2,3,2,1,5,5,4,6,6,3,2,6,3,6,6,1,1,2,3,1,3,6,6,4,4,2,1,6,6,1,3,1,2,5,6,3,3,5,6,6,6,5,6,6,6,3,5,1,6,6,5,2,1,5,6,3,1,4,6,6,3,1,1,5,1,2,3,1,3,4,2,5,5,3,3,1,3,2,3,2,6,6,2,4,6,6,6,6,2,4,3,3,2,1,1,3,2,1,6,2,4,5,3,6,3,2,5,5,5,3,3,6,6,4,2,5,5,3,3,1,2,4,5,3,4,2,2,5,3,6,4,2,3,3,6,2,1,5,1,1,1,1,6,2,2,6,6,5,1,5,4,6,6,5,1,1,2,4,3,5,2,6,2,2,5,6,2,6,5,6,4,5,6,4,1,6,1,6,6,2,5,2,6,6,2,2,4,3,5,4,1,1,6,5,2,5,4,1,2,1,2,4,5,3,4,3,2,2,4,3,2,4,3,2,5,2,2,1,3,2,4,5,3,4,4,1,3,5,1,5,5,1,3,2,5,5,3,3,6,6,2,4,5,4,1,6,3,4,4,4,1,1,2,1,5,6,5,1,1,4,6,6,6,1,3,4,3,6,5,4,1,2,1,5,3,1,2,2,1,5,3,6,6,3,1,2,1,6,5,1,2,4,5,4,3,5,5,3,3,5,1,6,4,4,2,2,4,3,4,5,4,5,1,4,3,1,5,2,6,5,1,6,6,6,6,1,1,6,3,5,4,6,4,1,1,2,3,2,6,6,6,5,4,2,5,6,1,2,3,6,4,4,5,6,5,5,2,6,5,4,1,5,2,6,4,6,2,4,4,5,1,6,2,1,1,6,3,4,6,6,6,1,2,1,5,5,5,4,2,3,6,2,6,1,4,1,2,3,2,4,2,4,2,6,6,1,6,1,3,4,1,1,2,2,2,6,3,5,1,1,1,6,2,3,1,3,4,5,4,2,2,4,1,4,1,5,1,5,2,6,6,6,2,4,2,5,4,2,5,4,4,1,3,1,2,5,6,2,4,5,1,2,1,1,1,1,5,1,2,3,1,2,5,1,2,3,4,6,6,6,5,4,4,5,1,1,1,3,3,3,2,5,1,6,4,3,1,3,6,4,2,3,6,5,3,3,1,2,6,5,1,2,6,6,5,1,4,4,1,4,6,4,2,5,1,1,5,1,1,3,2,2,6,5,5,3,6,2,6,2,5,6,3,4,2,2,1,2,4,6,5,5,1,1,4,2,1,4,5,5,4,1,4,5,4,2,5,5,6,5,5,1,6,4,6,4,5,5,5,6,2,1,3,3,4,1,3,6,4,6,2,2,6,3,5,5,3,6,3,3,4,5,1,6,1,4,2,3,6,2,2,1,6,3,4,5,3,3,4,2,5,3,2,5,3,2,2,4,5,1,4,5,4,5,5,2,5,3,3,3,1,3,6,5,2,1,4,5,4,2,4,5,6,4,1,2,1,5,6,1,6,4,3,4,1,3,5,1,5,6,1,3,2,2,6,1,3,6,2,6,6,4,2,6,4,5,3,4,2,2,1,5,4,4,2,2,6,2,5,4,6,5,5,1,1,4,5,2,4,2,6,4,1,4,5,3,4,3,1,3,2,6,1,4,1,5,5,1,6,1,2,5,5,5,3,5,6,6,3,3,6,4,2,6,4,5,1,3,5,6,6,1,2,3,5,3,3,2,5,6,1,1,2,6,3,2,4,1,5,1,5,6,4,3,4,1,2,3,6,2,2,1,3,6,5,6,6,6,6,2,3,4,1,6,2,1,1,6,1,5,3,4,5,6,2,3,1,6,2,5,2,3,3,6,3,6,6,6,6,3,4,2,6,1,3,5,2,2,2,5,1,1,1,3,2,3,5,3,2,4,4,4,5,3,2,1,5,1,3,5,4,6,4,6,2,6,3,2,5,6,5,5,6,2,5,5,2,4,2,5,5,3,3,3,5,5,4,5,2,5,6,1,5,2,4,3,2,1,6,5,2,1,2,5,3,3,1,5,4,3,1,3,6,6,2,4,5,1,1,3,6,6,3,5,2,1,1,4,1,2,3,2,1,5,4,3,1,3,1,1,4,4,2,5,1,1,3,4,5,4,1,6,5,2,6,2,6,1,4,5,6,1,5,5,4,3,6,1,5,1,4,4,6,3,4,3,5,6,5,1,5,5,3,6,5,1,1,5,5,2,6,3,5,3,6,2,5,3,6,6,2,1,3,5,3,2,4,2,6,1,6,1,2,1,5,4,4,6,3,2,2,2,5,1,4,1,2,2,3,4,5,3,3,1,6,1,1,5,1,6,1,1,6,3,4,1,4,5,2,2,2,5,2,2,2,5,5,1,2,2,2,3,1,4,5,5,2,4,5,1,1,1,1,5,1,2,5,1,3,1,3,3,4,6,3,3,4,5,4,4,1,2,1,6,1,6,2,3,1,6,1,3,3,4,4,3,5,6,2,5,2,4,3,2,1,6,6,6,6,2,6,4,4,4,4,2,3,4,1,2,5,3,4,5,3,3,1,4,4,6,5,3,1,3,3,5,3,2,4,5,1,4,2,3,4,3,5,6,6,5,6,5,2,5,1,5,6,3,6,1,1,3,2,4,1,1,3,2,4,1,5,6,2,2,5,6,5,3,5,2,2,5,2,6,1,6,2,4,2,2,4,5,3,4,2,2,3,6,5,1,1,4,6,3,5,6,5,3,3,4,5,4,4,6,5,1,3,3,3,6,5,6,3,6,1,1,5,2,6,4,6,5,4,4,1,5,3,3,2,2,4,5,5,4,3,1,2,5,3,5,4,6,6,2,1,1,4,5,2,6,3,4,6,4,3,4,5,1,3,3,6,2,6,6,4,5,1,6,3,4,4,4,6,4,1,3,5,5,2,2,1,3,2,1,6,5,1,2,1,2,4,4,6,6,5,4,2,2,6,4,1,2,2,3,1,5,2,3,3,5,4,5,4,2,6,2,3,4,4,4,1,4,1,6,3,4,3,4,5,1,2,4,1,6,1,4,1,5,1,3,4,3,4,3,4,5,3,4,1,6,5,2,5,4,2,4,5,2,2,4,5,2,2,3,4,5,1,4,2,6,1,2,2,4,6,2,5,3,6,4,3,4,4,3,5,3,6,2,3,5,5,4,1,2,1,5,6,3,5,3,2,5,3,3,6,5,2,4,3,3,4,5,6,5,3,4,4,1,6,1,4,4,4,6,6,1,6,5,2,4,5,2,3,2,4,2,2,2,2,5,1,1,5,2,4,4,1,1,1,6,4,5,4,6,1,5,5,1,6,1,3,1,2,4,2,1,3,6,5,6,6,1,1,3,1,6,5,6,6,3,3,6,6,5,2,1,4,1,2,6,6,2,2,3,5,3,6,2,1,5,4,6,6,3,2,2,2,5,4,2,4,4,4,1,5,3,5,5,2,1,6,6,6,2,3,5,6,4,1,5,3,6,5,4,3,2,3,5,5,6,6,1,5,2,4,2,3,1,2,1,4,3,5,1,6,5,1,5,3,5,3,4,6,5,1,2,2,2,3,3,1,6,2,3,6,6,1,2,5,1,6,6,3,3,1,4,6,4,3,2,4,5,3,3,1,5,5,5,2,4,6,4,2,5,4,3,3,4,5,1,4,1,4,5,5,3,6,5,4,2,1,2,2,3,5,4,3,2,6,6,6,6,1,4,2,5,5,2,4,3,1,3,5,1,2,6,3,4,3,5,4,4,5,3,2,5,4,1,4,2,4,5,2,5,4,2,5,5,2,5,5,6,4,5,3,6,1,5,5,1,3,5,6,5,4,6,1,5,4,5,3,2,2,2,5,3,6,6,3,5,1,4,2,4,5,3,1,1,3,4,3,5,2,3,2,6,3,6,6,6,3,3,1,4,4,6,5,3,2,3,1,5,2,1,2,2,4,1,2,1,1,1,5,4,3,4,5,4,2,6,6,2,3,6,2,3,1,5,1,2,1,4,6,3,6,5,3,6,4,6,4,6,1,4,2,3,6,6,2,1,1,6,3,4,2,3,6,6,3,6,1,5,1,1,5,2,5,2,2,3,4,2,3,6,1,6,1,1,2,2,2,3,3,6,1,5,4,2,6,6,3,4,5,4,2,6,2,3,6,6,6,4,2,5,3,5,2,2,4,6,3,4,4,1,4,6,6,3,4,3,6,5,5,1,2,2,2,3,1,6,2,4,4,2,2,3,2,4,5,5,6,3,5,2,1,2,2,4,4,4,1,2,6,3,2,3,3,1,3,5,4,4,2,6,1,5,5,1,1,4,6,6,4,1,5,1,3,2,1,6,5,5,6,4,2,4,6,1,1,6,5,6,2,4,2,4,3,6,3,4,2,2,5,1,1,5,2,2,3,1,1,4,6,3,6,1,6,5,4,1,5,2,1,1,4,1,5,1,4,1,2,2,1,4,2,5,4,3,5,4,2,6,1,5,6,1,4,3,1,1,3,5,3,3,3,1,2,6,4,3,6,6,1,4,6,4,3,1,2,1,3,5,4,2,1,3,5,2,4,2,2,5,4,2,1,6,5,4,5,6,6,1,6,3,5,3,3,1,5,1,2,5,5,5,3,5,3,6,4,4,5,2,4,3,3,5,3,1,6,2,6,2,3,6,2,6,6,1,6,2,1,1,1,4,4,1,2,1,1,6,3,3,1,4,3,6,1,5,5,3,4,6,2,1,2,5,1,5,5,2,5,5,3,3,4,5,6,3,5,3,6,5,2,2,3,2,3,5,1,2,6,1,6,3,3,5,3,2,5,6,6,2,1,4,4,6,3,2,2,2,2,6,6,6,2,4,2,1,3,5,6,5,4,2,6,6,3,2,1,3,2,5,1,6,3,2,6,6,4,4,5,1,6,6,3,3,4,1,1,2,2,2,3,6,6,3,2,3,5,2,6,6,1,5,6,4,3,2,1,4,1,2,6,4,2,6,5,3,1,1,1,5,3,5,1,3,2,2,5,6,6,3,5,3,2,5,3,4,5,4,1,4,1,3,2,3,2,4,4,6,2,6,2,1,5,6,6,5,6,4,2,2,5,4,6,5,3,3,6,3,4,2,3,4,5,6,5,2,5,6,1,6,2,1,6,6,6,4,4,5,5,6,2,4,6,1,3,3,3,6,3,6,6,2,5,4,1,6,2,2,3,5,2,4,5,4,4,2,3,5,5,3,4,5,2,1,3,3,5,3,4,6,5,2,1,2,2,2,3,6,2,1,4,5,6,2,1,3,5,4,5,3,5,5,4,3,4,2,4,1,2,5,6,6,5,1,2,4,6,2,2,6,4,3,3,1,6,1,3,5,3,2,1,5,1,1,1,4,6,6,4,5,2,4,2,3,1,5,4,3,6,6,2,5,5,1,5,1,4,1,5,5,5,5,3,2,5,2,6,4,5,4,5,4,4,3,5,6,2,3,1,4,2,1,6,1,2,1,2,3,2,5,3,1,6,4,2,5,1,1,5,2,4,3,5,4,4,1,6,5,6,2,5,4,5,2,3,5,3,3,6,5,2,5,5,4,6,5,6,4,6,3,3,4,4,1,4,5,6,4,4,4,5,4,1,6,5,6,5,5,4,5,6,4,3,3,2,5,6,3,1,3,4,5,1,1,6,3,1,1,3,4,1,1,4,1,1,5,4,2,1,3,1,1,1,5,3,3,1,6,1,5,1,1,1,4,1,3,3,2,5,2,4,1,2,5,6,6,1,6,4,1,3,4,1,1,2,3,5,5,6,2,3,1,3,3,3,5,1,1,4,3,3,4,3,2,1,6,2,4,4,6,1,6,1,4,1,5,1,3,3,1,3,2,1,5,2,5,2,3,6,2,6,1,3,6,1,4,5,3,4,1,3,2,2,1,3,4,3,5,2,3,4,1,1,6,1,4,2,4,1,5,5,5,4,2,2,6,3,2,4,3,6,5,4,3,4,3,5,5,4,4,2,3,5,1,4,3,4,4,5,1,1,4,3,2,4,5,5,1,4,3,2,6,2,2,4,1,1,2,1,6,3,2,3,1,1,1,3,6,4,6,2,4,3,3,4,3,1,6,6,2,6,5,4,1,4,1,5,5,3,3,2,1,4,1,4,3,5,6,4,2,6,3,3,5,2,3,1,6,4,3,5,4,1,1,2,1,2,4,6,3,6,1,4,5,1,1,4,5,4,4,4,2,1,4,4,1,3,3,5,3,6,3,4,4,5,6,5,3,5,2,1,2,4,5,2,3,4,6,4,3,5,6,3,3,6,6,4,6,1,5,6,4,6,4,3,3,3,6,1,4,4,1,1,6,2,4,4,1,5,1,3,1,5,4,6,5,6,2,4,3,3,3,4,2,2,5,2,2,5,2,2,5,3,4,2,6,3,3,5,2,5,4,4,2,6,1,1,1,1,1,6,6,1,1,2,1,1,6,6,2,6,5,1,2,3,4,6,4,1,6,6,5,5,4,5,3,4,2,2,3,1,6,3,5,2,1,2,5,6,4,2,5,1,4,2,4,6,6,6,5,3,2,2,2,1,3,5,1,2,4,2,6,4,2,2,1,2,4,3,6,4,3,2,5,6,2,6,4,4,1,6,5,1,6,1,3,1,1,4,3,4,6,1,4,2,2,3,4,6,6,3,3,1,1,5,2,2,2,3,2,5,2,5,6,1,4,1,6,2,2,1,5,2,2,5,2,3,4,1,1,4,1,1,5,2,5,4,6,2,5,1,5,3,5,5,4,4,6,1,6,4,1,5,1,5,2,5,3,3,5,3,2,3,1,4,1,5,6,3,2,4,3,6,6,4,3,1,6,4,1,3,5,1,1,4,5,4,2,1,6,2,6,4,6,4,6,5,5,3,1,6,4,1,1,3,1,1,2,1,3,6,3,4,6,4,6,3,5,2,2,4,6,3,6,3,5,6,3,6,3,1,2,3,6,2,1,4,4,4,6,4,5,6,3,4,2,5,2,3,4,1,1,2,6,1,4,1,4,4,4,6,5,2,3,3,5,4,4,4,2,6,1,2,1,6,1,2,5,5,3,1,5,2,4,6,4,3,6,1,2,6,3,3,6,1,2,1,5,4,1,3,6,3,2,4,3,3,3,6,3,5,5,6,3,5,5,6,1,5,4,5,4,3,2,5,1,4,6,6,5,1,4,5,1,5,5,4,1,3,1,2,3,2,3,1,1,4,1,5,5,3,2,5,3,3,4,6,3,3,6,5,5,3,1,2,2,2,2,5,1,3,5,2,1,2,1,1,6,2,6,5,6,5,1,1,6,3,5,5,2,5,6,4,2,3,4,1,3,1,2,3,4,1,5,6,5,4,6,4,3,4,2,3,1,4,5,5,5,2,5,2,2,5,1,4,2,6,6,3,6,4,4,5,6,5,4,4,1,1,4,3,4,6,5,6,1,3,6,3,3,6,1,5,5,5,4,6,4,3,2,1,4,5,4,5,2,6,6,3,3,3,4,1,1,1,6,6,4,1,5,2,2,2,5,1,4,2,1,1,3,3,3,1,4,4,6,6,1,6,5,3,3,5,1,5,6,1,1,6,6,6,4,6,4,4,1,6,5,2,6,3,3,6,4,2,2,2,3,2,3,3,4,6,3,2,4,3,2,2,2,3,4,6,4,1,3,4,1,1,5,3,2,5,2,2,1,4,4,1,5,6,4,6,5,5,5,5,3,6,6,2,5,2,5,5,6,1,1,3,4,6,1,3,3,4,1,3,1,6,5,1,2,4,2,4,6,4,2,2,2,6,6,1,2,1,5,3,4,4,2,5,2,6,6,6,3,1,6,6,1,1,5,6,4,1,2,4,3,6,1,4,4,5,5,1,3,3,1,5,5,4,1,5,3,2,3,1,4,1,1,2,2,4,3,3,1,3,6,2,3,4,2,2,1,3,5,4,2,4,6,4,5,3,6,6,3,1,2,5,2,1,2,4,4,1,4,2,2,6,6,5,6,6,6,2,6,5,3,6,2,3,6,1,3,2,3,4,5,4,4,2,5,2,6,5,3,5,6,1,6,3,6,4,2,5,6,6,1,4,5,2,1,1,3,4,2,2,1,4,3,1,3,1,3,5,4,4,5,4,3,4,6,3,5,1,1,1,3,3,4,4,3,4,2,1,5,1,1,1,2,6,3,2,2,2,6,3,6,2,2,4,3,6,3,4,6,4,4,1,6,5,1,6,6,5,4,3,3,4,1,5,2,2,2,2,3,4,2,2,5,6,3,2,4,1,6,5,6,6,4,1,6,4,2,2,4,1,4,1,6,5,1,5,6,1,5,2,4,3,5,5,1,5,2,5,1,1,1,1,1,1,1,4,6,3,1,3,6,3,6,5,6,2,6,3,6,2,2,2,1,6,2,6,4,3,6,2,6,5,1,1,6,3,3,1,4,2,3,2,6,1,5,1,2,4,4,6,2,4,1,6,1,5,3,5,5,3,4,5,5,3,4,2,2,2,1,4,5,5,4,6,2,1,3,3,3,1,3,3,6,6,6,4,1,3,2,2,3,5,4,4,6,3,5,4,3,1,3,1,1,5,6,5,2,3,6,2,2,4,2,5,2,5,3,1,5,3,6,5,6,2,5,4,5,5,6,5,6,1,4,2,1,6,3,6,6,2,2,4,2,1,6,4,6,5,5,1,2,4,4,1,2,4,1,6,5,3,5,1,4,2,5,4,6,6,5,3,6,2,2,3,4,3,1,5,4,4,6,2,6,1,3,1,4,3,6,2,1,1,5,5,5,2,1,1,2,4,5,5,6,1,6,4,6,2,6,5,2,5,6,1,2,5,2,2,2,4,5,1,3,3,1,6,2,3,1,6,2,1,4,2,5,5,3,2,2,2,6,5,5,1,4,2,3,2,2,4,3,5,6,4,1,4,3,5,4,5,5,6,5,5,3,3,1,1,3,2,4,5,4,2,6,3,4,3,3,4,5,5,4,1,5,1,2,3,4,5,2,5,5,2,1,2,1,2,6,5,3,4,1,4,1,6,1,2,1,2,3,6,6,6,1,4,4,3,2,6,3,4,5,5,6,2,2,1,5,2,1,1,2,5,2,5,3,1,2,1,2,1,2,5,3,3,5,2,6,3,2,3,2,5,4,6,4,1,3,6,2,4,5,2,6,4,2,4,6,6,4,6,6,2,4,5,6,5,6,3,3,3,4,4,3,3,2,3,5,2,3,5,5,6,2,6,1,1,6,4,4,3,4,2,3,6,2,6,2,1,5,6,2,5,6,4,3,4,3,4,2,1,1,1,2,3,4,1,5,3,4,4,2,6,4,3,2,3,2,1,3,3,1,3,6,5,6,5,3,2,5,5,1,1,3,5,3,6,2,3,6,2,1,6,4,5,6,2,5,2,6,3,1,3,6,6,2,2,6,6,6,2,3,1,1,2,1,5,4,5,4,3,1,1,3,6,5,2,6,1,6,2,3,4,3,4,6,4,4,1,5,4,1,1,3,5,3,1,6,2,4,3,6,5,1,3,3,3,5,4,2,2,3,3,3,3,3,1,2,1,6,3,6,1,5,1,1,6,4,6,5,4,3,2,2,4,6,1,4,3,3,2,1,1,4,6,4,2,2,4,6,1,2,2,3,4,3,3,1,6,5,5,3,6,4,5,2,3,1,3,2,4,3,3,1,1,3,4,2,4,3,4,3,4,1,3,1,5,6,2,3,2,6,5,1,5,3,2,5,5,4,6,5,3,4,4,1,4,6,6,6,4,1,3,1,1,2,1,4,5,3,2,5,6,6,3,3,4,5,3,1,4,4,6,3,4,2,1,3,2,5,6,4,4,4,1,5,5,2,3,6,1,3,2,6,5,2,4,5,1,3,1,1,6,6,1,3,6,4,3,3,1,3,6,1,6,1,6,2,5,3,4,3,5,1,6,4,1,1,5,4,5,4,3,4,5,4,1,1,6,6,1,2,6,6,4,2,4,3,1,6,6,6,2,3,2,3,1,5,6,2,6,1,2,5,1,4,1,6,3,1,5,6,6,4,5,1,2,3,3,2,1,5,4,2,5,4,4,3,6,6,5,6,4,1,4,4,5,4,4,5,3,4,2,5,1,3,3,4,1,4,2,6,4,5,5,2,1,3,2,4,6,3,5,3,6,6,4,6,3,5,1,3,3,2,2,5,2,2,6,5,5,5,1,2,3,4,1,4,5,5,1,5,6,3,4,2,6,4,5,2,1,4,5,3,4,4,3,1,3,2,3,6,1,4,2,4,3,5,1,2,5,4,2,6,5,3,2,2,4,1,2,1,3,1,5,3,2,6,1,2,6,2,2,6,6,2,6,3,6,1,5,1,6,3,4,2,4,4,6,5,3,3,3,6,1,4,1,1,5,4,2,4,2,1,6,3,4,1,4,1,1,6,3,6,6,2,6,1,1,5,2,2,6,5,5,1,4,4,2,1,1,4,6,4,3,5,2,1,2,4,2,3,4,3,6,2,6,4,3,3,3,6,2,4,4,1,2,2,1,1,4,1,5,3,3,1,1,2,3,6,3,1,5,4,3,4,2,4,6,2,5,1,2,1,2,5,5,5,1,1,6,4,6,3,4,6,5,1,6,4,5,6,3,2,1,4,2,5,6,4,6,5,4,5,4,3,4,4,1,3,6,3,4,6,4,3,6,1,6,6,3,5,5,2,4,3,2,3,3,4,2,5,6,5,2,1,1,4,3,5,5,2,1,2,2,2,2,5,4,1,5,4,3,2,1,3,1,3,4,2,6,6,3,4,3,3,2,4,5,1,1,6,2,3,3,1,6,5,3,1,3,4,2,1,6,6,2,6,3,2,3,4,2,3,5,5,1,1,1,2,5,6,6,6,6,1,1,4,4,5,3,2,6,3,5,2,1,3,5,3,3,1,2,5,2,4,4,5,6,5,4,2,6,4,1,4,4,3,3,2,1,3,6,3,5,3,6,5,4,2,3,5,6,6,5,4,5,4,1,2,5,4,2,5,5,1,2,2,1,1,6,1,5,2,1,4,6,2,5,1,5,4,5,2,5,6,1,5,6,2,4,6,4,2,4,6,5,6,6,4,5,5,1,5,1,1,5,3,1,6,3,1,1,1,1,1,2,1,3,4,2,5,4,4,2,2,6,3,5,6,1,4,6,1,1,5,6,5,1,4,2,4,3,5,1,6,1,1,5,4,1,1,3,4,3,4,5,4,5,5,3,4,2,6,4,2,4,2,2,6,4,6,5,5,3,6,6,6,3,6,3,2,6,5,4,4,2,1,3,3,5,2,2,4,4,2,5,3,4,3,3,3,1,2,5,5,6,5,3,4,4,2,2,6,1,2,6,3,4,5,3,5,2,4,1,5,6,6,1,1,1,4,1,6,4,1,6,4,6,6,4,1,1,4,1,1,2,5,5,3,1,2,2,6,1,2,5,2,3,1,4,2,2,5,3,1,5,4,5,5,3,2,1,4,2,2,3,2,3,5,1,1,5,3,4,4,5,6,5,1,3,1,6,6,5,3,5,3,4,4,3,3,4,3,4,1,6,1,5,1,6,3,6,6,1,6,6,2,1,6,2,1,1,3,4,5,3,4,3,5,1,3,4,4,3,1,1,6,6,6,1,1,5,3,4,4,6,5,3,4,1,1,2,4,4,2,3,1,1,4,3,5,5,5,5,2,1,6,3,6,3,2,2,2,5,4,1,6,2,6,6,3,4,4,5,4,2,6,1,5,5,2,5,5,3,6,6,5,5,1,4,2,1,2,1,4,3,5,1,5,4,1,1,5,4,3,4,5,4,1,4,3,1,6,5,6,3,3,6,4,5,4,2,2,3,1,3,3,6,6,6,1,3,5,4,3,6,5,5,3,5,3,1,3,4,2,2,5,4,2,4,3,3,3,3,2,3,5,4,1,1,5,1,4,6,6,4,3,5,1,3,3,5,3,5,4,4,6,4,3,4,6,3,5,2,3,2,5,1,3,5,3,2,1,4,3,5,6,5,1,1,4,2,1,5,6,1,4,6,5,1,2,2,6,5,5,4,4,6,1,2,6,3,2,1,4,3,2,6,6,3,1,6,4,5,4,1,5,3,5,2,5,6,3,1,4,5,2,1,5,3,2,5,6,6,5,3,2,5,6,4,1,2,5,3,4,3,5,5,5,6,1,2,3,2,2,4,3,4,4,1,6,5,1,6,3,4,4,1,3,3,3,1,1,5,1,3,5,1,2,5,1,6,4,3,1,6,6,5,5,5,1,2,6,1,6,1,6,6,2,3,3,6,2,5,5,1,1,2,1,3,6,1,4,4,4,4,1,4,3,5,2,1,4,2,1,3,6,5,1,4,1,2,3,3,6,4,2,6,5,2,1,1,2,6,1,6,4,2,6,2,4,1,6,4,4,5,3,5,6,1,6,1,3,2,6,3,4,5,4,3,3,1,1,6,4,5,4,4,4,6,3,5,5,1,3,1,4,3,6,4,3,6,5,2,5,4,6,1,4,4,3,5,3,2,4,4,2,3,3,1,4,3,2,5,5,2,5,1,4,2,5,2,1,2,3,2,3,5,4,1,2,5,6,3,5,6,1,2,3,3,3,1,4,6,2,5,4,4,4,3,6,6,1,4,6,3,4,6,4,6,5,5,5,6,4,2,3,5,2,5,4,5,4,2,4,6,5,6,4,1,3,6,4,2,2,4,2,3,2,6,1,6,6,4,2,3,3,1,4,2,6,2,2,6,1,6,6,6,6,3,4,4,5,6,6,2,4,3,1,6,6,6,3,2,1,6,3,4,5,4,5,2,2,2,2,1,6,6,5,5,6,4,4,4,3,5,5,5,1,4,5,5,4,1,5,2,5,4,2,4,5,3,2,2,6,3,4,6,6,4,5,6,4,5,3,6,5,6,6,6,1,5,1,2,1,5,5,1,1,4,6,2,2,4,5,2,6,2,4,3,4,1,5,2,4,5,3,6,3,6,5,3,4,2,2,1,6,4,3,3,5,2,2,6,6,1,6,5,5,4,5,1,1,2,6,2,3,1,2,5,2,6,2,1,1,3,6,2,2,5,6,2,5,3,3,5,1,5,5,1,6,4,1,4,5,5,6,2,1,4,1,1,6,6,6,2,6,6,2,6,5,6,2,4,2,1,5,6,1,2,6,4,2,1,2,3,3,4,3,6,4,4,2,3,3,1,6,1,4,4,6,6,3,2,4,1,5,5,2,3,6,4,2,4,2,1,2,4,4,2,4,3,3,2,1,4,2,1,1,1,4,6,4,6,6,4,5,5,2,6,6,1,2,3,2,4,4,1,6,6,3,4,1,5,2,6,6,1,1,6,2,1,5,4,2,6,1,2,1,1,2,6,6,6,4,2,5,5,2,5,5,3,4,2,2,6,2,6,4,2,1,3,5,5,1,3,4,2,5,6,2,3,5,4,4,3,2,5,5,6,5,5,4,2,4,6,6,1,5,6,3,6,1,2,1,4,4,1,5,3,2,2,5,5,4,1,5,6,2,2,2,3,5,4,5,4,3,5,1,2,2,2,4,1,5,5,6,4,5,5,2,2,2,3,4,3,3,5,2,2,6,1,2,5,1,6,1,5,1,5,1,4,6,3,5,6,5,1,5,4,2,4,6,2,2,3,6,2,5,5,4,3,6,4,1,4,5,4,2,3,5,4,6,1,5,4,5,3,1,6,2,2,1,5,2,6,1,2,5,4,4,1,3,2,2,6,6,1,4,4,5,2,6,4,6,2,5,2,1,3,5,2,3,5,6,4,3,2,2,4,5,6,6,6,5,6,3,2,4,2,2,3,5,5,6,2,1,6,5,6,1,4,2,6,3,1,3,2,4,2,3,2,3,6,3,5,1,3,6,1,3,4,3,2,3,4,6,2,4,6,3,1,2,1,1,2,2,5,1,6,2,3,3,1,4,2,4,6,3,3,5,6,1,3,6,4,2,2,6,3,5,6,6,4,3,4,3,2,2,6,5,3,3,5,3,2,1,1,1,3,1,4,5,3,2,5,2,2,2,5,3,5,4,6,3,4,6,5,2,3,5,5,4,1,4,2,4,2,2,4,5,2,4,3,3,4,4,6,2,6,6,2,6,2,6,4,1,6,4,5,4,1,5,6,6,1,6,2,3,1,6,3,1,6,2,1,6,3,4,1,4,3,1,1,6,5,3,2,6,6,6,1,4,3,1,6,3,3,5,6,2,3,3,6,5,1,2,3,1,6,3,2,1,4,2,6,6,1,6,1,5,3,2,5,3,5,6,3,6,4,2,4,4,3,3,3,6,6,1,5,3,2,6,4,5,6,2,6,1,6,3,5,5,3,2,1,5,6,1,2,3,5,5,6,5,1,6,3,6,6,3,1,6,2,6,6,6,5,2,3,1,2,5,2,6,3,1,5,2,4,1,2,2,4,6,4,6,4,2,1,3,1,2,5,2,3,4,4,4,2,5,6,3,6,1,6,2,1,5,4,1,3,6,3,5,2,1,2,1,4,4,6,5,4,4,1,2,2,4,2,2,2,3,1,4,4,2,4,5,4,1,6,6,1,4,2,2,6,5,1,5,6,6,2,6,1,6,5,6,1,4,3,5,5,6,3,2,3,2,2,3,1,5,3,5,1,4,4,4,3,6,3,3,4,5,5,2,6,1,6,6,2,4,1,1,5,6,2,4,2,2,4,1,4,2,6,3,2,4,1,2,2,2,2,2,6,6,1,4,2,1,4,3,4,1,2,3,3,5,1,1,2,6,4,4,3,6,6,5,2,1,1,4,4,2,6,4,2,5,5,2,5,3,1,1,1,3,4,3,1,3,4,4,6,6,5,2,1,6,2,5,6,3,2,2,3,2,3,5,2,6,2,2,1,2,1,4,3,1,1,1,1,2,5,6,5,1,6,5,3,2,4,4,3,1,4,2,5,6,4,3,5,4,3,1,4,2,3,3,6,6,1,5,5,4,4,5,3,3,4,5,4,1,3,2,5,2,4,5,3,1,4,2,6,5,5,1,4,4,3,2,1,4,3,2,5,2,2,3,3,3,1,5,4,3,2,4,1,6,3,1,5,4,5,6,2,2,3,1,5,2,1,5,4,3,6,5,3,1,3,4,3,2,1,5,1,2,2,1,5,5,3,1,5,4,3,5,1,3,1,4,4,2,6,4,3,1,2,6,3,2,4,4,6,1,1,4,2,4,1,4,3,3,3,6,5,3,6,3,6,2,5,6,4,6,2,5,1,6,1,4,3,6,1,3,1,4,1,4,3,5,2,4,5,4,3,6,6,2,3,1,4,5,2,3,5,2,6,2,3,5,4,4,1,4,5,1,3,2,6,3,6,1,5,1,3,4,1,3,6,5,5,4,2,1,2,4,5,1,4,4,1,4,2,6,6,1,4,4,3,1,4,6,1,2,1,1,6,5,1,1,5,1,6,4,1,6,6,3,5,3,4,6,3,3,4,1,6,2,5,5,3,1,1,5,5,3,6,4,1,6,5,1,4,1,1,5,3,2,5,3,5,3,4,5,1,3,3,2,6,5,1,6,1,6,2,1,4,1,3,5,4,6,5,5,2,6,5,1,3,4,1,5,4,1,1,5,1,1,3,3,2,2,3,3,2,1,5,2,2,5,1,2,6,1,2,5,3,3,6,4,4,1,5,4,3,4,2,2,2,5,5,1,3,1,3,4,1,1,2,2,2,4,6,5,3,2,5,1,5,1,5,5,3,1,3,5,2,1,4,2,6,5,1,3,5,6,3,4,6,4,2,6,4,5,6,3,3,2,3,6,4,4,5,5,1,4,1,5,6,3,3,5,3,3,3,5,6,4,1,1,3,6,1,1,5,3,4,1,3,3,5,1,5,2,6,4,6,6,6,6,6,6,1,1,6,6,6,6,2,5,5,6,5,3,1,1,6,4,5,5,1,2,6,1,1,3,1,5,3,4,3,2,1,6,2,5,2,2,6,4,6,4,2,3,2,4,1,1,3,4,2,1,2,5,1,2,3,3,5,3,1,1,5,1,2,3,2,6,1,1,1,4,4,6,2,6,3,5,2,3,1,1,6,4,5,3,4,2,1,2,6,3,2,3,1,3,4,4,3,1,4,4,4,5,1,1,3,2,4,4,4,4,3,2,6,3,4,4,2,4,3,2,5,4,2,1,4,2,4,6,1,5,1,1,1,5,5,1,2,5,2,6,5,3,4,3,1,1,2,6,2,1,3,4,1,1,6,4,6,4,5,6,4,4,1,2,5,5,6,2,3,6,2,5,1,3,2,1,5,4,6,3,5,1,4,6,6,3,1,2,1,5,5,6,6,3,5,6,4,6,3,3,3,5,6,1,4,4,3,6,5,5,1,4,6,1,3,1,5,5,5,2,2,1,1,5,3,2,3,4,4,1,2,6,4,6,4,2,2,4,6,6,6,1,2,4,1,4,5,1,4,3,3,2,6,6,6,2,6,1,5,3,1,3,2,1,2,5,6,4,1,6,6,1,6,4,5,5,1,2,6,2,2,1,4,3,6,3,3,6,5,6,4,1,4,2,2,5,5,5,4,1,2,5,2,3,6,1,3,6,5,5,5,1,2,1,5,4,4,1,6,1,2,6,6,5,5,1,4,3,1,4,3,2,4,3,1,2,3,6,4,5,2,6,6,4,1,1,3,5,2,6,4,4,5,6,6,5,6,6,2,3,5,6,5,5,3,6,2,2,2,2,5,6,6,3,5,5,2,3,5,5,3,4,2,6,2,6,1,1,6,2,4,4,4,2,3,3,2,5,4,4,4,6,3,4,3,6,1,2,6,4,5,4,4,6,2,5,6,5,5,5,3,6,1,4,2,5,6,3,1,2,2,1,6,3,4,1,2,3,6,2,5,1,5,4,6,4,6,5,5,5,6,3,4,6,3,6,4,5,5,4,2,1,4,2,2,1,3,6,3,4,6,2,1,4,6,4,5,5,5,1,6,5,4,3,4,6,5,4,2,5,1,5,3,5,6,2,1,4,5,5,1,2,1,6,1,2,1,3,4,2,3,5,1,2,4,1,2,3,1,3,3,4,4,5,5,3,3,6,5,1,2,3,2,6,2,3,5,5,5,4,4,6,3,3,5,5,5,6,3,5,6,3,3,6,2,2,1,2,1,6,3,5,2,4,6,6,1,5,1,5,5,6,6,4,1,6,2,2,5,4,3,6,2,1,2,5,5,2,5,5,2,6,5,4,6,3,2,6,2,1,1,1,6,3,6,2,3,1,3,6,1,4,2,2,6,1,6,4,4,2,1,5,2,6,1,2,6,3,3,1,3,5,3,3,1,2,1,6,4,1,4,6,3,3,5,3,2,1,1,1,4,3,5,4,5,5,2,4,5,4,4,5,4,6,4,6,1,6,2,5,2,6,5,3,5,1,1,6,2,2,3,2,5,5,1,5,5,5,6,3,1,6,5,3,4,1,5,2,6,2,6,4,1,6,2,4,5,1,1,4,6,4,5,3,5,2,2,3,2,6,4,5,2,4,2,6,5,2,2,1,3,4,1,1,4,3,4,1,2,6,4,1,1,5,2,4,5,4,2,2,1,4,4,3,4,3,3,4,2,2,1,6,5,1,1,4,4,6,5,2,6,6,1,2,3,1,6,5,5,2,5,6,4,5,4,1,3,1,4,3,1,2,3,1,1,5,2,6,4,1,3,2,5,4,1,3,6,1,5,4,4,5,6,5,2,6,6,6,6,6,4,4,4,3,1,1,5,4,5,4,3,5,6,5,1,3,1,4,5,5,4,6,3,2,3,4,3,1,4,2,5,1,5,3,5,6,3,4,4,4,6,5,5,1,1,3,2,6,3,6,5,5,2,2,3,5,3,1,4,3,2,4,4,3,3,1,2,5,6,2,1,1,3,5,2,5,5,6,4,3,2,3,1,1,3,3,2,2,4,3,1,2,4,3,6,2,6,3,5,4,2,5,4,1,4,1,6,3,5,4,4,4,6,1,6,5,4,1,1,5,3,2,3,1,6,3,2,6,2,6,2,3,2,2,6,4,6,6,2,6,1,2,6,1,2,2,4,4,4,2,6,2,5,1,1,2,3,6,5,5,3,4,5,3,2,3,1,5,6,5,6,1,3,3,6,1,3,4,4,1,1,5,3,1,2,2,3,4,2,1,4,2,4,2,3,4,2,5,4,5,1,1,2,6,1,6,5,4,4,1,6,6,1,6,1,2,2,6,6,6,6,1,5,2,4,2,6,3,6,1,6,4,4,2,2,6,5,4,6,3,1,1,3,6,1,1,4,5,4,1,6,1,1,1,4,6,1,1,1,3,6,2,4,1,5,2,2,6,2,5,2,2,5,4,2,1,1,6,6,3,3,3,3,6,4,5,1,6,5,4,5,3,4,5,4,3,1,4,4,6,1,3,5,4,2,2,1,1,3,4,3,5,4,3,1,6,6,6,1,6,3,6,6,3,6,2,5,2,6,6,5,6,4,2,3,1,4,3,5,3,5,3,1,2,3,5,6,2,6,1];
        mean = 2;
        n = 25419;
        foreach (var answer in solution.MissingRolls(rolls, mean, n))
        {
            Console.Write(answer + " ");
        }
        Console.WriteLine();
    }
    
    public class Solution {
        public int[] MissingRolls(int[] rolls, int mean, int n) {
            // (total + x) / z + x = mean
            // Remaining = total - mean * z
            // 

            int remaining = mean * (rolls.Length + n) - rolls.Sum();
            int avgVal = (int)Math.Floor((double)remaining / n);
            if (avgVal > 6 || avgVal < 1) // Impossible, since most have to be above 6 or below 1
            {
                return [];
            }

            int remainder = remaining - avgVal * n;
            if (avgVal == 6)
            {
                if (remainder > 0) return [];
            }
            if (remainder > n) return [];
            int[] answer = new int[n];
            for (int i = 0; i < n; i++)
            {
                answer[i] = avgVal;
                if (remainder > 0)
                {
                    answer[i] += 1;
                    remainder -= 1;
                }
            }

            return answer;
        }
    }
}