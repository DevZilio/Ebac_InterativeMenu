using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

public static class DevZilioUtil
{

// O codigo abaixo deveria ser feito em um script de editor, pois quando gera o jogo, tais funcoes nao devem ser compiladas, porem podemos usar essas funcoes de editor em outros scripts, desde que informamos usando o #if Unity_Editor para o unity que esta funcao nao deve ser compilada ao jogo.

//Criando um item de menu na barra de ferramentas
#if UNITY_EDITOR
[UnityEditor.MenuItem("Ebac/Test")]
public static void Test()
{
    Debug.Log("Test");
}

// criando atalho do teclado para acessar o menu
[UnityEditor.MenuItem("Ebac/Test2 %g")]
public static void Test2()
{
    Debug.Log("Test2");
}
#endif



    //Baseando no script Exemplo, essas funcoes ira executar da seguinte maneira:
    //public static Screens.ScreeBase GetRandom<Screens.ScreeBase>(this List<Screens.ScreeBase> list)
 

    #region RANDOM STUFF

public static T GetRandom<T>(this T[] array)
{
    if(array.Length ==0)
    return default(T);

    return array[Random.Range(0, array.Length)];
}

public static T GetRandom<T>(this List<T> list)
{
    return list[Random.Range(0, list.Count)];
}

public static T GetRandomButNotSame<T>(this List<T> list, T unique)
{
    if(list.Count == 1)
    return unique;

    int randomIndex = Random.Range(0, list.Count);
    return list[randomIndex];
}



    #endregion
}