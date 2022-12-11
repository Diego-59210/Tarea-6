using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{
    public GameObject AttackPoint;

    private CharacterAnimation animationScript;

    private AudioSource audioSource;

    [SerializeField]
    private AudioClip attackSound, deathSound;


    private EnemyMovement enemyMovementScript;

    void Awake()
    {
        animationScript = GetComponent<CharacterAnimation>();
        audioSource = GetComponent<AudioSource>();
        if (gameObject.CompareTag("Enemy"))
        {
            enemyMovementScript = GetComponentInParent<EnemyMovement>();
        }
    }

    void AttackON()
    {
        AttackPoint.SetActive(true);
    }
    void AttackOFF()
    {
        if (AttackPoint.activeInHierarchy)
        {
            AttackPoint.SetActive(false);
        }
    }
    public void AttackFXSound()
    {
        audioSource.volume = 0.2f;
        audioSource.clip = attackSound;
        audioSource.Play();
    }
    void CharacterDied()
    {
        audioSource.volume = 1f;
        audioSource.clip = deathSound;
        audioSource.Play();
    }
    void DisableMovement()
    {
        enemyMovementScript.enabled = false;
        transform.parent.gameObject.layer = 0;
    }
    void EnableMovement()
    {
        enemyMovementScript.enabled = true;
        transform.parent.gameObject.layer = 7;
    }
    void CharacterDeath()
    {
        Invoke("DeactivateGameObject", 1f);
    }
    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }
}
