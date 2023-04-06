using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCube : MonoBehaviour
{
    private void Start()
    {
     StartCoroutine(loop());
    }

    private IEnumerator loop()
    {
        while (true)
        {
            for (int i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(0.1f);
                transform.Translate(new Vector3(0f, 0.5f, 0f));
            }
            yield return new WaitForSeconds(1f);
            for (int i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(0.1f);
                transform.Translate(new Vector3(0f, -0.5f, 0f));
            }
        }
    }
}
