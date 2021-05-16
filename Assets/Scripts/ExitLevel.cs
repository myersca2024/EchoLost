using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{

    public string nextLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // play a sound
            Invoke("LoadLevel", 1);
        }
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }


}
