package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int[] array = new int[5];
        System.out.println(Arrays.toString(reverse(array)));

    }

    public static int [] reverse(int[] array){
        for (int i=0; i<array.length; i++){
            System.out.println("Enter number " + (i+1) + "\r");
            array[i] = scanner.nextInt();
        }

        int[] reversedArray = new int[array.length];

        for (int i=0; i<array.length; i++){
            reversedArray[i] = array[array.length-(i+1)];
        }

        System.out.println(Arrays.toString(array));;
        return reversedArray;
    }
}
