using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float speed = 10;
    private float horizontalInput;
    private float verticalInput;
    public AudioClip fireSound;
    public AudioClip popSound;

    public GameObject bulletPrefab;
    private AudioSource fireAudio;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
    }

    void Aim()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);

        if (transform.position.x > 3.08f)
        {
            transform.position = new Vector3(3.08f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < 0.81f)
        {
            transform.position = new Vector3(0.81f, transform.position.y, transform.position.z);
        }
        else if (transform.position.y > 5.1f)
        {
            transform.position = new Vector3(transform.position.x, 5.1f, transform.position.z);
        }
        else if (transform.position.y < 4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            fireAudio.PlayOneShot(fireSound, 0.3f);
            Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
        }

    }
    public void PlayPop()
    {
        fireAudio.PlayOneShot(popSound, 0.2f);
    }
}
