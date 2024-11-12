using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandClap : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
         if (animator == null)
        {
            Debug.LogError("Aucun Animator trouvé sur cet objet.");
        }
    }

    void Update()
    {
        // Vérifiez si la touche espace est pressée
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Déclenchez l'animation d'applaudissement
            animator.SetTrigger("Applaud");
        }
    }
}
