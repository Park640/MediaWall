using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Scenario scenario;
    public Bgm bgm;
    public GameObject meat;
    public CircleCollider2D coll;
    int childCnt = 0;

    public void ChildStartEat()
    {
        gameObject.GetComponent<Animator>().SetBool("eat", true);
    }
    public void HamColl()
    {
        coll.enabled = true;
    }
    public void Bird(int i)
    {
        bgm.Bird(i);
    }
    public void Magic1()
    {
        bgm.Magic1();
    }
    public void SeaDark()
    {
        bgm.SeaDark();
    }
    public void Truck(int i)
    {
        bgm.Truck(i);
    }
    public void Baart()
    {
        bgm.Bart();
    }
    public void bart2()
    {
        bgm.Bart2();
    }
    public void Air1()
    {
        bgm.Air1();
    }
    public void Saw(int i)
    {
        bgm.Saw(i);
    }
    public void Cow()
    {
        bgm.Cow();
    }
    public void Poop()
    {
        bgm.Poop();
    }
    public void Appear()
    {
        bgm.appear1.Play();
    }
    public void AirPlane(int i)
    {
        bgm.AirPlane(i);
    }
    public void Factory()
    {
        bgm.Factory();
    }
    public void SteakSound()
    {
        bgm.SteakSound();
    }
    public void EatSound()
    {
        bgm.EatSound();
    }
    public void ChildrenSound()
    {
        bgm.ChildrenSound();
    }
    public void EngineSound()
    {
        bgm.EngineSound();
    }
    public void CrySound()
    {
        bgm.CrySound();
    }
    public void FirstEarthTree()
    {
        scenario.earth.SetBool("tree1", true);
    }
    public void FellingOut()
    {
        scenario.felling.GetComponent<Animator>().SetBool("fellingOut", true);
        meat.SetActive(false);
        scenario.cow.SetActive(true);
        //gameObject.SetActive(false);
        scenario.sceneNo++;
    }
    public void SecondEarthTree()
    {
        scenario.earth.SetBool("tree2", true);
    }
    public void TruckON()
    {
        scenario.truck.SetBool("truckOn", true);
    }
    public void MeatFac()
    {
        scenario.meatFac.SetActive(true);
    }
    public void ThirdEarthTree()
    {
        scenario.earth.SetBool("tree3", true);
    }
    public void FourthEarthTree()
    {
        scenario.earth.SetBool("tree4", true);
    }
    public void FifthEarthTree()
    {
        scenario.earth.SetBool("tree5", true);
    }
    public void FactoryOn()
    {
        scenario.truckObj.SetActive(true);
    }
    public void MeathToHam()
    {
        //scenario.meat2.GetComponent<Animator>().SetBool("meatOut", true);
        scenario.steak.SetActive(true);
    }
    public void SteakToHam()
    {
        scenario.steak.GetComponent<Animator>().SetBool("steakToham", true);
    }
    public void Hamburger()
    {
        scenario.hamburger.SetActive(true);
    }
    public void Children()
    {
        scenario.children.SetActive(true);
    }
    public void ChildEat()
    {
        if (childCnt == 0)
        {
            scenario.hamburger.SetActive(false);
            childCnt++;
        }
        else if (childCnt == 1)
        {
            scenario.hamburger2.SetActive(false);
            childCnt++;
        }
        else if (childCnt == 2)
        {
            gameObject.GetComponent<Animator>().SetBool("eat", false);
            gameObject.GetComponent<Animator>().SetBool("sick", true);
        }

    }
    public void HamburgerOn()
    {
        scenario.hamburger2.SetActive(true);
        scenario.hamburger3.SetActive(true);
    }
}
