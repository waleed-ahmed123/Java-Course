package com.company;

public class Main {

    public static void main(String[] args) {
        int result = 1 + 2; // 1+2=3
        System.out.println(result);

        result = 4 - 1; // 4-1=3
        System.out.println(result);

        result = 4 * 5;//4 x 5 =20
        System.out.println(result);

        result = 20 / 4; // 20 / 4 = 5
        System.out.println(result);

        result = 4 % 3; //remainder of 4 MOD 3 = 1
        System.out.println(result);

        result++; // result = 1+1=2
        System.out.println(result);

        result--; //result = 2-1= 1
        System.out.println(result);

        result += 1; // 1+1=2
        System.out.println(result);

        result -= 1; // 2-1=1
        System.out.println(result);

        result *= 10; // result *10
        System.out.println(result);

        result /= 10; //result /10
        System.out.println(result);

        result = 10;
        result %= 7;
        System.out.println(result);

        boolean isAliens = false;
        if (isAliens == false) {
            System.out.println("it is not an alien");
            System.out.println("and i don't like them ");
        }

        int topScore = 80;
        if (topScore < 100) {
            System.out.println("you got the high score");
        }

        int secondScore = 60;
        if ((topScore > secondScore) && (topScore < 100)) {
            System.out.println("greater than second top score and less than 100");
        }

        if((topScore>90) || (secondScore<=90)){
            System.out.println("either or both conditions are true");
        }

        int newValue = 50;
        if(newValue == 50){
            System.out.println("this is true");
        }

        boolean isCar = false;
        if(isCar == true){
            System.out.println("this is not supposed to happen");
        }
        isCar = true;
        boolean wasCar = isCar ? true : false;
        if(wasCar){
            System.out.println("wasCar is true");
        }


        int ageOfClient = 20;
        boolean isEighteenOrOver = (ageOfClient == 20) ? true : false;
        System.out.println(isEighteenOrOver);


        }


    }