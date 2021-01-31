using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{

    public string current;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (string.Equals(current, "Level2"))
            {
                SceneManager.LoadScene("Level1");
            }
            else if (string.Equals(current, "Level1"))
            {
                SceneManager.LoadScene("Level3");
            }
            else if (string.Equals(current, "Level3"))
            {
                SceneManager.LoadScene("Game Over");
            }
        }
    }


}
