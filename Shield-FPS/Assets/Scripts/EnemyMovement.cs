using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private CharacterAnimation enemyAnim;

    private Rigidbody enemyBody;
    public float speed = 5f;

    private Transform playerTarget;

    public float attackDistance = 1f;
    public float chasePlayerAfterAttack = 0.5f;

    private float currentAttackTime;
    private float defaultAttackTime = 1f;

    private bool followPlayer, attackPlayer;

    void Awake()
    {
        enemyAnim = GetComponentInChildren<CharacterAnimation>();
        enemyBody = GetComponent<Rigidbody>();

        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        followPlayer = true;
        currentAttackTime = defaultAttackTime;

    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }
    void FixedUpdate()
    {
        FollowTarget();
    }
    void FollowTarget()
    {
        if (!followPlayer)
            return;

        if (Vector3.Distance(transform.position, playerTarget.position) > attackDistance)
        {
            transform.LookAt(playerTarget);
            enemyBody.velocity = transform.forward * speed;

            if (enemyBody.velocity.sqrMagnitude != 0)
            {
                enemyAnim.EnemyWalk(true);
            }
        }
        else if (Vector3.Distance(transform.position, playerTarget.position) <= attackDistance)
        {
            enemyBody.velocity = Vector3.zero;
            enemyAnim.EnemyWalk(false);

            followPlayer = false;
            attackPlayer = true;

        }
    }
    void Attack()
    {
        if (!attackPlayer)
            return;
        currentAttackTime += Time.deltaTime;
        if (currentAttackTime > defaultAttackTime)
        {
            enemyAnim.EnemyAttack();

            currentAttackTime = 0f;
        }
        if (Vector3.Distance(transform.position, playerTarget.position) > attackDistance + chasePlayerAfterAttack)
        {
            attackPlayer = false;
            followPlayer = true;
        }
    }
}
