package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int total = 0;
        int count = 0;
        //System.out.println("Enter a number");
        Scanner scanner = new Scanner(System.in);

        //int number = scanner.nextInt();
        //scanner.nextLine();

        while (true) {
            int order = count + 1;
            System.out.println("Enter number # " + order + ":");
            boolean isAnInt = scanner.hasNextInt();

            if (isAnInt) {
                int number = scanner.nextInt();
                count++;
                total += number;
                if (count == 10) {
                    break;
                }
            } else {
                System.out.println("Invalid Number");
            }

            scanner.nextLine();
        }

        System.out.println("Sum is: " + total);
        scanner.close();


    }
}
