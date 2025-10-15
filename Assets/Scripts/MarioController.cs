using UnityEngine;

public class MarioController : MonoBehaviour
{
    [SerializeField]
    private float speed; //m/s
    [SerializeField]
    private float jumpForce;
    private bool onGround;
    private LevelManager lm;
    //Fisicas
    private Rigidbody rb;
    [SerializeField]
    private GameObject tochosRotosPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lm= GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.RightArrow) == true) // &&
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            transform.eulerAngles = new Vector3(0, 90, 0);
        }

        if (Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.LeftArrow)==true)
        {
            transform.Translate(Vector3.left *speed * Time.deltaTime, Space.World);
            transform.eulerAngles = new Vector3(0, -90, 0);
        }

        if((Input.GetKeyDown(KeyCode.W)==true || Input.GetKeyDown(KeyCode.UpArrow) == true) && onGround == true)
        {
            rb.AddForce(Vector3.up * jumpForce);
            onGround = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lm.Pause();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag=="Tocho" || collision.gameObject.tag=="Plataform")
        {
            onGround = true;
        }

        if(collision.gameObject.tag == "Tocho")
        {
            if(collision.GetContact(0).normal == Vector3.down)
            {
                GameObject tochosRotosClone = Instantiate(tochosRotosPrefab, collision.transform.position, collision.transform.rotation);
                Destroy(collision.gameObject);
                Destroy(tochosRotosClone, 5f);
            }
        }

        if(collision.gameObject.tag == "Plataform")
        {
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Plataform")
        {
            transform.parent = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            GameManager.instance.totalCoins += 1;
            Destroy(other.gameObject);
            lm.UpdateCoins();
        }

        if (other.gameObject.tag == "Death")
        {
            Death();
        }

        if(other.gameObject.tag == "Finish")
        {
            lm.FinishLevel();
        }
    }

    public void Death()
    {
        GameManager.instance.life -= 1;
        if(GameManager.instance.life < 0)
        {
            lm.GameOver();
        }
        else
        {
            transform.position = lm.spawnPoint.position;
            transform.rotation = lm.spawnPoint.rotation;
            lm.UpdateLives();
        }  
    }
}
