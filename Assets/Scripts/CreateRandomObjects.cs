using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomObjects : MonoBehaviour
{
    //Here we have the prototypes of our objects (Cube, Sphere and Cylinder)
    public GameObject cubePrototype;
    public GameObject spherePrototype;
    public GameObject cylinderPrototype;
    
    //Here we have some containers for holding together the different types of our objects
    public GameObject CubeContainer;
    public GameObject SphereContainer;
    public GameObject CylinderContainer;
    
    //Here we have some counters for giving distinct names in our created objects
    int cubeCounter = 0;
    int sphereCounter = 0;
    int cylinderCounter = 0;

    //Here we have a function for creating random Objects
    void createRandomObjects()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Here we create randomly the type of our Object
            int randomObjectNum = Random.Range(0, 3);
            //Here we create randomly the radius d of our Object
            float randomObjectRadius = (float)Random.Range(1, 11);

            switch (randomObjectNum)
            {
                case 0:
                    //Here we call all the functions that are essential for creating a new cube and we set its name, position, size, velocity and color
                    
                    cubeCounter++;
                    GameObject newCube = Instantiate(cubePrototype,new Vector3(randomObjectRadius/2, randomObjectRadius/2, randomObjectRadius/2),cubePrototype.transform.rotation);
                    newCube.transform.parent = CubeContainer.transform;
                    newCube.name = "Cube" + cubeCounter;
                    newCube.transform.localScale = new Vector3(randomObjectRadius, randomObjectRadius, randomObjectRadius);
                    newCube.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
                    newCube.GetComponent<Rigidbody>().velocity = new Vector3(10*Random.Range(0.1f, 0.9f), 10*Random.Range(0.1f, 0.9f), 10*Random.Range(0.1f, 0.9f));
                    newCube.AddComponent<MaintainInitialVelocity>();
                    break;

                case 1:
                    //Here we call all the functions that are essential for creating a new Sphere and we set its name, position, size, velocity and color

                    sphereCounter++;
                    GameObject newSphere = Instantiate(spherePrototype, new Vector3(randomObjectRadius/2, randomObjectRadius/2, randomObjectRadius/2), spherePrototype.transform.rotation);
                    newSphere.transform.parent = SphereContainer.transform;
                    newSphere.name = "Sphere" + sphereCounter;
                    newSphere.transform.localScale = new Vector3(randomObjectRadius, randomObjectRadius, randomObjectRadius);
                    newSphere.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
                    newSphere.GetComponent<Rigidbody>().velocity = new Vector3(10 * Random.Range(0.1f, 0.9f), 10 * Random.Range(0.1f, 0.9f), 10 * Random.Range(0.1f, 0.9f));
                    newSphere.AddComponent<MaintainInitialVelocity>();
                    break;

                case 2:
                    //Here we call all the functions that are essential for creating a new Cylinder and we set its name, position, size, velocity and color
                    
                    cylinderCounter++;
                    GameObject newCylinder = Instantiate(cylinderPrototype, new Vector3(randomObjectRadius/2, randomObjectRadius/2, randomObjectRadius/2), cylinderPrototype.transform.rotation);
                    newCylinder.transform.parent = CylinderContainer.transform;
                    newCylinder.name = "Cylinder" + cylinderCounter;
                    newCylinder.transform.localScale = new Vector3(randomObjectRadius,randomObjectRadius/2, randomObjectRadius);
                    newCylinder.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
                    newCylinder.GetComponent<Rigidbody>().velocity = new Vector3(10 * Random.Range(0.1f, 0.9f), 10 * Random.Range(0.1f, 0.9f), 10 * Random.Range(0.1f, 0.9f));
                    newCylinder.AddComponent<MaintainInitialVelocity>();
                    break;
            }
        }
    }

    //Here we have a function for deleting all objects that are in our scene (except SC,SPH)
    void deleteAllObjects()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            var objects = new List<GameObject>();
            foreach (Transform cube in CubeContainer.transform) { objects.Add(cube.gameObject); }
            foreach (Transform sphere in SphereContainer.transform) { objects.Add(sphere.gameObject); }
            foreach (Transform cylinder in CylinderContainer.transform) { objects.Add(cylinder.gameObject); }
            objects.ForEach(curObject => Destroy(curObject));
            cubeCounter = 0;
            sphereCounter = 0;
            cylinderCounter = 0;
        }

    }

    //Here we have a function Update which is called once per frame and calls createRandomObjects() and deleteAllObjects()
    void Update()
    {
        createRandomObjects();
        deleteAllObjects();
    }
}
