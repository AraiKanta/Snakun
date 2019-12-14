using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater2 : MonoBehaviour
{
    //生成するプレハブ
    public GameObject small_flower_yellow;
    //X座標の最小値
    public float xMinPosition = -10f;
    //X座標の最大値
    public float xMaxPosition = 10f;
    //Y座標の最小値
    public float yMinPosition = 0f;
    //Y座標の最大値
    public float yMaxPosition = 10f;
    //Z座標の最小値
    public float zMinPosition = 0f;
    //Z座標の最大値
    public float zMaxPosition = 1f;
    //生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;

    void Start()
    {
        interval = 2f;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            GameObject yellow = Instantiate(small_flower_yellow);
            yellow.transform.position = GetRandomPosition();
            time = 0f;
        }
    }
    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        return new Vector3(x, y, z);

    }
}

