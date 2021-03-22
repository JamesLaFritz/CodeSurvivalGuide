using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChallenge2 : MonoBehaviour
{
    // create a program that changes a cube different colors based on input
    // 1 key = blue
    // 2 key = red
    // 3 key = green
    // 4 key = black
    
    private enum SelectedColors
    {
        Blue = 1,
        Red = 2,
        Green = 3,
        Black = 4
    }

    [SerializeField] private SelectedColors selectedColor = SelectedColors.Blue;

    private Renderer m_renderer;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    private void Start()
    {
        m_renderer = GetComponent<Renderer>();
    }

    /// <summary>
    ///  Update is called once per frame.
    /// </summary>
    private void Update()
    {
        CheckInput();
        CheckSelectedColor();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            selectedColor = (SelectedColors) 1;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            selectedColor = (SelectedColors) 2;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            selectedColor = (SelectedColors) 3;
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            selectedColor = (SelectedColors) 4;
    }

    private void CheckSelectedColor()
    {
        switch (selectedColor)
        {
            case SelectedColors.Blue:
                ChangeMaterialColor(Color.blue);
                break;
            case SelectedColors.Red:
                ChangeMaterialColor(Color.red);
                break;
            case SelectedColors.Green:
                ChangeMaterialColor(Color.green);
                break;
            case SelectedColors.Black:
                ChangeMaterialColor(Color.black);
                break;
            default:
                Debug.Log("Invalid color selected");
                break;
        }
    }

    private void ChangeMaterialColor(Color colorToChangeTo)
    {
        m_renderer.sharedMaterial.color = colorToChangeTo;
    }
}
