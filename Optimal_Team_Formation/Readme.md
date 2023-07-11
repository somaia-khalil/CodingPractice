Coding Challenge: Optimal Team Formation

You are given a list of players, each having a skill level. Your task is to form teams with the highest overall skill level.

You need to write a function that takes the following inputs:

Input:
- numPlayers (int): The total number of players (1 <= numPlayers <= 10^5).
- playerSkills (int[]): An array of integers representing the skill levels of each player. The length of the array will be equal to numPlayers (1 <= playerSkills[i] <= 10^9).

Output:
- optimalTeam (int[]): An array containing the indices of the players forming the team with the highest overall skill level.

The team should have the following properties:
1. The number of players in the team should be equal to or greater than 2.
2. The skill levels of the players in the team should be as diverse as possible. The diversity of the skill levels is calculated as the difference between the maximum and minimum skill levels in the team.
3. The overall skill level of the team is the sum of the skill levels of all players in the team.

If there are multiple teams with the same overall skill level, return the one with the lowest index.

Example:
Input: numPlayers = 6, playerSkills = [3, 5, 2, 8, 10, 6]
Output: [2, 3, 5]
Explanation: The team formed by players at indices 2, 3, and 5 has the highest overall skill level (2 + 8 + 6 = 16) and has the most diverse skill levels (8 - 2 = 6).

Input: numPlayers = 5, playerSkills = [1, 2, 3, 4, 5]
Output: [0, 1, 2, 3, 4]
Explanation: The team formed by all players has the highest overall skill level (1 + 2 + 3 + 4 + 5 = 15), and since there are no other teams, it is also the most diverse team.

Note:
- The output should be sorted in ascending order of player indices.
- In case of multiple teams with the same overall skill level, return the one with the lowest index.
- The optimal team may have more than two players, but you should try to maximize the diversity of skill levels while keeping the team size as small as possible.
- The input list `playerSkills` will not be empty.
- You may assume that there will always be at least one valid team formation with a minimum of two players.
- You do not need to handle tie-break scenarios when multiple teams have the same overall skill level and diversity. Return any valid team in such cases.
