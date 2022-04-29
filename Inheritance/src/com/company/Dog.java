package com.company;

public class Dog extends Animal {

    private int eyes;
    private int legs;
    private int tail;
    private int teeth;
    private String coat;

    //this is what the user has to specify
    public Dog(String name, int size, int weight, int eyes, int legs, int tail, int teeth, String coat)  {
        super(name, 1, 1, size, weight);
        this.eyes = eyes; // initialise the variables
        this.legs = legs;
        this.tail = tail;
        this.teeth = teeth;
        this.coat = coat;
    }

    private void chew(){
        System.out.println("Dog.chew() called");
    }

    // what override does is, it creates a version of that same method from the animal class and makes it
    //unique for the dog class
    @Override
    public void eat() {
        System.out.println("Dog.eat() called");
        chew();
        super.eat(); // this calls the eat method from the super class (Animal class)
    }

    public void walk(){
        System.out.println("Dog.walk() called ");
        move(5);
    }

    public void run(){
        System.out.println("Dog.run() called ");
        move(10);
    }

    private void moveLegs(int speed){
        System.out.println("Dog.moveLegs called ");
    }

    @Override
    public void move(int speed) {
        System.out.println("Dog.move() called");
        moveLegs(speed);
        super.move(speed);
    }
}
