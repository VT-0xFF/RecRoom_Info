// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 200 (plus referenced enums)

// --------------------------------------------------------------------------
// ACJPINEKHLO
// base   : DKIFNANIMKP`1<DPMLELFBFGC>
//   RESPONSE GET    api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{dELOHGGPMKI}   [Service.Auth]
public class ACJPINEKHLO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// ADGBDONCEKE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ADGBDONCEKE
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
// AGJFDECNMDH
//   (not directly referenced by a detected call)
public class AGJFDECNMDH
{
    public Guid <EPDHDACGJFH>k__BackingField;    // 0x0x10
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x20
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x28
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x30
    public string <HGHMNOJCFPD>k__BackingField;    // 0x0x38
    public long <OPNCGFJDAOA>k__BackingField;    // 0x0x40
    public Guid? <FENNGIGNOMP>k__BackingField;    // 0x0x48
    public DateTime <ADLDHHHDKHB>k__BackingField;    // 0x0x60
    public int <HIEKBEECECF>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// AHIJIJKAOCO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AHIJIJKAOCO
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
// AHJBINONPND
//   REQUEST  POST   api/roomcurrencies   [Service.WWW]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.WWW]
public class AHJBINONPND
{
    public Guid <LPEFMKBLMHB>k__BackingField;    // 0x0x10
    public long <GPNNICGNALA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// APBNFPJLHNI
// base   : MFPAMBDIFNM
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class APBNFPJLHNI : MFPAMBDIFNM
{
    public JBGKINFIKFJ? <EBOJOOJCPEL>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <LFLACLAOLLJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BABDAOMFBHB
//   (not directly referenced by a detected call)
public class BABDAOMFBHB
{
    public bool <BDLGFNGMIEO>k__BackingField;    // 0x0x10
    public GFDHMNEGHFK <NHGGDIJECBN>k__BackingField;    // 0x0x18
    public float <KPDLHMHNECF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BCEFCBNKDMB
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.WWW]
public class BCEFCBNKDMB
{
    public int <FALAOPMADHJ>k__BackingField;    // 0x0x10
    public Guid <HCDFLENBPFP>k__BackingField;    // 0x0x14
    public long <HBFAFJBBMGL>k__BackingField;    // 0x0x28
    public DateTime <ADLDHHHDKHB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// BDLDELBNOGO
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
public class BDLDELBNOGO
{
    public OAFFOBDCMDA <DDLNFPHKEGL>k__BackingField;    // 0x0x10
    public NDIKICGKOPC <BPJDDPJBEOI>k__BackingField;    // 0x0x18
    public CGNBBBAPMNB <DIKLPJDOGAL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BFPKBDBKIJA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BFPKBDBKIJA
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// BJFJGIAPMBI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BJFJGIAPMBI
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
// BOCDPGCPGNC
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class BOCDPGCPGNC
{
    public Dictionary<Guid, JFJEAPJDELH> <BKBOKJDPBNB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BPAKKNHNKDB
//   (not directly referenced by a detected call)
public class BPAKKNHNKDB
{
    public int <CBAFNAEFGBE>k__BackingField;    // 0x0x10
    public MBMCCOFPPNB <LIJLDNIHFOJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BPKOCJBEBHM
//   (not directly referenced by a detected call)
public class BPKOCJBEBHM
{
    public int <KBCDLIEKICJ>k__BackingField;    // 0x0x10
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
// CCEJNCNIHOJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CCEJNCNIHOJ
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// CDOIKLMJDFB
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.WWW]
public class CDOIKLMJDFB
{
    public List<IKCPPJPPGME> <ONEJAHDKEEF>k__BackingField;    // 0x0x10
    public string <DOJPPMEIAJM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CDPOCJAJOPN
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.Auth]
public class CDPOCJAJOPN
{
    public string <AFIEPFMOPDP>k__BackingField;    // 0x0x10
    public string <LABGGCBCCHP>k__BackingField;    // 0x0x18
    public string <DNMKLCLMPPE>k__BackingField;    // 0x0x20
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x28
    public string <IMLCODPONFO>k__BackingField;    // 0x0x30
    public BFPKBDBKIJA <HLFOGEGGGFN>k__BackingField;    // 0x0x38
    public List<string> <JILECMDFMJJ>k__BackingField;    // 0x0x40
    public List<string> <HNJLDEDHMIJ>k__BackingField;    // 0x0x48
    public string <OLGHJCNAGEO>k__BackingField;    // 0x0x50
    public List<HGIIAIODLKO> <OAADNPFPLCL>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// CFLHALCDLLN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CFLHALCDLLN
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
// CGKDEFDJPKC
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Matchmaking]
public class CGKDEFDJPKC
{
    public Guid <JJGCBHOKJFM>k__BackingField;    // 0x0x10
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x20
    public string <HGHMNOJCFPD>k__BackingField;    // 0x0x28
    public DateTime <MENOLMMHDEP>k__BackingField;    // 0x0x30
    public DateTime? <LHPOEMDFLHG>k__BackingField;    // 0x0x38
    public List<EPEKKMGIJBA> <ELIJPBKKKMB>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// CGNBBBAPMNB
//   RESPONSE POST   api/inventions/v1/settags   [Service.Auth]
public class CGNBBBAPMNB
{
    public CFLHALCDLLN <BPJDDPJBEOI>k__BackingField;    // 0x0x10
    public List<string> <HNJLDEDHMIJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DAMFMDAPDEK
//   RESPONSE GET    api/inventions/v1/details   [Service.Auth]
public class DAMFMDAPDEK
{
    public List<LMJKCPMLDKE> <HNJLDEDHMIJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DBBHNNLKFBL
//   (not directly referenced by a detected call)
public class DBBHNNLKFBL
{
    public KHOEBDJHENK LLLDMKPDINB;    // 0x0x10
    public int LHLCCGAIAHM;    // 0x0x14
}

// --------------------------------------------------------------------------
// DBNEJBHMBCO
//   RESPONSE GET    api/config/v2   [Service.Auth]
public class DBNEJBHMBCO
{
    public Dictionary<int, int> <FIGBJLOMGFI>k__BackingField;    // 0x0x10
    public List<HIMNAGFKBLF> <OEJLGJKPCLO>k__BackingField;    // 0x0x18
    public DBBHNNLKFBL[][] <DGDIFNBLLKF>k__BackingField;    // 0x0x20
    public NFKDCCLFIGB <NCKAPJKNDCL>k__BackingField;    // 0x0x28
    public MBJPPDLGMOB <EHALFKDLANA>k__BackingField;    // 0x0x30
    public BPKOCJBEBHM <GCALOJIFOEN>k__BackingField;    // 0x0x38
    public HCCJAHNNMBP <FNFKBLBEFGG>k__BackingField;    // 0x0x40
    public KABBOAMIDBD <GPEBDIGCONM>k__BackingField;    // 0x0x48
    public string <ALJPFIDPOHE>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// DELKEGJHLBN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DELKEGJHLBN
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// DENBMHIHFDI
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.WWW]
public class DENBMHIHFDI
{
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <EFLBCGJFAHI>k__BackingField;    // 0x0x18
    public ICIDDHDCJGH <NKOKFFMIEFH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DHBIJNEGBKF
//   (not directly referenced by a detected call)
public class DHBIJNEGBKF
{
    public int <EAIIMLNHKBL>k__BackingField;    // 0x0x10
    public GLLIMCABJJH <INCPBMKOOBM>k__BackingField;    // 0x0x14
    public List<DMEGCGLHHMO> <LJPBJKJECEC>k__BackingField;    // 0x0x18
    public List<DMEGCGLHHMO> <EGFCPNKOAHJ>k__BackingField;    // 0x0x20
    public bool <DEHKPMOCEBA>k__BackingField;    // 0x0x28
    public DateTime? <HJINAINMNHJ>k__BackingField;    // 0x0x30
    public DateTime? <NFGJNEMFBLB>k__BackingField;    // 0x0x40
    public DateTime? <KCCEJDIOKBB>k__BackingField;    // 0x0x50
    public bool <LPJFIIPCJON>k__BackingField;    // 0x0x60
    public bool <LAEKGGOHKFP>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// DJGMJCJOLEJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DJGMJCJOLEJ
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
// DMCCEDAKMON
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
public class DMCCEDAKMON
{
    public List<string> <HBMJOPLCMCE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DMEGCGLHHMO
//   (not directly referenced by a detected call)
public class DMEGCGLHHMO
{
    public ADGBDONCEKE <BCBEBOHMLDB>k__BackingField;    // 0x0x10
    public int <OPNCGFJDAOA>k__BackingField;    // 0x0x14
    public OCIDGHAABHC <CCAGIKHIBAJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ECEGFBKHKGB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ECEGFBKHKGB
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// EDAJDDGEMKB
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.Auth]
public class EDAJDDGEMKB
{
    public List<string> <OHNIKCDAGFN>k__BackingField;    // 0x0x10
    public List<string> <DAOLJJHINAI>k__BackingField;    // 0x0x18
    public List<string> <KCHHMNIBADJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EECOOCKKEEK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EECOOCKKEEK
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// EHOGKIEPDND
//   RESPONSE DELETE api/roomconsumables   [Service.WWW]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{iNPMEMKDKBM}   [Service.WWW]
public class EHOGKIEPDND
{
    public DJGMJCJOLEJ <HLFOGEGGGFN>k__BackingField;    // 0x0x10
    public AGJFDECNMDH <GJCFJCKNABE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ELKAAJGBGDC
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.WWW]
public class ELKAAJGBGDC
{
    public Dictionary<Guid, BPAKKNHNKDB> <HGPDIAGOILH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// EMNBENLODNM
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.WWW]
public class EMNBENLODNM
{
    public long <NCPOAKIDMGB>k__BackingField;    // 0x0x10
    public int <FALAOPMADHJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EPEKKMGIJBA
//   (not directly referenced by a detected call)
public class EPEKKMGIJBA
{
    public Guid <FPFGCIGFDHP>k__BackingField;    // 0x0x10
    public Guid <LCPIJODAJBP>k__BackingField;    // 0x0x20
    public DateTime <MENOLMMHDEP>k__BackingField;    // 0x0x30
    public List<GFDHMNEGHFK> <KHAGDJCOGKA>k__BackingField;    // 0x0x38
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
// FDBGJDPHAGP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FDBGJDPHAGP
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// FDPKBKCBMGL
//   RESPONSE GET    api/config/v1/azurespeech   [Service.Auth]
public class FDPKBKCBMGL
{
    public bool <NEMIDIFOIOJ>k__BackingField;    // 0x0x10
    public string <LABGGCBCCHP>k__BackingField;    // 0x0x18
    public string <OKIIOGOKLNL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FHLHHNLGBFN
//   (not directly referenced by a detected call)
public class FHLHHNLGBFN
{
    public ILKPFMBHNJM <DDLNFPHKEGL>k__BackingField;    // 0x0x10
    public OMHCDHMMEAK <LEKOMIELECI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FKHDMFGEIJL
//   (not directly referenced by a detected call)
public class FKHDMFGEIJL
{
    public long <JNEEKKLABKH>k__BackingField;    // 0x0x10
    public Guid <MGNOOMNLNLO>k__BackingField;    // 0x0x18
    public Guid <HCANCEIBNLM>k__BackingField;    // 0x0x28
    public DateTime <MLCJKGNAKGB>k__BackingField;    // 0x0x38
    public string <HNKFECFIAJK>k__BackingField;    // 0x0x40
    public string <OIMENBKNLFK>k__BackingField;    // 0x0x48
    public int <NLEJALELIMM>k__BackingField;    // 0x0x50
    public string <NKMDEOLKNGG>k__BackingField;    // 0x0x58
    public string <BGGKLKLFMIC>k__BackingField;    // 0x0x60
    public string <OJJHCLDLODH>k__BackingField;    // 0x0x68
    public string <MAGGEGNDOPI>k__BackingField;    // 0x0x70
    public int <JNNIFAKIGAB>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// FLJDKBLHENH
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.WWW]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
//   RESPONSE GET    api/avatar/v4/items   [Service.WWW]
public class FLJDKBLHENH
{
    public FDBGJDPHAGP <IAANEKFKKFN>k__BackingField;    // 0x0x10
    public string <ACABOOKBDLF>k__BackingField;    // 0x0x18
    public string <CGIDFIFNOHB>k__BackingField;    // 0x0x20
    public string <EDHFPCJPCLC>k__BackingField;    // 0x0x28
    public EECOOCKKEEK <NPOKGAKJDOF>k__BackingField;    // 0x0x30
    public string <HFMINPLGDMC>k__BackingField;    // 0x0x38
    public int <DNDLFILEPIJ>k__BackingField;    // 0x0x40
    public bool <KKEJJNBFBGG>k__BackingField;    // 0x0x44
    public string <DKCKJOEOPGD>k__BackingField;    // 0x0x48
    public DateTime <MLCJKGNAKGB>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// GAAKPBCEHEG
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.Auth]
public class GAAKPBCEHEG
{
    public int? <OMGKCCKGPCN>k__BackingField;    // 0x0x10
    public string <IMLCODPONFO>k__BackingField;    // 0x0x18
    public string <PGIGLOLIKDC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GEOPBELCJPG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GEOPBELCJPG
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
// GFDHMNEGHFK
//   (not directly referenced by a detected call)
public class GFDHMNEGHFK
{
    public int <DJGHIKBEOBP>k__BackingField;    // 0x0x10
    public string <CGIDFIFNOHB>k__BackingField;    // 0x0x18
    public string <EDHFPCJPCLC>k__BackingField;    // 0x0x20
    public string <HFMINPLGDMC>k__BackingField;    // 0x0x28
    public string <HFHLKKHHKCB>k__BackingField;    // 0x0x30
    public string <AOEFJFIDNKN>k__BackingField;    // 0x0x38
    public Guid? <MGNOOMNLNLO>k__BackingField;    // 0x0x40
    public FDBGJDPHAGP? <IAANEKFKKFN>k__BackingField;    // 0x0x54
    public string <FCJFBIHCMJN>k__BackingField;    // 0x0x60
    public string <CLCKKAMNBAD>k__BackingField;    // 0x0x68
    public bool <MJDDPDCOLJA>k__BackingField;    // 0x0x70
    public bool <ENGLOJHNPEH>k__BackingField;    // 0x0x71
    public bool <CGBNKPGNNIJ>k__BackingField;    // 0x0x72
    public EECOOCKKEEK <NPOKGAKJDOF>k__BackingField;    // 0x0x74
    public ADGBDONCEKE <BCBEBOHMLDB>k__BackingField;    // 0x0x78
    public int <LJHFHKEONPE>k__BackingField;    // 0x0x7C
    public MBKBDNLDBLI <JJJCCNMDNGN>k__BackingField;    // 0x0x80
    public PKEOLIEIEFH <MIMDBODOOBF>k__BackingField;    // 0x0x84
    public int? <MHGJDICKKMG>k__BackingField;    // 0x0x88
    public string <BMGGPEJBEDE>k__BackingField;    // 0x0x90
    public int? <DNDLFILEPIJ>k__BackingField;    // 0x0x98
    public int? <IKIGBMLFDCA>k__BackingField;    // 0x0xA0
    public string <LIEOCDEGLMA>k__BackingField;    // 0x0xA8
}

// --------------------------------------------------------------------------
// GLLIMCABJJH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GLLIMCABJJH
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// HCCJAHNNMBP
//   (not directly referenced by a detected call)
public class HCCJAHNNMBP
{
    public int <FDCEOOFCHAF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// HCHKMMGELIM
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.Auth]
public class HCHKMMGELIM
{
    public List<ILKPFMBHNJM> <LIIMKNHIDDH>k__BackingField;    // 0x0x10
    public string <DOJPPMEIAJM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HGCMDNNHKKN
// base   : MFPAMBDIFNM
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class HGCMDNNHKKN : MFPAMBDIFNM
{
    public DELKEGJHLBN? <EBOJOOJCPEL>k__BackingField;    // 0x0x18
    public BCEFCBNKDMB <DHPKAEDNCHM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HGIIAIODLKO
//   (not directly referenced by a detected call)
public class HGIIAIODLKO
{
    public DateTime <MLCJKGNAKGB>k__BackingField;    // 0x0x10
    public string <PIMILGIGJKB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HGLHEBEIFOA
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
public class HGLHEBEIFOA
{
    public bool <LPPLHMHAHCH>k__BackingField;    // 0x0x10
    public string <EEDPLOHJAPL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HHEBAOBAFCL
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
public class HHEBAOBAFCL
{
    public Guid? <EPDHDACGJFH>k__BackingField;    // 0x0x10
    public long? <AAJIAGNKOPM>k__BackingField;    // 0x0x28
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x38
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x40
    public string <HGHMNOJCFPD>k__BackingField;    // 0x0x48
    public KLGALMAIGMM <LJLNAAPAGNJ>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// HOPJCAPIICC
//   REQUEST  POST   api/customAvatarItems   [Service.Auth]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
public class HOPJCAPIICC
{
    public HHPGDMDOFHF <NMBKOGEANHN>k__BackingField;    // 0x0x10
    public string <MHHIGKAIPGC>k__BackingField;    // 0x0x18
    public int? <DEOECHICFGG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ICIDDHDCJGH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ICIDDHDCJGH
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// IGCMEBNIELE
// base   : DKIFNANIMKP`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.Auth]
public class IGCMEBNIELE
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// IIGBGENGIEM
//   REQUEST  POST   api/playerevents/v2   [Service.Auth]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.Auth]
public class IIGBGENGIEM
{
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x10
    public long? <JNGCJIILDLB>k__BackingField;    // 0x0x18
    public long? <IHKOJCNIKEO>k__BackingField;    // 0x0x28
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x38
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x40
    public List<string> <HNJLDEDHMIJ>k__BackingField;    // 0x0x48
    public string <HGHMNOJCFPD>k__BackingField;    // 0x0x50
    public DateTime <BPDDMECPGFG>k__BackingField;    // 0x0x58
    public DateTime <MGPMMIOPNEE>k__BackingField;    // 0x0x60
    public ILCCMMMKCFH <EDEPMPKMEPK>k__BackingField;    // 0x0x68
    public bool <BOJBOEEDGOP>k__BackingField;    // 0x0x6C
    public bool <LJCGGLPJOFA>k__BackingField;    // 0x0x6D
    public ECEGFBKHKGB <CEELLDLLDEA>k__BackingField;    // 0x0x70
    public ECEGFBKHKGB <FEOGMIFCKPD>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// IKCPPJPPGME
//   (not directly referenced by a detected call)
public class IKCPPJPPGME
{
    public int <GPDILEIOMPJ>k__BackingField;    // 0x0x10
    public DateTime <MLCJKGNAKGB>k__BackingField;    // 0x0x18
    public DateTime? <IDNGDOOBDCP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ILCCMMMKCFH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ILCCMMMKCFH
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// ILKPFMBHNJM
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class ILKPFMBHNJM
{
    public long <CGFCLLPLEPC>k__BackingField;    // 0x0x10
    public int <NACNABJJKLK>k__BackingField;    // 0x0x18
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x20
    public long? <JNGCJIILDLB>k__BackingField;    // 0x0x28
    public long? <IHKOJCNIKEO>k__BackingField;    // 0x0x38
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x48
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x50
    public string <HGHMNOJCFPD>k__BackingField;    // 0x0x58
    public DateTime <BPDDMECPGFG>k__BackingField;    // 0x0x60
    public DateTime <MGPMMIOPNEE>k__BackingField;    // 0x0x68
    public int <LDLAOLNEGFE>k__BackingField;    // 0x0x70
    public ILCCMMMKCFH <EDEPMPKMEPK>k__BackingField;    // 0x0x74
    public bool <BOJBOEEDGOP>k__BackingField;    // 0x0x78
    public bool <LJCGGLPJOFA>k__BackingField;    // 0x0x79
    public ECEGFBKHKGB <CEELLDLLDEA>k__BackingField;    // 0x0x7C
    public ECEGFBKHKGB <FEOGMIFCKPD>k__BackingField;    // 0x0x80
    public long? <GFMKOPMDPHB>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// INDBEGKNKAL
//   (not directly referenced by a detected call)
public class INDBEGKNKAL
{
    public bool <IGOBPAGFEDH>k__BackingField;    // 0x0x10
    public GEOPBELCJPG <JHOIGLKAJBM>k__BackingField;    // 0x0x14
    public int <BELLOCFFEJP>k__BackingField;    // 0x0x18
    public DateTime <ADLDHHHDKHB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// IOIKFJHGDMA
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.Auth]
public class IOIKFJHGDMA
{
    public List<long> <DFNINIOBLKE>k__BackingField;    // 0x0x10
    public KDEICACCAFC <INCPBMKOOBM>k__BackingField;    // 0x0x18
    public string <DFINOIPGAKF>k__BackingField;    // 0x0x20
    public long? <AAJIAGNKOPM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// JAPJEOFCKDL
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.WWW]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.WWW]
public class JAPJEOFCKDL
{
    public int <NJFOIACFLJO>k__BackingField;    // 0x0x10
    public int <GJHIILECJIO>k__BackingField;    // 0x0x14
    public float <CDPMHDJFMGL>k__BackingField;    // 0x0x18
    public float <BFEPPEBLJME>k__BackingField;    // 0x0x1C
    public bool <PEDADIFJDEH>k__BackingField;    // 0x0x20
    public bool <PNIBLBNIOEI>k__BackingField;    // 0x0x21
    public bool <DAJOEHDGFPN>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// JBGKINFIKFJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JBGKINFIKFJ
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
// JCONOLJCCBI
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.Auth]
public class JCONOLJCCBI
{
    public int <JHCBMEJJBGP>k__BackingField;    // 0x0x10
    public int? <EGDEJMHJCJO>k__BackingField;    // 0x0x14
    public string <EKIDJFHICAN>k__BackingField;    // 0x0x20
    public string <EAIGJJCCCDM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// JEBHKHMJHEO
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.Auth]
public class JEBHKHMJHEO
{
    public int <HIECCIOLNIA>k__BackingField;    // 0x0x10
    public MBEFKOMAMDF <INCPBMKOOBM>k__BackingField;    // 0x0x14
    public EDJNEFDBLFM <EJAAEAMOFPD>k__BackingField;    // 0x0x18
    public EDJNEFDBLFM <BIAJCALINPN>k__BackingField;    // 0x0x1C
    public EDJNEFDBLFM <BDEPBMJBAIJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JFGFJBAFOGP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JFGFJBAFOGP
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
// JFJEAPJDELH
//   RESPONSE PUT    api/roomconsumables   [Service.WWW]
public class JFJEAPJDELH
{
    public DJGMJCJOLEJ <HLFOGEGGGFN>k__BackingField;    // 0x0x10
    public PGPEAPANHDK <BFABNKEDDAF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JHONKCFACFB
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.WWW]
public class JHONKCFACFB
{
    public int <GJHIILECJIO>k__BackingField;    // 0x0x10
    public bool <PEDADIFJDEH>k__BackingField;    // 0x0x14
    public DateTime <GIMONCBCBKF>k__BackingField;    // 0x0x18
    public bool <MAHOJHJONBN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JMGKJCAGGEJ
//   RESPONSE GET    api/testcasemanagement/   [Service.Auth]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{mJDOIIBKEKN}   [Service.Auth]
public class JMGKJCAGGEJ
{
    public uint <AFIEPFMOPDP>k__BackingField;    // 0x0x10
    public uint? <BAMANJNCIBF>k__BackingField;    // 0x0x14
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x20
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x28
    public DateTime <LEDMPAHNGGN>k__BackingField;    // 0x0x30
    public DateTime? <EFOEMCEIPMD>k__BackingField;    // 0x0x38
    public bool <MEMFFJIHNCP>k__BackingField;    // 0x0x48
    public List<CDPOCJAJOPN> <MNNBIDBACDO>k__BackingField;    // 0x0x50
    public List<string> <HNJLDEDHMIJ>k__BackingField;    // 0x0x58
    public int <AMNHPGOMMBD>k__BackingField;    // 0x0x60
    public int <PLJOECBCLAC>k__BackingField;    // 0x0x64
    public int <OLGDAOFLFBD>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// KABBOAMIDBD
//   (not directly referenced by a detected call)
public class KABBOAMIDBD
{
    public float <CMMLFDLDBCN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KAFPLPPMFCJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KAFPLPPMFCJ
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// KDHLPEBLEGI
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.WWW]
public class KDHLPEBLEGI
{
    public long <NCPOAKIDMGB>k__BackingField;    // 0x0x10
    public int <FALAOPMADHJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KEBIHNBFMIA
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/checklist/v1/complete   [Service.WWW]
//   RESPONSE POST   api/progressionEvents   [Service.Auth]
//   RESPONSE POST   api/progressionEvents/collect/{jHAGJOJLMBG}/{dOEODJLHNCI}   [Service.Auth]
public class KEBIHNBFMIA
{
    public long? <AFIEPFMOPDP>k__BackingField;    // 0x0x10
    public int <CHKJGBIFOAC>k__BackingField;    // 0x0x20
    public int? <FIDJOFPKFFH>k__BackingField;    // 0x0x24
    public string <HFHLKKHHKCB>k__BackingField;    // 0x0x30
    public FDBGJDPHAGP? <IAANEKFKKFN>k__BackingField;    // 0x0x38
    public string <AOEFJFIDNKN>k__BackingField;    // 0x0x40
    public Guid? <MGNOOMNLNLO>k__BackingField;    // 0x0x48
    public string <FCJFBIHCMJN>k__BackingField;    // 0x0x60
    public string <CLCKKAMNBAD>k__BackingField;    // 0x0x68
    public ADGBDONCEKE <BCBEBOHMLDB>k__BackingField;    // 0x0x70
    public int <LJHFHKEONPE>k__BackingField;    // 0x0x74
    public int <MIGPCEJFHJI>k__BackingField;    // 0x0x78
    public PKEOLIEIEFH <LGBCINABIHD>k__BackingField;    // 0x0x7C
    public EECOOCKKEEK <PNELFAKELOF>k__BackingField;    // 0x0x80
    public string <DPBPCEFHJHB>k__BackingField;    // 0x0x88
    public JFGFJBAFOGP <JGJNKHODMAM>k__BackingField;    // 0x0x90
    public GEOPBELCJPG <NEJHMHJAFAH>k__BackingField;    // 0x0x94
    public AHIJIJKAOCO? <DGECFMAOGGB>k__BackingField;    // 0x0x98
    public bool <KGEOMJJDPNN>k__BackingField;    // 0x0xA0
    public bool <IPPBJMMINKJ>k__BackingField;    // 0x0xA1
    public string <HFJONPFAPGD>k__BackingField;    // 0x0xA8
    public bool <MHICHOJFLEO>k__BackingField;    // 0x0xB0
    public bool MJJPOGGOJIP;    // 0x0xB1
}

// --------------------------------------------------------------------------
// KFCAPDGAGCK
//   RESPONSE PUT    api/roomkeys/v1/   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class KFCAPDGAGCK
{
    public RoomKeyResult <HLFOGEGGGFN>k__BackingField;    // 0x0x10
    public LHGDKAPDFGF <KLNFMALKOIF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KHAFLBCNJFI
//   REQUEST  ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds/v2   [Service.Auth]
public class KHAFLBCNJFI
{
    public List<Guid> <KCALJOFFJNB>k__BackingField;    // 0x0x10
    public byte <IHONMGHGDNJ>k__BackingField;    // 0x0x18
    public int <FCIGCMIFINI>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// KHOEBDJHENK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KHOEBDJHENK
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
// KJNEJJPNCCJ
// base   : CABNONGMLJM
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/season/{oONDGDOGDPH}   [Service.WWW]
public class KJNEJJPNCCJ : CABNONGMLJM
{
    public int <JLOJHPKLIFE>k__BackingField;    // 0x0x30
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x38
    public DateTime <MENOLMMHDEP>k__BackingField;    // 0x0x40
    public DateTime <JCLEMFFMECP>k__BackingField;    // 0x0x48
    public ADGBDONCEKE <BCBEBOHMLDB>k__BackingField;    // 0x0x50
    public DHBIJNEGBKF <LMEPHAEOKFH>k__BackingField;    // 0x0x58
    public List<MDGJKCKGLAG> <JCHNOAEJFAI>k__BackingField;    // 0x0x60
    public INDBEGKNKAL <MBLIGENEGBL>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// KLGALMAIGMM
//   (not directly referenced by a detected call)
public class KLGALMAIGMM
{
    public long <OPNCGFJDAOA>k__BackingField;    // 0x0x10
    public Guid? <HCDFLENBPFP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KPECIABEHNJ
//   REQUEST  POST   api/equipment/v1/update   [Service.WWW]
public class KPECIABEHNJ
{
    public string <LNONEPIBPOH>k__BackingField;    // 0x0x10
    public string <CCJMFMDACMJ>k__BackingField;    // 0x0x18
    public string <CGIDFIFNOHB>k__BackingField;    // 0x0x20
    public string <EDHFPCJPCLC>k__BackingField;    // 0x0x28
    public EECOOCKKEEK <NPOKGAKJDOF>k__BackingField;    // 0x0x30
    public string <LIEOCDEGLMA>k__BackingField;    // 0x0x38
    public bool FNGLPOACEHO;    // 0x0x40
    public bool <DAJOEHDGFPN>k__BackingField;    // 0x0x41
}

// --------------------------------------------------------------------------
// LGNMGGOPIDN
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class LGNMGGOPIDN
{
    public MBMCCOFPPNB <LIJLDNIHFOJ>k__BackingField;    // 0x0x10
    public KLGALMAIGMM <BJLFGGDHPGD>k__BackingField;    // 0x0x18
    public int <CBAFNAEFGBE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LHGDKAPDFGF
//   (not directly referenced by a detected call)
public class LHGDKAPDFGF
{
    public long <NCPOAKIDMGB>k__BackingField;    // 0x0x10
    public Guid <HBLJBLHJJIL>k__BackingField;    // 0x0x18
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x28
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x30
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x38
    public int <OPNCGFJDAOA>k__BackingField;    // 0x0x40
    public Guid? <FENNGIGNOMP>k__BackingField;    // 0x0x44
    public DateTime <MLCJKGNAKGB>k__BackingField;    // 0x0x58
    public string <HGHMNOJCFPD>k__BackingField;    // 0x0x60
    public MIAAEAGOENI <INCPBMKOOBM>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// LHJGGPGHDNB
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.Auth]
public class LHJGGPGHDNB
{
    public HPNGBDGBJDM <NMBKOGEANHN>k__BackingField;    // 0x0x10
    public int <CCGHHGKJMBA>k__BackingField;    // 0x0x14
    public long <CJNHLDMDNAO>k__BackingField;    // 0x0x18
    public bool <NAKDMBADMGB>k__BackingField;    // 0x0x20
    public string <EEDPLOHJAPL>k__BackingField;    // 0x0x28
    public int? <HDOMBEDJDLB>k__BackingField;    // 0x0x30
    public bool <KBIDIHJHAJA>k__BackingField;    // 0x0x38
    public bool <ABPPBKGGEAE>k__BackingField;    // 0x0x39
    public bool <CKDJKIBGBDP>k__BackingField;    // 0x0x3A
    public bool <ILLNNAMLIBD>k__BackingField;    // 0x0x3B
    public string <HGPABIAIEKD>k__BackingField;    // 0x0x40
    public DateTime? <MLPGIJJPHAL>k__BackingField;    // 0x0x48
    public string <CHIAJFINFCJ>k__BackingField;    // 0x0x58
    public float <NMEFLJJJLPP>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// LHJKNJFEIAK
//   RESPONSE POST   api/chatreport/createChatReport   [Service.Auth]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.WWW]
//   RESPONSE DELETE api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.Auth]
//   RESPONSE DELETE api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
//   RESPONSE POST   api/customAvatarItems/v1/{nDNNLJBLELL}/appeal   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.Auth]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.Auth]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.WWW]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.WWW]
//   RESPONSE POST   api/images/v2/modifyaccessibility   [Service.Auth]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.WWW]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.WWW]
//   RESPONSE DELETE api/keepsakes   [Service.Auth]
//   RESPONSE DELETE api/keepsakes/{pGLONPJBOEL}   [Service.Auth]
//   RESPONSE POST   api/playerwarnings   [Service.Auth]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.Auth]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.WWW]
public class LHJKNJFEIAK
{
    public bool <LPPLHMHAHCH>k__BackingField;    // 0x0x10
    public string <BGCDGDCMFJL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LHPHFBOJLDO
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.WWW]
public class LHPHFBOJLDO
{
    public int EHAOJHOJHJI;    // 0x0x10
    public long HPFAKGBFIDM;    // 0x0x18
}

// --------------------------------------------------------------------------
// LMJKCPMLDKE
//   (not directly referenced by a detected call)
public class LMJKCPMLDKE
{
    public string <PAELNMGDBGE>k__BackingField;    // 0x0x10
    public CCEJNCNIHOJ <INCPBMKOOBM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LNCAGCLGDHI
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.WWW]
public class LNCAGCLGDHI
{
    public int <CCGHHGKJMBA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MBJPPDLGMOB
//   (not directly referenced by a detected call)
public class MBJPPDLGMOB
{
    public float <HAMLNBCHHMA>k__BackingField;    // 0x0x10
    public float <EDOLEOILMDN>k__BackingField;    // 0x0x14
    public float <LAMOMBKCENK>k__BackingField;    // 0x0x18
    public float <EDNGOBIKIAB>k__BackingField;    // 0x0x1C
    public float <PIKHGNFBJLO>k__BackingField;    // 0x0x20
    public float <NDMAJHDJFJI>k__BackingField;    // 0x0x24
    public float <ONMBNBMPEPJ>k__BackingField;    // 0x0x28
    public float <GJJOOFLHLHC>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// MBKBDNLDBLI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MBKBDNLDBLI
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
// MBMCCOFPPNB
//   REQUEST  PUT    api/roomconsumables   [Service.WWW]
public class MBMCCOFPPNB
{
    public Guid? <GAIGLNLAPFL>k__BackingField;    // 0x0x10
    public Guid <EEIAINHBBBB>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// MDGJKCKGLAG
// base   : DHBIJNEGBKF
//   (not directly referenced by a detected call)
public class MDGJKCKGLAG : DHBIJNEGBKF
{
    public int <BBMIHMBBLGG>k__BackingField;    // 0x0x68
    public List<BABDAOMFBHB> <GALEMKABMLI>k__BackingField;    // 0x0x70
    public List<BABDAOMFBHB> <JNMJPLGHOPI>k__BackingField;    // 0x0x78
    public List<BABDAOMFBHB> <EHICOOAMGLC>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// MDGKDEGDFPM
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{hPJFLAACOFJ}/{aFBIAACHEDL}   [Service.WWW]
public class MDGKDEGDFPM
{
    public ADGBDONCEKE <BCBEBOHMLDB>k__BackingField;    // 0x0x10
    public BJFJGIAPMBI <JPKCLAMOOMM>k__BackingField;    // 0x0x14
    public int <FMOMGDFHGMK>k__BackingField;    // 0x0x18
    public int <BOBNHCPHHAE>k__BackingField;    // 0x0x1C
    public int <BFBFEJFGOFA>k__BackingField;    // 0x0x20
    public MFKEAGNDGLM <KDJLFHOPFIO>k__BackingField;    // 0x0x24
    public bool <CCFEENPKLLK>k__BackingField;    // 0x0x28
    public float <IFNCJPELOCK>k__BackingField;    // 0x0x2C
    public int <BMILFFNBPEM>k__BackingField;    // 0x0x30
    public bool <PCKAJEOCJFL>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// MEMJPCPEGPB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MEMJPCPEGPB
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// MFKEAGNDGLM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MFKEAGNDGLM
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// MIAAEAGOENI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MIAAEAGOENI
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// MMGAHMCHKIF
//   (not directly referenced by a detected call)
public class MMGAHMCHKIF
{
    public int <JNFGJDMOCCO>k__BackingField;    // 0x0x10
    public NDIKICGKOPC <BPJDDPJBEOI>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// MNFDGCLIAEJ
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class MNFDGCLIAEJ
{
    public List<MMGAHMCHKIF> <BIJCGENEIOG>k__BackingField;    // 0x0x10
    public NDIKICGKOPC <BPJDDPJBEOI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MOPEJEBOFGP
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.Auth]
public class MOPEJEBOFGP
{
    public NDIKICGKOPC <BPJDDPJBEOI>k__BackingField;    // 0x0x10
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
// NCIMKGMBOGO
//   RESPONSE GET    api/playerevents/v1/all   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/all/{aDKBDELMJDI}   [Service.Auth]
public class NCIMKGMBOGO
{
    public List<ILKPFMBHNJM> <OGNKGCHCGCH>k__BackingField;    // 0x0x10
    public List<FHLHHNLGBFN> <BFGALMCCLEP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NDIKICGKOPC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NDIKICGKOPC
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
// NFKDCCLFIGB
//   (not directly referenced by a detected call)
public class NFKDCCLFIGB
{
    public int <CIDBCCEKCMD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NJAGAJEGKJL
//   RESPONSE ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds/v2   [Service.Auth]
public class NJAGAJEGKJL
{
    public Dictionary<Guid, List<FKHDMFGEIJL>> <ADFMEMHCBFG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OAFFOBDCMDA
// base   : ILKPFMBHNJM
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class OAFFOBDCMDA : ILKPFMBHNJM
{
    public List<LMJKCPMLDKE> <HNJLDEDHMIJ>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// OCIDGHAABHC
//   (not directly referenced by a detected call)
public class OCIDGHAABHC
{
    public int <ECEJFPDGMAD>k__BackingField;    // 0x0x10
    public DateTime? <ALPFEJCFKMI>k__BackingField;    // 0x0x18
    public DateTime? <BLJEFJDLGJI>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// OGDDLPIPFFD
//   REQUEST  POST   api/playerevents/v1/respond   [Service.Auth]
public class OGDDLPIPFFD
{
    public long <CGFCLLPLEPC>k__BackingField;    // 0x0x10
    public KAFPLPPMFCJ <INCPBMKOOBM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OLFMIINBKHA
//   RESPONSE GET    api/config/v1/backtrace   [Service.Auth]
public class OLFMIINBKHA
{
    public int <GOHGNLOFMBA>k__BackingField;    // 0x0x10
    public int <HAOJOEGDOOD>k__BackingField;    // 0x0x14
    public float <CKBLJEAGIOP>k__BackingField;    // 0x0x18
    public int <GPLOAKGAGCM>k__BackingField;    // 0x0x1C
    public int <MJKJAEJLJCJ>k__BackingField;    // 0x0x20
    public int <LMFGOAJINHD>k__BackingField;    // 0x0x24
    public int <DLLAGDJIHIG>k__BackingField;    // 0x0x28
    public string <MJKPDEKCGGI>k__BackingField;    // 0x0x30
    public string <OCKHKBFKAKC>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// OMHCDHMMEAK
//   (not directly referenced by a detected call)
public class OMHCDHMMEAK
{
    public long <HNEHNKCINDM>k__BackingField;    // 0x0x10
    public long <CGFCLLPLEPC>k__BackingField;    // 0x0x18
    public int <CHKJGBIFOAC>k__BackingField;    // 0x0x20
    public DateTime <MLCJKGNAKGB>k__BackingField;    // 0x0x28
    public KAFPLPPMFCJ <INCPBMKOOBM>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// PGEKMOCEDCA
//   REQUEST  POST   api/playerevents/v1/report   [Service.Auth]
public class PGEKMOCEDCA
{
    public HPNGBDGBJDM <NMBKOGEANHN>k__BackingField;    // 0x0x10
    public long <CGFCLLPLEPC>k__BackingField;    // 0x0x18
    public string <MHHIGKAIPGC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PGPEAPANHDK
//   (not directly referenced by a detected call)
public class PGPEAPANHDK
{
    public Guid <EPDHDACGJFH>k__BackingField;    // 0x0x10
    public int <FALAOPMADHJ>k__BackingField;    // 0x0x20
    public int <ABCOOLPADIF>k__BackingField;    // 0x0x24
    public Guid <DLAKLCDMECD>k__BackingField;    // 0x0x28
    public DateTime <ADLDHHHDKHB>k__BackingField;    // 0x0x38
    public AGJFDECNMDH <GJCFJCKNABE>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// PIDKFCEPDOJ
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.WWW]
public class PIDKFCEPDOJ
{
    public Guid <HCDFLENBPFP>k__BackingField;    // 0x0x10
    public int <OAKPLHBFEPM>k__BackingField;    // 0x0x20
    public long <KJKBGBMOEJA>k__BackingField;    // 0x0x28
    public Guid <LPEFMKBLMHB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// PKEOLIEIEFH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PKEOLIEIEFH
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
// PMICDKHILIC
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.WWW]
public class PMICDKHILIC
{
    public List<int> <OOEPJCDFDGN>k__BackingField;    // 0x0x10
    public string <DOJPPMEIAJM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PMOEPLPJGLB
//   REQUEST  PUT    api/customAvatarItems   [Service.Auth]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
public class PMOEPLPJGLB
{
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x10
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x18
    public int? <OPNCGFJDAOA>k__BackingField;    // 0x0x20
    public MEMJPCPEGPB? <EDEPMPKMEPK>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x10
    public long? <JNGCJIILDLB>k__BackingField;    // 0x0x18
    public HEJGHJHBLCB <CEFFDBJCGNO>k__BackingField;    // 0x0x28
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
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.Auth]
public class AppleMusicPromotionResponseDTO
{
    public EEKPCKOOGPO <BPJDDPJBEOI>k__BackingField;    // 0x0x10
    public string <NNDJBGOPDFO>k__BackingField;    // 0x0x18
    public string <HDNBNLNIKHI>k__BackingField;    // 0x0x20
    public string <FALHIIBBEPI>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public ADGBDONCEKE <CurrencyType>k__BackingField;    // 0x0x18
    public AHIJIJKAOCO <BalanceType>k__BackingField;    // 0x0x1C
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
    public long <CGFCLLPLEPC>k__BackingField;    // 0x0x10
    public long? <CBJFKGANHKN>k__BackingField;    // 0x0x18
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
    public DNEOMDNGKPO FilterType;    // 0x0x20
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
    public HEJGHJHBLCB <HOGOAMOELNP>k__BackingField;    // 0x0x10
    public string <JOLNMKJFGMI>k__BackingField;    // 0x0x18
    public int <GCHOIOEPNDH>k__BackingField;    // 0x0x20
    public int <AMIELDMHOMI>k__BackingField;    // 0x0x24
    public string <ADDOBKIKJHA>k__BackingField;    // 0x0x28
    public string <AKNCEFBKECE>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <FALAOPMADHJ>k__BackingField;    // 0x0x10
    public Guid <OODFHILMGIJ>k__BackingField;    // 0x0x14
    public DateTime <KNKFGFOPEGD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.Auth]
public class KeepsakeGlobalConfigDTO
{
    public bool <AFPGOOJIMKL>k__BackingField;    // 0x0x10
    public int <AAHJNJCJKJP>k__BackingField;    // 0x0x14
    public bool <NHGDCKDHMPM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <OODFHILMGIJ>k__BackingField;    // 0x0x10
    public HEJGHJHBLCB <PIJOFEGGIME>k__BackingField;    // 0x0x20
    public int <GDOBBLOKALM>k__BackingField;    // 0x0x24
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x28
    public long? <JNGCJIILDLB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.Auth]
//   RESPONSE GET    api/keepsakes/events/{nJDNKLCCOMD}   [Service.Auth]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <DNOLGFJCABH>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <NCHFBHIBCBA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <NCGBPKPCJNO>k__BackingField;    // 0x0x10
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x18
    public long <MJLLGFEPGPB>k__BackingField;    // 0x0x20
    public KEIDIPHHKEB <INCPBMKOOBM>k__BackingField;    // 0x0x28
    public int <IOMDIEOOCEE>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <AAJIAGNKOPM>k__BackingField;    // 0x0x10
    public List<Guid> <NOCDOJIPBEI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <DNOLGFJCABH>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <NCHFBHIBCBA>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <PNDMBKBJJJJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <MJLLGFEPGPB>k__BackingField;    // 0x0x10
    public long <GNKCMEEMIDJ>k__BackingField;    // 0x0x18
    public int? <GLDPHLOGPAI>k__BackingField;    // 0x0x20
    public int? <KJOFEKODCJO>k__BackingField;    // 0x0x28
    public long? <CEBCLFAAENE>k__BackingField;    // 0x0x30
    public long <GNBIHGHCLCF>k__BackingField;    // 0x0x40
    public long <IGGACDELAJL>k__BackingField;    // 0x0x48
    public int <CBOIPMPEMDE>k__BackingField;    // 0x0x50
    public KEIDIPHHKEB <FNGMDIOBBKH>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <FINEAECIPAL>k__BackingField;    // 0x0x58
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
    public PKEOLIEIEFH <GiftContext>k__BackingField;    // 0x0x20
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
    public COEKCFMGBLF creatorAccountRole;    // 0x0x60
    public long? convertedFromInventionId;    // 0x0x68
    public string displayMetadataJson;    // 0x0x78
    public string longDescription;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public NDOFHBMEJKB <ALPNOJFEAJP>k__BackingField;    // 0x0x10
    public CAHJBDKGBNF <LMLIOEBOIDB>k__BackingField;    // 0x0x14
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x18
    public string <BLFDFIMMHON>k__BackingField;    // 0x0x20
    public bool <EMKJMBEONAB>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<NDOFHBMEJKB> <JMDPPEJMDCD>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/event/{jHAGJOJLMBG}   [Service.Auth]
public class ProgressionEventDTO
{
    public long <GNKCMEEMIDJ>k__BackingField;    // 0x0x10
    public string <PAJGFPPNNLA>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <EHICOOAMGLC>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <OJKCJIFDEHO>k__BackingField;    // 0x0x28
    public DateTime <BPDDMECPGFG>k__BackingField;    // 0x0x30
    public DateTime <MGPMMIOPNEE>k__BackingField;    // 0x0x38
    public DateTime <OKCIKGDFBLN>k__BackingField;    // 0x0x40
    public bool <NGBMGEJNGAA>k__BackingField;    // 0x0x48
    public int <MBDKGFECPCI>k__BackingField;    // 0x0x4C
    public float <CALKDFOBHOJ>k__BackingField;    // 0x0x50
    public Guid? <OIMCOBOCKCL>k__BackingField;    // 0x0x54
    public string <FGDEJJBKIAG>k__BackingField;    // 0x0x68
    public string <CGDFHDAHBCI>k__BackingField;    // 0x0x70
    public string <IHFIEIGHEGC>k__BackingField;    // 0x0x78
    public string <PJBPDHEFNOO>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <IJOMEHIGGHH>k__BackingField;    // 0x0x10
    public int <NDJCOJPKPFJ>k__BackingField;    // 0x0x20
    public int <KAJOKBNOCMP>k__BackingField;    // 0x0x24
    public int <CDFJADAPPNF>k__BackingField;    // 0x0x28
    public long <JMKKCNNFNAK>k__BackingField;    // 0x0x30
    public long <NFEEJKHGLNF>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.Auth]
public class ProgressionEventRecordDTO
{
    public int <FALAOPMADHJ>k__BackingField;    // 0x0x10
    public int <MIGPCEJFHJI>k__BackingField;    // 0x0x14
    public int <NFEMBHGLMEF>k__BackingField;    // 0x0x18
    public int <ACKBPJEBEIG>k__BackingField;    // 0x0x1C
    public int <JMEGMOIFHMN>k__BackingField;    // 0x0x20
    public DateTime? <KKCJDJFBLEP>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <EIAJBGAMBFN>k__BackingField;    // 0x0x10
    public int <DJGHIKBEOBP>k__BackingField;    // 0x0x18
    public string <HGHMNOJCFPD>k__BackingField;    // 0x0x20
    public int <MIGPCEJFHJI>k__BackingField;    // 0x0x28
    public int <HFBIGLFINOD>k__BackingField;    // 0x0x2C
    public bool <IOFIKDGCDED>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.PublishInventionRequest
//   REQUEST  POST   api/inventions/v4/publish   [Service.Matchmaking]
public class PublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public LFLOAHHDFKI <Permission>k__BackingField;    // 0x0x18
    public MEMJPCPEGPB <Accessibility>k__BackingField;    // 0x0x1C
    public int? <Price>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.Auth]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public OIAGIIBAEHE ReportCategory;    // 0x0x20
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
    public LFLOAHHDFKI <Permission>k__BackingField;    // 0x0x18
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
//   RESPONSE DELETE api/roomkeys/v1/delete/{gAKNGADDBBM}   [Service.WWW]
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
    public bool OKNDFMMHNEP;    // 0x0x28
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
    public GMAJPDGKPKM? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [Auth POST]
public class PlayerCheerV1CreateRequest
{
    public GMAJPDGKPKM DPPCBOFHNCE;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [Auth POST]
public class PlayerReportingV1DeviceIdRequest
{
    public JFGFJBAFOGP CHLMLGKNBHB;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [Auth POST]
public class PlayerReportingV1HileRequest
{
    public PECMLCGKJJM FIFJJNIIAPF;  // wrapper
    public int? POEPPCOKJMD;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v1/modKick  [Auth POST]
public class PlayerReportingV1ModKickRequest
{
    public HPNGBDGBJDM PNBLEANGOCK;  // wrapper
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
    public byte[] BFLLAIFBMAJ;  // wrapper
    public HFHCFMIEIMN DNEOKGEBHFD;  // wrapper
    public object meta;  // candidate
    public object data;  // candidate
    public object file.bin;  // candidate
}

// api/PlayerReporting/v3/create  [Auth POST]
public class PlayerReportingV3CreateRequest
{
    public HPNGBDGBJDM ACBKHLFMHAG;  // wrapper
    public float? HIIMLIAMJJP;  // wrapper
    public bool? CEHBFAAGCNL;  // wrapper
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
    public List<DMMPCDIHBGH> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [WWW POST]
public class AvatarV2GiftsGenerateRequest
{
    public PKEOLIEIEFH PDMONEGPHPK;  // wrapper
    public PKEOLIEIEFH? GLGMNOJKBGD;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [WWW POST]
public class AvatarV3GiftsGenerateRequest
{
    public PKEOLIEIEFH PDMONEGPHPK;  // wrapper
    public PKEOLIEIEFH? GLGMNOJKBGD;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [Auth POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage LFKIGNHCOID;  // wrapper
    public JDLMNHLBMOD ACBKHLFMHAG;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [Auth POST]
public class ClubreportingV1ReportRequest
{
    public HPNGBDGBJDM ACBKHLFMHAG;  // wrapper
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
    public MEMJPCPEGPB JEEDFIDDHGM;  // wrapper
    public DGPECKIBNLF OPKHACEMMMH;  // wrapper
    public PAFLMOOHACI JCOGJCGILAK;  // wrapper
    public PAFLMOOHACI JMDDODPFEMH;  // wrapper
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
    public object outfitTypes;  // candidate
    public object minPrice;  // candidate
    public object isOwned;  // candidate
    public object itemTypes;  // candidate
    public object isFeatured;  // candidate
}

// api/customAvatarItems/v1/{nDNNLJBLELL}/appeal  [Auth POST]
public class CustomAvatarItemsV1NDNNLJBLELLAppealRequest
{
    public Guid NDNNLJBLELL;  // wrapper
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
    public IINPNOICGPB JKAEFCPKKCI;  // wrapper
    public PKEOLIEIEFH? DALGEGMKLIE;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [WWW POST]
public class GamerewardsV1SelectRequest
{
    public PKAFJJILNHF GGAGFFKEPCJ;  // wrapper
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

// api/keepsakes/{pGLONPJBOEL}/collect  [Auth POST]
public class KeepsakesPGLONPJBOELCollectRequest
{
    public Guid PGLONPJBOEL;  // wrapper
}

// api/messages/v2/send  [Auth POST]
public class MessagesV2SendRequest
{
    public KDEICACCAFC DKMDFAFCDMC;  // wrapper
    public long? GLOFJPFEAOO;  // wrapper
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
    public IReadOnlyCollection<long> JMICECDDPIB;  // wrapper
}

// api/playerevents/v2/delete/{eventId}  [Auth POST]
public class PlayereventsV2DeleteEventIdRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [Auth PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
    public ILCCMMMKCFH HNIEIPOBIGG;  // wrapper
    public ILCCMMMKCFH JEEDFIDDHGM;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [Auth PUT]
public class PlayereventsV2EventIdClubRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
    public long? PDBGLMFCLIM;  // wrapper
    public long? BCDMMOHMLCO;  // wrapper
}

// api/playerevents/v2/{eventId}/description  [Auth PUT]
public class PlayereventsV2EventIdDescriptionRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
}

// api/playerevents/v2/{eventId}/image  [Auth PUT]
public class PlayereventsV2EventIdImageRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [Auth PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
    public ECEGFBKHKGB EOOIDBLOJOI;  // wrapper
    public ECEGFBKHKGB PFHKCJCKNFA;  // wrapper
}

// api/playerevents/v2/{eventId}/name  [Auth PUT]
public class PlayereventsV2EventIdNameRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [Auth PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
    public long? OBHMCHCFEHN;  // wrapper
    public long? GPIHEOKIECF;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [Auth PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public ILKPFMBHNJM HFMBBCPPOHA;  // wrapper
    public DateTime EGCEPKOEHEP;  // wrapper
    public DateTime EKGEJPJPAFM;  // wrapper
    public DateTime OPAEOLIADNO;  // wrapper
    public DateTime LJEFIFPGOMC;  // wrapper
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
    public HPNGBDGBJDM ACBKHLFMHAG;  // wrapper
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
    public Guid MONIHHEFMPI;  // wrapper
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
    public Guid PMHDLNLHBNH;  // wrapper
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
    public Guid PMHDLNLHBNH;  // wrapper
    public long? ACACEAHEKDB;  // wrapper
    public byte? HMAFPCMGLCM;  // wrapper
    public int? NKKLIFIFGAP;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid MONIHHEFMPI;  // wrapper
    public long? ILMOEOPPFGN;  // wrapper
    public long? DKOPHAJPMLH;  // wrapper
    public int? KPNDJCKMECH;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [WWW PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> HHLMDDDPFNI;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [WWW POST]
public class RoomkeysV1CreateRequest
{
    public MIAAEAGOENI FIFJJNIIAPF;  // wrapper
    public Guid? BLBGINNJFLK;  // wrapper
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
    public HPNGBDGBJDM ACBKHLFMHAG;  // wrapper
    public long? AHDKAMGMIIF;  // wrapper
    public Guid? KAKDGOHNIOK;  // wrapper
    public int? NCAJOMJJMGG;  // wrapper
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
    public Guid GLEJCELMGBN;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [WWW POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid GGGKCMGGLBO;  // wrapper
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
    public BFPKBDBKIJA NPMCMCNMJNP;  // wrapper
}

