//Parent Class
internal class Shape
{
    double x, y;

    public Shape()
    {
        this.x = 7;
        this.y = 5;
    }

    public virtual double calcArea()
    {
        //Result
        return x * y;
    }
}

/*Protected classes ensure that objects and methods cannot be accessed by
 anything else but its child classes*/

//Main Method