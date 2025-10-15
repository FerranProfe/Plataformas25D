using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private bool listo;
    private bool following=false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (following == true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            following = true;
        }

        if (other.gameObject.tag == "EnemyLimit" && listo==true)
        {
            transform.eulerAngles += new Vector3(0, 180, 0);
            speed *= -1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.GetContact(0).normal.y <= -0.5f)
            {
                Debug.Log("Muere el enemigo");
                collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Muere el player");
                collision.gameObject.GetComponent<MarioController>().Death();
            }
        }
    }
}
