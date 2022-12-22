using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private CharacterAnimation enemyAnim;

    private NavMeshAgent agent;
    private Transform playerTarget;
    private Rigidbody enemyBody;
    public float attackRange;
    public float chasePlayerAfterAttack = 0.5f;
    private float currentAttackTime;
    private float defaultAttackTime = 1.5f;

    private bool followPlayer, attackPlayer;

    void Awake()
    {
        enemyAnim = GetComponentInChildren<CharacterAnimation>();
        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;
        enemyBody = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        followPlayer = true;
        currentAttackTime = defaultAttackTime;
        attackRange = agent.stoppingDistance;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }
    private void FixedUpdate()
    {
        Follow();
    }
    void Follow()
    {
        if(!followPlayer)
            return;

        float distance = Vector3.Distance(transform.position, playerTarget.transform.position);

        if (distance > attackRange)
        {
            agent.SetDestination(playerTarget.transform.position);

            if (enemyBody.velocity.sqrMagnitude != 0)
            {
                enemyAnim.EnemyWalk(true);
            }
        }
        else if(distance <= attackRange)
        {
            enemyAnim.EnemyWalk(false);

            followPlayer = false;
            attackPlayer = true;
        }
    }
    void Attack()
    {
        if (!attackPlayer)
            return;
        float distance = Vector3.Distance(transform.position, playerTarget.transform.position);
        currentAttackTime += Time.deltaTime;
        if(currentAttackTime > defaultAttackTime)
        {
            enemyAnim.EnemyAttack();
            currentAttackTime = 0f;
        }
        if(distance > attackRange + chasePlayerAfterAttack)
        {
            attackPlayer = false;
            followPlayer = true;
        }

    }

}
