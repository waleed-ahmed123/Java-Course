package com.company;

public class Main {

    public static void main(String[] args) {
        // write your code here
        int switchValue = 3;

        switch (switchValue) {
            case 1:
                System.out.println("value was 1");
                break;

            case 2:
                System.out.println("value was 2");
                break;

            default:
                System.out.println("was not 1 or 2");
                break;
        }


        char switchvalue = 'd';
        switch (switchvalue) {
            case 'a':
                System.out.println("char was 'a' ");
                break;
            case 'b':
                System.out.println("char was 'b' ");
                break;
            case 'c':
            case 'd':
            case 'e':
                System.out.println("char was " + switchvalue);
                break;
            default:
                System.out.println("character not found");
                break;
        }

        String month = "jaNuARy";
        switch (month.toLowerCase()) {
            case "january":
                System.out.println("JAN");
                break;
            case "june":
                System.out.println("JUN");
                break;
            default:
                System.out.println("not sure");
                break;
        }


    }
}
