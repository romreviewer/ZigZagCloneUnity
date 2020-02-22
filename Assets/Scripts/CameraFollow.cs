using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    Vector3 offset;
    public float lerpRate;
    public bool gameOver;
    void Start()
    {
        offset=ball.transform.position-transform.position;
        gameOver=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            follow();
        }
    }
    void follow()
    {
        Vector3 pos=transform.position;
        Vector3 tragetPos=ball.transform.position-offset;
        pos = Vector3.Lerp(pos,tragetPos,lerpRate*Time.deltaTime);
        transform.position=pos;
    }
}
