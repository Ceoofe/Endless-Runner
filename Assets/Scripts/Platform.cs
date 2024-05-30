using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speedForce;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move Platform to the left
        transform.Translate(Vector2.left * Time.deltaTime * speedForce);
        if(transform.position.x < -15.5f)
        {
            Destroy(gameObject);
        }
    }
}
