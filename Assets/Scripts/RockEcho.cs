using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockEcho : MonoBehaviour
{
    public float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;

    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            GameObject echoObj = Instantiate(echo, transform.position, Quaternion.identity);
            Destroy(echoObj, 1f);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
