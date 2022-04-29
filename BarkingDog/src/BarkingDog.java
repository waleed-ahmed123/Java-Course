public class BarkingDog {
    public static boolean shouldWakeUp(boolean barking, int hourOfDay) {
        if (barking==true && hourOfDay >= 0 && hourOfDay < 8 || barking==true && hourOfDay > 22 && hourOfDay < 24) {
            return true;
        } else {
            return false;
        }
    }
}
