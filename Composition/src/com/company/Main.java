package com.company;

public class Main {

    public static void main(String[] args) {
        Dimensions dimensions = new Dimensions(20,20,5);
        Case theCase = new Case("2200", "dell", "200", dimensions);

        // we can use the new keyword inside the brackets as a shortcut. This way we dont need to create another instance variable
        Monitor theMonitor = new Monitor("27 inch beast", "Acer", 27, new Resolution(2500, 1400));

        MotherBoard theMotherBoard = new MotherBoard("BJ-200", "Asus", 4, 6, "v2.46");

        PC thePC= new PC(theCase, theMonitor, theMotherBoard);
        thePC.powerUp();

    }
}
