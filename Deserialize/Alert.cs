

//{
//    "_id": {
//        "$oid": "637d23e9b89a2480e0055f56"
//            },
//            "Activation": {
//        "$date": {
//            "$numberLong": "1671217200000"
//                }
//    },
//            "Expiry": {
//        "$date": {
//            "$numberLong": "1672513200000"
//                }
//    },
//            "MissionInfo": {
//        "location": "SolNode25",
//                "missionType": "MT_TERRITORY",
//                "faction": "FC_CORPUS",
//                "difficulty": 1,
//                "missionReward": {
//            "credits": 20000,
//                    "items": [
//                        "/Lotus/StoreItems/Upgrades/Skins/Sigils/HolidaySigilXmas2014D"
//                    ]
//                },
//                "levelOverride": "/Lotus/Levels/Proc/Corpus/CorpusGasCityInterception",
//                "enemySpec": "/Lotus/Types/Game/EnemySpecs/CorpusGasRemasterDefenseSquad",
//                "minEnemyLevel": 20,
//                "maxEnemyLevel": 30,
//                "descText": "/Lotus/Language/Alerts/TennoUnitedAlert",
//                "maxWaveNum": 2
//            },
//            "Tag": "LotusGift",
//            "ForceUnlock": true
//        }

namespace PotatoAlert.Deserialize
{
    public class Alert
    {
        public string? Tag { get; set; }
        public MissionInfo? MissionInfo { get; set; }
    }

    public class MissionInfo
    {
        public string? location;
        public string? missionType;
        public string? faction;
        public int difficulty;
        public MissionReward? missionReward;
        public int minEnemyLevel;
        public int maxEnemyLevel;
    }
}
