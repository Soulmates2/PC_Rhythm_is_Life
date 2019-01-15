using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line3_good : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Score_Manager.score += 10 * Combo_Manager.fever;
            Combo_Manager.combo++;
            if (HP_Manager.HP < 100) HP_Manager.HP++;
            Destroy(other.gameObject);
            Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
            Judgement.text = "<color=#1F6ED4>" + "Perfect" + "</color>";
            Invoke("Judgement", 1);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Score_Manager.score += 10 * Combo_Manager.fever;
            Combo_Manager.combo++;
            if (HP_Manager.HP < 100) HP_Manager.HP++;
            Destroy(other.gameObject);
            Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
            Judgement.text = "<color=#1F6ED4>" + "Perfect" + "</color>";
            Invoke("Judgement", 1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Score_Manager.score += 10 * Combo_Manager.fever;
            Combo_Manager.combo++;
            if (HP_Manager.HP < 100) HP_Manager.HP++;
            Destroy(other.gameObject);
            Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
            Judgement.text = "<color=#1F6ED4>" + "Perfect" + "</color>";
            Invoke("Judgement", 1);
        }
    }
    public void Judgement()
    {
        Text Judgement = GameObject.Find("Judgement").GetComponent<Text>();
        Judgement.text = "";
    }
}
