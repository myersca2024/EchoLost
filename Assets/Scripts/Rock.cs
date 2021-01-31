using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private Vector3 initialScale;
    public GameObject echo;
    public AudioClip rockSFX;

    private void Start() {
        initialScale = transform.localScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            Instantiate(echo, this.transform.position, this.transform.rotation);
            AudioSource.PlayClipAtPoint(rockSFX, transform.position);
            Destroy(gameObject);
        }
    }
}
