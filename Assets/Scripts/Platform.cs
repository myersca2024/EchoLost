using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Color color;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        //sr = gameObject.GetComponent<SpriteRenderer>();
        //color = sr.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision) {
        //sr.material.color = color;
    }
}
