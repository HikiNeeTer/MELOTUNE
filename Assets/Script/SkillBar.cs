using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillBar : MonoBehaviour
{
    Image Skill;
    private float maxSkill = 100f;
    public static float AmountSkill;
    // Start is called before the first frame update
    void Start()
    {
        Skill = GetComponent<Image>();
        AmountSkill = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Skill.fillAmount = AmountSkill / maxSkill;
    }
}
