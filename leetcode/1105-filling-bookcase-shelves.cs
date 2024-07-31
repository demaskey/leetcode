namespace leetcode.s1105;

public class Solution {
    public int MinHeightShelves(int[][] books, int shelfWidth) {
        int minHeight = 0;

        int shelfWidthUsed = 0;
        int shelfHeight = 0;
        for(int i = 0; i < books.Length; i++) {
            // can the shelf width fit the next book?
            if(shelfWidthUsed + books[i][0] <= shelfWidth) {
                // add the book to the shelf
                shelfWidthUsed += books[i][0];
                shelfHeight = shelfHeight > books[i][1] ? shelfHeight : books[i][1];

            } else {
                // have to add another shelf

            }
        }

        return minHeight;
    }
}