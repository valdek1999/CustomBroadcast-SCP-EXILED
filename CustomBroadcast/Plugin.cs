using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Exiled.API.Extensions;
using Exiled.API.Interfaces;
using Exiled.Events;
using Handlers = Exiled.Events.Handlers;

namespace CustomBroadcast
{
    public class Plugin : Plugin<Config>
    {

		public override string Author { get; } = "HardFoxy";
		public override string Name { get; } = "BroadCastMessage";
		public override string Prefix { get; } = "BroadCastMessage";
		public override Version Version { get; } = Assembly.GetExecutingAssembly().GetName().Version;
		public override Version RequiredExiledVersion { get; } = new Version(2, 0, 7);

		public EventHandler EventHandler;
		public override void OnEnabled()
		{
			try
			{
				EventHandler = new EventHandler(this);
				base.OnEnabled();
				RegisterEvents();
			}
			catch (Exception e)
			{
				Log.Error($"Loading error: {e}");
			}
		}
		internal void RegisterEvents()
		{
			Handlers.Server.RoundStarted += EventHandler.RoundStart;
			Handlers.Server.RoundEnded += EventHandler.RoundEnd;
			Handlers.Server.WaitingForPlayers += EventHandler.Waiting;
		}
		public override void OnDisabled()
		{
			Handlers.Server.RoundStarted -= EventHandler.RoundStart;
			Handlers.Server.RoundEnded -= EventHandler.RoundEnd;
			Handlers.Server.WaitingForPlayers -= EventHandler.Waiting;
		}

		public override void OnReloaded()
		{

		}
	}
}
