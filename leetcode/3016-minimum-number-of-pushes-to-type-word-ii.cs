namespace leetcode.s3016;

public class WordChar 
{
    public int Occurrances {get; set;}
    public int Presses {get; set;}

    public WordChar(int occurrances = 0, int pressess = 0)
    {
        Occurrances = occurrances;
        Presses = pressess;
    }
}

public class Solution {
    public int MinimumPushes(string word) {
        Dictionary<char, WordChar> uniqueCharsAndCounts = new Dictionary<char, WordChar>();
        // find all unique characters and count the number for each
        foreach(char c in word){
            if(uniqueCharsAndCounts.ContainsKey(c)) {
                uniqueCharsAndCounts[c].Occurrances++;
            } else {
                uniqueCharsAndCounts.Add(c, new WordChar(1,0));
            }
        }

        // order the list by the largest occurrances first
        var orderedUniqueCharsAndCounts = uniqueCharsAndCounts.OrderByDescending(x => x.Value.Occurrances).ToList();

        // map the number of presses to each unique character to the eight possible buttons
        int characterCount = 0;
        int pressButtonTimes = 1;
        foreach(KeyValuePair<char, WordChar> c in orderedUniqueCharsAndCounts) {
            characterCount++;
            c.Value.Presses = pressButtonTimes;

            if(characterCount == 8) {
                pressButtonTimes++;
                characterCount = 0;
            }
        }

        // count the button presses
        int minimumPushes = 0;
        foreach(KeyValuePair<char, WordChar> c in orderedUniqueCharsAndCounts) {
            minimumPushes += c.Value.Occurrances * c.Value.Presses;
        }

        return minimumPushes;
    }
}