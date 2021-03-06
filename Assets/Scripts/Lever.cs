﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public bool collision;
    public AudioClip leverSFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collision && Input.GetKeyDown(KeyCode.E)) {
            if (door1 != null)
            {
                AudioSource.PlayClipAtPoint(leverSFX, transform.position);
                door1.SetActive(!door1.activeSelf);
            }
            if (door2 != null)
            {
                AudioSource.PlayClipAtPoint(leverSFX, transform.position);
                door2.SetActive(!door2.activeSelf);
            }
            if (door3 != null)
            {
                AudioSource.PlayClipAtPoint(leverSFX, transform.position);
                door3.SetActive(!door3.activeSelf);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            collision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player") {
            collision = false;
        }
    }
}
