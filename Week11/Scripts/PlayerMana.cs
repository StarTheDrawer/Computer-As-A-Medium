using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    public PlayerMana playerMana;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;   
        Mana();
    }

    void Mana()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            playerMana.mana -= 10;
            animator.SetBool("mana", true);
        }
        else
        {
            animator.SetBool("mana",false);
        }
    }
}
