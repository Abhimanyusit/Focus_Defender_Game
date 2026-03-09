using UnityEngine;

public class BulletFire : MonoBehaviour
{
    private float speed = 5.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z < 2.0f)
        {
            Destroy(gameObject);
        }
    }
}
