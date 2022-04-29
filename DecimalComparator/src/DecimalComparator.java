public class DecimalComparator {
    public static boolean areEqualByThreeDecimalPlaces(double number1, double number2) {
        number1 = (int) (number1 * 1000d);
        number2 = (int) (number2 * 1000);
        if (number1 == number2) {
            return true;
        } else {
            return false;
        }
    }
}
