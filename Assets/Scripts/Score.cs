using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //reference na druge komponente
    public Transform Cube;
    public Text scoreText;

    void Update()
    {
        scoreText.text = Cube.position.z.ToString("0");
    }

}
