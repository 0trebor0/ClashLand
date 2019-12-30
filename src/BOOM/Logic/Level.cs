﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRepublic.Boom.Logic.Manager;
using CRepublic.Boom.Packets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CRepublic.Boom.Logic
{
    internal class Level
    {

        internal Device Client;
        internal Avatar Avatar;
        internal Home Home;

        internal GameObjectManager GameObjectManager;

        internal Level()
        {
            this.GameObjectManager = new GameObjectManager(this);
            this.Avatar = new Avatar();
        }

        internal Level(long id)
        {
            this.GameObjectManager = new GameObjectManager(this);
            this.Avatar = new Avatar(id);
        }
        internal void LoadFromJSON(string jsonString)
        {
            GameObjectManager.Load(JObject.Parse(jsonString));
        }

        internal string SaveToJSON()
        {
            return JsonConvert.SerializeObject(GameObjectManager.Save(), Formatting.Indented);
        }

        public void Tick()
        {
            this.Avatar.LastTick = DateTime.UtcNow;
            GameObjectManager.Tick();
        }

        public ComponentManager GetComponentManager() => this.GameObjectManager.GetComponentManager();
    }
}
