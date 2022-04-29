package com.company;

public class Main {

    public static void main(String[] args) {
        for (int i = 2; i < 9; i++) {
            System.out.println("10,000 at interest rate " + i + "% interest = " + String.format("%.2f", calculateInterest(10000, i)));
        }

        System.out.println("**********");

        for (int i = 8; i > 1; i--) {
            System.out.println("10,000 at interest rate " + i + "% interest = " + String.format("%.2f", calculateInterest(10000, i)));
        }

        System.out.println("**********");

        int counter = 0;
        for (int i = 2; i < 22; i++) {

            if (isPrime(i) == true) {
                counter++;
                System.out.println("number " + i + " is a prime number");
                if (counter == 3) {
                    System.out.println("exiting for loop");
                    break;
                }
            }


        }
    }


    public static boolean isPrime(int n) {
        if (n == 0) {
            return false;
        } else {
            for (int i = 2; i <= n / 2; i++) {
                if (n % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }

    public static double calculateInterest(double amount, double interestRate) {
        return (amount * (interestRate / 100));
    }
}
