namespace leetcode.s1552;

public class Solution {
    public int MaxDistance(int[] position, int m) {
        Array.Sort(position);

        int low = 1;
        int high =  position[^1] - position[0];
        int maxDistance = 0;

        while (low <= high) {
            int mid = low + (high - low) / 2;
            if(CanPlaceBalls(position, m, mid)) {
                maxDistance = mid;
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return maxDistance;
    }

    private bool CanPlaceBalls(int[] position, int m, int minDist) {
        int count = 1;
        int lastPos = position[0];

        for(int i = 1; i < position.Length; i++) {
            if(position[i] - lastPos >= minDist) {
                count++;
                lastPos = position[i];
                if(count == m) {
                    return true;
                }
            }
        }
        return false;
    }
}

/*
This is my first iteration and it works pretty well but I kept getting 
incorrect results. Something is wrong with it and I'm not sure where I went 
wrong.
*/
public class Solution_FirstIteration {
    public int MaxDistance(int[] position, int m) {
        int maxDistance = 0;

        Array.Sort(position);

        /* when the number of balls is the minimum then it's a simple solution,
        sort the array, first ball goes in the lowest position and the second 
        ball goes in the largest position. */
        if(m == 2) {
            maxDistance = CalculateForce(position[0], position[^1]);
        } 
        /* when the number of positions is equal to the number of balls then one ball is placed in each position*/
        else if (m == position.Length) {
            maxDistance = CalculateMaxDistance(position);
        } else {
            int distanceFromFirstToLast = CalculateForce(position[0], position[^1]);
            int idealDistanceBetweenBalls = distanceFromFirstToLast / (m - 2 + 1);

            int[] ballPositions = new int[m];
            ballPositions[0] = position[0];
            ballPositions[^1] = position[^1];

            int positionIndexToPlaceBall = 1;
            for (int b = 1; b <= m - 2; b++) {
                int idealBallPosition = idealDistanceBetweenBalls * b + position[0];
                
                for(int i = positionIndexToPlaceBall; i < position.Length - 1; i++) {
                    if(position[i] <= idealBallPosition) {
                        positionIndexToPlaceBall = i;
                    }
                    else {
                        break;
                    }
                }
                ballPositions[b] = position[positionIndexToPlaceBall];
                positionIndexToPlaceBall++;
            }

            // find the smallest, biggest distance between each ball
            maxDistance = CalculateMaxDistance(ballPositions);
        }

        return maxDistance;
    }

    private int CalculateForce(int x, int y) {
        return Math.Abs(x - y);
    }

    private int CalculateMaxDistance(int[] ballPositions) {
        int maxDistance = CalculateForce(ballPositions[0], ballPositions[^1]);
        for(int b = 0; b < ballPositions.Length - 1; b++) {
            int force = CalculateForce(ballPositions[b], ballPositions[b+1]);
            if(force < maxDistance) { 
                maxDistance = force;
            }
        }

        return maxDistance;
    }
}