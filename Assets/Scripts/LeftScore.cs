using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftScore : MonoBehaviour
{
    public int p1Score;
    public Text Score;


    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        Score.text = p1Score.ToString("0");
    }


    private void OnCollisionEnter(Collision col)
    {
        p1Score++;
    }
}
