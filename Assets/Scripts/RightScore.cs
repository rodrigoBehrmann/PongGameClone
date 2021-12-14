using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightScore : MonoBehaviour
{
    public int p2Score;
    public Text Score;
    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        Score.text = p2Score.ToString("0");
    }

    private void OnCollisionEnter(Collision col)
    {
        p2Score++;
    }
}
