using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CountDownController : MonoBehaviour
{
    [SerializeField] float m_timelimit = 10f;
    [SerializeField] float m_startWarning = 5f;
    float m_timer;
    Text m_text;
    [SerializeField] Color m_warningColor = Color.red;
    Animator m_anim;

    void Start()
    {
        m_timer = m_timelimit;
        m_text = GetComponent<Text>();
        m_anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (m_timer < m_startWarning)
        {
            m_text.color = m_warningColor;

            if (m_anim)
            {
                m_anim.Play("Warning");
            }
        }

        if (m_timer < 0)
        {
            m_timer = 0;
        }
        else
        {
            m_timer -= Time.deltaTime;
        }

        m_text.text = Mathf.CeilToInt(m_timer).ToString();
    }
}
