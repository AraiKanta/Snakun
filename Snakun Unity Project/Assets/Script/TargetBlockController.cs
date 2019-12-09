using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ターゲットブロック（ボールが当たったら壊れるブロック）を制御する
/// ターゲットブロックの GameObject に追加して使う
/// </summary>
public class TargetBlockController : MonoBehaviour
{
    [SerializeField] int m_score = 100;

    bool m_isDead = false;
    void Start()
    {

    }

    void Update()
    {

    }


    /// <summary>
    /// Collider に衝突判定があった時に呼ばれる
    /// </summary>
    /// <param name="collision">衝突の情報</param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter OnCollisionEnter2D."); // 関数が呼び出されたら Console にログを出力する

        // 衝突相手が蜂だったら自分自身を破棄する
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// 「トリガーモードの」Collider に衝突判定があった時に呼ばれる
    /// </summary>
    /// <param name="collision">衝突の情報</param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter OnTriggerEnter2D."); // 関数が呼び出されたら Console にログを出力する


        if (m_isDead == false)
        {
            m_isDead = true;
            GameObject go = GameObject.Find("GameManager");
            if (go)
            {
                GameManager1 gm = go.GetComponent<GameManager1>();
                if (gm)
                {
                    gm.AddScore(m_score);
                }
            }
        }
        // 衝突相手が蜂だったら自分自身を破棄する
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        
    }
}
