using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] OptimalTeamFormation(int numPlayers, int[] playerSkills)
    {
        int[] sortedIndices = playerSkills
            .Select((skill, index) => new { Skill = skill, Index = index })
            .OrderBy(x => x.Skill)
            .Select(x => x.Index)
            .ToArray();

        int maxDiversity = 0;
        int[] optimalTeam = new int[0];

        for (int i = 0; i < sortedIndices.Length - 1; i++)
        {
            int[] team = new int[] { sortedIndices[i] };
            int diversity = 0;

            for (int j = i + 1; j < sortedIndices.Length; j++)
            {
                int currentSkill = playerSkills[sortedIndices[j]];
                team = team.Append(sortedIndices[j]).ToArray();
                diversity = currentSkill - playerSkills[team.Min()] + playerSkills[team.Max()];

                if (diversity >= maxDiversity)
                {
                    maxDiversity = diversity;
                    optimalTeam = team;
                }
                else
                {
                    break; // No need to continue as diversity will decrease from here
                }
            }
        }

        return optimalTeam;
    }
}
