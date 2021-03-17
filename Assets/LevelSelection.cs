using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelSelection : MonoBehaviour
{
    public const int NumLevels = 3;
    public int selectedLevel;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        RandomChangeLevel();
    }

    /// <summary>
    ///  Update is called once per frame.
    /// </summary>
    void Update()
    {
        switch (selectedLevel)
        {
            case 0:
                Debug.Log("You selected Easy!");
                break;
            case 1:
                Debug.Log("You selected Medium!");
                break;
            case 2:
                Debug.Log("You selected Hard!");
                break;
            default:
                Debug.Log("Invalid Selection");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomChangeLevel();
        }

        if (Input.GetKeyDown(KeyCode.Q))
            selectedLevel = 55;
    }

    private void RandomChangeLevel()
    {
        selectedLevel = Random.Range(0, NumLevels);
    }
}
