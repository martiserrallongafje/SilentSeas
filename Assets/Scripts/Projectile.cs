using UnityEngine;

public class Projectile : MonoBehaviour
{
    float velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        velocity = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * velocity * Vector3.right;
    }
}
