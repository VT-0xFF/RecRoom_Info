// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 240 (plus referenced enums)

// --------------------------------------------------------------------------
// AEHNJLDOKDN
//   (not directly referenced by a detected call)
public class AEHNJLDOKDN
{
    public string <ILBPNONLDCF>k__BackingField;    // 0x0x10
    public EHHIIJPDPPG <NGNEHDJBBEE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AEOKIHMCIHC
// base   : DLOPFDNIEKN
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
//   REQUEST  POST   api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.API]
public class AEOKIHMCIHC : DLOPFDNIEKN
{
    public MPKMIFDILJH? <GCAJJBDHGEJ>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <MDMBEADFBKB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AFGLPPMCIOK
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/price   [Service.API]
public class AFGLPPMCIOK
{
    public ELAKFLNAPAP <EMCKOLPIDNO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// AHFNOIDLIOE
//   (not directly referenced by a detected call)
public class AHFNOIDLIOE
{
    public float <CHFFJJKLMAN>k__BackingField;    // 0x0x10
    public float <MLMLMIKFLLK>k__BackingField;    // 0x0x14
    public float <DJCDIDDHOGF>k__BackingField;    // 0x0x18
    public float <LEPPNHHKOGM>k__BackingField;    // 0x0x1C
    public float <KEENBJAKJJD>k__BackingField;    // 0x0x20
    public float <LEAFEEIKNCF>k__BackingField;    // 0x0x24
    public float <ICCJJAIENJA>k__BackingField;    // 0x0x28
    public float <JLHOOLEPNEL>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// AIFILEKOFAC
//   RESPONSE POST   api/roomcurrencies/v1/createCurrency   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/updateCurrency   [Service.API]
public class AIFILEKOFAC
{
    public Guid <DDMKBNGIFJG>k__BackingField;    // 0x0x10
    public long? <MKJHGHIIGHF>k__BackingField;    // 0x0x20
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x30
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x38
    public IKHFMAMIBHH <NKHPCEHGPCF>k__BackingField;    // 0x0x40
    public long <NCMJOLKFNLG>k__BackingField;    // 0x0x48
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x50
    public DateTime <APKDFDAPDKF>k__BackingField;    // 0x0x58
    public DateTime <GNKOIMHAJOB>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// AJHFMPBHLPP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AJHFMPBHLPP
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
// ALCKHCELOOF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ALCKHCELOOF
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// ALPEMOIMILK
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
//   REQUEST  POST   api/config/v1/amplitude   [Service.API]
public class ALPEMOIMILK
{
    public string <GCLDBAIGPLA>k__BackingField;    // 0x0x10
    public string <MMJHGEGMNEB>k__BackingField;    // 0x0x18
    public bool <LBJHOCLFGJK>k__BackingField;    // 0x0x20
    public string <GNOFMHHOMPC>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// ANDJDFDENCL
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{balanceaddtypeId}/{id1}   [Service.API]
public class ANDJDFDENCL
{
    public IKHFMAMIBHH <NKHPCEHGPCF>k__BackingField;    // 0x0x10
    public CCBJPJFOOIG <PLBGEFDDOKI>k__BackingField;    // 0x0x14
    public int <FODMNIJBFEL>k__BackingField;    // 0x0x18
    public int <DIEDACBPPDC>k__BackingField;    // 0x0x1C
    public int <JAAAGLPALBN>k__BackingField;    // 0x0x20
    public INJHHBJIBFI <MHBOOMAGJNL>k__BackingField;    // 0x0x24
    public bool <DJMLFNFNOMN>k__BackingField;    // 0x0x28
    public float <ELGEGKCMMMO>k__BackingField;    // 0x0x2C
    public int <CNOAAHPCGIO>k__BackingField;    // 0x0x30
    public bool <KPNJBCBOBEE>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// AOBJHOEHKLC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AOBJHOEHKLC
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
// BDLCHJBPGIK
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/rooms/v1/filters   [Service.?]
public class BDLCHJBPGIK
{
    public List<string> <DNOOAFAKOJK>k__BackingField;    // 0x0x10
    public List<string> <AHFDPJLAHGC>k__BackingField;    // 0x0x18
    public List<string> <HMJAOKFAIJC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BFHHKBOGAHC
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.API]
public class BFHHKBOGAHC
{
    public int <PFAEKJAGAAA>k__BackingField;    // 0x0x10
    public int <NEPDPCBIGAA>k__BackingField;    // 0x0x14
    public float <BFNHJIAINCK>k__BackingField;    // 0x0x18
    public float <FHJGPEEJGHG>k__BackingField;    // 0x0x1C
    public bool <ENLPPDFDAEI>k__BackingField;    // 0x0x20
    public bool <JCCHHPIIIIJ>k__BackingField;    // 0x0x21
    public bool <ELAEKJJJDPP>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// BGNJAPOGBGF
//   RESPONSE PUT    api/roomkeys/v1/RoomKeyId   [Service.API]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.API]
public class BGNJAPOGBGF
{
    public LFHCCCJGOFL <BHJFFAHNIOD>k__BackingField;    // 0x0x10
    public NAPELIMFFMJ <OIFCLNLMILA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BKLALKNOKBK
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.API]
//   RESPONSE POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.API]
//   RESPONSE POST   api/roomEarningsDistributions/v1/earningsDistribution/{hEDMMBFEFLM}   [Service.API]
public class BKLALKNOKBK
{
    public long <MKJHGHIIGHF>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <PFFMNIIOCHO>k__BackingField;    // 0x0x18
    public FJAIFAHAGDB <KJJPGDLOMGF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// Backtrace.Unity.Model.BacktraceResult
//   (not directly referenced by a detected call)
public class BacktraceResult
{
    public BacktraceResult InnerExceptionResult;    // 0x0x10
    public string message;    // 0x0x18
    public string response;    // 0x0x20
    public BacktraceResultStatus Status;    // 0x0x28
    public string object;    // 0x0x30
    public string _rxId;    // 0x0x38
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
// CCBJPJFOOIG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CCBJPJFOOIG
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
}

// --------------------------------------------------------------------------
// CCFHPLKNJIM
//   (not directly referenced by a detected call)
public class CCFHPLKNJIM
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// CDPGJDBKDAI
//   RESPONSE GET    api/incentivizedreferrals/progress   [Service.API]
//   REQUEST  POST   api/incentivizedreferrals/progress   [Service.API]
public class CDPGJDBKDAI
{
    public int <EFKDOPHLIJI>k__BackingField;    // 0x0x10
    public List<IBEPLLCMGNL> <KGPDAIMPKDP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CEBPJKGMALN
//   RESPONSE GET    api/relationships/v1/addfriendwithcode?code=   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class CEBPJKGMALN
{
    public int <EGALFLBDGGB>k__BackingField;    // 0x0x10
    public CNBJCLOEDJP <NGNEHDJBBEE>k__BackingField;    // 0x0x14
    public JLGOLAHHAOB <OPKLIFNCDJJ>k__BackingField;    // 0x0x18
    public JLGOLAHHAOB <CELEADNBAAL>k__BackingField;    // 0x0x1C
    public JLGOLAHHAOB <ELGCHOMEDNI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CKHJNHKLMNK
//   RESPONSE POST   api/roomCurrencies/v2/purchase   [Service.API]
public class CKHJNHKLMNK
{
    public FFIEDCMIIFG <HGAFFCDFPFL>k__BackingField;    // 0x0x10
    public BalanceResponseDTO <MDMBEADFBKB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DCLCAAHKANO
//   (not directly referenced by a detected call)
public class DCLCAAHKANO
{
    public int <PDCDOAMJKDD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DKFHNJBGKPA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DKFHNJBGKPA
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
}

// --------------------------------------------------------------------------
// DLHCHENLKKJ
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class DLHCHENLKKJ
{
    public List<LBLPOPDNJPG> <AKCADKHKMEJ>k__BackingField;    // 0x0x10
    public DKFHNJBGKPA <OMCAKDJLGGN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DNLJKPCDPGD
//   (not directly referenced by a detected call)
public class DNLJKPCDPGD
{
    public Guid <DCCDLLIDCPN>k__BackingField;    // 0x0x10
    public Guid <NMGIFJFMBNP>k__BackingField;    // 0x0x20
    public DateTime <NIPEIAMEEKI>k__BackingField;    // 0x0x30
    public List<KPKIAKAOECN> <EFFAKNKOFMI>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// DOFGCBDDHPD
//   (not directly referenced by a detected call)
public class DOFGCBDDHPD
{
    public float <AOHEPJGKMIP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DPEDNKHFGDE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DPEDNKHFGDE
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// ECDLMCKGGCO
//   (not directly referenced by a detected call)
public class ECDLMCKGGCO
{
    public Guid <MNIDJJNOOKA>k__BackingField;    // 0x0x10
    public long <MKJHGHIIGHF>k__BackingField;    // 0x0x20
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x28
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x30
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x38
    public long <DMBKLIKGDAI>k__BackingField;    // 0x0x40
    public Guid? <CCKNJLFOOKN>k__BackingField;    // 0x0x48
    public DateTime <GNKOIMHAJOB>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// EDGEDJELLAN
//   (not directly referenced by a detected call)
public class EDGEDJELLAN
{
    public int <COOHGALAPNN>k__BackingField;    // 0x0x10
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x18
    public string <BGONOLENCBL>k__BackingField;    // 0x0x20
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x28
    public string <BGKGPGHAJPK>k__BackingField;    // 0x0x30
    public bool <HCKKKJHHEBC>k__BackingField;    // 0x0x38
    public int <KIGKHCKIPHD>k__BackingField;    // 0x0x3C
    public CCFHPLKNJIM <JKIOLIADPAB>k__BackingField;    // 0x0x40
    public BFPMBLEDAND MHKBJMCNEJK;    // 0x0x48
    public BFPMBLEDAND INAJLDPPJKP;    // 0x0x50
    public BFPMBLEDAND LAGNDMHCHKL;    // 0x0x58
    public DDCOOPMHJAI NCMFPPAHFLG;    // 0x0x60
}

// --------------------------------------------------------------------------
// EHHIIJPDPPG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EHHIIJPDPPG
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// ELAKFLNAPAP
//   (not directly referenced by a detected call)
public class ELAKFLNAPAP
{
    public long <DMBKLIKGDAI>k__BackingField;    // 0x0x10
    public Guid? <DDMKBNGIFJG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ELMFFCFAOIO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ELMFFCFAOIO
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
// ELOIGJJEENO
//   (not directly referenced by a detected call)
public class ELOIGJJEENO
{
    public int <PAHLEEHIGAA>k__BackingField;    // 0x0x10
    public DateTime <APKDFDAPDKF>k__BackingField;    // 0x0x18
    public DateTime? <JEPHFMJJDGM>k__BackingField;    // 0x0x20
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
// FFIEDCMIIFG
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.API]
//   REQUEST  POST   api/roomcurrencies/v1/getBalance   [Service.API]
public class FFIEDCMIIFG
{
    public int <ECMGHCNMNGD>k__BackingField;    // 0x0x10
    public Guid <DDMKBNGIFJG>k__BackingField;    // 0x0x14
    public long <LJKCIOLKIGP>k__BackingField;    // 0x0x28
    public DateTime <GNKOIMHAJOB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// FJAIFAHAGDB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FJAIFAHAGDB
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// GCPLHHAIDAM
//   (not directly referenced by a detected call)
public class GCPLHHAIDAM
{
    public bool <ADNKGGGOBLF>k__BackingField;    // 0x0x10
    public JFLGBOINJJG <GOGNPOJLNBD>k__BackingField;    // 0x0x14
    public int <PDIDIDGHPOJ>k__BackingField;    // 0x0x18
    public DateTime <GNKOIMHAJOB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GEGPKBEEOJJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GEGPKBEEOJJ
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// GKKDLKNBKNN
//   (not directly referenced by a detected call)
public class GKKDLKNBKNN
{
    public IKHFMAMIBHH <NKHPCEHGPCF>k__BackingField;    // 0x0x10
    public int <DMBKLIKGDAI>k__BackingField;    // 0x0x14
    public LDLEMDFBCDO <ACNDPBNAKAL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GLIPIKLLCJO
//   RESPONSE POST   api/roomcurrencies/v1/awardCurrency   [Service.API]
public class GLIPIKLLCJO
{
    public int <ECMGHCNMNGD>k__BackingField;    // 0x0x10
    public Guid <DDMKBNGIFJG>k__BackingField;    // 0x0x14
    public long <LJKCIOLKIGP>k__BackingField;    // 0x0x28
    public long <GAKPCEFJJLG>k__BackingField;    // 0x0x30
    public DateTime <PNKAEMLKGMA>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// GMEEJKIPMPP
//   REQUEST  POST   api/playerevents/v2   [Service.API]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.API]
public class GMEEJKIPMPP
{
    public long <MKJHGHIIGHF>k__BackingField;    // 0x0x10
    public long? <COPLCBIBHIP>k__BackingField;    // 0x0x18
    public long? <CNLHOOACKLF>k__BackingField;    // 0x0x28
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x38
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x40
    public List<string> <LBIKHDEBHBP>k__BackingField;    // 0x0x48
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x50
    public DateTime <GADGFIAKLPP>k__BackingField;    // 0x0x58
    public DateTime <PLHJKAHCLNI>k__BackingField;    // 0x0x60
    public PCOCIDOGJKN <LBNOIPIOPBK>k__BackingField;    // 0x0x68
    public bool <CBDOIDDIGFE>k__BackingField;    // 0x0x6C
    public bool <JCPOOFFCNOI>k__BackingField;    // 0x0x6D
    public GEGPKBEEOJJ <PHIPALFMEIA>k__BackingField;    // 0x0x70
    public GEGPKBEEOJJ <CPEAKAKBHGH>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// GMOOKIGDBPP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GMOOKIGDBPP
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// GPOEJFHKFKH
//   REQUEST  POST   api/playerevents/v1/respond   [Service.API]
public class GPOEJFHKFKH
{
    public long <LEAICOFPEGG>k__BackingField;    // 0x0x10
    public DPEDNKHFGDE <NGNEHDJBBEE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HAECLBNBCAC
//   RESPONSE GET    api/inventions/v1/personaldetails/{pGEKFHHOGJE}   [Service.API]
public class HAECLBNBCAC
{
    public bool <MKECONIPLFD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// HCMCIMMILFI
//   (not directly referenced by a detected call)
public class HCMCIMMILFI
{
    public long <LEAICOFPEGG>k__BackingField;    // 0x0x10
    public int <KACNBCLDNIL>k__BackingField;    // 0x0x18
    public long <MKJHGHIIGHF>k__BackingField;    // 0x0x20
    public long? <COPLCBIBHIP>k__BackingField;    // 0x0x28
    public long? <CNLHOOACKLF>k__BackingField;    // 0x0x38
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x48
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x50
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x58
    public DateTime <GADGFIAKLPP>k__BackingField;    // 0x0x60
    public DateTime <PLHJKAHCLNI>k__BackingField;    // 0x0x68
    public int <LNICJNDNFNN>k__BackingField;    // 0x0x70
    public PCOCIDOGJKN <LBNOIPIOPBK>k__BackingField;    // 0x0x74
    public bool <CBDOIDDIGFE>k__BackingField;    // 0x0x78
    public bool <JCPOOFFCNOI>k__BackingField;    // 0x0x79
    public GEGPKBEEOJJ <PHIPALFMEIA>k__BackingField;    // 0x0x7C
    public GEGPKBEEOJJ <CPEAKAKBHGH>k__BackingField;    // 0x0x80
    public long? <KLBAINAMABD>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// HIBGJNHCIGM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HIBGJNHCIGM
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// HLCNLHGHDPB
//   RESPONSE GET    api/groups/v1/memberships/{kFGECDIOFDG}   [Service.API]
public class HLCNLHGHDPB
{
    public long <JCBIEFGKEKH>k__BackingField;    // 0x0x10
    public int <BJLGJPKGGIN>k__BackingField;    // 0x0x18
    public KNCFJLDIFHB <HIFKMAHMCCH>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// HMOLNAFMCIK
//   REQUEST  POST   api/avatar/v3/saved/set   [Service.API]
public class HMOLNAFMCIK
{
    public int <KIGKHCKIPHD>k__BackingField;    // 0x0x10
    public string <HGMBIGEAHHL>k__BackingField;    // 0x0x18
    public string <JMPIFDNDDGH>k__BackingField;    // 0x0x20
    public string <FPPNNJHOLNN>k__BackingField;    // 0x0x28
    public string <ELEKMMJFHGF>k__BackingField;    // 0x0x30
    public string <LEPAJHJNMEH>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// IACPOIJKCNJ
//   (not directly referenced by a detected call)
public class IACPOIJKCNJ
{
    public int <JEMOEKCOPJM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IAHBGNJAGMK
//   RESPONSE GET    api/groups/v1/name/{nameId}   [Service.API]
//   RESPONSE GET    api/groups/v1/{groupId}   [Service.API]
public class IAHBGNJAGMK
{
    public long <JCBIEFGKEKH>k__BackingField;    // 0x0x10
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x18
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x20
    public DateTime <APKDFDAPDKF>k__BackingField;    // 0x0x28
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x30
    public ONOCEMEPOOL <LJPFDNKBENM>k__BackingField;    // 0x0x38
    public int <KDBAKLABCEA>k__BackingField;    // 0x0x3C
    public int <FGDCKIKIMNL>k__BackingField;    // 0x0x40
    public List<HLCNLHGHDPB> <JLOCHMDCFII>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// IBEPLLCMGNL
//   (not directly referenced by a detected call)
public class IBEPLLCMGNL
{
    public DateTime? <CMIAELJLLDM>k__BackingField;    // 0x0x10
    public DateTime? <FJMKHJMMLEF>k__BackingField;    // 0x0x20
    public IGIPFAIJADM <BHJFFAHNIOD>k__BackingField;    // 0x0x30
    public JCOAMNIAIBD <EEMPGJMLNOP>k__BackingField;    // 0x0x38
    public bool <OALOEEGABBL>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// IGIPFAIJADM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IGIPFAIJADM
{
    Locked = 0,
    Unlocked = 1,
    Claimed = 2,
}

// --------------------------------------------------------------------------
// IJMPMONNGMK
//   REQUEST  POST   api/playerevents/v1/report   [Service.API]
public class IJMPMONNGMK
{
    public LGGMHIGBMIG <JANMIMGMKCJ>k__BackingField;    // 0x0x10
    public long <LEAICOFPEGG>k__BackingField;    // 0x0x18
    public string <NBMBJIEHNEL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IKHFMAMIBHH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IKHFMAMIBHH
{
    Invalid = 0,
    LaserTagTickets = 1,
    RecCenterTokens = 2,
    LostSkullsGold = 100,
    DraculaSilver = 101,
    RecRoyale_Season1 = 200,
    RoomCurrency = 300,
}

// --------------------------------------------------------------------------
// INFDKHMMCCD
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/image   [Service.API]
public class INFDKHMMCCD
{
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// INJHHBJIBFI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum INJHHBJIBFI
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// JCOAMNIAIBD
//   (not directly referenced by a detected call)
public class JCOAMNIAIBD
{
    public int <HOMPLFAHCOK>k__BackingField;    // 0x0x10
    public int <FGCEIONHMKH>k__BackingField;    // 0x0x14
    public int <BBAJIMELOHN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JEEBKHKNOIB
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.API]
public class JEEBKHKNOIB
{
    public int <LBCJNHICGPB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JFAOHDLGCBL
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.API]
public class JFAOHDLGCBL
{
    public JLOPGADIKJG <BHJFFAHNIOD>k__BackingField;    // 0x0x10
    public MLFKNPKOHDM <PGEKANFHOHB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JFLGBOINJJG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JFLGBOINJJG
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
}

// --------------------------------------------------------------------------
// JHAMDKCLFNB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JHAMDKCLFNB
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
    UGCStorefront = 1800,
}

// --------------------------------------------------------------------------
// JHBFKNPBMBI
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class JHBFKNPBMBI
{
    public List<AEHNJLDOKDN> <LBIKHDEBHBP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JLOPGADIKJG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JLOPGADIKJG
{
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
    PlayerIsP2PRestricted = 10,
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
}

// --------------------------------------------------------------------------
// JPJCKKMBCNB
//   RESPONSE POST   api/roomcurrencies/v1/createPurchaseOffer   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/updatePurchaseOffer   [Service.API]
public class JPJCKKMBCNB
{
    public Guid <NECFHGFAGMM>k__BackingField;    // 0x0x10
    public Guid <DDMKBNGIFJG>k__BackingField;    // 0x0x20
    public int <DMGEALMLJLA>k__BackingField;    // 0x0x30
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x38
    public long <JELEGFKGIFP>k__BackingField;    // 0x0x40
    public long <DMBKLIKGDAI>k__BackingField;    // 0x0x48
    public DateTime <GNKOIMHAJOB>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// JPKCNGHBDIO
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/description   [Service.API]
public class JPKCNGHBDIO
{
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KIFDNODKCFM
// base   : NBJNGFBLNKF
//   (not directly referenced by a detected call)
public class KIFDNODKCFM : NBJNGFBLNKF
{
    public int <DGHLLBPMEBL>k__BackingField;    // 0x0x60
    public List<MMEMIAMJJJA> <EKJPAPPLBKD>k__BackingField;    // 0x0x68
    public List<MMEMIAMJJJA> <BOAKAIPPBNM>k__BackingField;    // 0x0x70
    public List<MMEMIAMJJJA> <KIBABGOAHHE>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// KIOBOPCKDLC
//   RESPONSE POST   api/consumables/v1/transfer   [Service.API]
//   REQUEST  POST   api/consumables/v1/transfer   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   REQUEST  POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   REQUEST  POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.API]
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.API]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.API]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.API]
//   RESPONSE POST   api/gamesight/event   [Service.API]
//   REQUEST  POST   api/gamesight/event   [Service.API]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.API]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.API]
//   REQUEST  POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.API]
public class KIOBOPCKDLC
{
    public bool <FGEDJMPFEOL>k__BackingField;    // 0x0x10
    public string <DLMFFIIMKMK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KKBCAPEIAJJ
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/inventions/v4/addversion   [Service.API]
//   RESPONSE POST   api/inventions/v6/save   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.API]
public class KKBCAPEIAJJ
{
    public MNEEGNMBBBC <BHJFFAHNIOD>k__BackingField;    // 0x0x10
    public LMOPKCGOOKK <NPNEFIHADLF>k__BackingField;    // 0x0x18
    public LKHHKLNIJCL <PAMAFABADOJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KLHLLGAIPNP
// base   : NBJNGFBLNKF
//   (not directly referenced by a detected call)
public class KLHLLGAIPNP : NBJNGFBLNKF
{
    public KPKIAKAOECN <HOIBBHMLDLM>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// KNCFJLDIFHB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KNCFJLDIFHB
{
    None = 0,
    Member = 0,
    Creator = 1,
    GroupDelete = 2,
    GroupModify = 4,
    MemberInvite = 8,
    MemberRemoval = 16,
    Moderator = 24,
    ModeratorAssign = 32,
    ModeratorRemove = 64,
    CoOwner = 124,
    Owner = 127,
    Pending = 128,
}

// --------------------------------------------------------------------------
// KNLAPLMFEPD
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class KNLAPLMFEPD
{
    public MKHMEOJFNOC <OMCAKDJLGGN>k__BackingField;    // 0x0x10
    public List<string> <LBIKHDEBHBP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KPKIAKAOECN
//   (not directly referenced by a detected call)
public class KPKIAKAOECN
{
    public int <NNBFHECOMDK>k__BackingField;    // 0x0x10
    public string <GCLKOGMOIIP>k__BackingField;    // 0x0x18
    public string <BGKGPGHAJPK>k__BackingField;    // 0x0x20
    public string <NPKDIHJAJBJ>k__BackingField;    // 0x0x28
    public string <JOCGHHCPLKL>k__BackingField;    // 0x0x30
    public KCAIJNFGGEF? <CMMBHFIFHCF>k__BackingField;    // 0x0x38
    public string <KGFEIPKDPBJ>k__BackingField;    // 0x0x40
    public string <PDOOAFDEFKO>k__BackingField;    // 0x0x48
    public bool <MFKLJOIAEBJ>k__BackingField;    // 0x0x50
    public bool <ALEANDKINEB>k__BackingField;    // 0x0x51
    public bool <EFEEMDDNGBC>k__BackingField;    // 0x0x52
    public HIBGJNHCIGM <KJEJGBPDAKE>k__BackingField;    // 0x0x54
    public IKHFMAMIBHH <NKHPCEHGPCF>k__BackingField;    // 0x0x58
    public int <PEGIJEIBINO>k__BackingField;    // 0x0x5C
    public ELMFFCFAOIO <EIDJCLLIKAA>k__BackingField;    // 0x0x60
    public LNEIAJDHAHF <DBNJDEGLDDH>k__BackingField;    // 0x0x64
    public int? <MDNBKDCPKFM>k__BackingField;    // 0x0x68
    public string <OEDPCOBMGOK>k__BackingField;    // 0x0x70
}

// --------------------------------------------------------------------------
// LAAPBAODDGM
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.API]
public class LAAPBAODDGM
{
    public Guid? <JDLLLCOFCHI>k__BackingField;    // 0x0x10
    public Guid <LCOOJPPOJNK>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// LBLPOPDNJPG
//   (not directly referenced by a detected call)
public class LBLPOPDNJPG
{
    public int <JCKCCFKFKGE>k__BackingField;    // 0x0x10
    public DKFHNJBGKPA <OMCAKDJLGGN>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// LBMPLEFOKND
//   RESPONSE POST   api/itemWishlists/v1/wishlist/me/{gOKEAEJFLPK}   [Service.API]
public class LBMPLEFOKND
{
    public Guid <HOJHIDDJGGM>k__BackingField;    // 0x0x10
    public int <ECMGHCNMNGD>k__BackingField;    // 0x0x20
    public int <NOIBMIJMPDP>k__BackingField;    // 0x0x24
    public DateTime <APKDFDAPDKF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LCNCGDPPLDK
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.API]
public class LCNCGDPPLDK
{
    public Guid? <MNIDJJNOOKA>k__BackingField;    // 0x0x10
    public long? <MKJHGHIIGHF>k__BackingField;    // 0x0x28
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x38
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x40
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x48
    public ELAKFLNAPAP <EMCKOLPIDNO>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// LDLEMDFBCDO
//   (not directly referenced by a detected call)
public class LDLEMDFBCDO
{
    public int <PCNHPLNDODL>k__BackingField;    // 0x0x10
    public DateTime? <NNPELFOFGOH>k__BackingField;    // 0x0x18
    public DateTime? <CNANHHPPEBN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LDOJCNOMGIC
//   RESPONSE GET    api/avatar/   [Service.API]
//   REQUEST  POST   api/avatar/   [Service.API]
//   REQUEST  POST   api/avatar/v2/set   [Service.API]
//   RESPONSE GET    api/avatar/v2/{iELGLAPLPOC}   [Service.API]
//   REQUEST  POST   api/avatar/v2/{iELGLAPLPOC}   [Service.API]
public class LDOJCNOMGIC
{
    public string <JMPIFDNDDGH>k__BackingField;    // 0x0x10
    public string <FPPNNJHOLNN>k__BackingField;    // 0x0x18
    public string <ELEKMMJFHGF>k__BackingField;    // 0x0x20
    public string <LEPAJHJNMEH>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LEHNOBFDBBG
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.API]
//   REQUEST  POST   api/PlayerReporting/v1/instantKick   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.API]
//   REQUEST  POST   api/PlayerReporting/v3/voteToKick   [Service.API]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.API]
//   RESPONSE POST   api/inventions/v1/report   [Service.API]
//   RESPONSE POST   api/playerevents/v1/report   [Service.API]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.API]
//   REQUEST  POST   api/relationships/sendfriendintroductions   [Service.API]
//   RESPONSE POST   api/rooms/v2/report   [Service.API]
//   REQUEST  POST   api/rooms/v2/report   [Service.API]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.API]
public class LEHNOBFDBBG
{
    public bool <FGEDJMPFEOL>k__BackingField;    // 0x0x10
    public string <LBMCBAJEGJO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LEOCCIEONGH
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.API]
public class LEOCCIEONGH
{
    public int <MEAPIJDMHEK>k__BackingField;    // 0x0x10
    public string <NBKEGBLPDAE>k__BackingField;    // 0x0x18
    public List<EDGEDJELLAN> <DHCNEAFGAPI>k__BackingField;    // 0x0x20
    public MGKEKLOGJNG <DFGJEGNBEGK>k__BackingField;    // 0x0x28
    public string <PAIBKAJFGPL>k__BackingField;    // 0x0x30
    public DateTime <NIPEIAMEEKI>k__BackingField;    // 0x0x38
    public DateTime <HMBBMOAGOLD>k__BackingField;    // 0x0x40
    public DateTime <CICBKAEJPPE>k__BackingField;    // 0x0x48
    public bool? <IDHIMBPEDIJ>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// LFHCCCJGOFL
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/v1/delete/{roomKeyId}   [Service.API]
public enum LFHCCCJGOFL
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
    PriceTooLow = 10,
    PriceTooHigh = 11,
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
}

// --------------------------------------------------------------------------
// LGLBLGGHONP
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.API]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.API]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.API]
public class LGLBLGGHONP
{
    public int <NEPDPCBIGAA>k__BackingField;    // 0x0x10
    public bool <ENLPPDFDAEI>k__BackingField;    // 0x0x14
    public DateTime <CJILBMPBAEH>k__BackingField;    // 0x0x18
    public bool <IOILDHLIFLA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LJIGADKPMLL
//   RESPONSE GET    api/influencerpartnerprogram/   [Service.API]
//   REQUEST  POST   api/influencerpartnerprogram/   [Service.API]
public class LJIGADKPMLL
{
    public List<int> <BAAHAKNBFJO>k__BackingField;    // 0x0x10
    public string <PODLGPMAHPB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LKHHKLNIJCL
//   (not directly referenced by a detected call)
public class LKHHKLNIJCL
{
    public long <LHFJPHONMKF>k__BackingField;    // 0x0x10
    public string <CHAFAFPKHJD>k__BackingField;    // 0x0x18
    public int <HHGJCNMMNJC>k__BackingField;    // 0x0x20
    public int <DFFHEAGOPHN>k__BackingField;    // 0x0x24
    public int <HNCMGMCMFDI>k__BackingField;    // 0x0x28
    public int <JNLBGHGECJK>k__BackingField;    // 0x0x2C
    public int <IFGCBFELKBF>k__BackingField;    // 0x0x30
    public string <GOBBOMLCKAG>k__BackingField;    // 0x0x38
    public string <OOIEMPCEGMC>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// LLMPIJGHOFI
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class LLMPIJGHOFI
{
    public DKFHNJBGKPA <OMCAKDJLGGN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LMOPKCGOOKK
//   (not directly referenced by a detected call)
public class LMOPKCGOOKK
{
    public long <LHFJPHONMKF>k__BackingField;    // 0x0x10
    public string <CHAFAFPKHJD>k__BackingField;    // 0x0x18
    public int <KACNBCLDNIL>k__BackingField;    // 0x0x20
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x28
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x30
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x38
    public int <CGIPOJIPIMM>k__BackingField;    // 0x0x40
    public CEFAOODHKIA <LBNOIPIOPBK>k__BackingField;    // 0x0x44
    public DateTime <GNKOIMHAJOB>k__BackingField;    // 0x0x48
    public DateTime <APKDFDAPDKF>k__BackingField;    // 0x0x50
    public DateTime? <BIMIPFDHPLD>k__BackingField;    // 0x0x58
    public long? <MOOBOEDADKH>k__BackingField;    // 0x0x68
    public int <CKAGMBCLBAK>k__BackingField;    // 0x0x78
    public int <OIHCCNICLFB>k__BackingField;    // 0x0x7C
    public int <PPJNNPGMMLL>k__BackingField;    // 0x0x80
    public AJHFMPBHLPP <CLEPLAKGOJI>k__BackingField;    // 0x0x84
    public AJHFMPBHLPP <ENIMCBJHOJF>k__BackingField;    // 0x0x88
    public bool <MLBIOMFMHPD>k__BackingField;    // 0x0x8C
    public bool <COGIHCKFMEB>k__BackingField;    // 0x0x8D
    public bool <AOFHLNCOALA>k__BackingField;    // 0x0x8E
    public int? <DMBKLIKGDAI>k__BackingField;    // 0x0x90
    public bool <MBKMCHOCCBE>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// LNEIAJDHAHF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LNEIAJDHAHF
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
    LevelUp = 100,
    Purchased_Gift_A = 500,
    Purchased_Gift_B = 501,
    Purchased_Gift_C = 502,
    Purchased_Gift_D = 503,
    Holiday = 1000,
    Contest = 1001,
    Promotion = 1002,
    LimitedTime = 1003,
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
    Store_LaserTag = 100000,
    Store_RecCenter = 100010,
    Consumable = 110000,
    Token = 110100,
    Punchcard_Challenge_Complete = 110200,
    All_Punchcard_Challenges_Complete = 110201,
    New_Player_Checklist_Item_Complete = 110300,
    Commerce_Purchase = 200000,
}

// --------------------------------------------------------------------------
// LOPKOPAGMJM
// base   : GJINCHCLEDL
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.API]
public class LOPKOPAGMJM : GJINCHCLEDL
{
    public List<KLHLLGAIPNP> KPKIIOPHJPP;    // 0x0x30
    public int <AGBBPLHCCFG>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// LPNDMCIABBL
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{gEAMBJBGHEI}   [Service.API]
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
public class LPNDMCIABBL
{
    public HCMCIMMILFI <MAENOHFJPDF>k__BackingField;    // 0x0x10
    public DKFHNJBGKPA <OMCAKDJLGGN>k__BackingField;    // 0x0x18
    public KNLAPLMFEPD <DOGBMKLLBCL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MCHDMHHPLAL
//   (not directly referenced by a detected call)
public class MCHDMHHPLAL
{
    public DateTime <APKDFDAPDKF>k__BackingField;    // 0x0x10
    public string <BCBKIKJBFPD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MDJPJLBNONN
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/name   [Service.API]
public class MDJPJLBNONN
{
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MGKEKLOGJNG
//   (not directly referenced by a detected call)
public class MGKEKLOGJNG
{
    public long <NNBFHECOMDK>k__BackingField;    // 0x0x10
    public string <NPKDIHJAJBJ>k__BackingField;    // 0x0x18
    public string <IACKOONOIBC>k__BackingField;    // 0x0x20
    public KCAIJNFGGEF? <CMMBHFIFHCF>k__BackingField;    // 0x0x28
    public string <KGFEIPKDPBJ>k__BackingField;    // 0x0x30
    public string <PDOOAFDEFKO>k__BackingField;    // 0x0x38
    public JHAMDKCLFNB <EHFFDNPDKGA>k__BackingField;    // 0x0x40
    public int <OLDLJIEOBOF>k__BackingField;    // 0x0x44
    public int <KCNDCKKIHDJ>k__BackingField;    // 0x0x48
    public LNEIAJDHAHF? <HLBBHBEJIPB>k__BackingField;    // 0x0x4C
    public HIBGJNHCIGM? <GCCLECDIGGK>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// MKHMEOJFNOC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MKHMEOJFNOC
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
    RoomPlaylistDoesNotExist = 13,
}

// --------------------------------------------------------------------------
// MKOFOFNHEDC
// base   : DLOPFDNIEKN
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  POST   api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.API]
public class MKOFOFNHEDC : DLOPFDNIEKN
{
    public GMOOKIGDBPP? <GCAJJBDHGEJ>k__BackingField;    // 0x0x18
    public FFIEDCMIIFG <HGAFFCDFPFL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MLFKNPKOHDM
//   (not directly referenced by a detected call)
public class MLFKNPKOHDM
{
    public Guid <MNIDJJNOOKA>k__BackingField;    // 0x0x10
    public int <ECMGHCNMNGD>k__BackingField;    // 0x0x20
    public int <OOEOAIIAMNB>k__BackingField;    // 0x0x24
    public Guid <DFFMHDJGNIP>k__BackingField;    // 0x0x28
    public DateTime <GNKOIMHAJOB>k__BackingField;    // 0x0x38
    public ECDLMCKGGCO <NPOGMKGNJBO>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// MMEMIAMJJJA
//   (not directly referenced by a detected call)
public class MMEMIAMJJJA
{
    public bool <PJBMOCELBPG>k__BackingField;    // 0x0x10
    public KPKIAKAOECN <HOIBBHMLDLM>k__BackingField;    // 0x0x18
    public float <GKPJNMJAOPC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MNEEGNMBBBC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MNEEGNMBBBC
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
}

// --------------------------------------------------------------------------
// MNMAEMICIPB
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable   [Service.API]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{iKCJMMAPOGF}   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{iKCJMMAPOGF}   [Service.API]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/description   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/description   [Service.API]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/image   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/image   [Service.API]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/name   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/name   [Service.API]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/price   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/price   [Service.API]
public class MNMAEMICIPB
{
    public JLOPGADIKJG <BHJFFAHNIOD>k__BackingField;    // 0x0x10
    public ECDLMCKGGCO <NPOGMKGNJBO>k__BackingField;    // 0x0x18
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
// NAPELIMFFMJ
//   (not directly referenced by a detected call)
public class NAPELIMFFMJ
{
    public long <LAOMMMOMDFL>k__BackingField;    // 0x0x10
    public Guid <CHAFAFPKHJD>k__BackingField;    // 0x0x18
    public long <MKJHGHIIGHF>k__BackingField;    // 0x0x28
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x30
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x38
    public int <DMBKLIKGDAI>k__BackingField;    // 0x0x40
    public Guid? <CCKNJLFOOKN>k__BackingField;    // 0x0x44
    public DateTime <APKDFDAPDKF>k__BackingField;    // 0x0x58
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// NBJNGFBLNKF
//   (not directly referenced by a detected call)
public class NBJNGFBLNKF
{
    public int <NOIBMIJMPDP>k__BackingField;    // 0x0x10
    public NKEEIMMILGO <NGNEHDJBBEE>k__BackingField;    // 0x0x14
    public List<GKKDLKNBKNN> <LOIAPGAMLOG>k__BackingField;    // 0x0x18
    public List<GKKDLKNBKNN> <POJBPHDLIEL>k__BackingField;    // 0x0x20
    public bool <OKLAMLMLJPB>k__BackingField;    // 0x0x28
    public DateTime? <ICMGAAJGKGC>k__BackingField;    // 0x0x30
    public DateTime? <PFMCIMPCNOM>k__BackingField;    // 0x0x40
    public DateTime? <NEDEJKIIHFD>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// NCGHAAFLPOG
//   RESPONSE GET    api/testcasemanagement/v1/testcase/{iAKMMHHICJO}   [Service.API]
public class NCGHAAFLPOG
{
    public string <AJKLNBBKDCC>k__BackingField;    // 0x0x10
    public string <JIBIEPODPKH>k__BackingField;    // 0x0x18
    public string <OCAMCPJGELG>k__BackingField;    // 0x0x20
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x28
    public string <OMFJDDIKBNM>k__BackingField;    // 0x0x30
    public ALCKHCELOOF <BHJFFAHNIOD>k__BackingField;    // 0x0x38
    public List<string> <BCBAOPBNNGM>k__BackingField;    // 0x0x40
    public List<string> <LBIKHDEBHBP>k__BackingField;    // 0x0x48
    public string <ODDBBKMMCNP>k__BackingField;    // 0x0x50
    public List<MCHDMHHPLAL> <GJJMOMJPPPJ>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// NEBGDFLOIOH
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{iAKMMHHICJO}   [Service.API]
public class NEBGDFLOIOH
{
    public uint <AJKLNBBKDCC>k__BackingField;    // 0x0x10
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x18
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x20
    public DateTime <ALGHBKAGLFH>k__BackingField;    // 0x0x28
    public DateTime? <JPMOIBHGGEN>k__BackingField;    // 0x0x30
    public bool <ALDDKHFPGIE>k__BackingField;    // 0x0x40
    public List<NCGHAAFLPOG> <EEBHLIDKMDC>k__BackingField;    // 0x0x48
    public List<string> <LBIKHDEBHBP>k__BackingField;    // 0x0x50
    public int <FMMOMNILBOE>k__BackingField;    // 0x0x58
    public int <POOAJOEDCFL>k__BackingField;    // 0x0x5C
    public int <NLBNFJOLONJ>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// NEOFEOMBOPA
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class NEOFEOMBOPA
{
    public LAAPBAODDGM <GMGIGHNDDMI>k__BackingField;    // 0x0x10
    public ELAKFLNAPAP <BEPGEPCKPOG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NGNFLJCAJLI
//   (not directly referenced by a detected call)
public class NGNFLJCAJLI
{
    public int <FLOOCIJDFAL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NHKABFLMIJM
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class NHKABFLMIJM
{
    public int? <IPNHLBLBPKO>k__BackingField;    // 0x0x10
    public string <OMFJDDIKBNM>k__BackingField;    // 0x0x18
    public string <EDCEGAPHDIB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// NHOBOIGPLKK
// base   : GJINCHCLEDL
//   RESPONSE GET    api/storefronts/v1/season/{seasonId}   [Service.API]
public class NHOBOIGPLKK : GJINCHCLEDL
{
    public int <BGEAPEMPCEM>k__BackingField;    // 0x0x30
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x38
    public DateTime <NIPEIAMEEKI>k__BackingField;    // 0x0x40
    public DateTime <HMBBMOAGOLD>k__BackingField;    // 0x0x48
    public IKHFMAMIBHH <NKHPCEHGPCF>k__BackingField;    // 0x0x50
    public NBJNGFBLNKF <FFGGFJBKKFA>k__BackingField;    // 0x0x58
    public List<KIFDNODKCFM> <HJMGMCAEKME>k__BackingField;    // 0x0x60
    public GCPLHHAIDAM <FKNJLHKGGOM>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// NKEEIMMILGO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NKEEIMMILGO
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// NPHDBIAFODJ
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.API]
public class NPHDBIAFODJ
{
    public Guid <JNPJCHFOAKH>k__BackingField;    // 0x0x10
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x20
    public string <EMLDEPICBKP>k__BackingField;    // 0x0x28
    public DateTime <NIPEIAMEEKI>k__BackingField;    // 0x0x30
    public DateTime? <IJPIKCLADFH>k__BackingField;    // 0x0x38
    public List<DNLJKPCDPGD> <CMILMACLMMM>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// ODCPAEOLJGN
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   REQUEST  POST   api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{iELGLAPLPOC}   [Service.API]
public class ODCPAEOLJGN
{
    public List<HCMCIMMILFI> <BAKHOOGDHAO>k__BackingField;    // 0x0x10
    public List<OKCCADMMNKI> <PMHPJFONMOD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OEALFGBMGMP
//   RESPONSE GET    api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class OEALFGBMGMP
{
    public LGGMHIGBMIG <JANMIMGMKCJ>k__BackingField;    // 0x0x10
    public int <LBCJNHICGPB>k__BackingField;    // 0x0x14
    public long <PLEHPPNLKJH>k__BackingField;    // 0x0x18
    public bool <KHKCMNCBMLD>k__BackingField;    // 0x0x20
    public string <LBMCBAJEGJO>k__BackingField;    // 0x0x28
    public int? <JHGPBBLFDEA>k__BackingField;    // 0x0x30
    public bool <HBMCOECHHJM>k__BackingField;    // 0x0x38
    public bool <BIJPBDMIBEH>k__BackingField;    // 0x0x39
    public string <MACLDHECLNE>k__BackingField;    // 0x0x40
    public float <CBJLLKJANHM>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// OKADLBLBFBD
//   (not directly referenced by a detected call)
public class OKADLBLBFBD
{
    public AOBJHOEHKLC CKDLDBIGIGC;    // 0x0x10
    public int NBCPOJPOLCO;    // 0x0x14
}

// --------------------------------------------------------------------------
// OKCCADMMNKI
//   (not directly referenced by a detected call)
public class OKCCADMMNKI
{
    public HCMCIMMILFI <MAENOHFJPDF>k__BackingField;    // 0x0x10
    public PKNHINEGACE <IAHLHICIJFO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OKJKIMEFOLK
//   RESPONSE GET    api/incentivizedreferrals/   [Service.API]
//   REQUEST  POST   api/incentivizedreferrals/   [Service.API]
public class OKJKIMEFOLK
{
    public List<ELOIGJJEENO> <JOIOOIHFMAB>k__BackingField;    // 0x0x10
    public string <PODLGPMAHPB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ONOCEMEPOOL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ONOCEMEPOOL
{
    GoodStanding = 0,
    InReview = 1,
    TempLock = 2,
    Permaban = 3,
}

// --------------------------------------------------------------------------
// PCOCIDOGJKN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PCOCIDOGJKN
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// PDNCMIADMCH
//   RESPONSE GET    api/config/   [Service.API]
//   REQUEST  POST   api/config/   [Service.API]
public class PDNCMIADMCH
{
    public Dictionary<int, int> <LDKCOMKDMMA>k__BackingField;    // 0x0x10
    public List<LEKPLMALANJ> <EKFDHBEBPKD>k__BackingField;    // 0x0x18
    public OKADLBLBFBD[][] <AFELNDICPLO>k__BackingField;    // 0x0x20
    public DCLCAAHKANO <MDOENFMEPDE>k__BackingField;    // 0x0x28
    public AHFNOIDLIOE <JPDFHIHHHNM>k__BackingField;    // 0x0x30
    public IACPOIJKCNJ <EJIHPCOAFLH>k__BackingField;    // 0x0x38
    public NGNFLJCAJLI <GJIEOOEBOID>k__BackingField;    // 0x0x40
    public DOFGCBDDHPD <CBCCOIJGMIH>k__BackingField;    // 0x0x48
    public string <KFGGKAJAOGE>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// PFKPDMLGIJM
//   RESPONSE PUT    api/players/v4/current/contact   [Service.API]
//   REQUEST  POST   api/players/v4/current/contact   [Service.API]
public class PFKPDMLGIJM
{
    public HTTPResponse CJACAHOFHME;    // 0x0x10
    public int? GAEOCOJKMMC;    // 0x0x18
    public string MLJIHJNBIPL;    // 0x0x20
    public byte[] PGLEGIGKJID;    // 0x0x28
    public string MFJKMGNMBGP;    // 0x0x30
}

// --------------------------------------------------------------------------
// PKNHINEGACE
//   (not directly referenced by a detected call)
public class PKNHINEGACE
{
    public long <CLFJFOLCHNK>k__BackingField;    // 0x0x10
    public long <LEAICOFPEGG>k__BackingField;    // 0x0x18
    public int <BJLGJPKGGIN>k__BackingField;    // 0x0x20
    public DateTime <APKDFDAPDKF>k__BackingField;    // 0x0x28
    public DPEDNKHFGDE <NGNEHDJBBEE>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v4/addversion   [Service.API]
public class AddVersionInventionRequestDTO
{
    public long inventionId;    // 0x0x10
    public int instantiationCost;    // 0x0x18
    public int lightsCost;    // 0x0x1C
    public int chipsCost;    // 0x0x20
    public int cloudVariablesCost;    // 0x0x24
    public int aiCost;    // 0x0x28
    public long creationRoomId;    // 0x0x30
    public string inventionDataFilename;    // 0x0x38
    public List<long> referencedInventions;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.?]
public class AppleMusicPromotionResponseDTO
{
    public HPINGJLPCAO <OMCAKDJLGGN>k__BackingField;    // 0x0x10
    public string <OGCPCMLJADG>k__BackingField;    // 0x0x18
    public string <LEILCEGPIFH>k__BackingField;    // 0x0x20
    public string <KDEIKPICHKE>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BroadcastRoomInstanceRequest
//   (not directly referenced by a detected call)
public class BroadcastRoomInstanceRequest
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
    public long? <BroadcastRoomInstanceId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.BulkInviteRequest
//   REQUEST  POST   api/playerevents/v1/bulkInvite   [Service.API]
public class BulkInviteRequest
{
    public long PlayerEventId;    // 0x0x10
    public List<int> InvitedPlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.CheerRequest
//   REQUEST  POST   api/inventions/v1/cheer   [Service.API]
public class CheerRequest
{
    public long InventionId;    // 0x0x10
    public bool Cheer;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.DeleteMessagesRequestDTO
//   REQUEST  POST   api/messages/v3/delete   [Service.API]
public class DeleteMessagesRequestDTO
{
    public List<long> MessageIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.DeleteResponseRequest
//   REQUEST  POST   api/playerevents/v1/deleteResponse   [Service.API]
public class DeleteResponseRequest
{
    public long PlayerEventId;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.GetEventsForClubsRequest
//   (not directly referenced by a detected call)
public class GetEventsForClubsRequest
{
    public List<long> Id;    // 0x0x10
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
    public FIOOJLBFCKG FilterType;    // 0x0x20
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
// RecNet.InventionBatchRequest
//   (not directly referenced by a detected call)
public class InventionBatchRequest
{
    public List<long> InventionIds;    // 0x0x10
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
//   REQUEST  POST   api/inventions/v1/settags   [Service.API]
public class ModifyTagsRequest
{
    public long InventionId;    // 0x0x10
    public List<string> AutoTags;    // 0x0x18
    public List<string> CustomTags;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.MultiRecipientFreeGiftRequestDTO
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.API]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public LNEIAJDHAHF <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v6/save   [Service.API]
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
    public long creationRoomId;    // 0x0x40
    public string inventionDataFilename;    // 0x0x48
    public List<long> referencedInventions;    // 0x0x50
    public EODHPBCCGLG creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public GHOFACIFBMI <NKBPAOAMABE>k__BackingField;    // 0x0x10
    public MAPKJEJJAAH <PMNGMNCMGLB>k__BackingField;    // 0x0x14
    public string <NDMGPOOPHIA>k__BackingField;    // 0x0x18
    public string <INGMGGGGDLF>k__BackingField;    // 0x0x20
    public bool <ADNJNMILFJK>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public List<GHOFACIFBMI> <GAPLEFJODIE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public PEFKENLNKAK ReportCategory;    // 0x0x20
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
//   REQUEST  POST   api/inventions/v1/updateprice   [Service.API]
public class UpdatePriceRequest
{
    public long InventionId;    // 0x0x10
    public int Price;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_DataResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class SA_DataResult : SA_Result
{
    public string m_Data;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class SA_Result
{
    public SA_Error m_error;    // 0x0x10
    public string m_requestId;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_iResult
//   (not directly referenced by a detected call)
public class SA_iResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.AuthenticationServices.ISN_ASAuthorizationOpenIDRequest
// base   : SA.iOS.AuthenticationServices.ISN_ASAuthorizationRequest
//   (not directly referenced by a detected call)
public class ISN_ASAuthorizationOpenIDRequest : ISN_ASAuthorizationRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.AuthenticationServices.ISN_ASAuthorizationRequest
// base   : SA.iOS.Utilities.ISN_NativeObject
//   (not directly referenced by a detected call)
public class ISN_ASAuthorizationRequest : ISN_NativeObject
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.AuthenticationServices.ISN_ASAuthorizationSingleSignOnRequest
// base   : SA.iOS.AuthenticationServices.ISN_IASAuthorizationAppleIDRequest
//   (not directly referenced by a detected call)
public class ISN_ASAuthorizationSingleSignOnRequest : ISN_IASAuthorizationAppleIDRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.AuthenticationServices.ISN_IASAuthorizationAppleIDRequest
// base   : SA.iOS.AuthenticationServices.ISN_ASAuthorizationOpenIDRequest
//   (not directly referenced by a detected call)
public class ISN_IASAuthorizationAppleIDRequest : ISN_ASAuthorizationOpenIDRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.CloudKit.ISN_CKResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_CKResult : SA_Result
{
    public string m_State;    // 0x0x20
    public string m_Description;    // 0x0x28
    public int m_ErrorCode;    // 0x0x30
    public ISN_CKRecord m_Record;    // 0x0x38
}

// --------------------------------------------------------------------------
// SA.iOS.Contacts.ISN_CNContactsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_CNContactsResult : SA_Result
{
    public List<ISN_CNContact> m_Contacts;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_AlarmDataRequest
//   (not directly referenced by a detected call)
public class ISN_AlarmDataRequest
{
    public bool m_HasAlarm;    // 0x0x10
    public bool m_isAbsoluteDate;    // 0x0x11
    public long m_DueDate;    // 0x0x18
    public long m_TimeStamp;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EKAlarmDataRequest
//   (not directly referenced by a detected call)
public class ISN_EKAlarmDataRequest
{
    public bool m_HasAlarm;    // 0x0x10
    public bool m_IsAbsoluteDate;    // 0x0x11
    public long m_DueDate;    // 0x0x18
    public long m_TimeStamp;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EKDataRequest
//   (not directly referenced by a detected call)
public class ISN_EKDataRequest
{
    public string m_Title;    // 0x0x10
    public long m_StartDate;    // 0x0x18
    public long m_EndDate;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EKRecurrenceRuleRequest
//   (not directly referenced by a detected call)
public class ISN_EKRecurrenceRuleRequest
{
    public bool m_HasRule;    // 0x0x10
    public string m_Frequency;    // 0x0x18
    public int m_Interval;    // 0x0x20
    public bool m_HasEndDate;    // 0x0x24
    public long m_EndDate;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EKSaveResult
//   (not directly referenced by a detected call)
public class ISN_EKSaveResult
{
    public string m_Identifier;    // 0x0x10
    public SA_Result m_Result;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EventKitDataRequest
//   (not directly referenced by a detected call)
public class ISN_EventKitDataRequest
{
    public string m_Title;    // 0x0x10
    public long m_StartDate;    // 0x0x18
    public long m_EndDate;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_EventKitSaveResult
//   (not directly referenced by a detected call)
public class ISN_EventKitSaveResult
{
    public string m_Identifier;    // 0x0x10
    public SA_Result m_Result;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.EventKit.ISN_RecurrenceRuleRequest
//   (not directly referenced by a detected call)
public class ISN_RecurrenceRuleRequest
{
    public bool m_HasRule;    // 0x0x10
    public string m_Frequency;    // 0x0x18
    public int m_Interval;    // 0x0x20
    public bool m_HasEndDate;    // 0x0x24
    public long m_EndDate;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.Foundation.ISN_NSKeyValueResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_NSKeyValueResult : SA_Result
{
    public ISN_NSKeyValueObject m_KeyValueObject;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKAchievementsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKAchievementsResult : SA_Result
{
    public List<ISN_GKAchievement> m_Achievements;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKIdentityVerificationSignatureResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKIdentityVerificationSignatureResult : SA_Result
{
    public string m_PublicKeyUrl;    // 0x0x20
    public string m_Signature;    // 0x0x28
    public string m_Salt;    // 0x0x30
    public long m_Timestamp;    // 0x0x38
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKImageLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKImageLoadResult : SA_Result
{
    public Texture2D m_Image;    // 0x0x20
    public string m_ImageBase64;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKLeaderboardsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKLeaderboardsResult : SA_Result
{
    public List<ISN_GKLeaderboard> m_Leaderboards;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKLoadDefaultLeaderboardResult
// base   : SA.Foundation.Templates.SA_DataResult
//   (not directly referenced by a detected call)
public class ISN_GKLoadDefaultLeaderboardResult : SA_DataResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKResolveSavedGamesRequest
//   (not directly referenced by a detected call)
public class ISN_GKResolveSavedGamesRequest
{
    public List<string> m_ConflictedGames;    // 0x0x10
    public string m_Data;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameFetchResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameFetchResult : SA_Result
{
    public List<ISN_GKSavedGame> m_SavedGames;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameLoadResult : SA_Result
{
    public string m_Data;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameSaveResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameSaveResult : SA_Result
{
    public ISN_GKSavedGame m_SavedGame;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKScoreLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKScoreLoadResult : SA_Result
{
    public List<ISN_GKScore> m_Scores;    // 0x0x20
    public ISN_GKLeaderboard m_Leaderboard;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.Internal.ISN_GKScoreRequest
//   (not directly referenced by a detected call)
public class ISN_GKScoreRequest
{
    public List<ISN_GKScore> m_scores;    // 0x0x10
}

// --------------------------------------------------------------------------
// SA.iOS.Photos.ISN_PHFetchResult`1
// base   : SA.iOS.Utilities.ISN_NativeObject
//   (not directly referenced by a detected call)
public class ISN_PHFetchResult : ISN_NativeObject
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// SA.iOS.ReplayKit.ISN_PRPreviewResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_PRPreviewResult : SA_Result
{
    public List<string> m_ActivityTypes;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.ReplayKit.ISN_RPStopResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_RPStopResult : SA_Result
{
    public bool m_HasPreviewController;    // 0x0x20
    public ISN_RPPreviewViewController PreviewController;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.Social.Enum.TextMessageComposeResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum TextMessageComposeResult
{
    Cancelled = 0,
    Sent = 1,
    Failed = 2,
    NotSupportedByDevice = 3,
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
    public string m_ActivityType;    // 0x0x20
    public bool m_Completed;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKInitResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_SKInitResult : SA_Result
{
    public List<ISN_SKProduct> m_Products;    // 0x0x20
    public List<string> m_InvalidProductIdentifiers;    // 0x0x28
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
// SA.iOS.UIKit.ISN_UIApplicationDelegateResult
//   (not directly referenced by a detected call)
public class ISN_UIApplicationDelegateResult
{
    public string m_EventName;    // 0x0x10
    public string m_Data;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIMenuControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIMenuControllerResult : SA_Result
{
    public int m_ChosenIndex;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIPickerControllerRequest
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerRequest
{
    public List<string> m_MediaTypes;    // 0x0x10
    public ISN_UIImagePickerControllerSourceType m_SourceType;    // 0x0x18
    public bool m_AllowsEditing;    // 0x0x1C
    public float m_ImageCompressionRate;    // 0x0x20
    public int m_MaxImageSize;    // 0x0x24
    public ISN_UIImageCompressionFormat m_EncodingType;    // 0x0x28
    public ISN_UIImagePickerControllerCameraDevice m_CameraDevice;    // 0x0x2C
    public ISN_UIModalPresentationStyle m_ModalPresentationStyle;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIPickerControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerResult : SA_Result
{
    public string m_EncodedImage;    // 0x0x20
    public string m_MediaUrl;    // 0x0x28
    public string m_ImageUrl;    // 0x0x30
    public string m_MediaType;    // 0x0x38
    public Texture2D m_Texture;    // 0x0x40
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIRegisterRemoteNotificationsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIRegisterRemoteNotificationsResult : SA_Result
{
    public string m_DeviceTokenUtf8;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIWheelPickerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIWheelPickerResult : SA_Result
{
    public string m_Value;    // 0x0x20
    public string m_State;    // 0x0x28
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
// StansAssets.Foundation.CachedWebRequest
//   (not directly referenced by a detected call)
public class CachedWebRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// StansAssets.Foundation.Models.IResult
//   (not directly referenced by a detected call)
public class IResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// StansAssets.Foundation.Models.Result
//   (not directly referenced by a detected call)
public class Result
{
    public Error m_Error;    // 0x0x10
}

// --------------------------------------------------------------------------
// Steamworks.CallResult
//   (not directly referenced by a detected call)
public class CallResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Steamworks.CallResult`1
// base   : Steamworks.CallResult
//   (not directly referenced by a detected call)
public class CallResult : CallResult
{
    public APIDispatchDelegate<T> m_Func;    // 0x0x0
    public SteamAPICall_t m_hAPICall;    // 0x0x0
    public bool m_bDisposed;    // 0x0x0
}

// --------------------------------------------------------------------------
// Steamworks.EAuthSessionResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EAuthSessionResponse
{
    k_EAuthSessionResponseOK = 0,
    k_EAuthSessionResponseUserNotConnectedToSteam = 1,
    k_EAuthSessionResponseNoLicenseOrExpired = 2,
    k_EAuthSessionResponseVACBanned = 3,
    k_EAuthSessionResponseLoggedInElseWhere = 4,
    k_EAuthSessionResponseVACCheckTimedOut = 5,
    k_EAuthSessionResponseAuthTicketCanceled = 6,
    k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed = 7,
    k_EAuthSessionResponseAuthTicketInvalid = 8,
    k_EAuthSessionResponsePublisherIssuedBan = 9,
}

// --------------------------------------------------------------------------
// Steamworks.EBeginAuthSessionResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EBeginAuthSessionResult
{
    k_EBeginAuthSessionResultOK = 0,
    k_EBeginAuthSessionResultInvalidTicket = 1,
    k_EBeginAuthSessionResultDuplicateRequest = 2,
    k_EBeginAuthSessionResultInvalidVersion = 3,
    k_EBeginAuthSessionResultGameMismatch = 4,
    k_EBeginAuthSessionResultExpiredTicket = 5,
}

// --------------------------------------------------------------------------
// Steamworks.EBroadcastUploadResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EBroadcastUploadResult
{
    k_EBroadcastUploadResultNone = 0,
    k_EBroadcastUploadResultOK = 1,
    k_EBroadcastUploadResultInitFailed = 2,
    k_EBroadcastUploadResultFrameFailed = 3,
    k_EBroadcastUploadResultTimeout = 4,
    k_EBroadcastUploadResultBandwidthExceeded = 5,
    k_EBroadcastUploadResultLowFPS = 6,
    k_EBroadcastUploadResultMissingKeyFrames = 7,
    k_EBroadcastUploadResultNoConnection = 8,
    k_EBroadcastUploadResultRelayFailed = 9,
    k_EBroadcastUploadResultSettingsChanged = 10,
    k_EBroadcastUploadResultMissingAudio = 11,
    k_EBroadcastUploadResultTooFarBehind = 12,
    k_EBroadcastUploadResultTranscodeBehind = 13,
    k_EBroadcastUploadResultNotAllowedToPlay = 14,
    k_EBroadcastUploadResultBusy = 15,
    k_EBroadcastUploadResultBanned = 16,
    k_EBroadcastUploadResultAlreadyActive = 17,
    k_EBroadcastUploadResultForcedOff = 18,
    k_EBroadcastUploadResultAudioBehind = 19,
    k_EBroadcastUploadResultShutdown = 20,
    k_EBroadcastUploadResultDisconnect = 21,
    k_EBroadcastUploadResultVideoInitFailed = 22,
    k_EBroadcastUploadResultAudioInitFailed = 23,
}

// --------------------------------------------------------------------------
// Steamworks.EChatRoomEnterResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EChatRoomEnterResponse
{
    k_EChatRoomEnterResponseSuccess = 1,
    k_EChatRoomEnterResponseDoesntExist = 2,
    k_EChatRoomEnterResponseNotAllowed = 3,
    k_EChatRoomEnterResponseFull = 4,
    k_EChatRoomEnterResponseError = 5,
    k_EChatRoomEnterResponseBanned = 6,
    k_EChatRoomEnterResponseLimited = 7,
    k_EChatRoomEnterResponseClanDisabled = 8,
    k_EChatRoomEnterResponseCommunityBan = 9,
    k_EChatRoomEnterResponseMemberBlockedYou = 10,
    k_EChatRoomEnterResponseYouBlockedMember = 11,
    k_EChatRoomEnterResponseRatelimitExceeded = 15,
}

// --------------------------------------------------------------------------
// Steamworks.ELeaderboardDataRequest
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ELeaderboardDataRequest
{
    k_ELeaderboardDataRequestGlobal = 0,
    k_ELeaderboardDataRequestGlobalAroundUser = 1,
    k_ELeaderboardDataRequestFriends = 2,
    k_ELeaderboardDataRequestUsers = 3,
}

// --------------------------------------------------------------------------
// Steamworks.EMatchMakingServerResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EMatchMakingServerResponse
{
    eServerResponded = 0,
    eServerFailedToRespond = 1,
    eNoServersListedOnMasterServer = 2,
}

// --------------------------------------------------------------------------
// Steamworks.ERegisterActivationCodeResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ERegisterActivationCodeResult
{
    k_ERegisterActivationCodeResultOK = 0,
    k_ERegisterActivationCodeResultFail = 1,
    k_ERegisterActivationCodeResultAlreadyRegistered = 2,
    k_ERegisterActivationCodeResultTimeout = 3,
    k_ERegisterActivationCodeAlreadyOwned = 4,
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
// Steamworks.EUserHasLicenseForAppResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EUserHasLicenseForAppResult
{
    k_EUserHasLicenseResultHasLicense = 0,
    k_EUserHasLicenseResultDoesNotHaveLicense = 1,
    k_EUserHasLicenseResultNoAuth = 2,
}

// --------------------------------------------------------------------------
// Steamworks.EVoiceResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EVoiceResult
{
    k_EVoiceResultOK = 0,
    k_EVoiceResultNotInitialized = 1,
    k_EVoiceResultNotRecording = 2,
    k_EVoiceResultNoData = 3,
    k_EVoiceResultBufferTooSmall = 4,
    k_EVoiceResultDataCorrupted = 5,
    k_EVoiceResultRestricted = 6,
    k_EVoiceResultUnsupportedCodec = 7,
    k_EVoiceResultReceiverOutOfDate = 8,
    k_EVoiceResultReceiverDidNotAnswer = 9,
}

// --------------------------------------------------------------------------
// Steamworks.HServerListRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class HServerListRequest : ValueType
{
    public nint m_HServerListRequest;    // 0x0x0
}

// --------------------------------------------------------------------------
// Steamworks.ISteamMatchmakingPingResponse
//   (not directly referenced by a detected call)
public class ISteamMatchmakingPingResponse
{
    public VTable m_VTable;    // 0x0x10
    public nint m_pVTable;    // 0x0x18
    public GCHandle m_pGCHandle;    // 0x0x20
    public ServerResponded m_ServerResponded;    // 0x0x28
    public ServerFailedToRespond m_ServerFailedToRespond;    // 0x0x30
}

// --------------------------------------------------------------------------
// Steamworks.ISteamMatchmakingPlayersResponse
//   (not directly referenced by a detected call)
public class ISteamMatchmakingPlayersResponse
{
    public VTable m_VTable;    // 0x0x10
    public nint m_pVTable;    // 0x0x18
    public GCHandle m_pGCHandle;    // 0x0x20
    public AddPlayerToList m_AddPlayerToList;    // 0x0x28
    public PlayersFailedToRespond m_PlayersFailedToRespond;    // 0x0x30
    public PlayersRefreshComplete m_PlayersRefreshComplete;    // 0x0x38
}

// --------------------------------------------------------------------------
// Steamworks.ISteamMatchmakingRulesResponse
//   (not directly referenced by a detected call)
public class ISteamMatchmakingRulesResponse
{
    public VTable m_VTable;    // 0x0x10
    public nint m_pVTable;    // 0x0x18
    public GCHandle m_pGCHandle;    // 0x0x20
    public RulesResponded m_RulesResponded;    // 0x0x28
    public RulesFailedToRespond m_RulesFailedToRespond;    // 0x0x30
    public RulesRefreshComplete m_RulesRefreshComplete;    // 0x0x38
}

// --------------------------------------------------------------------------
// Steamworks.ISteamMatchmakingServerListResponse
//   (not directly referenced by a detected call)
public class ISteamMatchmakingServerListResponse
{
    public VTable m_VTable;    // 0x0x10
    public nint m_pVTable;    // 0x0x18
    public GCHandle m_pGCHandle;    // 0x0x20
    public ServerResponded m_ServerResponded;    // 0x0x28
    public ServerFailedToRespond m_ServerFailedToRespond;    // 0x0x30
    public RefreshComplete m_RefreshComplete;    // 0x0x38
}

// --------------------------------------------------------------------------
// Unity.Burst.EagerCompilationRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class EagerCompilationRequest : ValueType
{
    public string EncodedMethod;    // 0x0x0
    public string Options;    // 0x0x8
}

// ==========================================================================
// SYNTHESIZED request DTOs: no wire body DTO was observed;
// these are built from observed form/query params, wrapper
// params and candidate keys. Field origins: form = POST/PUT
// form field, query = URL query param, wrapper = wrapper
// signature (not observed on wire), candidate = low
// confidence key. Names derive from the route.
// ==========================================================================

// api/CampusCard/v1/UpdateAndGetSubscription  [API POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [API POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public DGINBNBEOAG? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public DGINBNBEOAG DCHDIBLEMPE;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object RoomId;  // candidate
    public object Anonymous;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public ONFDBLENDBL BEGNHHGMJGP;  // wrapper
    public object oldDeviceId;  // candidate
    public object newDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public DDCGHACDAMC ONIHNDBDHGC;  // wrapper
    public int? PMPKJPOGMBN;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v3/create  [API GET]
public class PlayerReportingV3CreateRequest
{
    public object PlayerIdReported;  // candidate
    public object ReportCategory;  // candidate
    public object Details;  // candidate
    public object HeightReporter;  // candidate
    public object HeightReported;  // candidate
}

// api/avatar/v2/gifts/consume/  [API POST]
public class AvatarV2GiftsConsumeRequest
{
    public KGIHHMOBAHF UnlockedLevel;  // wrapper
}

// api/avatar/v2/gifts/generate  [API POST]
public class AvatarV2GiftsGenerateRequest
{
    public LNEIAJDHAHF GCLGODGIPBD;  // wrapper
    public LNEIAJDHAHF? CNLIGIAEOPL;  // wrapper
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object AlternateGiftContext;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [API POST]
public class AvatarV3GiftsGenerateRequest
{
    public LNEIAJDHAHF GCLGODGIPBD;  // wrapper
    public LNEIAJDHAHF? CNLIGIAEOPL;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [API POST]
public class ChallengeV2UpdateProgressRequest
{
    public EDGEDJELLAN FIJEPECLHPP;  // wrapper
    public object UpdateChallengeProgress;  // candidate
    public object ChallengeMapId;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object Complete;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public LGGMHIGBMIG ODCLPPPOKBC;  // wrapper
    public object clubId;  // candidate
    public object reportCategory;  // candidate
    public object details;  // candidate
}

// api/equipment/v1/update  [API POST]
public class EquipmentV1UpdateRequest
{
    public List<KPDPBPJBPMG> LNKECMKBDFG;  // wrapper
}

// api/gamerewards/v1/request  [API POST]
public class GamerewardsV1RequestRequest
{
    public AMGPAHLKELB ADKLOHFMOIN;  // wrapper
    public LNEIAJDHAHF? GALCIJFIANJ;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [API POST]
public class GamerewardsV1SelectRequest
{
    public GGILLMKFEPJ COPEIOENCLN;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/groups/v1/delete/{groupId}  [API POST]
public class GroupsV1DeleteGroupIdRequest
{
    public StatusResponse> HKHGMJEBNHA;  // wrapper
    public object GroupId;  // candidate
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

// api/influencerpartnerprogram/remove  [API POST]
public class InfluencerpartnerprogramRemoveRequest
{
    public int influencerAccountId;  // wrapper
}

// api/influencerpartnerprogram/support  [API POST]
public class InfluencerpartnerprogramSupportRequest
{
    public int influencerAccountId;  // wrapper
}

// api/inventions/v1/fromcreators  [API ?]
public class InventionsV1FromcreatorsRequest
{
    public List<int> id;  // param
}

// api/inventions/v2/batch  [API ?]
public class InventionsV2BatchRequest
{
    public List<long> id;  // param
}

// api/inventions/v2/search  [API GET]
public class InventionsV2SearchRequest
{
    public object skip;  // candidate
    public object take;  // candidate
}

// api/messages/v1/sendMultiple  [API POST]
public class MessagesV1SendMultipleRequest
{
    public List<long> OCKIHCAMGEG;  // wrapper
    public ANAFMIMCJBH LCKMLBAHEMA;  // wrapper
    public long? HEDMMBFEFLM;  // wrapper
    public OJPBJAKOIFL HKHGMJEBNHA;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object SendMessageMultiple;  // candidate
    public object RoomId;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public ANAFMIMCJBH LCKMLBAHEMA;  // wrapper
    public long? HEDMMBFEFLM;  // wrapper
    public OJPBJAKOIFL HKHGMJEBNHA;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/offlineinvite/v1/send  [API POST]
public class OfflineinviteV1SendRequest
{
    public String> HKHGMJEBNHA;  // wrapper
    public object PlayerId;  // candidate
}

// api/playerevents/v2/delete/{gEAMBJBGHEI}  [API POST]
public class PlayereventsV2DeleteGEAMBJBGHEIRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public PCOCIDOGJKN PCFFJLBBFFI;  // wrapper
    public object accessibility;  // candidate
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public long? HCBOCIHFFDC;  // wrapper
    public object clubId;  // candidate
}

// api/playerevents/v2/{eventId}/description  [API PUT]
public class PlayereventsV2EventIdDescriptionRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public object description;  // candidate
}

// api/playerevents/v2/{eventId}/image  [API PUT]
public class PlayereventsV2EventIdImageRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public object imageName;  // candidate
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public GEGPKBEEOJJ LOGCFFDNAOC;  // wrapper
    public GEGPKBEEOJJ IEEPIBFMGEF;  // wrapper
    public object isMultiInstance;  // candidate
    public object supportsMultiInstanceRoomChat;  // candidate
    public object defaultBroadcastPermissions;  // candidate
    public object canRequestBroadcastPermissions;  // candidate
}

// api/playerevents/v2/{eventId}/name  [API PUT]
public class PlayereventsV2EventIdNameRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public object name;  // candidate
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public long? CMJKMEMJJME;  // wrapper
    public object roomId;  // candidate
    public object subRoomId;  // candidate
}

// api/playerevents/v2/{eventId}/tags  [API PUT]
public class PlayereventsV2EventIdTagsRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public List<string> KKHPPBPIBDJ;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public HCMCIMMILFI GEAMBJBGHEI;  // wrapper
    public DateTime JHJHIPOENEE;  // wrapper
    public DateTime OGHKELBCIND;  // wrapper
    public object startTime;  // candidate
    public object endTime;  // candidate
}

// api/roomcurrencies/v1/awardCurrency  [API POST]
public class RoomcurrenciesV1AwardCurrencyRequest
{
    public Guid KDNDOGNCEGH;  // wrapper
    public object CurrencyId;  // candidate
    public object RecipientId;  // candidate
    public object Amount;  // candidate
    public object TransactionId;  // candidate
}

// api/roomcurrencies/v1/awardCurrency/bulk  [API POST]
public class RoomcurrenciesV1AwardCurrencyBulkRequest
{
    public List<JGAGCPPAOGB> AMNFNOKILEF;  // wrapper
}

// api/roomcurrencies/v1/createCurrency  [API POST]
public class RoomcurrenciesV1CreateCurrencyRequest
{
    public object RoomId;  // candidate
    public object Name;  // candidate
    public object Description;  // candidate
    public object Limit;  // candidate
    public object ImageName;  // candidate
}

// api/roomcurrencies/v1/updateCurrency  [API POST]
public class RoomcurrenciesV1UpdateCurrencyRequest
{
    public Guid KDNDOGNCEGH;  // wrapper
    public long? NDLALHMPCOO;  // wrapper
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object Description;  // candidate
    public object Limit;  // candidate
    public object ImageName;  // candidate
}

// api/roomkeys/v1/RoomKeyId  [API PUT]
public class RoomkeysV1RoomKeyIdRequest
{
    public IEnumerable<KeyValuePair<string, string>> FHLPJMHKMFC;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [API POST]
public class RoomkeysV1CreateRequest
{
    public Guid? PBHDLPFNJFN;  // wrapper
    public object RoomId;  // candidate
    public object Name;  // candidate
    public object Description;  // candidate
    public object Price;  // candidate
    public object ImageName;  // candidate
}

// api/rooms/v1/verifyRole  [API POST]
public class RoomsV1VerifyRoleRequest
{
    public object roomId;  // candidate
    public object role;  // candidate
    public object context;  // candidate
}

// api/royale/v2/matchcomplete  [API POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats JADFCECIOBA;  // wrapper
}

// api/screensharereports/v1/report  [API POST]
public class ScreensharereportsV1ReportRequest
{
    public object ImageName;  // candidate
    public object ReportedPlayerId;  // candidate
    public object RoomId;  // candidate
    public object RoomInstanceId;  // candidate
    public object RoomInstanceType;  // candidate
}

// api/storefronts/v1/PurchaseRoomKeyWithCurrency  [API POST]
public class StorefrontsV1PurchaseRoomKeyWithCurrencyRequest
{
    public Guid BGJBMAPOLPH;  // wrapper
    public object RoomKeyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedPurchaseCurrencyId;  // candidate
}

// api/storefronts/v1/objectives  [API POST]
public class StorefrontsV1ObjectivesRequest
{
    public List<LEDNDEBCHEF> PPOENNDGAHL;  // wrapper
    public object objectiveType;  // candidate
    public object completionPercentage;  // candidate
    public object roomId;  // candidate
    public object CompleteObjectives;  // candidate
}

// api/testcasemanagement/v1/testcase/{testcaseId}/status  [API POST]
public class TestcasemanagementV1TestcaseTestcaseIdStatusRequest
{
    public ALCKHCELOOF GHHHIDAJIKA;  // wrapper
}

