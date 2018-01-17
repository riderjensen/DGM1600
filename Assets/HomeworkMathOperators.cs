using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkMathOperators : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        //Circle
        const double PI = 3.14159;
        double radius = 2.5;
        //Formulas
        double diameterOfCircle = 2 * radius;
        double circumferenceOfCircle = 2 * PI * radius;
        double areaOfCircle = PI * (radius * radius);
        double volumeOfSphere = (4 / 3) * PI * (radius * radius * radius);
        //Printing to console
        print("The Diameter is " + diameterOfCircle + "using the radius of " + radius);
        print("The Circumference of the circle is " + circumferenceOfCircle + "using the radius of " + radius);
        print("The Area of the circle is " + areaOfCircle + "using the radius of " + radius);
        print("The Volume of the sphere is " + volumeOfSphere + "using the radius of " + radius);

        //Rectangle
        double length = 4;
        double width = 7;
        //Formulas
        double perimeterOfRectangle = 2 * (length * width);
        double areaOfRectangle = length * width;
        //Printing to console
        print("The Perimeter of the Rectangle is " + perimeterOfRectangle + "using the length of " + length + "and the width of " + width);
        print("The area of the rectangle is " + areaOfRectangle + "using the length of " + length + "and the width of " + width);

        //Triangle
        double triangleBase = 80;
        double triangleHeight = 30;
        //Formula
        double triangleArea = (triangleHeight * triangleBase) / 2;
        //Printing to console
        print("The area of the triangle is " + triangleArea + "using the base of " + triangleBase + "and the height of " + triangleHeight);
    }
	
}
