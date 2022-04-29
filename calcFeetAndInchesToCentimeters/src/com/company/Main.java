package com.company;

public class Main {

    public static void main(String[] args) {
        // write your code here
        calcFeetAndInchesToCentimeters(6, 0);
        calcFeetAndInchesToCentimeters(100);
    }

    public static double calcFeetAndInchesToCentimeters(double feet, double inches) {
        if ((feet < 0) || ((inches < 0) && (inches > 12))) {
            return -1;
        } else {
            double inchToCentimeter = inches * 2.54;
            double feetToCentimeters = (feet * 12) * 2.54;
            double total = inchToCentimeter + feetToCentimeters;
            System.out.println(feet + " feet and " + inches + " inches = " + total + " centimeters");
            return total;
        }
    }

    public static double calcFeetAndInchesToCentimeters(double inches) {
        if (inches < 0) {
            return -1;
        } else {
            double feet = (int) inches / 12;
            double remainingInches = (int) inches % 12;
            System.out.println(inches + " inches = " + feet + " feet and " + remainingInches + " inches");
            return calcFeetAndInchesToCentimeters(feet, remainingInches);
            //this is used to to calculate how many cm there are in the feet and inches provided.
            //calling the first method using the parameters calculated in this method.
        }

    }
}
