using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject image;
    public float startTime = 60;
    public Text textBox;
    void Start()
    {
        textBox.text = startTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        startTime = startTime - Time.deltaTime;
        textBox.text = Mathf.Round(startTime).ToString();
        if(startTime < 0.00){
            // startTime = startTime - Time.deltaTime;
            // textBox.text = Mathf.Round(startTime).ToString();
            textBox.text = "Game Over!";
            image.SetActive(true);
        }
    }
}
