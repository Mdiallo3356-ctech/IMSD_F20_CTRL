 using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    public Transform myTransform;
    public float speed;
    public float height;
    public float width;
    private float timer;
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
        
        timer = 0;
        speed = 1;
        height = 3;
        width = 3;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime*speed;
        float horiRotation = (Mathf.Cos(timer)*width)+x;
        float vertRotation = (Mathf.Sin(timer)*height)+y;
        myTransform.position = new Vector3(horiRotation,vertRotation,z);
    }
}
