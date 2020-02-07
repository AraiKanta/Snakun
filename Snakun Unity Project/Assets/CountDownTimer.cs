using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Text))]
public class CountDownTimer : MonoBehaviour
{
    //　トータル制限時間
    private float totalTime;
    //　制限時間（分）
    [SerializeField] private int minute;
    //　制限時間（秒）
    [SerializeField] private float seconds;
    //　前回Update時の秒数
    private float oldSeconds;
    private Text timerText;
    [SerializeField] Color m_warningColor = Color.red;
    Animator m_anim;
    [SerializeField] float m_startWarning = 5f;
    //float m_timer;


    // Start is called before the first frame update
    void Start()
    {
        totalTime = minute * 60 + seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
        m_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //　制限時間が0秒以下なら何もしない
        if (totalTime <= 0f)
        {
            return;
        }
        //　一旦トータルの制限時間を計測；
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        //　再設定
        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        if (seconds < m_startWarning)
        {
            timerText.color = m_warningColor;

            if (m_anim)
            {
                m_anim.Play("Warning");
            }
        }

        //　タイマー表示用UIテキストに時間を表示する
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
        //　制限時間以下になったらコンソールに『制限時間終了』という文字列を表示する
        if (totalTime <= 0f)
        {
            SceneManager.LoadScene("Result");
            Debug.Log("制限時間終了");
        }
    }
}
