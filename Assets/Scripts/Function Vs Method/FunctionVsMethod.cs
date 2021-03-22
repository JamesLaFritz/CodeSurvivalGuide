using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FunctionVsMethod : MonoBehaviour
{
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
        
    }


    public float GetResultsAdd(float num1, float num2)
    {
        return num1 + num2;
    }

    public void DisplayAddFunction(float num1, float num2)
    {
        Debug.Log(num1 + num2);
    }

    private float m_value = 5;

    public float GetResultsAdd(float numToAdd)
    {
        return m_value + numToAdd;
    }

    public void DisplayAddFunction(float amountToAdd)
    {
        Debug.Log(m_value + amountToAdd);
    }
}
