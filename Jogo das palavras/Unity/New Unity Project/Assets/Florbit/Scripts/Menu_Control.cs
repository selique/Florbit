using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadJogar (int scene) {
        SceneManager.LoadScene(scene);
    }

    public void SaiDoJogo ()
        {
        Application.Quit();
        }

    }
