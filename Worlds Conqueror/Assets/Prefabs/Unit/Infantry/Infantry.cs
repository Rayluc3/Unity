﻿using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using UnityEngine;

namespace WorldConqueror
{
    public class Infantry : Unit
    {
        #region Attributs

        
        private static int[] da = {10, 15, 20};
        private static int[] hp = {10, 20, 30};
        public static int sp = 5;
        protected int level; 
        
        #endregion

        public Infantry(PunTeams.Team team)
            : base(SoldierType.Infantry, team, da[0], hp[0], sp, 0)
        {
            
        }
        
        
        
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
