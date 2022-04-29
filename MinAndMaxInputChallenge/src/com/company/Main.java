package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        int min = 0;
        int max = 0;
        boolean first = true;

        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("Enter Number: ");
            boolean isAnInt = scanner.hasNextInt();

            if (isAnInt) {
                int number = scanner.nextInt();

                if (first){
                    first= false;
                    min = number;
                    max = number;
                }

                if (number > max) {
                    max = number;
                } else if (number < min) {
                    min = number;
                }


            } else {
                //System.out.println("Invalid number: ");
                break;
            }
        }
        scanner.nextLine();

        System.out.println("min number is: " + min);
        System.out.println("max number is: " + max);
        scanner.close();
    }
}

