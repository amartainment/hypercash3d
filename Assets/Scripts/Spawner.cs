using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Waterdrop;

    private int Number = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (Number < 5)
        {
            Instantiate(Waterdrop, transform.position, Quaternion.identity);
            Number++;
            //Debug.Log(Number);
            //Debug.Log(transform.position);
            yield return new WaitForSeconds(0.5f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
         
        
    }
}
