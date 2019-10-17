using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbController : MonoBehaviour
{
    public GameObject PlayerController;


    void OnTriggerEnter(Collider sphereCollider)
    {
        if (this.GetComponent<SphereCollider>().isTrigger)
        {
            // GameObject.Find("Cube").GetComponent<TankController>().enabled = false;
            print("Triggerred");
        }

    }

    void OnTriggerStay()
    {


    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
