using App;
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
       
        private bool _advancing;
        private bool _cstm = false;
        private bool _acce = false;
        private bool _itemh = false;
        private bool _iteml = false;
        private bool _itemr = false;
        private bool _skin = false;
        private bool _ling = false;
        private bool _hair = false;
        private bool _face = false;
        private bool _eyes = false;

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

                //Hide Mesh.
                if (this._cstm)
                {
                    if (secondaryAnimation_char.meshCstm != null)
                    {
                        secondaryAnimation_char.meshCstm.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshCstm != null)
                    {
                        secondaryAnimation_char.meshCstm.SetActive(true);
                    }
                }

                if (this._acce)
                {
                    if (secondaryAnimation_char.meshAcce != null)
                    {
                        secondaryAnimation_char.meshAcce.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshAcce != null)
                    {
                        secondaryAnimation_char.meshAcce.SetActive(true);
                    }
                }

                if (this._skin)
                {
                    if (secondaryAnimation_char.meshSkin != null)
                    {
                        secondaryAnimation_char.meshSkin.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshSkin != null)
                    {
                        secondaryAnimation_char.meshSkin.SetActive(true);
                    }
                }

                if (this._iteml)
                {
                    if (secondaryAnimation_char.meshItemL != null)
                    {
                        secondaryAnimation_char.meshItemL.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshItemL != null)
                    {
                        secondaryAnimation_char.meshItemL.SetActive(true);
                    }
                }

                if (this._itemr)
                {
                    if (secondaryAnimation_char.meshItemR != null)
                    {
                        secondaryAnimation_char.meshItemR.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshItemR != null)
                    {
                        secondaryAnimation_char.meshItemR.SetActive(true);
                    }
                }

                if (this._itemh)
                {
                    if (secondaryAnimation_char.meshItemH != null)
                    {
                        secondaryAnimation_char.meshItemH.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshItemH != null)
                    {
                        secondaryAnimation_char.meshItemH.SetActive(true);
                    }
                }

                if (this._ling)
                {
                    if (secondaryAnimation_char.meshLing != null)
                    {
                        secondaryAnimation_char.meshLing.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshLing != null)
                    {
                        secondaryAnimation_char.meshLing.SetActive(true);
                    }
                }

                if (this._hair)
                {
                    if (secondaryAnimation_char.meshHair != null)
                    {
                        secondaryAnimation_char.meshHair.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshHair != null)
                    {
                        secondaryAnimation_char.meshHair.SetActive(true);
                    }
                }

                if (this._face)
                {
                    if (secondaryAnimation_char.meshFace != null)
                    {
                        secondaryAnimation_char.meshFace.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshFace != null)
                    {
                        secondaryAnimation_char.meshFace.SetActive(true);
                    }
                }

                if (this._eyes)
                {
                    if (secondaryAnimation_char.meshEyes != null)
                    {
                        secondaryAnimation_char.meshEyes.SetActive(false);
                    }
                }
                else
                {
                    if (secondaryAnimation_char.meshEyes != null)
                    {
                        secondaryAnimation_char.meshEyes.SetActive(true);
                    }
                }

            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Delete].wasPressedThisFrame || Gamepad.current.selectButton.wasPressedThisFrame)
            {
                this._advancing = true;
                Time.timeScale = 1f;
            }

            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit1].wasPressedThisFrame)
            {
                this._cstm = !this._cstm;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit2].wasPressedThisFrame)
            {
                this._acce = !this._acce;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit3].wasPressedThisFrame)
            {
                this._itemh = !this._itemh;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit4].wasPressedThisFrame)
            {
                this._iteml = !this._iteml;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit5].wasPressedThisFrame)
            {
                this._itemr = !this._itemr;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit6].wasPressedThisFrame)
            {
                this._skin = !this._skin;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit7].wasPressedThisFrame)
            {
                this._ling = !this._ling;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit8].wasPressedThisFrame)
            {
                this._hair = !this._hair;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit9].wasPressedThisFrame)
            {
                this._face = !this._face;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Digit0].wasPressedThisFrame)
            {
                this._eyes = !this._eyes;
            }
            if (Keyboard.current[UnityEngine.InputSystem.Key.Backspace].wasPressedThisFrame || (Gamepad.current.leftStickButton.wasPressedThisFrame))
            {
                this._cstm = false;
                this._acce = false;
                this._itemh = false;
                this._iteml = false;
                this._itemr = false;
                this._skin = false;
                this._ling = false;
                this._hair = false;
                this._face = false;
                this._eyes = false;
    }
        }

      
    }
}
