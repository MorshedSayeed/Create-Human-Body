using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_body : MonoBehaviour
{
     public float mSpeed;
	// Start is called before the first frame update
    void Start()
    {
       mSpeed = 30f; 
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f , mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
	transform.Rotate(10f* Time.deltaTime, 2f , 30f * Time.deltaTime);
    }
}
