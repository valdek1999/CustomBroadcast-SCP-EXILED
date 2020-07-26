using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MEC;
using Mirror;
using Exiled.Events.EventArgs;
using Exiled.API.Features;
using Random = System.Random;

namespace CustomBroadcast
{
    public class EventHandler
    {
        readonly public Plugin plugin;
        Random random = new Random();
        string[] tip;
        public EventHandler(Plugin plugin)
        {
            this.plugin = plugin;
            tip = plugin.Config.CustomBroadcastMessage;
        }
        public bool round { get; set; }
        public List<CoroutineHandle> coroutines = new List<CoroutineHandle>();

        public EventHandler()
        {

        }

        internal void RoundStart()
        {
            round = true;
            foreach (CoroutineHandle handle in coroutines)
            {
                Timing.KillCoroutines(handle);
            }
            Log.Info("Starting the BroadCast.");
            coroutines.Add(Timing.RunCoroutine(BroadCastMessage(), ""));

        }

        public IEnumerator<float> BroadCastMessage()
        {
            while (round)
            {

                for (int i = tip.Length - 1; i >= 1; i--)
                {
                    int j = random.Next(i + 1);
                    // обменять значения data[j] и data[i]
                    var temp = tip[j];
                    tip[j] = tip[i];
                    tip[i] = temp;
                }
                yield return Timing.WaitForSeconds(20);
                foreach (string i in tip)
                {
                    
                        for(int k = 0; k < plugin.Config.RepeatingDuration; k++)
                        {
                            Map.Broadcast(1, $"{i}");
                            yield return Timing.WaitForSeconds(0.6f);
                        }
                    yield return Timing.WaitForSeconds(plugin.Config.RepeatingCooldown);
                }
            }
        }

        internal void Waiting()
        {
            round = false;
            foreach (CoroutineHandle handle in coroutines)
            {
                Timing.KillCoroutines(handle);
            }
        }

        internal void RoundEnd(RoundEndedEventArgs ev)
        {
            round = false;

        }

        internal void WaitingForPlayers()
        {
            foreach (CoroutineHandle handle in coroutines)
            {
                Timing.KillCoroutines(handle);
            }
        }
    }
}

