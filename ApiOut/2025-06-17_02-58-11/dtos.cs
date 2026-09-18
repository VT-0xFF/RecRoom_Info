// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 267 (plus referenced enums)

// --------------------------------------------------------------------------
// AAKPIFHPPIP
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class AAKPIFHPPIP
{
    public int <AFDPDLNNLOG>k__BackingField;    // 0x0x10
    public int? <LJPMEEDKLIO>k__BackingField;    // 0x0x14
    public string <IPLCDNHBBMF>k__BackingField;    // 0x0x20
    public string <NLBHLGBHFLE>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// ABOOKJLBGCB
//   (not directly referenced by a detected call)
public class ABOOKJLBGCB
{
    public int <PGHMMGLJNDD>k__BackingField;    // 0x0x10
    public ADJFCIILLIO <BMPOOMCPDMA>k__BackingField;    // 0x0x14
    public List<DJOKEHBONLO> <JFFHBHCCILO>k__BackingField;    // 0x0x18
    public List<DJOKEHBONLO> <EGFJONEPEKO>k__BackingField;    // 0x0x20
    public bool <OCHCIMNHAEE>k__BackingField;    // 0x0x28
    public DateTime? <IMIGIADICGO>k__BackingField;    // 0x0x30
    public DateTime? <DEJAJNAJMNB>k__BackingField;    // 0x0x40
    public DateTime? <EFDAKHLJLHG>k__BackingField;    // 0x0x50
    public bool <CDGJAEPFPIE>k__BackingField;    // 0x0x60
    public bool <NPDEPAPOLHE>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// ACDDJDNBNMN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ACDDJDNBNMN
{
    Unknown = -1,
    Success = 0,
    FeatureDisabled = 1,
    ConsumableUnderModeration = 2,
    RoomConsumableIdMismatch = 3,
    RoomConsumableNotFound = 4,
    ImageDoesNotExist = 5,
    AccountIdInvalid = 6,
    PlayerDoesntHavePermission = 7,
    PlayerIsNotBetaMember = 8,
    PlayerIsNotRRPMember = 9,
    PlayerIsP2PSellingRestricted = 10,
    PlayerIsJuniorAccount = 11,
    PlayerUnderModeration = 12,
    MaxConsumablesInRoom = 13,
    RoomIdMismatch = 14,
    RoomIdMissing = 15,
    RoomIdInvalid = 16,
    PriceOrCurrencyMissing = 17,
    CurrencyNotFound = 18,
    PriceTooLowCurrency = 19,
    PriceTooHighCurrency = 20,
    PriceTooLowTokens = 21,
    PriceTooHighTokens = 22,
    NameTooShort = 23,
    NameTooLong = 24,
    NameHasInvalidCharacters = 25,
    DescriptionTooShort = 26,
    DescriptionTooLong = 27,
    DescriptionHasInvalidCharacters = 28,
    DuplicateName = 29,
    InappropriateName = 30,
    InappropriateDescription = 31,
    ConcurrencyCodeMismatch = 32,
    PlayerDoesNotOwnConsumable = 33,
    OwnershipLimitExceeded = 34,
    PurchaseFailed = 35,
    RoomNotFound = 36,
    RoomUnderModeration = 37,
    RequestedPriceDoesNotMatch = 38,
    RequestedCurrencyDoesNotMatch = 39,
    ConsumableCannotBePurchasedWithRoomCurrency = 40,
    ConsumableCannotBePurchasedWithTokens = 41,
    PlayerIsP2PBuyingRestricted = 42,
    AwardAmountIsInvalid = 43,
    ConsumableCannotBeAwarded = 44,
    PlayerHasReachedAwardLimit = 45,
    AwardLimitIsInvalid = 46,
}

// --------------------------------------------------------------------------
// ADJFCIILLIO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ADJFCIILLIO
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// AEBJGFFALND
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AEBJGFFALND
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// AECHMPJHLHP
//   RESPONSE GET    api/makerai/freetrialconfig   [Service.Econ]
public class AECHMPJHLHP
{
    public TimeSpan <JDJHJGJLOJL>k__BackingField;    // 0x0x10
    public TimeSpan <LIODEMHFGKB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AGDFEAPMAIG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AGDFEAPMAIG
{
    Success = 0,
    HasModeratorClosedEvent = 1,
    DoesNotExist = 2,
    PlayerDoesNotExist = 3,
    RoomDoesNotExist = 4,
    StatusUnchanged = 5,
    PrivateEvent = 6,
    SomethingWentWrong = 7,
    DoesNotOwnRoom = 8,
    ResponseDoesNotExist = 9,
    PlayerAlreadyInvited = 10,
    EventDatesInvalid = 11,
    EventTooLong = 12,
    EventTooShort = 13,
    InappropriateName = 14,
    InappropriateDescription = 15,
    SomeInvitesFailed = 16,
    CannotInviteJunior = 17,
    EventCountLimitReached = 18,
    DoesNotOwnEvent = 19,
    UnregisteredOrJuniorNotAllowed = 20,
    InvalidClubPermissions = 21,
    ImageDoesNotExist = 22,
    SubRoomDoesNotExist = 23,
    DoesNotOwnSubRoom = 24,
    ModifyTagsFailed = 25,
    RoomCapacityTooLow = 26,
    BroadcastEventNotMultiInstance = 27,
    PlayerNotAllowedToCreateMultiInstanceEvents = 28,
    PlayerBannedFromEventCreation = 29,
    EventIsModerationClosed = 30,
    EventIsModerationPendingReview = 31,
    InvalidRecurringEventSchedule = 32,
    EventIsInModerationBlockedRoom = 33,
    JuniorsCannotCreateEvents = 34,
}

// --------------------------------------------------------------------------
// AGHPNEOHJOF
//   (not directly referenced by a detected call)
public class AGHPNEOHJOF
{
    public MCLHCIINKEC <BMPOOMCPDMA>k__BackingField;    // 0x0x10
    public int? <CCPLIDEFFFB>k__BackingField;    // 0x0x14
    public Guid? <KDMANNNBPLD>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// AICGNNCALDO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AICGNNCALDO
{
    Default = -1,
    FirstSessionOfDay = 1,
    AddAFriend = 2,
    PartyUp = 3,
    AllOtherChallenges = 4,
    LevelUp = 5,
    CheerAPlayer = 6,
    PointedAtPlayer = 7,
    CheerARoom = 8,
    SubscribeToPlayer = 9,
    DailyObjective1 = 10,
    DailyObjective2 = 11,
    DailyObjective3 = 12,
    AllDailyObjectives = 13,
    CompleteAnyDaily = 14,
    CompleteAnyWeekly = 15,
    OOBE_GoToLockerRoom = 20,
    OOBE_GoToActivity = 21,
    OOBE_FinishActivity = 22,
    NUX_PunchcardObjective = 25,
    NUX_AllPunchcardObjectives = 26,
    GoToRecCenter = 30,
    FinishActivity = 31,
    VisitACustomRoom = 32,
    CreateACustomRoom = 33,
    ScoreBasketInRecCenter = 35,
    UploadPhotoToRecNet = 36,
    UpdatePlayerBio = 37,
    SaveOutfitSlot = 38,
    PurchaseClothingItem = 39,
    PurchaseNonClothingItem = 40,
    DrinkWater = 41,
    ColorOnWhiteboard = 42,
    SetBasketballSkin = 43,
    ThrowBasketball = 44,
    PlaceInventionInDorm = 45,
    ChangeDormRoomSkin = 46,
    ToggleOwnedClothes = 47,
    EquipHat = 48,
    LoadOutfit = 49,
    SaveNewOutfitSlot = 50,
    SpawnCamera = 51,
    TakeSelfie = 52,
    PrintSelfie = 53,
    TakePictureOfPlayer = 54,
    PrintPictureOfPlayer = 55,
    PublishSelfieWithPlayer = 56,
    SpawnFoodWithOtherPlayers = 57,
    EmoteInRecCenter = 58,
    SendRoomChatInRecCenter = 59,
    UseFrendotron = 60,
    GoToDormRoom = 61,
    VisitSpecificRoom = 62,
    VisitPublicRRO = 63,
    VisitPublicRoomBySource = 64,
    FavoriteARoom = 65,
    TakePhotoWithFilter = 66,
    OpenYourPlayerProfile = 67,
    OpenOnlineStatusModal = 68,
    ChangeProfilePicture = 69,
    ChangePlayerDisplayName = 70,
    ChangePlayerDescriptionText = 71,
    OpenPlayerPronounsModal = 72,
    OpenOtherPlayersProfile = 73,
    VisitPlayersPortfolio = 74,
    FavoriteAFriend = 75,
    CharadesGames = 100,
    CharadesWinsPerformer = 101,
    CharadesWinsGuesser = 102,
    DiscGolfWins = 200,
    DiscGolfGames = 201,
    DiscGolfHolesUnderPar = 202,
    DodgeballWins = 300,
    DodgeballGames = 301,
    DodgeballHits = 302,
    PaddleballGames = 400,
    PaddleballWins = 401,
    PaddleballScores = 402,
    PaintballAnyModeGames = 500,
    PaintballAnyModeWins = 501,
    PaintballAnyModeHits = 502,
    PaintballCTFWins = 600,
    PaintballCTFGames = 601,
    PaintballCTFHits = 602,
    PaintballFlagCaptures = 603,
    PaintballTeamBattleWins = 700,
    PaintballTeamBattleGames = 701,
    PaintballTeamBattleHits = 702,
    PaintballFreeForAllWins = 710,
    PaintballFreeForAllGames = 711,
    PaintballFreeForAllHits = 712,
    SoccerWins = 800,
    SoccerGames = 801,
    SoccerGoals = 802,
    BowlingGames = 900,
    BowlingWins = 901,
    BowlingStrike = 902,
    QuestGames = 1000,
    QuestWins = 1001,
    QuestPlayerRevives = 1002,
    QuestEnemyKills = 1003,
    QuestGames_Goblin1 = 1010,
    QuestWins_Goblin1 = 1011,
    QuestPlayerRevives_Goblin1 = 1012,
    QuestEnemyKills_Goblin1 = 1013,
    QuestGames_Goblin2 = 1020,
    QuestWins_Goblin2 = 1021,
    QuestPlayerRevives_Goblin2 = 1022,
    QuestEnemyKills_Goblin2 = 1023,
    QuestGames_Scifi1 = 1030,
    QuestWins_Scifi1 = 1031,
    QuestPlayerRevives_Scifi1 = 1032,
    QuestEnemyKills_Scifi1 = 1033,
    QuestGames_Pirate1 = 1040,
    QuestWins_Pirate1 = 1041,
    QuestPlayerRevives_Pirate1 = 1042,
    QuestEnemyKills_Pirate1 = 1043,
    QuestGames_Dracula1 = 1050,
    QuestWins_Dracula1 = 1051,
    QuestPlayerRevives_Dracula1 = 1052,
    QuestEnemyKills_Dracula1 = 1053,
    ArenaGames = 2000,
    ArenaWins = 2001,
    ArenaPlayerRevives = 2002,
    ArenaHeroTags = 2003,
    ArenaBotTags = 2004,
    RecRoyaleGames = 3000,
    RecRoyaleWins = 3001,
    RecRoyaleTags = 3002,
    StuntRunnerGames = 4000,
    StuntRunnerWins = 4001,
    RecRallyGames = 5000,
    RecRallyWins = 5001,
}

// --------------------------------------------------------------------------
// AJJDHKPEBNH
// base   : FKGLKKIGGFP
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class AJJDHKPEBNH : FKGLKKIGGFP
{
    public IJEPKJKKOIJ? <OODGJHFBOGH>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <HMFNOGOBIBA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AJNCPCIEDIC
//   (not directly referenced by a detected call)
public class AJNCPCIEDIC
{
    public int <HNEBICBGJDB>k__BackingField;    // 0x0x10
    public DateTime <CHIPLNCOLHP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AOEGDAOBNAP
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class AOEGDAOBNAP
{
    public Guid? <LGNEJFGBAHA>k__BackingField;    // 0x0x10
    public long? <ECKOGOFIIPH>k__BackingField;    // 0x0x28
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x38
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x40
    public string <JJJJGJNODDP>k__BackingField;    // 0x0x48
    public HPBFANMGDAG <JKINHNJOJMA>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// APMHFDGFEBL
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class APMHFDGFEBL
{
    public string <FIODBMLENOF>k__BackingField;    // 0x0x10
    public string <BBAFELOGILE>k__BackingField;    // 0x0x18
    public string <EBFPMOGDCGP>k__BackingField;    // 0x0x20
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x28
    public string <NKAPHPJKJPE>k__BackingField;    // 0x0x30
    public KADABDADOKL <ILHPMNDBDKC>k__BackingField;    // 0x0x38
    public List<string> <BLFMOICCCBF>k__BackingField;    // 0x0x40
    public List<string> <CIFPGGPGJEL>k__BackingField;    // 0x0x48
    public string <ELLJLDILNOF>k__BackingField;    // 0x0x50
    public List<FMIHFKHBDPN> <FADLDBOGFMG>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// APOHLMNLEFG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum APOHLMNLEFG
{
    NonPurchasedNotUsableInP2P = -2,
    NonPurchasedDefault = -1,
    SteamPurchased = 0,
    OculusPurchased = 1,
    PlayStationPurchased = 2,
    MicrosoftPurchased = 3,
    RecNetPurchased = 4,
    IOSPurchased = 5,
    GooglePlayPurchased = 6,
    PicoPurchased = 8,
    SwitchPurchased = 9,
    PlayStationNonPurchasedP2P = 100,
    NonPlayStationNonPurchasedP2P = 101,
    NonPurchasedEarnedByP2P = 1000,
    NonPurchasedEarnedByP2Pv2 = 1001,
}

// --------------------------------------------------------------------------
// BHEBLMOAPJP
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.Econ]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.Econ]
//   RESPONSE GET    api/avatar/v4/items   [Service.Econ]
public class BHEBLMOAPJP
{
    public AEBJGFFALND <DEGCBFGCMKF>k__BackingField;    // 0x0x10
    public string <DPMBMFNLCJG>k__BackingField;    // 0x0x18
    public string <MCLCFJHNNPE>k__BackingField;    // 0x0x20
    public string <MLNFCNFONPL>k__BackingField;    // 0x0x28
    public NPOPGDKCOBH <IBGLJEHGMKE>k__BackingField;    // 0x0x30
    public string <AFPCLILCGIH>k__BackingField;    // 0x0x38
    public int <PDIGJMNLKLG>k__BackingField;    // 0x0x40
    public bool <FBKIMOLHJAG>k__BackingField;    // 0x0x44
    public string <KKFGHIPPPAF>k__BackingField;    // 0x0x48
    public DateTime <MOLGCMPAHCL>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// BIHDAAKIALA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BIHDAAKIALA
{
    RoomKey = 0,
    RoomConsumable = 1,
    RoomCurrencyPurchaseOffer = 2,
    CustomAvatarItem = 3,
    StoreUGCAvatarItem = 4,
    UNDEFINED = 5,
}

// --------------------------------------------------------------------------
// BNIFAHGCPKG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BNIFAHGCPKG
{
    Invalid = 0,
    LaserTagTickets = 1,
    RecCenterTokens = 2,
    LostSkullsGold = 100,
    DraculaSilver = 101,
    RecRoyale_Season1 = 200,
    RoomCurrency = 300,
    RoomInventoryItem = 301,
    ProgressionEvent = 400,
}

// --------------------------------------------------------------------------
// BNPOPJMGFNP
//   (not directly referenced by a detected call)
public class BNPOPJMGFNP
{
    public int <NJMNJKAIEIA>k__BackingField;    // 0x0x10
    public string <MCLCFJHNNPE>k__BackingField;    // 0x0x18
    public string <MLNFCNFONPL>k__BackingField;    // 0x0x20
    public string <AFPCLILCGIH>k__BackingField;    // 0x0x28
    public string <OEKHJGNHIJE>k__BackingField;    // 0x0x30
    public OAJMHFIAABF? <CNNPMKDNNNL>k__BackingField;    // 0x0x38
    public string <NCGAFCLHNIF>k__BackingField;    // 0x0x70
    public Guid? <OCNKBDNKLKG>k__BackingField;    // 0x0x78
    public AEBJGFFALND? <DEGCBFGCMKF>k__BackingField;    // 0x0x8C
    public string <CGFPOJKIBKD>k__BackingField;    // 0x0x98
    public string <BDIANBHJPPM>k__BackingField;    // 0x0xA0
    public bool <DJHLGBLEEOK>k__BackingField;    // 0x0xA8
    public bool <KNNKHIKIAOA>k__BackingField;    // 0x0xA9
    public bool <NBPHJEGNJNG>k__BackingField;    // 0x0xAA
    public NPOPGDKCOBH <IBGLJEHGMKE>k__BackingField;    // 0x0xAC
    public BNIFAHGCPKG <KDIMBONFBPE>k__BackingField;    // 0x0xB0
    public int <LKLAMKOBLMB>k__BackingField;    // 0x0xB4
    public MFCBDHILCNM <INNLKBKNMFA>k__BackingField;    // 0x0xB8
    public GJCFPCHPCFH <DFPHMCCPBAB>k__BackingField;    // 0x0xBC
    public int? <MJHFIEGBMLN>k__BackingField;    // 0x0xC0
    public string <ABCJDEICOEF>k__BackingField;    // 0x0xC8
    public int? <PDIGJMNLKLG>k__BackingField;    // 0x0xD0
    public int? <HBCPNFMOCEJ>k__BackingField;    // 0x0xD8
    public string <DJELNEHOCJO>k__BackingField;    // 0x0xE0
}

// --------------------------------------------------------------------------
// BOHNLAOMCDN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BOHNLAOMCDN
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// Backtrace.Unity.Model.BacktraceResult
//   (not directly referenced by a detected call)
public class BacktraceResult
{
    public string message;    // 0x0x10
    public string response;    // 0x0x18
    public BacktraceResultStatus Status;    // 0x0x20
    public string _rxId;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.HTTPRequest
//   (not directly referenced by a detected call)
public class HTTPRequest
{
    public Uri <Uri>k__BackingField;    // 0x0x10
    public HTTPMethods <MethodType>k__BackingField;    // 0x0x18
    public byte[] <RawData>k__BackingField;    // 0x0x20
    public Stream <UploadStream>k__BackingField;    // 0x0x28
    public bool <DisposeUploadStream>k__BackingField;    // 0x0x30
    public bool <UseUploadStreamLength>k__BackingField;    // 0x0x31
    public OnUploadProgressDelegate OnUploadProgress;    // 0x0x38
    public int <MaxFragmentQueueLength>k__BackingField;    // 0x0x40
    public OnRequestFinishedDelegate <Callback>k__BackingField;    // 0x0x48
    public OnDownloadProgressDelegate OnProgress;    // 0x0x50
    public OnRequestFinishedDelegate OnUpgraded;    // 0x0x58
    public bool <DisableRetry>k__BackingField;    // 0x0x60
    public bool <IsRedirected>k__BackingField;    // 0x0x61
    public Uri <RedirectUri>k__BackingField;    // 0x0x68
    public HTTPResponse <Response>k__BackingField;    // 0x0x70
    public HTTPResponse <ProxyResponse>k__BackingField;    // 0x0x78
    public Exception <Exception>k__BackingField;    // 0x0x80
    public object <Tag>k__BackingField;    // 0x0x88
    public Credentials <Credentials>k__BackingField;    // 0x0x90
    public Proxy <Proxy>k__BackingField;    // 0x0x98
    public int <MaxRedirects>k__BackingField;    // 0x0xA0
    public bool <UseAlternateSSL>k__BackingField;    // 0x0xA4
    public bool <IsCookiesEnabled>k__BackingField;    // 0x0xA5
    public List<Cookie> customCookies;    // 0x0xA8
    public HTTPFormUsage <FormUsage>k__BackingField;    // 0x0xB0
    public HTTPRequestStates <State>k__BackingField;    // 0x0xB4
    public int <RedirectCount>k__BackingField;    // 0x0xB8
    public Func<HTTPRequest, X509Certificate, X509Chain, bool> CustomCertificationValidator;    // 0x0xC0
    public TimeSpan <ConnectTimeout>k__BackingField;    // 0x0xC8
    public TimeSpan <Timeout>k__BackingField;    // 0x0xD0
    public bool <EnableTimoutForStreaming>k__BackingField;    // 0x0xD8
    public bool <EnableSafeReadOnUnknownContentLength>k__BackingField;    // 0x0xD9
    public int <Priority>k__BackingField;    // 0x0xDC
    public ICertificateVerifyer <CustomCertificateVerifyer>k__BackingField;    // 0x0xE0
    public IClientCredentialsProvider <CustomClientCredentialsProvider>k__BackingField;    // 0x0xE8
    public List<string> <CustomTLSServerNameList>k__BackingField;    // 0x0xF0
    public SupportedProtocols <ProtocolHandler>k__BackingField;    // 0x0xF8
    public OnBeforeRedirectionDelegate onBeforeRedirection;    // 0x0x100
    public OnBeforeHeaderSendDelegate _onBeforeHeaderSend;    // 0x0x108
    public Action<HTTPRequest, Stream> OnSendingHeaders;    // 0x0x110
    public bool <TryToMinimizeTCPLatency>k__BackingField;    // 0x0x118
    public long <Downloaded>k__BackingField;    // 0x0x120
    public long <DownloadLength>k__BackingField;    // 0x0x128
    public bool <DownloadProgressChanged>k__BackingField;    // 0x0x130
    public long <Uploaded>k__BackingField;    // 0x0x138
    public long <UploadLength>k__BackingField;    // 0x0x140
    public bool <UploadProgressChanged>k__BackingField;    // 0x0x148
    public bool isKeepAlive;    // 0x0x149
    public bool disableCache;    // 0x0x14A
    public bool cacheOnly;    // 0x0x14B
    public int streamFragmentSize;    // 0x0x14C
    public bool useStreaming;    // 0x0x150
    public Dictionary<string, List<string>> <Headers>k__BackingField;    // 0x0x158
    public HTTPFormBase FieldCollector;    // 0x0x160
    public HTTPFormBase FormImpl;    // 0x0x168
}

// --------------------------------------------------------------------------
// BestHTTP.HTTPResponse
//   (not directly referenced by a detected call)
public class HTTPResponse
{
    public int <VersionMajor>k__BackingField;    // 0x0x10
    public int <VersionMinor>k__BackingField;    // 0x0x14
    public int <StatusCode>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
    public bool <IsStreamed>k__BackingField;    // 0x0x28
    public bool <IsStreamingFinished>k__BackingField;    // 0x0x29
    public bool <IsFromCache>k__BackingField;    // 0x0x2A
    public HTTPCacheFileInfo <CacheFileInfo>k__BackingField;    // 0x0x30
    public bool <IsCacheOnly>k__BackingField;    // 0x0x38
    public Dictionary<string, List<string>> <Headers>k__BackingField;    // 0x0x40
    public byte[] <Data>k__BackingField;    // 0x0x48
    public int <DataLength>k__BackingField;    // 0x0x50
    public bool <IsUpgraded>k__BackingField;    // 0x0x54
    public List<Cookie> <Cookies>k__BackingField;    // 0x0x58
    public string dataAsText;    // 0x0x60
    public Texture2D texture;    // 0x0x68
    public bool <IsClosedManually>k__BackingField;    // 0x0x70
    public HTTPRequest baseRequest;    // 0x0x78
    public Stream HeaderStream;    // 0x0x80
    public Stream BodyStream;    // 0x0x88
    public List<ValueTuple<byte[], int>> streamedFragments;    // 0x0x90
    public object SyncRoot;    // 0x0x98
    public byte[] fragmentBuffer;    // 0x0xA0
    public int fragmentBufferDataLength;    // 0x0xA8
    public Stream cacheStream;    // 0x0xB0
    public int allFragmentSize;    // 0x0xB8
    public BufferPoolMemoryStream decompressorInputStream;    // 0x0xC0
    public BufferPoolMemoryStream decompressorOutputStream;    // 0x0xC8
    public GZipStream decompressorGZipStream;    // 0x0xD0
    public AutoResetEvent fragmentWaitEvent;    // 0x0xD8
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CertResponse
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class CertResponse : Asn1Encodable
{
    public DerInteger certReqId;    // 0x0x10
    public PkiStatusInfo status;    // 0x0x18
    public CertifiedKeyPair certifiedKeyPair;    // 0x0x20
    public Asn1OctetString rspInfo;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class CertRequest : Asn1Encodable
{
    public DerInteger certReqId;    // 0x0x10
    public CertTemplate certTemplate;    // 0x0x18
    public Controls controls;    // 0x0x20
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class BasicOcspResponse : Asn1Encodable
{
    public ResponseData tbsResponseData;    // 0x0x10
    public AlgorithmIdentifier signatureAlgorithm;    // 0x0x18
    public DerBitString signature;    // 0x0x20
    public Asn1Sequence certs;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class OcspRequest : Asn1Encodable
{
    public TbsRequest tbsRequest;    // 0x0x10
    public Signature optionalSignature;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.OcspResponse
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class OcspResponse : Asn1Encodable
{
    public OcspResponseStatus responseStatus;    // 0x0x10
    public ResponseBytes responseBytes;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.Request
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class Request : Asn1Encodable
{
    public CertID reqCert;    // 0x0x10
    public X509Extensions singleRequestExtensions;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.SingleResponse
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class SingleResponse : Asn1Encodable
{
    public CertID certID;    // 0x0x10
    public CertStatus certStatus;    // 0x0x18
    public DerGeneralizedTime thisUpdate;    // 0x0x20
    public DerGeneralizedTime nextUpdate;    // 0x0x28
    public X509Extensions singleExtensions;    // 0x0x30
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.TbsRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class TbsRequest : Asn1Encodable
{
    public DerInteger version;    // 0x0x10
    public GeneralName requestorName;    // 0x0x18
    public Asn1Sequence requestList;    // 0x0x20
    public X509Extensions requestExtensions;    // 0x0x28
    public bool versionSet;    // 0x0x30
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.CertificationRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable
//   (not directly referenced by a detected call)
public class CertificationRequest : Asn1Encodable
{
    public CertificationRequestInfo reqInfo;    // 0x0x10
    public AlgorithmIdentifier sigAlgId;    // 0x0x18
    public DerBitString sigBits;    // 0x0x20
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockResult
//   (not directly referenced by a detected call)
public class IBlockResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.DefaultSignatureResult
//   (not directly referenced by a detected call)
public class DefaultSignatureResult
{
    public ISigner mSigner;    // 0x0x10
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.DefaultVerifierResult
//   (not directly referenced by a detected call)
public class DefaultVerifierResult
{
    public ISigner mSigner;    // 0x0x10
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.CertificateRequest
//   (not directly referenced by a detected call)
public class CertificateRequest
{
    public byte[] mCertificateTypes;    // 0x0x10
    public IList mSupportedSignatureAlgorithms;    // 0x0x18
    public IList mCertificateAuthorities;    // 0x0x20
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest
//   (not directly referenced by a detected call)
public class CertificateStatusRequest
{
    public byte mStatusType;    // 0x0x10
    public object mRequest;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.OcspStatusRequest
//   (not directly referenced by a detected call)
public class OcspStatusRequest
{
    public IList mResponderIDList;    // 0x0x10
    public X509Extensions mRequestExtensions;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.CertificationRequest
//   (not directly referenced by a detected call)
public class Pkcs10CertificationRequest : CertificationRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPathBuilderResult
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPathValidatorResult
//   (not directly referenced by a detected call)
public class PkixCertPathBuilderResult : PkixCertPathValidatorResult
{
    public PkixCertPath certPath;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix.PkixCertPathValidatorResult
//   (not directly referenced by a detected call)
public class PkixCertPathValidatorResult
{
    public TrustAnchor trustAnchor;    // 0x0x10
    public PkixPolicyNode policyTree;    // 0x0x18
    public AsymmetricKeyParameter subjectPublicKey;    // 0x0x20
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampRequest
// base   : BestHTTP.SecureProtocol.Org.BouncyCastle.X509.X509ExtensionBase
//   (not directly referenced by a detected call)
public class TimeStampRequest : X509ExtensionBase
{
    public TimeStampReq req;    // 0x0x10
    public X509Extensions extensions;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp.TimeStampResponse
//   (not directly referenced by a detected call)
public class TimeStampResponse
{
    public TimeStampResp resp;    // 0x0x10
    public TimeStampToken timeStampToken;    // 0x0x18
}

// --------------------------------------------------------------------------
// BestHTTP.SignalRCore.Messages.NegotiationResult
//   (not directly referenced by a detected call)
public class NegotiationResult
{
    public string <ConnectionId>k__BackingField;    // 0x0x10
    public List<SupportedTransport> <SupportedTransports>k__BackingField;    // 0x0x18
    public Uri <Url>k__BackingField;    // 0x0x20
    public string <AccessToken>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// BestHTTP.WebSocket.WebSocketResponse
// base   : BestHTTP.HTTPResponse
//   (not directly referenced by a detected call)
public class WebSocketResponse : HTTPResponse
{
    public WebSocket <WebSocket>k__BackingField;    // 0x0xE0
    public Action<WebSocketResponse, string> OnText;    // 0x0xE8
    public Action<WebSocketResponse, byte[]> OnBinary;    // 0x0xF0
    public Action<WebSocketResponse, WebSocketFrameReader> OnIncompleteFrame;    // 0x0xF8
    public Action<WebSocketResponse, ushort, string> OnClosed;    // 0x0x100
    public TimeSpan <PingFrequnecy>k__BackingField;    // 0x0x108
    public ushort <MaxFragmentSize>k__BackingField;    // 0x0x110
    public int _bufferedAmount;    // 0x0x114
    public int <Latency>k__BackingField;    // 0x0x118
    public List<WebSocketFrameReader> IncompleteFrames;    // 0x0x120
    public List<WebSocketFrameReader> CompletedFrames;    // 0x0x128
    public List<WebSocketFrameReader> frameCache;    // 0x0x130
    public WebSocketFrameReader CloseFrame;    // 0x0x138
    public object FrameLock;    // 0x0x158
    public object SendLock;    // 0x0x160
    public List<WebSocketFrame> unsentFrames;    // 0x0x168
    public AutoResetEvent newFrameSignal;    // 0x0x170
    public bool sendThreadCreated;    // 0x0x178
    public bool closeSent;    // 0x0x179
    public bool closed;    // 0x0x17A
    public DateTime lastPing;    // 0x0x180
    public DateTime lastMessage;    // 0x0x188
    public CircularBuffer<int> rtts;    // 0x0x190
}

// --------------------------------------------------------------------------
// CEDFMCBFDGK
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.API]
public class CEDFMCBFDGK
{
    public List<long> <LBLNALAIKBL>k__BackingField;    // 0x0x10
    public GBPCMLAKICH <BMPOOMCPDMA>k__BackingField;    // 0x0x18
    public string <AAPPACEJGPK>k__BackingField;    // 0x0x20
    public long? <ECKOGOFIIPH>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// CGFCGHKMEJH
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.Econ]
public class CGFCGHKMEJH
{
    public long <ONBAEHHFMMM>k__BackingField;    // 0x0x10
    public int <KHHBPNKMNIB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CJCOLJEKBPE
//   (not directly referenced by a detected call)
public class CJCOLJEKBPE
{
    public Guid <LGNEJFGBAHA>k__BackingField;    // 0x0x10
    public int <KHHBPNKMNIB>k__BackingField;    // 0x0x20
    public int <FHLCLAIEIKD>k__BackingField;    // 0x0x24
    public Guid <OELGOMNOCHB>k__BackingField;    // 0x0x28
    public DateTime <EDCBENFACMP>k__BackingField;    // 0x0x38
    public NMDBPFKOJLP <HIIJBPHKJJG>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// CJNIIBMFNAC
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Auth]
public class CJNIIBMFNAC
{
    public Guid <HHNOEHHHCGP>k__BackingField;    // 0x0x10
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x20
    public string <JJJJGJNODDP>k__BackingField;    // 0x0x28
    public DateTime <POBJMJABHFG>k__BackingField;    // 0x0x30
    public DateTime? <DCFJIIDMGAL>k__BackingField;    // 0x0x38
    public List<JLPOHMLHEKA> <JFDHEAOLPIH>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// CMFLFMNCNHN
//   REQUEST  POST   api/playerevents/v1/report   [Service.API]
public class CMFLFMNCNHN
{
    public CGCFJIMPBOK <MNKCDEOONHI>k__BackingField;    // 0x0x10
    public long <BKDLEDHCEKE>k__BackingField;    // 0x0x18
    public string <PLCDDMBGBPF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CODCBNLCDGF
//   RESPONSE PUT    api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class CODCBNLCDGF
{
    public RoomKeyResult <ILHPMNDBDKC>k__BackingField;    // 0x0x10
    public DGHODMEOHEL <LOLNAGJLLDL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CODNEFMDLIN
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class CODNEFMDLIN : ValueType
{
    public Guid FNKCCICOAII;    // 0x0x0
}

// --------------------------------------------------------------------------
// DGAJDHHBHCK
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class DGAJDHHBHCK : ValueType
{
    public Guid FNKCCICOAII;    // 0x0x0
}

// --------------------------------------------------------------------------
// DGHODMEOHEL
//   (not directly referenced by a detected call)
public class DGHODMEOHEL
{
    public long <ONBAEHHFMMM>k__BackingField;    // 0x0x10
    public Guid <CMDNCIJLEDI>k__BackingField;    // 0x0x18
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x28
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x30
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x38
    public int <NLIDGLBHCOL>k__BackingField;    // 0x0x40
    public Guid? <ENJKGGJNBOE>k__BackingField;    // 0x0x44
    public DateTime <MOLGCMPAHCL>k__BackingField;    // 0x0x58
    public string <JJJJGJNODDP>k__BackingField;    // 0x0x60
    public BOHNLAOMCDN <BMPOOMCPDMA>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// DHNJIOCLMBE
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class DHNJIOCLMBE
{
    public List<LECHAIBKJDM> <HGBDFIGOLIJ>k__BackingField;    // 0x0x10
    public string <CNOLFBGHACB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DICMCJNMPLD
//   REQUEST  POST   api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class DICMCJNMPLD
{
    public Guid <EMNLNHLAADC>k__BackingField;    // 0x0x10
    public long <KIOKGIFHBGH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DJOKEHBONLO
//   (not directly referenced by a detected call)
public class DJOKEHBONLO
{
    public BNIFAHGCPKG <KDIMBONFBPE>k__BackingField;    // 0x0x10
    public int <NLIDGLBHCOL>k__BackingField;    // 0x0x14
    public FOLJPDJHLMJ <BIINHALBDDN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DKNOJIFCMEL
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class DKNOJIFCMEL
{
    public List<GDHOEIIDDOP> <CIFPGGPGJEL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DLCBOABCOBP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DLCBOABCOBP
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// DLDGCOKNLDA
// base   : CCCPHJMMHPK`1<GNDDLPACFNL>
//   RESPONSE GET    api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{aBKNJGDDAOJ}   [Service.API]
public class DLDGCOKNLDA
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// DLNFAAIBFGE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DLNFAAIBFGE
{
    Invalid = 0,
    DirectBalanceWithMultiplier = 1,
    FromGiftBox = 2,
    NUXChallenge = 10,
    AllNUXChallenges = 11,
    DailyChallenge = 100,
    AllDailyChallenges = 101,
    FinishActivity = 200,
    RecRoyaleMatchFinished = 250,
    ChecklistCredit = 303,
    WonGame = 1000,
    LostGame = 1001,
    WonGameRateLimited = 1002,
    WonGamePartial = 1003,
    LevelUp = 1100,
    Registered = 1200,
    CreatorReward = 1300,
    CommercePurchase = 1400,
    CommercePurchaseRevoked = 1401,
    Manual_Refund = 2000,
    Manual_Thanks = 2010,
    Manual_Apology = 2020,
    TestOnly = 8000,
}

// --------------------------------------------------------------------------
// DMLFIKABMGJ
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{lCFGHMPEGEJ}   [Service.API]
//   RESPONSE POST   api/playerevents/v2/{eventId}   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/accessibility   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/club   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/description   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/image   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/multiinstance   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/name   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/room   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/tags   [Service.API]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/time   [Service.API]
public class DMLFIKABMGJ
{
    public PNLMANAAGMB <LDDGILGICED>k__BackingField;    // 0x0x10
    public AGDFEAPMAIG <CNMDPCMOGGA>k__BackingField;    // 0x0x18
    public LELOMAPPNPF <IOGJKFPADJB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EENJJODKHGK
//   REQUEST  POST   api/items/purchaseInfos   [Service.Econ]
public class EENJJODKHGK
{
    public IReadOnlyList<LIOFNINKJIN> <BGKHPNOMHNJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// EFGBAPEPDDK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EFGBAPEPDDK
{
    Success = 0,
    TooManyTags = 1,
    TagUseRestricted = 2,
    InvalidTag = 3,
    InappropriateTag = 4,
    TagTooLong = 5,
    TagNotFound = 6,
    TagAlreadyExists = 7,
    NoChange = 8,
    TagRepeated = 9,
    LacksPermission = 10,
    RoomDoesNotExist = 11,
    InventionDoesNotExist = 12,
    ReservedWordViolation = 13,
}

// --------------------------------------------------------------------------
// EGKLGJJPDGA
//   REQUEST  PUT    api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class EGKLGJJPDGA
{
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x10
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x18
    public int? <NLIDGLBHCOL>k__BackingField;    // 0x0x20
    public MCOEPIIJNLA? <ACOJPJIABLL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// EGNMCGLNPJP
//   REQUEST  POST   api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class EGNMCGLNPJP
{
    public BNGBJHMMGBG <MNKCDEOONHI>k__BackingField;    // 0x0x10
    public string <PLCDDMBGBPF>k__BackingField;    // 0x0x18
    public int? <BJCCEIGDGCD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ENCCJMJDACE
//   (not directly referenced by a detected call)
public class ENCCJMJDACE
{
    public AICGNNCALDO ECNFNFDKIFG;    // 0x0x10
    public int APDDJDEFNJK;    // 0x0x14
}

// --------------------------------------------------------------------------
// ENKEODFGPMJ
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
//   RESPONSE POST   api/relationships/v2/updateVoiceVolume   [Service.API]
public class ENKEODFGPMJ
{
    public int <EMIJBDECFFN>k__BackingField;    // 0x0x10
    public CBBGKDGLPHD <BMPOOMCPDMA>k__BackingField;    // 0x0x14
    public NJIABPCPPDN <AGNEBEHHCOB>k__BackingField;    // 0x0x18
    public NJIABPCPPDN <LJKGANAKDCG>k__BackingField;    // 0x0x1C
    public NJIABPCPPDN <JBLJLOAPPLM>k__BackingField;    // 0x0x20
    public byte? <NMLJFLOKLMH>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// EPFIAJBHIGA
//   (not directly referenced by a detected call)
public class EPFIAJBHIGA
{
    public int <LJPNOKAPIOL>k__BackingField;    // 0x0x10
    public AGDFEAPMAIG <CNMDPCMOGGA>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// EPNJHPKOPAO
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class EPNJHPKOPAO
{
    public int <NNNEMHBEGEA>k__BackingField;    // 0x0x10
    public int <NLFHCAAFDNG>k__BackingField;    // 0x0x14
    public float <OLOLLHBCHGK>k__BackingField;    // 0x0x18
    public int <MEPMGEALJJN>k__BackingField;    // 0x0x1C
    public int <KLBGKMLMKAC>k__BackingField;    // 0x0x20
    public int <EMELHDDGBGF>k__BackingField;    // 0x0x24
    public int <MPOMLHGICAI>k__BackingField;    // 0x0x28
    public string <KKMEMODMGJC>k__BackingField;    // 0x0x30
    public string <EPDCFKBLLAJ>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// ExitGames.Client.Photon.OperationRequest
//   (not directly referenced by a detected call)
public class OperationRequest
{
    public byte OperationCode;    // 0x0x10
    public ParameterDictionary Parameters;    // 0x0x18
}

// --------------------------------------------------------------------------
// ExitGames.Client.Photon.OperationResponse
//   (not directly referenced by a detected call)
public class OperationResponse
{
    public byte OperationCode;    // 0x0x10
    public short ReturnCode;    // 0x0x12
    public string DebugMessage;    // 0x0x18
    public ParameterDictionary Parameters;    // 0x0x20
}

// --------------------------------------------------------------------------
// FCBDNLGIPHB
//   REQUEST  POST   api/playerevents/v2   [Service.API]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.API]
public class FCBDNLGIPHB
{
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x10
    public long? <DNKNGHELFCH>k__BackingField;    // 0x0x18
    public long? <AMKEIJLOHAG>k__BackingField;    // 0x0x28
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x38
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x40
    public List<string> <CIFPGGPGJEL>k__BackingField;    // 0x0x48
    public string <JJJJGJNODDP>k__BackingField;    // 0x0x50
    public DateTime <CAIEOEJIGON>k__BackingField;    // 0x0x58
    public DateTime <JHKKGJOAJMH>k__BackingField;    // 0x0x60
    public DLCBOABCOBP <ACOJPJIABLL>k__BackingField;    // 0x0x68
    public bool <BFKNEMGCADM>k__BackingField;    // 0x0x6C
    public bool <ODKKDENIEIG>k__BackingField;    // 0x0x6D
    public HDDHKLHPFPJ <BFHLHBEAIHG>k__BackingField;    // 0x0x70
    public HDDHKLHPFPJ <MGBAOFFKHFD>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// FFLPJIMKKNB
//   REQUEST  POST   api/relationships/v2/updateVoiceVolume   [Service.API]
public class FFLPJIMKKNB
{
    public int <AHJPOGANEHN>k__BackingField;    // 0x0x10
    public byte <NMLJFLOKLMH>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// FIJDEFJGMPE
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class FIJDEFJGMPE
{
    public int <BCMDJPPFJGJ>k__BackingField;    // 0x0x10
    public int <FLOFEBCFDDO>k__BackingField;    // 0x0x14
    public float <EJBGPNPKEEB>k__BackingField;    // 0x0x18
    public float <BCGPPJAPKOO>k__BackingField;    // 0x0x1C
    public bool <LKGDBOIAAGD>k__BackingField;    // 0x0x20
    public bool <EALBBIDINBH>k__BackingField;    // 0x0x21
    public bool <NAJFELJFDHP>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// FMIHFKHBDPN
//   (not directly referenced by a detected call)
public class FMIHFKHBDPN
{
    public DateTime <MOLGCMPAHCL>k__BackingField;    // 0x0x10
    public string <OCNBBEHIEIK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FOLJPDJHLMJ
//   (not directly referenced by a detected call)
public class FOLJPDJHLMJ
{
    public int <PBIAHPGGGCO>k__BackingField;    // 0x0x10
    public DateTime? <CIAJPLJJFOE>k__BackingField;    // 0x0x18
    public DateTime? <IOFJMBIIONM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// FOPNIDOJMAH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FOPNIDOJMAH
{
    All = -1,
    Steam = 0,
    Oculus = 1,
    PlayStation = 2,
    Xbox = 3,
    RecNet = 4,
    IOS = 5,
    GooglePlay = 6,
    Standalone = 7,
    Pico = 8,
    Switch = 9,
}

// --------------------------------------------------------------------------
// FPFFHAMJOIM
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class FPFFHAMJOIM
{
    public List<string> <GEDGKGKKKGH>k__BackingField;    // 0x0x10
    public List<string> <FPDADIJMAFH>k__BackingField;    // 0x0x18
    public List<string> <PIHHCMFFFHP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GBEEPPMHJFK
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.Econ]
public class GBEEPPMHJFK
{
    public Guid <HHJEFNMHOOE>k__BackingField;    // 0x0x10
    public int <DCENHFNMHJG>k__BackingField;    // 0x0x20
    public long <GFJNJOLKCMN>k__BackingField;    // 0x0x28
    public Guid <EMNLNHLAADC>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// GDHOEIIDDOP
//   (not directly referenced by a detected call)
public class GDHOEIIDDOP
{
    public string <GBMMEIPCGKG>k__BackingField;    // 0x0x10
    public GNBDMLHGOIB <BMPOOMCPDMA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GJCFPCHPCFH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GJCFPCHPCFH
{
    None = -1,
    Default = 0,
    First_Activity = 1,
    Game_Drop = 2,
    All_Daily_Challenges_Complete = 3,
    All_Weekly_Challenge_Complete = 4,
    Daily_Challenge_Complete = 5,
    Weekly_Challenge_Complete = 6,
    Unassigned_Equipment = 10,
    Unassigned_Avatar = 11,
    Unassigned_Consumable = 12,
    Reacquisition = 20,
    Membership = 21,
    NUX_TokensAndDressUp = 30,
    NUX_Experiment1 = 31,
    NUX_Experiment2 = 32,
    NUX_Experiment3 = 33,
    NUX_Experiment4 = 34,
    NUX_Experiment5 = 35,
    GameRewards = 50,
    GameRewards_Tokens = 51,
    GameRewards_Tokens_Experiment_Override = 52,
    GameRewards_A = 53,
    GameRewards_B = 54,
    LevelUp = 100,
    Purchased_Gift_A = 500,
    Purchased_Gift_B = 501,
    Purchased_Gift_C = 502,
    Purchased_Gift_D = 503,
    Holiday = 1000,
    Contest = 1001,
    Promotion = 1002,
    LimitedTime = 1003,
    LimitedTimeEvent = 1004,
    Deprecated = 1100,
    RecRoyale = 1200,
    Friendotron_Gift = 1300,
    DEPRECATED_Paintball_ClearCut = 2000,
    DEPRECATED_Paintball_Homestead = 2001,
    DEPRECATED_Paintball_Quarry = 2002,
    DEPRECATED_Paintball_River = 2003,
    DEPRECATED_Paintball_Dam = 2004,
    DEPRECATED_Paintball_DriveIn = 2005,
    Paintball_ClearCut = 2010,
    Paintball_Homestead = 2011,
    Paintball_Quarry = 2012,
    Paintball_River = 2013,
    Paintball_Dam = 2014,
    Paintball_DriveIn = 2015,
    DEPRECATED_Discgolf_Propulsion = 3000,
    DEPRECATED_Discgolf_Lake = 3001,
    Discgolf_Propulsion = 3010,
    Discgolf_Lake = 3011,
    Discgolf_Mode_CoopCatch = 3500,
    Quest_Goblin_A = 4000,
    Quest_Goblin_B = 4001,
    Quest_Goblin_C = 4002,
    Quest_Goblin_S = 4003,
    Quest_Goblin_Consumable = 4004,
    Quest_Cauldron_A = 4010,
    Quest_Cauldron_B = 4011,
    Quest_Cauldron_C = 4012,
    Quest_Cauldron_S = 4013,
    Quest_Cauldron_Consumable = 4014,
    Quest_Pirate1_A = 4100,
    Quest_Pirate1_B = 4101,
    Quest_Pirate1_C = 4102,
    Quest_Pirate1_S = 4103,
    Quest_Pirate1_X = 4104,
    Quest_Pirate1_Consumable = 4105,
    Quest_Dracula1_A = 4200,
    Quest_Dracula1_B = 4201,
    Quest_Dracula1_C = 4202,
    Quest_Dracula1_S = 4203,
    Quest_Dracula1_X = 4204,
    Quest_Dracula1_Consumable = 4205,
    Quest_Dracula1_SS = 4206,
    Quest_SciFi_A = 4500,
    Quest_SciFi_B = 4501,
    Quest_SciFi_C = 4502,
    Quest_SciFi_S = 4503,
    Quest_Scifi_Consumable = 4504,
    DEPRECATED_Charades = 5000,
    Charades = 5001,
    DEPRECATED_Soccer = 6000,
    Soccer = 6001,
    DEPRECATED_Paddleball = 7000,
    Paddleball = 7001,
    DEPRECATED_Dodgeball = 8000,
    Dodgeball = 8001,
    DEPRECATED_Lasertag = 9000,
    Lasertag = 9001,
    DEPRECATED_Bowling = 10000,
    Bowling = 10001,
    StuntRunner_TheMainEvent_A = 11000,
    StuntRunner_TheMainEvent_B = 11001,
    StuntRunner_TheMainEvent_C = 11002,
    StuntRunner_TheMainEvent_D = 11003,
    StuntRunner_TheMainEvent_S = 11004,
    StuntRunner_TheMainEvent_X = 11005,
    StuntRunner_TheMainEvent_Consumable = 11006,
    StuntRunner_TheMainEvent_SS = 11007,
    RecRally = 12000,
    Showdown_A = 12100,
    Showdown_B = 12101,
    Showdown_C = 12102,
    MyLittleMonsters = 12200,
    RunTheBlock = 12300,
    RROStorefront_ToBeNamed_2 = 12400,
    ProgressionEvent = 13000,
    Store_LaserTag = 100000,
    Store_RecCenter = 100010,
    Consumable = 110000,
    Token = 110100,
    Punchcard_Challenge_Complete = 110200,
    All_Punchcard_Challenges_Complete = 110201,
    New_Player_Checklist_Item_Complete = 110300,
    Commerce_Purchase = 200000,
    Gift_Card_Redemption = 210000,
}

// --------------------------------------------------------------------------
// GNBDMLHGOIB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GNBDMLHGOIB
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// HDDHKLHPFPJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HDDHKLHPFPJ
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// HDDPEGDPJCO
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class HDDPEGDPJCO
{
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <NEGKEODMIHL>k__BackingField;    // 0x0x18
    public IOFMCLGEHMO <DOFCINMBHPN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HDFDPLPCDBA
//   (not directly referenced by a detected call)
public class HDFDPLPCDBA
{
    public bool <JHEJNLILBDF>k__BackingField;    // 0x0x10
    public IGNJONDMFAO <KLANLBEMPMJ>k__BackingField;    // 0x0x14
    public int <HHPKEIJALIA>k__BackingField;    // 0x0x18
    public DateTime <EDCBENFACMP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HDGKAIOICEE
//   (not directly referenced by a detected call)
public class HDGKAIOICEE
{
    public bool <JFPBGNBGBEP>k__BackingField;    // 0x0x10
    public BNPOPJMGFNP <PJCIGLDDKGM>k__BackingField;    // 0x0x18
    public float <PDBAAFMKGAK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HDNJDKIKMEG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HDNJDKIKMEG
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// HEEFGMNNJEB
// base   : ABOOKJLBGCB
//   (not directly referenced by a detected call)
public class HEEFGMNNJEB : ABOOKJLBGCB
{
    public int <PGCJHPNAIOB>k__BackingField;    // 0x0x68
    public List<HDGKAIOICEE> <JNOIAJHKJBH>k__BackingField;    // 0x0x70
    public List<HDGKAIOICEE> <BFCCAOEEDHM>k__BackingField;    // 0x0x78
    public List<HDGKAIOICEE> <OKNEAIMJBFH>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// HGJBLIMFINJ
// base   : CCCPHJMMHPK`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class HGJBLIMFINJ
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// HIOEIDNDPPO
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class HIOEIDNDPPO
{
    public long <ONBAEHHFMMM>k__BackingField;    // 0x0x10
    public int <KHHBPNKMNIB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HMMHFPNFBHP
//   (not directly referenced by a detected call)
public class HMMHFPNFBHP
{
    public long <MACAIMFJCAK>k__BackingField;    // 0x0x10
    public long <BKDLEDHCEKE>k__BackingField;    // 0x0x18
    public int <AHJPOGANEHN>k__BackingField;    // 0x0x20
    public DateTime <MOLGCMPAHCL>k__BackingField;    // 0x0x28
    public HDNJDKIKMEG <BMPOOMCPDMA>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// HPBFANMGDAG
//   (not directly referenced by a detected call)
public class HPBFANMGDAG
{
    public long <NLIDGLBHCOL>k__BackingField;    // 0x0x10
    public Guid? <HHJEFNMHOOE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IANEGLKOFAN
//   (not directly referenced by a detected call)
public class IANEGLKOFAN
{
    public int <FJGMAOLJAFC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IBDHOIHCOFN
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.Econ]
public class IBDHOIHCOFN
{
    public int CDAIIPBDOCH;    // 0x0x10
    public long ABFPJPOLKOG;    // 0x0x18
}

// --------------------------------------------------------------------------
// IBLJKLCCCLL
// base   : KFLGBIAGFII
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{bPOGMBKNFOG}   [Service.Econ]
public class IBLJKLCCCLL : KFLGBIAGFII
{
    public int <BDJCCIOFPDM>k__BackingField;    // 0x0x30
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x38
    public DateTime <POBJMJABHFG>k__BackingField;    // 0x0x40
    public DateTime <GCNCECOHHCK>k__BackingField;    // 0x0x48
    public BNIFAHGCPKG <KDIMBONFBPE>k__BackingField;    // 0x0x50
    public ABOOKJLBGCB <MNNMLDCLODE>k__BackingField;    // 0x0x58
    public List<HEEFGMNNJEB> <GDCEMFPDEGK>k__BackingField;    // 0x0x60
    public HDFDPLPCDBA <NBMBGKCLGDC>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// IFJGNMDGNJJ
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class IFJGNMDGNJJ
{
    public Dictionary<Guid, NGCCNKCOKOB> <GOKDNJACPPK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IGNJONDMFAO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IGNJONDMFAO
{
    All = -1,
    None = 0,
    Steam = 1,
    Oculus = 2,
    PlayStation = 4,
    Xbox = 8,
    RecNet = 16,
    IOS = 32,
    GooglePlay = 64,
    Standalone = 128,
    Pico = 256,
    Switch = 512,
}

// --------------------------------------------------------------------------
// IHFDOIEOOIN
// base   : FKGLKKIGGFP
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class IHFDOIEOOIN : FKGLKKIGGFP
{
    public PINEIIBNCEE? <OODGJHFBOGH>k__BackingField;    // 0x0x18
    public JEFAPMCMNMN <EIAPIMOMDOP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IJEPKJKKOIJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IJEPKJKKOIJ
{
    OK = 0,
    TooManyRequests = 1,
    NotEnoughCredit = 2,
    AlreadyOwned = 3,
    NoItemAvailable = 4,
    CouponNotApplicable = 5,
    RequestedPriceDoesNotMatch = 6,
    RequestedAmountNotAllowed = 7,
    PlayerNotEligible = 8,
    RequestCannotBeRefunded = 9,
    PlayerNotApproved = 10,
}

// --------------------------------------------------------------------------
// IKCNIANHIMA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IKCNIANHIMA
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// IOCBLNCDCKC
//   REQUEST  PUT    api/roomconsumables   [Service.Econ]
public class IOCBLNCDCKC
{
    public Guid? <IMGCJJLCOFA>k__BackingField;    // 0x0x10
    public Guid <IFDCNNPGKJJ>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// IOFMCLGEHMO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IOFMCLGEHMO
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// IOOJNDIGJIF
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{lIEFHLCIOCG}   [Service.API]
public class IOOJNDIGJIF
{
    public List<LECHAIBKJDM> <NOKGIODOIHC>k__BackingField;    // 0x0x10
    public List<MKMAFOGNGOF> <JAPNJIFLCDA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JEFAPMCMNMN
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class JEFAPMCMNMN
{
    public int <KHHBPNKMNIB>k__BackingField;    // 0x0x10
    public Guid <HHJEFNMHOOE>k__BackingField;    // 0x0x14
    public long <FNKOGOIFAPN>k__BackingField;    // 0x0x28
    public DateTime <EDCBENFACMP>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// JGKAFFMMGOA
//   RESPONSE DELETE api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{mEFIGIGFANB}   [Service.Econ]
public class JGKAFFMMGOA
{
    public ACDDJDNBNMN <ILHPMNDBDKC>k__BackingField;    // 0x0x10
    public NMDBPFKOJLP <HIIJBPHKJJG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JGLIAAEPJHF
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class JGLIAAEPJHF
{
    public int <LIODEMHFGKB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JIHBBOIINIL
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class JIHBBOIINIL
{
    public bool <JOBGEMCNBEE>k__BackingField;    // 0x0x10
    public string <BBAFELOGILE>k__BackingField;    // 0x0x18
    public string <HKJEDAGDIAO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JLOBEHBJACJ
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class JLOBEHBJACJ
{
    public IOCBLNCDCKC <PPNCPENLONL>k__BackingField;    // 0x0x10
    public HPBFANMGDAG <HOEKKBOFLFI>k__BackingField;    // 0x0x18
    public int <IENPHBPENEG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JLPOHMLHEKA
//   (not directly referenced by a detected call)
public class JLPOHMLHEKA
{
    public Guid <CKHFPEKPPLE>k__BackingField;    // 0x0x10
    public Guid <AEHNNKBCJIL>k__BackingField;    // 0x0x20
    public DateTime <POBJMJABHFG>k__BackingField;    // 0x0x30
    public List<BNPOPJMGFNP> <GMJIGCHJHGL>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// JMMCOKJAIGA
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class JMMCOKJAIGA
{
    public AGDFEAPMAIG <CNMDPCMOGGA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KADABDADOKL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KADABDADOKL
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// KJLLFJPAJKP
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{kHNIMGKFPOO}   [Service.API]
public class KJLLFJPAJKP
{
    public uint <FIODBMLENOF>k__BackingField;    // 0x0x10
    public uint? <CHMKFNKFGFN>k__BackingField;    // 0x0x14
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x20
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x28
    public DateTime <POOAHFEOMML>k__BackingField;    // 0x0x30
    public DateTime? <OPOKKFNLPLJ>k__BackingField;    // 0x0x38
    public bool <KDFOCEKELMC>k__BackingField;    // 0x0x48
    public List<APMHFDGFEBL> <BECDDAEGJDE>k__BackingField;    // 0x0x50
    public List<string> <CIFPGGPGJEL>k__BackingField;    // 0x0x58
    public int <JFMBBMBGIMP>k__BackingField;    // 0x0x60
    public int <GAOMMAJPAJF>k__BackingField;    // 0x0x64
    public int <CBDNANKIPEG>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// LAOPFHHEMDH
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class LAOPFHHEMDH
{
    public int? <DDBHBBLOKLN>k__BackingField;    // 0x0x10
    public string <NKAPHPJKJPE>k__BackingField;    // 0x0x18
    public string <DFKANOFBBFM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LBKFFEALDNH
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.Econ]
public class LBKFFEALDNH
{
    public List<string> <NBOHBCHDDAN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LECHAIBKJDM
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class LECHAIBKJDM
{
    public long <BKDLEDHCEKE>k__BackingField;    // 0x0x10
    public int <GABNBHKDFMM>k__BackingField;    // 0x0x18
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x20
    public long? <DNKNGHELFCH>k__BackingField;    // 0x0x28
    public long? <AMKEIJLOHAG>k__BackingField;    // 0x0x38
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x48
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x50
    public string <JJJJGJNODDP>k__BackingField;    // 0x0x58
    public DateTime <CAIEOEJIGON>k__BackingField;    // 0x0x60
    public DateTime <JHKKGJOAJMH>k__BackingField;    // 0x0x68
    public int <GFOHCNKMDIM>k__BackingField;    // 0x0x70
    public DLCBOABCOBP <ACOJPJIABLL>k__BackingField;    // 0x0x74
    public bool <BFKNEMGCADM>k__BackingField;    // 0x0x78
    public bool <ODKKDENIEIG>k__BackingField;    // 0x0x79
    public HDDHKLHPFPJ <BFHLHBEAIHG>k__BackingField;    // 0x0x7C
    public HDDHKLHPFPJ <MGBAOFFKHFD>k__BackingField;    // 0x0x80
    public long? <AOCFPOIPOEK>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// LELOMAPPNPF
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class LELOMAPPNPF
{
    public EFGBAPEPDDK <CNMDPCMOGGA>k__BackingField;    // 0x0x10
    public List<string> <CIFPGGPGJEL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LFCHKONLOIE
//   (not directly referenced by a detected call)
public class LFCHKONLOIE
{
    public int <IENPHBPENEG>k__BackingField;    // 0x0x10
    public IOCBLNCDCKC <PPNCPENLONL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LGFBOBOEBPH
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/checklist/v1/complete   [Service.Econ]
//   RESPONSE POST   api/progressionEvents   [Service.API]
//   RESPONSE POST   api/progressionEvents/collect/{lCFGHMPEGEJ}/{iAPBNMJDHCD}   [Service.API]
public class LGFBOBOEBPH
{
    public long? <FIODBMLENOF>k__BackingField;    // 0x0x10
    public int <AHJPOGANEHN>k__BackingField;    // 0x0x20
    public int? <CHDCLOCAPJF>k__BackingField;    // 0x0x24
    public string <OEKHJGNHIJE>k__BackingField;    // 0x0x30
    public AEBJGFFALND? <DEGCBFGCMKF>k__BackingField;    // 0x0x38
    public string <NCGAFCLHNIF>k__BackingField;    // 0x0x40
    public Guid? <OCNKBDNKLKG>k__BackingField;    // 0x0x48
    public string <CGFPOJKIBKD>k__BackingField;    // 0x0x60
    public string <BDIANBHJPPM>k__BackingField;    // 0x0x68
    public BNIFAHGCPKG <KDIMBONFBPE>k__BackingField;    // 0x0x70
    public int <LKLAMKOBLMB>k__BackingField;    // 0x0x74
    public int <IBDFHNJGLOK>k__BackingField;    // 0x0x78
    public GJCFPCHPCFH <DCJABBNKBFP>k__BackingField;    // 0x0x7C
    public NPOPGDKCOBH <DHFEFCAKNLD>k__BackingField;    // 0x0x80
    public string <BJPCINIHPMN>k__BackingField;    // 0x0x88
    public string <HCJLJFFDFMH>k__BackingField;    // 0x0x90
    public bool <IDJIMFPLFPC>k__BackingField;    // 0x0x98
    public FOPNIDOJMAH <MGICFPGDCAM>k__BackingField;    // 0x0x9C
    public IGNJONDMFAO <MEHAMFIDKKF>k__BackingField;    // 0x0xA0
    public APOHLMNLEFG? <LCIKHKBGAKA>k__BackingField;    // 0x0xA4
    public bool <FIPAIMNGDON>k__BackingField;    // 0x0xAC
    public bool <FPHJGHHJIHP>k__BackingField;    // 0x0xAD
    public string <MPHMKHJJNJK>k__BackingField;    // 0x0xB0
    public string <DLACDCCCENP>k__BackingField;    // 0x0xB8
    public bool <HBLCOCPOMKP>k__BackingField;    // 0x0xC0
    public bool FPOFMHONJAB;    // 0x0xC1
}

// --------------------------------------------------------------------------
// LIGPLKJCMLG
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class LIGPLKJCMLG
{
    public List<EPFIAJBHIGA> <FHCLAOHADPJ>k__BackingField;    // 0x0x10
    public AGDFEAPMAIG <CNMDPCMOGGA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LIOFNINKJIN
// base   : FICFLMONDCJ
//   (not directly referenced by a detected call)
public class LIOFNINKJIN : FICFLMONDCJ
{
    public BIHDAAKIALA EMMLLDHNPLM;    // 0x0x20
}

// --------------------------------------------------------------------------
// LJDHGOJBBKP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LJDHGOJBBKP
{
    None = 0,
    LaserTag = 1,
    RecCenter = 2,
    Watch = 3,
    Quest_LostSkulls = 100,
    Quest_Dracula = 101,
    Quest_GoldenTrophy = 102,
    Quest_CrimsonCauldron = 103,
    RecRoyale = 200,
    Cafe = 300,
    Paintball = 400,
    Paintball_River = 401,
    Paintball_Homestead = 402,
    Paintball_Quarry = 403,
    Paintball_ClearCut = 404,
    Paintball_Spillway = 405,
    Paintball_SunsetDriveIn = 406,
    Bowling = 500,
    StuntRunner = 600,
    DormMirror = 700,
    InventionStore = 800,
    RoomKeys = 900,
    Player_Profile = 1000,
    Room_Save = 1100,
    RoomCurrencies = 1200,
    Wishlist = 1300,
    Friendotron = 1400,
    RoomConsumables = 1500,
    RecRally = 1600,
    PopUpShop_1 = 1700,
    PopUpShop_2 = 1701,
    PopUpShop_3 = 1702,
    PopUpShop_4 = 1703,
    PopUpShop_5 = 1704,
    PopUpShop_6 = 1705,
    PopUpShop_7 = 1706,
    PopUpShop_8 = 1707,
    PopUpShop_9 = 1708,
    PopUpShop_10 = 1709,
    PopUpShop_11 = 1710,
    PopUpShop_12 = 1711,
    PopUpShop_13 = 1712,
    PopUpShop_14 = 1713,
    PopUpShop_15 = 1714,
    PopUpShop_16 = 1715,
    PopUpShop_17 = 1716,
    PopUpShop_18 = 1717,
    PopUpShop_19 = 1718,
    PopUpShop_20 = 1719,
    CustomAvatarItems = 1800,
    ProgressionEventPurchasableXpBoosts = 1900,
    PopUpShop_ProgressionEvent_1 = 2000,
    PopUpShop_ProgressionEvent_2 = 2001,
    PopUpShop_ProgressionEvent_3 = 2002,
    PopUpShop_ProgressionEvent_4 = 2003,
    PopUpShop_ProgressionEvent_5 = 2004,
    RoomOffers = 2100,
    MyLittleMonsters = 2200,
    Destiny = 2201,
    RunTheBlock = 2202,
    RROStorefront_ToBeNamed_2 = 2203,
    DevStorefront_DoNotAddToWatch_1 = 2300,
    DevStorefront_DoNotAddToWatch_2 = 2301,
    DevStorefront_DoNotAddToWatch_3 = 2302,
    DevStorefront_DoNotAddToWatch_4 = 2303,
    DevStorefront_DoNotAddToWatch_5 = 2304,
}

// --------------------------------------------------------------------------
// LKDHECIEDMN
//   (not directly referenced by a detected call)
public class LKDHECIEDMN
{
    public AGHPNEOHJOF <JDIBMNNHDKH>k__BackingField;    // 0x0x10
    public long <AOFHKLJCHHD>k__BackingField;    // 0x0x18
    public GiftItemDTO <FLHKHMNMLKD>k__BackingField;    // 0x0x20
    public long? <LMMCLIOLAIB>k__BackingField;    // 0x0x28
    public int <FPIEFHEJHJC>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// MBBPNFHPDKL
//   (not directly referenced by a detected call)
public class MBBPNFHPDKL
{
    public int <EKJPOMJGFGC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MBPEDKNNCFK
//   REQUEST  POST   api/items/bulkpurchase   [Service.Commerce]
public class MBPEDKNNCFK
{
    public List<LKDHECIEDMN> <ILJHPDHDAKO>k__BackingField;    // 0x0x10
    public LJDHGOJBBKP? <MHBFEHBLINO>k__BackingField;    // 0x0x18
    public BNIFAHGCPKG <KDIMBONFBPE>k__BackingField;    // 0x0x20
    public bool <CJJMGKEEBMG>k__BackingField;    // 0x0x24
    public bool <GHIEJHFFEMO>k__BackingField;    // 0x0x25
}

// --------------------------------------------------------------------------
// MCLHCIINKEC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MCLHCIINKEC
{
    PurchasableItem = 0,
    CustomAvatarItem = 1,
}

// --------------------------------------------------------------------------
// MCOEPIIJNLA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MCOEPIIJNLA
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// MDFLDJFGDJJ
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.Econ]
public class MDFLDJFGDJJ
{
    public List<MEGDMJGCDIG> <JBBABEMEBAI>k__BackingField;    // 0x0x10
    public string <CNOLFBGHACB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MEGDMJGCDIG
//   (not directly referenced by a detected call)
public class MEGDMJGCDIG
{
    public int <KNMKLNEPBJK>k__BackingField;    // 0x0x10
    public DateTime <MOLGCMPAHCL>k__BackingField;    // 0x0x18
    public DateTime? <LJFLFAGEHGC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MFCBDHILCNM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MFCBDHILCNM
{
    Unspecified = -1,
    XP = 0,
    OutfitItem = 1,
    Equipment = 2,
    Currency = 3,
    Consumable = 4,
    Query = 5,
    HairDye = 6,
}

// --------------------------------------------------------------------------
// MKMAFOGNGOF
//   (not directly referenced by a detected call)
public class MKMAFOGNGOF
{
    public LECHAIBKJDM <LDDGILGICED>k__BackingField;    // 0x0x10
    public HMMHFPNFBHP <MKKLJNHHCLI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MMJMPMNADLE
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class MMJMPMNADLE
{
    public List<int> <DGLIIDNIMJA>k__BackingField;    // 0x0x10
    public string <CNOLFBGHACB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncHandshakeRequest
// base   : Mono.Net.Security.AsyncProtocolRequest
//   (not directly referenced by a detected call)
public class AsyncHandshakeRequest : AsyncProtocolRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncProtocolRequest
//   (not directly referenced by a detected call)
public class AsyncProtocolRequest
{
    public MobileAuthenticatedStream <Parent>k__BackingField;    // 0x0x10
    public bool <RunSynchronously>k__BackingField;    // 0x0x18
    public int <UserResult>k__BackingField;    // 0x0x1C
    public int Started;    // 0x0x20
    public int RequestedSize;    // 0x0x24
    public int WriteRequested;    // 0x0x28
    public object locker;    // 0x0x30
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncProtocolResult
//   (not directly referenced by a detected call)
public class AsyncProtocolResult
{
    public int <UserResult>k__BackingField;    // 0x0x10
    public ExceptionDispatchInfo <Error>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncReadOrWriteRequest
// base   : Mono.Net.Security.AsyncProtocolRequest
//   (not directly referenced by a detected call)
public class AsyncReadOrWriteRequest : AsyncProtocolRequest
{
    public BufferOffsetSize <UserBuffer>k__BackingField;    // 0x0x38
    public int <CurrentSize>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncReadRequest
// base   : Mono.Net.Security.AsyncReadOrWriteRequest
//   (not directly referenced by a detected call)
public class AsyncReadRequest : AsyncReadOrWriteRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Mono.Net.Security.AsyncWriteRequest
// base   : Mono.Net.Security.AsyncReadOrWriteRequest
//   (not directly referenced by a detected call)
public class AsyncWriteRequest : AsyncReadOrWriteRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Mono.Security.Interface.ValidationResult
//   (not directly referenced by a detected call)
public class ValidationResult
{
    public bool trusted;    // 0x0x10
    public bool user_denied;    // 0x0x11
    public int error_code;    // 0x0x14
    public MonoSslPolicyErrors? policy_errors;    // 0x0x18
}

// --------------------------------------------------------------------------
// Mono.Security.Protocol.Ntlm.ChallengeResponse
//   (not directly referenced by a detected call)
public class ChallengeResponse
{
    public bool _disposed;    // 0x0x10
    public byte[] _challenge;    // 0x0x18
    public byte[] _lmpwd;    // 0x0x20
    public byte[] _ntpwd;    // 0x0x28
}

// --------------------------------------------------------------------------
// NBJPECCDCPO
//   (not directly referenced by a detected call)
public class NBJPECCDCPO
{
    public float <OCCLNAKNIMO>k__BackingField;    // 0x0x10
    public float <LFPFIBEKOCM>k__BackingField;    // 0x0x14
    public float <FMLKMBLHGHE>k__BackingField;    // 0x0x18
    public float <MAOHOHLNFMD>k__BackingField;    // 0x0x1C
    public float <MLONLBKBNIH>k__BackingField;    // 0x0x20
    public float <AFOBIHBJPOF>k__BackingField;    // 0x0x24
    public float <KBBIOJKCALB>k__BackingField;    // 0x0x28
    public float <CCAIHGGCEID>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// NGCCNKCOKOB
//   RESPONSE PUT    api/roomconsumables   [Service.Econ]
public class NGCCNKCOKOB
{
    public ACDDJDNBNMN <ILHPMNDBDKC>k__BackingField;    // 0x0x10
    public CJCOLJEKBPE <MKLJJNOCFCG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NIIBMLALFHM
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class NIIBMLALFHM
{
    public int <FLOFEBCFDDO>k__BackingField;    // 0x0x10
    public bool <LKGDBOIAAGD>k__BackingField;    // 0x0x14
    public DateTime <BFKEOGCPANE>k__BackingField;    // 0x0x18
    public bool <HHEGDGLOKLA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// NMDBPFKOJLP
//   (not directly referenced by a detected call)
public class NMDBPFKOJLP
{
    public Guid <LGNEJFGBAHA>k__BackingField;    // 0x0x10
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x20
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x28
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x30
    public string <JJJJGJNODDP>k__BackingField;    // 0x0x38
    public long <NLIDGLBHCOL>k__BackingField;    // 0x0x40
    public Guid? <ENJKGGJNBOE>k__BackingField;    // 0x0x48
    public DateTime <EDCBENFACMP>k__BackingField;    // 0x0x60
    public int <BFFFCHHIHMB>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// NPOPGDKCOBH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NPOPGDKCOBH
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// OAJMHFIAABF
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class OAJMHFIAABF : ValueType
{
    public CODNEFMDLIN MLMPCGENECN;    // 0x0x0
    public DGAJDHHBHCK PFGGJKPJLAF;    // 0x0x10
    public Guid BILGBJJNAIB;    // 0x0x20
}

// --------------------------------------------------------------------------
// OCJBGCMJOKE
//   (not directly referenced by a detected call)
public class OCJBGCMJOKE
{
    public float <OBDBGHAFMBI>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PBCHLJBJGJI
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class PBCHLJBJGJI
{
    public CGCFJIMPBOK <MNKCDEOONHI>k__BackingField;    // 0x0x10
    public int <LIODEMHFGKB>k__BackingField;    // 0x0x14
    public long <BKDEHCFCJOP>k__BackingField;    // 0x0x18
    public bool <DPFIEMADGGJ>k__BackingField;    // 0x0x20
    public string <BDIJFHLHDFI>k__BackingField;    // 0x0x28
    public int? <HCIAAAAFCGE>k__BackingField;    // 0x0x30
    public bool <GLCCKNHFCNF>k__BackingField;    // 0x0x38
    public bool <LHDLPDIBANP>k__BackingField;    // 0x0x39
    public bool <CNCIJHAEEAI>k__BackingField;    // 0x0x3A
    public bool <KHJLJEHFKDL>k__BackingField;    // 0x0x3B
    public string <EHKJCHABMEP>k__BackingField;    // 0x0x40
    public DateTime? <GJBPHFDJIBC>k__BackingField;    // 0x0x48
    public string <AFNIKGNIAFG>k__BackingField;    // 0x0x58
    public bool <HBIJDJMPKGP>k__BackingField;    // 0x0x60
    public string <FFENBGFCLGF>k__BackingField;    // 0x0x68
    public string <MJFFJNALGNL>k__BackingField;    // 0x0x70
    public float <IBDPKMONOBP>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// PDJIKHEPAMC
//   RESPONSE POST   api/PlayerReporting/v1/roomModKick   [Service.API]
//   RESPONSE POST   api/chatreport/createChatReport   [Service.API]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.Econ]
//   RESPONSE DELETE api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.API]
//   RESPONSE DELETE api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{lPOCINEMHOG}/appeal   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.Econ]
//   RESPONSE POST   api/images/v2/modifyaccessibility   [Service.API]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.Econ]
//   RESPONSE DELETE api/keepsakes   [Service.API]
//   RESPONSE DELETE api/keepsakes/{aPLOIMOLGJJ}   [Service.API]
//   RESPONSE POST   api/makerai/activatefreetrial   [Service.API]
//   RESPONSE GET    api/makerai/checkfreetrialeligibility   [Service.Econ]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
public class PDJIKHEPAMC
{
    public bool <KJIBMHBFIEG>k__BackingField;    // 0x0x10
    public string <EAHEDNIGDIF>k__BackingField;    // 0x0x18
    public string <HJNOPENELPH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PGHCAKNLHED
//   REQUEST  POST   api/playerevents/v1/respond   [Service.API]
public class PGHCAKNLHED
{
    public long <BKDLEDHCEKE>k__BackingField;    // 0x0x10
    public HDNJDKIKMEG <BMPOOMCPDMA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PINEIIBNCEE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PINEIIBNCEE
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// PJEMHCHDGKM
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.API]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.API]
//   RESPONSE POST   api/inventions/v1/report   [Service.API]
//   RESPONSE POST   api/playerevents/v1/report   [Service.API]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.API]
//   RESPONSE POST   api/rooms/v2/report   [Service.API]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.API]
public class PJEMHCHDGKM
{
    public bool <KJIBMHBFIEG>k__BackingField;    // 0x0x10
    public string <BDIJFHLHDFI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PMIAMAMDAON
//   REQUEST  POST   api/equipment/v1/update   [Service.Econ]
public class PMIAMAMDAON
{
    public string <EBOIFNENPKJ>k__BackingField;    // 0x0x10
    public string <DHDEIJFAKML>k__BackingField;    // 0x0x18
    public string <MCLCFJHNNPE>k__BackingField;    // 0x0x20
    public string <MLNFCNFONPL>k__BackingField;    // 0x0x28
    public NPOPGDKCOBH <IBGLJEHGMKE>k__BackingField;    // 0x0x30
    public string <DJELNEHOCJO>k__BackingField;    // 0x0x38
    public bool EPDIOOIJLKG;    // 0x0x40
    public bool <NAJFELJFDHP>k__BackingField;    // 0x0x41
}

// --------------------------------------------------------------------------
// PMMLMIEAIMN
//   RESPONSE GET    api/config/v2   [Service.API]
public class PMMLMIEAIMN
{
    public Dictionary<int, int> <PHGNLHBJKII>k__BackingField;    // 0x0x10
    public List<HHNAOAMEMKC> <NGIJPECLAPM>k__BackingField;    // 0x0x18
    public ENCCJMJDACE[][] <MKEFFBDLBOM>k__BackingField;    // 0x0x20
    public IANEGLKOFAN <KIOPIDOAIPF>k__BackingField;    // 0x0x28
    public NBJPECCDCPO <BOADCFMNBOP>k__BackingField;    // 0x0x30
    public AJNCPCIEDIC <DNCFGLEFHEP>k__BackingField;    // 0x0x38
    public MBBPNFHPDKL <JLANKHOBINK>k__BackingField;    // 0x0x40
    public OCJBGCMJOKE <KFCLJACAAEP>k__BackingField;    // 0x0x48
    public string <LLPFHEPDDFL>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// PMNBEPBIGAL
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{hOALEGLICGN}/{hIKDIGFODLL}   [Service.Econ]
public class PMNBEPBIGAL
{
    public BNIFAHGCPKG <KDIMBONFBPE>k__BackingField;    // 0x0x10
    public DLNFAAIBFGE <BNBBJKEDPBO>k__BackingField;    // 0x0x14
    public int <JOAKKIKBAFD>k__BackingField;    // 0x0x18
    public int <KAIBNHDHNHM>k__BackingField;    // 0x0x1C
    public int <KJHKCOFOFFN>k__BackingField;    // 0x0x20
    public IKCNIANHIMA <DGHLHNAEIPA>k__BackingField;    // 0x0x24
    public bool <HGBIFDPFBHI>k__BackingField;    // 0x0x28
    public float <JOAHNCAHMOJ>k__BackingField;    // 0x0x2C
    public int <PAODJNMGNIP>k__BackingField;    // 0x0x30
    public bool <HELGLNKGAGF>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// PNLMANAAGMB
// base   : LECHAIBKJDM
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class PNLMANAAGMB : LECHAIBKJDM
{
    public List<GDHOEIIDDOP> <CIFPGGPGJEL>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// POKAKGFJENC
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class POKAKGFJENC
{
    public Dictionary<Guid, LFCHKONLOIE> <CHJLAEFPMAF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x10
    public long? <DNKNGHELFCH>k__BackingField;    // 0x0x18
    public JJFPKLGIJNA <IIJPNMBACNO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v8/addversion   [Service.Notifications]
public class AddVersionInventionRequestDTO
{
    public long inventionId;    // 0x0x10
    public bool hasBetaContent;    // 0x0x18
    public int instantiationCost;    // 0x0x1C
    public int lightsCost;    // 0x0x20
    public int chipsCost;    // 0x0x24
    public int cloudVariablesCost;    // 0x0x28
    public int aiCost;    // 0x0x2C
    public byte ugcVersion;    // 0x0x30
    public long creationRoomId;    // 0x0x38
    public string inventionDataFilename;    // 0x0x40
    public List<long> referencedInventions;    // 0x0x48
    public IReadOnlyList<Guid> referencedUnityAssetIds;    // 0x0x50
    public ModifyTagsRequest tagsRequest;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.API]
public class AppleMusicPromotionResponseDTO
{
    public FPJJHIIPHLJ <CNMDPCMOGGA>k__BackingField;    // 0x0x10
    public string <BLHIICNPDGN>k__BackingField;    // 0x0x18
    public string <LHPMBIEPIGJ>k__BackingField;    // 0x0x20
    public string <KCGOMAKFFOP>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public BNIFAHGCPKG <CurrencyType>k__BackingField;    // 0x0x18
    public APOHLMNLEFG <BalanceType>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.BalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<HBGPKNICCNH<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.CheerRequest
//   REQUEST  POST   api/inventions/v2/cheer   [Service.API]
public class CheerRequest
{
    public long InventionId;    // 0x0x10
    public bool Cheer;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.DeleteInventionRequest
//   REQUEST  POST   api/inventions/v2/delete   [Service.API]
public class DeleteInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.DeleteMessagesRequestDTO
//   REQUEST  POST   api/messages/v3/delete   [Service.API]
public class DeleteMessagesRequestDTO
{
    public List<long> MessageIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.BroadcastRoomInstanceRequest
//   REQUEST  POST   api/playerevents/v1/broadcast   [Service.API]
public class BroadcastRoomInstanceRequest
{
    public long <BKDLEDHCEKE>k__BackingField;    // 0x0x10
    public long? <LENANHPECGD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.BulkInviteRequest
//   REQUEST  POST   api/playerevents/v1/bulkInvite   [Service.API]
public class BulkInviteRequest
{
    public long PlayerEventId;    // 0x0x10
    public List<int> InvitedPlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.DeleteResponseRequest
//   REQUEST  POST   api/playerevents/v1/deleteResponse   [Service.API]
public class DeleteResponseRequest
{
    public long PlayerEventId;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.FilteredTextDTO
//   (not directly referenced by a detected call)
public class FilteredTextDTO
{
    public string <ANBNPAIGGFD>k__BackingField;    // 0x0x10
    public int <OJCNMIKDOPG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.GetNearbyScoresRequestDTO
// base   : RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetNearbyScoresRequestDTO : GetRankRequestDTO
{
    public int WindowSize;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetRankRequestDTO
{
    public int PlayerId;    // 0x0x10
    public int StatChannel;    // 0x0x14
    public long RoomId;    // 0x0x18
    public ANADBMMLDLL FilterType;    // 0x0x20
    public bool SortAscending;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.GetRanksRequestDTO
// base   : RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetRanksRequestDTO : GetRankRequestDTO
{
    public int RankStart;    // 0x0x28
    public int RankEnd;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.GiftItemDTO
//   (not directly referenced by a detected call)
public class GiftItemDTO
{
    public int <ToPlayerId>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public bool <Anonymous>k__BackingField;    // 0x0x20
    public GJCFPCHPCFH <GiftContext>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.InventionModifyTagsRequest
// base   : RecNet.ModifyTagsRequest
//   REQUEST  POST   api/inventions/v1/settags   [Service.API]
public class InventionModifyTagsRequest : ModifyTagsRequest
{
    public long InventionId;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCategoryConfigDTO
//   (not directly referenced by a detected call)
public class KeepsakeCategoryConfigDTO
{
    public JJFPKLGIJNA <FPJJENNFHCL>k__BackingField;    // 0x0x10
    public string <KDDLIPBNMIN>k__BackingField;    // 0x0x18
    public int <FOIMAGFLIGN>k__BackingField;    // 0x0x20
    public int <OOOGGPFBOFH>k__BackingField;    // 0x0x24
    public string <GBEJAPAAJBB>k__BackingField;    // 0x0x28
    public string <CFGPOPMEPIP>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <KHHBPNKMNIB>k__BackingField;    // 0x0x10
    public Guid <PDBOGJNEELP>k__BackingField;    // 0x0x14
    public DateTime <CEOPLLIEFFK>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <FAHEAEPGPPK>k__BackingField;    // 0x0x10
    public int <CACNIMBLIKN>k__BackingField;    // 0x0x14
    public bool <KEIAAIPFFGM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <PDBOGJNEELP>k__BackingField;    // 0x0x10
    public JJFPKLGIJNA <EGHANNMJKGJ>k__BackingField;    // 0x0x20
    public int <PKPHBFKFGAH>k__BackingField;    // 0x0x24
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x28
    public long? <DNKNGHELFCH>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{aAFEKOBABPD}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <DLAIEKHINLD>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <MOHMGFNDFPE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <NKICMMNOBGB>k__BackingField;    // 0x0x10
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x18
    public long <LHFIMGBEOMF>k__BackingField;    // 0x0x20
    public KGOIMDJLHMP <BMPOOMCPDMA>k__BackingField;    // 0x0x28
    public int <DJEBFKKMJHK>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <ECKOGOFIIPH>k__BackingField;    // 0x0x10
    public List<Guid> <EMPGNBKNEKN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <DLAIEKHINLD>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <MOHMGFNDFPE>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <KCAELHCFOJB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <LHFIMGBEOMF>k__BackingField;    // 0x0x10
    public long <JHHMGBCLOOI>k__BackingField;    // 0x0x18
    public int? <NJIJDIKAGPG>k__BackingField;    // 0x0x20
    public int? <EIABKMIOHPF>k__BackingField;    // 0x0x28
    public long? <EOKONOGNFMP>k__BackingField;    // 0x0x30
    public long <GHAADEGNHOD>k__BackingField;    // 0x0x40
    public long <NNOEGJKJBEF>k__BackingField;    // 0x0x48
    public int <CJAGMLNCDAF>k__BackingField;    // 0x0x50
    public KGOIMDJLHMP <BJLKNDGMKEE>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <LIEJLMBFHNM>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.KickPlayerDTO
//   REQUEST  POST   api/PlayerReporting/v1/instantKick   [Service.API]
public class KickPlayerDTO
{
    public long GameSessionId;    // 0x0x10
    public List<int> PlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ModifyTagsRequest
//   (not directly referenced by a detected call)
public class ModifyTagsRequest
{
    public List<string> AutoTags;    // 0x0x10
    public List<string> CustomTags;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.MultiRecipientFreeGiftRequestDTO
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.Econ]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public GJCFPCHPCFH <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v9/save   [Service.Matchmaking]
public class NewInventionRequestDTO
{
    public string name;    // 0x0x10
    public string description;    // 0x0x18
    public string imageName;    // 0x0x20
    public bool hasBetaContent;    // 0x0x28
    public int instantiationCost;    // 0x0x2C
    public int lightsCost;    // 0x0x30
    public int chipsCost;    // 0x0x34
    public int cloudVariablesCost;    // 0x0x38
    public int aiCost;    // 0x0x3C
    public byte ugcVersion;    // 0x0x40
    public long creationRoomId;    // 0x0x48
    public string inventionDataFilename;    // 0x0x50
    public List<long> referencedInventions;    // 0x0x58
    public IReadOnlyList<Guid> referencedUnityAssetIds;    // 0x0x60
    public IIOJHPILAFO creatorAccountRole;    // 0x0x68
    public long? convertedFromInventionId;    // 0x0x70
    public string displayMetadataJson;    // 0x0x80
    public string longDescription;    // 0x0x88
    public ModifyTagsRequest tagsRequest;    // 0x0x90
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public CIPAIMJFGAG <BJPMFGPDDCM>k__BackingField;    // 0x0x10
    public OPHDOPICDEC <PBJAMHAJJBG>k__BackingField;    // 0x0x14
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x18
    public string <GDMMDMBLFAH>k__BackingField;    // 0x0x20
    public bool <DFNGAPPBHJF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<CIPAIMJFGAG> <JLKEJIMMBIJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{lCFGHMPEGEJ}   [Service.API]
public class ProgressionEventDTO
{
    public long <JHHMGBCLOOI>k__BackingField;    // 0x0x10
    public string <OJBKEKBLCGL>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <OKNEAIMJBFH>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <CHKMDIBLMGJ>k__BackingField;    // 0x0x28
    public DateTime <CAIEOEJIGON>k__BackingField;    // 0x0x30
    public DateTime <JHKKGJOAJMH>k__BackingField;    // 0x0x38
    public DateTime <AMLMAONOADO>k__BackingField;    // 0x0x40
    public bool <DMEPHFOKFNH>k__BackingField;    // 0x0x48
    public int <OOLABLPNAFN>k__BackingField;    // 0x0x4C
    public float <OABFCMIKBMB>k__BackingField;    // 0x0x50
    public Guid? <KFNCBKPLODA>k__BackingField;    // 0x0x54
    public string <FAHJBDMLHDA>k__BackingField;    // 0x0x68
    public string <LJLJGIBJFLJ>k__BackingField;    // 0x0x70
    public string <OALMIGMBBMM>k__BackingField;    // 0x0x78
    public string <CJHFDNDPGCN>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <HMFDOALABCP>k__BackingField;    // 0x0x10
    public int <BBPAKAEFLCL>k__BackingField;    // 0x0x20
    public int <DBOIOIFMNLC>k__BackingField;    // 0x0x24
    public int <BAHLINAINIK>k__BackingField;    // 0x0x28
    public long <DBDFIAPEAEP>k__BackingField;    // 0x0x30
    public long <ACAHJDGNMPJ>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <KHHBPNKMNIB>k__BackingField;    // 0x0x10
    public int <IBDFHNJGLOK>k__BackingField;    // 0x0x14
    public int <AIEIMDGPLLI>k__BackingField;    // 0x0x18
    public int <DGEMOFJGDKE>k__BackingField;    // 0x0x1C
    public int <IBCCICEBDKK>k__BackingField;    // 0x0x20
    public DateTime? <OFLEAMANOBM>k__BackingField;    // 0x0x28
    public int <MMFGBNFGOHF>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <CNLBKKGBFGK>k__BackingField;    // 0x0x10
    public int <NJMNJKAIEIA>k__BackingField;    // 0x0x18
    public string <JJJJGJNODDP>k__BackingField;    // 0x0x20
    public int <IBDFHNJGLOK>k__BackingField;    // 0x0x28
    public int <IFPOILGDFKO>k__BackingField;    // 0x0x2C
    public bool <JIIKHAKAGEI>k__BackingField;    // 0x0x30
    public bool <KBJCGJHANHN>k__BackingField;    // 0x0x31
}

// --------------------------------------------------------------------------
// RecNet.PublishInventionRequest
//   REQUEST  POST   api/inventions/v4/publish   [Service.API]
public class PublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public CKKDFOFPPNC <Permission>k__BackingField;    // 0x0x18
    public MCOEPIIJNLA <Accessibility>k__BackingField;    // 0x0x1C
    public int? <Price>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PurchaseBalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class PurchaseBalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<POCCIFFLKCI<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public LNDDINBMNME ReportCategory;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.InventionAndVersionReplicationIdsDTO
//   (not directly referenced by a detected call)
public class InventionAndVersionReplicationIdsDTO
{
    public Guid <ReplicationId>k__BackingField;    // 0x0x10
    public Guid <VersionReplicationId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.ReplicationUnityAssetsDTO
//   (not directly referenced by a detected call)
public class ReplicationUnityAssetsDTO
{
    public InventionAndVersionReplicationIdsDTO <Invention>k__BackingField;    // 0x0x10
    public List<FDMCMDDALOH> <UnityAssets>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.SetInventionVersionAccessibilityRequest
//   REQUEST  PUT    api/inventions/v2/accessibility   [Service.API]
public class SetInventionVersionAccessibilityRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public int <VersionNumber>k__BackingField;    // 0x0x18
    public MCOEPIIJNLA <NewAccessibility>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.SetStatRequestDTO
//   (not directly referenced by a detected call)
public class SetStatRequestDTO
{
    public int <StatChannel>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x18
    public int <StatValue>k__BackingField;    // 0x0x20
    public int? <CurrentStatValue>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.SpecialTags
//   RESPONSE GET    api/inventions/v1/specialTags   [Service.API]
public class SpecialTags
{
    public List<string> <AutoTags>k__BackingField;    // 0x0x10
    public List<string> <AGOnlyTags>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.UnpublishInventionRequest
//   REQUEST  POST   api/inventions/v2/unpublish   [Service.API]
public class UnpublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.UpdateInventionGeneralPermissionRequest
//   REQUEST  POST   api/inventions/v2/update   [Service.API]
public class UpdateInventionGeneralPermissionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public CKKDFOFPPNC <Permission>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.UpdateInventionMetadataRequest
//   REQUEST  PUT    api/inventions/v2/metadata   [Service.Data]
public class UpdateInventionMetadataRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public string <LongDescription>k__BackingField;    // 0x0x28
    public string <ImageName>k__BackingField;    // 0x0x30
    public ModifyTagsRequest <TagsRequest>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.UpdatePriceRequest
//   REQUEST  POST   api/inventions/v2/updateprice   [Service.API]
public class UpdatePriceRequest
{
    public long InventionId;    // 0x0x10
    public int Price;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class BaseDTO
{
    public string <Id>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.FileDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class FileDTO : BaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.MessageContentDTO
//   (not directly referenced by a detected call)
public class MessageContentDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Text>k__BackingField;    // 0x0x18
    public HHGMLDDAFMP <ImageFile>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.MessageDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class MessageDTO : BaseDTO
{
    public List<AIOGAJIOGFB> <Content>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.RunDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class RunDTO : BaseDTO
{
    public string <ThreadId>k__BackingField;    // 0x0x18
    public RunStatus <Status>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.ThreadDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class ThreadDTO : BaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ClientEventBaseDTO : EventBaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationCreatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationCreatedEventDTO : EventBaseDTO
{
    public ConversationDTO <Conversation>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationDTO
//   (not directly referenced by a detected call)
public class ConversationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemContentDTO
//   (not directly referenced by a detected call)
public class ConversationItemContentDTO
{
    public ConversationItemContentType <Type>k__BackingField;    // 0x0x10
    public string <Text>k__BackingField;    // 0x0x18
    public string <Id>k__BackingField;    // 0x0x20
    public string <Audio>k__BackingField;    // 0x0x28
    public string <Transcript>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemCreateEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemCreateEventDTO : ClientEventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemCreatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemCreatedEventDTO : EventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDTO
//   (not directly referenced by a detected call)
public class ConversationItemDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public ConversationItemType <Type>k__BackingField;    // 0x0x18
    public Role? <Role>k__BackingField;    // 0x0x1C
    public List<ConversationItemContentDTO> <Content>k__BackingField;    // 0x0x28
    public string <CallId>k__BackingField;    // 0x0x30
    public string <Name>k__BackingField;    // 0x0x38
    public string <Arguments>k__BackingField;    // 0x0x40
    public string <Output>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDeleteEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemDeleteEventDTO : ClientEventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDeletedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemDeletedEventDTO : EventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemInputAudioTranscriptionCompletedEventDTO : EventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
    public int <ContentIndex>k__BackingField;    // 0x0x28
    public string <Transcript>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ErrorDTO
//   (not directly referenced by a detected call)
public class ErrorDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Code>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
    public string <Param>k__BackingField;    // 0x0x28
    public string <EventId>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ErrorEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ErrorEventDTO : EventBaseDTO
{
    public ErrorDTO <Error>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class EventBaseDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <EventId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferAppendEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferAppendEventDTO : ClientEventBaseDTO
{
    public string <Audio>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferCommittedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferCommittedEventDTO : EventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferSpeechStartedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferSpeechStartedEventDTO : EventBaseDTO
{
    public int <AudioStartMs>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferSpeechStoppedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferSpeechStoppedEventDTO : EventBaseDTO
{
    public int <AudioEndMs>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioTranscriptionDTO
//   (not directly referenced by a detected call)
public class InputAudioTranscriptionDTO
{
    public string <Model>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputTokenDetailsDTO
// base   : RecRoom.AI.OpenAI.Realtime.TokenDetailsDTO
//   (not directly referenced by a detected call)
public class InputTokenDetailsDTO : TokenDetailsDTO
{
    public int <CachedTokens>k__BackingField;    // 0x0x18
    public TokenDetailsDTO <CachedTokensDetails>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.RateLimitDTO
//   (not directly referenced by a detected call)
public class RateLimitDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public int <Limit>k__BackingField;    // 0x0x18
    public int <Remaining>k__BackingField;    // 0x0x1C
    public float <ResetSeconds>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.RateLimitsUpdatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class RateLimitsUpdatedEventDTO : EventBaseDTO
{
    public RateLimitDTO[] <RateLimits>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Delta>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioTranscriptDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioTranscriptDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Transcript>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseContentPartEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseContentPartEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public ConversationItemContentDTO <Part>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseCreateEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseCreateEventDTO : ClientEventBaseDTO
{
    public ResponseDTO <Response>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseDTO
//   (not directly referenced by a detected call)
public class ResponseDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public ResponseStatus <Status>k__BackingField;    // 0x0x18
    public ResponseStatusDetailsDTO <StatusDetails>k__BackingField;    // 0x0x20
    public List<ConversationItemDTO> <Output>k__BackingField;    // 0x0x28
    public TokenUsageDTO <Usage>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseErrorDTO
//   (not directly referenced by a detected call)
public class ResponseErrorDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Code>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseEventDTO : EventBaseDTO
{
    public ResponseDTO <Response>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseFunctionCallArgumentsDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public string <CallId>k__BackingField;    // 0x0x38
    public string <Delta>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseFunctionCallArgumentsDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseFunctionCallArgumentsDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public string <CallId>k__BackingField;    // 0x0x38
    public string <Name>k__BackingField;    // 0x0x40
    public string <Arguments>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseOutputItemEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseOutputItemEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public int <OutputIndex>k__BackingField;    // 0x0x28
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseStatusDetailsDTO
//   (not directly referenced by a detected call)
public class ResponseStatusDetailsDTO
{
    public ResponseStatus <Type>k__BackingField;    // 0x0x10
    public string <Reason>k__BackingField;    // 0x0x18
    public ResponseErrorDTO <Error>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseTextDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseTextDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Delta>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.SessionDTO
//   (not directly referenced by a detected call)
public class SessionDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public DateTime <ExpiresAt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.SessionEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class SessionEventDTO : EventBaseDTO
{
    public SessionDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.TokenDetailsDTO
//   (not directly referenced by a detected call)
public class TokenDetailsDTO
{
    public int <TextTokens>k__BackingField;    // 0x0x10
    public int <AudioTokens>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.TokenUsageDTO
//   (not directly referenced by a detected call)
public class TokenUsageDTO
{
    public int <TotalTokens>k__BackingField;    // 0x0x10
    public int <InputTokens>k__BackingField;    // 0x0x14
    public int <OutputTokens>k__BackingField;    // 0x0x18
    public InputTokenDetailsDTO <InputTokenDetails>k__BackingField;    // 0x0x20
    public TokenDetailsDTO <OutputTokenDetails>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ToolDTO
//   (not directly referenced by a detected call)
public class ToolDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public JsonSchema <Parameters>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateInputVoiceTranscriptionEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateInputVoiceTranscriptionEventDTO : ClientEventBaseDTO
{
    public UpdateInputVoiceTranscriptionDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateInstructionsEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateInstructionsEventDTO : ClientEventBaseDTO
{
    public UpdateInstructionsDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateSessionAudioConfigEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateSessionAudioConfigEventDTO : ClientEventBaseDTO
{
    public UpdateSessionAudioConfigDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateToolConfigEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateToolConfigEventDTO : ClientEventBaseDTO
{
    public UpdateToolConfigDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.RoomieAI.ManageUserMemoryResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ManageUserMemoryResult : ValueType
{
    public bool Success;    // 0x0x0
    public string Message;    // 0x0x8
    public string Error;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.DataLayer.RoomKeyResult
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{iLMMCNCEOHD}   [Service.Econ]
public enum RoomKeyResult
{
    Success = 0,
    InvalidParameters = 1,
    DoesNotExist = 2,
    NameTooShort = 3,
    NameTooLong = 4,
    DuplicateName = 5,
    InappropriateName = 6,
    DescriptionTooShort = 7,
    DescriptionTooLong = 8,
    InappropriateDescription = 9,
    PriceIsInvalid = 10,
    PermissionDenied = 12,
    PlayerHasRoomUnderModerationReview = 13,
    JuniorStatusFail = 14,
    PlayerIsNotCoOwner = 15,
    RoomKeyLimitReached = 16,
    PlayerAlreadyOwns = 17,
    RoomUnderModerationReview = 18,
    PurchaseFailed = 19,
    RoomDoesNotExist = 20,
    PaidKeyPurchasingDisabled = 21,
    CreateOrModifyKeysDisabled = 22,
    RoomKeyUnderModerationReview = 23,
    PlayerRestrictedFromP2PSelling = 24,
    PlayerNotRecRoomPlusMember = 25,
    InvalidRoomCurrency = 26,
    RoomCurrenciesAreDisabled = 27,
    ImageDoesNotExist = 28,
    NotEnoughCurrency = 29,
    PlayerRestrictedFromP2PBuying = 30,
}

// --------------------------------------------------------------------------
// RecRoom.Debugging.AutocompleteResult
// base   : UnityEngine.MonoBehaviour
//   (not directly referenced by a detected call)
public class AutocompleteResult : MonoBehaviour
{
    public RawImage backgroundImage;    // 0x0x18
    public TMP_Text text;    // 0x0x20
    public bool ANNAOBFOHCP;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class SA_Result
{
    public SA_Error m_error;    // 0x0x10
    public string m_requestId;    // 0x0x18
    public string m_stringData;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_iResult
//   (not directly referenced by a detected call)
public class SA_iResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.Contacts.ISN_CNContactsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_CNContactsResult : SA_Result
{
    public List<ISN_CNContact> m_Contacts;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.Social.ISN_UIActivityViewControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIActivityViewControllerResult : SA_Result
{
    public string m_ActivityType;    // 0x0x28
    public bool m_Completed;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKProductsResponse
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_SKProductsResponse : SA_Result
{
    public List<ISN_SKProduct> m_Products;    // 0x0x28
    public List<string> m_InvalidProductIdentifiers;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKReceiptRefreshRequest
// base   : SA.iOS.StoreKit.ISN_SKRequest
//   (not directly referenced by a detected call)
public class ISN_SKReceiptRefreshRequest : ISN_SKRequest
{
    public ISN_SKReceiptDictionary m_Properties;    // 0x0x10
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKRequest
//   (not directly referenced by a detected call)
public class ISN_SKRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Steamworks.CallResult
//   (not directly referenced by a detected call)
public class CallResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Steamworks.EResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EResult
{
    k_EResultNone = 0,
    k_EResultOK = 1,
    k_EResultFail = 2,
    k_EResultNoConnection = 3,
    k_EResultInvalidPassword = 5,
    k_EResultLoggedInElsewhere = 6,
    k_EResultInvalidProtocolVer = 7,
    k_EResultInvalidParam = 8,
    k_EResultFileNotFound = 9,
    k_EResultBusy = 10,
    k_EResultInvalidState = 11,
    k_EResultInvalidName = 12,
    k_EResultInvalidEmail = 13,
    k_EResultDuplicateName = 14,
    k_EResultAccessDenied = 15,
    k_EResultTimeout = 16,
    k_EResultBanned = 17,
    k_EResultAccountNotFound = 18,
    k_EResultInvalidSteamID = 19,
    k_EResultServiceUnavailable = 20,
    k_EResultNotLoggedOn = 21,
    k_EResultPending = 22,
    k_EResultEncryptionFailure = 23,
    k_EResultInsufficientPrivilege = 24,
    k_EResultLimitExceeded = 25,
    k_EResultRevoked = 26,
    k_EResultExpired = 27,
    k_EResultAlreadyRedeemed = 28,
    k_EResultDuplicateRequest = 29,
    k_EResultAlreadyOwned = 30,
    k_EResultIPNotFound = 31,
    k_EResultPersistFailed = 32,
    k_EResultLockingFailed = 33,
    k_EResultLogonSessionReplaced = 34,
    k_EResultConnectFailed = 35,
    k_EResultHandshakeFailed = 36,
    k_EResultIOFailure = 37,
    k_EResultRemoteDisconnect = 38,
    k_EResultShoppingCartNotFound = 39,
    k_EResultBlocked = 40,
    k_EResultIgnored = 41,
    k_EResultNoMatch = 42,
    k_EResultAccountDisabled = 43,
    k_EResultServiceReadOnly = 44,
    k_EResultAccountNotFeatured = 45,
    k_EResultAdministratorOK = 46,
    k_EResultContentVersion = 47,
    k_EResultTryAnotherCM = 48,
    k_EResultPasswordRequiredToKickSession = 49,
    k_EResultAlreadyLoggedInElsewhere = 50,
    k_EResultSuspended = 51,
    k_EResultCancelled = 52,
    k_EResultDataCorruption = 53,
    k_EResultDiskFull = 54,
    k_EResultRemoteCallFailed = 55,
    k_EResultPasswordUnset = 56,
    k_EResultExternalAccountUnlinked = 57,
    k_EResultPSNTicketInvalid = 58,
    k_EResultExternalAccountAlreadyLinked = 59,
    k_EResultRemoteFileConflict = 60,
    k_EResultIllegalPassword = 61,
    k_EResultSameAsPreviousValue = 62,
    k_EResultAccountLogonDenied = 63,
    k_EResultCannotUseOldPassword = 64,
    k_EResultInvalidLoginAuthCode = 65,
    k_EResultAccountLogonDeniedNoMail = 66,
    k_EResultHardwareNotCapableOfIPT = 67,
    k_EResultIPTInitError = 68,
    k_EResultParentalControlRestricted = 69,
    k_EResultFacebookQueryError = 70,
    k_EResultExpiredLoginAuthCode = 71,
    k_EResultIPLoginRestrictionFailed = 72,
    k_EResultAccountLockedDown = 73,
    k_EResultAccountLogonDeniedVerifiedEmailRequired = 74,
    k_EResultNoMatchingURL = 75,
    k_EResultBadResponse = 76,
    k_EResultRequirePasswordReEntry = 77,
    k_EResultValueOutOfRange = 78,
    k_EResultUnexpectedError = 79,
    k_EResultDisabled = 80,
    k_EResultInvalidCEGSubmission = 81,
    k_EResultRestrictedDevice = 82,
    k_EResultRegionLocked = 83,
    k_EResultRateLimitExceeded = 84,
    k_EResultAccountLoginDeniedNeedTwoFactor = 85,
    k_EResultItemDeleted = 86,
    k_EResultAccountLoginDeniedThrottle = 87,
    k_EResultTwoFactorCodeMismatch = 88,
    k_EResultTwoFactorActivationCodeMismatch = 89,
    k_EResultAccountAssociatedToMultiplePartners = 90,
    k_EResultNotModified = 91,
    k_EResultNoMobileDevice = 92,
    k_EResultTimeNotSynced = 93,
    k_EResultSmsCodeFailed = 94,
    k_EResultAccountLimitExceeded = 95,
    k_EResultAccountActivityLimitExceeded = 96,
    k_EResultPhoneActivityLimitExceeded = 97,
    k_EResultRefundToWallet = 98,
    k_EResultEmailSendFailure = 99,
    k_EResultNotSettled = 100,
    k_EResultNeedCaptcha = 101,
    k_EResultGSLTDenied = 102,
    k_EResultGSOwnerDenied = 103,
    k_EResultInvalidItemType = 104,
    k_EResultIPBanned = 105,
    k_EResultGSLTExpired = 106,
    k_EResultInsufficientFunds = 107,
    k_EResultTooManyPending = 108,
    k_EResultNoSiteLicensesFound = 109,
    k_EResultWGNetworkSendExceeded = 110,
    k_EResultAccountNotFriends = 111,
    k_EResultLimitedUserAccount = 112,
    k_EResultCantRemoveItem = 113,
    k_EResultAccountDeleted = 114,
    k_EResultExistingUserCancelledLicense = 115,
}

// --------------------------------------------------------------------------
// Unity.Scenes.PrefabLoadResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class PrefabLoadResult : ValueType
{
    public Entity PrefabRoot;    // 0x0x0
}

// --------------------------------------------------------------------------
// Unity.Scenes.WeakAssetPrefabLoadRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class WeakAssetPrefabLoadRequest : ValueType
{
    public EntityPrefabReference WeakReferenceId;    // 0x0x0
}

// ==========================================================================
// SYNTHESIZED request DTOs: no wire body DTO was observed;
// these are built from observed form/query params, wrapper
// params and candidate keys. Field origins: form = POST/PUT
// form field, query = URL query param, wrapper = wrapper
// signature (not observed on wire), candidate = low
// confidence key. Names derive from the route.
// ==========================================================================

// api/CampusCard/v1/UpdateAndGetSubscription  [Econ POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [API POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public BGLEIGJCNIL? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public BGLEIGJCNIL MAGGDEGKNCF;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public FOPNIDOJMAH HPNGOAGIOIL;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public JNKHMHMNCDA HHCAOFMCNLG;  // wrapper
    public int? CLIMJGNKGNF;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/modKick  [API POST]
public class PlayerReportingV1ModKickRequest
{
    public CGCFJIMPBOK AHIGNIDPDAJ;  // wrapper
    public object IsFromReport;  // candidate
    public object FromReportCategory;  // candidate
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
}

// api/PlayerReporting/v1/moderationBlockDetails  [API POST]
public class PlayerReportingV1ModerationBlockDetailsRequest
{
    public string deviceToken;  // wrapper
}

// api/PlayerReporting/v1/referee  [API POST]
public class PlayerReportingV1RefereeRequest
{
    public byte[] HPGIDELCODH;  // wrapper
    public JMAAOPJDLJN BJOPABFKAIB;  // wrapper
    public object meta;  // candidate
    public object data;  // candidate
    public object file.bin;  // candidate
}

// api/PlayerReporting/v1/roomModKick  [API POST]
public class PlayerReportingV1RoomModKickRequest
{
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
    public object Reason;  // candidate
}

// api/PlayerReporting/v3/create  [API POST]
public class PlayerReportingV3CreateRequest
{
    public CGCFJIMPBOK EECGPHGFGAH;  // wrapper
    public float? MGBJNJNGNKI;  // wrapper
    public bool? LGELGBMGHLC;  // wrapper
    public object IsFullBodyAvatarReport;  // candidate
    public object IsReporterFullBodyAvatar;  // candidate
    public object IsGiftingReport;  // candidate
    public object ReportCategory;  // candidate
    public object HeightReporter;  // candidate
}

// api/PlayerReporting/v3/voteToKick  [API POST]
public class PlayerReportingV3VoteToKickRequest
{
    public object Response;  // candidate
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
    public object Reason;  // candidate
}

// api/avatar/v1/lockeditems  [Econ GET]
public class AvatarV1LockeditemsRequest
{
    public List<OAJMHFIAABF> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public GJCFPCHPCFH GJIMIGJJJKI;  // wrapper
    public GJCFPCHPCFH? FALKFJFJEIN;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public GJCFPCHPCFH GJIMIGJJJKI;  // wrapper
    public GJCFPCHPCFH? FALKFJFJEIN;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [API POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage IJOJGNJMCGP;  // wrapper
    public CKNFHFAOHEN EECGPHGFGAH;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public CGCFJIMPBOK EECGPHGFGAH;  // wrapper
    public object details;  // candidate
    public object clubId;  // candidate
    public object reportCategory;  // candidate
}

// api/config/v1/backtrace  [API GET]
public class ConfigV1BacktraceRequest
{
    public object allocate;  // candidate
    public object platformType;  // candidate
}

// api/customAvatarItems/v1  [API POST]
public class CustomAvatarItemsV1Request
{
    public MCOEPIIJNLA LDPGNLMNBBL;  // wrapper
    public CIAIMANPFBE BHDCALLBPFB;  // wrapper
    public MKCJAKNBGJG MKFFDHKCKFG;  // wrapper
    public MKCJAKNBGJG JKFJMCNPIMB;  // wrapper
    public object metadata;  // candidate
    public object thumbnailImage;  // candidate
    public object design;  // candidate
    public object file.bin;  // candidate
}

// api/customAvatarItems/v1/design  [API GET]
public class CustomAvatarItemsV1DesignRequest
{
    public object metadata;  // candidate
    public object design;  // candidate
    public object file.bin;  // candidate
}

// api/customAvatarItems/v1/featured  [API GET]
public class CustomAvatarItemsV1FeaturedRequest
{
    public object unityAssetVersion;  // candidate
    public object unityAssetTarget;  // candidate
}

// api/customAvatarItems/v1/hot  [API GET]
public class CustomAvatarItemsV1HotRequest
{
    public object unityAssetVersion;  // candidate
    public object unityAssetTarget;  // candidate
}

// api/customAvatarItems/v1/me  [API GET]
public class CustomAvatarItemsV1MeRequest
{
    public object take;  // candidate
    public object skip;  // candidate
}

// api/customAvatarItems/v1/search  [API GET]
public class CustomAvatarItemsV1SearchRequest
{
    public object outfitTypes;  // candidate
    public object minPrice;  // candidate
    public object isOwned;  // candidate
    public object itemTypes;  // candidate
    public object isFeatured;  // candidate
}

// api/customAvatarItems/v1/{lPOCINEMHOG}/appeal  [API POST]
public class CustomAvatarItemsV1LPOCINEMHOGAppealRequest
{
    public Guid LPOCINEMHOG;  // wrapper
}

// api/customAvatarItems/v2/fromCreator/{aBKNJGDDAOJ}  [API GET]
public class CustomAvatarItemsV2FromCreatorABKNJGDDAOJRequest
{
    public int take;  // wrapper
}

// api/externalfriendinvite/v1/createplatforminvite  [API POST]
public class ExternalfriendinviteV1CreateplatforminviteRequest
{
    public string platformId;  // wrapper
}

// api/externalfriendinvite/v1/sendtextmessageinvite  [API POST]
public class ExternalfriendinviteV1SendtextmessageinviteRequest
{
    public object phoneNumber;  // candidate
    public object senderName;  // candidate
    public object friendCode;  // candidate
}

// api/gamerewards/v1/request  [Econ POST]
public class GamerewardsV1RequestRequest
{
    public AJBJLKCLFGL IOEDFGCHMLD;  // wrapper
    public GJCFPCHPCFH? GBLADIMMHIK;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public BLBIAOANCHJ DCPMIMNCGGI;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/images/  [API GET]
public class ImagesRequest
{
    public object sort;  // candidate
    public object filter;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v4/room/{roomId}  [API GET]
public class ImagesV4RoomRoomIdRequest
{
    public object filter;  // candidate
    public object sort;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v5/bulk  [API ?]
public class ImagesV5BulkRequest
{
    public List<long> ids;  // param
}

// api/images/v5/cheered/bulk  [API ?]
public class ImagesV5CheeredBulkRequest
{
    public List<long> id;  // param
}

// api/images/v5/player/{playerId}  [API GET]
public class ImagesV5PlayerPlayerIdRequest
{
    public object sort;  // candidate
}

// api/images/v6  [API GET]
public class ImagesV6Request
{
    public string name;  // wrapper
}

// api/incentivizedreferrals/claim  [Econ POST]
public class IncentivizedreferralsClaimRequest
{
    public int ReferralRewardId;  // wrapper
}

// api/incentivizedreferrals/referrals  [Econ GET]
public class IncentivizedreferralsReferralsRequest
{
    public object continuationToken;  // candidate
    public object take;  // candidate
}

// api/influencerpartnerprogram/influencer  [Econ GET]
public class InfluencerpartnerprogramInfluencerRequest
{
    public int accountId;  // wrapper
}

// api/influencerpartnerprogram/influencers  [Econ GET]
public class InfluencerpartnerprogramInfluencersRequest
{
    public object continuationToken;  // candidate
    public object take;  // candidate
}

// api/influencerpartnerprogram/remove  [Econ POST]
public class InfluencerpartnerprogramRemoveRequest
{
    public int influencerAccountId;  // wrapper
}

// api/influencerpartnerprogram/support  [Econ POST]
public class InfluencerpartnerprogramSupportRequest
{
    public int influencerAccountId;  // wrapper
}

// api/inventions/v1/details  [API GET]
public class InventionsV1DetailsRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v1/dormskinsfromids  [API ?]
public class InventionsV1DormskinsfromidsRequest
{
    public List<long> ids;  // param
}

// api/inventions/v1/fulllineageowner  [API GET]
public class InventionsV1FulllineageownerRequest
{
    public List<long> id;  // query
}

// api/inventions/v1/versions  [API GET]
public class InventionsV1VersionsRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v2/batch  [API ?]
public class InventionsV2BatchRequest
{
    public List<long> id;  // param
}

// api/inventions/v2/search  [API GET]
public class InventionsV2SearchRequest
{
    public object value;  // candidate
    public object ugcVersion;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/itemWishlists/v1/isonwishlist/bulk  [Econ POST]
public class ItemWishlistsV1IsonwishlistBulkRequest
{
    public List<int> accountIds;  // form
}

// api/itemWishlists/v1/wishlist/add  [Econ POST]
public class ItemWishlistsV1WishlistAddRequest
{
    public int? EBPOEEFPKPL;  // wrapper
    public Guid? LPOCINEMHOG;  // wrapper
    public object customAvatarItemId;  // candidate
    public object purchasableItemId;  // candidate
}

// api/itemWishlists/v1/wishlist/remove  [Econ POST]
public class ItemWishlistsV1WishlistRemoveRequest
{
    public int? EBPOEEFPKPL;  // wrapper
    public Guid? LPOCINEMHOG;  // wrapper
    public object customAvatarItemId;  // candidate
    public object purchasableItemId;  // candidate
}

// api/keepsakes/{aPLOIMOLGJJ}/collect  [API POST]
public class KeepsakesAPLOIMOLGJJCollectRequest
{
    public Guid APLOIMOLGJJ;  // wrapper
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public GBPCMLAKICH HHPGEEEEHGL;  // wrapper
    public long? FHOIPEIAACP;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/offlineinvite/v1/send  [API POST]
public class OfflineinviteV1SendRequest
{
    public long PlayerId;  // wrapper
}

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/clubs  [API POST]
public class PlayereventsV1ClubsRequest
{
    public IReadOnlyCollection<long> KEIGEODNDCO;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public DLCBOABCOBP LDPGNLMNBBL;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? FFBFPEHMLMB;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public HDDHKLHPFPJ CMOLGKGFDGK;  // wrapper
    public HDDHKLHPFPJ FICJEBKPGBD;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? IIHAMPMIGID;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime JCDBIBKMNJP;  // wrapper
    public DateTime IEBICIECCML;  // wrapper
}

// api/playeritems/v1/isavataritemowned/bulk  [Econ POST]
public class PlayeritemsV1IsavataritemownedBulkRequest
{
    public List<int> accountIds;  // form
}

// api/playeritems/v1/isequipmentitemowned/bulk  [Econ POST]
public class PlayeritemsV1IsequipmentitemownedBulkRequest
{
    public List<int> accountIds;  // form
}

// api/playerwarnings  [API POST]
public class PlayerwarningsRequest
{
    public CGCFJIMPBOK EECGPHGFGAH;  // wrapper
    public object ModeratorNote;  // candidate
    public object WarnedPlayerId;  // candidate
    public object ReportCategory;  // candidate
    public object DisplayReason;  // candidate
}

// api/relationships/  [API POST]
public class RelationshipsRequest
{
    public object PlayerId;  // candidate
}

// api/relationships/v1/addfriendwithcode  [API GET]
public class RelationshipsV1AddfriendwithcodeRequest
{
    public object code;  // candidate
}

// api/roomCurrencies/v2/purchase  [Econ POST]
public class RoomCurrenciesV2PurchaseRequest
{
    public Guid MJOHCAKFICN;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomcurrencies/v1/createCurrency  [Econ POST]
public class RoomcurrenciesV1CreateCurrencyRequest
{
    public object Color;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object Shape;  // candidate
}

// api/roomcurrencies/v1/createPurchaseOffer  [Econ POST]
public class RoomcurrenciesV1CreatePurchaseOfferRequest
{
    public Guid JDPBJFKAIBO;  // wrapper
    public object Price;  // candidate
    public object CurrencyId;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object Order;  // candidate
}

// api/roomcurrencies/v1/currencies  [Econ GET]
public class RoomcurrenciesV1CurrenciesRequest
{
    public object roomId;  // candidate
}

// api/roomcurrencies/v1/deletePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1DeletePurchaseOfferRequest
{
    public Guid PurchaseOfferId;  // wrapper
}

// api/roomcurrencies/v1/getAllBalances  [Econ GET]
public class RoomcurrenciesV1GetAllBalancesRequest
{
    public object roomId;  // candidate
}

// api/roomcurrencies/v1/getBalance  [Econ GET]
public class RoomcurrenciesV1GetBalanceRequest
{
    public object accountId;  // candidate
    public object currencyId;  // candidate
}

// api/roomcurrencies/v1/updateCurrency  [Econ POST]
public class RoomcurrenciesV1UpdateCurrencyRequest
{
    public Guid JDPBJFKAIBO;  // wrapper
    public long? JJKKBPEEGAN;  // wrapper
    public byte? EBHEGJDIFIE;  // wrapper
    public int? JJNDBAIEAAG;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid MJOHCAKFICN;  // wrapper
    public long? DLNAJFLMHAB;  // wrapper
    public long? DPLKFDPKGLG;  // wrapper
    public int? OGABEPJBEMN;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> JKGCHKOAIPN;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public BOHNLAOMCDN HHCAOFMCNLG;  // wrapper
    public Guid? NMHJIDLLIPJ;  // wrapper
    public object Price;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Type;  // candidate
    public object RoomId;  // candidate
}

// api/roomkeys/v1/owns  [Econ GET]
public class RoomkeysV1OwnsRequest
{
    public object playerId;  // candidate
    public object roomKeyId;  // candidate
}

// api/rooms/v1/verifyRole  [API POST]
public class RoomsV1VerifyRoleRequest
{
    public object roomId;  // candidate
    public object role;  // candidate
    public object context;  // candidate
}

// api/rooms/v2/report  [API POST]
public class RoomsV2ReportRequest
{
    public CGCFJIMPBOK EECGPHGFGAH;  // wrapper
    public long? JNFKBHADDOK;  // wrapper
    public Guid? BLEFGDKGHED;  // wrapper
    public int? BPCBOMLBIND;  // wrapper
    public object RoomOfferVersion;  // candidate
    public object ReportCategory;  // candidate
    public object RoomOfferId;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
}

// api/screensharereports/v1/report  [API POST]
public class ScreensharereportsV1ReportRequest
{
    public object ReportedPlayerId;  // candidate
    public object RoomInstanceId;  // candidate
    public object ImageName;  // candidate
    public object RoomInstanceType;  // candidate
    public object RoomId;  // candidate
}

// api/storefronts/v1/PurchaseRoomKeyWithCurrency  [Econ POST]
public class StorefrontsV1PurchaseRoomKeyWithCurrencyRequest
{
    public Guid PPFMEHPOLFN;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid HAIBNMNGEEK;  // wrapper
    public object progressionEventId;  // candidate
    public object requestedPrice;  // candidate
    public object purchasableXpBoostId;  // candidate
    public object expectedXp;  // candidate
}

// api/storefronts/v1/buyPurchaseReminder  [Econ POST]
public class StorefrontsV1BuyPurchaseReminderRequest
{
    public object purchaseReminderId;  // candidate
    public object requestedPrice;  // candidate
}

// api/storefronts/v1/buyRoomKey  [Econ GET]
public class StorefrontsV1BuyRoomKeyRequest
{
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v2/trialInvention  [Econ POST]
public class StorefrontsV2TrialInventionRequest
{
    public long inventionId;  // wrapper
}

// api/testcasemanagement/v1/testcase/  [API POST]
public class TestcasemanagementV1TestcaseRequest
{
    public KADABDADOKL PKMGJGEINCO;  // wrapper
}

