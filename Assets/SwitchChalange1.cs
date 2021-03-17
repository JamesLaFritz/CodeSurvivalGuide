using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChalange1 : MonoBehaviour
{
    public int points;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    ///  Update is called once per frame.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            points = 50;
        else if (Input.GetKeyDown(KeyCode.W))
            points = 100;
        else if (Input.GetKeyDown(KeyCode.E))
            points = 0;

        CheckPoints();
    }

    private void CheckPoints()
    {
        switch (points)
        {
            case 50:
            case 100:
                Debug.Log("Points are " + points + "!");
                break;
            default:
                Debug.Log("You need 50 or 100 points to get a message");
                break;
        }
    }
}
