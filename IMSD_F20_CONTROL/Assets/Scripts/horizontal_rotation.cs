using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontal_rotation : MonoBehaviour
{
    public Transform myTransform;
    public float speed;
    public double height;
    public double width;
    private float x;
    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
        myTransform.position = new Vector3(x,y,z);
        
        speed = 2;
        height = 3;
        width = 3; 
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.RotateAround(Vector3.zero, Vector3.up,120*Time.deltaTime*speed);
    }
}
