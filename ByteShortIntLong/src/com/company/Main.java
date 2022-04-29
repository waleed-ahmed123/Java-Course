package com.company;

public class Main {

        public static void main(String[] args) {

            byte myByteNum = (byte) (10);
            int myIntNum = 50;
            short myShortNum = (short) (20);

            long myTotal = (long) (50000L + (10L * (myByteNum + myIntNum + myShortNum)));

            System.out.println(myTotal);
        }
}
