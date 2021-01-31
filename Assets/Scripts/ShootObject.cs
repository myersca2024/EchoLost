using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootObject : MonoBehaviour {
    public GameObject bullet;
    public GameObject bulletSource;
    public float bulletForce = 20f;
    public float cooldown;
    private float t;
    private bool onCoolDown = false;

    private void Start() {
        t = 0;
    }

    void FixedUpdate() {
        if (onCoolDown) {
            t += Time.deltaTime;
            if (t > cooldown) {
                t = 0;
                onCoolDown = false;
            }
        }

        if (Input.GetButtonDown("Fire1") && !onCoolDown) {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var mouseDir = mousePos - gameObject.transform.position;
            mouseDir.z = 0.0f;
            mouseDir = mouseDir.normalized;

            GameObject instantBullet = Instantiate(bullet, bulletSource.transform.position, this.transform.rotation);
            Rigidbody2D rb = instantBullet.GetComponent<Rigidbody2D>();
            rb.AddForce(mouseDir * bulletForce, ForceMode2D.Impulse);

            onCoolDown = true;
        }
    }
}