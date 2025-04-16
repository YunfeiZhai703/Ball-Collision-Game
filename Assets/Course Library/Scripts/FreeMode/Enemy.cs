using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enermyRb;
    private GameObject playerGo;
    private float gameBound = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enermyRb = GetComponent<Rigidbody>();
        playerGo = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        enermyRb.AddForce((playerGo.transform.position - transform.position).normalized * speed);
        if (transform.position.y < gameBound){
            Destroy(gameObject);
        }
    }
}
