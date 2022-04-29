package com.company;

public class Main {

    public static void main(String[] args) {
        // write your code here
        int newScore = calculateScore("tim", 500);
        System.out.println("new score is " + newScore);
        calculateScore(75);
        calculateScore();
    }

    public static int calculateScore(String playerName, int score) {
        System.out.println("Player " + playerName + " Scored " + score + " points");
        return score * 1000;
    }

    public static int calculateScore(int score) {
        System.out.println("unnamed player Scored " + score + " points");
        return score * 1000;
    }

    public static int calculateScore() {
        System.out.println("no player name, ni player score");
        return 0;
    }
}
