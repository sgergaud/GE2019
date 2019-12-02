using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhalesSpawn : MonoBehaviour
{
    public Rigidbody randomWhale;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody clone;
            clone = Instantiate(randomWhale, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.down * 10);
        }
    }

    


}
