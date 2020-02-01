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
    /// <summary>赤の花を何個取ったか</summary>
    [SerializeField] public static int m_redFlower = 0;
    /// <summary>赤の花を何個取ったか</summary>
    [SerializeField] public static int m_blueFlower = 0;
    /// <summary>赤の花を何個取ったか</summary>
    [SerializeField] public static int m_yellowFlower = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(double score, int combo, int redflower, int blueflower, int yellowflower)
    {
        if (m_combo == 5 || m_combo == 10 || m_combo == 20 || m_combo == 30)
        {
            score *= 1.5;
        }
        
        m_score += score;
        Debug.Log(score);
        m_combo += combo;
        Debug.Log(combo);
        m_redFlower += redflower;
        Debug.Log(redflower);
        m_blueFlower += blueflower;
        Debug.Log(blueflower);
        m_yellowFlower += yellowflower;
        Debug.Log(yellowflower);
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

    public static int GetRF()
    {
        return m_redFlower;
    }

    public static int GetBF()
    {
        return m_blueFlower;
    }

    public static int GetYF()
    {
        return m_yellowFlower;
    }

    public static void Reset()
    {
        m_combo = 0;
        m_score = 0;
        m_redFlower = 0;
        m_blueFlower = 0;
        m_yellowFlower = 0;
    }
}
