package com.company;

public class BedRoom {
    private String name;
    private Wall wall1;
    private Wall wall2;
    private Wall wall3;

    private Ceiling ceiling;
    private Bed bed;
    private Lamp lamp;

    public BedRoom(String name, Wall wall1, Wall wall2, Wall wall3, Ceiling ceiling, Bed bed, Lamp lamp) {
        this.name = name;
        this.wall1 = wall1;
        this.wall2 = wall2;
        this.wall3 = wall3;
        this.ceiling = ceiling;
        this.bed = bed;
        this.lamp = lamp;
    }

    public Lamp getLamp(){
        return this.lamp;
    }

    public void makeBed(){
        System.out.println("Bedroom --> making bed");
        bed.make();
    }
}
