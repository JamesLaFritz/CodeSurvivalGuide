using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    // Create a program where you assign a cube in the inspector and when you hit the space key, you passs the object into a function called ChangeColor.
    // The function should take both the GameObject and a color to change to and the operation should be handled with in the function

    [SerializeField] private GameObject cube;
    [SerializeField] private Color color;

    /// <summary>
    ///  Update is called once per frame.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ChangeColor(cube, color);
    }

    public void ChangeColor(GameObject obj, Color colorToChangeTo)
    {
        obj.GetComponent<MeshRenderer>().material.color = colorToChangeTo;
    }
}
