using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Mouse X");
        float V = Input.GetAxis("Mouse Y");
        transform.Translate(new Vector3(H * speed * Time.deltaTime, V * speed * Time.deltaTime, 0));
    }
}
