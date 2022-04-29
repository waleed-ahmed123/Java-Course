package com.company;

public class Main {

    public static void main(String[] args) {
        Wall wall1 = new Wall("north");
        Wall wall2 = new Wall("east");
        Wall wall3 = new Wall("south");

        Ceiling ceiling = new Ceiling(12, 55);

        Bed bed = new Bed("modern", 4, 3, 2, 1);

        Lamp lamp = new Lamp("classic", false, 75);

        BedRoom bedRoom = new BedRoom("tims", wall1, wall2, wall3, ceiling, bed, lamp);
        bedRoom.makeBed();
        bedRoom.getLamp().turnOn();
    }
}
