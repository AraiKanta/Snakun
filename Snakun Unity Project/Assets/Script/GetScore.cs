using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    [SerializeField] Text m_scoreText;
    double s;
    [SerializeField] Text m_comboText;
    int c;

    // Start is called before the first frame update
    void Start()
    {
        s = GameManager1.GetS();
        Debug.Log(s);
        c = GameManager1.GetC();
        Debug.Log(c);

        m_scoreText.text = "スコア:" + s.ToString("");
        m_comboText.text = "コンボ:" + c.ToString("");
    }

    // Update is called once per frame
    void Update()
    {

    }    
}
