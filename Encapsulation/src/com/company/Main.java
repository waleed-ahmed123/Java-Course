package com.company;

public class Main {

    public static void main(String[] args) {
        EnhancedPlayer player = new EnhancedPlayer("Tim", 50, "sword");
        System.out.println("initial health is " + player.getHealth());
        player.loseHealth(60);
        System.out.println("new health is " + player.getHealth());
    }
}