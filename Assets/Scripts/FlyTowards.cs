using UnityEngine;
using System.Collections;


/// <summary>
/// Makes this object move towards player and return to original position when out of radius
/// </summary>
public class FlyTowards : MonoBehaviour
{

    public float speed;
    public float radius;
    public LayerMask playerMask;
    public Vector3 player;
    public Vector3 original;
    public GameObject[] tags;
    public bool fly = false;
    //float distance;
    //float curDistance;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player").transform.position;
        original = transform.position;
        if (player == null)
            player = transform.position;
        //distance = Vector3.Distance(player.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player").transform.position;
        if (Physics2D.OverlapCircle(transform.position, radius, playerMask))
            gameObject.transform.position = Vector3.MoveTowards(transform.position, player, Time.deltaTime * speed);
        else
        {   
            gameObject.transform.position = Vector3.MoveTowards(transform.position, original, Time.deltaTime * speed);
        }
           
    }
}
