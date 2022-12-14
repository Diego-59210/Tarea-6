using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayerAttack1()
    {
        anim.SetTrigger("Attack1");
    }
    public void PlayerAttack2()
    {
        anim.SetTrigger("Attack2");
    }
    public void PlayerAttack3()
    {
        anim.SetTrigger("Attack3");
    }
    public void ShieldBlockON()
    {
        anim.SetBool("Blocking",true);
    }
    public void ShieldBlockOFF()
    {
        anim.SetBool("Blocking", false);
    }
    public void BlockedAttack()
    {
        anim.SetTrigger("Blocked");
    }
    public void SpecialAttack()
    {
        anim.SetTrigger("Special");
    }

    public void Death()
    {
        anim.SetTrigger("Death");
    }

    //Enemy Animations

    public void EnemyWalk(bool move)
    {
        anim.SetBool("Walking", move);
    }
    public void EnemyAttack()
    {
        anim.SetTrigger("Attack");
    }
    public void EnemyHit()
    {
        anim.SetTrigger("Hit");
    }


}
