using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballSimulator.Model;
using System;

namespace FootballSimulator.Tests
{
    [TestClass]
    public class PairwiseTests
    {
        //        TEST CASES			
        //case	Domaci Gosti   Odigrana
        //1	    Negativno Negativno   Da
        //2	    Negativno Pozitivno   Ne
        //3	    Pozitivno Negativno   Ne
        //4	    Pozitivno Pozitivno   Da
        //5	    0	0	Da
        //6	    0	Negativno Ne
        //7	    Negativno	0	Ne
        //8	    Pozitivno	0	~Da
        //9	    0	Pozitivno ~Da

        // Imena testnih metoda trebaju biti deskriptivnija
        // 



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PairwsiseTestCase1()
        {
            Rezultat rezultat = new Rezultat(-1, -1, true);
            rezultat.JeLiNerjeseno();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PairwsiseTestCase2()
        {
            Rezultat rezultat = new Rezultat(-1, 2, false);
            rezultat.JeLiNerjeseno();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PairwsiseTestCase3()
        {
            Rezultat rezultat = new Rezultat(2, -1, false);
            rezultat.JeLiNerjeseno();
        }

        [TestMethod]
        public void PairwsiseTestCase4()
        {
            Rezultat rezultat = new Rezultat(2, 2, true);
            rezultat.JeLiNerjeseno();
        }

        [TestMethod]
        public void PairwsiseTestCase5()
        {
            Rezultat rezultat = new Rezultat(0, 0, true);
            rezultat.JeLiNerjeseno();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PairwsiseTestCase6()
        {
            Rezultat rezultat = new Rezultat(0, -1, false);
            rezultat.JeLiNerjeseno();
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PairwsiseTestCase7()
        {
            Rezultat rezultat = new Rezultat(-1, 0, false);
            rezultat.JeLiNerjeseno();
        }


        [TestMethod]
        public void PairwsiseTestCase8()
        {
            Rezultat rezultat = new Rezultat(2, 0, true); // alternativno: new Rezultat(2, 0, false);
            rezultat.JeLiNerjeseno();
        }


        [TestMethod]
        public void PairwsiseTestCase9()
        {
            Rezultat rezultat = new Rezultat(0, 2, true); // alternativno: new Rezultat(0, 2, false);
            rezultat.JeLiNerjeseno();
        }



    }
}
