package com.company;

public class Main {

    public static void main(String[] args) {
        float myMinFloatValue = Float.MIN_VALUE;
        float myMaxFloatValue = Float.MAX_VALUE;
        System.out.println("float min value =" + myMinFloatValue);
        System.out.println("float max value =" + myMaxFloatValue);

        double myMinDoubleValue = Double.MIN_VALUE;
        double myMaxDoubleValue = Double.MAX_VALUE;
        System.out.println("double min value =" + myMinDoubleValue);
        System.out.println("double max value =" + myMaxDoubleValue);

        int myInt = 100;
        float myFloat = 1.25f;
        double myDouble = 5d;

        double numberOfPounds = 200d;
        double convertedKilograms = numberOfPounds * 0.45359237d;
        System.out.println("converted KG = " + convertedKilograms);
    }
}
