// See https://aka.ms/new-console-template for more information

public abstract class Shape{
public abstract double calculateSurface();

}

public class Rectangle : Shape{
    
    
    private double lenght;
    private double width;

 public Rectangle(double width, double lenght){
        this.width = width;
        this.lenght = lenght;
    }
    public override double calculateSurface(){
        return lenght * width;
    }
}

public class Triangle : Shape{
    
    
    private double width;
    private double height;

    public Triangle(double width, double height){
        this.width = width;
        this.height = height;
    }
    public override double calculateSurface(){
        return height * width * 0.5;
    }
}


public class Circle : Shape{
    
    
    private double radius;
    

    public Circle(double radius){
        this.radius = radius;
    }
    public override double calculateSurface(){
        return 22/7 * radius * radius;
    }
}

public class program{
    public static void Main(){
        Shape [] arrayOfShapes = {new Circle(5), new Rectangle(3,4), new Triangle(5,10)};
        double [] areas = {arrayOfShapes[0].calculateSurface(), arrayOfShapes[1].calculateSurface(), arrayOfShapes[2].calculateSurface()};
        Console.Write("Area of circle with raduis 5 = "+ areas[0] + "\nArea of rectangle with width 3 and lenght 4 = " + areas[1] + "\narea of triangle with width 5 and height 10 = " + areas[2]);

    }
}