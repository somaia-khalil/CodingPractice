## The Resource Allocation Optimization

You are managing a company with `n` employees and `m` projects. Each employee has a skill level represented by a positive integer. Each project requires a specific skill level, also represented by a positive integer. Your task is to assign employees to projects in a way that maximizes the total skill level of the assigned employees.

Your task is to implement the function `OptimizeResourceAllocation` that takes the following inputs:

- A list of integers representing the skill levels of the `n` employees.
- A list of integers representing the skill levels required for the `m` projects.

The function should return the maximum possible total skill level that can be achieved by optimally allocating employees to projects.

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] employees = { 5, 8, 4, 7, 6 };
        int[] projects = { 6, 9, 5 };

        int result = OptimizeResourceAllocation(employees, projects);
        // Output: 20
        // Explanation: The best allocation is {6, 7, 7}, which results in a total skill level of 20.

        int[] employees2 = { 3, 2, 6, 5 };
        int[] projects2 = { 7, 5 };

        int result2 = OptimizeResourceAllocation(employees2, projects2);
        // Output: 14
        // Explanation: The best allocation is {5, 6}, which results in a total skill level of 14.
    }

    public static int OptimizeResourceAllocation(int[] employees, int[] projects)
    {
        // Implement your solution here
    }
}
