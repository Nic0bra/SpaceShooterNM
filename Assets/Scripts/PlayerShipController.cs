using UnityEngine;

public class PlayerShipController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 3f;

    //Control ship move distance
    public float xMin, xMax;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        transform.Translate(xMove * moveSpeed * Time.deltaTime, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax),
            transform.position.y,
            transform.position.z);

    }
}
