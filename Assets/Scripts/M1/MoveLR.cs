using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = startPos + new Vector3(x, 0, 0);
    }
}
