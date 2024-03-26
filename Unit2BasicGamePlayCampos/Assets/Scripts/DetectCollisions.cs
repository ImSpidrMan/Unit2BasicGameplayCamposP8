using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private static int lives = 3;
    private static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
        lives--;
        Debug.Log("Lives:" + lives);
            if (lives == 0)
            {
                Destroy(other.gameObject);
                Debug.Log("Game Over!");
            }
        }

        else if (other.gameObject.name != "Player")
        {
            score++;
            Destroy(other.gameObject);
            Debug.Log("Score:" + score);
        }
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
