namespace leetcode.s2037;

/*
There are n seats and n students in a room. You are given an array seats of length n, where seats[i] is the position of the ith seat. You are also given the array students of length n, where students[j] is the position of the jth student.

You may perform the following move any number of times:

Increase or decrease the position of the ith student by 1 (i.e., moving the ith student from position x to x + 1 or x - 1)
Return the minimum number of moves required to move each student to a seat such that no two students are in the same seat.

Note that there may be multiple seats or students in the same position at the beginning.

 

Example 1:

Input: seats = [3,1,5], students = [2,7,4]
Output: 4
Explanation: The students are moved as follows:
- The first student is moved from from position 2 to position 1 using 1 move.
- The second student is moved from from position 7 to position 5 using 2 moves.
- The third student is moved from from position 4 to position 3 using 1 move.
In total, 1 + 2 + 1 = 4 moves were used.
Example 2:

Input: seats = [4,1,5,9], students = [1,3,2,6]
Output: 7
Explanation: The students are moved as follows:
- The first student is not moved.
- The second student is moved from from position 3 to position 4 using 1 move.
- The third student is moved from from position 2 to position 5 using 3 moves.
- The fourth student is moved from from position 6 to position 9 using 3 moves.
In total, 0 + 1 + 3 + 3 = 7 moves were used.
Example 3:

Input: seats = [2,2,6,6], students = [1,3,2,6]
Output: 4
Explanation: Note that there are two seats at position 2 and two seats at position 6.
The students are moved as follows:
- The first student is moved from from position 1 to position 2 using 1 move.
- The second student is moved from from position 3 to position 6 using 3 moves.
- The third student is not moved.
- The fourth student is not moved.
In total, 1 + 3 + 0 + 0 = 4 moves were used.
*/

public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        var availableSeats = new List<int>(seats);
        var studentsToSeat = new List<int>(students);

        availableSeats.Sort();
        studentsToSeat.Sort();

        int moves = 0;

        for(int i = 0; i < availableSeats.Count; i++) {
            moves += Math.Abs(availableSeats[i] - studentsToSeat[i]);
        }

        return moves;
    }

    /*Second Iteration */
    /*public int MinMovesToSeat(int[] seats, int[] students) {
        int moves = -1;

        var availableSeats = new List<int>(seats);
        var studentsToSeat = new List<int>(students);

        var studentsLeftToSeat = new List<int>();

        // remove seats and students that do not requrie any moves
        foreach(int student in studentsToSeat) {
            if(availableSeats.Exists(x => x == student)) {
                // get the index of the seat and remove it
                int seatToRemove = availableSeats.FindIndex(x => x == student);
                availableSeats.RemoveAt(seatToRemove);
                // student will be removed from the list by ommission
            }
            else {
                // add the student to studentsLeftToSeat
                studentsLeftToSeat.Add(student);
            }
        }

        studentsToSeat = studentsLeftToSeat;
        
        if(studentsToSeat.Count == 0 && availableSeats.Count == 0) {
            moves = 0;
        } else if(studentsToSeat.Count == 1 && availableSeats.Count == 1) {
            moves = Math.Abs(studentsToSeat[0] - availableSeats[0]);
        } else if(studentsToSeat.Count == 2 && availableSeats.Count == 2) {
            int tempMoves1 = Math.Abs(studentsToSeat[0]-availableSeats[0]) + Math.Abs(studentsToSeat[1]-availableSeats[1]);
            int tempMoves2 = Math.Abs(studentsToSeat[0]-availableSeats[1]) + Math.Abs(studentsToSeat[1]-availableSeats[0]);

            if(moves == -1) {
                moves = 0;
            }

            if (tempMoves1 < tempMoves2) {
                moves += tempMoves1;
            } else {
                moves += tempMoves2;
            }
        } else {
            int firstStudent = studentsToSeat[0];
            studentsToSeat.RemoveAt(0);
            for (int i = 0; i < availableSeats.Count; i++) {
                var tempSeat = availableSeats[i];
                var tempSeats = new List<int>(availableSeats.ToArray());
                tempSeats.RemoveAt(i);

                int tempMoves = MinMovesToSeat(tempSeats.ToArray(), studentsToSeat.ToArray());

                tempMoves += Math.Abs(firstStudent - tempSeat);

                if (moves == -1 || tempMoves < moves) {
                    moves = tempMoves;
                }
            }
        }

        return moves;
    }*/

    /*First Iteration*/
    /* public int MinMovesToSeat(int[] seats, int[] students) {
        int moves = 0;

        var availableSeats = new List<int>(seats);

        for(int j = 0; j < students.Length; j++) {
            var findSeat = true;
            var deltaMoves = 0;
            while(findSeat) {
                if(deltaMoves == 0 && availableSeats.Exists(x => x == students[j])) {
                    // stop looking for a seat
                    findSeat = false;
                    // moves is zero
                    // find the index of the seat
                    int seatToRemove = availableSeats.FindIndex(x => x == students[j]);
                    // remove seat from the list
                    availableSeats.RemoveAt(seatToRemove);
                    // move on to the next student

                } else if(availableSeats.Exists(x => x + deltaMoves == students[j])) {
                    // stop looking for a seat
                    findSeat = false;
                    // moves is deltaMoves, add deltaMoves to moves
                    moves += deltaMoves;
                    // find the index of the seat
                    int seatToRemove = availableSeats.FindIndex(x => x + deltaMoves == students[j]);
                    // remove the seat from the list
                    availableSeats.RemoveAt(seatToRemove);
                    // move on to the next student
                } else if(availableSeats.Exists(x => x - deltaMoves == students[j])) {
                    // stop looking for a seat
                    findSeat = false;
                    // moves is deltaMoves, add deltaMoves to moves
                    moves += deltaMoves;
                    // find the index of the seat
                    int seatToRemove = availableSeats.FindIndex(x => x - deltaMoves == students[j]);
                    // remove the seat from the list
                    availableSeats.RemoveAt(seatToRemove);
                    // move on to the next student
                } else {
                    // keep looking for a seat

                    // increase deltaMoves by 1
                    deltaMoves++;
                }
            }
        }

         return moves;
     } */
}