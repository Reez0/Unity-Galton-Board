using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;
    public Button restartButton;
    public float waitTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());
        
    }

    IEnumerator spawn() {
        for (int i =0;i<250;i++) {
            Instantiate(objectToSpawn,transform.position, transform.rotation);
            yield return new WaitForSecondsRealtime(this.waitTime);

        }
        restartButton.gameObject.SetActive(true);
  
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
