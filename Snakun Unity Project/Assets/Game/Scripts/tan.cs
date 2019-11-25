using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tan : MonoBehaviour
{
    public Vector3 Distance;
    public Vector3 MovementFrequency;
    Vector3 Moveposition;
    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        Moveposition.x = startPosition.x + Mathf.Tan(Time.timeSinceLevelLoad * MovementFrequency.x) * Distance.x;
        Moveposition.y = startPosition.y + Mathf.Tan(Time.timeSinceLevelLoad * MovementFrequency.y) * Distance.y;
        Moveposition.z = startPosition.z + Mathf.Tan(Time.timeSinceLevelLoad * MovementFrequency.z) * Distance.z;
        transform.position = new Vector3(Moveposition.x, Moveposition.y, Moveposition.z);
    }
}
