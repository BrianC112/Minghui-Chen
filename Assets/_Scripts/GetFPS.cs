using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetFPS : MonoBehaviour
{
    public TMP_Text fpsText;
    private int count;
    private float deltaTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count++;
        deltaTime += Time.deltaTime;

        if (deltaTime >= 0.5f)
        {
            var fps = count / deltaTime;
            count = 0;
            deltaTime = 0;
            fpsText.text = $"FPS: {Mathf.Ceil(fps)}";
        }
    }
}
