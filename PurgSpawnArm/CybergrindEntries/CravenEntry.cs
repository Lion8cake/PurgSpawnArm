using PurgSpawnArm;
using UltraEnemyAPI.Systems;
using UnityEngine;

namespace PurgSpawnArm.CybergrindEntries
{
	public class CravenEntry : CustomEnemyTypeEntry
	{
		public override bool AddedToTheCybergrind()
		{
			return Plugin.CravenInCybergrind.value;
		}

		public override void CybergrindSetEntrySettings(out int spawnCost, out int costIncreasePerSpawn, out int spawnWave, out GameObject spawnObjects)
		{
			spawnCost = 20;
			costIncreasePerSpawn = 15;
			spawnWave = 18;
			spawnObjects = Plugin.bundle.LoadAsset<GameObject>("Craven");
		}

		public override SpawnTypePosition CybergrindSetTypePosition()
		{
			return new BeforeAllEnemies(CybergrindSpawnType.uncommon);
		}
	}
}
