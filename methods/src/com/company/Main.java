package com.company;

public class Main {

    public static void main(String[] args) {

        int highScore=calculateScore(true, 800, 5, 100);
        System.out.println("your final score was " + highScore);


        highScore=calculateScore(true, 10000, 8, 200);
        System.out.println("your final score was " + highScore);
    }


    public static int calculateScore(boolean gameOver, int score, int levelCompleted, int bonus) {
        if (gameOver) {
            int finalScore = score + (levelCompleted * bonus); // here we have created a local variable finalScore. this cannot be accessed outside the code block.
            finalScore += 1000;
            return finalScore;
        }
        return-1;
    }
}
