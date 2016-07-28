// Generated by the Protocol Buffers 3.0 compiler.  DO NOT EDIT!
// Source file "POGOProtos.Networking.Requests.proto"
// Syntax "Proto3"

import Foundation
import ProtocolBuffers


public func == (lhs: Pogoprotos.Networking.Requests.Request, rhs: Pogoprotos.Networking.Requests.Request) -> Bool {
  if (lhs === rhs) {
    return true
  }
  var fieldCheck:Bool = (lhs.hashValue == rhs.hashValue)
  fieldCheck = fieldCheck && (lhs.hasRequestType == rhs.hasRequestType) && (!lhs.hasRequestType || lhs.requestType == rhs.requestType)
  fieldCheck = fieldCheck && (lhs.hasRequestMessage == rhs.hasRequestMessage) && (!lhs.hasRequestMessage || lhs.requestMessage == rhs.requestMessage)
  fieldCheck = (fieldCheck && (lhs.unknownFields == rhs.unknownFields))
  return fieldCheck
}

public extension Pogoprotos.Networking.Requests {
  public struct PogoprotosNetworkingRequestsRoot {
    public static var sharedInstance : PogoprotosNetworkingRequestsRoot {
     struct Static {
         static let instance : PogoprotosNetworkingRequestsRoot = PogoprotosNetworkingRequestsRoot()
     }
     return Static.instance
    }
    public var extensionRegistry:ExtensionRegistry

    init() {
      extensionRegistry = ExtensionRegistry()
      registerAllExtensions(extensionRegistry)
    }
    public func registerAllExtensions(_ registry:ExtensionRegistry) {
    }
  }



  //Enum type declaration start 

  public enum RequestType:Int32, CustomDebugStringConvertible, CustomStringConvertible {
    // No implementation required
    case methodUnset = 0

    // Implemented [R & M]
    case playerUpdate = 1

    // Implemented [R & M]
    case getPlayer = 2

    // Implemented [R & M]
    case getInventory = 4

    // Implemented [R & M]
    case downloadSettings = 5

    // Implemented [R & M]
    case downloadItemTemplates = 6

    // Implemented [R & M]
    case downloadRemoteConfigVersion = 7

    // Implemented [R & M]
    case fortSearch = 101

    // Implemented [R & M]
    case encounter = 102

    // Implemented [R & M]
    case catchPokemon = 103

    // Implemented [R & M]
    case fortDetails = 104

    // Can't find this one
    case itemUse = 105

    // Implemented [R & M]
    case getMapObjects = 106

    // Implemented [R & M]
    case fortDeployPokemon = 110

    // Implemented [R & M]
    case fortRecallPokemon = 111

    // Implemented [R & M]
    case releasePokemon = 112

    // Implemented [R & M]
    case useItemPotion = 113

    // Implemented [R & M]
    case useItemCapture = 114

    // Can't find this one
    case useItemFlee = 115

    // Implemented [R & M]
    case useItemRevive = 116

    // Not yet implemented in the game
    case tradeSearch = 117

    // Not yet implemented in the game
    case tradeOffer = 118

    // Not yet implemented in the game
    case tradeResponse = 119

    // Not yet implemented in the game
    case tradeResult = 120

    // Implemented [R & M]
    case getPlayerProfile = 121

    // Can't find this one
    case getItemPack = 122

    // Can't find this one
    case buyItemPack = 123

    // Can't find this one
    case buyGemPack = 124

    // Implemented [R & M]
    case evolvePokemon = 125

    // Implemented [R & M]
    case getHatchedEggs = 126

    // Implemented [R & M]
    case encounterTutorialComplete = 127

    // Implemented [R & M]
    case levelUpRewards = 128

    // Implemented [R & M]
    case checkAwardedBadges = 129

    // Implemented [R & M]
    case useItemGym = 133

    // Implemented [R & M]
    case getGymDetails = 134

    // Implemented [R & M]
    case startGymBattle = 135

    // Implemented [R & M]
    case attackGym = 136

    // Implemented [R & M]
    case recycleInventoryItem = 137

    // Implemented [R & M]
    case collectDailyBonus = 138

    // Implemented [R & M]
    case useItemXpBoost = 139

    // Implemented [R & M]
    case useItemEggIncubator = 140

    // Implemented [R & M]
    case useIncense = 141

    // Implemented [R & M]
    case getIncensePokemon = 142

    // Implemented [R & M]
    case incenseEncounter = 143

    // Implemented [R & M]
    case addFortModifier = 144

    // Implemented [R & M]
    case diskEncounter = 145

    // Implemented [R & M]
    case collectDailyDefenderBonus = 146

    // Implemented [R & M]
    case upgradePokemon = 147

    // Implemented [R & M]
    case setFavoritePokemon = 148

    // Implemented [R & M]
    case nicknamePokemon = 149

    // Implemented [R & M]
    case equipBadge = 150

    // Implemented [R & M]
    case setContactSettings = 151

    // Implemented [R & M]
    case getAssetDigest = 300

    // Implemented [R & M]
    case getDownloadUrls = 301

    // Implemented [R & M]
    case getSuggestedCodenames = 401

    // Implemented [R & M] TEST RESPONSE
    case checkCodenameAvailable = 402

    // Implemented [R & M] TEST RESPONSE
    case claimCodename = 403

    // Implemented [R & M]
    case setAvatar = 404

    // Implemented [R & M]
    case setPlayerTeam = 405

    // Implemented [R & M]
    case markTutorialComplete = 406

    // Can't find this one
    case loadSpawnPoints = 500

    // Implemented [R & M]
    case echo = 666
    case debugUpdateInventory = 700
    case debugDeletePlayer = 701

    // Not yet released.
    case sfidaRegistration = 800

    // Not yet released.
    case sfidaActionLog = 801

    // Not yet released.
    case sfidaCertification = 802

    // Not yet released.
    case sfidaUpdate = 803

    // Not yet released.
    case sfidaAction = 804

    // Not yet released.
    case sfidaDowser = 805

    // Not yet released.
    case sfidaCapture = 806
    public func toString() -> String {
      switch self {
      case .methodUnset: return "METHOD_UNSET"
      case .playerUpdate: return "PLAYER_UPDATE"
      case .getPlayer: return "GET_PLAYER"
      case .getInventory: return "GET_INVENTORY"
      case .downloadSettings: return "DOWNLOAD_SETTINGS"
      case .downloadItemTemplates: return "DOWNLOAD_ITEM_TEMPLATES"
      case .downloadRemoteConfigVersion: return "DOWNLOAD_REMOTE_CONFIG_VERSION"
      case .fortSearch: return "FORT_SEARCH"
      case .encounter: return "ENCOUNTER"
      case .catchPokemon: return "CATCH_POKEMON"
      case .fortDetails: return "FORT_DETAILS"
      case .itemUse: return "ITEM_USE"
      case .getMapObjects: return "GET_MAP_OBJECTS"
      case .fortDeployPokemon: return "FORT_DEPLOY_POKEMON"
      case .fortRecallPokemon: return "FORT_RECALL_POKEMON"
      case .releasePokemon: return "RELEASE_POKEMON"
      case .useItemPotion: return "USE_ITEM_POTION"
      case .useItemCapture: return "USE_ITEM_CAPTURE"
      case .useItemFlee: return "USE_ITEM_FLEE"
      case .useItemRevive: return "USE_ITEM_REVIVE"
      case .tradeSearch: return "TRADE_SEARCH"
      case .tradeOffer: return "TRADE_OFFER"
      case .tradeResponse: return "TRADE_RESPONSE"
      case .tradeResult: return "TRADE_RESULT"
      case .getPlayerProfile: return "GET_PLAYER_PROFILE"
      case .getItemPack: return "GET_ITEM_PACK"
      case .buyItemPack: return "BUY_ITEM_PACK"
      case .buyGemPack: return "BUY_GEM_PACK"
      case .evolvePokemon: return "EVOLVE_POKEMON"
      case .getHatchedEggs: return "GET_HATCHED_EGGS"
      case .encounterTutorialComplete: return "ENCOUNTER_TUTORIAL_COMPLETE"
      case .levelUpRewards: return "LEVEL_UP_REWARDS"
      case .checkAwardedBadges: return "CHECK_AWARDED_BADGES"
      case .useItemGym: return "USE_ITEM_GYM"
      case .getGymDetails: return "GET_GYM_DETAILS"
      case .startGymBattle: return "START_GYM_BATTLE"
      case .attackGym: return "ATTACK_GYM"
      case .recycleInventoryItem: return "RECYCLE_INVENTORY_ITEM"
      case .collectDailyBonus: return "COLLECT_DAILY_BONUS"
      case .useItemXpBoost: return "USE_ITEM_XP_BOOST"
      case .useItemEggIncubator: return "USE_ITEM_EGG_INCUBATOR"
      case .useIncense: return "USE_INCENSE"
      case .getIncensePokemon: return "GET_INCENSE_POKEMON"
      case .incenseEncounter: return "INCENSE_ENCOUNTER"
      case .addFortModifier: return "ADD_FORT_MODIFIER"
      case .diskEncounter: return "DISK_ENCOUNTER"
      case .collectDailyDefenderBonus: return "COLLECT_DAILY_DEFENDER_BONUS"
      case .upgradePokemon: return "UPGRADE_POKEMON"
      case .setFavoritePokemon: return "SET_FAVORITE_POKEMON"
      case .nicknamePokemon: return "NICKNAME_POKEMON"
      case .equipBadge: return "EQUIP_BADGE"
      case .setContactSettings: return "SET_CONTACT_SETTINGS"
      case .getAssetDigest: return "GET_ASSET_DIGEST"
      case .getDownloadUrls: return "GET_DOWNLOAD_URLS"
      case .getSuggestedCodenames: return "GET_SUGGESTED_CODENAMES"
      case .checkCodenameAvailable: return "CHECK_CODENAME_AVAILABLE"
      case .claimCodename: return "CLAIM_CODENAME"
      case .setAvatar: return "SET_AVATAR"
      case .setPlayerTeam: return "SET_PLAYER_TEAM"
      case .markTutorialComplete: return "MARK_TUTORIAL_COMPLETE"
      case .loadSpawnPoints: return "LOAD_SPAWN_POINTS"
      case .echo: return "ECHO"
      case .debugUpdateInventory: return "DEBUG_UPDATE_INVENTORY"
      case .debugDeletePlayer: return "DEBUG_DELETE_PLAYER"
      case .sfidaRegistration: return "SFIDA_REGISTRATION"
      case .sfidaActionLog: return "SFIDA_ACTION_LOG"
      case .sfidaCertification: return "SFIDA_CERTIFICATION"
      case .sfidaUpdate: return "SFIDA_UPDATE"
      case .sfidaAction: return "SFIDA_ACTION"
      case .sfidaDowser: return "SFIDA_DOWSER"
      case .sfidaCapture: return "SFIDA_CAPTURE"
      }
    }
    public static func fromString(_ str:String) throws -> Pogoprotos.Networking.Requests.RequestType {
      switch str {
      case "METHOD_UNSET":  return .methodUnset
      case "PLAYER_UPDATE":  return .playerUpdate
      case "GET_PLAYER":  return .getPlayer
      case "GET_INVENTORY":  return .getInventory
      case "DOWNLOAD_SETTINGS":  return .downloadSettings
      case "DOWNLOAD_ITEM_TEMPLATES":  return .downloadItemTemplates
      case "DOWNLOAD_REMOTE_CONFIG_VERSION":  return .downloadRemoteConfigVersion
      case "FORT_SEARCH":  return .fortSearch
      case "ENCOUNTER":  return .encounter
      case "CATCH_POKEMON":  return .catchPokemon
      case "FORT_DETAILS":  return .fortDetails
      case "ITEM_USE":  return .itemUse
      case "GET_MAP_OBJECTS":  return .getMapObjects
      case "FORT_DEPLOY_POKEMON":  return .fortDeployPokemon
      case "FORT_RECALL_POKEMON":  return .fortRecallPokemon
      case "RELEASE_POKEMON":  return .releasePokemon
      case "USE_ITEM_POTION":  return .useItemPotion
      case "USE_ITEM_CAPTURE":  return .useItemCapture
      case "USE_ITEM_FLEE":  return .useItemFlee
      case "USE_ITEM_REVIVE":  return .useItemRevive
      case "TRADE_SEARCH":  return .tradeSearch
      case "TRADE_OFFER":  return .tradeOffer
      case "TRADE_RESPONSE":  return .tradeResponse
      case "TRADE_RESULT":  return .tradeResult
      case "GET_PLAYER_PROFILE":  return .getPlayerProfile
      case "GET_ITEM_PACK":  return .getItemPack
      case "BUY_ITEM_PACK":  return .buyItemPack
      case "BUY_GEM_PACK":  return .buyGemPack
      case "EVOLVE_POKEMON":  return .evolvePokemon
      case "GET_HATCHED_EGGS":  return .getHatchedEggs
      case "ENCOUNTER_TUTORIAL_COMPLETE":  return .encounterTutorialComplete
      case "LEVEL_UP_REWARDS":  return .levelUpRewards
      case "CHECK_AWARDED_BADGES":  return .checkAwardedBadges
      case "USE_ITEM_GYM":  return .useItemGym
      case "GET_GYM_DETAILS":  return .getGymDetails
      case "START_GYM_BATTLE":  return .startGymBattle
      case "ATTACK_GYM":  return .attackGym
      case "RECYCLE_INVENTORY_ITEM":  return .recycleInventoryItem
      case "COLLECT_DAILY_BONUS":  return .collectDailyBonus
      case "USE_ITEM_XP_BOOST":  return .useItemXpBoost
      case "USE_ITEM_EGG_INCUBATOR":  return .useItemEggIncubator
      case "USE_INCENSE":  return .useIncense
      case "GET_INCENSE_POKEMON":  return .getIncensePokemon
      case "INCENSE_ENCOUNTER":  return .incenseEncounter
      case "ADD_FORT_MODIFIER":  return .addFortModifier
      case "DISK_ENCOUNTER":  return .diskEncounter
      case "COLLECT_DAILY_DEFENDER_BONUS":  return .collectDailyDefenderBonus
      case "UPGRADE_POKEMON":  return .upgradePokemon
      case "SET_FAVORITE_POKEMON":  return .setFavoritePokemon
      case "NICKNAME_POKEMON":  return .nicknamePokemon
      case "EQUIP_BADGE":  return .equipBadge
      case "SET_CONTACT_SETTINGS":  return .setContactSettings
      case "GET_ASSET_DIGEST":  return .getAssetDigest
      case "GET_DOWNLOAD_URLS":  return .getDownloadUrls
      case "GET_SUGGESTED_CODENAMES":  return .getSuggestedCodenames
      case "CHECK_CODENAME_AVAILABLE":  return .checkCodenameAvailable
      case "CLAIM_CODENAME":  return .claimCodename
      case "SET_AVATAR":  return .setAvatar
      case "SET_PLAYER_TEAM":  return .setPlayerTeam
      case "MARK_TUTORIAL_COMPLETE":  return .markTutorialComplete
      case "LOAD_SPAWN_POINTS":  return .loadSpawnPoints
      case "ECHO":  return .echo
      case "DEBUG_UPDATE_INVENTORY":  return .debugUpdateInventory
      case "DEBUG_DELETE_PLAYER":  return .debugDeletePlayer
      case "SFIDA_REGISTRATION":  return .sfidaRegistration
      case "SFIDA_ACTION_LOG":  return .sfidaActionLog
      case "SFIDA_CERTIFICATION":  return .sfidaCertification
      case "SFIDA_UPDATE":  return .sfidaUpdate
      case "SFIDA_ACTION":  return .sfidaAction
      case "SFIDA_DOWSER":  return .sfidaDowser
      case "SFIDA_CAPTURE":  return .sfidaCapture
      default: throw ProtocolBuffersError.InvalidProtocolBuffer("Conversion String to Enum has failed.")
      }
    }
    public var debugDescription:String { return getDescription() }
    public var description:String { return getDescription() }
    private func getDescription() -> String { 
        switch self {
            case .methodUnset: return ".MethodUnset"
            case .playerUpdate: return ".PlayerUpdate"
            case .getPlayer: return ".GetPlayer"
            case .getInventory: return ".GetInventory"
            case .downloadSettings: return ".DownloadSettings"
            case .downloadItemTemplates: return ".DownloadItemTemplates"
            case .downloadRemoteConfigVersion: return ".DownloadRemoteConfigVersion"
            case .fortSearch: return ".FortSearch"
            case .encounter: return ".Encounter"
            case .catchPokemon: return ".CatchPokemon"
            case .fortDetails: return ".FortDetails"
            case .itemUse: return ".ItemUse"
            case .getMapObjects: return ".GetMapObjects"
            case .fortDeployPokemon: return ".FortDeployPokemon"
            case .fortRecallPokemon: return ".FortRecallPokemon"
            case .releasePokemon: return ".ReleasePokemon"
            case .useItemPotion: return ".UseItemPotion"
            case .useItemCapture: return ".UseItemCapture"
            case .useItemFlee: return ".UseItemFlee"
            case .useItemRevive: return ".UseItemRevive"
            case .tradeSearch: return ".TradeSearch"
            case .tradeOffer: return ".TradeOffer"
            case .tradeResponse: return ".TradeResponse"
            case .tradeResult: return ".TradeResult"
            case .getPlayerProfile: return ".GetPlayerProfile"
            case .getItemPack: return ".GetItemPack"
            case .buyItemPack: return ".BuyItemPack"
            case .buyGemPack: return ".BuyGemPack"
            case .evolvePokemon: return ".EvolvePokemon"
            case .getHatchedEggs: return ".GetHatchedEggs"
            case .encounterTutorialComplete: return ".EncounterTutorialComplete"
            case .levelUpRewards: return ".LevelUpRewards"
            case .checkAwardedBadges: return ".CheckAwardedBadges"
            case .useItemGym: return ".UseItemGym"
            case .getGymDetails: return ".GetGymDetails"
            case .startGymBattle: return ".StartGymBattle"
            case .attackGym: return ".AttackGym"
            case .recycleInventoryItem: return ".RecycleInventoryItem"
            case .collectDailyBonus: return ".CollectDailyBonus"
            case .useItemXpBoost: return ".UseItemXpBoost"
            case .useItemEggIncubator: return ".UseItemEggIncubator"
            case .useIncense: return ".UseIncense"
            case .getIncensePokemon: return ".GetIncensePokemon"
            case .incenseEncounter: return ".IncenseEncounter"
            case .addFortModifier: return ".AddFortModifier"
            case .diskEncounter: return ".DiskEncounter"
            case .collectDailyDefenderBonus: return ".CollectDailyDefenderBonus"
            case .upgradePokemon: return ".UpgradePokemon"
            case .setFavoritePokemon: return ".SetFavoritePokemon"
            case .nicknamePokemon: return ".NicknamePokemon"
            case .equipBadge: return ".EquipBadge"
            case .setContactSettings: return ".SetContactSettings"
            case .getAssetDigest: return ".GetAssetDigest"
            case .getDownloadUrls: return ".GetDownloadUrls"
            case .getSuggestedCodenames: return ".GetSuggestedCodenames"
            case .checkCodenameAvailable: return ".CheckCodenameAvailable"
            case .claimCodename: return ".ClaimCodename"
            case .setAvatar: return ".SetAvatar"
            case .setPlayerTeam: return ".SetPlayerTeam"
            case .markTutorialComplete: return ".MarkTutorialComplete"
            case .loadSpawnPoints: return ".LoadSpawnPoints"
            case .echo: return ".Echo"
            case .debugUpdateInventory: return ".DebugUpdateInventory"
            case .debugDeletePlayer: return ".DebugDeletePlayer"
            case .sfidaRegistration: return ".SfidaRegistration"
            case .sfidaActionLog: return ".SfidaActionLog"
            case .sfidaCertification: return ".SfidaCertification"
            case .sfidaUpdate: return ".SfidaUpdate"
            case .sfidaAction: return ".SfidaAction"
            case .sfidaDowser: return ".SfidaDowser"
            case .sfidaCapture: return ".SfidaCapture"
        }
    }
  }

  //Enum type declaration end 

  final public class Request : GeneratedMessage, GeneratedMessageProtocol {
    public private(set) var requestType:Pogoprotos.Networking.Requests.RequestType = Pogoprotos.Networking.Requests.RequestType.methodUnset
    public private(set) var hasRequestType:Bool = false
    public private(set) var hasRequestMessage:Bool = false
    public private(set) var requestMessage:Data = Data()

    required public init() {
         super.init()
    }
    override public func isInitialized() -> Bool {
     return true
    }
    override public func writeToCodedOutputStream(_ output:CodedOutputStream) throws {
      if hasRequestType {
        try output.writeEnum(1, value:requestType.rawValue)
      }
      if hasRequestMessage {
        try output.writeData(2, value:requestMessage)
      }
      try unknownFields.writeToCodedOutputStream(output)
    }
    override public func serializedSize() -> Int32 {
      var serialize_size:Int32 = memoizedSerializedSize
      if serialize_size != -1 {
       return serialize_size
      }

      serialize_size = 0
      if (hasRequestType) {
        serialize_size += requestType.rawValue.computeEnumSize(1)
      }
      if hasRequestMessage {
        serialize_size += requestMessage.computeDataSize(2)
      }
      serialize_size += unknownFields.serializedSize()
      memoizedSerializedSize = serialize_size
      return serialize_size
    }
    public class func parseArrayDelimitedFromInputStream(_ input:InputStream) throws -> Array<Pogoprotos.Networking.Requests.Request> {
      var mergedArray = Array<Pogoprotos.Networking.Requests.Request>()
      while let value = try parseFromDelimitedFromInputStream(input) {
        mergedArray += [value]
      }
      return mergedArray
    }
    public class func parseFromDelimitedFromInputStream(_ input:InputStream) throws -> Pogoprotos.Networking.Requests.Request? {
      return try Pogoprotos.Networking.Requests.Request.Builder().mergeDelimitedFromInputStream(input)?.build()
    }
    public class func parseFromData(_ data:Data) throws -> Pogoprotos.Networking.Requests.Request {
      return try Pogoprotos.Networking.Requests.Request.Builder().mergeFromData(data, extensionRegistry:Pogoprotos.Networking.Requests.PogoprotosNetworkingRequestsRoot.sharedInstance.extensionRegistry).build()
    }
    public class func parseFromData(_ data:Data, extensionRegistry:ExtensionRegistry) throws -> Pogoprotos.Networking.Requests.Request {
      return try Pogoprotos.Networking.Requests.Request.Builder().mergeFromData(data, extensionRegistry:extensionRegistry).build()
    }
    public class func parseFromInputStream(_ input:InputStream) throws -> Pogoprotos.Networking.Requests.Request {
      return try Pogoprotos.Networking.Requests.Request.Builder().mergeFromInputStream(input).build()
    }
    public class func parseFromInputStream(_ input:InputStream, extensionRegistry:ExtensionRegistry) throws -> Pogoprotos.Networking.Requests.Request {
      return try Pogoprotos.Networking.Requests.Request.Builder().mergeFromInputStream(input, extensionRegistry:extensionRegistry).build()
    }
    public class func parseFromCodedInputStream(_ input:CodedInputStream) throws -> Pogoprotos.Networking.Requests.Request {
      return try Pogoprotos.Networking.Requests.Request.Builder().mergeFromCodedInputStream(input).build()
    }
    public class func parseFromCodedInputStream(_ input:CodedInputStream, extensionRegistry:ExtensionRegistry) throws -> Pogoprotos.Networking.Requests.Request {
      return try Pogoprotos.Networking.Requests.Request.Builder().mergeFromCodedInputStream(input, extensionRegistry:extensionRegistry).build()
    }
    public class func getBuilder() -> Pogoprotos.Networking.Requests.Request.Builder {
      return Pogoprotos.Networking.Requests.Request.classBuilder() as! Pogoprotos.Networking.Requests.Request.Builder
    }
    public func getBuilder() -> Pogoprotos.Networking.Requests.Request.Builder {
      return classBuilder() as! Pogoprotos.Networking.Requests.Request.Builder
    }
    override public class func classBuilder() -> MessageBuilder {
      return Pogoprotos.Networking.Requests.Request.Builder()
    }
    override public func classBuilder() -> MessageBuilder {
      return Pogoprotos.Networking.Requests.Request.Builder()
    }
    public func toBuilder() throws -> Pogoprotos.Networking.Requests.Request.Builder {
      return try Pogoprotos.Networking.Requests.Request.builderWithPrototype(self)
    }
    public class func builderWithPrototype(_ prototype:Pogoprotos.Networking.Requests.Request) throws -> Pogoprotos.Networking.Requests.Request.Builder {
      return try Pogoprotos.Networking.Requests.Request.Builder().mergeFrom(prototype)
    }
    override public func encode() throws -> Dictionary<String,AnyObject> {
      guard isInitialized() else {
        throw ProtocolBuffersError.InvalidProtocolBuffer("Uninitialized Message")
      }

      var jsonMap:Dictionary<String,AnyObject> = Dictionary<String,AnyObject>()
      if hasRequestType {
        jsonMap["requestType"] = requestType.toString()
      }
      if hasRequestMessage {
        jsonMap["requestMessage"] = requestMessage.base64EncodedString(NSData.Base64EncodingOptions(rawValue: 0))
      }
      return jsonMap
    }
    override class public func decode(_ jsonMap:Dictionary<String,AnyObject>) throws -> Pogoprotos.Networking.Requests.Request {
      return try Pogoprotos.Networking.Requests.Request.Builder.decodeToBuilder(jsonMap).build()
    }
    override class public func fromJSON(_ data:Data) throws -> Pogoprotos.Networking.Requests.Request {
      return try Pogoprotos.Networking.Requests.Request.Builder.fromJSONToBuilder(data).build()
    }
    override public func getDescription(_ indent:String) throws -> String {
      var output = ""
      if (hasRequestType) {
        output += "\(indent) requestType: \(requestType.description)\n"
      }
      if hasRequestMessage {
        output += "\(indent) requestMessage: \(requestMessage) \n"
      }
      output += unknownFields.getDescription(indent)
      return output
    }
    override public var hashValue:Int {
        get {
            var hashCode:Int = 7
            if hasRequestType {
               hashCode = (hashCode &* 31) &+ Int(requestType.rawValue)
            }
            if hasRequestMessage {
               hashCode = (hashCode &* 31) &+ requestMessage.hashValue
            }
            hashCode = (hashCode &* 31) &+  unknownFields.hashValue
            return hashCode
        }
    }


    //Meta information declaration start

    override public class func className() -> String {
        return "Pogoprotos.Networking.Requests.Request"
    }
    override public func className() -> String {
        return "Pogoprotos.Networking.Requests.Request"
    }
    override public func classMetaType() -> GeneratedMessage.Type {
        return Pogoprotos.Networking.Requests.Request.self
    }
    //Meta information declaration end

    final public class Builder : GeneratedMessageBuilder {
      private var builderResult:Pogoprotos.Networking.Requests.Request = Pogoprotos.Networking.Requests.Request()
      public func getMessage() -> Pogoprotos.Networking.Requests.Request {
          return builderResult
      }

      required override public init () {
         super.init()
      }
        public var hasRequestType:Bool{
            get {
                return builderResult.hasRequestType
            }
        }
        public var requestType:Pogoprotos.Networking.Requests.RequestType {
            get {
                return builderResult.requestType
            }
            set (value) {
                builderResult.hasRequestType = true
                builderResult.requestType = value
            }
        }
        public func setRequestType(_ value:Pogoprotos.Networking.Requests.RequestType) -> Pogoprotos.Networking.Requests.Request.Builder {
          self.requestType = value
          return self
        }
        public func clearRequestType() -> Pogoprotos.Networking.Requests.Request.Builder {
           builderResult.hasRequestType = false
           builderResult.requestType = .methodUnset
           return self
        }
      public var hasRequestMessage:Bool {
           get {
                return builderResult.hasRequestMessage
           }
      }
      public var requestMessage:Data {
           get {
                return builderResult.requestMessage
           }
           set (value) {
               builderResult.hasRequestMessage = true
               builderResult.requestMessage = value
           }
      }
      public func setRequestMessage(_ value:Data) -> Pogoprotos.Networking.Requests.Request.Builder {
        self.requestMessage = value
        return self
      }
      public func clearRequestMessage() -> Pogoprotos.Networking.Requests.Request.Builder{
           builderResult.hasRequestMessage = false
           builderResult.requestMessage = Data()
           return self
      }
      override public var internalGetResult:GeneratedMessage {
           get {
              return builderResult
           }
      }
      override public func clear() -> Pogoprotos.Networking.Requests.Request.Builder {
        builderResult = Pogoprotos.Networking.Requests.Request()
        return self
      }
      override public func clone() throws -> Pogoprotos.Networking.Requests.Request.Builder {
        return try Pogoprotos.Networking.Requests.Request.builderWithPrototype(builderResult)
      }
      override public func build() throws -> Pogoprotos.Networking.Requests.Request {
           try checkInitialized()
           return buildPartial()
      }
      public func buildPartial() -> Pogoprotos.Networking.Requests.Request {
        let returnMe:Pogoprotos.Networking.Requests.Request = builderResult
        return returnMe
      }
      public func mergeFrom(_ other:Pogoprotos.Networking.Requests.Request) throws -> Pogoprotos.Networking.Requests.Request.Builder {
        if other == Pogoprotos.Networking.Requests.Request() {
         return self
        }
        if other.hasRequestType {
             requestType = other.requestType
        }
        if other.hasRequestMessage {
             requestMessage = other.requestMessage
        }
        try mergeUnknownFields(other.unknownFields)
        return self
      }
      override public func mergeFromCodedInputStream(_ input:CodedInputStream) throws -> Pogoprotos.Networking.Requests.Request.Builder {
           return try mergeFromCodedInputStream(input, extensionRegistry:ExtensionRegistry())
      }
      override public func mergeFromCodedInputStream(_ input:CodedInputStream, extensionRegistry:ExtensionRegistry) throws -> Pogoprotos.Networking.Requests.Request.Builder {
        let unknownFieldsBuilder:UnknownFieldSet.Builder = try UnknownFieldSet.builderWithUnknownFields(self.unknownFields)
        while (true) {
          let protobufTag = try input.readTag()
          switch protobufTag {
          case 0: 
            self.unknownFields = try unknownFieldsBuilder.build()
            return self

          case 8:
            let valueIntrequestType = try input.readEnum()
            if let enumsrequestType = Pogoprotos.Networking.Requests.RequestType(rawValue:valueIntrequestType){
                 requestType = enumsrequestType
            } else {
                 try unknownFieldsBuilder.mergeVarintField(1, value:Int64(valueIntrequestType))
            }

          case 18:
            requestMessage = try input.readData()

          default:
            if (!(try parseUnknownField(input,unknownFields:unknownFieldsBuilder, extensionRegistry:extensionRegistry, tag:protobufTag))) {
               unknownFields = try unknownFieldsBuilder.build()
               return self
            }
          }
        }
      }
      override class public func decodeToBuilder(_ jsonMap:Dictionary<String,AnyObject>) throws -> Pogoprotos.Networking.Requests.Request.Builder {
        let resultDecodedBuilder = Pogoprotos.Networking.Requests.Request.Builder()
        if let jsonValueRequestType = jsonMap["requestType"] as? String {
          resultDecodedBuilder.requestType = try Pogoprotos.Networking.Requests.RequestType.fromString(jsonValueRequestType)
        }
        if let jsonValueRequestMessage = jsonMap["requestMessage"] as? String {
          resultDecodedBuilder.requestMessage = Data(base64EncodedString:jsonValueRequestMessage, options: NSData.Base64DecodingOptions(rawValue:0))!
        }
        return resultDecodedBuilder
      }
      override class public func fromJSONToBuilder(_ data:Data) throws -> Pogoprotos.Networking.Requests.Request.Builder {
        let jsonData = try JSONSerialization.jsonObject(with: data, options: JSONSerialization.ReadingOptions(rawValue: 0))
        guard let jsDataCast = jsonData as? Dictionary<String,AnyObject> else {
          throw ProtocolBuffersError.InvalidProtocolBuffer("Invalid JSON data")
        }
        return try Pogoprotos.Networking.Requests.Request.Builder.decodeToBuilder(jsDataCast)
      }
    }

  }

}

// @@protoc_insertion_point(global_scope)