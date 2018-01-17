using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public vs private
//public means other classes can access
//private means that it means it CANT be accessed through other scripts

public class moveObject : MonoBehaviour {
    public float horizontalSpeed = .2f;
    public float verticalSpeed = .2f;
    public float zSpeed = .2f;

	// Use this for initialization
	void Start () {
		
	}
	/* This is an example of a multi line comment used in C#
     * It is important to note the indentation of how the classes are arranged.
     * It is like opening boxes. A small box is inside the larger box. But boxes of the same size can be in the 
     * same sized box. So if you have a class using the same methods then you should keep them in the same indentation,
     * But when you need to define a new class, you should move out your indentaion so that it can be on the same level
     * and scope of other classes. For example, all of my If statements dealing with the Update class are under the update
     * area because I need to program to check for those constantly. Anything I only needed done once would be put under
     * the start area instead so the program would only check for it once. It is more pleasing visually and easier to
     * understand when information is organized this way. 
     *  */
	// This is a single line comment
    //They can also be used to stop code from being read and disable it until you decide to enable it again
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-horizontalSpeed, 0, 0);
        }
        //this is an example of a dot operator. Transform is an option underneath gameObject. Translate is an option
        //underneath transform and as you continue further into the statement this trend continues (except that in this
        //example those three are all parts of translate. In a larger statement this could go on for some time)
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(horizontalSpeed, 0, 0);
        }
        //the semicolon above tells the program that I have finished my statement for my specified task.
        //In this case, it lets the computer know that only my object shuld move one specific way when the D key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0, verticalSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, -verticalSpeed, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Translate(0, 0, -zSpeed);
        }
        if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Translate(0, 0, zSpeed);
        }
        
	}
}
