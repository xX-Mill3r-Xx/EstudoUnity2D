using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTeclado2 : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(H * speed * Time.deltaTime,0,0));
        transform.Translate(new Vector3(0, V * speed * Time.deltaTime, 0));
    }
}
