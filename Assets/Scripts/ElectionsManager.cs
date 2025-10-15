using UnityEngine;

public class ElectionsManager : MonoBehaviour
{
    public int votosJoel;
    public int votosIvon;
    public int votosIker;
    public int votosRobert;

    public void Votar(string nombre)
    {
        switch (nombre)
        {
            case "Joel":
                votosJoel += 1;
                break;
            case "Ivon":
                votosIvon += 1;
                break;
            case "Robert":
                votosRobert += 1;
                break;
            case "Iker":
                votosIker += 1;
                break;
            default:

                break;
        }
    }
}
