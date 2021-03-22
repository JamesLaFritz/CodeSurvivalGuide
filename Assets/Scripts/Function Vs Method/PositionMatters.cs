using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMatters : MonoBehaviour
{
    // Create an array of 5 different positions.
    // Use a custom method to generate a random index
    // Use a custom method to set the position to that sub index;

    public const int NumberPositions = 5;
    public Vector3[] positions;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        SetPosition();
    }

    public Vector3[] GenerateRandomPositions(int positionsToCreate)
    {
        Vector3[] randomPositions = new Vector3[positionsToCreate];

        for (int i = 0; i < NumberPositions; i++)
        {
            randomPositions[i] = new Vector3(Random.value, Random.value, Random.value);
        }

        return randomPositions;
    }

    private int GetRandomIndex()
    {
        return Random.Range(0, NumberPositions);
    }

    public void SetPosition()
    {
        if (positions == null || positions.Length < NumberPositions) positions = GenerateRandomPositions(NumberPositions);
        int index = GetRandomIndex();
        transform.position = positions[index];
    }

    /// <summary>
    ///  Update is called once per frame.
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SetPosition();
    }
}
