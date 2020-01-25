using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    // Start is called before the first frame update
    private Text ScoreText;
    //　フェードアウトするスピード
    private float fadeOutSpeed = 3f;
    //　移動値
    [SerializeField]
    private float moveSpeed = 0.4f;

    void Start()
    {
        ScoreText = GetComponentInChildren<Text>();
    }
    void LateUpdate()
    {
        transform.rotation = Camera.main.transform.rotation;
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        ScoreText.color = Color.Lerp(ScoreText.color, new Color(1f, 0f, 0f, 0f), fadeOutSpeed * Time.deltaTime);

        if (ScoreText.color.a <= 0.1f)
        {
            Destroy(gameObject);
        }
    }

}
