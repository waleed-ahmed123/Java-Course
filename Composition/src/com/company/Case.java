package com.company;

import java.awt.*;

public class Case {
    private String model; // A case HAS-A model, manufacturer, powerSupply and Dimensions
    private String manufacturer;
    private String powerSupply;
    private Dimensions dimensions; // we are creating another object that is a part of case

    public Case(String model, String manufacturer, String powerSupply, Dimensions dimensions) {
        this.model = model;
        this.manufacturer = manufacturer;
        this.powerSupply = powerSupply;
        this.dimensions = dimensions;
    }

    public void pressPowerButton(){
        System.out.println("power button pressed");
    }

    public String getModel() {
        return model;
    }

    public String getManufacturer() {
        return manufacturer;
    }

    public String getPowerSupply() {
        return powerSupply;
    }

    public Dimensions getDimensions() {
        return dimensions;
    }
}
