using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 5f;
    void Start()
    {

        float SpeedX = Random.Range(0, 2) == 0 ? -1 : 1; //-1 é para a esquerda e 1 é para a direita
        float SpeedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(Speed * SpeedX, Speed * SpeedY, 0f);
    }    
    
}
