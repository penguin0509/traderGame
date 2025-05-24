using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public float floatSpeed = 30f;
    public float fadeDuration = 1.0f;
    private Text text;
    private Color originalColor;

    void Start()
    {
        text = GetComponent<Text>();
        originalColor = text.color;
        Destroy(gameObject, fadeDuration);
    }

    void Update()
    {
        transform.Translate(Vector3.up * floatSpeed * Time.deltaTime);
        float fade = Mathf.Clamp01(1 - (Time.time - Time.timeSinceLevelLoad) / fadeDuration);
        text.color = new Color(originalColor.r, originalColor.g, originalColor.b, fade);
    }

    public void SetText(string message)
    {
        if (text == null) text = GetComponent<Text>();
        text.text = message;
    }
}
