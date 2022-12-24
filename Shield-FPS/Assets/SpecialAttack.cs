using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialAttack : MonoBehaviour
{
    public Slider specialSlider;
    private CharacterAnimation anim;

    public float maxEnergy;
    public float energy;
    public float minEnergy;

    // Start is called before the first frame update
    void Awake()
    {
        energy = 0f;
        maxEnergy = specialSlider.maxValue;
        minEnergy = specialSlider.minValue;
        anim = GetComponentInChildren<CharacterAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        specialSlider.value = energy;
        if (energy >= maxEnergy)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                anim.SpecialAttack();
                energy = 0f;
            }
            
        }
        
    }
    public void AbsorbPower(float amount)
    {
        energy += amount;

    }
}
