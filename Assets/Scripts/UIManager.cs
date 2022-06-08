using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private GameObject sphere;

    [SerializeField]
    private GameObject capsule;

    [SerializeField] 
    private Toggle myobject1  , myobject2 , myobject3; 
 
    [SerializeField] 
    private GameObject myobject11, myobject22, myobject33;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callCube()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(-3,8);
        y = Random.Range(-2.8f, 3.78f);
        z = 0;
        pos = new Vector3(x, y, z);
        Instantiate(cube, pos, Quaternion.identity);
        myobject11.SetActive(true);
    }
    public void callSphere()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(-3, 8);
        y = Random.Range(-2.8f, 3.78f);
        z = 0;
        pos = new Vector3(x, y, z);
        Instantiate(sphere, pos, Quaternion.identity);
        myobject22.SetActive(true);
    }
    public void callCapsule()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(-3, 8);
        y = Random.Range(-2.8f, 3.78f);
        z = 0;
        pos = new Vector3(x, y, z);
        Instantiate(capsule, pos, Quaternion.identity);
        myobject33.SetActive(true);
    }
}
