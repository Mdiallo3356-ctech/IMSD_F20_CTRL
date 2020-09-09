using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public Transform myTransform;
    public float speed;
    private float timer;
    public double max;
    public double min;
    private bool increasing;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        speed = 1;
        if(this.transform.position.z > 0)
        {
            max = 19.5;
            min = 1;
        }
        if(this.transform.position.z < 0)
        {
            max = -1;
            min = -19.5;
        }
        increasing = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(increasing == true)
        {
            myTransform.position += new Vector3(0,0,0.1f)*speed;
            if(myTransform.position.z >= max)
            {
                increasing = false;
            }
        }
        if(increasing == false){
            myTransform.position -= new Vector3(0,0,0.1f)*speed;
            if(myTransform.position.z <= min)
            {
                increasing = true;
            }
        }
        
    }
}
