using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        //this.nextShootTime = Random.Range(minShootDelay, maxShootDelay);
    }


    void OnTriggerEnter(Collider col)
    {
        moveDir = !moveDir;
        transform.position = new Vector3(transform.position.x, transform.position.y - .5f, transform.position.z);

    }

    bool moveDir = true;
    private Vector3 left = Vector3.left;
    private Vector3 right = Vector3.right;
    [SerializeField]
    private int moveSpeed;// = 2;
    private int timer = 300;
    public int numberOfEnemies = 32;
    public GameObject wallR;
    public GameObject wallL;
    private int numberOfEnemiesLeft;
    Vector3 dir;

    void Update()
    {
        if (moveDir)
            dir = Vector3.left;
        else
            dir = Vector3.right;

        transform.Translate(moveSpeed * Time.deltaTime * dir);
    }
}
        