using UnityEngine;

public class BooOrbit : MonoBehaviour
{
    public Transform centerPoint;   // Het punt waar Boo omheen draait
    public float orbitSpeed = 50f;  // Hoe snel hij draait
    public float radius = 3f;       // Afstand tot het middelpunt

    void Start()
    {
        if (centerPoint == null)
        {
            // Als er geen centrum is, gebruik (0, 0, 0)
            centerPoint = new GameObject("OrbitCenter").transform;
            centerPoint.position = Vector3.zero;
        }

        // Beginpositie van Boo op de juiste afstand
        transform.position = centerPoint.position + new Vector3(radius, 0, 0);
    }

    void Update()
    {
        // Laat Boo ronddraaien om het middelpunt
        transform.RotateAround(centerPoint.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
