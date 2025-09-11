using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;
    private void CreateBall(Color c)
    {
        GameObject ball = Instantiate(prefab);
        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", c);
        }
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            CreateBall();
            elapsedTime = 0f;
        }
    }
}
