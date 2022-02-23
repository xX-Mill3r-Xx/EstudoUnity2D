using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentar : MonoBehaviour
{
    public float x = 10f;
    float y = 0.1f;
    float z = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(x * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-x * Time.deltaTime, 0, 0));
        }

        //if (Input.GetKey(KeyCode.S))
        //{
        //    z = 100f;
        //    transform.Rotate(new Vector3(0,0,z));
        //}
        
    }
}
