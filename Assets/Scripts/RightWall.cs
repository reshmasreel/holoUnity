using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public int count;
// public TextMeshProUGUI countText;
// public GameObject winTextObject;
public class RightWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // count = 0;

        // SetCountText();

        // winTextObject.SetActive(false);
    }

    // void SetCountText(){
    //     countText.text = "Count : " + count.ToString();
    //     if(count = 0){
    //         winTextObject.SetActive(true);
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Cube")){
            other.gameObject.SetActive(false);
            // count++;
            // SetCountText();
        }

        // if(other.gameObject.CompareTag("Ball")){
        //     other.gameObject.SetActive(false);
        // }

        // if(other.gameObject.CompareTag("Capsule")){
        //     other.gameObject.SetActive(false);
        // }
    }
}
