﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Building
{

    public class Building : MonoBehaviour
    {

        #region DataEnums

        public enum BuildingType
        {
            QG, QG_Captured, Ville, MineDeFer, Caserne, TourDarcher, None
        }

        #endregion

        #region DataLists

        protected int[] orIncomeList = { 10, 20, 30 };
        protected int[] orQGIncomeList = { 20, 40, 60 };
        protected int[] ferIncomeList = { 1, 2, 3 };
        protected int[] dommageList = { 10, 15, 25 };
        protected int[] dommageQGList = { 20, 30, 50 };

        protected int[] healsListVille = { 200, 400, 800 };
        protected int[] healsListMineDeFer = { 250, 500, 1000 };
        protected int[] healsListTourDarcher = { 150, 300, 600 };
        protected int healsListCaserne = 500;
        protected int[] healsListQG = { 1000, 2000, 5000 };
        protected int[] healsListQG_Captured = { 500, 1000, 1500 };

        #endregion

        #region Initialisateur

        private BuildingType type;
        private int orIncome;
        private int ferIncome;
        private bool spawnUnit;
        private int initialLevel;
        private int actualLevel;
        private int maxHeals;
        private int maxNeutralHeals;
        private int heals;
        private int dommage;

        #endregion

        #region getters

        public BuildingType Type
        {
            get => type;
        }


        public int OrIncome
        {
            get => orIncome;
        }

        public int FerIncome
        {
            get => ferIncome;
        }

        public bool SpawnUnit
        {
            get => spawnUnit;
        }

        public int Dommage
        {
            get => dommage;
        }

        public int ActualLevel
        {
            get => actualLevel;
        }

        public int Heals
        {
            get => heals;
        }

        #endregion

        public Building(BuildingType typeBatiment, int initialLvl)
        {
            this.type = typeBatiment;
            this.initialLevel = initialLvl;
            this.actualLevel = initialLevel;

            this.ferIncome = 0;
            this.orIncome = 0;
            this.spawnUnit = false;

            switch (typeBatiment)
            {
                case BuildingType.Ville:

                    this.orIncome = orIncomeList[ActualLevel];
                    this.maxHeals = healsListVille[ActualLevel];
                    this.maxNeutralHeals = maxHeals / 2;
                    break;


                case BuildingType.MineDeFer:

                    this.ferIncome = ferIncomeList[ActualLevel];
                    this.maxHeals = healsListMineDeFer[ActualLevel];
                    this.maxNeutralHeals = maxHeals / 2;
                    break;

                case BuildingType.Caserne:

                    this.spawnUnit = true;
                    this.initialLevel = 0;
                    this.actualLevel = 0;
                    this.maxHeals = healsListCaserne;
                    this.maxNeutralHeals = maxHeals / 2;
                    break;

                case BuildingType.TourDarcher:

                    this.dommage = dommageList[ActualLevel];
                    break;

                case BuildingType.QG:

                case BuildingType.QG_Captured:

                    this.spawnUnit = true;
                    this.orIncome = orQGIncomeList[ActualLevel];
                    this.dommage = dommageQGList[ActualLevel];
                    break;

                default:

                    break;
            }

            return;
        }

        // Start is called before the first frame update
        void Start()
        {
            //nothing to do
        }


        // Update is called once per frame
        void Update()
        {
            //nothing to do
        }
    }
}