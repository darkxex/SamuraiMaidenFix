using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MaidenFix
{
    public class Uncensor : MonoBehaviour
    {
       
        private static IEnumerable<GameObject> Meshes(SecondaryAnimation_char src)
        {
            yield return src.meshAcce;
            yield return src.meshCstm;
            yield return src.meshEyes;
            yield return src.meshFace;
            yield return src.meshHair;
            yield return src.meshItemH;
            yield return src.meshItemL;
            yield return src.meshItemR;
            yield return src.meshLing;
            yield return src.meshSkin;
            yield return src.meshHide;
            yield break;
        }

        private void Update()
        {
            if (this._advancing)
            {
                this._advancing = false;
                Time.timeScale = 0f;
            }
            if (Time.timeScale != 0f)
            {
                return;
            }
            foreach (SecondaryAnimation_char secondaryAnimation_char in UnityEngine.Object.FindObjectsOfType<SecondaryAnimation_char>())
            {
                secondaryAnimation_char.isVisible = true;
                foreach (GameObject gameObject in Uncensor.Meshes(secondaryAnimation_char))
                {
                    if (gameObject != null)
                    {
                        gameObject.SetActive(true);
                    }
                }
                if (secondaryAnimation_char.meshHide != null)
                {
                    secondaryAnimation_char.meshHide.SetActive(false);
                }
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Delete].wasPressedThisFrame)
            {
                this._advancing = true;
                Time.timeScale = 1f;
            }
        }

        private bool _advancing;
    }
}
