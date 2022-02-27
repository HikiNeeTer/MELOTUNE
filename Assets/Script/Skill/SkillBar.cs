using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillBar : MonoBehaviour
{
    Image Skill;
    private float maxSkill = 100f;
    public static float AmountSkill;
    private bool doOnce;

    public GameObject skillParticle;
    private GameObject currentParticle;

    // Start is called before the first frame update
    void Start()
    {
        Skill = GetComponent<Image>();
        AmountSkill = 0;
        doOnce = true;
    }

    // Update is called once per frame
    void Update()
    {
        Skill.fillAmount = AmountSkill / maxSkill;
        if (Skill.fillAmount == 1.0f && doOnce)
        {
            currentParticle = Instantiate(skillParticle, RectTransformUtility.WorldToScreenPoint(Camera.main, transform.position), Quaternion.identity);
            doOnce = false;
        }
        else if(Skill.fillAmount < 1.0f)
        {
            if (currentParticle != null)
            {
                Destroy(currentParticle);
            }
            doOnce = true;
        }
    }
}
