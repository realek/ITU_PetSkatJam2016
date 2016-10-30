using UnityEngine;
using System.Collections;

public class PcTaskbar : MonoBehaviour {

    [SerializeField]
    private GameObject m_StartMenu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToggleStartMenu()
    {
        if (m_StartMenu.activeSelf)
            m_StartMenu.SetActive(false);
        else
            m_StartMenu.SetActive(true);
    }
}
