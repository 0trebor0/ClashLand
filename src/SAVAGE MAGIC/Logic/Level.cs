﻿using System;
using System.Collections.Generic;
using CRepublic.Magic.Logic.Structure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CRepublic.Magic.Logic
{
    internal class Level
    {
        internal Device Device { get; set; }
        internal Player Avatar { get; set; }

        //internal GameObjectManager GameObjectManager;
        //internal Village_Worker_Manager VillageWorkerManager;
        //internal Builder_Village_Worker_Manager BuilderVillageWorkerManager;

        internal Level()
        {
            this.Avatar = new Player();
        }

        internal Level(long id)
        {
            this.Avatar = new Player(id);
        }

        internal string JSON
        {
            get { return "hih"; }
            set { }
            //get => JsonConvert.SerializeObject(GameObjectManager.JSON, Formatting.Indented);
            //set => this.GameObjectManager.JSON = JObject.Parse(value);
        }
       
        internal void Reset()
        {
            //var gameObjects = GameObjectManager.GetAllGameObjects();
            //foreach (List<GameObject> t in gameObjects)
                //t.Clear();
        }

       /* internal void Tick()
        {
            this.Avatar.LastTick = DateTime.UtcNow;
            GameObjectManager.Tick();
        }*/

        //internal ComponentManager GetComponentManager => this.GameObjectManager.GetComponentManager();

        //internal bool HasFreeVillageWorkers => this.VillageWorkerManager.GetFreeWorkers() > 0;
        //internal bool HasFreeBuilderVillageWorkers => this.BuilderVillageWorkerManager.GetFreeWorkers() > 0;
    }
}
