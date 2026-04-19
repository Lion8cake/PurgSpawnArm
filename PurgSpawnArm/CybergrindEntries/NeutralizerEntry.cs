using PurgSpawnArm;
using UltraEnemyAPI.Systems;
using UnityEngine;

namespace PurgSpawnArm.CybergrindEntries
{
	public class NeutralizerEntry : CustomEnemyTypeEntry
	{
		public override bool AddedToTheCybergrind()
		{
			return Plugin.NeutralizerInCybergrind.value;
		}

		public override void CybergrindSetEntrySettings(out int spawnCost, out int costIncreasePerSpawn, out int spawnWave, out GameObject spawnObjects)
		{
			spawnCost = 55;
			costIncreasePerSpawn = 0; //Capped at 1 reguardless
			spawnWave = 19;
			spawnObjects = Plugin.bundle.LoadAsset<GameObject>("Neutralizer");
		}

		public override SpawnTypePosition CybergrindSetTypePosition()
		{
			return new AfterSpawnTypeEnemy(CybergrindEnemyCatagories.UncommonEnemies.Idol);
		}

		public override int CybergrindCapNonCommonEnemyAmount(int currentWave, int enemyAmount)
		{
			return 1;
		}

		public override bool? CybergrindCanBeRadiant(EndlessEnemy target, int currentWave, int enemyAmount)
		{
			return false;
		}

		public override bool CybergrindUncommonMeleePositionsOnly()
		{
			return true;
		}
	}
}