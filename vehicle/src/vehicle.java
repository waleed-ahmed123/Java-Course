public class vehicle {
    private String name;
    private String size;

    private int currentVelocity;
    private int currentDirection;

    public vehicle(String name, String size) {
        this.name = name;
        this.size = size;
    }

    public void steer(int direction){
        this.currentDirection=direction;
        System.out.println("Vehicle.steer(): steering at " + currentDirection + " degrees");
    }

    public void move(int velocity, int direction){
        this.currentVelocity = velocity;
        this.currentDirection = direction;

        System.out.println("Vehicle.move(): moving at " + currentVelocity + " in direction " + currentDirection);
    }

    public String getName() {
        return name;
    }

    public String getSize() {
        return size;
    }

    public int getCurrentVelocity() {
        return currentVelocity;
    }

    public int getCurrentDirection() {
        return currentDirection;
    }
}
