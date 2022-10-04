using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonages : MonoBehaviour
{
    public Transform[] Personajes;
    public MeshRenderer meshRenderer;
    public Vector3[] posicion;
    public bool personaje1 = false;
    public bool personaje2 = false;
    public bool personaje3 = false;
    public bool personaje4 = false;

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("1"))
        {


            personaje1 = true;
            personaje2 = false;
            personaje3 = false;
            personaje4 = false;

            

        }

        if (personaje1 == true && Input.GetKeyDown("a"))
        {


            Personajes[0].transform.position += Vector3.right;




        }else if (personaje1 == true && Input.GetKeyDown("d"))
        {




            Personajes[0].transform.position += Vector3.left;




        }else if (personaje1 == true && Input.GetKeyDown("w"))
        {




            Personajes[0].transform.position += Vector3.up;



        }else if (personaje1 == true && Input.GetKeyDown("s") && Personajes[0].position.y > 0.28)
        {


           

            Personajes[0].transform.position += Vector3.down;



        }

        if (Input.GetKeyDown("2"))
        {


            personaje1 = false;
            personaje2 = true;
            personaje3 = false;
            personaje4 = false;




        }
        
        if(personaje2 == true && Input.GetKeyDown("a"))
        {



            Personajes[1].transform.position += Vector3.right;



        }else if (personaje2 == true && Input.GetKeyDown("d"))
        {



            Personajes[1].transform.position += Vector3.left;



        }else if (personaje2 == true && Input.GetKeyDown("w")) 
        {




            Personajes[1].transform.position += Vector3.up;



        }else if (personaje2 == true && Input.GetKeyDown("s") && Personajes[1].position.y > 1.50) 
        {




            Personajes[1].transform.position += Vector3.down;



        }



        if (Input.GetKeyDown("3"))
        {


            personaje1 = false;
            personaje2 = false;
            personaje3 = true;
            personaje4 = false;


        }

        if (personaje3 == true && Input.GetKeyDown("a"))
        {



            Personajes[2].transform.position += Vector3.right;



        }else if (personaje3 == true && Input.GetKeyDown("d"))
        {



            Personajes[2].transform.position += Vector3.left;



        }else if (personaje3 == true && Input.GetKeyDown("w"))
        {




            Personajes[2].transform.position += Vector3.up;



        }else if (personaje3 == true && Input.GetKeyDown("s") && Personajes[2].position.y > 0.05)
        {




            Personajes[2].transform.position += Vector3.down;



        }



        if (Input.GetKeyDown("4"))
        {


            personaje1 = false;
            personaje2 = false;
            personaje3 = false;
            personaje4 = true;


        }


        if (personaje4 == true && Input.GetKeyDown("a"))
        {



            Personajes[3].transform.position += Vector3.right;



        }
        else if (personaje4 == true && Input.GetKeyDown("d"))
        {



            Personajes[3].transform.position += Vector3.left;



        }
        else if (personaje4 == true && Input.GetKeyDown("w"))
        {




            Personajes[3].transform.position += Vector3.up;



        }else if (personaje4 == true && Input.GetKeyDown("s") && Personajes[3].position.y > 0.2)
        {




            Personajes[3].transform.position += Vector3.down;



        }

        if (Input.GetKeyDown("space"))
        {


            Personajes[0].transform.position = Vector3.zero;
            Personajes[1].transform.position = Vector3.zero;
            Personajes[2].transform.position = Vector3.zero;
            Personajes[3].transform.position = Vector3.zero;

        }






    }

}

