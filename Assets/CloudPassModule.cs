using UnityEngine;
using System.Collections;

public class CloudPassModule : MonoBehaviour {

    [SerializeField]
    private GameObject m_button;
    [SerializeField]
    private GameObject m_passChangePage;
	// Use this for initialization
	void Start () {

        m_passChangePage.SetActive(false);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenPasswordChange()
    {
        m_button.SetActive(false);
        m_passChangePage.SetActive(true);
    }

    public void PassChange()
    {
        EventManager.PassChange();
        m_button.SetActive(true);
        m_passChangePage.SetActive(false);

    }
}
