using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public float billAmount = 0;
    public float tipPercentage = 20;

    private float m_tipAmount = 0;

    private float m_totalOwed = 0;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // Your bill is: and your tip amount is: so you owe total amount;
        string message = "Your bill is: " + billAmount;
        m_tipAmount = billAmount * (tipPercentage / 100);
        m_totalOwed = billAmount + m_tipAmount;
        message += " and your tip amount is: " + m_tipAmount + " so you owe " + m_totalOwed;
        Debug.Log(message);
    }
}
