// See https://aka.ms/new-console-template for more information
class Solution
{
    // These are our numbers from which we will extract our words.
    private static String[] less_than_twenty = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

    private static String[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    private static String[] chunks = { "", "Thousand", "Million", "Billion", "Trillion" };

    // This function takes the numerical value and breaks it into parts with 3 digit each.
    // Then it passes it to next function coupled with it that will build the string for it.
    public static String sayNumber(long num)
    {
        if (num == 0) return "Zero.";

        string ans = new();

        int index = 0;
        while (num > 0)
        {
            if (num % 1000 != 0)
            {
                ans = convertThreeDigit(num % 1000) + chunks[index] + ", " + ans;
            }
            index++;
            num /= 1000;
        }
        // for perfecting our punctuation, we will use substring and trim methods.
        return ans.Trim().Substring(0, ans.Length() - 3) + ".";

    }

    // This function recieves the 3 digit number and builds the string.
    // Its a recursive function.
    private static String convertThreeDigit(long num)
    {
        if (num == 0) return "";
        if (num < 20) return less_than_twenty[(int)num] + " ";

        else if (num < 100) return tens[(int)num / 10] + " " + convertThreeDigit(num % 10);

        else return less_than_twenty[(int)num / 100] + " " + "Hundred" + " " + convertThreeDigit(num % 100);
    }

    // Finally our driver class to test our inputs.
    public static void main(String[] args)
    {
        long n1 = 0;
        long n2 = 11;
        long n3 = 1043283;
        System.out.println(sayNumber(n1) + "\n" + sayNumber(n2) + "\n" + sayNumber(n3));
    }
}