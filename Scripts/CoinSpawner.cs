using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject moedaPrefab;

    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;

    public float tempoRespawn = 2f;

    void Start()
    {
        SpawnarMoeda();
    }

    void SpawnarMoeda()
    {
        Transform[] pontos = {
            spawn1,
            spawn2,
            spawn3,
            spawn4,
            spawn5
        };

        int numero = Random.Range(0, pontos.Length);

        if (pontos[numero] == null)
        {
            Debug.LogError("Um dos Spawn Points não foi colocado no CoinSpawner!");
            return;
        }

        Instantiate(
            moedaPrefab,
            pontos[numero].position,
            Quaternion.identity
        );
    }

    public void MoedaColetada()
    {
        Invoke(nameof(SpawnarMoeda), tempoRespawn);
    }
}