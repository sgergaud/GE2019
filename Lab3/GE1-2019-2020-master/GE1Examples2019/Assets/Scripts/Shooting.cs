using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public int fireRate = 3;

    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(c_Shooting());
    }

    float ellapsed = float.MaxValue;

    System.Collections.IEnumerator c_Shooting()
    {
        float toPass = 1.0f / fireRate;
        while (true ) //infiniteLoop
        {
            GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            yield return new WaitForSeconds(toPass);
        }
    }

    Coroutine cr;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && cr == null)
        {

            cr = StartCoroutine(c_Shooting());
        }
        //float toPass = 1.0f / fireRate;
        //ellapsed += Time.deltaTime;

        //if (Input.GetKey(KeyCode.Space) && ellapsed > toPass )
        //{
          //  GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
          //ellapsed = 0;
        //}
    }
}
