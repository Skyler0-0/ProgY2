using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float RotationSpeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
    }
}
