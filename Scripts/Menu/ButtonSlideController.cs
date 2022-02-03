using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.Animations;
using UnityEngine;

public class ButtonSlideController : MonoBehaviour
{
    [SerializeField] private bool isActive;
    [SerializeField] private Animator _animator;

    async public void StartWorkSlider() 
    {
        Debug.Log("+");
        if (isActive)
        {
            _animator.SetBool("Run" , true);
            isActive = false;
            await Task.Delay(100);
            Debug.Log(_animator.GetBool("Run"));
            _animator.SetBool("Run" , false);
        }
        else
        {
            _animator.SetBool("Return" , true);
            isActive = true;
            await Task.Delay(100);
            _animator.SetBool("Return" , false);
        }
    }
}
