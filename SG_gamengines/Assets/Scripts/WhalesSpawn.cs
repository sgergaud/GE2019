using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WhalesSpawn : MonoBehaviour
{
    //public Rigidbody randomWhale;
    public float Timer = 3f;
    public GameObject Whale;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //  Rigidbody clone;
        // clone = Instantiate(randomWhale, transform.position, transform.rotation);
        // clone.velocity = transform.TransformDirection(Vector3.down * 10);
        //}

        Timer -= Time.deltaTime;

        if (Timer <= 0f)
        {
            GameObject WhaleClone;
            WhaleClone = Instantiate(Whale, transform.position,
                 Quaternion.Euler(0f, 0f, Random.Range(0f, 360f))) as GameObject; ;
            WhaleClone = Whale;

            Timer = 3f;
        }
    }

    


}
