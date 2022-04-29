package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        // write your code here

        Scanner scanner = new Scanner(System.in); // Scanner is one of javas built in classes and allows us to read user input
        //new keyword lets us create an instance of Scanner meaning were creating a new object of type Scanner
        System.out.println("Enter your year of birth:");
        boolean hasNextInt = scanner.hasNextInt();
        if (hasNextInt) {
            int yearOfBirth = scanner.nextInt(); // nextInt converts the user input into an integer and stores it in the variable
            scanner.nextLine();// handle next line character

            System.out.println("Enter your name: ");
            String name = scanner.nextLine(); // this line retrieves the input from the user and stores it in a variable called name
            int age = 2020 - yearOfBirth;

            if (age >= 0 && age <= 100) {
                System.out.println("your name is " + name + " and you are " + age + " years old");
            } else {
                System.out.println("Invalid Year Of Birth");
            }
        }else {
            System.out.println("Unable to parse year of birth");
        }

        scanner.close();
    }
}
