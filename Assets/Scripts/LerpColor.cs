using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpColor : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Echo")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
