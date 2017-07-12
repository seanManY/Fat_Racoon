using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour {

    Scene scene;
    GameObject camera;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        camera = GameObject.Find("MainCamera");
    }
	
	void OnTriggerEnter2D(Collider2D other)
    {
      
        if(other.gameObject.tag == "Player")
        {
            Destroy(camera);
            SceneManager.LoadScene(scene.name);
        }

        Destroy(other.gameObject);

    }
}
