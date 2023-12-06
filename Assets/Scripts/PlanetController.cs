using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlanetController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI EOrbitPlanet;
    [SerializeField] public TextMeshProUGUI OOrbitPlanet;
    [SerializeField] public TextMeshProUGUI EPlanet;
    [SerializeField] public TextMeshProUGUI InfoPlanet;
    [SerializeField] public Image Panel;
    [SerializeField] public GameObject shuttleSpace;
    [SerializeField] public GameObject vcShuttleSpace;
    [SerializeField] public GameObject MercurioGrav;
    [SerializeField] public GameObject VCMercurio;
    [SerializeField] public GameObject VenusGrav;
    [SerializeField] public GameObject VCVenus;
    [SerializeField] public GameObject TierraGrav;
    [SerializeField] public GameObject VCTierra;
    [SerializeField] public GameObject MarteGrav;
    [SerializeField] public GameObject VCMarte;
    [SerializeField] public GameObject GravJupiter;
    [SerializeField] public GameObject VJupiter;
    [SerializeField] public GameObject GravSaturno;
    [SerializeField] public GameObject VSaturno;
    [SerializeField] public GameObject UranoGrav;
    [SerializeField] public GameObject VCUrano;
    [SerializeField] public GameObject NeptunoGrav;
    [SerializeField] public GameObject VCNeptuno;

    public bool isInTrigger = false;
    public bool isInOrbit = false;
    public MonoBehaviour shuttleSpaceScript;

    public GameObject planeta;
    public Vector3 coordenadas;

    void Start()
    {
        shuttleSpaceScript = shuttleSpace.GetComponent<ShuttleMovement>();

        planeta = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        coordenadas = shuttleSpace.transform.position;

        if (isInOrbit)
        {
            shuttleSpace.transform.RotateAround(transform.position, Vector3.up, 50f * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (planeta.name == "Mercurio")
                {
                    Debug.Log("Entrando a Mercurio");
                    SceneManager.LoadScene("Mercury");
                }
                else if (planeta.name == "Venus")
                {
                    Debug.Log("Entrando a Venus");
                    SceneManager.LoadScene("Venus");
                }
                else if (planeta.name == "Tierra")
                {
                    Debug.Log("Entrando a Tierra");
                    SceneManager.LoadScene("Earth");
                }
                else if (planeta.name == "Marte")
                {
                    Debug.Log("Entrando a Marte");
                    SceneManager.LoadScene("Mars");
                }
                else if (planeta.name == "Jupiter")
                {
                    Debug.Log("Entrando a Jupiter");
                    SceneManager.LoadScene("Jupiter");
                }
                else if (planeta.name == "Saturno")
                {
                    Debug.Log("Entrando a Saturno");
                    SceneManager.LoadScene("Saturn");
                }
                else if (planeta.name == "Urano")
                {
                    Debug.Log("Entrando a Urano");
                    SceneManager.LoadScene("Uranus");
                }
                else if (planeta.name == "Neptuno")
                {
                    Debug.Log("Entrando a Neptuno");
                    SceneManager.LoadScene("Neptune");
                }
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                isInOrbit = false;
                vcShuttleSpace.SetActive(true);
                shuttleSpaceScript.enabled = true;
                shuttleSpace.transform.parent = null;

                if (planeta.name == "Mercurio")
                {
                    Debug.Log("Desorbitando con Mercurio");
                    VCMercurio.SetActive(false);
                }
                else if (planeta.name == "Venus")
                {
                    Debug.Log("Desorbitando con Venus");
                    VCVenus.SetActive(false);
                }
                else if (planeta.name == "Tierra")
                {
                    Debug.Log("Desorbitando con Tierra");
                    VCTierra.SetActive(false);
                }
                else if (planeta.name == "Marte")
                {
                    Debug.Log("Desorbitando con Marte");
                    VCMarte.SetActive(false);
                }
                else if (planeta.name == "Jupiter")
                {
                    Debug.Log("Desorbitando con Jupiter");
                    VJupiter.SetActive(false);
                }
                else if (planeta.name == "Saturno")
                {
                    Debug.Log("Desorbitando con Saturno");
                    VSaturno.SetActive(false);
                }
                else if (planeta.name == "Urano")
                {
                    Debug.Log("Desorbitando con Urano");
                    VCUrano.SetActive(false);
                }
                else if (planeta.name == "Neptuno")
                {
                    Debug.Log("Desorbitando con Neptuno");
                    VCNeptuno.SetActive(false);
                }
                UpdateTextMesh();

            }
        }

        if (isInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            isInOrbit = true;
            vcShuttleSpace.SetActive(false);
            shuttleSpaceScript.enabled = false;
            shuttleSpace.transform.parent = transform;
            

            if (planeta.name == "Mercurio")
            {
                Debug.Log("Contacto con Mercurio");
                VCMercurio.SetActive(true);
            }
            else if (planeta.name == "Venus")
            {
                Debug.Log("Contacto con Venus");
                VCVenus.SetActive(true);
            }
            else if (planeta.name == "Tierra")
            {
                Debug.Log("Contacto con Tierra");
                VCTierra.SetActive(true);
            }
            else if (planeta.name == "Marte")
            {
                Debug.Log("Contacto con Marte");
                VCMarte.SetActive(true);
            }
            else if (planeta.name == "Jupiter")
            {
                Debug.Log("Contacto con Jupiter");
                VJupiter.SetActive(true);
            }
            else if (planeta.name == "Saturno")
            {
                Debug.Log("Contacto con Saturno");
                VSaturno.SetActive(true);
            }
            else if (planeta.name == "Urano")
            {
                Debug.Log("Contacto con Urano");
                VCUrano.SetActive(true);
            }
            else if (planeta.name == "Neptuno")
            {
                Debug.Log("Contacto con Neptuno");
                VCNeptuno.SetActive(true);
            }
            UpdateTextMesh();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == shuttleSpace)
        {
            isInTrigger = true;
            UpdateTextMesh();
        }
    }

    void OnTriggerStay(Collider other)
    {

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == shuttleSpace)
        {
            isInTrigger = false;
            UpdateTextMesh();
        }
    }

    private void UpdateTextMesh()
    {
        if (isInTrigger && isInOrbit == false)
        {
            EOrbitPlanet.enabled = true;
            EPlanet.enabled = false;
            OOrbitPlanet.enabled = false;
            InfoPlanet.enabled = false;
            Panel.enabled = false;
        }
        else if (isInTrigger && isInOrbit)
        {
            EOrbitPlanet.enabled = false;
            EPlanet.enabled = true;
            OOrbitPlanet.enabled = true;
            InfoPlanet.enabled = true;
            Panel.enabled = true;
        }
        else
        {
            EOrbitPlanet.enabled = false;
            EPlanet.enabled = false;
            OOrbitPlanet.enabled = false;
            InfoPlanet.enabled = false;
            Panel.enabled = false;
        }
    }

}
