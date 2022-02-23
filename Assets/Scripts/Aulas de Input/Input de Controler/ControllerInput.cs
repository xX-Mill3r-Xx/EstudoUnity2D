using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(H * speed * Time.deltaTime, V * speed * Time.deltaTime, 0));

        if (Input.GetButton("Fire1"))
        {
            Debug.Log("Fire");
        }
    }
}
