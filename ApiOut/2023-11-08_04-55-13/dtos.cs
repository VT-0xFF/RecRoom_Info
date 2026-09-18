// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 212 (plus referenced enums)

// --------------------------------------------------------------------------
// AAEGOCBAFNM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AAEGOCBAFNM
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// ACGEDGOEAJP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ACGEDGOEAJP
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
}

// --------------------------------------------------------------------------
// ACOEHOOJKAO
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class ACOEHOOJKAO
{
    public List<string> <NEJMAKDFLOE>k__BackingField;    // 0x0x10
    public List<string> <POHBJDNLLDF>k__BackingField;    // 0x0x18
    public List<string> <OJNDHKHOKPI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AFBIDAOCBFB
//   RESPONSE ?      api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Econ]
public class AFBIDAOCBFB
{
    public NMOCDEEOHJA <BMFMNIMIDHA>k__BackingField;    // 0x0x10
    public KFDPPEICEBK <CINMDCEGEOC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AFNJJDACIPH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AFNJJDACIPH
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
}

// --------------------------------------------------------------------------
// AJPEAJPFIIJ
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class AJPEAJPFIIJ
{
    public int <BONFFEFOCEK>k__BackingField;    // 0x0x10
    public MHELGBFBCAF <AHGNGLCPEBK>k__BackingField;    // 0x0x14
    public INJLLHHIAGN <NFJJPCFJAKA>k__BackingField;    // 0x0x18
    public INJLLHHIAGN <DKKAJBOFAAL>k__BackingField;    // 0x0x1C
    public INJLLHHIAGN <AFEHPKFCPII>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BACJMDEGMJD
//   (not directly referenced by a detected call)
public class BACJMDEGMJD
{
    public Guid <AJGLHHADADH>k__BackingField;    // 0x0x10
    public int <MJGFOGHKDFN>k__BackingField;    // 0x0x20
    public int <DGNANCCFANJ>k__BackingField;    // 0x0x24
    public Guid <EKMALBGGNHI>k__BackingField;    // 0x0x28
    public DateTime <KHAHEOMCHHB>k__BackingField;    // 0x0x38
    public JHFIMMAAFOO <CJNCOCOCLEA>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// BBDCGOGIDBF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BBDCGOGIDBF
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
// BBKGAMBBHKN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BBKGAMBBHKN
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
// BEGJDMHHNAL
//   (not directly referenced by a detected call)
public class BEGJDMHHNAL
{
    public int <HHMPMCHNCCF>k__BackingField;    // 0x0x10
    public FAJICACALLF <NALAIGBMDDP>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// BGFOJPEJJEN
//   (not directly referenced by a detected call)
public class BGFOJPEJJEN
{
    public Guid? <FFAMMPHNMDF>k__BackingField;    // 0x0x10
    public Guid <NOAMEKBPLEO>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// BGOLIJHOAGM
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class BGOLIJHOAGM
{
    public int? <OHOMNKDCGKC>k__BackingField;    // 0x0x10
    public string <EGDMKJGAGIJ>k__BackingField;    // 0x0x18
    public string <IGAGBOHCKJB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BINGCHPPFAF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BINGCHPPFAF
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// BMBHGJJJADE
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class BMBHGJJJADE
{
    public int <KGMGKIODBAG>k__BackingField;    // 0x0x10
    public int <DPHDIIDAOEB>k__BackingField;    // 0x0x14
    public float <DOEDDILOLAA>k__BackingField;    // 0x0x18
    public float <OPNHFAADOJD>k__BackingField;    // 0x0x1C
    public bool <LLINGJGGCLK>k__BackingField;    // 0x0x20
    public bool <NPGCDPCJPEG>k__BackingField;    // 0x0x21
    public bool <LLHEHEGLINC>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// BMPDCDEMLCE
//   (not directly referenced by a detected call)
public class BMPDCDEMLCE
{
    public float <PFLJDIGAJLN>k__BackingField;    // 0x0x10
    public float <MFHHLEHCHDL>k__BackingField;    // 0x0x14
    public float <MBGCCAPFEMJ>k__BackingField;    // 0x0x18
    public float <HOJNCAEHPII>k__BackingField;    // 0x0x1C
    public float <BELFENPJOBC>k__BackingField;    // 0x0x20
    public float <EHLJCFGNMAI>k__BackingField;    // 0x0x24
    public float <OOKFOEKMMIP>k__BackingField;    // 0x0x28
    public float <BEFKFFPPAMA>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// BPKJGMAPOAL
// base   : NGGOIMHEKJF
//   (not directly referenced by a detected call)
public class BPKJGMAPOAL : NGGOIMHEKJF
{
    public int <MDDGJMKOJMC>k__BackingField;    // 0x0x60
    public List<ONCNLCCNKCE> <EHIOKAMCFCB>k__BackingField;    // 0x0x68
    public List<ONCNLCCNKCE> <EDPFCBLHKCI>k__BackingField;    // 0x0x70
    public List<ONCNLCCNKCE> <EMFMNBMIFHJ>k__BackingField;    // 0x0x78
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
// CBOGEMLBOFJ
//   (not directly referenced by a detected call)
public class CBOGEMLBOFJ
{
    public long <MJKPAOMNBAA>k__BackingField;    // 0x0x10
    public Guid? <FFOPGOIPMPD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CFGMFOCDPBB
//   (not directly referenced by a detected call)
public class CFGMFOCDPBB
{
    public ObscuredLong <MCNNDEPLEOE>k__BackingField;    // 0x0x10
    public string <NKBFPFDNINK>k__BackingField;    // 0x0x38
    public ObscuredInt <MLGAKJGJOFP>k__BackingField;    // 0x0x40
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x58
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x60
    public string <JKNLPGPDJDI>k__BackingField;    // 0x0x68
    public int <BFKMGPGBKEM>k__BackingField;    // 0x0x70
    public OMCBBEDKJFO <EEFCMCIKAGO>k__BackingField;    // 0x0x74
    public DateTime <KHAHEOMCHHB>k__BackingField;    // 0x0x78
    public DateTime <FLDGKIFCAFB>k__BackingField;    // 0x0x80
    public DateTime? <APNJDIDCOEE>k__BackingField;    // 0x0x88
    public long? <JMDFEPCMMOB>k__BackingField;    // 0x0x98
    public int <CEMPFNFJFBH>k__BackingField;    // 0x0xA8
    public int <JELBLOAMOJG>k__BackingField;    // 0x0xAC
    public int <DAMPCHHLPPN>k__BackingField;    // 0x0xB0
    public CNFPPHMIALB <GLEJHODJLMK>k__BackingField;    // 0x0xB4
    public CNFPPHMIALB <BAIEDANHIGF>k__BackingField;    // 0x0xB8
    public ObscuredBool <BENFBCEJPBL>k__BackingField;    // 0x0xBC
    public ObscuredBool <OCAONACOFLN>k__BackingField;    // 0x0xC8
    public ObscuredBool <DBFAPNNBGBG>k__BackingField;    // 0x0xD4
    public int? <MJKPAOMNBAA>k__BackingField;    // 0x0xE0
    public bool <LIHCNJCGLIF>k__BackingField;    // 0x0xE8
}

// --------------------------------------------------------------------------
// CGHHHLFBHFL
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class CGHHHLFBHFL
{
    public string <MJPDOLNNJOP>k__BackingField;    // 0x0x10
    public string <HOEHHHLBGBN>k__BackingField;    // 0x0x18
    public string <GJMGBDIIHLI>k__BackingField;    // 0x0x20
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x28
    public string <EGDMKJGAGIJ>k__BackingField;    // 0x0x30
    public AAEGOCBAFNM <BMFMNIMIDHA>k__BackingField;    // 0x0x38
    public List<string> <EGNBOFBHDBO>k__BackingField;    // 0x0x40
    public List<string> <MCCLNBFNMDD>k__BackingField;    // 0x0x48
    public string <GEJJMKDICGF>k__BackingField;    // 0x0x50
    public List<MFEBFNMNNPB> <KMPBMMAPIGF>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// CLFCKDJNIHA
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.Econ]
//   RESPONSE GET    api/avatar/v4/items   [Service.Econ]
public class CLFCKDJNIHA
{
    public OENHMLLPCHH <BIMCIFAIFJP>k__BackingField;    // 0x0x10
    public string <GLFJENNJHKD>k__BackingField;    // 0x0x18
    public string <DGBPAAHHNOP>k__BackingField;    // 0x0x20
    public string <NLBMCHFJDEG>k__BackingField;    // 0x0x28
    public MJBGPLBJDEH <INFJDPCBLJP>k__BackingField;    // 0x0x30
    public string <PPIKFJEKMJN>k__BackingField;    // 0x0x38
    public int <HOPFIDMLMIF>k__BackingField;    // 0x0x40
    public bool <KJGIKIDCEHK>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// CMIJNCKPNHF
//   (not directly referenced by a detected call)
public class CMIJNCKPNHF
{
    public bool <OCEPDPJPFAI>k__BackingField;    // 0x0x10
    public AFNJJDACIPH <EAOMFHBFDJD>k__BackingField;    // 0x0x14
    public int <DJAAGAGNKHK>k__BackingField;    // 0x0x18
    public DateTime <KHAHEOMCHHB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CNFPPHMIALB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CNFPPHMIALB
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
// CPGFJDEMABN
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
public class CPGFJDEMABN
{
    public EKENOHNGOOL <BMFMNIMIDHA>k__BackingField;    // 0x0x10
    public BACJMDEGMJD <JHHKFGEPNGL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CPHIPCLBLKO
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class CPHIPCLBLKO
{
    public INAINIEOHOI <HJDDCLOCBGF>k__BackingField;    // 0x0x10
    public int <JGLJGKIOHAG>k__BackingField;    // 0x0x14
    public long <CGAEHOMMJPP>k__BackingField;    // 0x0x18
    public bool <JCHEJDMLGBF>k__BackingField;    // 0x0x20
    public string <BGHKLMCCLMM>k__BackingField;    // 0x0x28
    public int? <AKNAJMDLDKB>k__BackingField;    // 0x0x30
    public bool <JHMLNJCFFJC>k__BackingField;    // 0x0x38
    public bool <OHKELKNNBNC>k__BackingField;    // 0x0x39
    public bool <DPCOBIOKMBB>k__BackingField;    // 0x0x3A
    public bool <IKIEOOMLDLJ>k__BackingField;    // 0x0x3B
    public string <NGOPLBECKKH>k__BackingField;    // 0x0x40
    public DateTime? <GNCJOCODLMC>k__BackingField;    // 0x0x48
    public string <OPJJAMJAPCL>k__BackingField;    // 0x0x58
    public float <LBJOJNCLCCF>k__BackingField;    // 0x0x60
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
// DCAEIJFPLDD
//   RESPONSE GET    api/config/v2   [Service.API]
public class DCAEIJFPLDD
{
    public Dictionary<int, int> <IBMFMKMPLLN>k__BackingField;    // 0x0x10
    public List<BLPKAPMKPBN> <PIPBJCHJJIM>k__BackingField;    // 0x0x18
    public POGGPFLNDKF[][] <AFIHMJJAEJD>k__BackingField;    // 0x0x20
    public OCFDLKAAFFJ <KIDHOKMPJAH>k__BackingField;    // 0x0x28
    public BMPDCDEMLCE <GEOIAOLPDOA>k__BackingField;    // 0x0x30
    public OAILHEPACOB <FIKFPBKLCCN>k__BackingField;    // 0x0x38
    public LKHBDHCDBBD <LGCHKHBEOGP>k__BackingField;    // 0x0x40
    public KLLAIACGOJA <EJCALLPPPLJ>k__BackingField;    // 0x0x48
    public string <KLMOGGCCPCK>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// DCENIFGGBBO
// base   : HAFKAFIEAFH
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class DCENIFGGBBO : HAFKAFIEAFH
{
    public List<EPOIBCGFCNI> <MCCLNBFNMDD>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// DILNHDFMKKD
//   RESPONSE POST   api/chatreport/createChatReport   [Service.API]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.Econ]
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.API]
//   RESPONSE PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.Econ]
//   RESPONSE ?      api/gamerewards/v1/request   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.Econ]
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE DELETE api/keepsakes/{kJOKGMJIJOB}   [Service.API]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
public class DILNHDFMKKD
{
    public bool <GPKDGAFAKNB>k__BackingField;    // 0x0x10
    public string <FKPJNLDLKOA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DMEAFPHKMKM
//   (not directly referenced by a detected call)
public class DMEAFPHKMKM
{
    public int <DMDECPDJJOH>k__BackingField;    // 0x0x10
    public BGFOJPEJJEN <PKLGJIHPCCF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DOBFEHEGCDG
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
public class DOBFEHEGCDG
{
    public string <CKHJNGHJAGB>k__BackingField;    // 0x0x10
    public string <MKANFFPJCKJ>k__BackingField;    // 0x0x18
    public bool <MGNPANADAKB>k__BackingField;    // 0x0x20
    public string <KLLBDCDFKAK>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// ECBKGPPBJCE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ECBKGPPBJCE
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// EGAECLLKIPE
// base   : FGHBCNIEOCC
//   RESPONSE ?      api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.Econ]
public class EGAECLLKIPE : FGHBCNIEOCC
{
    public GOKFOCHNLEJ? <LIKNBMHNMGD>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <EPGLEBPICPB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EIGCBGEBALG
//   (not directly referenced by a detected call)
public class EIGCBGEBALG
{
    public long <BKOAOGOMBKN>k__BackingField;    // 0x0x10
    public string <NKBFPFDNINK>k__BackingField;    // 0x0x18
    public int <CNGHIMILKGP>k__BackingField;    // 0x0x20
    public int <JHHBGLDINIL>k__BackingField;    // 0x0x24
    public int <KMAPCLIBMDC>k__BackingField;    // 0x0x28
    public int <GIDEOGLONOL>k__BackingField;    // 0x0x2C
    public int <JEEJMPHHMBO>k__BackingField;    // 0x0x30
    public string <EEEMNKHEJHF>k__BackingField;    // 0x0x38
    public string <EJMLPGEOANL>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// EJMOJHDIBNG
//   (not directly referenced by a detected call)
public class EJMOJHDIBNG
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// EKENOHNGOOL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EKENOHNGOOL
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
// EKHHFDIOBOC
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class EKHHFDIOBOC
{
    public long <NFEIMPKIJCC>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <IGHJFLDIPCL>k__BackingField;    // 0x0x18
    public NPLDJHCJNHB <MOIKNANDCFH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EMKJFMFMJBI
//   (not directly referenced by a detected call)
public class EMKJFMFMJBI
{
    public long <PONDFBAPKAB>k__BackingField;    // 0x0x10
    public string <HADPGKDOLLN>k__BackingField;    // 0x0x18
    public string <EILCAECMMJP>k__BackingField;    // 0x0x20
    public OENHMLLPCHH? <BIMCIFAIFJP>k__BackingField;    // 0x0x28
    public string <AJAKCEAJACI>k__BackingField;    // 0x0x30
    public string <MEICHMNDNOL>k__BackingField;    // 0x0x38
    public PNFCNJJFDEF <HHANMAJKGKK>k__BackingField;    // 0x0x40
    public int <EGPDLDEHLMG>k__BackingField;    // 0x0x44
    public int <HHFMPLPOOLF>k__BackingField;    // 0x0x48
    public BBKGAMBBHKN? <MCLHBOGCDGO>k__BackingField;    // 0x0x4C
    public MJBGPLBJDEH? <NABNGCJDDEB>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// EMMCODKMGBP
//   (not directly referenced by a detected call)
public class EMMCODKMGBP
{
    public long <JEMKLACNJLK>k__BackingField;    // 0x0x10
    public long <EOICOHCLHFK>k__BackingField;    // 0x0x18
    public int <OBCNDMMICAC>k__BackingField;    // 0x0x20
    public DateTime <FLDGKIFCAFB>k__BackingField;    // 0x0x28
    public KOBBGPLDGCI <AHGNGLCPEBK>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// EPOIBCGFCNI
//   (not directly referenced by a detected call)
public class EPOIBCGFCNI
{
    public string <LMFLEPANHOK>k__BackingField;    // 0x0x10
    public BINGCHPPFAF <AHGNGLCPEBK>k__BackingField;    // 0x0x18
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
// FAJICACALLF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FAJICACALLF
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
}

// --------------------------------------------------------------------------
// FFCFMLODACK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FFCFMLODACK
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
// FLNKIPIPBDA
//   (not directly referenced by a detected call)
public class FLNKIPIPBDA
{
    public int <AKIAEEJFJOF>k__BackingField;    // 0x0x10
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x18
    public string <IJCCDLFLCFJ>k__BackingField;    // 0x0x20
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x28
    public string <NLBMCHFJDEG>k__BackingField;    // 0x0x30
    public bool <AIMNPJGGKKL>k__BackingField;    // 0x0x38
    public int <KFNIKDJDGKF>k__BackingField;    // 0x0x3C
    public EJMOJHDIBNG <ADCDLLEMNON>k__BackingField;    // 0x0x40
    public JMPKLJNIGJC NMGMMEOFLNO;    // 0x0x48
    public JMPKLJNIGJC CLEOCHOGPDK;    // 0x0x50
    public JMPKLJNIGJC PPKKEBHDIKF;    // 0x0x58
    public OLKFKMINFGA PPBDJAAHKCD;    // 0x0x60
}

// --------------------------------------------------------------------------
// FPLNEBKFIIB
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class FPLNEBKFIIB
{
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x10
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x18
    public int? <MJKPAOMNBAA>k__BackingField;    // 0x0x20
    public OMCBBEDKJFO? <EEFCMCIKAGO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// GBICDJFHJHP
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.API]
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems   [Service.API]
public class GBICDJFHJHP
{
    public Dictionary<string, KIMDMDGBHNI> <JCAPDOJAEJJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GEHFJMHMPNE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GEHFJMHMPNE
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
// GJCBBLNCAFE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GJCBBLNCAFE
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// HAFKAFIEAFH
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class HAFKAFIEAFH
{
    public long <EOICOHCLHFK>k__BackingField;    // 0x0x10
    public int <MLJGIIEADJO>k__BackingField;    // 0x0x18
    public long <NFEIMPKIJCC>k__BackingField;    // 0x0x20
    public long? <BGHANGGMGDC>k__BackingField;    // 0x0x28
    public long? <NGFCHOJJHIG>k__BackingField;    // 0x0x38
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x48
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x50
    public string <JKNLPGPDJDI>k__BackingField;    // 0x0x58
    public DateTime <NFLDNALPMDM>k__BackingField;    // 0x0x60
    public DateTime <JDCLDPCOPKI>k__BackingField;    // 0x0x68
    public int <MNGGAGEKDFC>k__BackingField;    // 0x0x70
    public HPMHJOKIIEK <EEFCMCIKAGO>k__BackingField;    // 0x0x74
    public bool <HCMPFJMLPAH>k__BackingField;    // 0x0x78
    public bool <PMCPMDDMFIO>k__BackingField;    // 0x0x79
    public GJCBBLNCAFE <INDHKADCPAH>k__BackingField;    // 0x0x7C
    public GJCBBLNCAFE <CBOJBHEGJFN>k__BackingField;    // 0x0x80
    public long? <LFPENJIABAN>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// HGJDIAJJDNI
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{fHBEKHFNLBP}/{dCCOFJPOLJF}   [Service.Econ]
public class HGJDIAJJDNI
{
    public BBDCGOGIDBF <JPIMNINPJLM>k__BackingField;    // 0x0x10
    public KDPJMBAHPHK <JHBLDBFMPFN>k__BackingField;    // 0x0x14
    public int <OLDHIGLMIAC>k__BackingField;    // 0x0x18
    public int <EFLFCDAKFNM>k__BackingField;    // 0x0x1C
    public int <GBKOEFJCLAO>k__BackingField;    // 0x0x20
    public OHFIBNCCNCD <PJFFOGBCKAL>k__BackingField;    // 0x0x24
    public bool <MHHIEOMLEEA>k__BackingField;    // 0x0x28
    public float <MJBEHAKFGMD>k__BackingField;    // 0x0x2C
    public int <MPNIEEONNGH>k__BackingField;    // 0x0x30
    public bool <LCHHCHFINEA>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// HJJMKOEDIIK
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class HJJMKOEDIIK
{
    public int <MJGFOGHKDFN>k__BackingField;    // 0x0x10
    public Guid <FFOPGOIPMPD>k__BackingField;    // 0x0x14
    public long <ONLBLBJLPKF>k__BackingField;    // 0x0x28
    public DateTime <KHAHEOMCHHB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// HKJEPJFDOOC
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{hICCPMJPEHH}   [Service.API]
public class HKJEPJFDOOC
{
    public List<HAFKAFIEAFH> <FLOAGLJFPLP>k__BackingField;    // 0x0x10
    public List<OOHIBINJBEJ> <EDDIDNACOJA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HLKEKLAPBKB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HLKEKLAPBKB
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// HOAICLOJANM
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class HOAICLOJANM
{
    public PLAOLFMCENB <NALAIGBMDDP>k__BackingField;    // 0x0x10
    public List<string> <MCCLNBFNMDD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HOENMCNMMAG
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class HOENMCNMMAG
{
    public List<BEGJDMHHNAL> <JGDIAMKCBBO>k__BackingField;    // 0x0x10
    public FAJICACALLF <NALAIGBMDDP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HPMHJOKIIEK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HPMHJOKIIEK
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// IDJBOMBAOKD
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class IDJBOMBAOKD
{
    public IGHFOEBDHOM <HJDDCLOCBGF>k__BackingField;    // 0x0x10
    public string <JKKBBONGAEP>k__BackingField;    // 0x0x18
    public int? <IJPCDDLHNPN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IDJNNJGPDAG
//   (not directly referenced by a detected call)
public class IDJNNJGPDAG
{
    public Guid <AIMHOCFAAJI>k__BackingField;    // 0x0x10
    public Guid <HGEAHDPECPA>k__BackingField;    // 0x0x20
    public DateTime <BPKIIGPKHFD>k__BackingField;    // 0x0x30
    public List<KLHLHEAGJEN> <JPINAIKHJEO>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// INBFBCIGGNA
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class INBFBCIGGNA
{
    public int <LFEEIFJACCP>k__BackingField;    // 0x0x10
    public int? <MCFMPCBMMDJ>k__BackingField;    // 0x0x14
    public string <BABPGHGBLJF>k__BackingField;    // 0x0x20
    public string <HGIPAEJBICF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// INMEKFJAIGO
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.Econ]
public class INMEKFJAIGO
{
    public List<IPJPDCKPBMB> <EOIAMPAEANP>k__BackingField;    // 0x0x10
    public string <JMPFGAGJOAH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IOPJFMPFOCE
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class IOPJFMPFOCE
{
    public Dictionary<Guid, DMEAFPHKMKM> <MGJKHJIAICD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IPJPDCKPBMB
//   (not directly referenced by a detected call)
public class IPJPDCKPBMB
{
    public int <MCCNHKGNENC>k__BackingField;    // 0x0x10
    public DateTime <FLDGKIFCAFB>k__BackingField;    // 0x0x18
    public DateTime? <PJOGFCLBPLN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IPPGLJKDOIE
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{hPBLIGMAEPN}   [Service.API]
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
public class IPPGLJKDOIE
{
    public DCENIFGGBBO <CKKHOFJMCHP>k__BackingField;    // 0x0x10
    public FAJICACALLF <NALAIGBMDDP>k__BackingField;    // 0x0x18
    public HOAICLOJANM <CGDDLOKIAHK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JHFCLGBCONG
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class JHFCLGBCONG
{
    public int <JGLJGKIOHAG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JHFIMMAAFOO
//   (not directly referenced by a detected call)
public class JHFIMMAAFOO
{
    public Guid <AJGLHHADADH>k__BackingField;    // 0x0x10
    public long <NFEIMPKIJCC>k__BackingField;    // 0x0x20
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x28
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x30
    public string <JKNLPGPDJDI>k__BackingField;    // 0x0x38
    public long <MJKPAOMNBAA>k__BackingField;    // 0x0x40
    public Guid? <KDIPGCLMIHM>k__BackingField;    // 0x0x48
    public DateTime <KHAHEOMCHHB>k__BackingField;    // 0x0x60
    public int <DCDIAKJJCIG>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// JKLADHHJFBN
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class JKLADHHJFBN
{
    public List<int> <GPBDGBFDGOG>k__BackingField;    // 0x0x10
    public string <JMPFGAGJOAH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JKMEFNIHAMM
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{lIEAGBEBBMP}   [Service.Econ]
public class JKMEFNIHAMM
{
    public EKENOHNGOOL <BMFMNIMIDHA>k__BackingField;    // 0x0x10
    public JHFIMMAAFOO <CJNCOCOCLEA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JOBJIEGJEMB
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/inventions/v4/addversion   [Service.API]
//   RESPONSE POST   api/inventions/v6/save   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.Econ]
public class JOBJIEGJEMB
{
    public ACGEDGOEAJP <BMFMNIMIDHA>k__BackingField;    // 0x0x10
    public CFGMFOCDPBB <NEABJHHEPOM>k__BackingField;    // 0x0x18
    public EIGCBGEBALG <CAKPNEMNIIP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JOOIOKPLFAN
// base   : PHHGIMEIMEP`1<DOBJGDENJNK>
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{pCHPGFDPAMM}   [Service.API]
public class JOOIOKPLFAN
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// JPFOJBNNMIB
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class JPFOJBNNMIB
{
    public List<EPOIBCGFCNI> <MCCLNBFNMDD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KBPMNOFLCPC
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class KBPMNOFLCPC
{
    public int <LCDBMMPONDB>k__BackingField;    // 0x0x10
    public int <MHGNLDMJJJO>k__BackingField;    // 0x0x14
    public float <JEBINAEIMLN>k__BackingField;    // 0x0x18
    public int <GJGOGEADMDH>k__BackingField;    // 0x0x1C
    public int <NOKHNIPGFDF>k__BackingField;    // 0x0x20
    public int <MFPANNDGKJH>k__BackingField;    // 0x0x24
    public int <OBMNEGIEMFE>k__BackingField;    // 0x0x28
    public string <PMJIOJAKLEO>k__BackingField;    // 0x0x30
    public string <ENGDNNANKMJ>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// KDFJDHBPDKE
// base   : GNHPJDJKDCC
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{iGCNOIHADDO}   [Service.Econ]
public class KDFJDHBPDKE : GNHPJDJKDCC
{
    public int <HAAABPNAAJB>k__BackingField;    // 0x0x30
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x38
    public DateTime <BPKIIGPKHFD>k__BackingField;    // 0x0x40
    public DateTime <MAEPAIFBMDH>k__BackingField;    // 0x0x48
    public BBDCGOGIDBF <JPIMNINPJLM>k__BackingField;    // 0x0x50
    public NGGOIMHEKJF <DNAGJLGLFFD>k__BackingField;    // 0x0x58
    public List<BPKJGMAPOAL> <AOFEILFMDLG>k__BackingField;    // 0x0x60
    public CMIJNCKPNHF <JOMBJEOGCBJ>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// KDPJMBAHPHK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KDPJMBAHPHK
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
// KEMMABIICAJ
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class KEMMABIICAJ
{
    public long <DDDMPOGCGKH>k__BackingField;    // 0x0x10
    public int <MJGFOGHKDFN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KFDPPEICEBK
//   (not directly referenced by a detected call)
public class KFDPPEICEBK
{
    public long <DDDMPOGCGKH>k__BackingField;    // 0x0x10
    public Guid <NKBFPFDNINK>k__BackingField;    // 0x0x18
    public long <NFEIMPKIJCC>k__BackingField;    // 0x0x28
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x30
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x38
    public int <MJKPAOMNBAA>k__BackingField;    // 0x0x40
    public Guid? <KDIPGCLMIHM>k__BackingField;    // 0x0x44
    public DateTime <FLDGKIFCAFB>k__BackingField;    // 0x0x58
    public string <JKNLPGPDJDI>k__BackingField;    // 0x0x60
    public ECBKGPPBJCE <AHGNGLCPEBK>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// KIMDMDGBHNI
//   (not directly referenced by a detected call)
public class KIMDMDGBHNI
{
    public long <LDCJPIECANO>k__BackingField;    // 0x0x10
    public Guid <ECIHNMKOJNB>k__BackingField;    // 0x0x18
    public Guid <EBKDAOJGBHD>k__BackingField;    // 0x0x28
    public DateTime <FLDGKIFCAFB>k__BackingField;    // 0x0x38
    public string <GGMOMNJBMKN>k__BackingField;    // 0x0x40
    public string <KEJCCJDIPJP>k__BackingField;    // 0x0x48
    public string <MOJJABNHHEP>k__BackingField;    // 0x0x50
    public string <DNFPIJCCLBL>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// KLAHFADMEAG
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class KLAHFADMEAG
{
    public bool <HALOEBIIGGK>k__BackingField;    // 0x0x10
    public string <HOEHHHLBGBN>k__BackingField;    // 0x0x18
    public string <ECLELEMGFBG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KLHLHEAGJEN
//   (not directly referenced by a detected call)
public class KLHLHEAGJEN
{
    public int <PONDFBAPKAB>k__BackingField;    // 0x0x10
    public string <DGBPAAHHNOP>k__BackingField;    // 0x0x18
    public string <NLBMCHFJDEG>k__BackingField;    // 0x0x20
    public string <PPIKFJEKMJN>k__BackingField;    // 0x0x28
    public string <HADPGKDOLLN>k__BackingField;    // 0x0x30
    public string <GOILLFHPJAN>k__BackingField;    // 0x0x38
    public OENHMLLPCHH? <BIMCIFAIFJP>k__BackingField;    // 0x0x40
    public string <AJAKCEAJACI>k__BackingField;    // 0x0x48
    public string <MEICHMNDNOL>k__BackingField;    // 0x0x50
    public bool <DNOJADJEGBA>k__BackingField;    // 0x0x58
    public bool <LMFNDOEOIOE>k__BackingField;    // 0x0x59
    public bool <JOIKBPOEGPM>k__BackingField;    // 0x0x5A
    public MJBGPLBJDEH <INFJDPCBLJP>k__BackingField;    // 0x0x5C
    public int <HOPFIDMLMIF>k__BackingField;    // 0x0x60
    public BBDCGOGIDBF <JPIMNINPJLM>k__BackingField;    // 0x0x64
    public int <IOMJBAJMNKJ>k__BackingField;    // 0x0x68
    public GEHFJMHMPNE <CDHHCMNHBNB>k__BackingField;    // 0x0x6C
    public BBKGAMBBHKN <KDDEDJMGPKL>k__BackingField;    // 0x0x70
    public int? <JAOCGFKIPPH>k__BackingField;    // 0x0x74
    public string <DDCEGCAJJFC>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// KLLAIACGOJA
//   (not directly referenced by a detected call)
public class KLLAIACGOJA
{
    public float <FKJJJCEPGNI>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KMGMCOECIOC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KMGMCOECIOC
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
}

// --------------------------------------------------------------------------
// KOBBGPLDGCI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KOBBGPLDGCI
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// KOKCHAFNBED
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{jPODHBJFPKM}   [Service.API]
public class KOKCHAFNBED
{
    public uint <MJPDOLNNJOP>k__BackingField;    // 0x0x10
    public uint? <LNBIOBBIKFM>k__BackingField;    // 0x0x14
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x20
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x28
    public DateTime <EBEKCBKBEGK>k__BackingField;    // 0x0x30
    public DateTime? <KCJAGOKNKOM>k__BackingField;    // 0x0x38
    public bool <BNIMFKLBOCI>k__BackingField;    // 0x0x48
    public List<CGHHHLFBHFL> <OAJNOKEMILC>k__BackingField;    // 0x0x50
    public List<string> <MCCLNBFNMDD>k__BackingField;    // 0x0x58
    public int <NNPOKHHFCMI>k__BackingField;    // 0x0x60
    public int <ACFJOBJMPDM>k__BackingField;    // 0x0x64
    public int <GDGEELNBACA>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// KPEFMOECOJG
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class KPEFMOECOJG
{
    public Guid? <AJGLHHADADH>k__BackingField;    // 0x0x10
    public long? <NFEIMPKIJCC>k__BackingField;    // 0x0x28
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x38
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x40
    public string <JKNLPGPDJDI>k__BackingField;    // 0x0x48
    public CBOGEMLBOFJ <FBMFBGIGEHD>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// KPGNNLAJMDF
//   (not directly referenced by a detected call)
public class KPGNNLAJMDF
{
    public int <DNGNKIPFFEG>k__BackingField;    // 0x0x10
    public DateTime? <MCJBGNECGFM>k__BackingField;    // 0x0x18
    public DateTime? <HKDAOLGKHHM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LDBEPNIGNNM
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class LDBEPNIGNNM
{
    public FAJICACALLF <NALAIGBMDDP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LFLFCGHAMLG
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems   [Service.API]
public class LFLFCGHAMLG
{
    public byte <NAJILMLOADN>k__BackingField;    // 0x0x10
    public int <GGOMCCNDCCM>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// LGBIKIPBNIB
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.Econ]
public class LGBIKIPBNIB
{
    public int <NEFCJLJGAAA>k__BackingField;    // 0x0x10
    public string <NCBKOKBLNEM>k__BackingField;    // 0x0x18
    public List<FLNKIPIPBDA> <GNNNHNAIKGJ>k__BackingField;    // 0x0x20
    public EMKJFMFMJBI <MIOAMCJDKAA>k__BackingField;    // 0x0x28
    public string <JACDNILEDFI>k__BackingField;    // 0x0x30
    public DateTime <BPKIIGPKHFD>k__BackingField;    // 0x0x38
    public DateTime <MAEPAIFBMDH>k__BackingField;    // 0x0x40
    public DateTime <HHAILAPEPNL>k__BackingField;    // 0x0x48
    public bool? <IMPNJHBHCFB>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// LHENKFEENDI
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/checklist/v1/complete   [Service.Econ]
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE POST   api/progressionEvents/collect/{hPBLIGMAEPN}/{aAOOLGELAND}   [Service.API]
public class LHENKFEENDI
{
    public long? <MJPDOLNNJOP>k__BackingField;    // 0x0x10
    public int? <CAFIBNDOAAE>k__BackingField;    // 0x0x20
    public string <HADPGKDOLLN>k__BackingField;    // 0x0x28
    public OENHMLLPCHH? <BIMCIFAIFJP>k__BackingField;    // 0x0x30
    public string <GOILLFHPJAN>k__BackingField;    // 0x0x38
    public string <AJAKCEAJACI>k__BackingField;    // 0x0x40
    public string <MEICHMNDNOL>k__BackingField;    // 0x0x48
    public BBDCGOGIDBF <JPIMNINPJLM>k__BackingField;    // 0x0x50
    public int <IOMJBAJMNKJ>k__BackingField;    // 0x0x54
    public int <EGPDLDEHLMG>k__BackingField;    // 0x0x58
    public BBKGAMBBHKN <MCLHBOGCDGO>k__BackingField;    // 0x0x5C
    public MJBGPLBJDEH <NABNGCJDDEB>k__BackingField;    // 0x0x60
    public string <IGAAKLMELDI>k__BackingField;    // 0x0x68
    public KMGMCOECIOC <KPBLLAIOEBN>k__BackingField;    // 0x0x70
    public AFNJJDACIPH <BHDMFGNJEJK>k__BackingField;    // 0x0x74
    public LINGHGGGFNN? <GDEABHHMIKJ>k__BackingField;    // 0x0x78
    public bool <JDGJMAMBJJM>k__BackingField;    // 0x0x80
    public bool <IAAPEJHMFHG>k__BackingField;    // 0x0x81
    public string <GDJDOIBJKDM>k__BackingField;    // 0x0x88
    public bool <BINPMKHANHM>k__BackingField;    // 0x0x90
    public bool KGNGMNFIAFG;    // 0x0x91
}

// --------------------------------------------------------------------------
// LINGHGGGFNN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LINGHGGGFNN
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
    PlayStationNonPurchasedP2P = 100,
    NonPlayStationNonPurchasedP2P = 101,
    NonPurchasedEarnedByP2P = 1000,
}

// --------------------------------------------------------------------------
// LJGDDFNNJHH
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Auth]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class LJGDDFNNJHH
{
    public int <DPHDIIDAOEB>k__BackingField;    // 0x0x10
    public bool <LLINGJGGCLK>k__BackingField;    // 0x0x14
    public DateTime <MMGCMALPPLL>k__BackingField;    // 0x0x18
    public bool <IFHCHKCKLJH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LKHBDHCDBBD
//   (not directly referenced by a detected call)
public class LKHBDHCDBBD
{
    public int <IIFFBOOEFJF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LPGOFLPOPML
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LPGOFLPOPML
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// MCGLHPLEMCC
//   RESPONSE POST   api/AppIntegrity/v1/iospaymentqueuefailed   [Service.API]
//   RESPONSE POST   api/AppIntegrity/v1/iosproducts   [Service.API]
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
public class MCGLHPLEMCC
{
    public bool <GPKDGAFAKNB>k__BackingField;    // 0x0x10
    public string <BGHKLMCCLMM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MFEBFNMNNPB
//   (not directly referenced by a detected call)
public class MFEBFNMNNPB
{
    public DateTime <FLDGKIFCAFB>k__BackingField;    // 0x0x10
    public string <LGKIKJADEIH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MGGLGPJHPFD
//   REQUEST  ?      api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class MGGLGPJHPFD
{
    public Guid <JIPCJBPFKOD>k__BackingField;    // 0x0x10
    public long <BOFFCCLILHJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MHDFHCLMMBD
//   (not directly referenced by a detected call)
public class MHDFHCLMMBD
{
    public BBDCGOGIDBF <JPIMNINPJLM>k__BackingField;    // 0x0x10
    public int <MJKPAOMNBAA>k__BackingField;    // 0x0x14
    public KPGNNLAJMDF <KOHCBBFLGFD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MJBGPLBJDEH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MJBGPLBJDEH
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// MKGMCMHPDBP
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class MKGMCMHPDBP
{
    public List<HAFKAFIEAFH> <OPNKIOJLGKM>k__BackingField;    // 0x0x10
    public string <JMPFGAGJOAH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MKPKFPPLCAP
// base   : GNHPJDJKDCC
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.Econ]
public class MKPKFPPLCAP : GNHPJDJKDCC
{
    public List<MMLBNGGEPNC> FGIMMJAFFLC;    // 0x0x30
    public int <DFKBPKFDMGB>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// MMLBNGGEPNC
// base   : NGGOIMHEKJF
//   (not directly referenced by a detected call)
public class MMLBNGGEPNC : NGGOIMHEKJF
{
    public KLHLHEAGJEN <OFBEPAMKFLB>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// MPBCODDKEIP
//   RESPONSE ?      api/inventions/   [Service.API]
//   RESPONSE GET    api/inventions/v1/personaldetails/{dPAOADGHCDE}   [Service.API]
public class MPBCODDKEIP
{
    public bool <KAHGJEDBOKK>k__BackingField;    // 0x0x10
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
// NAAGHPNPKIA
// base   : PHHGIMEIMEP`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class NAAGHPNPKIA
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// NCLOKEIHHNB
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class NCLOKEIHHNB
{
    public Dictionary<Guid, CPGFJDEMABN> <DOBJELNEILP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NEHOIHCEPME
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.API]
public class NEHOIHCEPME
{
    public List<string> <IKLOJFADFBI>k__BackingField;    // 0x0x10
    public byte <NAJILMLOADN>k__BackingField;    // 0x0x18
    public int <GGOMCCNDCCM>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// NGGOIMHEKJF
//   (not directly referenced by a detected call)
public class NGGOIMHEKJF
{
    public int <NNKENAFPHAD>k__BackingField;    // 0x0x10
    public HLKEKLAPBKB <AHGNGLCPEBK>k__BackingField;    // 0x0x14
    public List<MHDFHCLMMBD> <HNIJHHGKCLF>k__BackingField;    // 0x0x18
    public List<MHDFHCLMMBD> <IJHOMMNHGLA>k__BackingField;    // 0x0x20
    public bool <MDKFNNNOONG>k__BackingField;    // 0x0x28
    public DateTime? <DMNLKBHJKHB>k__BackingField;    // 0x0x30
    public DateTime? <FFDELMIOLHB>k__BackingField;    // 0x0x40
    public DateTime? <MLHDMIPBPKP>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// NHPGJJEEOFL
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Econ]
public class NHPGJJEEOFL
{
    public Guid <NLMNDFPMJLC>k__BackingField;    // 0x0x10
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x20
    public string <JKNLPGPDJDI>k__BackingField;    // 0x0x28
    public DateTime <BPKIIGPKHFD>k__BackingField;    // 0x0x30
    public DateTime? <HGDLNFKAKGD>k__BackingField;    // 0x0x38
    public List<IDJNNJGPDAG> <MALKGBFPCGC>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// NMOCDEEOHJA
// base   : System.Enum
//   RESPONSE ?      api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{hEMPFGMLDBN}   [Service.Econ]
public enum NMOCDEEOHJA
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
// NPLDJHCJNHB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NPLDJHCJNHB
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// OAILHEPACOB
//   (not directly referenced by a detected call)
public class OAILHEPACOB
{
    public int <NHDBHBCMOJG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OCFDLKAAFFJ
//   (not directly referenced by a detected call)
public class OCFDLKAAFFJ
{
    public int <KFJBMPGHABO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OENHMLLPCHH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OENHMLLPCHH
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// OHFIBNCCNCD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OHFIBNCCNCD
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// OMCBBEDKJFO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OMCBBEDKJFO
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// OMGPPEANKCO
// base   : FGHBCNIEOCC
//   RESPONSE ?      api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.Econ]
public class OMGPPEANKCO : FGHBCNIEOCC
{
    public LPGOFLPOPML? <LIKNBMHNMGD>k__BackingField;    // 0x0x18
    public HJJMKOEDIIK <CEJMPIDPHJB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ONCNLCCNKCE
//   (not directly referenced by a detected call)
public class ONCNLCCNKCE
{
    public bool <BMPBJMLIEJN>k__BackingField;    // 0x0x10
    public KLHLHEAGJEN <OFBEPAMKFLB>k__BackingField;    // 0x0x18
    public float <GMOPPPCBBIB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OOHIBINJBEJ
//   (not directly referenced by a detected call)
public class OOHIBINJBEJ
{
    public HAFKAFIEAFH <CKKHOFJMCHP>k__BackingField;    // 0x0x10
    public EMMCODKMGBP <HPJBKEDGCBK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PLAOLFMCENB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PLAOLFMCENB
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
}

// --------------------------------------------------------------------------
// PNFCNJJFDEF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PNFCNJJFDEF
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
}

// --------------------------------------------------------------------------
// POGGPFLNDKF
//   (not directly referenced by a detected call)
public class POGGPFLNDKF
{
    public FFCFMLODACK DPOLHEEKGMJ;    // 0x0x10
    public int JLFDOFGOFFB;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.API]
public class AddKeepsakeInstanceRequest
{
    public long <NFEIMPKIJCC>k__BackingField;    // 0x0x10
    public long? <BGHANGGMGDC>k__BackingField;    // 0x0x18
    public PEEBFJALEIP <EJPCKBFFCNM>k__BackingField;    // 0x0x28
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
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.API]
public class AppleMusicPromotionResponseDTO
{
    public ICMIIIKMPDA <NALAIGBMDDP>k__BackingField;    // 0x0x10
    public string <JINKNJNMOMF>k__BackingField;    // 0x0x18
    public string <ECEGIFJJKFI>k__BackingField;    // 0x0x20
    public string <KHOBPLBMEBD>k__BackingField;    // 0x0x28
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
// RecNet.Events.BroadcastRoomInstanceRequest
//   (not directly referenced by a detected call)
public class BroadcastRoomInstanceRequest
{
    public long <EOICOHCLHFK>k__BackingField;    // 0x0x10
    public long? <FGLGDEBBNLI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.BulkInviteRequest
//   (not directly referenced by a detected call)
public class BulkInviteRequest
{
    public long PlayerEventId;    // 0x0x10
    public List<int> InvitedPlayerIds;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.DeleteResponseRequest
//   (not directly referenced by a detected call)
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
    public HKKBPLKHGBD FilterType;    // 0x0x20
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
// RecNet.KeepsakeCategoryConfigDTO
//   (not directly referenced by a detected call)
public class KeepsakeCategoryConfigDTO
{
    public PEEBFJALEIP <AOOKJCDNFGD>k__BackingField;    // 0x0x10
    public string <HGBJMONACHH>k__BackingField;    // 0x0x18
    public int <KFCLDBLFDKL>k__BackingField;    // 0x0x20
    public int <EHJGPLNBOCE>k__BackingField;    // 0x0x24
    public string <DEIADMIOCIH>k__BackingField;    // 0x0x28
    public string <MADKGEFJMKA>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <MJGFOGHKDFN>k__BackingField;    // 0x0x10
    public Guid <IMLNIEBNFBH>k__BackingField;    // 0x0x14
    public DateTime <POPOOFIGFII>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <BMMCNBKJMBE>k__BackingField;    // 0x0x10
    public int <GADIGIAPIGO>k__BackingField;    // 0x0x14
    public bool <HPPIAMCJPOB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <IMLNIEBNFBH>k__BackingField;    // 0x0x10
    public PEEBFJALEIP <JIOPGHJCGPD>k__BackingField;    // 0x0x20
    public int <BKNFDJOBONM>k__BackingField;    // 0x0x24
    public long <NFEIMPKIJCC>k__BackingField;    // 0x0x28
    public long? <BGHANGGMGDC>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{dHCCPMNANKD}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <LGBEKBJJBNM>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <LCBCOOHHIOE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <EEFMPNIBDFD>k__BackingField;    // 0x0x10
    public long <NFEIMPKIJCC>k__BackingField;    // 0x0x18
    public long <FKKAJLOHFKC>k__BackingField;    // 0x0x20
    public HMAHLINEMOD <AHGNGLCPEBK>k__BackingField;    // 0x0x28
    public int <IGEMOOLNAJL>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <NFEIMPKIJCC>k__BackingField;    // 0x0x10
    public List<Guid> <HHGBKIKNHMO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <LGBEKBJJBNM>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <LCBCOOHHIOE>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <FILMBHHGABG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <FKKAJLOHFKC>k__BackingField;    // 0x0x10
    public long <NBGIPHIBBPP>k__BackingField;    // 0x0x18
    public int? <CPKALNMIDNC>k__BackingField;    // 0x0x20
    public int? <DAEGNFJGLDA>k__BackingField;    // 0x0x28
    public long? <PGPDIJBCELP>k__BackingField;    // 0x0x30
    public long <AJHDNJKKCIF>k__BackingField;    // 0x0x40
    public long <BJCLHGICHEE>k__BackingField;    // 0x0x48
    public int <JAPGBIGNNBH>k__BackingField;    // 0x0x50
    public HMAHLINEMOD <OPIIDAGALCB>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <IPDBEBFIODM>k__BackingField;    // 0x0x58
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
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.Econ]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public BBKGAMBBHKN <GiftContext>k__BackingField;    // 0x0x20
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
    public NKNIPGBFGFH creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public JNCEPDLNBDG <LCIJNNGHAOI>k__BackingField;    // 0x0x10
    public JIKLAAACHCF <LKDJLFMNFJP>k__BackingField;    // 0x0x14
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x18
    public string <OOIMOLDEOAB>k__BackingField;    // 0x0x20
    public bool <DHNFJLNFLHM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<JNCEPDLNBDG> <GDMNMLOLOMH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{hPBLIGMAEPN}   [Service.API]
public class ProgressionEventDTO
{
    public long <NBGIPHIBBPP>k__BackingField;    // 0x0x10
    public string <ADNLPKNEPDO>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <EMFMNBMIFHJ>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <LFLCBMPFGGA>k__BackingField;    // 0x0x28
    public DateTime <NFLDNALPMDM>k__BackingField;    // 0x0x30
    public DateTime <JDCLDPCOPKI>k__BackingField;    // 0x0x38
    public DateTime <DPGPJIBLGGP>k__BackingField;    // 0x0x40
    public bool <KLCHBBDKOIC>k__BackingField;    // 0x0x48
    public int <GFNPEJIFOCM>k__BackingField;    // 0x0x4C
    public float <EAGBFEIHEGG>k__BackingField;    // 0x0x50
    public Guid? <DCEOKPBOKHM>k__BackingField;    // 0x0x54
    public string <EPGHLBFJCLE>k__BackingField;    // 0x0x68
    public string <HAENNPAIKKH>k__BackingField;    // 0x0x70
    public string <KJKBKIJPDBE>k__BackingField;    // 0x0x78
    public string <HJDHBGKAAPF>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <AGFGENEAOME>k__BackingField;    // 0x0x10
    public int <EEKMEBKOHAO>k__BackingField;    // 0x0x20
    public int <KEMAJOHDJEC>k__BackingField;    // 0x0x24
    public int <JGGLCLKHDAB>k__BackingField;    // 0x0x28
    public long <HONANLBGMEG>k__BackingField;    // 0x0x30
    public long <EKLKLLJLKDH>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <MJGFOGHKDFN>k__BackingField;    // 0x0x10
    public int <EGPDLDEHLMG>k__BackingField;    // 0x0x14
    public int <JJNPBCGOHAE>k__BackingField;    // 0x0x18
    public int <PNOLMOJKDOA>k__BackingField;    // 0x0x1C
    public int <EBBPKEKNNFG>k__BackingField;    // 0x0x20
    public DateTime? <JPGKOJLFIAO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <MFKJIOPEDIA>k__BackingField;    // 0x0x10
    public int <PONDFBAPKAB>k__BackingField;    // 0x0x18
    public string <JKNLPGPDJDI>k__BackingField;    // 0x0x20
    public int <EGPDLDEHLMG>k__BackingField;    // 0x0x28
    public int <NJDOBMEKEBD>k__BackingField;    // 0x0x2C
    public bool <LLEBMCMPCFM>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public OFPCELEGACD ReportCategory;    // 0x0x20
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
// RecRoom.Debugging.AutocompleteResult
// base   : UnityEngine.MonoBehaviour
//   (not directly referenced by a detected call)
public class AutocompleteResult : MonoBehaviour
{
    public RawImage backgroundImage;    // 0x0x18
    public TMP_Text text;    // 0x0x20
    public bool DENGAJGOPBD;    // 0x0x28
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

// api/CampusCard/v1/UpdateAndGetSubscription  [Econ POST]
public class CampusCardV1UpdateAndGetSubscriptionRequest
{
    public string accessToken;  // wrapper
}

// api/PlayerCheer/v1/SetSelectedCheer  [API POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public BEPNGEEHBKK? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public BEPNGEEHBKK FHBJCIMBBBK;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public KMGMCOECIOC OIBFCMLLNEK;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public FIFDCJLPHIG AOPDMLJGEMB;  // wrapper
    public int? FOJDALLDMPL;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/moderationBlockDetails  [API POST]
public class PlayerReportingV1ModerationBlockDetailsRequest
{
    public string deviceToken;  // wrapper
}

// api/PlayerReporting/v3/create  [API POST]
public class PlayerReportingV3CreateRequest
{
    public INAINIEOHOI DMDBAADDNKL;  // wrapper
    public float? IDHIKLOAMAM;  // wrapper
    public object ReportCategory;  // candidate
    public object HeightReporter;  // candidate
    public object RoomInstanceType;  // candidate
    public object RoomId;  // candidate
    public object HeightReported;  // candidate
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
    public List<CDEIEAKMFDI> desc;  // wrapper
}

// api/avatar/v2/gifts/consume/  [Econ POST]
public class AvatarV2GiftsConsumeRequest
{
    public LHENKFEENDI UnlockedLevel;  // wrapper
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public BBKGAMBBHKN GMIADHJEACD;  // wrapper
    public BBKGAMBBHKN? FNEBMFNGFMM;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public BBKGAMBBHKN GMIADHJEACD;  // wrapper
    public BBKGAMBBHKN? FNEBMFNGFMM;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [Econ POST]
public class ChallengeV2UpdateProgressRequest
{
    public FLNKIPIPBDA MNLKLFKHCPM;  // wrapper
    public object UpdateChallengeProgress;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object ChallengeMapId;  // candidate
    public object Complete;  // candidate
}

// api/chatreport/createChatReport  [API POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage KHIFMDJDLEG;  // wrapper
    public AHBKMPBIOLN DMDBAADDNKL;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public INAINIEOHOI DMDBAADDNKL;  // wrapper
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
    public OMCBBEDKJFO EHEDOCEMDFG;  // wrapper
    public KHOHHMLBLPA EFEPADFHCGD;  // wrapper
    public byte[] KNLAGKCFFFH;  // wrapper
    public byte[] COINNFBIJFO;  // wrapper
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

// api/customAvatarItems/v1/me  [API GET]
public class CustomAvatarItemsV1MeRequest
{
    public object take;  // candidate
    public object skip;  // candidate
}

// api/customAvatarItems/v1/search  [API GET]
public class CustomAvatarItemsV1SearchRequest
{
    public object minPrice;  // candidate
    public object isOwned;  // candidate
    public object itemTypes;  // candidate
    public object isFeatured;  // candidate
    public object creatorUsername;  // candidate
}

// api/equipment/v1/update  [Econ POST]
public class EquipmentV1UpdateRequest
{
    public List<BEPLHKBCIDC> CCDJCPKGCMK;  // wrapper
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
    public OCEDOMCFIDM FOHEABEHDDI;  // wrapper
    public BBKGAMBBHKN? MELFPMCJLFM;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public PJFHEJCIFPC KECDFLBHIMO;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/images/v4/room/{roomId}  [API GET]
public class ImagesV4RoomRoomIdRequest
{
    public object filter;  // candidate
    public object sort;  // candidate
    public object take;  // candidate
    public object skip;  // candidate
}

// api/images/v5/bulk  [API GET]
public class ImagesV5BulkRequest
{
    public List<long> ids;  // query
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

// api/inventions/v1/delete  [API GET]
public class InventionsV1DeleteRequest
{
    public CFGMFOCDPBB inventionId;  // wrapper
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

// api/inventions/v1/unpublish  [API GET]
public class InventionsV1UnpublishRequest
{
    public long inventionId;  // wrapper
}

// api/inventions/v1/update  [API GET]
public class InventionsV1UpdateRequest
{
    public object name;  // candidate
    public object inventionId;  // candidate
    public object description;  // candidate
    public object imgName;  // candidate
    public object permission;  // candidate
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
    public object take;  // candidate
    public object skip;  // candidate
}

// api/inventions/v3/publish  [API GET]
public class InventionsV3PublishRequest
{
    public object price;  // candidate
    public object accessibility;  // candidate
    public object permissionLevel;  // candidate
    public object inventionId;  // candidate
}

// api/keepsakes/{kJOKGMJIJOB}/collect  [API POST]
public class KeepsakesKJOKGMJIJOBCollectRequest
{
    public Guid KJOKGMJIJOB;  // wrapper
}

// api/messages/v1/sendMultiple  [API POST]
public class MessagesV1SendMultipleRequest
{
    public List<long> BOLNJBMMKDP;  // wrapper
    public OCAMMGKPLCN MONGHLBAOFH;  // wrapper
    public long? GCFELHFPIGG;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
    public object SendMessageMultiple;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public OCAMMGKPLCN MONGHLBAOFH;  // wrapper
    public long? GCFELHFPIGG;  // wrapper
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

// api/playerevents/v1/broadcast  [API POST]
public class PlayereventsV1BroadcastRequest
{
    public long? MNIACFNNHGG;  // wrapper
}

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/bulkInvite  [API POST]
public class PlayereventsV1BulkInviteRequest
{
    public List<int> BOLNJBMMKDP;  // wrapper
}

// api/playerevents/v1/deleteResponse  [API POST]
public class PlayereventsV1DeleteResponseRequest
{
    public KOBBGPLDGCI KLOMBCLIHMA;  // wrapper
}

// api/playerevents/v1/report  [API POST]
public class PlayereventsV1ReportRequest
{
    public INAINIEOHOI DMDBAADDNKL;  // wrapper
}

// api/playerevents/v1/respond  [API POST]
public class PlayereventsV1RespondRequest
{
    public KOBBGPLDGCI KLOMBCLIHMA;  // wrapper
}

// api/playerevents/v2  [API POST]
public class PlayereventsV2Request
{
    public long? PDNAFDGOEDL;  // wrapper
    public long? GEFCKAGBBHM;  // wrapper
    public List<string> LDABNMIJELK;  // wrapper
    public DateTime EFJGLOOEAKI;  // wrapper
    public DateTime NPGFKNGHGKM;  // wrapper
    public HPMHJOKIIEK EHEDOCEMDFG;  // wrapper
    public GJCBBLNCAFE GCFADCJJIMH;  // wrapper
    public GJCBBLNCAFE ANJMFFAIHCD;  // wrapper
}

// api/playerevents/v2/{eventId}  [API POST]
public class PlayereventsV2EventIdRequest
{
    public long? PDNAFDGOEDL;  // wrapper
    public List<string> LDABNMIJELK;  // wrapper
    public DateTime EFJGLOOEAKI;  // wrapper
    public DateTime NPGFKNGHGKM;  // wrapper
    public HPMHJOKIIEK EHEDOCEMDFG;  // wrapper
    public long? GEFCKAGBBHM;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public HPMHJOKIIEK EHEDOCEMDFG;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? GEFCKAGBBHM;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public GJCBBLNCAFE GCFADCJJIMH;  // wrapper
    public GJCBBLNCAFE GODPNFEEHHG;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? PDNAFDGOEDL;  // wrapper
}

// api/playerevents/v2/{eventId}/tags  [API PUT]
public class PlayereventsV2EventIdTagsRequest
{
    public List<string> LDABNMIJELK;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime EFJGLOOEAKI;  // wrapper
    public DateTime NPGFKNGHGKM;  // wrapper
}

// api/playerwarnings  [API POST]
public class PlayerwarningsRequest
{
    public INAINIEOHOI DMDBAADDNKL;  // wrapper
    public object ModeratorNote;  // candidate
    public object WarnedPlayerId;  // candidate
    public object ReportCategory;  // candidate
    public object DisplayReason;  // candidate
}

// api/relationships/v1/addfriendwithcode  [API GET]
public class RelationshipsV1AddfriendwithcodeRequest
{
    public object code;  // candidate
}

// api/roomCurrencies/v2/purchase  [Econ POST]
public class RoomCurrenciesV2PurchaseRequest
{
    public Guid DDICAHELNGO;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency  [Econ PUT]
public class RoomconsumablesV1RoomconsumableRoomconsumableIdPurchaseCurrencyRequest
{
    public Guid LIEAGBEBBMP;  // wrapper
    public Guid ONLBDNACDNF;  // wrapper
    public Guid? DDJNOEAOEFN;  // wrapper
}

// api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens  [Econ PUT]
public class RoomconsumablesV1RoomconsumableRoomconsumableIdPurchaseTokensRequest
{
    public Guid LIEAGBEBBMP;  // wrapper
    public Guid? DDJNOEAOEFN;  // wrapper
}

// api/roomcurrencies/v1/awardCurrency/bulk  [Econ POST]
public class RoomcurrenciesV1AwardCurrencyBulkRequest
{
    public List<GABMDAAKFFN> IEHGNCMIBBK;  // wrapper
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
    public Guid NHLAGDLIBLD;  // wrapper
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
    public Guid NHLAGDLIBLD;  // wrapper
    public long? OLFMIPKCOEL;  // wrapper
    public byte? GJPMODOJLLG;  // wrapper
    public int? HBLLOHAOGDJ;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid DDICAHELNGO;  // wrapper
    public long? AIGOHFJGHLB;  // wrapper
    public long? CGIIKGHBKIM;  // wrapper
    public int? HDDJMINMJCP;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> CNCKHACNADC;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/awardbulk  [Econ POST]
public class RoomkeysV1AwardbulkRequest
{
    public IEnumerable<ECBEMADPNHL> HIGEGKDOJKM;  // wrapper
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public ECBKGPPBJCE AOPDMLJGEMB;  // wrapper
    public Guid? LPHMCABCBPI;  // wrapper
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
    public INAINIEOHOI DMDBAADDNKL;  // wrapper
    public long? OBOHKPMOPFL;  // wrapper
    public object ReportCategory;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
    public object Details;  // candidate
}

// api/royale/v2/matchcomplete  [Econ POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats KOJKGNIHIFK;  // wrapper
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
    public Guid NOHCMGBPCLM;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid LLGIJNBOAEN;  // wrapper
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

// api/storefronts/v1/objectives  [Econ POST]
public class StorefrontsV1ObjectivesRequest
{
    public List<PBGLHMCFEMH> JJLCOJFPDFE;  // wrapper
    public object roomId;  // candidate
    public object CompleteObjectives;  // candidate
    public object objectiveType;  // candidate
    public object completionPercentage;  // candidate
}

// api/storefronts/v1/trialInvention  [Econ POST]
public class StorefrontsV1TrialInventionRequest
{
    public long inventionId;  // wrapper
}

// api/storefronts/v2/buyInvention  [Econ GET]
public class StorefrontsV2BuyInventionRequest
{
    public object requestedPrice;  // candidate
    public object inventionId;  // candidate
}

// api/testcasemanagement/v1/testcase/  [API POST]
public class TestcasemanagementV1TestcaseRequest
{
    public AAEGOCBAFNM APDDGFBOOML;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

