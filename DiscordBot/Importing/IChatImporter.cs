﻿using System.Timers;

namespace Discord_Channel_Importer.DiscordBot.Importing
{
	/// <summary>
	/// For Discord channel chat importers
	/// </summary>
	internal interface IChatImporter
	{
		Timer ImportTimer { get; }

		IChatImporterSettings Settings { get; }

		bool IsFinished { get; }


		void StartImport();

		void StopImport();
	}	
}
