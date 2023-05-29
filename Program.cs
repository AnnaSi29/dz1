import java.util.ArrayList;
import java.util.List;

public class MyClass {

    public static void main(String args[]) {
      
        Laptop laptop1 = new Laptop();      // создание объекта ноутбук
        laptop1.setName("Lenovo");
        laptop1.setColor("red");
        laptop1.setMemory("16GB");
              
        Laptop laptop2 = new Laptop();      // создание объекта ноутбук
        laptop2.setName("Asus");
        laptop2.setColor("grey");
        laptop2.setMemory("4GB");
        
        Laptop laptop3 = new Laptop();      // создание объекта ноутбук
        laptop3.setName("Asus");
        laptop3.setColor("blue");
        laptop3.setMemory("8GB");
        
        Laptop laptop4 = new Laptop();      // создание объекта ноутбук
        laptop4.setName("HP");
        laptop4.setColor("grey");
        laptop4.setMemory("8GB");

        
        List<Laptop> laptops= new ArrayList<>(); // создание множества ноутбуков
        
        // заполнение множества ноутбуков объектами
        laptops.add(laptop1);
        laptops.add(laptop2);
        laptops.add(laptop3);
        laptops.add(laptop4);


        // вывод ноутбуков серого цвета
        for(Laptop laptop : laptops) {
            if(laptop.getColor() == "grey"){
                System.out.println("laptop grey = " + laptop.name + " " + laptop.color + " " + laptop.memory);
            }
        }
      
        // вывод ноутбуков с оперативной памятью 8GB    
        // for(Laptop laptop : laptops) {
        //     if(laptop.getMemory() == "8GB"){
        //         System.out.println("laptop 8GB = " + laptop.name + " " + laptop.color + " " + laptop.memory);
        //     }
        // }
    }
}
class Laptop{
     
    String name;        // название ноутбука
    String color;       // цвет ноутбука
    String memory;      // оперативная память ноутбука
       
    
    //методы
    //получение названия ноутбука
    String getName(){
        return color;
    }
    //установка названия ноутбука
    String setName(String name){
        this.name = name;
        return name;
    } 
    //получение цвета ноутбука
    String getColor(){
        return color;
    }
    //установка цвета ноутбука
    String setColor(String color){
        this.color = color;
        return color;
    }
    //получение оперативной памяти ноутбука
    String getMemory(){
        return memory;
    }
    //установка оперативной памяти ноутбука
    String setMemory(String memory){
        this.memory = memory;
        return memory;
    }
}