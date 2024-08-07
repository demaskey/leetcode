using System.Text;

namespace leetcode.s0273;

public class Solution {
    public string NumberToWords(int num) {
        StringBuilder numberToWords = new StringBuilder();

        if(num ==0) {
            numberToWords.Append("Zero");
        } else if(num > 0 & num < 20) {
            numberToWords.Append(OneToNineteen(num));
        } else {
            // need to break down the number into smaller components
            // is the number in the billions?
            if(num >= 1000000000) {
                int numOfBillions = num / 1000000000;
                numberToWords.Append(NumberToWords(numOfBillions));
                numberToWords.Append(" Billion");

                int numRemaining = num - (numOfBillions * 1000000000);

                if(numRemaining > 0) {
                    numberToWords.Append(" " + NumberToWords(numRemaining));
                }

            } else if(num >= 1000000) {
                // is the number in the millions?
                int numOfMillions = num / 1000000;
                numberToWords.Append(NumberToWords(numOfMillions));
                numberToWords.Append(" Million");

                int numRemaining = num - (numOfMillions * 1000000);

                if(numRemaining > 0) {
                    numberToWords.Append(" " + NumberToWords(numRemaining));
                }

            } else if(num >= 1000) {
                // is the number in the thousands?
                int numOfThousands = num / 1000;
                numberToWords.Append(NumberToWords(numOfThousands));
                numberToWords.Append(" Thousand");

                int numRemaining = num - (numOfThousands * 1000);

                if(numRemaining > 0) {
                    numberToWords.Append(" " + NumberToWords(numRemaining));
                }

            } else if(num >= 100) {
                // is the number in the hundreds?
                int numOfHundreds = num / 100;
                numberToWords.Append(NumberToWords(numOfHundreds));
                numberToWords.Append(" Hundred");

                int numRemaining = num - (numOfHundreds * 100);

                if(numRemaining > 0) {
                    numberToWords.Append(" " + NumberToWords(numRemaining));
                }
            } else {
                // between 20 and 99
                int numOfTens = num / 10;
                numberToWords.Append(TwentyToNinetyByTen(numOfTens * 10));

                int numRemaining = num - (numOfTens * 10);

                if(numRemaining > 0) {
                    numberToWords.Append(" " + NumberToWords(numRemaining));
                }
            }
        }

        return numberToWords.ToString();;
    }

    private string OneToNineteen(int num) {
        switch(num) {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            case 10:
                return "Ten";
            case 11:
                return "Eleven";
            case 12:
                return "Twelve";
            case 13:
                return "Thirteen";
            case 14:
                return "Fourteen";
            case 15:
                return "Fifteen";
            case 16:
                return "Sixteen";
            case 17:
                return "Seventeen";
            case 18:
                return "Eighteen";
            case 19:
                return "Nineteen";
            default:
                return string.Empty;
        }


    }

    private string TwentyToNinetyByTen(int num) {
        switch (num) {
            case 20:
                return "Twenty";
            case 30:
                return "Thirty";
            case 40:
                return "Forty";
            case 50:
                return "Fifty";
            case 60:
                return "Sixty";
            case 70:
                return "Seventy";
            case 80:
                return "Eighty";
            case 90:
                return "Ninety";
            default:
                return string.Empty;
        }
    }
}