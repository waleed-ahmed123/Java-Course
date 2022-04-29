public class Main {
    public static void main(String[] args) {
        boolean isBarking = BarkingDog.shouldWakeUp(true, -1);
        if (isBarking == true) {
            System.out.println("you should wake up");
        } else {
            System.out.println("you should not wake up");
        }
    }


}