using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DirectMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Keyboard kb = Keyboard.current;

        // bool rightPressed = kb.rightArrowKey.isPressed;
        // bool leftPressed = kb.leftArrowKey.isPressed;

        // float direction = 0;

        // if (kb.rightArrowKey.isPressed) {
        //     direction += -1;
        // }

        // if (kb.leftArrowKey.isPressed) {
        //     direction += 1;
        // }

        // transform.Translate(direction * transform.right * speed * Time.deltaTime);
        
        //workflow Direct
        // if(rightPressed) {transform.Translate(transform.right * speed * Time.deltaTime);} //up, right, forward //(-transform.up)} 
        // if (leftPressed) {transform.Translate(-transform.right * speed * Time.deltaTime);}
        // //pas else if car sinon c'est seulement si la première condition est fausse alors il va verifiér le else if. La résultante sera que la première condition prédominera la seconde, donc ici la droite prédominera sur la gauche même si les deux touches sont appuyées en même temps. Tandis qu'avec deux if, si les deux sont appuyées, elles s'annulent et l'objet s'arrête de bouger.
    
    }
}
