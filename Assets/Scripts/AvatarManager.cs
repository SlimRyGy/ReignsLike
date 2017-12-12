using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarManager : DualBehaviour 
{
    #region Public Members

    public Image m_avatarImage;
    public Text m_avatarName;
    public Text m_avatarRequest;

    #endregion

    #region Public void

    public void SetAvatarImage(Sprite _texture)
    {
        m_avatarImage.sprite = _texture;

    }

    public void SetAvatarName(string _dialogue)
    {
        m_avatarName.text = _dialogue;
    }

    public void SetDialogue(string _dialogue)
    {
        m_avatarRequest.text = _dialogue;
    }

    public void SetImageName(string imageIdName)
    {

    }

    public void SetKingName(string kingName)
    {

    }

    #endregion

    #region System

    void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion

}
