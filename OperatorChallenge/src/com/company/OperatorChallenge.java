package com.company;

public class OperatorChallenge {

    public static void main(String[] args) {

        double num1 = 20.00d;
        double num2 = 80.00d;
        boolean x;


        double myValuesTotal = (num1 + num2) * 100.00d;
        System.out.println("myValuesTotal = " + myValuesTotal);
        double remainder = myValuesTotal % 40.00d;
        System.out.println("theRemainder = " + remainder);


        boolean isNoRemainder = (remainder == 0) ? true : false;
        System.out.println("inNoRemainder = " + isNoRemainder);

        if (!isNoRemainder) {
            System.out.println("got some remainder");
        }
    }
}
