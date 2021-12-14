using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public float Speed = 5f;
    public bool isRight;
    public float limiteYmaximo, limiteYminimo;   

    void Update()
    {
        if (transform.position.y > limiteYmaximo)
        {
            transform.position = new Vector3(transform.position.x, limiteYmaximo, 0);
        }
        else if (transform.position.y < limiteYminimo)
        {
            transform.position = new Vector3(transform.position.x, limiteYminimo, 0);
        }

        if (isRight)
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * Speed * Time.deltaTime,0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * Speed * Time.deltaTime, 0f);
        }        

    }   

}
