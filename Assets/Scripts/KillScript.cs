using UnityEngine;

public class KillScript : MonoBehaviour
{

    [SerializeField] public float killTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, killTime);
    }

}