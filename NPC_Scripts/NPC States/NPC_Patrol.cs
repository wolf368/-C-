using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Patrol : MonoBehaviour
{ 
    public Vector2[] patrolPoints;
    public float speed;

    public float pauseDuration = 1.5f;

    private bool isPaused;
    private int currentPatrolIndex;
    public Vector2 target;

    private Rigidbody2D rb;
    private Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        StartCoroutine(SetPatrolPoints());
    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            rb.velocity = Vector2.zero;
            return;
        }

        Vector2 direction = ((Vector3)target - transform.position).normalized;
        if (direction.x < 0 && transform.localScale.x > 0 || direction.x > 0 && transform.localScale.x < 0)
            transform.localScale = new Vector3(transform.localScale.x*-1, transform.localScale.y, transform.localScale.z);
        
        rb.velocity = direction * speed;
        
        if (Vector2.Distance(transform.position, target) < 0.1f)
        {
            StartCoroutine(SetPatrolPoints());
        }
    }

    IEnumerator SetPatrolPoints()
    {
        isPaused = true;
        anim.Play("NPC_Idle");

        yield return new WaitForSeconds(pauseDuration);

        currentPatrolIndex =(currentPatrolIndex+1) % patrolPoints.Length;
        target = patrolPoints[currentPatrolIndex];
        isPaused = false;
        anim.Play("NPC_Walk");

    }
}
