using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // count = 0;

        // SetCountText();

        // winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void SetCountText(){
    //     countText.text = "Count : " + count.ToString();
    //     if(count = 0){
    //         winTextObject.SetActive(true);
    //     }
    // }

    private void OnCollisionEnter(Collision other) {
        // if(other.gameObject.CompareTag("Cube")){
        //     other.gameObject.SetActive(false);
        // }

        // if(other.gameObject.CompareTag("Ball")){
        //     other.gameObject.SetActive(false);
        // }

        if(other.gameObject.CompareTag("Capsule")){
            other.gameObject.SetActive(false);
            // count++;
            // SetCountText();
        }
    }
}
