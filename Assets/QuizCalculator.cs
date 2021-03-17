using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float[] quizGrades = new float[] {0, 0, 0, 0, 0};

    public float sum = 0;

    public float average = 0;


    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        CalculateAverage();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            CalculateAverage();
    }

    private void CalculateAverage()
    {
        quizGrades = new float[] {0, 0, 0, 0, 0};
        sum = average = 0;

        // 5 quiz grades that calculate randomly then average those grades.
        for (int i = 0; i < quizGrades.Length; i++)
        {
            quizGrades[i] = Random.Range(0f, 101f);
            sum += quizGrades[i];
        }

        average = sum / quizGrades.Length;
        average = Mathf.Round(average * 100f) / 100f;

        DisplayAverage();
    }

    private void DisplayAverage()
    {
        string message = "Your average: " + average;

        // if average >= 90 print A
        // print B = >= 80 but less than 90
        // print C = > 70 < 80
        // print F < 70
        if (average >= 90)
            message += "\n You got an A";
        else if (average >= 80)
            message += "\n You got a B";
        else if (average >= 70)
            message += "\n You got a C";
        else
            message += "\n You got a F";

        Debug.Log(message);
    }
}
