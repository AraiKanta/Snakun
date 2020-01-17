using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    /// <summary>スコア表示用 Text</summary>
    [SerializeField] Text m_scoreText;
    /// <summary>得点</summary>
    public static double m_score;
    /// <summary>コンボ表示用 Text</summary>
    [SerializeField] Text m_comboText;
    ///<summary>コンボ</summary>
    public static int m_combo;
    /// <summary>タイマー</summary>
    float m_timer;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(double score, int combo)
    {
        if (m_combo == 5 || m_combo == 10 || m_combo == 20 || m_combo == 30)
        {
            score *= 1.5;
        }
        
        m_score += score;
        Debug.Log(score);
        m_combo += combo;
        Debug.Log(combo);
        m_scoreText.text = "スコア:" + m_score.ToString("");
        m_comboText.text = "コンボ:" + m_combo.ToString("");
    }

    public static double GetS()
    {
        return m_score;
    }

    public static int GetC()
    {
        return m_combo;
    }
}
