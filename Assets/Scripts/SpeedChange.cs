using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChange : MonoBehaviour
{
    // create a program that
    // increments the speed when you hit the s key
    // a key decrement the speed.
    // When speed is > 20 Print out Slow down
    // When speed is 0 print out You need to speed up
    // You can't go below 0

    public int speed = 0;

    /// <summary>
    ///  Update is called once per frame.
    /// </summary>
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
            speed += 1;
        if (Input.GetKey(KeyCode.A))
            speed -= 1;
        if (speed < 0)
            speed = 0;
        else if (speed == 0)
            Debug.Log("Speed Up");
        else if (speed > 20)
            Debug.Log("Slow Down");
    }
}
