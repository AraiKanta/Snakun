using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TakeScore : MonoBehaviour
{

    //　ScoreUIプレハブ
    [SerializeField]
    private GameObject ScoreUI;

    private Transform parentTrans = null;

    private void Start()
    {
        parentTrans = GameObject.Find("ScoreRoot").transform;
    }

    public void Score(Collider2D collision)
    {
        //　ScoreUIをインスタンス化。登場位置は接触したコライダの中心からカメラの方向に少し寄せた位置
        var obj = Instantiate<GameObject>(ScoreUI, Vector3.zero, Quaternion.identity);
        obj.transform.SetParent(parentTrans);
        obj.transform.localPosition = Vector3.zero;
    }
}