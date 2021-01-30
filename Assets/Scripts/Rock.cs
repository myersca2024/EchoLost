using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private float t;
    private Vector3 initialScale;
    public float duration = .7f;
    public GameObject echo;

    private void Start() {
        initialScale = transform.localScale;
        t = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            Instantiate(echo, this.transform.position, this.transform.rotation);
            Destroy(gameObject, 0.1f);
        }
    }
}
