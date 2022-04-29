package com.company;

public class Main {

    public static void main(String[] args) {
        // write your code here
        boolean gameOver = true;
        int score = 5000;
        int levelCompleted = 5;
        int bonus = 100;

        if (score <= 5000 && score > 1000) {
            System.out.println("your score was less than 5000 but greater than 1000");
        } else if (score <= 1000) {
            System.out.println("your score was less than 1000");
        } else {
            System.out.println("got here");
        }


        if (gameOver == true) {
            int finalScore = score + (levelCompleted * bonus); // here we have created a local variable finalScore. this cannot be accessed outside the code block.
            System.out.println("your final score was " + finalScore);
        }

        if (gameOver == true) {
            int score2 = 10000;
            int levelCompleted2 = 8;
            int bonus2 = 200;
            int finalScore = score2 + (levelCompleted2 * bonus2); // here we have created a local variable finalScore. this cannot be accessed outside the code block.
            System.out.println("your second score was " + finalScore);
        }
    }
}
