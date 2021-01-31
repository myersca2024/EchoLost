using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LerpColor : MonoBehaviour
{
    float t;
    private bool triggered;
    public float duration = 2f;
    public Color echoColor = Color.white;

    void Start()
    {
        t = 0f;
        triggered = false;
    }

    void Update()
    {
        if (triggered)
        {
            Debug.Log("Triggered");
            t += Time.deltaTime / duration;
            Color lerpedColor = Color.Lerp(echoColor, Color.black, t);
            gameObject.GetComponent<SpriteRenderer>().color = lerpedColor;
            if (GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>() != null)
            {
                GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>().color = lerpedColor;
            }
            if (t >= 1)
            {
                triggered = false;
                t = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rock" || other.tag == "Echo") {
            triggered = true;
            t = 0;
        }
    }
}
