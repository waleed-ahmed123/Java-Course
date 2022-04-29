package com.company;

public class Main {

    public static void main(String[] args) {
        // write your code here
        int counter = 0;
        while (counter != 6) {
            System.out.println("count value was " + counter);
            counter++;
        }


        counter = 0;
        while (true) {
            if (counter == 6) {
                break;
            }
            System.out.println("count value was " + counter);
            counter++;
        }


        counter = 0;
        do {
            System.out.println("count value was " + counter);
            counter++;
        } while (counter != 6);

        int num = 4;
        int finish = 20;
        int total = 0;
        while (num <= finish) {
            num++;
            if (!isEvenNumber(num)) {
                continue;
            }
            if (total == 5) {
                System.out.println(total);
                break;
            }
            System.out.println("Even number " + num);
            total++;
        }

    }

    public static boolean isEvenNumber(int num) {
        if (num % 2 == 0) {
            return true;
        } else {
            return false;
        }
    }
}
