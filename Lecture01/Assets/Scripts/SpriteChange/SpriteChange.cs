using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    private Sprite idleSprite;
    private Sprite clickSprite;

    private SpriteCharacter character;

    private Coroutine spriteChangeCoroutine = null;
    private WaitForSeconds duration = new WaitForSeconds(0.5f);

    private void Awake()
    {
        idleSprite = Resources.Load<Sprite>("");
        clickSprite = Resources.Load<Sprite>("");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (spriteChangeCoroutine != null)
            {
                StopCoroutine(spriteChangeCoroutine);
            }
            spriteChangeCoroutine = StartCoroutine(PlayClickSprite());
        }
    }

    private IEnumerator PlayClickSprite()
    {
        character.SwitchSprite(clickSprite);
        yield return duration;
        character.SwitchSprite(idleSprite);
    }
}
