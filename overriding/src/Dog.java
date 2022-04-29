public class Dog {
    public void bark(){
        System.out.println("woof");
    }
}

class germanShepherd extends Dog{
    @Override
    public void bark() {
        System.out.println("woof woof woof");
    }
}
