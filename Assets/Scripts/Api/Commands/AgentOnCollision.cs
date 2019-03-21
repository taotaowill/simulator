﻿/**
* Copyright (c) 2019 LG Electronics, Inc.
*
* This software contains code licensed as described in LICENSE.
*
*/

using SimpleJSON;
using UnityEngine;

namespace Api.Commands
{
    class AgentOnCollision : ICommand
    {
        public string Name { get { return "agent/on_collision"; } }

        public void Execute(string client, JSONNode args)
        {
            var api = ApiManager.Instance;
            var uid = args["uid"].Value;

            GameObject obj;
            if (api.Agents.TryGetValue(uid, out obj))
            {
                api.Collisions.Add(obj);
                api.SendResult(client, JSONNull.CreateOrGet());
            }
            else
            {
                api.SendError(client, $"Agent '{uid}' not found");
            }
        }
    }
}
