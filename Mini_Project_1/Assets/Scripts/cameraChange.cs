using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChange : MonoBehaviour
{
    public GameObject cam3rd;
    public GameObject cam1st;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camChange();
        }
    }

    public void camChange()
    {
        cam3rd.SetActive(!cam3rd.activeSelf);
        cam1st.SetActive(!cam1st.activeSelf);
    }
}
