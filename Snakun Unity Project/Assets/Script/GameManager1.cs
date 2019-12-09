using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    /// <summary>スコア表示用 Text</summary>
    [SerializeField] Text m_scoreText;
    /// <summary>得点</summary>
    int m_score;
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

    public void AddScore(int score)
    {
        m_score += score;
        Debug.Log(score);
        m_scoreText.text = "スコア:"+ m_score.ToString("");
    }
}
