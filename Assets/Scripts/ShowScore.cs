using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = Score.instance.scoreValue;
    }

    // Update is called once per frame
    void Update()
    {
        score = Score.instance.scoreValue;
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
