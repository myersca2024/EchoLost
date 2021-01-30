using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoExpand : MonoBehaviour
{
    public float duration;
    private float t = 0f;
    private Vector3 initialScale;

    void Start()
    {
        initialScale = this.transform.localScale;
    }

    void FixedUpdate() {
        t += Time.deltaTime / duration;
        transform.localScale = Vector3.Lerp(initialScale, initialScale * 30, t);
        if (t >= 1) {
            Destroy(gameObject, 0.1f);
        }
    }
}
