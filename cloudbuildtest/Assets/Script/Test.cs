using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour {

   public   Text m_Text;
   public   Button m_Button;
    int a = 0;
	// Use this for initialization
	void Start () {
        m_Button.onClick.AddListener(new UnityEngine.Events.UnityAction(()=>
        {
            a++;
            a++;
            m_Text.text = a.ToString();
        }));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
