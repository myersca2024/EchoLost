using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private float t;
    private Vector3 initialScale;
    private bool increasing = false;
    public float duration = .7f;

    private void Start() {
        initialScale = transform.localScale;
        t = 0;
    }

    void Update() {
        if (increasing) {
            t += Time.deltaTime / duration;
            transform.localScale = Vector3.Lerp(initialScale, initialScale * 30, t);
            if (t >= 1) {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Platform") {
            Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0;
            increasing = true;

            SpriteRenderer otherSprite = other.GetComponent<SpriteRenderer>();
            otherSprite.material.color = Color.red;
        }   
    }
    /*
    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Platoform") {
            SpriteRenderer otherSprite = other.GetComponent<SpriteRenderer>();
            otherSprite.material.color = color;
        }
    }*/
}
