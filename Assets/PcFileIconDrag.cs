using UnityEngine;
using System.Collections;

public class PcFileIconDrag : MonoBehaviour {

    private Vector3 m_lastMousePos;
    private RectTransform m_recBinRT;
    private RectTransform m_fileRT;
    private PCScreenObject m_obj;
	// Use this for initialization
	void Start ()
    {
        m_obj = GetComponent<PCScreenObject>();
        m_recBinRT = GameObject.FindGameObjectWithTag("RecycleBin").GetComponent<RectTransform>();
        m_fileRT = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void BeginDrag()
    {
        m_lastMousePos = Input.mousePosition;
        m_obj.CanBeOpened = false;
    }

    public void Drag()
    {
        Vector3 cPosOffset = Input.mousePosition - m_lastMousePos;
        gameObject.transform.position += cPosOffset;
        m_lastMousePos = Input.mousePosition;
    }

    public void EndDrag()
    {
        //How to derp 1-0-1  AABS BITCH! <3
        Vector3 recBinMin = m_recBinRT.position - new Vector3(m_recBinRT.rect.size.x, m_recBinRT.rect.size.y, 0);
        Vector3 recBinMax = m_recBinRT.position + new Vector3(m_recBinRT.rect.size.x, m_recBinRT.rect.size.y, 0);
        Vector3 fileMin = transform.position - new Vector3(m_fileRT.rect.size.x, m_fileRT.rect.size.y, 0);
        Vector3 fileMax = transform.position + new Vector3(m_fileRT.rect.size.x, m_fileRT.rect.size.y, 0);

        if ((recBinMin.x <=fileMax.x && recBinMax.x >=fileMin.x) && (recBinMin.y <= fileMax.y && recBinMax.y >= fileMin.y))
        {
            EventManager.DeletedPasswords();
            Destroy(gameObject);
        }
        m_obj.CanBeOpened = true;
    }
}
