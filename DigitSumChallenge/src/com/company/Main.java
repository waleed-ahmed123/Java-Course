package com.company;

public class Main {

    public static void main(String[] args) {
        // write your code here
        System.out.println(sumDigit(123));
    }

    public static int sumDigit(int number) {
        if (number < 10) {
            return -1;
        } else {
            int total = 0;

            // 125 -> 125/10 = 12 -> 12*10=120 -> 125-120=5

            while (number > 0) {
                //extract the least significant digit
                int digit = number % 10;
                total += digit;

                //drop the least significant digit
                number /= 10;
            }
            return total;

        }
    }
}
