using UnityEngine;
using System.Collections;

public class PcHddFiles : MonoBehaviour {

    [SerializeField]
    private GameObject m_hddFiles;
    [SerializeField]
    private GameObject m_hdd;
	// Use this for initialization
	void Start () {

        m_hddFiles.SetActive(false);
        m_hdd.SetActive(true);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowFiles()
    {
        if (m_hddFiles.activeSelf)
        {
            m_hddFiles.SetActive(false);
            m_hdd.SetActive(true);
        }
        else
        {
            m_hddFiles.SetActive(true);
            m_hdd.SetActive(false);
        }
    }
}
