using UnityEngine;

public class CamaraController : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offsetPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.position + offsetPos;
    }
}
