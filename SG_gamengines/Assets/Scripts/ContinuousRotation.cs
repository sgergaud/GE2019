using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousRotation : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(xSpin, ySpin, zSpin);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
                    
}
