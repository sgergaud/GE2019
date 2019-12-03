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
        Timer -= Time.deltaTime;
    
        if (Timer <= 0f)
        {
            GameObject WhaleClone;
            WhaleClone = Instantiate(Whale, transform.position,
                 Quaternion.Euler(Random.Range(0f, 360f),Random.Range(0f, 360f), Random.Range(0f,360f))) as GameObject;
            
            

            Timer = 3f;
        }
    }

    


}
