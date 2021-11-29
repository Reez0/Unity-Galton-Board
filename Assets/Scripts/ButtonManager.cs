using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = restartButton;
        btn.onClick.AddListener(restart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void restart() {
        SceneManager.LoadScene("SampleScene");
    }


}
