using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    [SerializeField] Text m_scoreText;
    int s;

    // Start is called before the first frame update
    void Start()
    {
        s = GameManager1.GetS();
        Debug.Log(s);

        m_scoreText.text = "スコア:" + s.ToString("");
    }

    // Update is called once per frame
    void Update()
    {

    }    
}
