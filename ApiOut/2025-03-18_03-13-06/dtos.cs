// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 214 (plus referenced enums)

// --------------------------------------------------------------------------
// ABCNFIGAAGI
// base   : JAOEKBCPPFJ`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.Auth]
public class ABCNFIGAAGI
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// AEJIBDAGMAB
//   REQUEST  POST   api/customAvatarItems   [Service.Auth]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
public class AEJIBDAGMAB
{
    public BHEIPBKAGBE <EGFOOBEDHDF>k__BackingField;    // 0x0x10
    public string <JIKCJOONACL>k__BackingField;    // 0x0x18
    public int? <PNOHBLIKMCA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AHOJJJAFGOL
//   RESPONSE POST   api/inventions/v1/settags   [Service.Auth]
public class AHOJJJAFGOL
{
    public OHGOOCAIHOF <JOEGDIPNKIA>k__BackingField;    // 0x0x10
    public List<string> <KBKFFLLGNIL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AJNLHLFHABD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AJNLHLFHABD
{
    RoomKey = 0,
    RoomConsumable = 1,
    RoomCurrencyPurchaseOffer = 2,
    CustomAvatarItem = 3,
    StoreUGCAvatarItem = 4,
    UNDEFINED = 5,
}

// --------------------------------------------------------------------------
// AMDMOJEJIGJ
//   RESPONSE PUT    api/roomconsumables   [Service.WWW]
public class AMDMOJEJIGJ
{
    public PNGDLIPGKLA <FAJOIMHNFMK>k__BackingField;    // 0x0x10
    public GAODFJNJPEF <JHDBGFKHOOJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// APCLENBKOPG
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class APCLENBKOPG
{
    public Dictionary<Guid, CLMLPGMDJCP> <ABMLHNGLEDK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BBMMOBODAGK
//   (not directly referenced by a detected call)
public class BBMMOBODAGK
{
    public Guid <JPFCPNJJBLO>k__BackingField;    // 0x0x10
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x20
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x28
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x30
    public string <NJPJLDJJHAH>k__BackingField;    // 0x0x38
    public long <GMKCDDDFADJ>k__BackingField;    // 0x0x40
    public Guid? <BHDKFJNGGAK>k__BackingField;    // 0x0x48
    public DateTime <PDBJHGBPPMG>k__BackingField;    // 0x0x60
    public int <MEICBEJAMDN>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// BCPGMNELKBC
//   RESPONSE GET    api/config/v1/backtrace   [Service.Auth]
public class BCPGMNELKBC
{
    public int <PDKLJKAHIDE>k__BackingField;    // 0x0x10
    public int <JNKCLIIAJPK>k__BackingField;    // 0x0x14
    public float <MFNOFEGJKOB>k__BackingField;    // 0x0x18
    public int <EMBMHBKEEAO>k__BackingField;    // 0x0x1C
    public int <AMNJOCCHDKF>k__BackingField;    // 0x0x20
    public int <OIJLKHFFFCF>k__BackingField;    // 0x0x24
    public int <GHDLONLNKNB>k__BackingField;    // 0x0x28
    public string <NPLFIBNKIFA>k__BackingField;    // 0x0x30
    public string <GDCBJFOACCO>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// BEEMKCBDONI
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class BEEMKCBDONI
{
    public Dictionary<Guid, AMDMOJEJIGJ> <LJEFMEHLNIH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BGAANIHBCHM
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class BGAANIHBCHM : ValueType
{
    public DBNNFNBKLPB EKKAALFKEPB;    // 0x0x0
    public KFKBHGMMOEG DAPCMPKCMBG;    // 0x0x10
    public Guid GIFMIPLPHKP;    // 0x0x20
}

// --------------------------------------------------------------------------
// BJMCILGJIBE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BJMCILGJIBE
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
// BKKNAFNGJBF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BKKNAFNGJBF
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
// BLEOGCDNGFN
//   REQUEST  POST   api/equipment/v1/update   [Service.WWW]
public class BLEOGCDNGFN
{
    public string <KNKHLBKAJDC>k__BackingField;    // 0x0x10
    public string <MKHHJHJNHHK>k__BackingField;    // 0x0x18
    public string <HCNCGCIGKBK>k__BackingField;    // 0x0x20
    public string <OCIAFELFOGD>k__BackingField;    // 0x0x28
    public MFFOAHJHDHK <EKMJHNJOHIK>k__BackingField;    // 0x0x30
    public string <MLKAHFGKAPL>k__BackingField;    // 0x0x38
    public bool DMAIDBODJJJ;    // 0x0x40
    public bool <JGJDMFHGPMP>k__BackingField;    // 0x0x41
}

// --------------------------------------------------------------------------
// BLKGGKCACHK
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.WWW]
public class BLKGGKCACHK
{
    public long <CLKHNDFDFGI>k__BackingField;    // 0x0x10
    public int <CGDLAOCOBHK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BMKDIMIIAGM
//   (not directly referenced by a detected call)
public class BMKDIMIIAGM
{
    public float <MLHEJKELDKM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BMNFNIIOBGH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BMNFNIIOBGH
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
// BNKNIIIIHOM
//   (not directly referenced by a detected call)
public class BNKNIIIIHOM
{
    public bool <MEKAGPLAHMB>k__BackingField;    // 0x0x10
    public LFGGHKBPFGJ <GHDGCIAKCEA>k__BackingField;    // 0x0x18
    public float <EEGHEHGHAEJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BOBIMJKOHAM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BOBIMJKOHAM
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
// CJIECHECMFA
// base   : HMCICAICLDG
//   (not directly referenced by a detected call)
public class CJIECHECMFA : HMCICAICLDG
{
    public AJNLHLFHABD BNFAMEGDFLO;    // 0x0x20
}

// --------------------------------------------------------------------------
// CLMLPGMDJCP
//   (not directly referenced by a detected call)
public class CLMLPGMDJCP
{
    public int <NMEMKFEAOPL>k__BackingField;    // 0x0x10
    public DDONEDHGHPI <IJLPHDFIKAG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DADNNCNIKHC
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Auth]
public class DADNNCNIKHC
{
    public Guid <JNDMGNJEOGH>k__BackingField;    // 0x0x10
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x20
    public string <NJPJLDJJHAH>k__BackingField;    // 0x0x28
    public DateTime <BOAMAINMHEK>k__BackingField;    // 0x0x30
    public DateTime? <EHKAPELCODL>k__BackingField;    // 0x0x38
    public List<GKKNGKFOMGE> <MCLFDGDCELA>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// DAMDGNJFOKB
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
public class DAMDGNJFOKB
{
    public List<string> <JEDIAHONBHC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DBNNFNBKLPB
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class DBNNFNBKLPB : ValueType
{
    public Guid FGPNICIMMFP;    // 0x0x0
}

// --------------------------------------------------------------------------
// DCNHJBPLMDG
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class DCNHJBPLMDG
{
    public DDONEDHGHPI <IJLPHDFIKAG>k__BackingField;    // 0x0x10
    public IKKCOIFKNOH <OIJKPIHMPCH>k__BackingField;    // 0x0x18
    public int <NMEMKFEAOPL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DCODEHLOKDO
//   RESPONSE GET    api/testcasemanagement/   [Service.Auth]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{jDNOHHGIHEO}   [Service.Auth]
public class DCODEHLOKDO
{
    public uint <KKEIFFNAPMC>k__BackingField;    // 0x0x10
    public uint? <BLJFPDAGLKD>k__BackingField;    // 0x0x14
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x20
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x28
    public DateTime <IKNIHOKKJAN>k__BackingField;    // 0x0x30
    public DateTime? <LNFCEIOPNIP>k__BackingField;    // 0x0x38
    public bool <IGDPKCBONKM>k__BackingField;    // 0x0x48
    public List<GHIPDNIFJIA> <APNCEBBFPLG>k__BackingField;    // 0x0x50
    public List<string> <KBKFFLLGNIL>k__BackingField;    // 0x0x58
    public int <IBHCHJNPBFN>k__BackingField;    // 0x0x60
    public int <CJJDBDKDGMA>k__BackingField;    // 0x0x64
    public int <KHHIBEGGEOC>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// DDONEDHGHPI
//   REQUEST  PUT    api/roomconsumables   [Service.WWW]
public class DDONEDHGHPI
{
    public Guid? <OHEMCKOGGKP>k__BackingField;    // 0x0x10
    public Guid <OBCJJFHFNHG>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// DHECDODLICK
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.WWW]
public class DHECDODLICK
{
    public long <CLKHNDFDFGI>k__BackingField;    // 0x0x10
    public int <CGDLAOCOBHK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DHKIOBCBPGF
//   REQUEST  POST   api/roomcurrencies   [Service.WWW]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.WWW]
public class DHKIOBCBPGF
{
    public Guid <AMPKBEOCHLK>k__BackingField;    // 0x0x10
    public long <FABAHCODLJE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DIHNAEHDOMN
//   REQUEST  POST   api/playerevents/v1/respond   [Service.Auth]
public class DIHNAEHDOMN
{
    public long <LJABGCJOOAA>k__BackingField;    // 0x0x10
    public MHAEBOLDCCO <BCLMFLFBLHA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DINOAJOKBHF
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/checklist/v1/complete   [Service.WWW]
//   RESPONSE POST   api/progressionEvents   [Service.Auth]
//   RESPONSE POST   api/progressionEvents/collect/{eDDDPIOCLPG}/{lBCEFBHICOG}   [Service.Auth]
public class DINOAJOKBHF
{
    public long? <KKEIFFNAPMC>k__BackingField;    // 0x0x10
    public int <HMEHJPMBOIF>k__BackingField;    // 0x0x20
    public int? <LNILGKLCNJI>k__BackingField;    // 0x0x24
    public string <JKMCMLPANCP>k__BackingField;    // 0x0x30
    public IOGCBHHMBAD? <MDFLMIOFHAD>k__BackingField;    // 0x0x38
    public string <LAEHEIBFNMC>k__BackingField;    // 0x0x40
    public Guid? <AAMNKKGHKGP>k__BackingField;    // 0x0x48
    public string <HLCHAPHDEKB>k__BackingField;    // 0x0x60
    public string <HJDAGDGBDGM>k__BackingField;    // 0x0x68
    public BOBIMJKOHAM <EOANHLDMMOA>k__BackingField;    // 0x0x70
    public int <BPMJMBCBCDC>k__BackingField;    // 0x0x74
    public int <EKPDICPOOCE>k__BackingField;    // 0x0x78
    public BJMCILGJIBE <NOGHJPBHDCE>k__BackingField;    // 0x0x7C
    public MFFOAHJHDHK <LMKBDJNEINK>k__BackingField;    // 0x0x80
    public string <LPEBNOFKLGG>k__BackingField;    // 0x0x88
    public ICLCGPHPAPG <FBJAMLCOEKH>k__BackingField;    // 0x0x90
    public OKEMGKIMBMH <EGMKKGKEMAO>k__BackingField;    // 0x0x94
    public EBACFOPCMGA? <OGDKEFDDBDF>k__BackingField;    // 0x0x98
    public bool <ICMJLBMMDEB>k__BackingField;    // 0x0xA0
    public bool <GHKJNBALGAB>k__BackingField;    // 0x0xA1
    public string <OODIACFKHBC>k__BackingField;    // 0x0xA8
    public bool <IBPFHNKNBOD>k__BackingField;    // 0x0xB0
    public bool HLLEGALLDLB;    // 0x0xB1
}

// --------------------------------------------------------------------------
// DLNNFNMELPJ
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.WWW]
public class DLNNFNMELPJ
{
    public int <BLIJJGHMGPF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DMCECJNMIJB
//   (not directly referenced by a detected call)
public class DMCECJNMIJB
{
    public bool <LCLAJGBNFGA>k__BackingField;    // 0x0x10
    public OKEMGKIMBMH <HJNMMAFLPDE>k__BackingField;    // 0x0x14
    public int <DEPKDDIKBDJ>k__BackingField;    // 0x0x18
    public DateTime <PDBJHGBPPMG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DMJFLMAMLFI
//   RESPONSE DELETE api/roomconsumables   [Service.WWW]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{pBNPLDOFKHF}   [Service.WWW]
public class DMJFLMAMLFI
{
    public PNGDLIPGKLA <FAJOIMHNFMK>k__BackingField;    // 0x0x10
    public BBMMOBODAGK <LHCDGJPCAPI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DMJOKACKJMA
// base   : JANFMCKCFJC
//   (not directly referenced by a detected call)
public class DMJOKACKJMA : JANFMCKCFJC
{
    public int <KICOEGFFBNM>k__BackingField;    // 0x0x68
    public List<BNKNIIIIHOM> <EAJAHHIGIKF>k__BackingField;    // 0x0x70
    public List<BNKNIIIIHOM> <AEKMJIPICFI>k__BackingField;    // 0x0x78
    public List<BNKNIIIIHOM> <ALABBFJJMON>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// DPLBBGIKCDA
//   (not directly referenced by a detected call)
public class DPLBBGIKCDA
{
    public string <FMIKNDCAJLI>k__BackingField;    // 0x0x10
    public FCGBLAFEBDM <BCLMFLFBLHA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DPMHOHNMJDM
//   REQUEST  POST   api/items/bulkpurchase   [Service.Commerce]
public class DPMHOHNMJDM
{
    public List<KADHPLFJEAG> <KCNJOJHFAED>k__BackingField;    // 0x0x10
    public JOJCOALEHPO? <DPGBEMLJGKF>k__BackingField;    // 0x0x18
    public BOBIMJKOHAM <EOANHLDMMOA>k__BackingField;    // 0x0x20
    public bool <JMKPBIBNIPK>k__BackingField;    // 0x0x24
    public bool <CMKABPNGINA>k__BackingField;    // 0x0x25
}

// --------------------------------------------------------------------------
// DPNCGLFADLG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DPNCGLFADLG
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// EBACFOPCMGA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EBACFOPCMGA
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
// EFMKNDBMONL
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.WWW]
public class EFMKNDBMONL
{
    public int <CGDLAOCOBHK>k__BackingField;    // 0x0x10
    public Guid <ECJHBOLEOOB>k__BackingField;    // 0x0x14
    public long <AGFPKBCDLIC>k__BackingField;    // 0x0x28
    public DateTime <PDBJHGBPPMG>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// EJFNJHGFONM
//   (not directly referenced by a detected call)
public class EJFNJHGFONM
{
    public DateTime <BDJMKHDLFJN>k__BackingField;    // 0x0x10
    public string <CNGMFDBANPP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EOMDACGOFLE
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.WWW]
public class EOMDACGOFLE
{
    public Guid <ECJHBOLEOOB>k__BackingField;    // 0x0x10
    public int <EDCDJHCMFNJ>k__BackingField;    // 0x0x20
    public long <LPJDGJCBIMH>k__BackingField;    // 0x0x28
    public Guid <AMPKBEOCHLK>k__BackingField;    // 0x0x30
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
// FALPLBKDECG
//   RESPONSE GET    api/config/v1/azurespeech   [Service.Auth]
public class FALPLBKDECG
{
    public bool <EKMMCOKNEME>k__BackingField;    // 0x0x10
    public string <JBLOCNFKBAD>k__BackingField;    // 0x0x18
    public string <GNPLACBPJNL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FCGBLAFEBDM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FCGBLAFEBDM
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// FCODALDPHAJ
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class FCODALDPHAJ
{
    public List<GMNEEADHOKC> <LGELPBCKIHM>k__BackingField;    // 0x0x10
    public BMNFNIIOBGH <JOEGDIPNKIA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FFGKPBGJOGC
//   REQUEST  POST   api/items/purchaseInfos   [Service.WWW]
public class FFGKPBGJOGC
{
    public IReadOnlyList<CJIECHECMFA> <EGBDIOJEGGP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GAODFJNJPEF
//   (not directly referenced by a detected call)
public class GAODFJNJPEF
{
    public Guid <JPFCPNJJBLO>k__BackingField;    // 0x0x10
    public int <CGDLAOCOBHK>k__BackingField;    // 0x0x20
    public int <MLMLLBJIDDK>k__BackingField;    // 0x0x24
    public Guid <GAHMGKIINLK>k__BackingField;    // 0x0x28
    public DateTime <PDBJHGBPPMG>k__BackingField;    // 0x0x38
    public BBMMOBODAGK <LHCDGJPCAPI>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// GDDCHMNKMCA
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class GDDCHMNKMCA
{
    public long <LJABGCJOOAA>k__BackingField;    // 0x0x10
    public int <IDPLCODMAAC>k__BackingField;    // 0x0x18
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x20
    public long? <CCHBBGMEHAH>k__BackingField;    // 0x0x28
    public long? <JPGBCHAFMFF>k__BackingField;    // 0x0x38
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x48
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x50
    public string <NJPJLDJJHAH>k__BackingField;    // 0x0x58
    public DateTime <PKMOIBEMGGG>k__BackingField;    // 0x0x60
    public DateTime <KJOOAKEIKKJ>k__BackingField;    // 0x0x68
    public int <ALCDAMKPPCH>k__BackingField;    // 0x0x70
    public PCFHGMELLAO <INMAOOMCHMP>k__BackingField;    // 0x0x74
    public bool <ONEMKOELEKH>k__BackingField;    // 0x0x78
    public bool <MKKABJAKGEF>k__BackingField;    // 0x0x79
    public NOOHIKMHEAO <EJPBFGMAIKJ>k__BackingField;    // 0x0x7C
    public NOOHIKMHEAO <KHAJBBEKLPL>k__BackingField;    // 0x0x80
    public long? <CCECGGHAGKN>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// GDELDDEDLLB
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v1/modKick   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.Auth]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.Auth]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.Auth]
//   RESPONSE POST   api/inventions/v1/report   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/report   [Service.Auth]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.Auth]
//   RESPONSE POST   api/rooms/v2/report   [Service.Auth]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.Auth]
public class GDELDDEDLLB
{
    public bool <IPNENEDBEAJ>k__BackingField;    // 0x0x10
    public string <JDJHNLFNBDK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GGFFDFDIDLN
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.WWW]
public class GGFFDFDIDLN
{
    public int PDJACGCKONA;    // 0x0x10
    public long FEGGOIBIHDD;    // 0x0x18
}

// --------------------------------------------------------------------------
// GHIPDNIFJIA
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.Auth]
public class GHIPDNIFJIA
{
    public string <KKEIFFNAPMC>k__BackingField;    // 0x0x10
    public string <JBLOCNFKBAD>k__BackingField;    // 0x0x18
    public string <OIDJNDNCBJC>k__BackingField;    // 0x0x20
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x28
    public string <BOIOJLCBEHD>k__BackingField;    // 0x0x30
    public LEPEGIGGLOC <FAJOIMHNFMK>k__BackingField;    // 0x0x38
    public List<string> <PJBBMBCKOGN>k__BackingField;    // 0x0x40
    public List<string> <KBKFFLLGNIL>k__BackingField;    // 0x0x48
    public string <GOEAPMPKMMF>k__BackingField;    // 0x0x50
    public List<EJFNJHGFONM> <NHKNFAKPDOI>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// GKKNGKFOMGE
//   (not directly referenced by a detected call)
public class GKKNGKFOMGE
{
    public Guid <BBGAJCLAGBG>k__BackingField;    // 0x0x10
    public Guid <ELFKNGJBCEB>k__BackingField;    // 0x0x20
    public DateTime <BOAMAINMHEK>k__BackingField;    // 0x0x30
    public List<LFGGHKBPFGJ> <GOGCFAEIBIH>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// GKPIBFJCIJG
//   (not directly referenced by a detected call)
public class GKPIBFJCIJG
{
    public int <AJBMDFHKAGE>k__BackingField;    // 0x0x10
    public DateTime <EAFJMFJKDBB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GLFKJIAJPLH
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.WWW]
public class GLFKJIAJPLH
{
    public List<JEHHMGAJDPB> <KLPGIKCIKOJ>k__BackingField;    // 0x0x10
    public string <HOGOLLLKHLI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GMNEEADHOKC
//   (not directly referenced by a detected call)
public class GMNEEADHOKC
{
    public int <NMPPCBKCMEM>k__BackingField;    // 0x0x10
    public BMNFNIIOBGH <JOEGDIPNKIA>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// HHDLEBOMOEA
//   REQUEST  PUT    api/customAvatarItems   [Service.Auth]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
public class HHDLEBOMOEA
{
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x10
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x18
    public int? <GMKCDDDFADJ>k__BackingField;    // 0x0x20
    public NHEBJNLJFEG? <INMAOOMCHMP>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// HIFOHGPGCGO
//   RESPONSE GET    api/playerevents/v1/all   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/all/{gMGPDOAAFEJ}   [Service.Auth]
public class HIFOHGPGCGO
{
    public List<GDDCHMNKMCA> <AFIAFCKLEFK>k__BackingField;    // 0x0x10
    public List<OHNBBGBFHHC> <NELCEBMIFMH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HMIPCLGJIEM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HMIPCLGJIEM
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// HNHNCPOBJEJ
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.WWW]
public class HNHNCPOBJEJ
{
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <IHCCAOMAFJF>k__BackingField;    // 0x0x18
    public HMIPCLGJIEM <FCOFLPAJJKH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HOJHKHBJDIP
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.WWW]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.WWW]
public class HOJHKHBJDIP
{
    public int <GKNFBKGMFDE>k__BackingField;    // 0x0x10
    public int <LOBLKFBPGIP>k__BackingField;    // 0x0x14
    public float <DFLKJIKCBAN>k__BackingField;    // 0x0x18
    public float <BMAPCCJLCKG>k__BackingField;    // 0x0x1C
    public bool <KHMLOLNKMIO>k__BackingField;    // 0x0x20
    public bool <PLNFECEPFAB>k__BackingField;    // 0x0x21
    public bool <JGJDMFHGPMP>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// ICCCIINPGDF
// base   : GDDCHMNKMCA
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class ICCCIINPGDF : GDDCHMNKMCA
{
    public List<DPLBBGIKCDA> <KBKFFLLGNIL>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// ICLCGPHPAPG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ICLCGPHPAPG
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
// IKKCOIFKNOH
//   (not directly referenced by a detected call)
public class IKKCOIFKNOH
{
    public long <GMKCDDDFADJ>k__BackingField;    // 0x0x10
    public Guid? <ECJHBOLEOOB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ILGGPAOPAJM
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.Auth]
//   RESPONSE POST   api/relationships/v2/updateVoiceVolume   [Service.Auth]
public class ILGGPAOPAJM
{
    public int <IGIENJJIFPD>k__BackingField;    // 0x0x10
    public FIPIABMAGAK <BCLMFLFBLHA>k__BackingField;    // 0x0x14
    public EIGENLFJGDI <OIICDOJDAPO>k__BackingField;    // 0x0x18
    public EIGENLFJGDI <IJMHAKGAKGF>k__BackingField;    // 0x0x1C
    public EIGENLFJGDI <JOMCCCPHOLL>k__BackingField;    // 0x0x20
    public byte? <MKKHGNHPNJC>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// IMEKLFJGHJK
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
public class IMEKLFJGHJK
{
    public Guid? <JPFCPNJJBLO>k__BackingField;    // 0x0x10
    public long? <IBKJLBGFPBN>k__BackingField;    // 0x0x28
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x38
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x40
    public string <NJPJLDJJHAH>k__BackingField;    // 0x0x48
    public IKKCOIFKNOH <JNEEPDDDALK>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// IOGCBHHMBAD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IOGCBHHMBAD
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// JAHBGKLIIEK
//   RESPONSE GET    api/inventions/v1/details   [Service.Auth]
public class JAHBGKLIIEK
{
    public List<DPLBBGIKCDA> <KBKFFLLGNIL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JANFMCKCFJC
//   (not directly referenced by a detected call)
public class JANFMCKCFJC
{
    public int <OFHACFDEBAF>k__BackingField;    // 0x0x10
    public MOJGMECBALE <BCLMFLFBLHA>k__BackingField;    // 0x0x14
    public List<KBHFLDIFNNP> <DLFHCJKHAPK>k__BackingField;    // 0x0x18
    public List<KBHFLDIFNNP> <DIIAPAPOMMH>k__BackingField;    // 0x0x20
    public bool <CDCLIDBIHKG>k__BackingField;    // 0x0x28
    public DateTime? <MJAPCPPJNND>k__BackingField;    // 0x0x30
    public DateTime? <EIMLFPFLKON>k__BackingField;    // 0x0x40
    public DateTime? <GDDCGINLGLL>k__BackingField;    // 0x0x50
    public bool <BONPICPCJPD>k__BackingField;    // 0x0x60
    public bool <CJINOAJBEOE>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// JEHHMGAJDPB
//   (not directly referenced by a detected call)
public class JEHHMGAJDPB
{
    public int <BDHFFGMGMHJ>k__BackingField;    // 0x0x10
    public DateTime <BDJMKHDLFJN>k__BackingField;    // 0x0x18
    public DateTime? <EOCACCINBHG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JIMAGGGPMGI
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.Auth]
public class JIMAGGGPMGI
{
    public List<long> <JEABHCOIBJE>k__BackingField;    // 0x0x10
    public OBJIHOOAMCJ <BCLMFLFBLHA>k__BackingField;    // 0x0x18
    public string <FOEGIDCAAAD>k__BackingField;    // 0x0x20
    public long? <IBKJLBGFPBN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// JMLDCBAIGNL
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.Auth]
public class JMLDCBAIGNL
{
    public List<GDDCHMNKMCA> <DDEDPNIPHHL>k__BackingField;    // 0x0x10
    public string <HOGOLLLKHLI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JOJCOALEHPO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JOJCOALEHPO
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
// KADHPLFJEAG
//   (not directly referenced by a detected call)
public class KADHPLFJEAG
{
    public NEGOLKNHFMA <HPADGCEDLDD>k__BackingField;    // 0x0x10
    public long <PGLGHJAAAKE>k__BackingField;    // 0x0x18
    public GiftItemDTO <PAILIPCDAPE>k__BackingField;    // 0x0x20
    public long? <JJMDOHHAOME>k__BackingField;    // 0x0x28
    public int <CEJIIFLCBBA>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// KBENEKOBJIB
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.Auth]
public class KBENEKOBJIB
{
    public int <KHPEKDBKOLL>k__BackingField;    // 0x0x10
    public int? <PCDNNGFJOJF>k__BackingField;    // 0x0x14
    public string <LHPANBHINHF>k__BackingField;    // 0x0x20
    public string <KKLGCDMNPMN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// KBHFLDIFNNP
//   (not directly referenced by a detected call)
public class KBHFLDIFNNP
{
    public BOBIMJKOHAM <EOANHLDMMOA>k__BackingField;    // 0x0x10
    public int <GMKCDDDFADJ>k__BackingField;    // 0x0x14
    public NKIBDNENBDF <JDFPFLLLFAA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KFKBHGMMOEG
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class KFKBHGMMOEG : ValueType
{
    public Guid FGPNICIMMFP;    // 0x0x0
}

// --------------------------------------------------------------------------
// KNBANEPLLFP
//   (not directly referenced by a detected call)
public class KNBANEPLLFP
{
    public long <CLKHNDFDFGI>k__BackingField;    // 0x0x10
    public Guid <ENGJACPGDLL>k__BackingField;    // 0x0x18
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x28
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x30
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x38
    public int <GMKCDDDFADJ>k__BackingField;    // 0x0x40
    public Guid? <BHDKFJNGGAK>k__BackingField;    // 0x0x44
    public DateTime <BDJMKHDLFJN>k__BackingField;    // 0x0x58
    public string <NJPJLDJJHAH>k__BackingField;    // 0x0x60
    public MOJIEODGIGC <BCLMFLFBLHA>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// KPBLHPLNNOA
// base   : OMKLDILHDPD
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/season/{iHNLJACAGEM}   [Service.WWW]
public class KPBLHPLNNOA : OMKLDILHDPD
{
    public int <BPNICNNMDJC>k__BackingField;    // 0x0x30
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x38
    public DateTime <BOAMAINMHEK>k__BackingField;    // 0x0x40
    public DateTime <NOENOEIEIHM>k__BackingField;    // 0x0x48
    public BOBIMJKOHAM <EOANHLDMMOA>k__BackingField;    // 0x0x50
    public JANFMCKCFJC <JALBLAAGFKM>k__BackingField;    // 0x0x58
    public List<DMJOKACKJMA> <ECADOOAKEDF>k__BackingField;    // 0x0x60
    public DMCECJNMIJB <IGNGBHJAOGL>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// LEPEGIGGLOC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LEPEGIGGLOC
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// LFGGHKBPFGJ
//   (not directly referenced by a detected call)
public class LFGGHKBPFGJ
{
    public int <ENONCJEIANL>k__BackingField;    // 0x0x10
    public string <HCNCGCIGKBK>k__BackingField;    // 0x0x18
    public string <OCIAFELFOGD>k__BackingField;    // 0x0x20
    public string <HCPCOPPNBBM>k__BackingField;    // 0x0x28
    public string <JKMCMLPANCP>k__BackingField;    // 0x0x30
    public BGAANIHBCHM? <EPPLOBKEOHI>k__BackingField;    // 0x0x38
    public string <LAEHEIBFNMC>k__BackingField;    // 0x0x70
    public Guid? <AAMNKKGHKGP>k__BackingField;    // 0x0x78
    public IOGCBHHMBAD? <MDFLMIOFHAD>k__BackingField;    // 0x0x8C
    public string <HLCHAPHDEKB>k__BackingField;    // 0x0x98
    public string <HJDAGDGBDGM>k__BackingField;    // 0x0xA0
    public bool <DMDFGAKIJJA>k__BackingField;    // 0x0xA8
    public bool <EGLGCGPBCAA>k__BackingField;    // 0x0xA9
    public bool <CPOMCAAPIJB>k__BackingField;    // 0x0xAA
    public MFFOAHJHDHK <EKMJHNJOHIK>k__BackingField;    // 0x0xAC
    public BOBIMJKOHAM <EOANHLDMMOA>k__BackingField;    // 0x0xB0
    public int <BPMJMBCBCDC>k__BackingField;    // 0x0xB4
    public OPHJOLIIEGC <GAPECEJIHFD>k__BackingField;    // 0x0xB8
    public BJMCILGJIBE <NEHCMLNMILC>k__BackingField;    // 0x0xBC
    public int? <PGBLIKEKIMG>k__BackingField;    // 0x0xC0
    public string <CGAMHFCMJIB>k__BackingField;    // 0x0xC8
    public int? <LNGBEFOEOEM>k__BackingField;    // 0x0xD0
    public int? <LEEMIAAGKJO>k__BackingField;    // 0x0xD8
    public string <MLKAHFGKAPL>k__BackingField;    // 0x0xE0
}

// --------------------------------------------------------------------------
// LIBIHEHLFOM
//   (not directly referenced by a detected call)
public class LIBIHEHLFOM
{
    public float <LJKEBHJDENF>k__BackingField;    // 0x0x10
    public float <DDIIEOFNCHD>k__BackingField;    // 0x0x14
    public float <GHADMHHGIBH>k__BackingField;    // 0x0x18
    public float <COGNFAFLJPJ>k__BackingField;    // 0x0x1C
    public float <HKCNFONAJHI>k__BackingField;    // 0x0x20
    public float <GDKCBDOADHP>k__BackingField;    // 0x0x24
    public float <NNKHHPGNIHE>k__BackingField;    // 0x0x28
    public float <KNAMOJHDBEF>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// LKNMCGOFNMB
//   REQUEST  POST   api/playerevents/v1/report   [Service.Auth]
public class LKNMCGOFNMB
{
    public HFPNMKANCJC <EGFOOBEDHDF>k__BackingField;    // 0x0x10
    public long <LJABGCJOOAA>k__BackingField;    // 0x0x18
    public string <JIKCJOONACL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LNONMJIBFOO
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.Auth]
public class LNONMJIBFOO
{
    public BMNFNIIOBGH <JOEGDIPNKIA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LOKADMBNGIN
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{mFDPCLOJDHA}/{mHODPPADGGI}   [Service.WWW]
public class LOKADMBNGIN
{
    public BOBIMJKOHAM <EOANHLDMMOA>k__BackingField;    // 0x0x10
    public MLMGPNCFLKK <DBKGDOOCNFH>k__BackingField;    // 0x0x14
    public int <NDHBPEKGEJG>k__BackingField;    // 0x0x18
    public int <NIGPGFPJKLM>k__BackingField;    // 0x0x1C
    public int <PFCEICMFIEL>k__BackingField;    // 0x0x20
    public DPNCGLFADLG <ALCCKGKNKJC>k__BackingField;    // 0x0x24
    public bool <EBOOJBAPDHK>k__BackingField;    // 0x0x28
    public float <NMLHEBOLLAG>k__BackingField;    // 0x0x2C
    public int <FPDCIHBAGCD>k__BackingField;    // 0x0x30
    public bool <HOCHPBMPIDG>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// MBOLBFFHHFL
//   (not directly referenced by a detected call)
public class MBOLBFFHHFL
{
    public int <FIDDFFOPCCB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MCOPHFDFDOP
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.Auth]
public class MCOPHFDFDOP
{
    public HFPNMKANCJC <EGFOOBEDHDF>k__BackingField;    // 0x0x10
    public int <BLIJJGHMGPF>k__BackingField;    // 0x0x14
    public long <OMNICHBKLEF>k__BackingField;    // 0x0x18
    public bool <LAFAMNKPNLL>k__BackingField;    // 0x0x20
    public string <JDJHNLFNBDK>k__BackingField;    // 0x0x28
    public int? <KNJCNPPBNPF>k__BackingField;    // 0x0x30
    public bool <HDBOJKDDNBH>k__BackingField;    // 0x0x38
    public bool <JLNOCDGHOIK>k__BackingField;    // 0x0x39
    public bool <HPGGGIHCGMJ>k__BackingField;    // 0x0x3A
    public bool <DBKLBOFAGGP>k__BackingField;    // 0x0x3B
    public string <BCNPNBMEAPB>k__BackingField;    // 0x0x40
    public DateTime? <FNNLDGCMFFD>k__BackingField;    // 0x0x48
    public string <GHBNBAEBMCN>k__BackingField;    // 0x0x58
    public float <MLMOCDAPNOA>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// MDECNBIJKKE
//   RESPONSE GET    api/config/v2   [Service.Auth]
public class MDECNBIJKKE
{
    public Dictionary<int, int> <JOJIJCHBMOB>k__BackingField;    // 0x0x10
    public List<OBKLNJJDBLG> <DOBHPIMAOCD>k__BackingField;    // 0x0x18
    public PODKCNLOOAL[][] <JPGLEPNDMFJ>k__BackingField;    // 0x0x20
    public MBOLBFFHHFL <IAHKLGFCEMH>k__BackingField;    // 0x0x28
    public LIBIHEHLFOM <NDNEKJBKBKF>k__BackingField;    // 0x0x30
    public GKPIBFJCIJG <DGMKOIAHKKJ>k__BackingField;    // 0x0x38
    public ODFHFPIBFKN <ALDAIKIAMKC>k__BackingField;    // 0x0x40
    public BMKDIMIIAGM <MHGJJBPHEMN>k__BackingField;    // 0x0x48
    public string <CFLKOHANIKB>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// MFFOAHJHDHK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MFFOAHJHDHK
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// MHAEBOLDCCO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MHAEBOLDCCO
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// MJEIJOONCMD
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.Auth]
public class MJEIJOONCMD
{
    public List<string> <COPPMJHNPNL>k__BackingField;    // 0x0x10
    public List<string> <BLDPPKOBNGE>k__BackingField;    // 0x0x18
    public List<string> <ONNOOODMGHI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MLMGPNCFLKK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MLMGPNCFLKK
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
// MMKCGPGIILA
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.WWW]
public class MMKCGPGIILA
{
    public List<int> <PMCJNFKPFGG>k__BackingField;    // 0x0x10
    public string <HOGOLLLKHLI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MOJGMECBALE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MOJGMECBALE
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// MOJIEODGIGC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MOJIEODGIGC
{
    Key = 0,
    CircuitEventKey = 1,
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
// NAALDEHGLCH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NAALDEHGLCH
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
// NEGOLKNHFMA
//   (not directly referenced by a detected call)
public class NEGOLKNHFMA
{
    public NNBDCFGLAJE <BCLMFLFBLHA>k__BackingField;    // 0x0x10
    public int? <FKCIBOBACEG>k__BackingField;    // 0x0x14
    public Guid? <FIDMOIGBGEA>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// NHEBJNLJFEG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NHEBJNLJFEG
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// NKIBDNENBDF
//   (not directly referenced by a detected call)
public class NKIBDNENBDF
{
    public int <MKIFDOCBJBG>k__BackingField;    // 0x0x10
    public DateTime? <BIBONJJOJEB>k__BackingField;    // 0x0x18
    public DateTime? <FPDFAHMBOLJ>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// NLLCECEDBKB
//   RESPONSE POST   api/chatreport/createChatReport   [Service.Auth]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.WWW]
//   RESPONSE POST   api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.Auth]
//   RESPONSE PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/v1/{dLBJLJBGNMD}/appeal   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.Auth]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.WWW]
//   RESPONSE POST   api/images/v2/modifyaccessibility   [Service.Auth]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.WWW]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.WWW]
//   RESPONSE DELETE api/keepsakes   [Service.Auth]
//   RESPONSE DELETE api/keepsakes/{mDCODEADBDH}   [Service.Auth]
//   RESPONSE POST   api/playerwarnings   [Service.Auth]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.Auth]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.WWW]
public class NLLCECEDBKB
{
    public bool <IPNENEDBEAJ>k__BackingField;    // 0x0x10
    public string <HHBBGLKPPFI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NNBDCFGLAJE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NNBDCFGLAJE
{
    PurchasableItem = 0,
    CustomAvatarItem = 1,
}

// --------------------------------------------------------------------------
// NOOHIKMHEAO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NOOHIKMHEAO
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// NPKBBHLKDPF
// base   : JAOEKBCPPFJ`1<LGFILEBPNEG>
//   RESPONSE GET    api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{hGEJODBPMHJ}   [Service.Auth]
public class NPKBBHLKDPF
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// OANPIPKBOEB
//   REQUEST  POST   api/relationships/v2/updateVoiceVolume   [Service.Auth]
public class OANPIPKBOEB
{
    public int <HMEHJPMBOIF>k__BackingField;    // 0x0x10
    public byte <MKKHGNHPNJC>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// ODFHFPIBFKN
//   (not directly referenced by a detected call)
public class ODFHFPIBFKN
{
    public int <HCOMKIJGOGH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OGGECKHAPPO
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2/delete/{eventId}   [Service.Auth]
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
public class OGGECKHAPPO
{
    public ICCCIINPGDF <EGKCBIAEFLA>k__BackingField;    // 0x0x10
    public BMNFNIIOBGH <JOEGDIPNKIA>k__BackingField;    // 0x0x18
    public AHOJJJAFGOL <GKIGDOFNHAD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OGMGNJELEBB
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.Auth]
public class OGMGNJELEBB
{
    public int? <KOOEBBKHBOB>k__BackingField;    // 0x0x10
    public string <BOIOJLCBEHD>k__BackingField;    // 0x0x18
    public string <DAFFFGAFECJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OHBFFDFNGHK
//   REQUEST  POST   api/playerevents/v2   [Service.Auth]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.Auth]
public class OHBFFDFNGHK
{
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x10
    public long? <CCHBBGMEHAH>k__BackingField;    // 0x0x18
    public long? <JPGBCHAFMFF>k__BackingField;    // 0x0x28
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x38
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x40
    public List<string> <KBKFFLLGNIL>k__BackingField;    // 0x0x48
    public string <NJPJLDJJHAH>k__BackingField;    // 0x0x50
    public DateTime <PKMOIBEMGGG>k__BackingField;    // 0x0x58
    public DateTime <KJOOAKEIKKJ>k__BackingField;    // 0x0x60
    public PCFHGMELLAO <INMAOOMCHMP>k__BackingField;    // 0x0x68
    public bool <ONEMKOELEKH>k__BackingField;    // 0x0x6C
    public bool <MKKABJAKGEF>k__BackingField;    // 0x0x6D
    public NOOHIKMHEAO <EJPBFGMAIKJ>k__BackingField;    // 0x0x70
    public NOOHIKMHEAO <KHAJBBEKLPL>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// OHGOOCAIHOF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OHGOOCAIHOF
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
// OHNBBGBFHHC
//   (not directly referenced by a detected call)
public class OHNBBGBFHHC
{
    public GDDCHMNKMCA <EGKCBIAEFLA>k__BackingField;    // 0x0x10
    public PBCNNHPOONI <KICPJMNODGA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OKEMGKIMBMH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OKEMGKIMBMH
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
// OPHJOLIIEGC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OPHJOLIIEGC
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
// PBANBBAAELC
//   RESPONSE PUT    api/roomkeys/v1/   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class PBANBBAAELC
{
    public RoomKeyResult <FAJOIMHNFMK>k__BackingField;    // 0x0x10
    public KNBANEPLLFP <KLCHPEDPNBE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PBCNNHPOONI
//   (not directly referenced by a detected call)
public class PBCNNHPOONI
{
    public long <CGIEFGJMINI>k__BackingField;    // 0x0x10
    public long <LJABGCJOOAA>k__BackingField;    // 0x0x18
    public int <HMEHJPMBOIF>k__BackingField;    // 0x0x20
    public DateTime <BDJMKHDLFJN>k__BackingField;    // 0x0x28
    public MHAEBOLDCCO <BCLMFLFBLHA>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// PCFHGMELLAO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PCFHGMELLAO
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// PCICKPGDKHM
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.WWW]
public class PCICKPGDKHM
{
    public int <LOBLKFBPGIP>k__BackingField;    // 0x0x10
    public bool <KHMLOLNKMIO>k__BackingField;    // 0x0x14
    public DateTime <MPJGOKPIDKK>k__BackingField;    // 0x0x18
    public bool <JLOHPLDNJBP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PEOCDPJGHGC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PEOCDPJGHGC
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// PFDGHJNLIIL
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.WWW]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
//   RESPONSE GET    api/avatar/v4/items   [Service.WWW]
public class PFDGHJNLIIL
{
    public IOGCBHHMBAD <MDFLMIOFHAD>k__BackingField;    // 0x0x10
    public string <DGLGEDKKFCG>k__BackingField;    // 0x0x18
    public string <HCNCGCIGKBK>k__BackingField;    // 0x0x20
    public string <OCIAFELFOGD>k__BackingField;    // 0x0x28
    public MFFOAHJHDHK <EKMJHNJOHIK>k__BackingField;    // 0x0x30
    public string <HCPCOPPNBBM>k__BackingField;    // 0x0x38
    public int <LNGBEFOEOEM>k__BackingField;    // 0x0x40
    public bool <IJMAPBBLKIC>k__BackingField;    // 0x0x44
    public string <EKNPMFFIMOB>k__BackingField;    // 0x0x48
    public DateTime <BDJMKHDLFJN>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// PKAEBEMOLKI
// base   : CAGFIDLHCLO
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class PKAEBEMOLKI : CAGFIDLHCLO
{
    public BKKNAFNGJBF? <JHKAKLIHDOE>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <LHABOFLGMJC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PKKBKMBGECL
// base   : CAGFIDLHCLO
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class PKKBKMBGECL : CAGFIDLHCLO
{
    public PEOCDPJGHGC? <JHKAKLIHDOE>k__BackingField;    // 0x0x18
    public EFMKNDBMONL <HLJFDBCNBIF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PNGDLIPGKLA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PNGDLIPGKLA
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
// PODKCNLOOAL
//   (not directly referenced by a detected call)
public class PODKCNLOOAL
{
    public NAALDEHGLCH CNFKCMOAMJA;    // 0x0x10
    public int EAEPKBJGPNJ;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x10
    public long? <CCHBBGMEHAH>k__BackingField;    // 0x0x18
    public AJMLMFADNCB <HAHJGHKEEPF>k__BackingField;    // 0x0x28
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
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.Auth]
public class AppleMusicPromotionResponseDTO
{
    public IHNIOOGJBFF <JOEGDIPNKIA>k__BackingField;    // 0x0x10
    public string <PILMLDHJGBB>k__BackingField;    // 0x0x18
    public string <HPGNOIMPPAE>k__BackingField;    // 0x0x20
    public string <HGEMOICFJDC>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public BOBIMJKOHAM <CurrencyType>k__BackingField;    // 0x0x18
    public EBACFOPCMGA <BalanceType>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.BalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<IMCLALLPAPB<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.CheerRequest
//   REQUEST  POST   api/inventions/v2/cheer   [Service.Auth]
public class CheerRequest
{
    public long InventionId;    // 0x0x10
    public bool Cheer;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.DeleteInventionRequest
//   REQUEST  POST   api/inventions/v2/delete   [Service.Auth]
public class DeleteInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
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
    public long <LJABGCJOOAA>k__BackingField;    // 0x0x10
    public long? <DKJINEALNEN>k__BackingField;    // 0x0x18
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
// RecNet.FilteredTextDTO
//   (not directly referenced by a detected call)
public class FilteredTextDTO
{
    public string <PIFFBKEMEJA>k__BackingField;    // 0x0x10
    public int <BPBFLIFKJJL>k__BackingField;    // 0x0x18
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
    public ADLEKGGGNAM FilterType;    // 0x0x20
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
    public BJMCILGJIBE <GiftContext>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCategoryConfigDTO
//   (not directly referenced by a detected call)
public class KeepsakeCategoryConfigDTO
{
    public AJMLMFADNCB <LKMENOBLJEO>k__BackingField;    // 0x0x10
    public string <IFANIMPCACM>k__BackingField;    // 0x0x18
    public int <ILICGMBKDHM>k__BackingField;    // 0x0x20
    public int <IAONAGBJIBE>k__BackingField;    // 0x0x24
    public string <DCFGFGGFPMD>k__BackingField;    // 0x0x28
    public string <MFPMHMKMPLH>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <CGDLAOCOBHK>k__BackingField;    // 0x0x10
    public Guid <GKDPJCLDJMB>k__BackingField;    // 0x0x14
    public DateTime <OMLEEPEKMMG>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.Auth]
public class KeepsakeGlobalConfigDTO
{
    public bool <FLAFGECDEOE>k__BackingField;    // 0x0x10
    public int <APEIKBFGHLE>k__BackingField;    // 0x0x14
    public bool <KKKMJNEJIDM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <GKDPJCLDJMB>k__BackingField;    // 0x0x10
    public AJMLMFADNCB <LFFEKILNEJP>k__BackingField;    // 0x0x20
    public int <FCNBEHKPJBE>k__BackingField;    // 0x0x24
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x28
    public long? <CCHBBGMEHAH>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.Auth]
//   RESPONSE GET    api/keepsakes/events/{lGDNIKBGCMO}   [Service.Auth]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <PIILNOFJMKC>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <FIBCGJGAEOD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <AKOKBLHKLDK>k__BackingField;    // 0x0x10
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x18
    public long <FLBGBJGDDKM>k__BackingField;    // 0x0x20
    public PPAHGJDENEL <BCLMFLFBLHA>k__BackingField;    // 0x0x28
    public int <IFCOPJOHAHE>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <IBKJLBGFPBN>k__BackingField;    // 0x0x10
    public List<Guid> <KNLBBKOMPMH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <PIILNOFJMKC>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <FIBCGJGAEOD>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <FBAMJEOHMJJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <FLBGBJGDDKM>k__BackingField;    // 0x0x10
    public long <NLLGKPGGEMF>k__BackingField;    // 0x0x18
    public int? <JECAOJEJNGD>k__BackingField;    // 0x0x20
    public int? <BLNOCCMDNHP>k__BackingField;    // 0x0x28
    public long? <OMJDEACNMII>k__BackingField;    // 0x0x30
    public long <LOHGCKNLODJ>k__BackingField;    // 0x0x40
    public long <BPAOEFMJKKH>k__BackingField;    // 0x0x48
    public int <GAHLEMOGDPC>k__BackingField;    // 0x0x50
    public PPAHGJDENEL <FCOCMHNHJJD>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <BGDEBPILNFN>k__BackingField;    // 0x0x58
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
    public BJMCILGJIBE <GiftContext>k__BackingField;    // 0x0x20
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
    public MMOLBELIPAC creatorAccountRole;    // 0x0x68
    public long? convertedFromInventionId;    // 0x0x70
    public string displayMetadataJson;    // 0x0x80
    public string longDescription;    // 0x0x88
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public CDLOKBCOPIO <ABBBBBIOFGE>k__BackingField;    // 0x0x10
    public HJJHCPOFENI <CFDOGFMOPPH>k__BackingField;    // 0x0x14
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x18
    public string <GINGAKGJCNH>k__BackingField;    // 0x0x20
    public bool <IPGNLJHPCPA>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<CDLOKBCOPIO> <EJFMKBDMPDD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/event/{eDDDPIOCLPG}   [Service.Auth]
public class ProgressionEventDTO
{
    public long <NLLGKPGGEMF>k__BackingField;    // 0x0x10
    public string <OJEIBBMLHGJ>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <ALABBFJJMON>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <BHBCJIBLOOH>k__BackingField;    // 0x0x28
    public DateTime <PKMOIBEMGGG>k__BackingField;    // 0x0x30
    public DateTime <KJOOAKEIKKJ>k__BackingField;    // 0x0x38
    public DateTime <HHIGKLJIOIB>k__BackingField;    // 0x0x40
    public bool <MKIJFAHGHGL>k__BackingField;    // 0x0x48
    public int <BGBEDFOHIFI>k__BackingField;    // 0x0x4C
    public float <NDHLOJOLOOB>k__BackingField;    // 0x0x50
    public Guid? <EPPNONGOMDO>k__BackingField;    // 0x0x54
    public string <KGBEFPPBEDE>k__BackingField;    // 0x0x68
    public string <IDJIFINMOAD>k__BackingField;    // 0x0x70
    public string <OOFPPMHGOBI>k__BackingField;    // 0x0x78
    public string <LEFAGGEJPOC>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <JJACLHCFPOG>k__BackingField;    // 0x0x10
    public int <IOIDNPKCDGJ>k__BackingField;    // 0x0x20
    public int <APMDGGLPPHH>k__BackingField;    // 0x0x24
    public int <BAPCFHGKFCJ>k__BackingField;    // 0x0x28
    public long <KIBKCAHGAEM>k__BackingField;    // 0x0x30
    public long <AMCHKCEAJAK>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.Auth]
public class ProgressionEventRecordDTO
{
    public int <CGDLAOCOBHK>k__BackingField;    // 0x0x10
    public int <EKPDICPOOCE>k__BackingField;    // 0x0x14
    public int <BKGEPIBHOFC>k__BackingField;    // 0x0x18
    public int <AOJFHKCINGH>k__BackingField;    // 0x0x1C
    public int <CBEAEJKNFIA>k__BackingField;    // 0x0x20
    public DateTime? <PNCFNPBCHEO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <MNGOJELLIMM>k__BackingField;    // 0x0x10
    public int <ENONCJEIANL>k__BackingField;    // 0x0x18
    public string <NJPJLDJJHAH>k__BackingField;    // 0x0x20
    public int <EKPDICPOOCE>k__BackingField;    // 0x0x28
    public int <DEEJDMNEMNC>k__BackingField;    // 0x0x2C
    public bool <BFCLDAMAPHL>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.PublishInventionRequest
//   REQUEST  POST   api/inventions/v4/publish   [Service.Auth]
public class PublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public GMJFIECDNGI <Permission>k__BackingField;    // 0x0x18
    public NHEBJNLJFEG <Accessibility>k__BackingField;    // 0x0x1C
    public int? <Price>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PurchaseBalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class PurchaseBalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<IOAFPOIKIGO<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.Auth]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public NHDPFEJFKAE ReportCategory;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.SetInventionVersionAccessibilityRequest
//   REQUEST  PUT    api/inventions/v2/accessibility   [Service.Auth]
public class SetInventionVersionAccessibilityRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public int <VersionNumber>k__BackingField;    // 0x0x18
    public NHEBJNLJFEG <NewAccessibility>k__BackingField;    // 0x0x1C
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
// RecNet.UnpublishInventionRequest
//   REQUEST  POST   api/inventions/v2/unpublish   [Service.Auth]
public class UnpublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.UpdateInventionGeneralPermissionRequest
//   REQUEST  POST   api/inventions/v2/update   [Service.Auth]
public class UpdateInventionGeneralPermissionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public GMJFIECDNGI <Permission>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.UpdateInventionMetadataRequest
//   REQUEST  PUT    api/inventions/v2/metadata   [Service.Auth]
public class UpdateInventionMetadataRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public string <LongDescription>k__BackingField;    // 0x0x28
    public string <ImageName>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.UpdatePriceRequest
//   REQUEST  POST   api/inventions/v2/updateprice   [Service.Auth]
public class UpdatePriceRequest
{
    public long InventionId;    // 0x0x10
    public int Price;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.DataLayer.RoomKeyResult
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/   [Service.WWW]
//   RESPONSE DELETE api/roomkeys/v1/delete/{mJOKIIGLCIG}   [Service.WWW]
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
    public bool HLHEPCBPCFF;    // 0x0x28
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

// api/CampusCard/v1/UpdateAndGetSubscription  [WWW POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [Auth POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public IDIHPLNLDNF? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [Auth POST]
public class PlayerCheerV1CreateRequest
{
    public IDIHPLNLDNF ALGEALBDMDI;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [Auth POST]
public class PlayerReportingV1DeviceIdRequest
{
    public ICLCGPHPAPG IEMECLBBOBO;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [Auth POST]
public class PlayerReportingV1HileRequest
{
    public OKHHKNFCEFM NNILCBOLNDI;  // wrapper
    public int? HDIIGILPACJ;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/modKick  [Auth POST]
public class PlayerReportingV1ModKickRequest
{
    public HFPNMKANCJC FLGJNNLOFNP;  // wrapper
    public object IsFromReport;  // candidate
    public object FromReportCategory;  // candidate
    public object GameSessionId;  // candidate
    public object PlayerId;  // candidate
}

// api/PlayerReporting/v1/moderationBlockDetails  [Auth POST]
public class PlayerReportingV1ModerationBlockDetailsRequest
{
    public string deviceToken;  // wrapper
}

// api/PlayerReporting/v1/referee  [Auth POST]
public class PlayerReportingV1RefereeRequest
{
    public byte[] LJELDKAOCJM;  // wrapper
    public JCLEPFOKOOB DFPGAGEFDEL;  // wrapper
    public object meta;  // candidate
    public object data;  // candidate
    public object file.bin;  // candidate
}

// api/PlayerReporting/v3/create  [Auth POST]
public class PlayerReportingV3CreateRequest
{
    public HFPNMKANCJC EJCDNDHLCKP;  // wrapper
    public float? KMDDLFNMAME;  // wrapper
    public bool? OFPKJICBCFH;  // wrapper
    public object IsFullBodyAvatarReport;  // candidate
    public object IsReporterFullBodyAvatar;  // candidate
    public object IsGiftingReport;  // candidate
    public object ReportCategory;  // candidate
    public object HeightReporter;  // candidate
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
    public List<BGAANIHBCHM> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [WWW POST]
public class AvatarV2GiftsGenerateRequest
{
    public BJMCILGJIBE IBLIOEFMDMM;  // wrapper
    public BJMCILGJIBE? CBHNHMEDABE;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [WWW POST]
public class AvatarV3GiftsGenerateRequest
{
    public BJMCILGJIBE IBLIOEFMDMM;  // wrapper
    public BJMCILGJIBE? CBHNHMEDABE;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [Auth POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage DCEACFEGBDC;  // wrapper
    public NDHNEBFFHBP EJCDNDHLCKP;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [Auth POST]
public class ClubreportingV1ReportRequest
{
    public HFPNMKANCJC EJCDNDHLCKP;  // wrapper
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
    public NHEBJNLJFEG GHHCIIPBHNJ;  // wrapper
    public GIFIJKECGHP LFEOMFLHEBC;  // wrapper
    public AMAHFPHIMJA IFBOJILJPHF;  // wrapper
    public AMAHFPHIMJA AOMNKFAEOGJ;  // wrapper
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

// api/customAvatarItems/v1/featured  [Auth GET]
public class CustomAvatarItemsV1FeaturedRequest
{
    public object unityAssetVersion;  // candidate
    public object unityAssetTarget;  // candidate
}

// api/customAvatarItems/v1/hot  [Auth GET]
public class CustomAvatarItemsV1HotRequest
{
    public object unityAssetVersion;  // candidate
    public object unityAssetTarget;  // candidate
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
    public object outfitTypes;  // candidate
    public object minPrice;  // candidate
    public object isOwned;  // candidate
    public object itemTypes;  // candidate
    public object isFeatured;  // candidate
}

// api/customAvatarItems/v1/{dLBJLJBGNMD}/appeal  [Auth POST]
public class CustomAvatarItemsV1DLBJLJBGNMDAppealRequest
{
    public Guid DLBJLJBGNMD;  // wrapper
}

// api/customAvatarItems/v2/fromCreator/{hGEJODBPMHJ}  [Auth GET]
public class CustomAvatarItemsV2FromCreatorHGEJODBPMHJRequest
{
    public int take;  // wrapper
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
    public NACPDEGLMEA HHAFLOAIDBI;  // wrapper
    public BJMCILGJIBE? KBNLCBOBMGF;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [WWW POST]
public class GamerewardsV1SelectRequest
{
    public BPMJIHLBDOC EOFDOGGFGLN;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/images/  [Auth GET]
public class ImagesRequest
{
    public object sort;  // candidate
    public object filter;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v4/room/{roomId}  [Auth GET]
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

// api/itemWishlists/v1/isonwishlist/bulk  [WWW POST]
public class ItemWishlistsV1IsonwishlistBulkRequest
{
    public List<int> accountIds;  // form
}

// api/keepsakes/{mDCODEADBDH}/collect  [Auth POST]
public class KeepsakesMDCODEADBDHCollectRequest
{
    public Guid MDCODEADBDH;  // wrapper
}

// api/messages/v2/send  [Auth POST]
public class MessagesV2SendRequest
{
    public OBJIHOOAMCJ ANGGCHEAKNK;  // wrapper
    public long? KCAAOMDKNIH;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/offlineinvite/v1/send  [Auth POST]
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
    public IReadOnlyCollection<long> GNHLOBHPKHM;  // wrapper
}

// api/playerevents/v2/delete/{eventId}  [Auth POST]
public class PlayereventsV2DeleteEventIdRequest
{
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [Auth PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public PCFHGMELLAO GHHCIIPBHNJ;  // wrapper
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
    public PCFHGMELLAO NNMPJHLBOHK;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [Auth PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? IAPKLCKHBOA;  // wrapper
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
    public long? JLNNLHKGIHH;  // wrapper
}

// api/playerevents/v2/{eventId}/description  [Auth PUT]
public class PlayereventsV2EventIdDescriptionRequest
{
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
}

// api/playerevents/v2/{eventId}/image  [Auth PUT]
public class PlayereventsV2EventIdImageRequest
{
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [Auth PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public NOOHIKMHEAO OPNGFJEFNMK;  // wrapper
    public NOOHIKMHEAO JEJCDFGIKMK;  // wrapper
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
}

// api/playerevents/v2/{eventId}/name  [Auth PUT]
public class PlayereventsV2EventIdNameRequest
{
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [Auth PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? NFFPLNPCCNI;  // wrapper
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
    public long? FMKNPFOKPJO;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [Auth PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime GEPPIPLKAPF;  // wrapper
    public DateTime DABEEMEOADO;  // wrapper
    public GDDCHMNKMCA KMHDIPHFDND;  // wrapper
    public DateTime HCJFDLJOHFB;  // wrapper
    public DateTime OGLDFAEFLDP;  // wrapper
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
    public HFPNMKANCJC EJCDNDHLCKP;  // wrapper
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
    public Guid IPAFKKFJNHJ;  // wrapper
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
    public Guid ICNFNGCPNHP;  // wrapper
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
    public Guid ICNFNGCPNHP;  // wrapper
    public long? FFFFGHFGFJD;  // wrapper
    public byte? ADJAHFEDDPI;  // wrapper
    public int? JLNFDAODDKP;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid IPAFKKFJNHJ;  // wrapper
    public long? AFOOKCAGKGE;  // wrapper
    public long? MBMCPNMENHC;  // wrapper
    public int? JBPJDLDIMEB;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [WWW PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> BNHLGDBCCDH;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [WWW POST]
public class RoomkeysV1CreateRequest
{
    public MOJIEODGIGC NNILCBOLNDI;  // wrapper
    public Guid? HAAFMHDEOPH;  // wrapper
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

// api/rooms/v2/report  [Auth POST]
public class RoomsV2ReportRequest
{
    public HFPNMKANCJC EJCDNDHLCKP;  // wrapper
    public long? DGAMIJDOAKF;  // wrapper
    public Guid? DHCJPNPBMDG;  // wrapper
    public int? DFIALAMNAAO;  // wrapper
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
    public Guid HJEINHNIKJB;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [WWW POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid JBMIIPDPJGM;  // wrapper
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

// api/storefronts/v2/trialInvention  [WWW POST]
public class StorefrontsV2TrialInventionRequest
{
    public long inventionId;  // wrapper
}

// api/testcasemanagement/v1/testcase/  [Auth POST]
public class TestcasemanagementV1TestcaseRequest
{
    public LEPEGIGGLOC PFAGNGMKJJK;  // wrapper
}

