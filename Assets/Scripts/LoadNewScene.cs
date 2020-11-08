using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public void LoadTerrain()
    {
        SceneManager.LoadScene("Terrain");
    }

    public void LoadInterior()
    {
        SceneManager.LoadScene("Interior");
    }

    public void LoadTexture()
    {
        SceneManager.LoadScene("Texture");
    }

    public void LoadPrototype()
    {
        SceneManager.LoadScene("Prototype 2");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
