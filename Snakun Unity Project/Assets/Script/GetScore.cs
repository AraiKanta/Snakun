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
    [SerializeField] Text redFlower;
    int rf;
    [SerializeField] Text blueFlower;
    int bf;
    [SerializeField] Text yellowFlower;
    int yf;
    // Start is called before the first frame update
    void Start()
    {
        s = GameManager1.GetS();
        Debug.Log(s);
        c = GameManager1.GetC();
        Debug.Log(c);
        rf = GameManager1.GetRF();
        Debug.Log(rf);
        bf = GameManager1.GetBF();
        Debug.Log(bf);
        yf = GameManager1.GetYF();
        Debug.Log(yf);

        m_scoreText.text = "スコア:" + s.ToString("");
        m_comboText.text = "コンボ:" + c.ToString("");
        redFlower.text = "赤い花:" + rf.ToString("");
        blueFlower.text = "青い花:" + bf.ToString("");
        yellowFlower.text = "黄色い花:" + yf.ToString("");
    }

    // Update is called once per frame
    void Update()
    {

    }    
}
