using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Player : MonoBehaviour
{
    // Create a program that when you hit the space key, you increment the score value.
    // When the score value is > 50 turn the cube green
    // At the start of the program turn the cube red

    [SerializeField] private int score = 0;

    private bool hasChangedColor;

    private Renderer m_renderer;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    private void Start()
    {
        m_renderer = GetComponent<Renderer>();
        Reset();
    }

    private void Reset()
    {
        score = 0;
        hasChangedColor = false;
        ChangeMaterialColor(Color.red);
    }

    /// <summary>
    ///  Update is called once per frame.
    /// </summary>
    private void Update()
    {
        CheckInput();
        CheckScore();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            IncrementScore(10);
        if (Input.GetKeyDown(KeyCode.Return))
            Reset();
    }

    private void IncrementScore(int amount)
    {
        score += amount;
    }

    private void CheckScore()
    {
        // if score > 50 && we haven't changed the cube color then change the cube color to green
        if (score < 50 || hasChangedColor) return;

        ChangeMaterialColor(Color.green);
        hasChangedColor = true;
    }

    private void ChangeMaterialColor(Color colorToChangeTo)
    {
        m_renderer.sharedMaterial.color = colorToChangeTo;
    }
}
