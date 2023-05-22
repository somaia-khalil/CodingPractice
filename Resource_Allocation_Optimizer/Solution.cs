// Solution to The Resource Allocation Optimization challenge

using System;
using System.Linq;

public class Program
{
    public static int OptimizeResourceAllocation(int[] employees, int[] projects)
    {
        int n = employees.Length;
        int m = projects.Length;

        Array.Sort(employees);
        Array.Sort(projects);

        int totalSkillLevel = 0;
        int empIndex = n - 1;

        for (int i = m - 1; i >= 0; i--)
        {
            if (empIndex >= 0 && employees[empIndex] >= projects[i])
            {
                totalSkillLevel += employees[empIndex];
                empIndex--;
            }
        }

        return totalSkillLevel;
    }

    static void Main()
    {
        int[] employees = { 5, 8, 4, 7, 6 };
        int[] projects = { 6, 9, 5 };

        int result = OptimizeResourceAllocation(employees, projects);
        Console.WriteLine(result); // Output: 20

        int[] employees2 = { 3, 2, 6, 5 };
        int[] projects2 = { 7, 5 };

        int result2 = OptimizeResourceAllocation(employees2, projects2);
        Console.WriteLine(result2); // Output: 14
    }
}
