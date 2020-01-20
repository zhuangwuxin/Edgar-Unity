﻿using MapGeneration.Interfaces.Core.MapLayouts;

namespace Assets.ProceduralLevelGenerator.Scripts.GeneratorPipeline.Payloads.Interfaces
{
	using System.Collections.Generic;
	using DungeonGenerators;
	using GeneralAlgorithms.DataStructures.Common;
	using MapGeneration.Core.MapDescriptions;
	using MapGeneration.Interfaces.Core.MapDescriptions;
	using RoomTemplates;
	using UnityEngine;

	/// <summary>
	/// Represents data used in and produced from a graph-based dungeon generator.
	/// </summary>
    public interface IGraphBasedGeneratorPayload
	{
		IMapDescription<int> MapDescription { get; set; }

		IMapLayout<int> GeneratedLayout { get; set; }

		TwoWayDictionary<IRoomTemplate, GameObject> RoomDescriptionsToRoomTemplates { get; set; }

		Layout<int> Layout { get; set; }
	}
}