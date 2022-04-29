package com.company;

import java.util.Scanner;

public class Main {

    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        // write your code here
        int[] myIntegers = readIntegers(4);
        System.out.println("the min number is " + findMin(myIntegers));
    }


    public static int[] readIntegers(int count) {
        System.out.println("Enter " + count + " Integer Values.\r");
        int[] myArray = new int[count];
        for (int i = 0; i < count; i++) {
            myArray[i] = scanner.nextInt();
        }
        return myArray;
    }

    public static int findMin(int[] myArray) {
        int[] temp = myArray;
        int min = temp[0];
        for (int i = 0; i < myArray.length-1; i++) {
            if ( myArray[i + 1] < min) {
                min = temp[i + 1];
            }
        }
        return min;
    }
}

