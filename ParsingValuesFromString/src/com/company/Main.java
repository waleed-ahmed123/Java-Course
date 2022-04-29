package com.company;

public class Main {

    public static void main(String[] args) {
	// write your code here
        String numberAsString = "2018";
        System.out.println("numberAsString = " + numberAsString);

        int number = Integer.parseInt(numberAsString);  // you can use double too
        System.out.println("number = " + number);

        numberAsString +=1;
        number += 1;

        System.out.println("numberAsString = " + numberAsString);
        System.out.println("number = " + number);

    }
}
