namespace leetcode.s1482;

public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        int minDays = -1;

        // are there enough blooms to make the bouquets? if not, return -1
        if(m * k > bloomDay.Length) return -1;

        // to find the minimum number of day I have to use a binary search style algorithm. Start in the middle.
        var listBloomDay = new List<int>(bloomDay);
        listBloomDay.Sort();
        var distinctBloomDay = listBloomDay.Distinct().ToList();
        
        int startIndex = 0;
        int endIndex = distinctBloomDay.Count() - 1;
        int indexToCheck = ((endIndex - startIndex) / 2) + startIndex;

        while (true) {
            if(startIndex > endIndex) { 
                break;
            } else { 
                indexToCheck = ((endIndex - startIndex) / 2) + startIndex; 
            }

            int numberBloomDay = distinctBloomDay[indexToCheck];
            // another break out scenario... don't chek bloom days larger than minDays
            if(minDays != -1 && numberBloomDay > minDays) { 
                break; 
            }
            // have enough flowers bloomed to make the bouquets?
            if(listBloomDay.Count(x => numberBloomDay >= x) >= m * k) {
                // count the number of bouquets I can make
                int countBouquets = 0;
                for(int i = 0; i < bloomDay.Length; i++) {
                    bool bloomed = numberBloomDay >= bloomDay[i];
                    if(bloomed) {
                        // are there enough flowers to make a bouquet?
                        if(i + k <= bloomDay.Length) {
                            // the current flower bloomed, check adjacent flowers
                            int countBloomedFlowers = 0;
                            for(int j = 0; j < k; j++) {
                                if(numberBloomDay >= bloomDay[i + j]) {
                                    countBloomedFlowers++;
                                }
                                else {
                                    // one of the adjacent flowers has not bloomed. break of out loop
                                    break;
                                }
                            }

                            if(countBloomedFlowers == k) {
                                // made one bouquet
                                countBouquets++;
                                // skip over the flowers that made the bouquet
                                i = i + k - 1;
                            } else {
                                // skip to the flower that is not bloomed
                                i += countBloomedFlowers;
                            }
                        } else {
                            break;
                        }
                    } 
                }
                if (countBouquets >= m) { 
                    minDays = numberBloomDay;
                    // can I go to a lower number of bloom days?
                    endIndex = indexToCheck - 1;
                } else {
                    startIndex = indexToCheck + 1;
                }
            } else {
                // not enough bloomed flowers
                startIndex = indexToCheck + 1;
            }
        }

        return minDays;
    }
}