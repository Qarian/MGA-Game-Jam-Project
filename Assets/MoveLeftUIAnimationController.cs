using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveLeftUIAnimationController : MonoBehaviour
{
    private Animator _animator;

    public Animator _animatorSecondMenu;
    public Button nextMenu;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ClickedButtonNextView()
    {
        _animator.SetTrigger("ButtonClicked");
        _animatorSecondMenu.SetTrigger("ButtomClicked");
    }
}
