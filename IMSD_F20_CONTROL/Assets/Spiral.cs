using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{
   public Transform myTransform;
    public float speed;
    private float height;
    private float width;
    private float timer;
    public float max;
    public float min;
    private float x;
    private float y;
    private float z;
    private bool increasing;
    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
        
        timer = 0;
        speed = 5;
        height = 3;
        width = 3;
        max = 20;
        min = -20;
        increasing = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime*speed;
        float horiRotation = (Mathf.Cos(timer)*width)+x;
        float vertRotation = (Mathf.Sin(timer)*height)+y;
        myTransform.position = new Vector3(horiRotation,vertRotation,z);
        if(increasing == true)
        {
            z += 0.02f;
            if(z >= max)
            {
                increasing = false;
            }
        }
        if(increasing == false)
        {
            z -= 0.02f;
            if(z <= min)
            {
                increasing = true;
            }
        }
    }
}
