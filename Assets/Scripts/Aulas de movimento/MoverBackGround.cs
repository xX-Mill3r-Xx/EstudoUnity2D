using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBackGround : MonoBehaviour
{
    public Renderer sky;
    public float speedSky;

    // Start is called before the first frame update
    void Start()
    {
        //sky = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offSet = new Vector2(speedSky*Time.deltaTime,0);
        sky.material.mainTextureOffset += offSet;
    }
}
