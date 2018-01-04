using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : DualBehaviour
{
    #region Public Members

    public Save m_save;

    public List<Image> m_indicators = new List<Image>();

    public Image m_avatar;
    public Text m_name;
    public Text m_question;
    public Text m_answerYes;
    public Text m_answerNo;

    public System.Random m_r;

    #endregion

    #region Public void

    #endregion

    #region System

    public void Awake()
    {
        m_r = new System.Random();



        if (m_save.currentPerso == null || m_save.currentQuestion == null)
            Reset();
        else
        {
            SetQuestion(m_save.currentPerso, m_save.currentQuestion);
            SetAmounts(m_save.fillAmounts);
        }
            
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    #endregion

    #region Class Methods

    public void AnswerYes()
    {
        Debug.Log("Answered Positively");

        ApplyEffects(m_save.currentQuestion.effects_yes);

        NextQuestion();
    }

    public void AnswerNo()
    {
        Debug.Log("Answered Negatively");

        ApplyEffects(m_save.currentQuestion.effects_no);

        NextQuestion();
    }

    public void NextQuestion()
    {
        Perso perso = m_save.persos[m_r.Next(m_save.persos.Count)];
        Questions question = perso.questions[m_r.Next(perso.questions.Count)];

        m_save.currentPerso = perso;
        m_save.currentQuestion = question;

        SetQuestion(perso, question);
    }

    public void SetQuestion(Perso perso, Questions question)
    {
        m_avatar.sprite = perso.image;
        m_name.text = perso.name;
        m_question.text = question.question;
        m_answerYes.text = question.answerYes;
        m_answerNo.text = question.answerNo;
    }

    public void ApplyEffects(List<Effect> effects)
    {
        foreach (Effect effect in effects)
            m_indicators[effect.indicator].fillAmount += effect.amount;

        SaveAmounts();
    }

    public void SetAmounts(List<float> amounts)
    {
        int i = 0;
        foreach (float amount in amounts)
            m_indicators[i++].fillAmount = amount;

        SaveAmounts();
    }

    public void SaveAmounts()
    {
        List<float> newAmounts = new List<float>();

        foreach (Image i in m_indicators)
            newAmounts.Add(i.fillAmount);

        m_save.fillAmounts = newAmounts;
    }

    public void Reset()
    {
        NextQuestion();
        SetAmounts(m_save.defaultFillAmounts);
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
