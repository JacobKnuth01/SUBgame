using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy2AI : MonoBehaviour
{

    private Animator anim;
    private Transform target;
    public Transform homePos;

    [SerializeField] private float speed;
    [SerializeField] private float maxRange;
    [SerializeField] private float minRange;

    // Start is called before the first frame update
    void Start()
    {

        target = FindObjectOfType<PlayerMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= maxRange && Vector3.Distance(target.position, transform.position) >= minRange)
        {
            FollowPlayer();
        }
        else if (Vector3.Distance(target.position, transform.position) >= maxRange)
        {
            GoHome();
        }

    }

    public void FollowPlayer()
    {

        transform.position = Vector3.MoveTowards(transform.position, new Vector3((target.transform.position.x), (target.transform.position.y), target.transform.position.z), speed * Time.deltaTime);
    }

    public void GoHome()
    {

        transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime);



    }

}

