// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 223 (plus referenced enums)

// --------------------------------------------------------------------------
// ABNCMBBACKE
//   RESPONSE POST   api/inventions/v1/cheer   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/delete   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/update   [Service.Auth]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.Auth]
//   RESPONSE GET    api/inventions/v3/publish   [Service.Matchmaking]
//   RESPONSE POST   api/inventions/v6/addversion   [Service.Matchmaking]
//   RESPONSE POST   api/inventions/v7/save   [Service.Matchmaking]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.WWW]
public class ABNCMBBACKE
{
    public LHCHEPPKDCC <FEAJEPMJNLH>k__BackingField;    // 0x0x10
    public ADHBHAOOFDC <CPIGHACGHBC>k__BackingField;    // 0x0x18
    public LEIGJHACJBP <GJGJPECCLNC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ACOOIPLFNCG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ACOOIPLFNCG
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
    RoomCurrency = 1200,
    Wishlist = 1300,
    RoomConsumable = 1400,
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
    CustomAvatarItems = 1800,
    ProgressionEventPurchasableXpBoosts = 1900,
    PopUpShop_ProgressionEvent_1 = 2000,
    PopUpShop_ProgressionEvent_2 = 2001,
    PopUpShop_ProgressionEvent_3 = 2002,
    PopUpShop_ProgressionEvent_4 = 2003,
    PopUpShop_ProgressionEvent_5 = 2004,
    RoomOffers = 2100,
}

// --------------------------------------------------------------------------
// ADAIPLFMBDE
//   (not directly referenced by a detected call)
public class ADAIPLFMBDE
{
    public string <BNGNMEANONG>k__BackingField;    // 0x0x10
    public CAMNICCJNCM <JFCKCJEOJNA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ADHBHAOOFDC
//   (not directly referenced by a detected call)
public class ADHBHAOOFDC
{
    public ObscuredLong <NFJGLPLJEAH>k__BackingField;    // 0x0x10
    public string <CGPKINMCEAP>k__BackingField;    // 0x0x38
    public ObscuredInt <ECABGBMNPMA>k__BackingField;    // 0x0x40
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x58
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x60
    public string <CMDIKLHCBOH>k__BackingField;    // 0x0x68
    public byte <GGGDKLDEPHI>k__BackingField;    // 0x0x70
    public int <BJFMOCLNCMO>k__BackingField;    // 0x0x74
    public BAJMPAINDDM <MPDOKFNONGF>k__BackingField;    // 0x0x78
    public bool <CEAEFMJCBAB>k__BackingField;    // 0x0x7C
    public DateTime <HIIBLOFOIBC>k__BackingField;    // 0x0x80
    public DateTime <BCPKMACFAFI>k__BackingField;    // 0x0x88
    public DateTime? <LEAOFOHJGAA>k__BackingField;    // 0x0x90
    public long? <KKDLEAMKMKN>k__BackingField;    // 0x0xA0
    public int <NKPCFLHKCJF>k__BackingField;    // 0x0xB0
    public int <JHBKMGKCDNP>k__BackingField;    // 0x0xB4
    public int <DGGJGKHBKPD>k__BackingField;    // 0x0xB8
    public CEAHAODEDBD <FADPPMEBODC>k__BackingField;    // 0x0xBC
    public CEAHAODEDBD <FGNMBDFOFGF>k__BackingField;    // 0x0xC0
    public ObscuredBool <GNEDGJCLGJG>k__BackingField;    // 0x0xC4
    public ObscuredBool <FCAPOFMDFJC>k__BackingField;    // 0x0xD0
    public ObscuredBool <NFKKJHHEKMK>k__BackingField;    // 0x0xDC
    public int? <MJBJBJLOOLB>k__BackingField;    // 0x0xE8
    public bool <AJFNKHMPHBD>k__BackingField;    // 0x0xF0
}

// --------------------------------------------------------------------------
// AECNDJCACEJ
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2/delete/{aNKGECEILCH}   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2/{eventId}   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/accessibility   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/club   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/description   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/image   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/multiinstance   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/name   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/room   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/tags   [Service.Auth]
//   RESPONSE PUT    api/playerevents/v2/{eventId}/time   [Service.Auth]
public class AECNDJCACEJ
{
    public PJNBAFDENBA <PPFJFMMIHGB>k__BackingField;    // 0x0x10
    public MLKJMPINDHA <ANAHOCKEDEJ>k__BackingField;    // 0x0x18
    public MMOGLEMFEDF <PCMLCCHEIBP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AEIMPGMNLHG
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.WWW]
public class AEIMPGMNLHG
{
    public long <LDAGIFHJLBO>k__BackingField;    // 0x0x10
    public int <NNJDGMFOAAJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AELBGLNPCFK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AELBGLNPCFK
{
    Invalid = 0,
    LaserTagTickets = 1,
    RecCenterTokens = 2,
    LostSkullsGold = 100,
    DraculaSilver = 101,
    RecRoyale_Season1 = 200,
    RoomCurrency = 300,
    ProgressionEvent = 400,
}

// --------------------------------------------------------------------------
// AFBMHMGJHAN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AFBMHMGJHAN
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// AFEDAMADDKP
// base   : KMEJCOLBENK
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/season/{hFPMKPDJCGL}   [Service.WWW]
public class AFEDAMADDKP : KMEJCOLBENK
{
    public int <EPJOLNFHFDG>k__BackingField;    // 0x0x30
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x38
    public DateTime <LCIIAOMBPMA>k__BackingField;    // 0x0x40
    public DateTime <CIDGJNBNFIC>k__BackingField;    // 0x0x48
    public AELBGLNPCFK <KBFIOMGPIOH>k__BackingField;    // 0x0x50
    public FJLGBAMHLFB <AGMHELHCKCE>k__BackingField;    // 0x0x58
    public List<PFOGPKAKBNE> <APNGOGILDEL>k__BackingField;    // 0x0x60
    public HGFKJJBAKIE <PKFMCGIOMGE>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// AFMJOIJBDLO
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.WWW]
public class AFMJOIJBDLO
{
    public Guid <NLHIHNEANHF>k__BackingField;    // 0x0x10
    public int <IDFEAIECBGM>k__BackingField;    // 0x0x20
    public long <LHKJKBFGLCC>k__BackingField;    // 0x0x28
    public Guid <GLKCKCICLAI>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// AGNPHACIMEJ
//   RESPONSE POST   api/AppIntegrity/v1/iospaymentqueuefailed   [Service.Auth]
//   RESPONSE POST   api/AppIntegrity/v1/iosproducts   [Service.Auth]
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.Auth]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.?]
//   RESPONSE POST   api/inventions/v1/report   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/report   [Service.Auth]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.Auth]
//   RESPONSE POST   api/rooms/v2/report   [Service.Auth]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.Auth]
public class AGNPHACIMEJ
{
    public bool <ONPEMCIENBA>k__BackingField;    // 0x0x10
    public string <BLDNMPNAADO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AIDALAABBPI
// base   : JDIIANFINCF
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.WWW]
public class AIDALAABBPI : JDIIANFINCF
{
    public FMLPPNOINFL? <LLKHBNMDGDB>k__BackingField;    // 0x0x18
    public PKMAIFDBNMG <HJHFEIMENJM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AIFDHIGNHAD
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.WWW]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
//   RESPONSE GET    api/avatar/v4/items   [Service.WWW]
public class AIFDHIGNHAD
{
    public FAHAPBHFJAM <FOPDCBAJDAB>k__BackingField;    // 0x0x10
    public string <JJJICAKFJKK>k__BackingField;    // 0x0x18
    public string <KHFOPNIGPDI>k__BackingField;    // 0x0x20
    public string <AHKPAMPMHJF>k__BackingField;    // 0x0x28
    public JNOLMELBJHO <GGEFGOCBOLN>k__BackingField;    // 0x0x30
    public string <CAJOKJPJLLN>k__BackingField;    // 0x0x38
    public int <PFNAIIEGGKG>k__BackingField;    // 0x0x40
    public bool <HLKBDKBGJIN>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// ALHCHJNICCJ
//   (not directly referenced by a detected call)
public class ALHCHJNICCJ
{
    public int <KINHEHEBMGF>k__BackingField;    // 0x0x10
    public DateTime <BCPKMACFAFI>k__BackingField;    // 0x0x18
    public DateTime? <NIPGEAKJGPB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BAJMPAINDDM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BAJMPAINDDM
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// BDNAKPOMLNB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BDNAKPOMLNB
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
// BIJPIFIGBOF
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.Auth]
public class BIJPIFIGBOF
{
    public List<string> <MHIKHKMGJBM>k__BackingField;    // 0x0x10
    public List<string> <ODKOOBEGOOP>k__BackingField;    // 0x0x18
    public List<string> <DHFPKJEABOG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BPFGHCGMCIE
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.WWW]
public class BPFGHCGMCIE
{
    public List<int> <CNPIJPLBECL>k__BackingField;    // 0x0x10
    public string <PLHFHKKGFLP>k__BackingField;    // 0x0x18
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
    public bool <IsUpgraded>k__BackingField;    // 0x0x50
    public List<Cookie> <Cookies>k__BackingField;    // 0x0x58
    public string dataAsText;    // 0x0x60
    public Texture2D texture;    // 0x0x68
    public bool <IsClosedManually>k__BackingField;    // 0x0x70
    public HTTPRequest baseRequest;    // 0x0x78
    public Stream Stream;    // 0x0x80
    public List<byte[]> streamedFragments;    // 0x0x88
    public object SyncRoot;    // 0x0x90
    public byte[] fragmentBuffer;    // 0x0x98
    public int fragmentBufferDataLength;    // 0x0xA0
    public Stream cacheStream;    // 0x0xA8
    public int allFragmentSize;    // 0x0xB0
    public BufferPoolMemoryStream decompressorInputStream;    // 0x0xB8
    public BufferPoolMemoryStream decompressorOutputStream;    // 0x0xC0
    public GZipStream decompressorGZipStream;    // 0x0xC8
    public AutoResetEvent fragmentWaitEvent;    // 0x0xD0
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
    public WebSocket <WebSocket>k__BackingField;    // 0x0xD8
    public Action<WebSocketResponse, string> OnText;    // 0x0xE0
    public Action<WebSocketResponse, byte[]> OnBinary;    // 0x0xE8
    public Action<WebSocketResponse, WebSocketFrameReader> OnIncompleteFrame;    // 0x0xF0
    public Action<WebSocketResponse, ushort, string> OnClosed;    // 0x0xF8
    public TimeSpan <PingFrequnecy>k__BackingField;    // 0x0x100
    public ushort <MaxFragmentSize>k__BackingField;    // 0x0x108
    public int _bufferedAmount;    // 0x0x10C
    public int <Latency>k__BackingField;    // 0x0x110
    public List<WebSocketFrameReader> IncompleteFrames;    // 0x0x118
    public List<WebSocketFrameReader> CompletedFrames;    // 0x0x120
    public List<WebSocketFrameReader> frameCache;    // 0x0x128
    public WebSocketFrameReader CloseFrame;    // 0x0x130
    public object FrameLock;    // 0x0x150
    public object SendLock;    // 0x0x158
    public List<WebSocketFrame> unsentFrames;    // 0x0x160
    public AutoResetEvent newFrameSignal;    // 0x0x168
    public bool sendThreadCreated;    // 0x0x170
    public bool closeSent;    // 0x0x171
    public bool closed;    // 0x0x172
    public DateTime lastPing;    // 0x0x178
    public DateTime lastMessage;    // 0x0x180
    public CircularBuffer<int> rtts;    // 0x0x188
}

// --------------------------------------------------------------------------
// CAMNICCJNCM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CAMNICCJNCM
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// CBEFOGOIJLA
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.Auth]
public class CBEFOGOIJLA
{
    public MLKJMPINDHA <ANAHOCKEDEJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// CCBBMFGIOMF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CCBBMFGIOMF
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
    Toaster = 512,
}

// --------------------------------------------------------------------------
// CCMKILKCIHN
//   RESPONSE GET    api/config/v1/amplitude   [Service.Auth]
public class CCMKILKCIHN
{
    public string <KMGIILMJHME>k__BackingField;    // 0x0x10
    public string <OPNFCHEOHEN>k__BackingField;    // 0x0x18
    public bool <BMGLCFPNGOP>k__BackingField;    // 0x0x20
    public string <NNHECFEBBMF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// CEAHAODEDBD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CEAHAODEDBD
{
    Unassigned = 0,
    LimitedOneUseOnly = 10,
    DisallowKeyLock = 15,
    UseOnly = 20,
    EditAndSave = 40,
    Publish = 60,
    Charge = 80,
    Unlimited = 100,
}

// --------------------------------------------------------------------------
// CFBIMFEMKPF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CFBIMFEMKPF
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// CFLOBHPJGHE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CFLOBHPJGHE
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// CHOEDECFNMC
//   (not directly referenced by a detected call)
public class CHOEDECFNMC
{
    public Guid <FCHCFDEMGKN>k__BackingField;    // 0x0x10
    public Guid <GEFMAFJGFNH>k__BackingField;    // 0x0x20
    public DateTime <LCIIAOMBPMA>k__BackingField;    // 0x0x30
    public List<DJAINENAGOB> <KIIAAKJMPID>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// CKAGMGEKDGE
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.WWW]
public class CKAGMGEKDGE
{
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <ABMMNBPDNCB>k__BackingField;    // 0x0x18
    public PMJNAMEHOKL <PPMHOAMBBHE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CPJNILAACID
//   REQUEST  POST   api/playerevents/v1/report   [Service.Auth]
public class CPJNILAACID
{
    public INJMGIDEJOA <MNBPAMJFLDN>k__BackingField;    // 0x0x10
    public long <FADGDMJCJLI>k__BackingField;    // 0x0x18
    public string <KMHOFHHEMJO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CodeStage.AntiCheat.ObscuredTypes.ObscuredBool
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ObscuredBool : ValueType
{
    public byte currentCryptoKey;    // 0x0x0
    public int hiddenValue;    // 0x0x4
    public bool inited;    // 0x0x8
    public bool fakeValue;    // 0x0x9
    public bool fakeValueActive;    // 0x0xA
}

// --------------------------------------------------------------------------
// CodeStage.AntiCheat.ObscuredTypes.ObscuredInt
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ObscuredInt : ValueType
{
    public int currentCryptoKey;    // 0x0x0
    public int hiddenValue;    // 0x0x4
    public bool inited;    // 0x0x8
    public int fakeValue;    // 0x0xC
    public bool fakeValueActive;    // 0x0x10
}

// --------------------------------------------------------------------------
// CodeStage.AntiCheat.ObscuredTypes.ObscuredLong
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ObscuredLong : ValueType
{
    public long currentCryptoKey;    // 0x0x0
    public long hiddenValue;    // 0x0x8
    public bool inited;    // 0x0x10
    public long fakeValue;    // 0x0x18
    public bool fakeValueActive;    // 0x0x20
}

// --------------------------------------------------------------------------
// DAJCJHKCJBN
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.?]
public class DAJCJHKCJBN
{
    public int? <JOAEOLLCLCI>k__BackingField;    // 0x0x10
    public string <IADFCCGOEKH>k__BackingField;    // 0x0x18
    public string <MGGDAKCEBEL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DDEMLAKDJPC
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{kLPBLNIFOBJ}/{cKFPKHFJDLF}   [Service.WWW]
public class DDEMLAKDJPC
{
    public AELBGLNPCFK <KBFIOMGPIOH>k__BackingField;    // 0x0x10
    public LCLEJEFNMIG <BDJLPHJHJEF>k__BackingField;    // 0x0x14
    public int <PHGNEBDFODF>k__BackingField;    // 0x0x18
    public int <JMCHLNCHOLL>k__BackingField;    // 0x0x1C
    public int <BKAPNFOEKPJ>k__BackingField;    // 0x0x20
    public ILJFKJDNOMF <OBHEMFCELPG>k__BackingField;    // 0x0x24
    public bool <CDNMPMCIFMK>k__BackingField;    // 0x0x28
    public float <MDCDLKOBBGK>k__BackingField;    // 0x0x2C
    public int <JLPLBAMOKIC>k__BackingField;    // 0x0x30
    public bool <BJCMLONDPKD>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// DDJAHCFDHHC
//   (not directly referenced by a detected call)
public class DDJAHCFDHHC
{
    public int <OJCAFJOAOCN>k__BackingField;    // 0x0x10
    public MLKJMPINDHA <ANAHOCKEDEJ>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// DJAINENAGOB
//   (not directly referenced by a detected call)
public class DJAINENAGOB
{
    public int <BBOGNJMDFMI>k__BackingField;    // 0x0x10
    public string <KHFOPNIGPDI>k__BackingField;    // 0x0x18
    public string <AHKPAMPMHJF>k__BackingField;    // 0x0x20
    public string <CAJOKJPJLLN>k__BackingField;    // 0x0x28
    public string <PJNNGCMBCLF>k__BackingField;    // 0x0x30
    public string <CNLPFBCFKHO>k__BackingField;    // 0x0x38
    public FAHAPBHFJAM? <FOPDCBAJDAB>k__BackingField;    // 0x0x40
    public string <OLIONJDGOCH>k__BackingField;    // 0x0x48
    public string <FJPAEODHDMC>k__BackingField;    // 0x0x50
    public bool <ILPKBDJFMMM>k__BackingField;    // 0x0x58
    public bool <CHCOPLBBKJI>k__BackingField;    // 0x0x59
    public bool <PJKBJCGCICF>k__BackingField;    // 0x0x5A
    public JNOLMELBJHO <GGEFGOCBOLN>k__BackingField;    // 0x0x5C
    public AELBGLNPCFK <KBFIOMGPIOH>k__BackingField;    // 0x0x60
    public int <GGGKIBPOMCE>k__BackingField;    // 0x0x64
    public LGIPIODCKLD <BINGEJKKPEJ>k__BackingField;    // 0x0x68
    public EHDLBGOMCAB <EPDJKPKBBLJ>k__BackingField;    // 0x0x6C
    public int? <EAFKPHFBLDI>k__BackingField;    // 0x0x70
    public string <LNKJPMGEFHD>k__BackingField;    // 0x0x78
    public int? <PFNAIIEGGKG>k__BackingField;    // 0x0x80
    public int? <NLFHNHBAOLK>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// DJNOIADJCHN
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.Auth]
public class DJNOIADJCHN
{
    public string <CEGICJKGANO>k__BackingField;    // 0x0x10
    public string <DMLJOFDALBA>k__BackingField;    // 0x0x18
    public string <FNOFOMHEICN>k__BackingField;    // 0x0x20
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x28
    public string <IADFCCGOEKH>k__BackingField;    // 0x0x30
    public CFBIMFEMKPF <FEAJEPMJNLH>k__BackingField;    // 0x0x38
    public List<string> <NEFIEMBMLIF>k__BackingField;    // 0x0x40
    public List<string> <BOOGFGPPPGO>k__BackingField;    // 0x0x48
    public string <NMEAEMKEGMA>k__BackingField;    // 0x0x50
    public List<NMKLJBJNKHP> <KNEJHLAOKFN>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// EAPGNCCGAJC
//   (not directly referenced by a detected call)
public class EAPGNCCGAJC
{
    public int <INLKAPKBNIJ>k__BackingField;    // 0x0x10
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x18
    public string <HGLAECHFFKB>k__BackingField;    // 0x0x20
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x28
    public string <AHKPAMPMHJF>k__BackingField;    // 0x0x30
    public bool <IGJIMIOHLEK>k__BackingField;    // 0x0x38
    public int <DNFDMFJOBKI>k__BackingField;    // 0x0x3C
    public LKLAAPNNCAI <LDLKBLGPFJE>k__BackingField;    // 0x0x40
    public HPEOOPMOOMA KHPCOFFOOEE;    // 0x0x48
    public HPEOOPMOOMA JJKGABMCCCE;    // 0x0x50
    public HPEOOPMOOMA JGMDAKECELJ;    // 0x0x58
    public NKHDJAOMCDP CNBALBKPKKM;    // 0x0x60
}

// --------------------------------------------------------------------------
// EBLJJHACODM
// base   : JKFOBEDGDAL`1<FNCIPLMHGGI>
//   RESPONSE GET    api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{dFDFMHMGBMN}   [Service.Auth]
public class EBLJJHACODM
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// EDNPFECNKPI
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.WWW]
public class EDNPFECNKPI
{
    public long <LDAGIFHJLBO>k__BackingField;    // 0x0x10
    public int <NNJDGMFOAAJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EENGLCJFHDC
// base   : JDIIANFINCF
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.WWW]
public class EENGLCJFHDC : JDIIANFINCF
{
    public GJNLMHNHJHG? <LLKHBNMDGDB>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <NEOOBEOBCFB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EFEFGJIJAND
//   REQUEST  POST   api/roomcurrencies   [Service.WWW]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.WWW]
public class EFEFGJIJAND
{
    public Guid <GLKCKCICLAI>k__BackingField;    // 0x0x10
    public long <PLAKAPOJBMN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EHDLBGOMCAB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EHDLBGOMCAB
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
// EKJCLEAALGJ
//   RESPONSE GET    api/config/v2   [Service.Auth]
public class EKJCLEAALGJ
{
    public Dictionary<int, int> <GJBNKNDODFC>k__BackingField;    // 0x0x10
    public List<KLDBDEJAJLK> <FDLOOGINLBE>k__BackingField;    // 0x0x18
    public FCOMBOBBFJI[][] <HIMIJGMCCFD>k__BackingField;    // 0x0x20
    public IFNLJDIEHHJ <FAHNCPEHILE>k__BackingField;    // 0x0x28
    public KPJJPHDHKCB <GNGKAEOCBHK>k__BackingField;    // 0x0x30
    public FOIHKIMLDDI <BLDPGOJBIGN>k__BackingField;    // 0x0x38
    public GKOFDEICCLI <MBIHNOLPPLK>k__BackingField;    // 0x0x40
    public GGLFHPFJGLF <DLEOIGHLDGF>k__BackingField;    // 0x0x48
    public string <OEJMILPALIP>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// EMIHCNKDNLH
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.Auth]
public class EMIHCNKDNLH
{
    public int <KFLGMMFGPFI>k__BackingField;    // 0x0x10
    public int? <JEODCNOOJGI>k__BackingField;    // 0x0x14
    public string <EFALANGCJIK>k__BackingField;    // 0x0x20
    public string <FIMLBNBBHLB>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// EMNBHHLDNEL
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.Auth]
public class EMNBHHLDNEL
{
    public INJMGIDEJOA <MNBPAMJFLDN>k__BackingField;    // 0x0x10
    public int <MHLBCHNBIBF>k__BackingField;    // 0x0x14
    public long <IHLINAFBENE>k__BackingField;    // 0x0x18
    public bool <FNNOMGFODEL>k__BackingField;    // 0x0x20
    public string <BLDNMPNAADO>k__BackingField;    // 0x0x28
    public int? <FAMOPHPNCEI>k__BackingField;    // 0x0x30
    public bool <HCLOHIANMCH>k__BackingField;    // 0x0x38
    public bool <OFHNOIOIACO>k__BackingField;    // 0x0x39
    public bool <BBKJNIBKJLN>k__BackingField;    // 0x0x3A
    public bool <KMKHJOPEACB>k__BackingField;    // 0x0x3B
    public string <DCNKHJMBFAN>k__BackingField;    // 0x0x40
    public DateTime? <AHDIHONDOOL>k__BackingField;    // 0x0x48
    public string <GOMKAIHCOKD>k__BackingField;    // 0x0x58
    public float <BGLJGNODFLD>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// EasyAntiCheat.Client.HostValidationResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HostValidationResult
{
    ServerHostValidationSuccess = 0,
    ServerHostValidationFailed = 1,
    ServerHostValidationTimedOut = 2,
}

// --------------------------------------------------------------------------
// EasyAntiCheat.Client.LoadResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LoadResult
{
    InitSuccess = 0,
    LauncherInvalidParameter = 1,
    LauncherDNSError = 2,
    LauncherNetworkError = 3,
    LauncherFailure = 4,
    LauncherInstallError = 5,
    LauncherSuccessUnderWine = 6,
    InitCancelRequested = 7,
    GameClientConnected = 8,
    GameClientDisconnected = 9,
    GameClientAuthenticated = 10,
    GameClientIntegrityViolation = 11,
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
// FAHAPBHFJAM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FAHAPBHFJAM
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// FBDAPPLDEPA
//   REQUEST  POST   api/customAvatarItems   [Service.Auth]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
public class FBDAPPLDEPA
{
    public HBFENMLJGDG <MNBPAMJFLDN>k__BackingField;    // 0x0x10
    public string <KMHOFHHEMJO>k__BackingField;    // 0x0x18
    public int? <NIJEPLGPFMF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FCMLBAMKDEJ
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
public class FCMLBAMKDEJ
{
    public List<string> <NBHCEPEPLGK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FCOMBOBBFJI
//   (not directly referenced by a detected call)
public class FCOMBOBBFJI
{
    public BDNAKPOMLNB PHCFNAFJOGF;    // 0x0x10
    public int EJFOJIHIDJO;    // 0x0x14
}

// --------------------------------------------------------------------------
// FGBHCDFEOLC
//   (not directly referenced by a detected call)
public class FGBHCDFEOLC
{
    public long <HDAEGFLAJHJ>k__BackingField;    // 0x0x10
    public Guid <JODPBHDCBPK>k__BackingField;    // 0x0x18
    public Guid <BNEDKPNNNKF>k__BackingField;    // 0x0x28
    public DateTime <BCPKMACFAFI>k__BackingField;    // 0x0x38
    public string <GLAPBADDDHH>k__BackingField;    // 0x0x40
    public string <AGKBKEGMOOJ>k__BackingField;    // 0x0x48
    public string <MACFFANBLCB>k__BackingField;    // 0x0x50
    public string <GNCCJHNPHPF>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// FJBOLFEGNCB
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
public class FJBOLFEGNCB
{
    public Guid? <DDBJJGEBMFA>k__BackingField;    // 0x0x10
    public long? <AMFPIGCBJBE>k__BackingField;    // 0x0x28
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x38
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x40
    public string <CMDIKLHCBOH>k__BackingField;    // 0x0x48
    public HJHNBECIMKK <FBJLLDJHKPL>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// FJLGBAMHLFB
//   (not directly referenced by a detected call)
public class FJLGBAMHLFB
{
    public int <CLGGGMDEFBK>k__BackingField;    // 0x0x10
    public GFOMBLOIIBJ <JFCKCJEOJNA>k__BackingField;    // 0x0x14
    public List<KIBGNIJNDKD> <EAAJOGGKBNJ>k__BackingField;    // 0x0x18
    public List<KIBGNIJNDKD> <PFKDPEGEAMF>k__BackingField;    // 0x0x20
    public bool <CLAMAPNECCA>k__BackingField;    // 0x0x28
    public DateTime? <FOBKPCOHOGD>k__BackingField;    // 0x0x30
    public DateTime? <HCNJIFNKPOJ>k__BackingField;    // 0x0x40
    public DateTime? <DIKJFIHCLLH>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// FLCGOHCNEMJ
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.WWW]
public class FLCGOHCNEMJ
{
    public int OJAJPPIFBBK;    // 0x0x10
    public long IOBOAHIPEKC;    // 0x0x18
}

// --------------------------------------------------------------------------
// FMLPPNOINFL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FMLPPNOINFL
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// FNHNPMNIAKO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FNHNPMNIAKO
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// FNJOCDBEIMA
// base   : JKFOBEDGDAL`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.Auth]
public class FNJOCDBEIMA
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// FOIHKIMLDDI
//   (not directly referenced by a detected call)
public class FOIHKIMLDDI
{
    public int <MPPKANEOKNB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FPGLEINJPKC
//   (not directly referenced by a detected call)
public class FPGLEINJPKC
{
    public long <BBOGNJMDFMI>k__BackingField;    // 0x0x10
    public string <PJNNGCMBCLF>k__BackingField;    // 0x0x18
    public string <DMFGOPGHDLF>k__BackingField;    // 0x0x20
    public FAHAPBHFJAM? <FOPDCBAJDAB>k__BackingField;    // 0x0x28
    public string <OLIONJDGOCH>k__BackingField;    // 0x0x30
    public string <FJPAEODHDMC>k__BackingField;    // 0x0x38
    public ACOOIPLFNCG <IIKEPCKLBKK>k__BackingField;    // 0x0x40
    public int <DDGOHPCDPKM>k__BackingField;    // 0x0x44
    public int <NBFOPBHDDPB>k__BackingField;    // 0x0x48
    public EHDLBGOMCAB? <JNECGAGBLOI>k__BackingField;    // 0x0x4C
    public JNOLMELBJHO? <KHCFDAGBBEF>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// GDEPKGEDHFM
//   REQUEST  PUT    api/roomconsumables   [Service.WWW]
public class GDEPKGEDHFM
{
    public Guid? <HILGBGKNEII>k__BackingField;    // 0x0x10
    public Guid <LAPBDJGLALD>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// GEJDPHONDAE
//   RESPONSE GET    api/config/v1/azurespeech   [Service.Auth]
public class GEJDPHONDAE
{
    public bool <AKIGHJJKMHB>k__BackingField;    // 0x0x10
    public string <DMLJOFDALBA>k__BackingField;    // 0x0x18
    public string <MDDPEMHCNFE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GFJDCFHDPAJ
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.Auth]
public class GFJDCFHDPAJ
{
    public List<long> <LEBLMADPIFN>k__BackingField;    // 0x0x10
    public JOAEEMMGNFH <JFCKCJEOJNA>k__BackingField;    // 0x0x18
    public string <CCAHLEAEIPM>k__BackingField;    // 0x0x20
    public long? <AMFPIGCBJBE>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// GFOMBLOIIBJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GFOMBLOIIBJ
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// GGDHAAECILA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GGDHAAECILA
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
// GGLFHPFJGLF
//   (not directly referenced by a detected call)
public class GGLFHPFJGLF
{
    public float <PICBBLIPDPH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GHNHKFEPGAP
//   (not directly referenced by a detected call)
public class GHNHKFEPGAP
{
    public Guid <DDBJJGEBMFA>k__BackingField;    // 0x0x10
    public int <NNJDGMFOAAJ>k__BackingField;    // 0x0x20
    public int <JPBGOPBECLM>k__BackingField;    // 0x0x24
    public Guid <EGFCOHCCIIG>k__BackingField;    // 0x0x28
    public DateTime <HIIBLOFOIBC>k__BackingField;    // 0x0x38
    public JJKGFGNNFJA <GGCAKJCLDJK>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// GJNLMHNHJHG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GJNLMHNHJHG
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
// GKKADIFMINP
//   REQUEST  POST   api/playerevents/v2   [Service.Auth]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.Auth]
public class GKKADIFMINP
{
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x10
    public long? <MJIMKCHBLAI>k__BackingField;    // 0x0x18
    public long? <LKHNDGPBAMI>k__BackingField;    // 0x0x28
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x38
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x40
    public List<string> <BOOGFGPPPGO>k__BackingField;    // 0x0x48
    public string <CMDIKLHCBOH>k__BackingField;    // 0x0x50
    public DateTime <NDPKELFCJPD>k__BackingField;    // 0x0x58
    public DateTime <AGLEKELIHHL>k__BackingField;    // 0x0x60
    public CFLOBHPJGHE <MPDOKFNONGF>k__BackingField;    // 0x0x68
    public bool <CLLHPCDHFAC>k__BackingField;    // 0x0x6C
    public bool <MKBPEGOFCIM>k__BackingField;    // 0x0x6D
    public HDBHHJEEFPB <NBAKPJLAFKF>k__BackingField;    // 0x0x70
    public HDBHHJEEFPB <DIPOGGCCKHD>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// GKOFDEICCLI
//   (not directly referenced by a detected call)
public class GKOFDEICCLI
{
    public int <NCMNPLFFFPD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GLPLCMHPACH
//   RESPONSE DELETE api/roomconsumables   [Service.WWW]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{oMCBGACLJMP}   [Service.WWW]
public class GLPLCMHPACH
{
    public GGDHAAECILA <FEAJEPMJNLH>k__BackingField;    // 0x0x10
    public JJKGFGNNFJA <GGCAKJCLDJK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HDBHHJEEFPB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HDBHHJEEFPB
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// HGFKJJBAKIE
//   (not directly referenced by a detected call)
public class HGFKJJBAKIE
{
    public bool <DBJKKCDCGKL>k__BackingField;    // 0x0x10
    public CCBBMFGIOMF <GOIIMEDGLNK>k__BackingField;    // 0x0x14
    public int <DEENLILHHBG>k__BackingField;    // 0x0x18
    public DateTime <HIIBLOFOIBC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HIPIHPLLHPE
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.WWW]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.WWW]
public class HIPIHPLLHPE
{
    public GDEPKGEDHFM <ICOCFFMLGDJ>k__BackingField;    // 0x0x10
    public HJHNBECIMKK <FLNFHBMCPCH>k__BackingField;    // 0x0x18
    public int <PDPFIPPBHLD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HJBHFDIHFJG
// base   : FJLGBAMHLFB
//   (not directly referenced by a detected call)
public class HJBHFDIHFJG : FJLGBAMHLFB
{
    public DJAINENAGOB <CMOPGFHHBGD>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// HJHNBECIMKK
//   (not directly referenced by a detected call)
public class HJHNBECIMKK
{
    public long <MJBJBJLOOLB>k__BackingField;    // 0x0x10
    public Guid? <NLHIHNEANHF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HKMMENIPPLI
//   (not directly referenced by a detected call)
public class HKMMENIPPLI
{
    public LFIDBMBIOHG <PPFJFMMIHGB>k__BackingField;    // 0x0x10
    public LGOAMCBOOKN <KCLELAGDMLD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HNFKLABMBKH
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class HNFKLABMBKH
{
    public List<DDJAHCFDHHC> <INDHHLPHHNC>k__BackingField;    // 0x0x10
    public MLKJMPINDHA <ANAHOCKEDEJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ICOAILNMAPB
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.Auth]
public class ICOAILNMAPB
{
    public int <EDOEADGJLJJ>k__BackingField;    // 0x0x10
    public NNBLBEFAFEM <JFCKCJEOJNA>k__BackingField;    // 0x0x14
    public CEDOFAKKFBN <FPELEIEEFIM>k__BackingField;    // 0x0x18
    public CEDOFAKKFBN <ADDIADPIHCP>k__BackingField;    // 0x0x1C
    public CEDOFAKKFBN <BKKMNPAMFGB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ICPCDHGLDNH
//   RESPONSE GET    api/testcasemanagement/   [Service.Auth]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{fJIJLBIGEAH}   [Service.Auth]
public class ICPCDHGLDNH
{
    public uint <CEGICJKGANO>k__BackingField;    // 0x0x10
    public uint? <FPHEDLMNJJC>k__BackingField;    // 0x0x14
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x20
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x28
    public DateTime <LLGBGACAPBP>k__BackingField;    // 0x0x30
    public DateTime? <OKEBFGKMCEL>k__BackingField;    // 0x0x38
    public bool <DBHJLJLELAM>k__BackingField;    // 0x0x48
    public List<DJNOIADJCHN> <GBOBMIOMEEK>k__BackingField;    // 0x0x50
    public List<string> <BOOGFGPPPGO>k__BackingField;    // 0x0x58
    public int <FAKCMBPGDGO>k__BackingField;    // 0x0x60
    public int <PIJCJFIBIEM>k__BackingField;    // 0x0x64
    public int <JOLDMJMJGJB>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// IFNLJDIEHHJ
//   (not directly referenced by a detected call)
public class IFNLJDIEHHJ
{
    public int <OCCCEHIHCBE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IJMGGBAPGML
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IJMGGBAPGML
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
    ToasterPurchased = 9,
    PlayStationNonPurchasedP2P = 100,
    NonPlayStationNonPurchasedP2P = 101,
    NonPurchasedEarnedByP2P = 1000,
    NonPurchasedEarnedByP2Pv2 = 1001,
}

// --------------------------------------------------------------------------
// ILJFKJDNOMF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ILJFKJDNOMF
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// IPHGBBKDIKN
//   RESPONSE PUT    api/roomkeys/v1/   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class IPHGBBKDIKN
{
    public JJMJKFHCEFB <FEAJEPMJNLH>k__BackingField;    // 0x0x10
    public JKGEDNMFPKD <LBCONBFNPKK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JDDDCOBEIOC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JDDDCOBEIOC
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
// JHEILJKPDLK
//   REQUEST  POST   api/equipment/v1/update   [Service.WWW]
public class JHEILJKPDLK
{
    public string <BIJAIILKHHG>k__BackingField;    // 0x0x10
    public string <GNIHKNEJAIL>k__BackingField;    // 0x0x18
    public string <KHFOPNIGPDI>k__BackingField;    // 0x0x20
    public string <AHKPAMPMHJF>k__BackingField;    // 0x0x28
    public JNOLMELBJHO <GGEFGOCBOLN>k__BackingField;    // 0x0x30
    public bool KDDJLGIBKLP;    // 0x0x34
    public bool <BDENBEINHII>k__BackingField;    // 0x0x35
}

// --------------------------------------------------------------------------
// JJKGFGNNFJA
//   (not directly referenced by a detected call)
public class JJKGFGNNFJA
{
    public Guid <DDBJJGEBMFA>k__BackingField;    // 0x0x10
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x20
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x28
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x30
    public string <CMDIKLHCBOH>k__BackingField;    // 0x0x38
    public long <MJBJBJLOOLB>k__BackingField;    // 0x0x40
    public Guid? <EBMHMGEHCDM>k__BackingField;    // 0x0x48
    public DateTime <HIIBLOFOIBC>k__BackingField;    // 0x0x60
    public int <DBMOKKEDPGI>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// JJMJKFHCEFB
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/   [Service.WWW]
//   RESPONSE DELETE api/roomkeys/v1/delete/{nKCDKPFDGAC}   [Service.WWW]
public enum JJMJKFHCEFB
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
// JKGEDNMFPKD
//   (not directly referenced by a detected call)
public class JKGEDNMFPKD
{
    public long <LDAGIFHJLBO>k__BackingField;    // 0x0x10
    public Guid <CGPKINMCEAP>k__BackingField;    // 0x0x18
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x28
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x30
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x38
    public int <MJBJBJLOOLB>k__BackingField;    // 0x0x40
    public Guid? <EBMHMGEHCDM>k__BackingField;    // 0x0x44
    public DateTime <BCPKMACFAFI>k__BackingField;    // 0x0x58
    public string <CMDIKLHCBOH>k__BackingField;    // 0x0x60
    public FNHNPMNIAKO <JFCKCJEOJNA>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// JMLMFPDCGEE
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.WWW]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.WWW]
public class JMLMFPDCGEE
{
    public int <GFAJJADIJIJ>k__BackingField;    // 0x0x10
    public int <MOGLDEOKONF>k__BackingField;    // 0x0x14
    public float <IBPDKCCAGJM>k__BackingField;    // 0x0x18
    public float <HFLDOKDGFHN>k__BackingField;    // 0x0x1C
    public bool <HMLKDEJCMJH>k__BackingField;    // 0x0x20
    public bool <PIJECKGDNHP>k__BackingField;    // 0x0x21
    public bool <BDENBEINHII>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// JNOLMELBJHO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JNOLMELBJHO
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// KFJADDBJHML
//   REQUEST  POST   api/playerevents/v1/respond   [Service.Auth]
public class KFJADDBJHML
{
    public long <FADGDMJCJLI>k__BackingField;    // 0x0x10
    public AFBMHMGJHAN <JFCKCJEOJNA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KGDEIJDAGND
//   RESPONSE GET    api/config/v1/backtrace   [Service.Auth]
public class KGDEIJDAGND
{
    public int <IFFJKALEMBD>k__BackingField;    // 0x0x10
    public int <MAHBMICGDCM>k__BackingField;    // 0x0x14
    public float <HGDIELEMHLI>k__BackingField;    // 0x0x18
    public int <DLJODMLDBHP>k__BackingField;    // 0x0x1C
    public int <DIIBBHLIGCP>k__BackingField;    // 0x0x20
    public int <ILAMDNKMDNB>k__BackingField;    // 0x0x24
    public int <ICIJIAFIBJE>k__BackingField;    // 0x0x28
    public string <CDNCPFPBFNP>k__BackingField;    // 0x0x30
    public string <DEEHOLKAHAE>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// KIBGNIJNDKD
//   (not directly referenced by a detected call)
public class KIBGNIJNDKD
{
    public AELBGLNPCFK <KBFIOMGPIOH>k__BackingField;    // 0x0x10
    public int <MJBJBJLOOLB>k__BackingField;    // 0x0x14
    public NILILHAJNAG <DLAFIEEDLKP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KKHHBGFFCGJ
//   RESPONSE POST   api/chatreport/createChatReport   [Service.?]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.WWW]
//   RESPONSE DELETE api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.Auth]
//   RESPONSE DELETE api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.Auth]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.WWW]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.WWW]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.WWW]
//   RESPONSE DELETE api/keepsakes   [Service.Auth]
//   RESPONSE DELETE api/keepsakes/{iDGPLJCMDKB}   [Service.Auth]
//   RESPONSE POST   api/playerwarnings   [Service.Auth]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.Auth]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.WWW]
public class KKHHBGFFCGJ
{
    public bool <ONPEMCIENBA>k__BackingField;    // 0x0x10
    public string <BEGFFCGFEKB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KKJPFDHCGNK
//   (not directly referenced by a detected call)
public class KKJPFDHCGNK
{
    public bool <AIGCLOEPDNH>k__BackingField;    // 0x0x10
    public DJAINENAGOB <CMOPGFHHBGD>k__BackingField;    // 0x0x18
    public float <PEBEHJBLMNL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KPJJPHDHKCB
//   (not directly referenced by a detected call)
public class KPJJPHDHKCB
{
    public float <EOOLIFEEAAD>k__BackingField;    // 0x0x10
    public float <HILKCLJELCB>k__BackingField;    // 0x0x14
    public float <NGNHJJKBGKH>k__BackingField;    // 0x0x18
    public float <DDOLOJBBFOG>k__BackingField;    // 0x0x1C
    public float <EHMPJLEGJON>k__BackingField;    // 0x0x20
    public float <AGFHOJKCPMG>k__BackingField;    // 0x0x24
    public float <ECDHMHPPCAC>k__BackingField;    // 0x0x28
    public float <NKEPALEAANH>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// LAOLMNEPIKH
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Matchmaking]
public class LAOLMNEPIKH
{
    public Guid <OLBEFFPIDPB>k__BackingField;    // 0x0x10
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x20
    public string <CMDIKLHCBOH>k__BackingField;    // 0x0x28
    public DateTime <LCIIAOMBPMA>k__BackingField;    // 0x0x30
    public DateTime? <JIFMCAHBHLP>k__BackingField;    // 0x0x38
    public List<CHOEDECFNMC> <IBLEIKPKMIB>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// LCEKPPJHADE
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.WWW]
public class LCEKPPJHADE
{
    public List<ALHCHJNICCJ> <MGLOHIAOPCD>k__BackingField;    // 0x0x10
    public string <PLHFHKKGFLP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LCLEJEFNMIG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LCLEJEFNMIG
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
// LEBKBGMEAMJ
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class LEBKBGMEAMJ
{
    public Dictionary<Guid, NJCMDMMOIBP> <FGCKCBOBFMB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LEIGJHACJBP
//   (not directly referenced by a detected call)
public class LEIGJHACJBP
{
    public long <HDONAANALHF>k__BackingField;    // 0x0x10
    public string <CGPKINMCEAP>k__BackingField;    // 0x0x18
    public int <FAGFBNDPFOI>k__BackingField;    // 0x0x20
    public int <LBBBLGLGBEK>k__BackingField;    // 0x0x24
    public int <JPEDABLJKEP>k__BackingField;    // 0x0x28
    public int <DJLNPDBHJGH>k__BackingField;    // 0x0x2C
    public int <IKCCBCKEDEI>k__BackingField;    // 0x0x30
    public string <BLKLBIGGGCP>k__BackingField;    // 0x0x38
    public string <HOEKCPLBIBL>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// LFIDBMBIOHG
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class LFIDBMBIOHG
{
    public long <FADGDMJCJLI>k__BackingField;    // 0x0x10
    public int <FJDLIKDNMGG>k__BackingField;    // 0x0x18
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x20
    public long? <MJIMKCHBLAI>k__BackingField;    // 0x0x28
    public long? <LKHNDGPBAMI>k__BackingField;    // 0x0x38
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x48
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x50
    public string <CMDIKLHCBOH>k__BackingField;    // 0x0x58
    public DateTime <NDPKELFCJPD>k__BackingField;    // 0x0x60
    public DateTime <AGLEKELIHHL>k__BackingField;    // 0x0x68
    public int <EEBIFFLBIIK>k__BackingField;    // 0x0x70
    public CFLOBHPJGHE <MPDOKFNONGF>k__BackingField;    // 0x0x74
    public bool <CLLHPCDHFAC>k__BackingField;    // 0x0x78
    public bool <MKBPEGOFCIM>k__BackingField;    // 0x0x79
    public HDBHHJEEFPB <NBAKPJLAFKF>k__BackingField;    // 0x0x7C
    public HDBHHJEEFPB <DIPOGGCCKHD>k__BackingField;    // 0x0x80
    public long? <GIIFJHEEADI>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// LGIPIODCKLD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LGIPIODCKLD
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
// LGOAMCBOOKN
//   (not directly referenced by a detected call)
public class LGOAMCBOOKN
{
    public long <GFJGMPPKHEE>k__BackingField;    // 0x0x10
    public long <FADGDMJCJLI>k__BackingField;    // 0x0x18
    public int <GIBHOJABBGA>k__BackingField;    // 0x0x20
    public DateTime <BCPKMACFAFI>k__BackingField;    // 0x0x28
    public AFBMHMGJHAN <JFCKCJEOJNA>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// LHCHEPPKDCC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LHCHEPPKDCC
{
    Success = 0,
    InvalidParameters = 1,
    PlayerCannotUpload = 2,
    DuplicateName = 3,
    NameTooShort = 4,
    NameTooLong = 5,
    NotCreator = 6,
    DoesNotExist = 7,
    ImageDoesNotExist = 8,
    InventionLimitReached = 9,
    DescriptionTooLong = 10,
    InnapropriateName = 11,
    InnapropriateDescription = 12,
    CannotBeModified = 13,
    PlayerCannotPublish = 14,
    AlreadyPublished = 15,
    AlreadyUnpublished = 16,
    InventionUnderModerationReview = 17,
    PlayerCannotDownload = 18,
    PlayerAlreadyOwns = 19,
    DescriptionTooShort = 20,
    DoesNotHavePermission = 21,
    PermissionLevelCannotBeChanged = 22,
    AlreadyCheered = 23,
    AlreadyRemovedCheer = 24,
    ModeratorRestrictedPublishing = 25,
    PlayerCannotSell = 26,
    InvalidPrice = 27,
    PriceCannotBeChanged = 28,
    InvalidPermissionForPaidInvention = 29,
    PurchaseFailed = 30,
    CannotDownloadPaidInvention = 31,
    CannotSellUnownedLineage = 32,
    DoesNotAllowTrial = 33,
    StillOnTrialCooldown = 34,
    PlayerCannotTrial = 35,
    PaidInventionPublishingDisabled = 36,
    PaidInventionPurchasingDisabled = 37,
    OperationIsDisabled = 38,
    PlayerRestrictedFromP2PSelling = 39,
    PlayerNotRecRoomPlusMember = 40,
    InvalidInstantiationCost = 41,
    FeaturedInventionNotPublished = 42,
    FeaturedInventionNotActive = 43,
    InventionContainsBlockedFiles = 44,
    PlayerRestrictedFromP2PBuying = 45,
    ReservedWordRuleViolationInName = 46,
    ReservedWordRuleViolationInDescription = 47,
}

// --------------------------------------------------------------------------
// LKLAAPNNCAI
//   (not directly referenced by a detected call)
public class LKLAAPNNCAI
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// MDEGMLLHKJL
// base   : KMEJCOLBENK
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.WWW]
public class MDEGMLLHKJL : KMEJCOLBENK
{
    public string <BCHOBMBNENJ>k__BackingField;    // 0x0x30
    public List<HJBHFDIHFJG> CKNBJGJDKOF;    // 0x0x38
    public int <NCPFIHJLIDC>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// MLJKAPBGCDC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MLJKAPBGCDC
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
    Toaster = 9,
}

// --------------------------------------------------------------------------
// MLKJMPINDHA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MLKJMPINDHA
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
// MMOGLEMFEDF
//   RESPONSE POST   api/inventions/v1/settags   [Service.Auth]
public class MMOGLEMFEDF
{
    public JDDDCOBEIOC <ANAHOCKEDEJ>k__BackingField;    // 0x0x10
    public List<string> <BOOGFGPPPGO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MNKLMANJNMH
//   REQUEST  PUT    api/customAvatarItems   [Service.Auth]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
public class MNKLMANJNMH
{
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x10
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x18
    public int? <MJBJBJLOOLB>k__BackingField;    // 0x0x20
    public BAJMPAINDDM? <MPDOKFNONGF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// MOMCCCOKBNL
//   RESPONSE GET    api/playerevents/v1/all   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/all/{dKIOMDOEGKN}   [Service.Auth]
public class MOMCCCOKBNL
{
    public List<LFIDBMBIOHG> <ICKJFIAGCDH>k__BackingField;    // 0x0x10
    public List<HKMMENIPPLI> <HJBBBMNGDAH>k__BackingField;    // 0x0x18
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
// NHFFMNDCMNP
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.Auth]
public class NHFFMNDCMNP
{
    public List<LFIDBMBIOHG> <FPNKJENHOCP>k__BackingField;    // 0x0x10
    public string <PLHFHKKGFLP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NILILHAJNAG
//   (not directly referenced by a detected call)
public class NILILHAJNAG
{
    public int <NMKAGJLKDDA>k__BackingField;    // 0x0x10
    public DateTime? <NMPPKEJLAHL>k__BackingField;    // 0x0x18
    public DateTime? <BBBIIFPGIDO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// NJCMDMMOIBP
//   RESPONSE PUT    api/roomconsumables   [Service.WWW]
public class NJCMDMMOIBP
{
    public GGDHAAECILA <FEAJEPMJNLH>k__BackingField;    // 0x0x10
    public GHNHKFEPGAP <CIJALALKAPH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NMBOBKGLIIO
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/checklist/v1/complete   [Service.WWW]
//   RESPONSE POST   api/progressionEvents   [Service.Auth]
//   RESPONSE POST   api/progressionEvents/collect/{aNKGECEILCH}/{eCFJEOFBPAM}   [Service.Auth]
public class NMBOBKGLIIO
{
    public long? <CEGICJKGANO>k__BackingField;    // 0x0x10
    public int <GIBHOJABBGA>k__BackingField;    // 0x0x20
    public int? <ANOHGAOCGIP>k__BackingField;    // 0x0x24
    public string <PJNNGCMBCLF>k__BackingField;    // 0x0x30
    public FAHAPBHFJAM? <FOPDCBAJDAB>k__BackingField;    // 0x0x38
    public string <CNLPFBCFKHO>k__BackingField;    // 0x0x40
    public string <OLIONJDGOCH>k__BackingField;    // 0x0x48
    public string <FJPAEODHDMC>k__BackingField;    // 0x0x50
    public AELBGLNPCFK <KBFIOMGPIOH>k__BackingField;    // 0x0x58
    public int <GGGKIBPOMCE>k__BackingField;    // 0x0x5C
    public int <DDGOHPCDPKM>k__BackingField;    // 0x0x60
    public EHDLBGOMCAB <JNECGAGBLOI>k__BackingField;    // 0x0x64
    public JNOLMELBJHO <KHCFDAGBBEF>k__BackingField;    // 0x0x68
    public string <JKNEHFDIIMG>k__BackingField;    // 0x0x70
    public MLJKAPBGCDC <NHCMHLHJBOB>k__BackingField;    // 0x0x78
    public CCBBMFGIOMF <BEFEHCICGND>k__BackingField;    // 0x0x7C
    public IJMGGBAPGML? <DPJBJEJAHHI>k__BackingField;    // 0x0x80
    public bool <LIPMNKPCJFG>k__BackingField;    // 0x0x88
    public bool <JAIDENFNIFJ>k__BackingField;    // 0x0x89
    public string <KOMHIHGDJLI>k__BackingField;    // 0x0x90
    public bool <GIGEALAJMPB>k__BackingField;    // 0x0x98
    public bool BNNCEMANHNJ;    // 0x0x99
}

// --------------------------------------------------------------------------
// NMKLJBJNKHP
//   (not directly referenced by a detected call)
public class NMKLJBJNKHP
{
    public DateTime <BCPKMACFAFI>k__BackingField;    // 0x0x10
    public string <NNAKDIPCBJM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OAHNAHCPABM
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class OAHNAHCPABM
{
    public Dictionary<Guid, PIGHLNBJHOM> <MDONCEHDBBJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OBHKJBJHAIE
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.WWW]
public class OBHKJBJHAIE
{
    public int <MOGLDEOKONF>k__BackingField;    // 0x0x10
    public bool <HMLKDEJCMJH>k__BackingField;    // 0x0x14
    public DateTime <BBLKKNNCBDB>k__BackingField;    // 0x0x18
    public bool <ABBENJKGHMA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OFBJOGMFKGF
//   REQUEST  POST   api/challenge/v2/updateProgress   [Service.WWW]
public class OFBJOGMFKGF
{
    public int <CIFJEIGAGEF>k__BackingField;    // 0x0x10
    public int <INLKAPKBNIJ>k__BackingField;    // 0x0x14
    public string <HGLAECHFFKB>k__BackingField;    // 0x0x18
    public bool <IGJIMIOHLEK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OIDHLLEOJNG
//   REQUEST  ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.Notifications]
public class OIDHLLEOJNG
{
    public List<string> <CINGLLNBHDB>k__BackingField;    // 0x0x10
    public byte <JLJMOPBFPOK>k__BackingField;    // 0x0x18
    public int <HKOLMMIBGAP>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// OIKKODPIDOG
//   RESPONSE ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.Notifications]
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems/v2   [Service.Notifications]
public class OIKKODPIDOG
{
    public Dictionary<string, FGBHCDFEOLC> <COMPLCODGEO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OLLNDCDJHHA
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.WWW]
public class OLLNDCDJHHA
{
    public int <CIFJEIGAGEF>k__BackingField;    // 0x0x10
    public string <OHPGHNJMFHD>k__BackingField;    // 0x0x18
    public List<EAPGNCCGAJC> <DHLFOEEFHDM>k__BackingField;    // 0x0x20
    public FPGLEINJPKC <OJPHBEFEABB>k__BackingField;    // 0x0x28
    public string <ENJDIDPMDKJ>k__BackingField;    // 0x0x30
    public DateTime <LCIIAOMBPMA>k__BackingField;    // 0x0x38
    public DateTime <CIDGJNBNFIC>k__BackingField;    // 0x0x40
    public DateTime <GDNEFLFBIDG>k__BackingField;    // 0x0x48
    public bool? <IPIBAHFAJBK>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// PFOGPKAKBNE
// base   : FJLGBAMHLFB
//   (not directly referenced by a detected call)
public class PFOGPKAKBNE : FJLGBAMHLFB
{
    public int <ABJMMMINGGP>k__BackingField;    // 0x0x60
    public List<KKJPFDHCGNK> <MGGJCAEHHBG>k__BackingField;    // 0x0x68
    public List<KKJPFDHCGNK> <HHJJIJEKFID>k__BackingField;    // 0x0x70
    public List<KKJPFDHCGNK> <MJDCKANJHKF>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// PGAOCDCDOHF
//   RESPONSE GET    api/inventions/v1/details   [Service.Auth]
public class PGAOCDCDOHF
{
    public List<ADAIPLFMBDE> <BOOGFGPPPGO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PGFJPFJMECI
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.WWW]
public class PGFJPFJMECI
{
    public int <MHLBCHNBIBF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PIGHLNBJHOM
//   (not directly referenced by a detected call)
public class PIGHLNBJHOM
{
    public int <PDPFIPPBHLD>k__BackingField;    // 0x0x10
    public GDEPKGEDHFM <ICOCFFMLGDJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PJHLOMAICEL
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems/v2   [Service.Notifications]
public class PJHLOMAICEL
{
    public byte <JLJMOPBFPOK>k__BackingField;    // 0x0x10
    public int <HKOLMMIBGAP>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// PJNBAFDENBA
// base   : LFIDBMBIOHG
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class PJNBAFDENBA : LFIDBMBIOHG
{
    public List<ADAIPLFMBDE> <BOOGFGPPPGO>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// PKMAIFDBNMG
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.WWW]
public class PKMAIFDBNMG
{
    public int <NNJDGMFOAAJ>k__BackingField;    // 0x0x10
    public Guid <NLHIHNEANHF>k__BackingField;    // 0x0x14
    public long <OCPOKPLLHPC>k__BackingField;    // 0x0x28
    public DateTime <HIIBLOFOIBC>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// PMJNAMEHOKL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PMJNAMEHOKL
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x10
    public long? <MJIMKCHBLAI>k__BackingField;    // 0x0x18
    public JOIHFCCLJHG <KDDGGBNFHOP>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v6/addversion   [Service.Matchmaking]
public class AddVersionInventionRequestDTO
{
    public long inventionId;    // 0x0x10
    public int instantiationCost;    // 0x0x18
    public int lightsCost;    // 0x0x1C
    public int chipsCost;    // 0x0x20
    public int cloudVariablesCost;    // 0x0x24
    public int aiCost;    // 0x0x28
    public byte ugcVersion;    // 0x0x2C
    public long creationRoomId;    // 0x0x30
    public string inventionDataFilename;    // 0x0x38
    public List<long> referencedInventions;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.Auth]
public class AppleMusicPromotionResponseDTO
{
    public BJIIHCKHBLC <ANAHOCKEDEJ>k__BackingField;    // 0x0x10
    public string <APEOFDJCEIK>k__BackingField;    // 0x0x18
    public string <PNDMOJIIBCN>k__BackingField;    // 0x0x20
    public string <NKMJFPPDEPG>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public AELBGLNPCFK <CurrencyType>k__BackingField;    // 0x0x18
    public IJMGGBAPGML <BalanceType>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.CheerRequest
//   REQUEST  POST   api/inventions/v1/cheer   [Service.Auth]
public class CheerRequest
{
    public long InventionId;    // 0x0x10
    public bool Cheer;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.DeleteMessagesRequestDTO
//   REQUEST  POST   api/messages/v3/delete   [Service.Auth]
public class DeleteMessagesRequestDTO
{
    public List<long> MessageIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.BroadcastRoomInstanceRequest
//   REQUEST  POST   api/playerevents/v1/broadcast   [Service.Auth]
public class BroadcastRoomInstanceRequest
{
    public long <FADGDMJCJLI>k__BackingField;    // 0x0x10
    public long? <NKHANAJMKOM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.BulkInviteRequest
//   REQUEST  POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class BulkInviteRequest
{
    public long PlayerEventId;    // 0x0x10
    public List<int> InvitedPlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.DeleteResponseRequest
//   REQUEST  POST   api/playerevents/v1/deleteResponse   [Service.Auth]
public class DeleteResponseRequest
{
    public long PlayerEventId;    // 0x0x10
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
    public AAEDLBHPJJI FilterType;    // 0x0x20
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
// RecNet.KeepsakeCategoryConfigDTO
//   (not directly referenced by a detected call)
public class KeepsakeCategoryConfigDTO
{
    public JOIHFCCLJHG <OHNCIINIMKC>k__BackingField;    // 0x0x10
    public string <LBALMENPDHF>k__BackingField;    // 0x0x18
    public int <AHDOGMBBDOM>k__BackingField;    // 0x0x20
    public int <IIIFMGONMAC>k__BackingField;    // 0x0x24
    public string <LIHANGNBNMC>k__BackingField;    // 0x0x28
    public string <CKIJEOODPGN>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <NNJDGMFOAAJ>k__BackingField;    // 0x0x10
    public Guid <IPEDMMNNNOA>k__BackingField;    // 0x0x14
    public DateTime <CLJMNGNMHGM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.Auth]
public class KeepsakeGlobalConfigDTO
{
    public bool <KGJGPGOFGHC>k__BackingField;    // 0x0x10
    public int <APLFPOCGLCD>k__BackingField;    // 0x0x14
    public bool <NDIGCAIFAGP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <IPEDMMNNNOA>k__BackingField;    // 0x0x10
    public JOIHFCCLJHG <BHJKGMAOIOO>k__BackingField;    // 0x0x20
    public int <JEDOBPKDGII>k__BackingField;    // 0x0x24
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x28
    public long? <MJIMKCHBLAI>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.Auth]
//   RESPONSE GET    api/keepsakes/events/{pPDBJCHGBJC}   [Service.Auth]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <EIDAIMEAEMF>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <PGMJEGMDGBH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <CMOLANGICHC>k__BackingField;    // 0x0x10
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x18
    public long <JANCHEJHIAN>k__BackingField;    // 0x0x20
    public JFGOINKPGCE <JFCKCJEOJNA>k__BackingField;    // 0x0x28
    public int <MHFNHKBDGLI>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <AMFPIGCBJBE>k__BackingField;    // 0x0x10
    public List<Guid> <MBLPMONHLNN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <EIDAIMEAEMF>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <PGMJEGMDGBH>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <OJMFHLKAHCG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <JANCHEJHIAN>k__BackingField;    // 0x0x10
    public long <BNECPHJJIGD>k__BackingField;    // 0x0x18
    public int? <AKIADLBLOIB>k__BackingField;    // 0x0x20
    public int? <JMEDCPPACMM>k__BackingField;    // 0x0x28
    public long? <LIJJNAOGCHH>k__BackingField;    // 0x0x30
    public long <HDLHGHLAKAM>k__BackingField;    // 0x0x40
    public long <HGCJPDJDMPM>k__BackingField;    // 0x0x48
    public int <AJFFKDLNCOC>k__BackingField;    // 0x0x50
    public JFGOINKPGCE <BOGCNJBOBHI>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <AMMHOFEIPNF>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.KickPlayerDTO
//   REQUEST  POST   api/PlayerReporting/v1/instantKick   [Service.Auth]
public class KickPlayerDTO
{
    public long GameSessionId;    // 0x0x10
    public List<int> PlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ModifyTagsRequest
//   REQUEST  POST   api/inventions/v1/settags   [Service.Auth]
public class ModifyTagsRequest
{
    public long InventionId;    // 0x0x10
    public List<string> AutoTags;    // 0x0x18
    public List<string> CustomTags;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.MultiRecipientFreeGiftRequestDTO
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.WWW]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public EHDLBGOMCAB <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v7/save   [Service.Matchmaking]
public class NewInventionRequestDTO
{
    public string name;    // 0x0x10
    public string description;    // 0x0x18
    public string imageName;    // 0x0x20
    public int instantiationCost;    // 0x0x28
    public int lightsCost;    // 0x0x2C
    public int chipsCost;    // 0x0x30
    public int cloudVariablesCost;    // 0x0x34
    public int aiCost;    // 0x0x38
    public byte ugcVersion;    // 0x0x3C
    public long creationRoomId;    // 0x0x40
    public string inventionDataFilename;    // 0x0x48
    public List<long> referencedInventions;    // 0x0x50
    public KFANPMEHJHA creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public MMDMNFHCEKE <GNKFCGFALNN>k__BackingField;    // 0x0x10
    public OLKIBCFAHBM <PKGKAHOMKPM>k__BackingField;    // 0x0x14
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x18
    public string <BMHLOFPPKON>k__BackingField;    // 0x0x20
    public bool <HIHBPFHCKII>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<MMDMNFHCEKE> <ADKGLDOPDNM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/event/{aNKGECEILCH}   [Service.Auth]
public class ProgressionEventDTO
{
    public long <BNECPHJJIGD>k__BackingField;    // 0x0x10
    public string <LMCPMGELNHI>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <MJDCKANJHKF>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <DOJHDEBICCD>k__BackingField;    // 0x0x28
    public DateTime <NDPKELFCJPD>k__BackingField;    // 0x0x30
    public DateTime <AGLEKELIHHL>k__BackingField;    // 0x0x38
    public DateTime <DKOKHHFKPBI>k__BackingField;    // 0x0x40
    public bool <APIILHDMBML>k__BackingField;    // 0x0x48
    public int <HFILHJEJHEO>k__BackingField;    // 0x0x4C
    public float <FKDHKAJOKOC>k__BackingField;    // 0x0x50
    public Guid? <HAAPBPNLILE>k__BackingField;    // 0x0x54
    public string <AHIHNCFIFOI>k__BackingField;    // 0x0x68
    public string <GKLEIMEFCMF>k__BackingField;    // 0x0x70
    public string <BJBOMCKCGEM>k__BackingField;    // 0x0x78
    public string <DOACLFCHLJA>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <GMEDHKENNOF>k__BackingField;    // 0x0x10
    public int <OHODPOBAJNC>k__BackingField;    // 0x0x20
    public int <POBNALMCOBK>k__BackingField;    // 0x0x24
    public int <CAMFJOEGGAH>k__BackingField;    // 0x0x28
    public long <NOLOHPFHHHA>k__BackingField;    // 0x0x30
    public long <BHMHJNEBOOB>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.Auth]
public class ProgressionEventRecordDTO
{
    public int <NNJDGMFOAAJ>k__BackingField;    // 0x0x10
    public int <DDGOHPCDPKM>k__BackingField;    // 0x0x14
    public int <JCLONFNFGIE>k__BackingField;    // 0x0x18
    public int <PCMGKIONCAE>k__BackingField;    // 0x0x1C
    public int <HBAKEGODIOL>k__BackingField;    // 0x0x20
    public DateTime? <MKOEALKGAIM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <FHGAJAGMDJD>k__BackingField;    // 0x0x10
    public int <BBOGNJMDFMI>k__BackingField;    // 0x0x18
    public string <CMDIKLHCBOH>k__BackingField;    // 0x0x20
    public int <DDGOHPCDPKM>k__BackingField;    // 0x0x28
    public int <BLHDHFGGBMF>k__BackingField;    // 0x0x2C
    public bool <BAJMLENHFAO>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.Auth]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public DELJOCJKCIL ReportCategory;    // 0x0x20
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
// RecNet.UpdatePriceRequest
//   REQUEST  POST   api/inventions/v1/updateprice   [Service.Auth]
public class UpdatePriceRequest
{
    public long InventionId;    // 0x0x10
    public int Price;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.Debugging.AutocompleteResult
// base   : UnityEngine.MonoBehaviour
//   (not directly referenced by a detected call)
public class AutocompleteResult : MonoBehaviour
{
    public RawImage backgroundImage;    // 0x0x18
    public TMP_Text text;    // 0x0x20
    public bool NGHJAFHFFCJ;    // 0x0x28
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
// SA.iOS.GameKit.ISN_GKSavedGameFetchResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameFetchResult : SA_Result
{
    public List<ISN_GKSavedGame> m_SavedGames;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameSaveResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameSaveResult : SA_Result
{
    public ISN_GKSavedGame m_SavedGame;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.ReplayKit.ISN_PRPreviewResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_PRPreviewResult : SA_Result
{
    public List<string> m_ActivityTypes;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.ReplayKit.ISN_RPStopResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_RPStopResult : SA_Result
{
    public bool m_HasPreviewController;    // 0x0x28
    public ISN_RPPreviewViewController PreviewController;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.Social.ISN_MessageComposeResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ISN_MessageComposeResult
{
    Cancelled = 0,
    Sent = 1,
    Failed = 2,
    NotSupportedByDevice = 3,
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
// SA.iOS.UIKit.ISN_UIPickerControllerRequest
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerRequest
{
    public List<string> m_MediaTypes;    // 0x0x10
    public float m_ImageCompressionRate;    // 0x0x18
    public int m_MaxImageSize;    // 0x0x1C
    public ISN_UIImageCompressionFormat m_EncodingType;    // 0x0x20
    public ISN_UIModalPresentationStyle m_ModalPresentationStyle;    // 0x0x24
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIPickerControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerResult : SA_Result
{
    public string m_EncodedImage;    // 0x0x28
    public string m_MediaUrl;    // 0x0x30
    public string m_ImageUrl;    // 0x0x38
    public string m_MediaType;    // 0x0x40
    public Texture2D m_Texture;    // 0x0x48
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIRegisterRemoteNotificationsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIRegisterRemoteNotificationsResult : SA_Result
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.UserNotifications.ISN_UNNotificationRequest
//   (not directly referenced by a detected call)
public class ISN_UNNotificationRequest
{
    public string m_Identifier;    // 0x0x10
    public ISN_UNNotificationContent m_Content;    // 0x0x18
    public ISN_UNNotificationTrigger m_Trigger;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.UserNotifications.ISN_UNNotificationResponse
//   (not directly referenced by a detected call)
public class ISN_UNNotificationResponse
{
    public ISN_UNNotification m_Notification;    // 0x0x10
    public string m_ActionIdentifier;    // 0x0x18
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

// api/CampusCard/v1/UpdateAndGetSubscription  [WWW POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [Auth POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public IGJCJAOGPEM? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [Notifications POST]
public class PlayerCheerV1CreateRequest
{
    public IGJCJAOGPEM BOFEBDNHAMD;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [Auth POST]
public class PlayerReportingV1DeviceIdRequest
{
    public MLJKAPBGCDC PDEMHKAGCDD;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [Auth POST]
public class PlayerReportingV1HileRequest
{
    public PMPMJFECKLL LPFFKBBBCBL;  // wrapper
    public int? LBKKLOBHKEO;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/moderationBlockDetails  [Auth POST]
public class PlayerReportingV1ModerationBlockDetailsRequest
{
    public string deviceToken;  // wrapper
}

// api/PlayerReporting/v3/create  [Auth POST]
public class PlayerReportingV3CreateRequest
{
    public INJMGIDEJOA FNMELHOBKIG;  // wrapper
    public float? LLJEKNAFNOJ;  // wrapper
    public bool? LFMMFDMLLDL;  // wrapper
    public object IsFullBodyAvatarReport;  // candidate
    public object IsReporterFullBodyAvatar;  // candidate
    public object ReportCategory;  // candidate
    public object HeightReporter;  // candidate
    public object RoomInstanceType;  // candidate
}

// api/PlayerReporting/v3/voteToKick  [Auth POST]
public class PlayerReportingV3VoteToKickRequest
{
    public object Response;  // candidate
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
    public object Reason;  // candidate
}

// api/avatar/v1/lockeditems  [WWW GET]
public class AvatarV1LockeditemsRequest
{
    public List<PFPAGMCKFGF> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [WWW POST]
public class AvatarV2GiftsGenerateRequest
{
    public EHDLBGOMCAB KMABAKEMFMI;  // wrapper
    public EHDLBGOMCAB? OLLHEOKBAGJ;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [WWW POST]
public class AvatarV3GiftsGenerateRequest
{
    public EHDLBGOMCAB KMABAKEMFMI;  // wrapper
    public EHDLBGOMCAB? OLLHEOKBAGJ;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [? POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage LJCDGDONMLD;  // wrapper
    public JNJKOLCCPFO FNMELHOBKIG;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [Notifications POST]
public class ClubreportingV1ReportRequest
{
    public INJMGIDEJOA FNMELHOBKIG;  // wrapper
    public object details;  // candidate
    public object clubId;  // candidate
    public object reportCategory;  // candidate
}

// api/config/v1/backtrace  [Auth GET]
public class ConfigV1BacktraceRequest
{
    public object allocate;  // candidate
    public object platformType;  // candidate
}

// api/customAvatarItems/v1  [Auth POST]
public class CustomAvatarItemsV1Request
{
    public BAJMPAINDDM PPOJFPOKDBH;  // wrapper
    public BNOIOLOGGDC HNFHGKLOCII;  // wrapper
    public MFAAEIBAHGL CIGHOALDCAE;  // wrapper
    public MFAAEIBAHGL CGDDGMBGGHA;  // wrapper
    public object metadata;  // candidate
    public object thumbnailImage;  // candidate
    public object design;  // candidate
    public object file.bin;  // candidate
}

// api/customAvatarItems/v1/design  [Auth GET]
public class CustomAvatarItemsV1DesignRequest
{
    public object metadata;  // candidate
    public object design;  // candidate
    public object file.bin;  // candidate
}

// api/customAvatarItems/v1/me  [Auth GET]
public class CustomAvatarItemsV1MeRequest
{
    public object take;  // candidate
    public object skip;  // candidate
}

// api/customAvatarItems/v1/search  [Auth GET]
public class CustomAvatarItemsV1SearchRequest
{
    public object minPrice;  // candidate
    public object isOwned;  // candidate
    public object itemTypes;  // candidate
    public object isFeatured;  // candidate
    public object creatorUsername;  // candidate
}

// api/externalfriendinvite/v1/createplatforminvite  [Auth POST]
public class ExternalfriendinviteV1CreateplatforminviteRequest
{
    public string platformId;  // wrapper
}

// api/externalfriendinvite/v1/sendtextmessageinvite  [Auth POST]
public class ExternalfriendinviteV1SendtextmessageinviteRequest
{
    public object phoneNumber;  // candidate
    public object senderName;  // candidate
    public object friendCode;  // candidate
}

// api/gamerewards/v1/request  [WWW POST]
public class GamerewardsV1RequestRequest
{
    public PIHHPOIONHC JGHEKJKOFPE;  // wrapper
    public EHDLBGOMCAB? BEJPNGBMLPO;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [WWW POST]
public class GamerewardsV1SelectRequest
{
    public IKMIDCOMGNK CJGFMMCICPD;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/images/  [Auth GET]
public class ImagesRequest
{
    public object filter;  // candidate
    public object sort;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v4/room/{roomId}  [? GET]
public class ImagesV4RoomRoomIdRequest
{
    public object filter;  // candidate
    public object sort;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v5/bulk  [Auth ?]
public class ImagesV5BulkRequest
{
    public List<long> ids;  // param
}

// api/images/v5/cheered/bulk  [Auth ?]
public class ImagesV5CheeredBulkRequest
{
    public List<long> id;  // param
}

// api/images/v5/player/{playerId}  [Auth GET]
public class ImagesV5PlayerPlayerIdRequest
{
    public object sort;  // candidate
}

// api/images/v6  [Auth GET]
public class ImagesV6Request
{
    public string name;  // wrapper
}

// api/incentivizedreferrals/claim  [WWW POST]
public class IncentivizedreferralsClaimRequest
{
    public int ReferralRewardId;  // wrapper
}

// api/incentivizedreferrals/referrals  [WWW GET]
public class IncentivizedreferralsReferralsRequest
{
    public object continuationToken;  // candidate
    public object take;  // candidate
}

// api/influencerpartnerprogram/influencer  [WWW GET]
public class InfluencerpartnerprogramInfluencerRequest
{
    public int accountId;  // wrapper
}

// api/influencerpartnerprogram/influencers  [WWW GET]
public class InfluencerpartnerprogramInfluencersRequest
{
    public object continuationToken;  // candidate
    public object take;  // candidate
}

// api/influencerpartnerprogram/remove  [WWW POST]
public class InfluencerpartnerprogramRemoveRequest
{
    public int influencerAccountId;  // wrapper
}

// api/influencerpartnerprogram/support  [WWW POST]
public class InfluencerpartnerprogramSupportRequest
{
    public int influencerAccountId;  // wrapper
}

// api/inventions/v1/delete  [Auth GET]
public class InventionsV1DeleteRequest
{
    public ADHBHAOOFDC inventionId;  // wrapper
}

// api/inventions/v1/details  [Auth GET]
public class InventionsV1DetailsRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v1/dormskinsfromids  [Auth ?]
public class InventionsV1DormskinsfromidsRequest
{
    public List<long> ids;  // param
}

// api/inventions/v1/fulllineageowner  [Auth GET]
public class InventionsV1FulllineageownerRequest
{
    public List<long> id;  // query
}

// api/inventions/v1/unpublish  [Auth GET]
public class InventionsV1UnpublishRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v1/update  [Auth GET]
public class InventionsV1UpdateRequest
{
    public object name;  // candidate
    public object inventionId;  // candidate
    public object description;  // candidate
    public object imgName;  // candidate
    public object permission;  // candidate
}

// api/inventions/v1/versions  [Auth GET]
public class InventionsV1VersionsRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v2/batch  [Auth ?]
public class InventionsV2BatchRequest
{
    public List<long> id;  // param
}

// api/inventions/v2/search  [Auth GET]
public class InventionsV2SearchRequest
{
    public object value;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/inventions/v3/publish  [Auth GET]
public class InventionsV3PublishRequest
{
    public object price;  // candidate
    public object accessibility;  // candidate
    public object permissionLevel;  // candidate
    public object inventionId;  // candidate
}

// api/itemWishlists/v1/isonwishlist/bulk  [WWW POST]
public class ItemWishlistsV1IsonwishlistBulkRequest
{
    public List<int> accountIds;  // form
}

// api/keepsakes/{iDGPLJCMDKB}/collect  [Auth POST]
public class KeepsakesIDGPLJCMDKBCollectRequest
{
    public Guid IDGPLJCMDKB;  // wrapper
}

// api/messages/v2/send  [Auth POST]
public class MessagesV2SendRequest
{
    public JOAEEMMGNFH OGCKEJOMMAB;  // wrapper
    public long? GMKNHGGIMFN;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/offlineinvite/v1/send  [? POST]
public class OfflineinviteV1SendRequest
{
    public long PlayerId;  // wrapper
}

// api/playerevents/v1/bulk  [Auth POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/clubs  [Auth POST]
public class PlayereventsV1ClubsRequest
{
    public IReadOnlyCollection<long> INGLILBHDMN;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [Auth PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public CFLOBHPJGHE PPOJFPOKDBH;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [Auth PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? NLKODICBNAH;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [Auth PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public HDBHHJEEFPB OMNCNAPIEMO;  // wrapper
    public HDBHHJEEFPB CAAIMHMFLJM;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [Auth PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? EDBJFNJNPDL;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [Auth PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime EOBOIBODBAD;  // wrapper
    public DateTime IDHEOPEEKFF;  // wrapper
}

// api/playeritems/v1/isavataritemowned/bulk  [WWW POST]
public class PlayeritemsV1IsavataritemownedBulkRequest
{
    public List<int> accountIds;  // form
}

// api/playeritems/v1/isequipmentitemowned/bulk  [WWW POST]
public class PlayeritemsV1IsequipmentitemownedBulkRequest
{
    public List<int> accountIds;  // form
}

// api/playerwarnings  [Auth POST]
public class PlayerwarningsRequest
{
    public INJMGIDEJOA FNMELHOBKIG;  // wrapper
    public object ModeratorNote;  // candidate
    public object WarnedPlayerId;  // candidate
    public object ReportCategory;  // candidate
    public object DisplayReason;  // candidate
}

// api/relationships/  [Auth POST]
public class RelationshipsRequest
{
    public object PlayerId;  // candidate
}

// api/relationships/v1/addfriendwithcode  [Auth GET]
public class RelationshipsV1AddfriendwithcodeRequest
{
    public object code;  // candidate
}

// api/roomCurrencies/v2/purchase  [WWW POST]
public class RoomCurrenciesV2PurchaseRequest
{
    public Guid MEFICMLHFBI;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomcurrencies/v1/createCurrency  [WWW POST]
public class RoomcurrenciesV1CreateCurrencyRequest
{
    public object Color;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object Shape;  // candidate
}

// api/roomcurrencies/v1/createPurchaseOffer  [WWW POST]
public class RoomcurrenciesV1CreatePurchaseOfferRequest
{
    public Guid DMLAPLKGFMP;  // wrapper
    public object Price;  // candidate
    public object CurrencyId;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object Order;  // candidate
}

// api/roomcurrencies/v1/currencies  [WWW GET]
public class RoomcurrenciesV1CurrenciesRequest
{
    public object roomId;  // candidate
}

// api/roomcurrencies/v1/deletePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1DeletePurchaseOfferRequest
{
    public Guid PurchaseOfferId;  // wrapper
}

// api/roomcurrencies/v1/getAllBalances  [WWW GET]
public class RoomcurrenciesV1GetAllBalancesRequest
{
    public object roomId;  // candidate
}

// api/roomcurrencies/v1/getBalance  [WWW GET]
public class RoomcurrenciesV1GetBalanceRequest
{
    public object accountId;  // candidate
    public object currencyId;  // candidate
}

// api/roomcurrencies/v1/updateCurrency  [WWW POST]
public class RoomcurrenciesV1UpdateCurrencyRequest
{
    public Guid DMLAPLKGFMP;  // wrapper
    public long? HBEOJPBCPDN;  // wrapper
    public byte? EDLOLMEBDKG;  // wrapper
    public int? DNOKCMICDIP;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid MEFICMLHFBI;  // wrapper
    public long? CBOCFFOBJCO;  // wrapper
    public long? POLKGJHOEOK;  // wrapper
    public int? IMIHFLPIKJB;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [WWW PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> JCKJBGDNIAO;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [WWW POST]
public class RoomkeysV1CreateRequest
{
    public FNHNPMNIAKO LPFFKBBBCBL;  // wrapper
    public Guid? JLDPKHNDKNN;  // wrapper
    public object Price;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Type;  // candidate
    public object RoomId;  // candidate
}

// api/roomkeys/v1/owns  [WWW GET]
public class RoomkeysV1OwnsRequest
{
    public object playerId;  // candidate
    public object roomKeyId;  // candidate
}

// api/rooms/v1/verifyRole  [Auth POST]
public class RoomsV1VerifyRoleRequest
{
    public object roomId;  // candidate
    public object role;  // candidate
    public object context;  // candidate
}

// api/rooms/v2/report  [Notifications POST]
public class RoomsV2ReportRequest
{
    public INJMGIDEJOA FNMELHOBKIG;  // wrapper
    public long? HGNLBCODCCF;  // wrapper
    public Guid? BCFFDFCOBDK;  // wrapper
    public int? FGDPGDALHEG;  // wrapper
    public object RoomOfferVersion;  // candidate
    public object ReportCategory;  // candidate
    public object RoomOfferId;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
}

// api/screensharereports/v1/report  [Auth POST]
public class ScreensharereportsV1ReportRequest
{
    public object ReportedPlayerId;  // candidate
    public object RoomInstanceId;  // candidate
    public object ImageName;  // candidate
    public object RoomInstanceType;  // candidate
    public object RoomId;  // candidate
}

// api/storefronts/v1/PurchaseRoomKeyWithCurrency  [WWW POST]
public class StorefrontsV1PurchaseRoomKeyWithCurrencyRequest
{
    public Guid FPJPCHOAKJM;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [WWW POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid BCEHPDGOPPO;  // wrapper
    public object progressionEventId;  // candidate
    public object requestedPrice;  // candidate
    public object purchasableXpBoostId;  // candidate
    public object expectedXp;  // candidate
}

// api/storefronts/v1/buyPurchaseReminder  [WWW POST]
public class StorefrontsV1BuyPurchaseReminderRequest
{
    public object purchaseReminderId;  // candidate
    public object requestedPrice;  // candidate
}

// api/storefronts/v1/buyRoomKey  [WWW GET]
public class StorefrontsV1BuyRoomKeyRequest
{
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/trialInvention  [WWW POST]
public class StorefrontsV1TrialInventionRequest
{
    public long inventionId;  // wrapper
}

// api/storefronts/v2/buyInvention  [WWW GET]
public class StorefrontsV2BuyInventionRequest
{
    public object requestedPrice;  // candidate
    public object inventionId;  // candidate
}

// api/testcasemanagement/v1/testcase/  [Auth POST]
public class TestcasemanagementV1TestcaseRequest
{
    public CFBIMFEMKPF KNNKNFJAFCF;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

