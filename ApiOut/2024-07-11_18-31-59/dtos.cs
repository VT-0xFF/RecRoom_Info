// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 206 (plus referenced enums)

// --------------------------------------------------------------------------
// AALMJOBMIPJ
//   (not directly referenced by a detected call)
public class AALMJOBMIPJ
{
    public float <KKGKEONLMFB>k__BackingField;    // 0x0x10
    public float <IELCGDPINKE>k__BackingField;    // 0x0x14
    public float <IFMJEFLOKIA>k__BackingField;    // 0x0x18
    public float <BPDGCKFGCHD>k__BackingField;    // 0x0x1C
    public float <DNMDPJGBBJD>k__BackingField;    // 0x0x20
    public float <FHAKBMLAEBM>k__BackingField;    // 0x0x24
    public float <GKLAPCPCIGP>k__BackingField;    // 0x0x28
    public float <EBJIOOKIFLO>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// AEEOHJFPGHI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AEEOHJFPGHI
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// AHPCJNKBNPH
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.WWW]
public class AHPCJNKBNPH
{
    public int <DPJHIOICIDL>k__BackingField;    // 0x0x10
    public bool <OMCOHBPCKAK>k__BackingField;    // 0x0x14
    public DateTime <FJCKNANLDLN>k__BackingField;    // 0x0x18
    public bool <AOFIBOOKOHN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ANEIEMAHBCO
//   (not directly referenced by a detected call)
public class ANEIEMAHBCO
{
    public long <PDBAABCODGP>k__BackingField;    // 0x0x10
    public string <MBCCEGENNEP>k__BackingField;    // 0x0x18
    public int <JKPBBCOHGFC>k__BackingField;    // 0x0x20
    public bool <LHBCMLBMKML>k__BackingField;    // 0x0x24
    public int <IENPFAGICGO>k__BackingField;    // 0x0x28
    public int <NGPJEIMMINC>k__BackingField;    // 0x0x2C
    public int <KCOFFNNNEOC>k__BackingField;    // 0x0x30
    public int <AOCNCPANEKF>k__BackingField;    // 0x0x34
    public string <MNCOKPCOCDP>k__BackingField;    // 0x0x38
    public string <HCDDMPBFECD>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// APCFJPLHMMO
//   (not directly referenced by a detected call)
public class APCFJPLHMMO
{
    public float <CCPALDNODHL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// APEMDKFCPLH
//   (not directly referenced by a detected call)
public class APEMDKFCPLH
{
    public FKMOANNDEEK <GBKMEELNIGO>k__BackingField;    // 0x0x10
    public LAILOABODEC <JLMIBKEOJOG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BBJECOAEEOC
//   (not directly referenced by a detected call)
public class BBJECOAEEOC
{
    public int <AFDJHDEGDAJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BCKBMHHNEBO
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.WWW]
public class BCKBMHHNEBO
{
    public long <GFOAIHMBAEK>k__BackingField;    // 0x0x10
    public int <PNIKECMOIDM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BINAPHKDMDH
// base   : System.Enum
//   RESPONSE ?      api/roomkeys/   [Service.Data]
//   RESPONSE DELETE api/roomkeys/v1/delete/{jOEIBFAMFNN}   [Service.WWW]
public enum BINAPHKDMDH
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
// BLIMEGFFKGL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BLIMEGFFKGL
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
// BMIGJJELFIJ
// base   : FKMOANNDEEK
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class BMIGJJELFIJ : FKMOANNDEEK
{
    public List<EGNAMJHMFHN> <KMFCBFAGNAD>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// BNIEKOGPCIE
//   RESPONSE PUT    api/roomkeys/v1/   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class BNIEKOGPCIE
{
    public BINAPHKDMDH <BPKEIMDMMIC>k__BackingField;    // 0x0x10
    public CBLNGHKHMAN <ABOBJFOPCID>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BODJDCEKNHO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BODJDCEKNHO
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// BPKLFKMICDO
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.Auth]
public class BPKLFKMICDO
{
    public List<long> <GJEHOMPDABK>k__BackingField;    // 0x0x10
    public GPPPHMEDNAN <LNGMKEFHECE>k__BackingField;    // 0x0x18
    public string <INFMNHPEEEG>k__BackingField;    // 0x0x20
    public long? <IIDNOMKGICC>k__BackingField;    // 0x0x28
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
    public Stream Stream;    // 0x0x80
    public List<ValueTuple<byte[], int>> streamedFragments;    // 0x0x88
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
// CBLNGHKHMAN
//   (not directly referenced by a detected call)
public class CBLNGHKHMAN
{
    public long <GFOAIHMBAEK>k__BackingField;    // 0x0x10
    public Guid <MBCCEGENNEP>k__BackingField;    // 0x0x18
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x28
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x30
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x38
    public int <MNLOPPJFJPO>k__BackingField;    // 0x0x40
    public Guid? <EHLFOMCLJFL>k__BackingField;    // 0x0x44
    public DateTime <OIDMNCMICHH>k__BackingField;    // 0x0x58
    public string <JEOIMEHHHNK>k__BackingField;    // 0x0x60
    public JLLCNGEGFCG <LNGMKEFHECE>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// CBPFOPLNNJF
//   RESPONSE GET    api/config/v2   [Service.Auth]
public class CBPFOPLNNJF
{
    public Dictionary<int, int> <GFBLEJCJBNH>k__BackingField;    // 0x0x10
    public List<LPLJHCBJOOH> <KPBLDICFNKF>k__BackingField;    // 0x0x18
    public PIMJDOEGGFN[][] <CPKOJKLGFJD>k__BackingField;    // 0x0x20
    public CDJOKDIOKLK <DNCOLGECLLM>k__BackingField;    // 0x0x28
    public AALMJOBMIPJ <GCCNGLAIICF>k__BackingField;    // 0x0x30
    public FCKALIOBAHE <IBEPALLOONL>k__BackingField;    // 0x0x38
    public BBJECOAEEOC <LOJNIGMPOAE>k__BackingField;    // 0x0x40
    public APCFJPLHMMO <HDFCDJKIKEN>k__BackingField;    // 0x0x48
    public string <JBPDGPLOEKP>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// CDJOKDIOKLK
//   (not directly referenced by a detected call)
public class CDJOKDIOKLK
{
    public int <NMJHKNOAFLK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// CGIBJJFIKKL
//   (not directly referenced by a detected call)
public class CGIBJJFIKKL
{
    public int <NCGNLPMFMEB>k__BackingField;    // 0x0x10
    public DateTime <OIDMNCMICHH>k__BackingField;    // 0x0x18
    public DateTime? <NCHJAKOKDHN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CHCDOAPJJGH
//   REQUEST  POST   api/playerevents/v2   [Service.Auth]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.Auth]
public class CHCDOAPJJGH
{
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x10
    public long? <JCAIMEGABDO>k__BackingField;    // 0x0x18
    public long? <NAENNANJNLP>k__BackingField;    // 0x0x28
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x38
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x40
    public List<string> <KMFCBFAGNAD>k__BackingField;    // 0x0x48
    public string <JEOIMEHHHNK>k__BackingField;    // 0x0x50
    public DateTime <NENCNGOOPBI>k__BackingField;    // 0x0x58
    public DateTime <EJDOHJOLDKI>k__BackingField;    // 0x0x60
    public MPPOCPMAGFJ <ONHJJFJABJK>k__BackingField;    // 0x0x68
    public bool <LINBHLLOHGD>k__BackingField;    // 0x0x6C
    public bool <IPDMNCCNHMJ>k__BackingField;    // 0x0x6D
    public BODJDCEKNHO <BIPIMFHNAHO>k__BackingField;    // 0x0x70
    public BODJDCEKNHO <KGMILEOMMHD>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// CNDCELANJKM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CNDCELANJKM
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
// CNLGBMLNJMO
//   (not directly referenced by a detected call)
public class CNLGBMLNJMO
{
    public int <LECDEFJACFG>k__BackingField;    // 0x0x10
    public DateTime? <IEELFMCFEBD>k__BackingField;    // 0x0x18
    public DateTime? <OFIHBPNKFAG>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// COGBIDCIEPE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum COGBIDCIEPE
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
// CPJLGIBAOJC
//   (not directly referenced by a detected call)
public class CPJLGIBAOJC
{
    public int <IKNDONOEDEP>k__BackingField;    // 0x0x10
    public string <IHMKMKEMPGC>k__BackingField;    // 0x0x18
    public string <ACBODIIMDPF>k__BackingField;    // 0x0x20
    public string <NHFDKIMLEKH>k__BackingField;    // 0x0x28
    public string <JEBNLJIBJCL>k__BackingField;    // 0x0x30
    public string <HGPELOMMODC>k__BackingField;    // 0x0x38
    public Guid? <HFPLCOMGHEC>k__BackingField;    // 0x0x40
    public MDEGNDGEEHE? <NOPOKGDMPJJ>k__BackingField;    // 0x0x54
    public string <HGJFEALAHNN>k__BackingField;    // 0x0x60
    public string <KGMAKLCKBNM>k__BackingField;    // 0x0x68
    public bool <MNBNICMCEIA>k__BackingField;    // 0x0x70
    public bool <DEEDJNDBIME>k__BackingField;    // 0x0x71
    public bool <EFKMMCNCMPJ>k__BackingField;    // 0x0x72
    public MGOIIGNJJJA <NEHNJCPGFEL>k__BackingField;    // 0x0x74
    public OGPIJPOPLHA <LFANLNNCJEL>k__BackingField;    // 0x0x78
    public int <BIJFGIHPHNJ>k__BackingField;    // 0x0x7C
    public CNDCELANJKM <HEEIKNGJLEH>k__BackingField;    // 0x0x80
    public BLIMEGFFKGL <CKKNNJNMFKH>k__BackingField;    // 0x0x84
    public int? <LDGNAEIOGMI>k__BackingField;    // 0x0x88
    public string <BNBDMDHFAKP>k__BackingField;    // 0x0x90
    public int? <AEHCGNPAAOA>k__BackingField;    // 0x0x98
    public int? <KKLNDPBLKNA>k__BackingField;    // 0x0xA0
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
// DACJMDOMDEJ
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.Auth]
public class DACJMDOMDEJ
{
    public string <CEIMFEJNMAO>k__BackingField;    // 0x0x10
    public string <JDLAELAGCDB>k__BackingField;    // 0x0x18
    public string <ILNBFEHBLAB>k__BackingField;    // 0x0x20
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x28
    public string <KFHBOOMNFGM>k__BackingField;    // 0x0x30
    public FGJKMPCODMO <BPKEIMDMMIC>k__BackingField;    // 0x0x38
    public List<string> <ANPKEALBOGD>k__BackingField;    // 0x0x40
    public List<string> <KMFCBFAGNAD>k__BackingField;    // 0x0x48
    public string <CLMJMPIIFFC>k__BackingField;    // 0x0x50
    public List<KFGDGDKPFIH> <ELCOOJIEBMI>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// DAEHOLMELEO
//   RESPONSE DELETE api/roomconsumables   [Service.WWW]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{pFGFNDDLGMB}   [Service.WWW]
public class DAEHOLMELEO
{
    public PGDNLCGDKJL <BPKEIMDMMIC>k__BackingField;    // 0x0x10
    public PJMGMAFJIKF <OJBJALDDOCJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DAHDLPLEOAD
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.WWW]
public class DAHDLPLEOAD
{
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <LFAJIENJLGL>k__BackingField;    // 0x0x18
    public AEEOHJFPGHI <NFECEPOOEBP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DFHAEEPEILL
//   (not directly referenced by a detected call)
public class DFHAEEPEILL
{
    public long <IDLFPLPCKKN>k__BackingField;    // 0x0x10
    public Guid <HFPLCOMGHEC>k__BackingField;    // 0x0x18
    public Guid <OEOHCMHDOJA>k__BackingField;    // 0x0x28
    public DateTime <OIDMNCMICHH>k__BackingField;    // 0x0x38
    public string <PCHHEHLDOLA>k__BackingField;    // 0x0x40
    public string <NNECNBBEKDI>k__BackingField;    // 0x0x48
    public int <PAEKIACIPIC>k__BackingField;    // 0x0x50
    public string <DNFFHKAEFBM>k__BackingField;    // 0x0x58
    public string <HLPLJKGGOJA>k__BackingField;    // 0x0x60
    public string <JCKIDGBEOMG>k__BackingField;    // 0x0x68
    public string <OAALJHEMEKB>k__BackingField;    // 0x0x70
    public int <HOMJOCMADGO>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// DGKJPFBPONJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DGKJPFBPONJ
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
// DHOHNLLBAIP
// base   : HCBEMHFAHOC`1<LFDCJCJMMGM>
//   RESPONSE GET    api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{iLEJEKADFIP}   [Service.Auth]
public class DHOHNLLBAIP
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// DIILELOFPNH
// base   : HCBEMHFAHOC`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.Auth]
public class DIILELOFPNH
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// DJFCCOILADO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DJFCCOILADO
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
// DKMFIBMILMB
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.Auth]
public class DKMFIBMILMB
{
    public LKGPFPDDLFD <GLBLPBBFMGO>k__BackingField;    // 0x0x10
    public int <EDEDPOOCOBE>k__BackingField;    // 0x0x14
    public long <EMMEJNNAPME>k__BackingField;    // 0x0x18
    public bool <CCOMPNOJBBK>k__BackingField;    // 0x0x20
    public string <OBBENIEDFGE>k__BackingField;    // 0x0x28
    public int? <KOFEHACMJJA>k__BackingField;    // 0x0x30
    public bool <KKFHENEFFEF>k__BackingField;    // 0x0x38
    public bool <HMKJMPGNFHM>k__BackingField;    // 0x0x39
    public bool <NBGDFHICFDG>k__BackingField;    // 0x0x3A
    public bool <KGCCDICGKNO>k__BackingField;    // 0x0x3B
    public string <KDDHIKMECFM>k__BackingField;    // 0x0x40
    public DateTime? <FNFCILBLEEE>k__BackingField;    // 0x0x48
    public string <HAAAJDKFOIE>k__BackingField;    // 0x0x58
    public float <CANCCKEDDJP>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// DLHGNGIGEIP
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.Auth]
public class DLHGNGIGEIP
{
    public List<FKMOANNDEEK> <GHIALDEDIII>k__BackingField;    // 0x0x10
    public string <CFKFDHHGNGG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DOBNMPDBEEO
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.WWW]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
//   RESPONSE GET    api/avatar/v4/items   [Service.WWW]
public class DOBNMPDBEEO
{
    public MDEGNDGEEHE <NOPOKGDMPJJ>k__BackingField;    // 0x0x10
    public string <AOINIJPDIHP>k__BackingField;    // 0x0x18
    public string <IHMKMKEMPGC>k__BackingField;    // 0x0x20
    public string <ACBODIIMDPF>k__BackingField;    // 0x0x28
    public MGOIIGNJJJA <NEHNJCPGFEL>k__BackingField;    // 0x0x30
    public string <NHFDKIMLEKH>k__BackingField;    // 0x0x38
    public int <AEHCGNPAAOA>k__BackingField;    // 0x0x40
    public bool <GNDDFJNIAMJ>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// DOEBKCODFED
//   RESPONSE GET    api/inventions/v1/details   [Service.Auth]
public class DOEBKCODFED
{
    public List<EGNAMJHMFHN> <KMFCBFAGNAD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DPIECNOCOJC
//   REQUEST  POST   api/equipment/v1/update   [Service.WWW]
public class DPIECNOCOJC
{
    public string <KOAKIBCBDFM>k__BackingField;    // 0x0x10
    public string <OLFKADJBAGB>k__BackingField;    // 0x0x18
    public string <IHMKMKEMPGC>k__BackingField;    // 0x0x20
    public string <ACBODIIMDPF>k__BackingField;    // 0x0x28
    public MGOIIGNJJJA <NEHNJCPGFEL>k__BackingField;    // 0x0x30
    public bool FPLEFDFGNDA;    // 0x0x34
    public bool <DANGPPPMHKJ>k__BackingField;    // 0x0x35
}

// --------------------------------------------------------------------------
// EBFMDPONOMB
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.WWW]
public class EBFMDPONOMB
{
    public int <PNIKECMOIDM>k__BackingField;    // 0x0x10
    public Guid <PNHNPFFJNOG>k__BackingField;    // 0x0x14
    public long <LHCFGEEFAHO>k__BackingField;    // 0x0x28
    public DateTime <DMJIMMFAPOO>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// ECLBAGLGLAG
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
public class ECLBAGLGLAG
{
    public Guid? <MHFOHIEDMDI>k__BackingField;    // 0x0x10
    public long? <IIDNOMKGICC>k__BackingField;    // 0x0x28
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x38
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x40
    public string <JEOIMEHHHNK>k__BackingField;    // 0x0x48
    public IBDOMFAIAFD <CLJOALIGBDH>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// EFGAEBEMMKJ
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.WWW]
public class EFGAEBEMMKJ
{
    public int BMKBFHAKCHE;    // 0x0x10
    public long ADBBBOMBOJM;    // 0x0x18
}

// --------------------------------------------------------------------------
// EFNAJMHBBKL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EFNAJMHBBKL
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// EGINBCLBFJE
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.WWW]
public class EGINBCLBFJE
{
    public int <EDEDPOOCOBE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// EGNAMJHMFHN
//   (not directly referenced by a detected call)
public class EGNAMJHMFHN
{
    public string <ICADHCBDAEB>k__BackingField;    // 0x0x10
    public GCPNLFIHOFJ <LNGMKEFHECE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EJEJBJGIDBC
//   RESPONSE GET    api/config/v1/azurespeech   [Service.Auth]
public class EJEJBJGIDBC
{
    public bool <KKGGBDJHJCJ>k__BackingField;    // 0x0x10
    public string <JDLAELAGCDB>k__BackingField;    // 0x0x18
    public string <PMPNFFIKEKH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EJKEMFNHONH
//   (not directly referenced by a detected call)
public class EJKEMFNHONH
{
    public int <MCJALNEJGNH>k__BackingField;    // 0x0x10
    public LHJIJNLOBIC <LNGMKEFHECE>k__BackingField;    // 0x0x14
    public List<MCLIMAIHBJG> <HOELIFCHDMN>k__BackingField;    // 0x0x18
    public List<MCLIMAIHBJG> <CIEIEKLEPKA>k__BackingField;    // 0x0x20
    public bool <AFAEBOJHNIK>k__BackingField;    // 0x0x28
    public DateTime? <BIBAOALGNNA>k__BackingField;    // 0x0x30
    public DateTime? <GCOBAPLMELJ>k__BackingField;    // 0x0x40
    public DateTime? <FPBDLBLEEAG>k__BackingField;    // 0x0x50
    public bool <JDKAADCEBDF>k__BackingField;    // 0x0x60
    public bool <FGBINOGKNMA>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// EKFIHDOGOOH
//   REQUEST  POST   api/playerevents/v1/report   [Service.Auth]
public class EKFIHDOGOOH
{
    public LKGPFPDDLFD <GLBLPBBFMGO>k__BackingField;    // 0x0x10
    public long <LKPMKOHGADB>k__BackingField;    // 0x0x18
    public string <ADLBKGIJPGD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EKHHMOPPNMC
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.WWW]
public class EKHHMOPPNMC
{
    public List<CGIBJJFIKKL> <EFBBBPECIGB>k__BackingField;    // 0x0x10
    public string <CFKFDHHGNGG>k__BackingField;    // 0x0x18
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
// FCKALIOBAHE
//   (not directly referenced by a detected call)
public class FCKALIOBAHE
{
    public int <FNOJMALAACL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FCLEEMHCNOG
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems/v2   [Service.Notifications]
public class FCLEEMHCNOG
{
    public byte <FLNEANEFPHM>k__BackingField;    // 0x0x10
    public int <OGENMPDIHGP>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// FGJKMPCODMO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FGJKMPCODMO
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// FJJBLCBJAJI
// base   : HJDHAADMMLI
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class FJJBLCBJAJI : HJDHAADMMLI
{
    public POKPKFKEHKB? <EBADKLIHJIO>k__BackingField;    // 0x0x18
    public EBFMDPONOMB <GJFEJNEMAEG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FJPCHFBICEF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FJPCHFBICEF
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
// FKMOANNDEEK
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class FKMOANNDEEK
{
    public long <LKPMKOHGADB>k__BackingField;    // 0x0x10
    public int <JKBJHFFDMOO>k__BackingField;    // 0x0x18
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x20
    public long? <JCAIMEGABDO>k__BackingField;    // 0x0x28
    public long? <NAENNANJNLP>k__BackingField;    // 0x0x38
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x48
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x50
    public string <JEOIMEHHHNK>k__BackingField;    // 0x0x58
    public DateTime <NENCNGOOPBI>k__BackingField;    // 0x0x60
    public DateTime <EJDOHJOLDKI>k__BackingField;    // 0x0x68
    public int <NCBFFPOIEDC>k__BackingField;    // 0x0x70
    public MPPOCPMAGFJ <ONHJJFJABJK>k__BackingField;    // 0x0x74
    public bool <LINBHLLOHGD>k__BackingField;    // 0x0x78
    public bool <IPDMNCCNHMJ>k__BackingField;    // 0x0x79
    public BODJDCEKNHO <BIPIMFHNAHO>k__BackingField;    // 0x0x7C
    public BODJDCEKNHO <KGMILEOMMHD>k__BackingField;    // 0x0x80
    public long? <IPNAPONPGBJ>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// FLNLNFNCNGF
//   RESPONSE ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds/v2   [Service.Auth]
public class FLNLNFNCNGF
{
    public Dictionary<Guid, List<DFHAEEPEILL>> <EHEBKOPGCGM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FMOFGLDHPGK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FMOFGLDHPGK
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// FNBECBDPKHG
//   REQUEST  PUT    api/customAvatarItems   [Service.Auth]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
public class FNBECBDPKHG
{
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x10
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x18
    public int? <MNLOPPJFJPO>k__BackingField;    // 0x0x20
    public EFNAJMHBBKL? <ONHJJFJABJK>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// FNHOMLHJPMO
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.WWW]
public class FNHOMLHJPMO
{
    public Guid <PNHNPFFJNOG>k__BackingField;    // 0x0x10
    public int <EIKDEKIJJAO>k__BackingField;    // 0x0x20
    public long <BAHPALAEINP>k__BackingField;    // 0x0x28
    public Guid <BHHOHMJHHLA>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// GBEAJENPCDI
// base   : EJKEMFNHONH
//   (not directly referenced by a detected call)
public class GBEAJENPCDI : EJKEMFNHONH
{
    public int <OICKFMBKLPP>k__BackingField;    // 0x0x68
    public List<NFJFOOLPPGI> <HKDACFCMDPM>k__BackingField;    // 0x0x70
    public List<NFJFOOLPPGI> <OKIOLGBBKMF>k__BackingField;    // 0x0x78
    public List<NFJFOOLPPGI> <KPBLKLNNMLF>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// GCKDPFABBAH
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
//   RESPONSE DELETE api/keepsakes/{iMDIPHCNPIB}   [Service.Auth]
//   RESPONSE POST   api/playerwarnings   [Service.Auth]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.Auth]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.WWW]
public class GCKDPFABBAH
{
    public bool <GJFGGGDEJOE>k__BackingField;    // 0x0x10
    public string <APGFKPPMEKB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GCPNLFIHOFJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GCPNLFIHOFJ
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// GFDMPBJOEFA
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.Auth]
public class GFDMPBJOEFA
{
    public int <FGNBKJOBFHH>k__BackingField;    // 0x0x10
    public DGFNHOJPDPI <LNGMKEFHECE>k__BackingField;    // 0x0x14
    public NMMKPPGIAMP <NLPCCALFJNP>k__BackingField;    // 0x0x18
    public NMMKPPGIAMP <HLEHIAJIJEH>k__BackingField;    // 0x0x1C
    public NMMKPPGIAMP <MHDJDJIEDCB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GFPHGOGKPLG
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.Auth]
public class GFPHGOGKPLG
{
    public List<string> <OOFLBEGGCHG>k__BackingField;    // 0x0x10
    public List<string> <AFGGOODFGBF>k__BackingField;    // 0x0x18
    public List<string> <NIKBJENDBFO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GHOOGKHCIJM
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/checklist/v1/complete   [Service.WWW]
//   RESPONSE POST   api/progressionEvents   [Service.Auth]
//   RESPONSE POST   api/progressionEvents/collect/{iPFPGPGFKPL}/{oOFODOCCBIM}   [Service.Auth]
public class GHOOGKHCIJM
{
    public long? <CEIMFEJNMAO>k__BackingField;    // 0x0x10
    public int <DKMMJDJFMGI>k__BackingField;    // 0x0x20
    public int? <DDHGEOJONMH>k__BackingField;    // 0x0x24
    public string <JEBNLJIBJCL>k__BackingField;    // 0x0x30
    public MDEGNDGEEHE? <NOPOKGDMPJJ>k__BackingField;    // 0x0x38
    public string <HGPELOMMODC>k__BackingField;    // 0x0x40
    public Guid? <HFPLCOMGHEC>k__BackingField;    // 0x0x48
    public string <HGJFEALAHNN>k__BackingField;    // 0x0x60
    public string <KGMAKLCKBNM>k__BackingField;    // 0x0x68
    public OGPIJPOPLHA <LFANLNNCJEL>k__BackingField;    // 0x0x70
    public int <BIJFGIHPHNJ>k__BackingField;    // 0x0x74
    public int <ONIFPODJKAE>k__BackingField;    // 0x0x78
    public BLIMEGFFKGL <JILPBHOCCAH>k__BackingField;    // 0x0x7C
    public MGOIIGNJJJA <AFNMMFAAFNB>k__BackingField;    // 0x0x80
    public string <HFJCMOACDCA>k__BackingField;    // 0x0x88
    public COGBIDCIEPE <KDBAFGLAIHA>k__BackingField;    // 0x0x90
    public KGCLGMNMELJ <GACIJCAGJIJ>k__BackingField;    // 0x0x94
    public KOBIDOIAPNN? <LBJLNKCNGFD>k__BackingField;    // 0x0x98
    public bool <GDDILNBLEKA>k__BackingField;    // 0x0xA0
    public bool <POIFDBPKGBJ>k__BackingField;    // 0x0xA1
    public string <DCJPDHLPAOE>k__BackingField;    // 0x0xA8
    public bool <BCPFOBICIDK>k__BackingField;    // 0x0xB0
    public bool JBMHFPIGKLH;    // 0x0xB1
}

// --------------------------------------------------------------------------
// HADMEAKLANC
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2/delete/{iPFPGPGFKPL}   [Service.Auth]
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
public class HADMEAKLANC
{
    public BMIGJJELFIJ <GBKMEELNIGO>k__BackingField;    // 0x0x10
    public KHLMONNHOAK <HBBCGPEOFHK>k__BackingField;    // 0x0x18
    public IABPBFNMDJF <OEOEGGABPIH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HBOPJBLHNNI
//   REQUEST  ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds/v2   [Service.Auth]
public class HBOPJBLHNNI
{
    public List<Guid> <EBBFMPMKGMA>k__BackingField;    // 0x0x10
    public byte <FLNEANEFPHM>k__BackingField;    // 0x0x18
    public int <OGENMPDIHGP>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// HGNOLKCNFFJ
//   REQUEST  PUT    api/roomconsumables   [Service.WWW]
public class HGNOLKCNFFJ
{
    public Guid? <BEEFIOHICHA>k__BackingField;    // 0x0x10
    public Guid <PPOHONDFDIG>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// HHCJAFGCHDI
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.Auth]
public class HHCJAFGCHDI
{
    public int <PLBCJICIJED>k__BackingField;    // 0x0x10
    public int? <PHPAMNDFCPI>k__BackingField;    // 0x0x14
    public string <DLBNIKMMDBM>k__BackingField;    // 0x0x20
    public string <KGBDOBEGLLD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// HICMLOEIMJH
//   (not directly referenced by a detected call)
public class HICMLOEIMJH
{
    public ObscuredLong <IGPABKCIHEA>k__BackingField;    // 0x0x10
    public string <MBCCEGENNEP>k__BackingField;    // 0x0x38
    public ObscuredInt <HIGHHNHFFHP>k__BackingField;    // 0x0x40
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x58
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x60
    public string <JEOIMEHHHNK>k__BackingField;    // 0x0x68
    public byte <HDEHJPNIJJE>k__BackingField;    // 0x0x70
    public int <GBGEDKLOCNP>k__BackingField;    // 0x0x74
    public EFNAJMHBBKL <ONHJJFJABJK>k__BackingField;    // 0x0x78
    public bool <OPBHBAJKKCD>k__BackingField;    // 0x0x7C
    public DateTime <DMJIMMFAPOO>k__BackingField;    // 0x0x80
    public DateTime <OIDMNCMICHH>k__BackingField;    // 0x0x88
    public DateTime? <KLCIKDLKEAJ>k__BackingField;    // 0x0x90
    public long? <FPJKOGJDOLG>k__BackingField;    // 0x0xA0
    public int <JBGALGNBNOL>k__BackingField;    // 0x0xB0
    public int <FECJAIDGCLH>k__BackingField;    // 0x0xB4
    public int <DHKNMNMFEOF>k__BackingField;    // 0x0xB8
    public FJPCHFBICEF <FFLBPBCPFEC>k__BackingField;    // 0x0xBC
    public FJPCHFBICEF <NLLDHHOPBBB>k__BackingField;    // 0x0xC0
    public ObscuredBool <KADDFLJOPEM>k__BackingField;    // 0x0xC4
    public ObscuredBool <FJDINFHPCIO>k__BackingField;    // 0x0xD0
    public ObscuredBool <PKGOCKIANME>k__BackingField;    // 0x0xDC
    public ObscuredBool <IFKGGJDPKIJ>k__BackingField;    // 0x0xE8
    public int? <MNLOPPJFJPO>k__BackingField;    // 0x0xF4
    public bool <FMDLIBMBLBB>k__BackingField;    // 0x0xFC
}

// --------------------------------------------------------------------------
// HKLDDFOJEOC
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.WWW]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.WWW]
public class HKLDDFOJEOC
{
    public int <NPAEBAAAEEN>k__BackingField;    // 0x0x10
    public int <DPJHIOICIDL>k__BackingField;    // 0x0x14
    public float <OJBJCJDPENM>k__BackingField;    // 0x0x18
    public float <NHBDBCDPENL>k__BackingField;    // 0x0x1C
    public bool <OMCOHBPCKAK>k__BackingField;    // 0x0x20
    public bool <LGBOMFDFDHI>k__BackingField;    // 0x0x21
    public bool <DANGPPPMHKJ>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// HLKFGIOLPCP
//   REQUEST  POST   api/customAvatarItems   [Service.Auth]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
public class HLKFGIOLPCP
{
    public MNKJIENFHIP <GLBLPBBFMGO>k__BackingField;    // 0x0x10
    public string <ADLBKGIJPGD>k__BackingField;    // 0x0x18
    public int? <BKJGFIBFCFA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HMHINKICNCP
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
public class HMHINKICNCP
{
    public bool <GJFGGGDEJOE>k__BackingField;    // 0x0x10
    public string <OBBENIEDFGE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IABPBFNMDJF
//   RESPONSE POST   api/inventions/v1/settags   [Service.Auth]
public class IABPBFNMDJF
{
    public ICGKNPLLMKF <HBBCGPEOFHK>k__BackingField;    // 0x0x10
    public List<string> <KMFCBFAGNAD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IBDOMFAIAFD
//   (not directly referenced by a detected call)
public class IBDOMFAIAFD
{
    public long <MNLOPPJFJPO>k__BackingField;    // 0x0x10
    public Guid? <PNHNPFFJNOG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ICGKNPLLMKF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ICGKNPLLMKF
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
// IIDJFAECPBD
//   (not directly referenced by a detected call)
public class IIDJFAECPBD
{
    public int <OGEIKNBKGOM>k__BackingField;    // 0x0x10
    public KHLMONNHOAK <HBBCGPEOFHK>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// IPPEBLAMJGJ
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs/v2   [Service.Auth]
public class IPPEBLAMJGJ
{
    public List<string> <AEGOEGADMPB>k__BackingField;    // 0x0x10
    public byte <FLNEANEFPHM>k__BackingField;    // 0x0x18
    public int <OGENMPDIHGP>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// JBJOGDCHJAH
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs/v2   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems/v2   [Service.Notifications]
public class JBJOGDCHJAH
{
    public Dictionary<string, List<DFHAEEPEILL>> <KFODAHIKEKN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JDIMCMHDMIN
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Matchmaking]
public class JDIMCMHDMIN
{
    public Guid <GBBJMLENJMC>k__BackingField;    // 0x0x10
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x20
    public string <JEOIMEHHHNK>k__BackingField;    // 0x0x28
    public DateTime <OMPOANJJLIJ>k__BackingField;    // 0x0x30
    public DateTime? <COEOKLJCGHO>k__BackingField;    // 0x0x38
    public List<PEFODEPIEMM> <AAEIEHNMJKA>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// JELFHONNDHD
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.Auth]
public class JELFHONNDHD
{
    public KHLMONNHOAK <HBBCGPEOFHK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JFCMJHLCPJH
//   REQUEST  POST   api/playerevents/v1/respond   [Service.Auth]
public class JFCMJHLCPJH
{
    public long <LKPMKOHGADB>k__BackingField;    // 0x0x10
    public FMOFGLDHPGK <LNGMKEFHECE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JFHHFBEMDDO
// base   : JOIEEHIKOJG
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/season/{aBEOKMCLKCK}   [Service.WWW]
public class JFHHFBEMDDO : JOIEEHIKOJG
{
    public int <ILOEAFKAGCK>k__BackingField;    // 0x0x30
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x38
    public DateTime <OMPOANJJLIJ>k__BackingField;    // 0x0x40
    public DateTime <GIPPBPIJIDJ>k__BackingField;    // 0x0x48
    public OGPIJPOPLHA <LFANLNNCJEL>k__BackingField;    // 0x0x50
    public EJKEMFNHONH <NFHLJIKOHGM>k__BackingField;    // 0x0x58
    public List<GBEAJENPCDI> <FHMGPLFDOLL>k__BackingField;    // 0x0x60
    public OEEMHPEGDGK <IMCOBGEJMME>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// JIJBPBHEGFM
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.Auth]
public class JIJBPBHEGFM
{
    public int? <AHFLDIPOGPB>k__BackingField;    // 0x0x10
    public string <KFHBOOMNFGM>k__BackingField;    // 0x0x18
    public string <KHNKOBMPKIK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JLLCNGEGFCG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JLLCNGEGFCG
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// JMBCHAMIKPB
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class JMBCHAMIKPB
{
    public HGNOLKCNFFJ <LPIFKFBENMG>k__BackingField;    // 0x0x10
    public IBDOMFAIAFD <OMFBJLNIFPJ>k__BackingField;    // 0x0x18
    public int <KNGKDHOALBK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JOEMMFFJMMJ
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class JOEMMFFJMMJ
{
    public Dictionary<Guid, MMOMKALEPAA> <ELEKIBCLOMJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JOFGPIOEBHP
// base   : HJDHAADMMLI
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class JOFGPIOEBHP : HJDHAADMMLI
{
    public DJFCCOILADO? <EBADKLIHJIO>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <GMKMJIHGMLG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KAPGBAAHHCK
//   RESPONSE GET    api/config/v1/backtrace   [Service.Auth]
public class KAPGBAAHHCK
{
    public int <MCNHJOGHMEG>k__BackingField;    // 0x0x10
    public int <DGODCAAJBKP>k__BackingField;    // 0x0x14
    public float <JFGJFMEMLBN>k__BackingField;    // 0x0x18
    public int <EIHBOJGAFGO>k__BackingField;    // 0x0x1C
    public int <GMHCKIIILAI>k__BackingField;    // 0x0x20
    public int <HIOADEPNDJK>k__BackingField;    // 0x0x24
    public int <MAIABEIJFPL>k__BackingField;    // 0x0x28
    public string <KCGMLCCOOOO>k__BackingField;    // 0x0x30
    public string <NOELCNFFBJG>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// KFGDGDKPFIH
//   (not directly referenced by a detected call)
public class KFGDGDKPFIH
{
    public DateTime <OIDMNCMICHH>k__BackingField;    // 0x0x10
    public string <OPGPJPCOOBM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KGCLGMNMELJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KGCLGMNMELJ
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
// KHLMONNHOAK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KHLMONNHOAK
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
// KMEGOPCHOJE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KMEGOPCHOJE
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// KMGAPODMEEH
//   RESPONSE GET    api/testcasemanagement/   [Service.Auth]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{dKFNFHGODON}   [Service.Auth]
public class KMGAPODMEEH
{
    public uint <CEIMFEJNMAO>k__BackingField;    // 0x0x10
    public uint? <KGDNCMEMMEI>k__BackingField;    // 0x0x14
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x20
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x28
    public DateTime <BNCLDLJDOCG>k__BackingField;    // 0x0x30
    public DateTime? <AJGCLBPMONB>k__BackingField;    // 0x0x38
    public bool <AIABIOGCNAN>k__BackingField;    // 0x0x48
    public List<DACJMDOMDEJ> <PMBHHCBMPJB>k__BackingField;    // 0x0x50
    public List<string> <KMFCBFAGNAD>k__BackingField;    // 0x0x58
    public int <HECGBKKICHJ>k__BackingField;    // 0x0x60
    public int <ENHDNOIGFON>k__BackingField;    // 0x0x64
    public int <NEECEADDGEP>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// KOBIDOIAPNN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KOBIDOIAPNN
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
// LAILOABODEC
//   (not directly referenced by a detected call)
public class LAILOABODEC
{
    public long <LJJMFNNFCIP>k__BackingField;    // 0x0x10
    public long <LKPMKOHGADB>k__BackingField;    // 0x0x18
    public int <DKMMJDJFMGI>k__BackingField;    // 0x0x20
    public DateTime <OIDMNCMICHH>k__BackingField;    // 0x0x28
    public FMOFGLDHPGK <LNGMKEFHECE>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// LCDAMLGCBPC
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.WWW]
public class LCDAMLGCBPC
{
    public long <GFOAIHMBAEK>k__BackingField;    // 0x0x10
    public int <PNIKECMOIDM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LHJIJNLOBIC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LHJIJNLOBIC
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// LODMLIJLHCN
//   REQUEST  POST   api/roomcurrencies   [Service.WWW]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.WWW]
public class LODMLIJLHCN
{
    public Guid <BHHOHMJHHLA>k__BackingField;    // 0x0x10
    public long <NAFCMDFLFCG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LPJNDNCLBJC
//   (not directly referenced by a detected call)
public class LPJNDNCLBJC
{
    public Guid <MHFOHIEDMDI>k__BackingField;    // 0x0x10
    public int <PNIKECMOIDM>k__BackingField;    // 0x0x20
    public int <IGKJGBEABGC>k__BackingField;    // 0x0x24
    public Guid <DCJBIANGCIE>k__BackingField;    // 0x0x28
    public DateTime <DMJIMMFAPOO>k__BackingField;    // 0x0x38
    public PJMGMAFJIKF <OJBJALDDOCJ>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// MCGJGADIGNI
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
public class MCGJGADIGNI
{
    public List<string> <FNCPCOAKNKC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MCLIMAIHBJG
//   (not directly referenced by a detected call)
public class MCLIMAIHBJG
{
    public OGPIJPOPLHA <LFANLNNCJEL>k__BackingField;    // 0x0x10
    public int <MNLOPPJFJPO>k__BackingField;    // 0x0x14
    public CNLGBMLNJMO <FFJBANEINNB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MDDPLBIAPCO
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class MDDPLBIAPCO
{
    public Dictionary<Guid, PBIBKMJLIFD> <MOOPKEHHNCD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MDEGNDGEEHE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MDEGNDGEEHE
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// MDPDBAMCCGI
//   RESPONSE GET    api/playerevents/v1/all   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/all/{lKMOKKELGIB}   [Service.Auth]
public class MDPDBAMCCGI
{
    public List<FKMOANNDEEK> <OPAJIIHOKOJ>k__BackingField;    // 0x0x10
    public List<APEMDKFCPLH> <POHJDMELFCI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MGOIIGNJJJA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MGOIIGNJJJA
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// MMOMKALEPAA
//   (not directly referenced by a detected call)
public class MMOMKALEPAA
{
    public int <KNGKDHOALBK>k__BackingField;    // 0x0x10
    public HGNOLKCNFFJ <LPIFKFBENMG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MPPOCPMAGFJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MPPOCPMAGFJ
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
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
// NFJFOOLPPGI
//   (not directly referenced by a detected call)
public class NFJFOOLPPGI
{
    public bool <PCJOOBKEFEG>k__BackingField;    // 0x0x10
    public CPJLGIBAOJC <CCDIANNGINH>k__BackingField;    // 0x0x18
    public float <JHIFEKBLBBP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// NFNLOOFMJEF
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class NFNLOOFMJEF
{
    public List<IIDJFAECPBD> <DAGNAOJOKOJ>k__BackingField;    // 0x0x10
    public KHLMONNHOAK <HBBCGPEOFHK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NPJLOANBIPC
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.WWW]
public class NPJLOANBIPC
{
    public List<int> <KIHCGNMNFAD>k__BackingField;    // 0x0x10
    public string <CFKFDHHGNGG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OBMJNHHHLNP
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{aCICMLKDOPG}/{dCAFBPCCPIF}   [Service.WWW]
public class OBMJNHHHLNP
{
    public OGPIJPOPLHA <LFANLNNCJEL>k__BackingField;    // 0x0x10
    public OMFEEBGIFEH <MCDNGGPKJJE>k__BackingField;    // 0x0x14
    public int <EIHGMCBIEHK>k__BackingField;    // 0x0x18
    public int <FEFFEFCGNNC>k__BackingField;    // 0x0x1C
    public int <PBLFNEHLLHF>k__BackingField;    // 0x0x20
    public KMEGOPCHOJE <COBEMEKIIHG>k__BackingField;    // 0x0x24
    public bool <EJMKNIFPEFC>k__BackingField;    // 0x0x28
    public float <ILHLEPHNLEP>k__BackingField;    // 0x0x2C
    public int <NKPNPMKMDDL>k__BackingField;    // 0x0x30
    public bool <NJFAEJLMFKM>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// OEEMHPEGDGK
//   (not directly referenced by a detected call)
public class OEEMHPEGDGK
{
    public bool <NCJFBOBHGAJ>k__BackingField;    // 0x0x10
    public KGCLGMNMELJ <PEPHCGEDDGG>k__BackingField;    // 0x0x14
    public int <KINBABLNBCC>k__BackingField;    // 0x0x18
    public DateTime <DMJIMMFAPOO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OGPIJPOPLHA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OGPIJPOPLHA
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
// OMFEEBGIFEH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OMFEEBGIFEH
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
// PBIBKMJLIFD
//   RESPONSE PUT    api/roomconsumables   [Service.WWW]
public class PBIBKMJLIFD
{
    public PGDNLCGDKJL <BPKEIMDMMIC>k__BackingField;    // 0x0x10
    public LPJNDNCLBJC <EGJEKPGADFC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PEFODEPIEMM
//   (not directly referenced by a detected call)
public class PEFODEPIEMM
{
    public Guid <ENLPPMGOBOA>k__BackingField;    // 0x0x10
    public Guid <OGPCHNHEDOM>k__BackingField;    // 0x0x20
    public DateTime <OMPOANJJLIJ>k__BackingField;    // 0x0x30
    public List<CPJLGIBAOJC> <CDHEJOGMBDL>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// PGDNLCGDKJL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PGDNLCGDKJL
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
// PGIKMLILKMC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PGIKMLILKMC
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
    InappropriateDescription = 12,
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
    InventionContainsBetaContent = 48,
    PlatformDoesntSupportPublishing = 49,
    MismatchedUgcVersions = 50,
    ConvertedFromSameUgcVersion = 51,
    ConvertedFromInventionDoesNotExist = 52,
    ConvertedFromInventionHigherVersion = 53,
    PlatformDoesntSupportInvention = 54,
}

// --------------------------------------------------------------------------
// PIMJDOEGGFN
//   (not directly referenced by a detected call)
public class PIMJDOEGGFN
{
    public DGKJPFBPONJ CFIJHLJGGAP;    // 0x0x10
    public int NDEMDCLIFKN;    // 0x0x14
}

// --------------------------------------------------------------------------
// PJMGMAFJIKF
//   (not directly referenced by a detected call)
public class PJMGMAFJIKF
{
    public Guid <MHFOHIEDMDI>k__BackingField;    // 0x0x10
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x20
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x28
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x30
    public string <JEOIMEHHHNK>k__BackingField;    // 0x0x38
    public long <MNLOPPJFJPO>k__BackingField;    // 0x0x40
    public Guid? <EHLFOMCLJFL>k__BackingField;    // 0x0x48
    public DateTime <DMJIMMFAPOO>k__BackingField;    // 0x0x60
    public int <CCJBMGPJIFL>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// PMOLNEHKHLN
//   RESPONSE POST   api/inventions/v1/cheer   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/delete   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/update   [Service.Auth]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.Auth]
//   RESPONSE GET    api/inventions/v3/publish   [Service.Matchmaking]
//   RESPONSE POST   api/inventions/v7/addversion   [Service.Notifications]
//   RESPONSE POST   api/inventions/v8/save   [Service.Matchmaking]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.WWW]
public class PMOLNEHKHLN
{
    public PGIKMLILKMC <BPKEIMDMMIC>k__BackingField;    // 0x0x10
    public HICMLOEIMJH <MIPCNGAFCJO>k__BackingField;    // 0x0x18
    public ANEIEMAHBCO <FBNJIPEJIHE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// POKPKFKEHKB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum POKPKFKEHKB
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x10
    public long? <JCAIMEGABDO>k__BackingField;    // 0x0x18
    public NIPPJGHMNJM <IDCNLENNPGJ>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v7/addversion   [Service.Notifications]
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
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.Auth]
public class AppleMusicPromotionResponseDTO
{
    public FNKGAELALBD <HBBCGPEOFHK>k__BackingField;    // 0x0x10
    public string <DOIEAIOMFGP>k__BackingField;    // 0x0x18
    public string <NIGDFCNLKBC>k__BackingField;    // 0x0x20
    public string <JGENCKBIODB>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public OGPIJPOPLHA <CurrencyType>k__BackingField;    // 0x0x18
    public KOBIDOIAPNN <BalanceType>k__BackingField;    // 0x0x1C
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
    public long <LKPMKOHGADB>k__BackingField;    // 0x0x10
    public long? <DFEJDEBMKBJ>k__BackingField;    // 0x0x18
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
    public GONBMEALODI FilterType;    // 0x0x20
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
    public NIPPJGHMNJM <GMGKIANIPBB>k__BackingField;    // 0x0x10
    public string <OLONEFPMFNH>k__BackingField;    // 0x0x18
    public int <CKFLPGPLPOK>k__BackingField;    // 0x0x20
    public int <DGEKLCIMDMB>k__BackingField;    // 0x0x24
    public string <HANHCJGFFND>k__BackingField;    // 0x0x28
    public string <DEOFKPHNOGD>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <PNIKECMOIDM>k__BackingField;    // 0x0x10
    public Guid <MJMDAEFBLBN>k__BackingField;    // 0x0x14
    public DateTime <ECBALGIFNPF>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.Auth]
public class KeepsakeGlobalConfigDTO
{
    public bool <EOJBMBFLMEN>k__BackingField;    // 0x0x10
    public int <GNMOPNOLGLC>k__BackingField;    // 0x0x14
    public bool <PMOMGEEIENH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <MJMDAEFBLBN>k__BackingField;    // 0x0x10
    public NIPPJGHMNJM <OKDGAJLKFMN>k__BackingField;    // 0x0x20
    public int <KOMFLIPMPPF>k__BackingField;    // 0x0x24
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x28
    public long? <JCAIMEGABDO>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.Auth]
//   RESPONSE GET    api/keepsakes/events/{lHOFLPMECDE}   [Service.Auth]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <CFMOHMNKCDM>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <NILIHNAMLKF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <ACBKPAMFJBI>k__BackingField;    // 0x0x10
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x18
    public long <FBKHANEGNMF>k__BackingField;    // 0x0x20
    public FABPGDAFEDJ <LNGMKEFHECE>k__BackingField;    // 0x0x28
    public int <PGMBPLEAHPN>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <IIDNOMKGICC>k__BackingField;    // 0x0x10
    public List<Guid> <JAJJMBPJKAL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <CFMOHMNKCDM>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <NILIHNAMLKF>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <JHBFBPNODMC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <FBKHANEGNMF>k__BackingField;    // 0x0x10
    public long <PKFNBCNIDOO>k__BackingField;    // 0x0x18
    public int? <BAJMBDFCPLH>k__BackingField;    // 0x0x20
    public int? <BDLGHEDHIHM>k__BackingField;    // 0x0x28
    public long? <BAHNLJEEGBF>k__BackingField;    // 0x0x30
    public long <BDPEHLOIOAH>k__BackingField;    // 0x0x40
    public long <HGCKPNOHBMB>k__BackingField;    // 0x0x48
    public int <BELGEGOGAIM>k__BackingField;    // 0x0x50
    public FABPGDAFEDJ <FEPEAIELCBN>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <JADBILKFALJ>k__BackingField;    // 0x0x58
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
    public BLIMEGFFKGL <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v8/save   [Service.Matchmaking]
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
    public JLMLCKPCLMI creatorAccountRole;    // 0x0x60
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public PJGMDBKGFBE <KLHCFPLIGEE>k__BackingField;    // 0x0x10
    public AMFGCOHGCKE <AINJNFKKHNC>k__BackingField;    // 0x0x14
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x18
    public string <NIFHBLHFHNC>k__BackingField;    // 0x0x20
    public bool <MMOFEJDLIFE>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<PJGMDBKGFBE> <MBCPBJELMGK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/event/{iPFPGPGFKPL}   [Service.Auth]
public class ProgressionEventDTO
{
    public long <PKFNBCNIDOO>k__BackingField;    // 0x0x10
    public string <NCLJKGFODBO>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <KPBLKLNNMLF>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <NJCMNHOJHLL>k__BackingField;    // 0x0x28
    public DateTime <NENCNGOOPBI>k__BackingField;    // 0x0x30
    public DateTime <EJDOHJOLDKI>k__BackingField;    // 0x0x38
    public DateTime <EAFHJPDIGEK>k__BackingField;    // 0x0x40
    public bool <KLOGIHCGOJN>k__BackingField;    // 0x0x48
    public int <KHJNOLFDMBE>k__BackingField;    // 0x0x4C
    public float <KKGJBCINGOP>k__BackingField;    // 0x0x50
    public Guid? <LONFMGEEHNF>k__BackingField;    // 0x0x54
    public string <GFFPGJLBDPD>k__BackingField;    // 0x0x68
    public string <IGEBFGODKOF>k__BackingField;    // 0x0x70
    public string <LEBNNGDOGPO>k__BackingField;    // 0x0x78
    public string <KNIEKHDJMNG>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <IBGCEKCHKIM>k__BackingField;    // 0x0x10
    public int <DFKOAJGOPDA>k__BackingField;    // 0x0x20
    public int <HPJAGMNHBJF>k__BackingField;    // 0x0x24
    public int <CBKIALEFIBH>k__BackingField;    // 0x0x28
    public long <DDKHDFJAMLE>k__BackingField;    // 0x0x30
    public long <NAINOGGNGLI>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.Auth]
public class ProgressionEventRecordDTO
{
    public int <PNIKECMOIDM>k__BackingField;    // 0x0x10
    public int <ONIFPODJKAE>k__BackingField;    // 0x0x14
    public int <OONPAPLPCAF>k__BackingField;    // 0x0x18
    public int <PAAELCMCNCJ>k__BackingField;    // 0x0x1C
    public int <KOMIPDBHLLI>k__BackingField;    // 0x0x20
    public DateTime? <PJKBGPDDLEB>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <MDFMAOGOAEA>k__BackingField;    // 0x0x10
    public int <IKNDONOEDEP>k__BackingField;    // 0x0x18
    public string <JEOIMEHHHNK>k__BackingField;    // 0x0x20
    public int <ONIFPODJKAE>k__BackingField;    // 0x0x28
    public int <ODNGFKMFJDK>k__BackingField;    // 0x0x2C
    public bool <JKFPJMICAMP>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.Auth]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public JELMBLAKAMC ReportCategory;    // 0x0x20
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
    public bool LIAFFHBEBKH;    // 0x0x28
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
    public OKMJMGHFPOO? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [Auth POST]
public class PlayerCheerV1CreateRequest
{
    public OKMJMGHFPOO CKKOEDMEOIE;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [Auth POST]
public class PlayerReportingV1DeviceIdRequest
{
    public COGBIDCIEPE CDOOKECIDGH;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [Auth POST]
public class PlayerReportingV1HileRequest
{
    public KNDNPIAAOJO NCMHJNKFAGH;  // wrapper
    public int? GIHAJJDAPHG;  // wrapper
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
    public LKGPFPDDLFD LBLNGEEGOCA;  // wrapper
    public float? JKHFLIBEHAB;  // wrapper
    public bool? NGKPMBJMMOO;  // wrapper
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
    public List<IMGBFBEHHOP> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [WWW POST]
public class AvatarV2GiftsGenerateRequest
{
    public BLIMEGFFKGL CNBJCJOALNK;  // wrapper
    public BLIMEGFFKGL? IJJAJDNMMNO;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [WWW POST]
public class AvatarV3GiftsGenerateRequest
{
    public BLIMEGFFKGL CNBJCJOALNK;  // wrapper
    public BLIMEGFFKGL? IJJAJDNMMNO;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [? POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage JNNDBFGKHHD;  // wrapper
    public FDNHIKPPFCI LBLNGEEGOCA;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [Notifications POST]
public class ClubreportingV1ReportRequest
{
    public LKGPFPDDLFD LBLNGEEGOCA;  // wrapper
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

// api/customAvatarItems/v1  [Auth POST]
public class CustomAvatarItemsV1Request
{
    public EFNAJMHBBKL IBDHGFHCNBP;  // wrapper
    public IFKADPNDBOP DAEBNFHGENL;  // wrapper
    public PKHKDOKPICE LDBLIAGJFDA;  // wrapper
    public PKHKDOKPICE FBCJCBKJGHN;  // wrapper
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
    public KPDEJIADAID DDLDMDIODOI;  // wrapper
    public BLIMEGFFKGL? OJFFAFCPEOJ;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [WWW POST]
public class GamerewardsV1SelectRequest
{
    public NKGJAFIIICH JOGEDPPDHKF;  // wrapper
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
    public HICMLOEIMJH inventionId;  // wrapper
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

// api/keepsakes/{iMDIPHCNPIB}/collect  [Auth POST]
public class KeepsakesIMDIPHCNPIBCollectRequest
{
    public Guid IMDIPHCNPIB;  // wrapper
}

// api/messages/v2/send  [Auth POST]
public class MessagesV2SendRequest
{
    public GPPPHMEDNAN HHFINDLGBJC;  // wrapper
    public long? DIMOGDCMBFM;  // wrapper
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
    public IReadOnlyCollection<long> HIPOADEAAGL;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [Auth PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public MPPOCPMAGFJ IBDHGFHCNBP;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [Auth PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? ANBCIOKODGP;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [Auth PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public BODJDCEKNHO DEHFKBLIAAL;  // wrapper
    public BODJDCEKNHO BIGPFEFMEKC;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [Auth PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? KJMNNDODHCP;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [Auth PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime NCEEMEKPLHO;  // wrapper
    public DateTime GEHGKBEMJPC;  // wrapper
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
    public LKGPFPDDLFD LBLNGEEGOCA;  // wrapper
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

// api/roomCurrencies/v2/purchase  [? POST]
public class RoomCurrenciesV2PurchaseRequest
{
    public Guid IAFNAJAODCC;  // wrapper
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
    public Guid CDDAOGFINBF;  // wrapper
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
    public Guid CDDAOGFINBF;  // wrapper
    public long? EIMPEHDAPCI;  // wrapper
    public byte? ACDOKGKGEAH;  // wrapper
    public int? KIJNHGNFMMA;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid IAFNAJAODCC;  // wrapper
    public long? MCMLJDEPMOD;  // wrapper
    public long? NMMAMOIDCII;  // wrapper
    public int? EHNNGENIEKG;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [WWW PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> LDMPLMIKDPA;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [WWW POST]
public class RoomkeysV1CreateRequest
{
    public JLLCNGEGFCG NCMHJNKFAGH;  // wrapper
    public Guid? LBMHMBFPGDE;  // wrapper
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
    public LKGPFPDDLFD LBLNGEEGOCA;  // wrapper
    public long? CECJOPMPOCN;  // wrapper
    public Guid? KMILCLKNBCL;  // wrapper
    public int? IDDJFMBDJNB;  // wrapper
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
    public Guid AIIIGKKHPDH;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [WWW POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid DKPBLLFILJE;  // wrapper
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
    public FGJKMPCODMO MMMNFNCEDOI;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

