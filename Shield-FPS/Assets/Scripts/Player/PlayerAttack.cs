using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ComboState
{
    NONE,
    ATTACK_1,
    ATTACK_2
    //ATTACK_3
}


public class PlayerAttack : MonoBehaviour
{
    private CharacterAnimation player_Anim;

    private bool activateTimerToReset;

    public float default_Combo_Timer = 0.8f;
    private float current_Combo_Timer;
    public GameObject blockingPoint;

    private ComboState current_Combo_State;

    void Awake()
    {
        player_Anim = GetComponentInChildren<CharacterAnimation>();
        
    }
    void Start()
    {
        current_Combo_Timer = default_Combo_Timer;
        current_Combo_State = ComboState.NONE;
    }

    void Update()
    {
        ComboAttack();
        ResetComboState();
        Blocking();
    }
    void ComboAttack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (current_Combo_State == ComboState.ATTACK_2) //Change this

                return;

            current_Combo_State++;
            activateTimerToReset = true;
            current_Combo_Timer = default_Combo_Timer;
            if (current_Combo_State == ComboState.ATTACK_1)
            {
                player_Anim.PlayerAttack1();
            }
            if (current_Combo_State == ComboState.ATTACK_2)
            {
                player_Anim.PlayerAttack2();
            }
            //if (current_Combo_State == ComboState.ATTACK_3)
            //{
            //   player_Anim.PlayerAttack3();
            //}
        }
    }
    void Blocking()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            player_Anim.ShieldBlockON();
            blockingPoint.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            player_Anim.ShieldBlockOFF();
            if (blockingPoint.activeInHierarchy)
            {
                blockingPoint.SetActive(false);
            }

        }
    }
    void ResetComboState()
    {
        if (activateTimerToReset)
        {
            current_Combo_Timer -= Time.deltaTime;
            if (current_Combo_Timer <= 0f)
            {
                current_Combo_State = ComboState.NONE;
                activateTimerToReset = false;
                current_Combo_Timer = default_Combo_Timer;
            }
        }
    }

}
