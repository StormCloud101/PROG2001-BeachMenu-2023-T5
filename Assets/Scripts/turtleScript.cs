using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtleScript : MonoBehaviour
{
    public GameObject turtle;
    public float value;
    public Vector3 sizeChange;

    //Moves the turtle left
    public void moveLeft()
    {
        value -= 0.1f;
        turtle.transform.position = new Vector3(value, 0, 0);
    }

    //Moves the turtle right
    public void moveRight()
    {
        value += 0.1f;
        turtle.transform.position = new Vector3(value, 0, 0);
    }

    //rotates the turtle left
    public void rotateLeft()
    {
        turtle.transform.Rotate(0f, 20f, 0f, Space.Self);
    }
}
