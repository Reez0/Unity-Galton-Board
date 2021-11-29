using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BallTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public PhysicMaterial superBounceMaterial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collidedWith) {
        if (collidedWith.gameObject.tag == "Ball") {
            var tempMat = new PhysicMaterial();
            tempMat.bounciness = 0;
            collidedWith.material = tempMat;
            collidedWith.gameObject.GetComponent<Rigidbody>().mass = 200f;
            var x = this.gameObject.GetComponentInChildren<UnityEngine.UI.Text>();
              var originalText = x.text;
              var convertedText = Convert.ToUInt32(originalText);
              convertedText++;
              x.text = convertedText.ToString();
        }
    }
}
