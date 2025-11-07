using UnityEngine;

public class HealthStatus : MonoBehaviour
{
    private int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            health -= 10;
            Debug.Log("P for Punch!!");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            health += 10;
            Debug.Log("Yay your healing");
        }

        if (health > 80)
        {
            Debug.Log("Excellent health!");
        }
        else if (health > 50)
        {
            Debug.Log("Good health!");
        }
        else if (health > 20)
        {
            Debug.Log("Warning: Low health!");
        }
        else
        {
            Debug.Log("Critical: Very low health!");
        }
    }
}
