using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpColor : MonoBehaviour
{
    float t;
    private bool triggered;
    public float duration = 2f;

    void Start()
    {
        t = 0f;
        triggered = false;
    }

    void Update()
    {
        if (triggered)
        {
            t += Time.deltaTime / duration;
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.white, Color.black, t);
            if (t >= 1)
            {
                triggered = false;
                t = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player") {
            triggered = true;
        }
    }
}
