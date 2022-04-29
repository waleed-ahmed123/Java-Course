package com.company;

public class PC {
    // we created a class called PC.
    // it HAS-A case, monitor, motherBoard
    // if you use extend, you can only inherit from one class at a time. this way you can
    private Case theCase;
    private Monitor monitor;
    private MotherBoard motherBoard;

    public PC(Case theCase, Monitor monitor, MotherBoard motherBoard) {
        this.theCase = theCase;
        this.monitor = monitor;
        this. motherBoard = motherBoard;
    }

    public void powerUp(){
        theCase.pressPowerButton();
        drawLogo();
    }

    private void drawLogo(){
        //Fancy Graphics
        monitor.drawPixelAt(1200, 50, "yellow");
    }
}
