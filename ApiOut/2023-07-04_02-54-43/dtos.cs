// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 256 (plus referenced enums)

// --------------------------------------------------------------------------
// ABOFPFJJJHC
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class ABOFPFJJJHC
{
    public bool <IOFACDNDMKM>k__BackingField;    // 0x0x10
    public string <IIOGMFDFGEH>k__BackingField;    // 0x0x18
    public string <KLCMODDJDAK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AEMMNFLPGON
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class AEMMNFLPGON
{
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x10
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x18
    public int? <BBAMKHAPNAH>k__BackingField;    // 0x0x20
    public KEEEIICNMDG? <LKPIIGBABKA>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// AEOKPNKIBAH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AEOKPNKIBAH
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
// AGJIPKNGKJK
//   (not directly referenced by a detected call)
public class AGJIPKNGKJK
{
    public int <LEJOJIOFBPO>k__BackingField;    // 0x0x10
    public DNMGKGKMJPM <GLIMPMIAKLA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AHPLKPCDKJB
// base   : LJHMKMNOODN
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.Econ]
public class AHPLKPCDKJB : LJHMKMNOODN
{
    public List<NBFLCLCKEFD> MPMJIBDCJHJ;    // 0x0x30
    public int <DFIIBJHMKPO>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// AIHCMDJFJOD
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class AIHCMDJFJOD
{
    public ACLOKBCJMHF <HMDDMEJKNNG>k__BackingField;    // 0x0x10
    public string <DBGCEJENMAK>k__BackingField;    // 0x0x18
    public int? <DILAKDLNPBC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ALJBCKLNABN
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class ALJBCKLNABN
{
    public long <HGPFPAFMCPK>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <PBNFMGOJHJL>k__BackingField;    // 0x0x18
    public OHFJGCCKOGD <AKHFBOFHMJN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AMDOMBCDJEG
//   (not directly referenced by a detected call)
public class AMDOMBCDJEG
{
    public DOEKJNLHOAI <AMDKKOOBOGJ>k__BackingField;    // 0x0x10
    public int <BBAMKHAPNAH>k__BackingField;    // 0x0x14
    public PODPMAENOJM <EEDLEFHHPIM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AMJIGHPFBDJ
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class AMJIGHPFBDJ
{
    public FGMDGNJAKAB <HMDDMEJKNNG>k__BackingField;    // 0x0x10
    public int <FOOELJLMMKE>k__BackingField;    // 0x0x14
    public long <JKFOPPAGNDA>k__BackingField;    // 0x0x18
    public bool <INNAIIJGMKL>k__BackingField;    // 0x0x20
    public string <LMMLGGAHGGK>k__BackingField;    // 0x0x28
    public int? <FLAAEAOLFAH>k__BackingField;    // 0x0x30
    public bool <BMKPBLPJLJL>k__BackingField;    // 0x0x38
    public bool <GPAOAGLJINM>k__BackingField;    // 0x0x39
    public bool <JBMBAKAKCPO>k__BackingField;    // 0x0x3A
    public bool <BALBACDNONG>k__BackingField;    // 0x0x3B
    public string <LGOFNOFGDMJ>k__BackingField;    // 0x0x40
    public DateTime? <KKGDECPKMOA>k__BackingField;    // 0x0x48
    public float <CGGHPCOHEAC>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// AOMNEOICFMJ
//   (not directly referenced by a detected call)
public class AOMNEOICFMJ
{
    public long <BBAMKHAPNAH>k__BackingField;    // 0x0x10
    public Guid? <BCGDBKHPMJP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BDLDMNMEKBO
//   (not directly referenced by a detected call)
public class BDLDMNMEKBO
{
    public int <KBJFBALLLJN>k__BackingField;    // 0x0x10
    public DPGNCMBMIGI <OOGNDPHIEBE>k__BackingField;    // 0x0x14
    public List<AMDOMBCDJEG> <IIBCAMCLFBA>k__BackingField;    // 0x0x18
    public List<AMDOMBCDJEG> <LKGDLEABNNO>k__BackingField;    // 0x0x20
    public bool <LHAOBHMHKCF>k__BackingField;    // 0x0x28
    public DateTime? <LJGOJMOKPNL>k__BackingField;    // 0x0x30
    public DateTime? <NLBBPJEPBBG>k__BackingField;    // 0x0x40
    public DateTime? <FDMJBHLIBDL>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// BFGPOPPFKCE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BFGPOPPFKCE
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// BLPGODDNBHA
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class BLPGODDNBHA
{
    public List<PAKJJJEHEPI> <HOFEDMLKPGJ>k__BackingField;    // 0x0x10
    public HHMNFHKFPNB <JOHKPEFPAHB>k__BackingField;    // 0x0x18
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
// CBGJNHHEJJA
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Auth]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class CBGJNHHEJJA
{
    public int <MOMGFGIKBHF>k__BackingField;    // 0x0x10
    public bool <JKNNNNFCAFN>k__BackingField;    // 0x0x14
    public DateTime <JKLPDJJICPO>k__BackingField;    // 0x0x18
    public bool <HHFJHDNLABA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CBMKAGAHPOM
// base   : System.Enum
//   RESPONSE ?      api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{cNCCCOEPINK}   [Service.Econ]
public enum CBMKAGAHPOM
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
// CDIBJCHJBGN
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class CDIBJCHJBGN
{
    public int <BLJBCMOFCLC>k__BackingField;    // 0x0x10
    public AAJAHBFNBMK <OOGNDPHIEBE>k__BackingField;    // 0x0x14
    public BLBKDIBPHGM <CLFBICCCKAH>k__BackingField;    // 0x0x18
    public BLBKDIBPHGM <GEJCAMMKHGL>k__BackingField;    // 0x0x1C
    public BLBKDIBPHGM <AJOAJFGCMMC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CGIAOGJPCKF
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class CGIAOGJPCKF
{
    public int <NFHIDFPHHAF>k__BackingField;    // 0x0x10
    public int <IOOFLICECNM>k__BackingField;    // 0x0x14
    public float <LPMJBEJHHED>k__BackingField;    // 0x0x18
    public int <JHOHGKIPCGF>k__BackingField;    // 0x0x1C
    public int <LKPNPHLFHIL>k__BackingField;    // 0x0x20
    public int <PONOBNCAGHB>k__BackingField;    // 0x0x24
    public int <IPLHMFCCNKG>k__BackingField;    // 0x0x28
    public string <MNENIHIPLIA>k__BackingField;    // 0x0x30
    public string <KMIKNINCPBO>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// CJGNGEOHFMJ
//   RESPONSE ?      api/avatar/   [Service.Econ]
//   RESPONSE GET    api/avatar/v2   [Service.Econ]
//   REQUEST  POST   api/avatar/v2/set   [Service.Econ]
//   RESPONSE GET    api/avatar/v2/{dCMDLBGKIGH}   [Service.Econ]
public class CJGNGEOHFMJ
{
    public string <JBFPLBPBIBP>k__BackingField;    // 0x0x10
    public string <JHGAPMFKHHB>k__BackingField;    // 0x0x18
    public string <LBLDPKKIHEG>k__BackingField;    // 0x0x20
    public string <EMBDLJJPFCJ>k__BackingField;    // 0x0x28
    public string <GNNGDHIOHNO>k__BackingField;    // 0x0x30
    public List<HCNINAANKCB> <OMOHGFMIEMK>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// CKFOGPIBCMD
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class CKFOGPIBCMD
{
    public DNMGKGKMJPM <GLIMPMIAKLA>k__BackingField;    // 0x0x10
    public AOMNEOICFMJ <KFFFPNGNEBG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CLHDNMIGPGE
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class CLHDNMIGPGE
{
    public Dictionary<Guid, LGMIGMMMNPJ> <ACOAGLPHJDB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// CNMJABJDFDP
//   (not directly referenced by a detected call)
public class CNMJABJDFDP
{
    public long <ACOPCALOILH>k__BackingField;    // 0x0x10
    public string <HKCHFAOGENL>k__BackingField;    // 0x0x18
    public int <OAMNBANJJJM>k__BackingField;    // 0x0x20
    public int <IADNAFEAKGF>k__BackingField;    // 0x0x24
    public int <IGCPMNEEJEO>k__BackingField;    // 0x0x28
    public int <ALGLEBFCHMG>k__BackingField;    // 0x0x2C
    public int <LPBNMNNPBMK>k__BackingField;    // 0x0x30
    public string <PHJNKPCPLPJ>k__BackingField;    // 0x0x38
    public string <GAPPEPPCFAK>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// COHCDIBPNJL
//   (not directly referenced by a detected call)
public class COHCDIBPNJL
{
    public float <EMGJPPDCBDF>k__BackingField;    // 0x0x10
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
// DCMMIEGCNKB
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{kNDPDJMHLDC}   [Service.Econ]
public class DCMMIEGCNKB
{
    public AEOKPNKIBAH <JGCCAMLMKGO>k__BackingField;    // 0x0x10
    public NNGPLLEAKAM <BOECCNAJGGO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DEDBIKHBEPM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DEDBIKHBEPM
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
    CustomAvatarItems = 1800,
    ProgressionEventPurchasableXpBoosts = 1900,
    PopUpShop_ProgressionEvent_1 = 2000,
    PopUpShop_ProgressionEvent_2 = 2001,
    PopUpShop_ProgressionEvent_3 = 2002,
    PopUpShop_ProgressionEvent_4 = 2003,
    PopUpShop_ProgressionEvent_5 = 2004,
}

// --------------------------------------------------------------------------
// DEJBLEMMOFN
//   (not directly referenced by a detected call)
public class DEJBLEMMOFN
{
    public ObscuredLong <ACOPCALOILH>k__BackingField;    // 0x0x10
    public string <HKCHFAOGENL>k__BackingField;    // 0x0x38
    public ObscuredInt <MKHAJNCCCIL>k__BackingField;    // 0x0x40
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x58
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x60
    public string <IIGHEPEOFIN>k__BackingField;    // 0x0x68
    public int <FNHNMIDLHNK>k__BackingField;    // 0x0x70
    public KEEEIICNMDG <LKPIIGBABKA>k__BackingField;    // 0x0x74
    public DateTime <MGPMAJMFHJJ>k__BackingField;    // 0x0x78
    public DateTime <ALIJOOMMGGF>k__BackingField;    // 0x0x80
    public DateTime? <AGNNHGGFLGD>k__BackingField;    // 0x0x88
    public long? <LGPLGLJIGMG>k__BackingField;    // 0x0x98
    public int <MIFEDBEAKCO>k__BackingField;    // 0x0xA8
    public int <ILPCDFEEKMN>k__BackingField;    // 0x0xAC
    public int <CPPOFAAGMPD>k__BackingField;    // 0x0xB0
    public KOGOHEGFGAJ <ANHJCJOCCPB>k__BackingField;    // 0x0xB4
    public KOGOHEGFGAJ <IMHDFDPMBNN>k__BackingField;    // 0x0xB8
    public ObscuredBool <NMNIJPJGNIA>k__BackingField;    // 0x0xBC
    public ObscuredBool <LIAHEAFHILB>k__BackingField;    // 0x0xC8
    public ObscuredBool <MIIOLAAAOJC>k__BackingField;    // 0x0xD4
    public int? <BBAMKHAPNAH>k__BackingField;    // 0x0xE0
    public bool <FAAAJGIDDMI>k__BackingField;    // 0x0xE8
}

// --------------------------------------------------------------------------
// DIMEDNDDELG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DIMEDNDDELG
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
// DNMGKGKMJPM
//   REQUEST  ?      api/roomconsumables   [Service.Econ]
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.Econ]
public class DNMGKGKMJPM
{
    public Guid? <JNHBKLKPBCN>k__BackingField;    // 0x0x10
    public Guid <ABNHFLLMDKL>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// DNMPFOAKJKM
//   (not directly referenced by a detected call)
public class DNMPFOAKJKM
{
    public int <EHOGPLJCGDA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DOEKJNLHOAI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DOEKJNLHOAI
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
// DPGNCMBMIGI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DPGNCMBMIGI
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// EAKLMAHGICO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EAKLMAHGICO
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
// EAOFMJOICIG
//   (not directly referenced by a detected call)
public class EAOFMJOICIG
{
    public DIMEDNDDELG LAKPKCKINJP;    // 0x0x10
    public int BHEKNNLNPKH;    // 0x0x14
}

// --------------------------------------------------------------------------
// EGEKMHNCGNL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EGEKMHNCGNL
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
// EHHMGGECDOA
//   (not directly referenced by a detected call)
public class EHHMGGECDOA
{
    public int <AAJEKIKCJEO>k__BackingField;    // 0x0x10
    public DateTime <ALIJOOMMGGF>k__BackingField;    // 0x0x18
    public DateTime? <IDIFKCBOEDO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EIBOPIMIMKI
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class EIBOPIMIMKI
{
    public Guid? <LDMCIMEPMHB>k__BackingField;    // 0x0x10
    public long? <HGPFPAFMCPK>k__BackingField;    // 0x0x28
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x38
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x40
    public string <IIGHEPEOFIN>k__BackingField;    // 0x0x48
    public AOMNEOICFMJ <GKJCMBJOPAK>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// ELAMIEDJNFF
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
public class ELAMIEDJNFF
{
    public string <FIIOHEBIOFC>k__BackingField;    // 0x0x10
    public string <HLKHCBPDIKN>k__BackingField;    // 0x0x18
    public bool <NGCBOFOIGOE>k__BackingField;    // 0x0x20
    public string <NNEBDNDMPEG>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// EMLMGGDEFNL
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class EMLMGGDEFNL
{
    public List<LPMKOMGMBBP> <MHIMEJFCKHG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// EPGEJJGMFGJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EPGEJJGMFGJ
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
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
// FEOJLOHGGMD
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class FEOJLOHGGMD
{
    public long <EBCKLJFEKBI>k__BackingField;    // 0x0x10
    public int <MKHAJNCCCIL>k__BackingField;    // 0x0x18
    public long <HGPFPAFMCPK>k__BackingField;    // 0x0x20
    public long? <AJKNGOFKKBI>k__BackingField;    // 0x0x28
    public long? <LHILICPGIAG>k__BackingField;    // 0x0x38
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x48
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x50
    public string <IIGHEPEOFIN>k__BackingField;    // 0x0x58
    public DateTime <IKIPILOPAAC>k__BackingField;    // 0x0x60
    public DateTime <PCKKENLHOND>k__BackingField;    // 0x0x68
    public int <LGPNOBJDPBM>k__BackingField;    // 0x0x70
    public EPGEJJGMFGJ <LKPIIGBABKA>k__BackingField;    // 0x0x74
    public bool <KOIBCBIJCGA>k__BackingField;    // 0x0x78
    public bool <KJBGDIAMKIL>k__BackingField;    // 0x0x79
    public GFMHBMEMAKI <BAGJPHKKGJO>k__BackingField;    // 0x0x7C
    public GFMHBMEMAKI <EJNOHKCDADP>k__BackingField;    // 0x0x80
    public long? <LJJHKPHNGCI>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// FGKIDNNDELB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FGKIDNNDELB
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// FGNMMGKNPNF
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class FGNMMGKNPNF
{
    public HHMNFHKFPNB <JOHKPEFPAHB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FHMJLOHHCHC
//   (not directly referenced by a detected call)
public class FHMJLOHHCHC
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// FJAMHDAFDGB
//   (not directly referenced by a detected call)
public class FJAMHDAFDGB
{
    public bool <BCJDKDDDCKL>k__BackingField;    // 0x0x10
    public OKFLCGDBGOC <PPGBDICIILI>k__BackingField;    // 0x0x18
    public float <IHBDHKHJLIB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// FNCHBKKMEAJ
//   (not directly referenced by a detected call)
public class FNCHBKKMEAJ
{
    public Guid <NJMOAFHLBPD>k__BackingField;    // 0x0x10
    public Guid <JEPICKICDHD>k__BackingField;    // 0x0x20
    public DateTime <LHFOCJAJEPO>k__BackingField;    // 0x0x30
    public List<OKFLCGDBGOC> <AJFHEHCMICN>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// GBANIBNKDCN
//   (not directly referenced by a detected call)
public class GBANIBNKDCN
{
    public Guid <LDMCIMEPMHB>k__BackingField;    // 0x0x10
    public int <JGPJHBIDMKK>k__BackingField;    // 0x0x20
    public int <DILGMJKNPHF>k__BackingField;    // 0x0x24
    public Guid <AJIMABHMLLO>k__BackingField;    // 0x0x28
    public DateTime <MGPMAJMFHJJ>k__BackingField;    // 0x0x38
    public NNGPLLEAKAM <BOECCNAJGGO>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// GCAIIGGGLKG
//   (not directly referenced by a detected call)
public class GCAIIGGGLKG
{
    public float <GBMGECDPBMD>k__BackingField;    // 0x0x10
    public float <EONGEBOMKHM>k__BackingField;    // 0x0x14
    public float <JJLOCLCGKNE>k__BackingField;    // 0x0x18
    public float <MADCIEMDFIM>k__BackingField;    // 0x0x1C
    public float <LFEOLMOFNLF>k__BackingField;    // 0x0x20
    public float <LKIEDBOEPIF>k__BackingField;    // 0x0x24
    public float <DEEGMAEMJDO>k__BackingField;    // 0x0x28
    public float <AAEALMPJDNH>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// GFMHBMEMAKI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GFMHBMEMAKI
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// GKJLJOIMKFI
// base   : PDJLNBMLJNG
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class GKJLJOIMKFI : PDJLNBMLJNG
{
    public EDAMANKPFOA? <EIFBHNCNBLE>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <BPBGPCGAEOB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HCDJJFCPDDP
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{balanceaddtypeId}/False   [Service.Econ]
public class HCDJJFCPDDP
{
    public DOEKJNLHOAI <AMDKKOOBOGJ>k__BackingField;    // 0x0x10
    public HELGKMILCOD <LAJKPEGMFKC>k__BackingField;    // 0x0x14
    public int <NCEODJKIGGJ>k__BackingField;    // 0x0x18
    public int <CLPNFBJMGMH>k__BackingField;    // 0x0x1C
    public int <MLFLGBHMGPF>k__BackingField;    // 0x0x20
    public FGKIDNNDELB <OPOEKMEAGDC>k__BackingField;    // 0x0x24
    public bool <JAMMBFIILMP>k__BackingField;    // 0x0x28
    public float <JGECHDMLGMK>k__BackingField;    // 0x0x2C
    public int <HPGELMMNECE>k__BackingField;    // 0x0x30
    public bool <IBAHAGLPACD>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// HCNINAANKCB
//   (not directly referenced by a detected call)
public class HCNINAANKCB
{
    public Guid <BMGJEFHDMGJ>k__BackingField;    // 0x0x10
    public byte <NNFALDFHBGC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HDOKFAFEBME
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.Econ]
public class HDOKFAFEBME
{
    public int <BOPOKHOFHBP>k__BackingField;    // 0x0x10
    public string <BFNECKCFMPK>k__BackingField;    // 0x0x18
    public List<KIFAMLKBJHM> <EPJCGGBFMHK>k__BackingField;    // 0x0x20
    public HKHBGNDAFJJ <HJHFOCENNNN>k__BackingField;    // 0x0x28
    public string <LCDAAICGHLD>k__BackingField;    // 0x0x30
    public DateTime <LHFOCJAJEPO>k__BackingField;    // 0x0x38
    public DateTime <FNEMKGLNCAG>k__BackingField;    // 0x0x40
    public DateTime <CCCFLJPNCDM>k__BackingField;    // 0x0x48
    public bool? <HMNOIKPJLCD>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// HELGKMILCOD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HELGKMILCOD
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
// HGMNIDGBAED
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HGMNIDGBAED
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// HHMNFHKFPNB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HHMNFHKFPNB
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
}

// --------------------------------------------------------------------------
// HIKFGGCLDAK
//   REQUEST  ?      api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class HIKFGGCLDAK
{
    public Guid <NGCKDEINOFC>k__BackingField;    // 0x0x10
    public long <DHEHKLFFDNG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HKHBGNDAFJJ
//   (not directly referenced by a detected call)
public class HKHBGNDAFJJ
{
    public long <PCLLNDCPOCG>k__BackingField;    // 0x0x10
    public string <AAMOFKIPFED>k__BackingField;    // 0x0x18
    public string <DHMIFFEJFLK>k__BackingField;    // 0x0x20
    public MICLEHLCMID? <NJCKCNAPDBK>k__BackingField;    // 0x0x28
    public string <LBCDMKLEDFP>k__BackingField;    // 0x0x30
    public string <MGAOJHIHDHF>k__BackingField;    // 0x0x38
    public DEDBIKHBEPM <CFAPGAHHEGF>k__BackingField;    // 0x0x40
    public int <HLFNCJDADNI>k__BackingField;    // 0x0x44
    public int <FFCNIDLIGJC>k__BackingField;    // 0x0x48
    public EGEKMHNCGNL? <FFMHJBHGIBI>k__BackingField;    // 0x0x4C
    public BFGPOPPFKCE? <KPMIEMCGICO>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// HKLMFLEIOIN
//   REQUEST  POST   api/avatar/v4/saved/set   [Service.Econ]
public class HKLMFLEIOIN
{
    public int <LKDFFLEKICF>k__BackingField;    // 0x0x10
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x18
    public string <PHICGPLDOLM>k__BackingField;    // 0x0x20
    public string <JBFPLBPBIBP>k__BackingField;    // 0x0x28
    public string <JHGAPMFKHHB>k__BackingField;    // 0x0x30
    public string <LBLDPKKIHEG>k__BackingField;    // 0x0x38
    public string <EMBDLJJPFCJ>k__BackingField;    // 0x0x40
    public string <GNNGDHIOHNO>k__BackingField;    // 0x0x48
    public KEEEIICNMDG <LKPIIGBABKA>k__BackingField;    // 0x0x50
    public List<HCNINAANKCB> <OMOHGFMIEMK>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// HLJPOIOMMAN
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class HLJPOIOMMAN
{
    public IALKNIJOJIP <JOHKPEFPAHB>k__BackingField;    // 0x0x10
    public List<string> <MHIMEJFCKHG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HNGNGADKFKM
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class HNGNGADKFKM
{
    public List<string> <FBJEDBNGOKM>k__BackingField;    // 0x0x10
    public List<string> <OAHFOJCICOB>k__BackingField;    // 0x0x18
    public List<string> <JGNAGCPPOHF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HOFLFLINLKO
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class HOFLFLINLKO
{
    public string <CKBODBKIDMF>k__BackingField;    // 0x0x10
    public string <IIOGMFDFGEH>k__BackingField;    // 0x0x18
    public string <GIHJMLBHIEP>k__BackingField;    // 0x0x20
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x28
    public string <OFKFGKAIMNK>k__BackingField;    // 0x0x30
    public HOPJIFKGIEL <JGCCAMLMKGO>k__BackingField;    // 0x0x38
    public List<string> <OCPECEEDNLE>k__BackingField;    // 0x0x40
    public List<string> <MHIMEJFCKHG>k__BackingField;    // 0x0x48
    public string <PELMGLNHGAD>k__BackingField;    // 0x0x50
    public List<OAMNOIPABLK> <KAEDFJBBOCA>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// HOPJIFKGIEL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HOPJIFKGIEL
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// HPLPEKBNBHP
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class HPLPEKBNBHP
{
    public List<int> <BMBKMKKPPCK>k__BackingField;    // 0x0x10
    public string <NHBIMHNEIFK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HPPOHGADOJG
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class HPPOHGADOJG
{
    public int <IHCLKMLFJNH>k__BackingField;    // 0x0x10
    public int? <IFGKKHEFOMK>k__BackingField;    // 0x0x14
    public string <EDENIDABEPI>k__BackingField;    // 0x0x20
    public string <LNIBGCGOMNJ>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// IAJDGMPCEGC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IAJDGMPCEGC
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// IALKNIJOJIP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IALKNIJOJIP
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
// IJLECBADMJP
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class IJLECBADMJP
{
    public Dictionary<Guid, AGJIPKNGKJK> <MGBMMBIMDDN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// IKMIPIPHHGC
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Econ]
public class IKMIPIPHHGC
{
    public Guid <ANPPDLECPPN>k__BackingField;    // 0x0x10
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x20
    public string <IIGHEPEOFIN>k__BackingField;    // 0x0x28
    public DateTime <LHFOCJAJEPO>k__BackingField;    // 0x0x30
    public DateTime? <OMLNEJKKKGA>k__BackingField;    // 0x0x38
    public List<FNCHBKKMEAJ> <KCNJKAKMPDP>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// INFHEGBCPFA
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class INFHEGBCPFA
{
    public int <FOOELJLMMKE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JBKIAIBJFFJ
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class JBKIAIBJFFJ
{
    public List<FEOJLOHGGMD> <FLNOGLAGOHP>k__BackingField;    // 0x0x10
    public string <NHBIMHNEIFK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JGMDANEOJLF
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class JGMDANEOJLF
{
    public long <DIIFDAAAGLD>k__BackingField;    // 0x0x10
    public int <JGPJHBIDMKK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JHAMBACPAEK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JHAMBACPAEK
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// JJPKBMIGGLJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JJPKBMIGGLJ
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// JKMEEGEDKKJ
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.Econ]
public class JKMEEGEDKKJ
{
    public List<EHHMGGECDOA> <KKFMIKHIAEJ>k__BackingField;    // 0x0x10
    public string <NHBIMHNEIFK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KAAIPACLKBH
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/inventions/v4/addversion   [Service.API]
//   RESPONSE POST   api/inventions/v6/save   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.Econ]
public class KAAIPACLKBH
{
    public EAKLMAHGICO <JGCCAMLMKGO>k__BackingField;    // 0x0x10
    public DEJBLEMMOFN <NOMIFMGJOHC>k__BackingField;    // 0x0x18
    public CNMJABJDFDP <BDJAPBFPDIH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KBHACLJDECL
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class KBHACLJDECL
{
    public int <JJGJJGGPFNM>k__BackingField;    // 0x0x10
    public int <MOMGFGIKBHF>k__BackingField;    // 0x0x14
    public float <IIICOPMKBHK>k__BackingField;    // 0x0x18
    public float <NCAINLNOCDL>k__BackingField;    // 0x0x1C
    public bool <JKNNNNFCAFN>k__BackingField;    // 0x0x20
    public bool <MIINFGGHCLC>k__BackingField;    // 0x0x21
    public bool <NGHKOHADMJD>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// KIBGNFDCLNL
//   RESPONSE PUT    api/avatar/v4/saved/name   [Service.Econ]
//   RESPONSE POST   api/avatar/v4/saved/set   [Service.Econ]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.Econ]
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.API]
//   RESPONSE PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.Econ]
//   RESPONSE POST   api/gamesight/event   [Service.API]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.Econ]
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE DELETE api/keepsakes/{bHBNPLODPJC}   [Service.API]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
public class KIBGNFDCLNL
{
    public bool <LBOPPJGAIEN>k__BackingField;    // 0x0x10
    public string <OIBENAMLIMJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KIFAMLKBJHM
//   (not directly referenced by a detected call)
public class KIFAMLKBJHM
{
    public int <PFIFENAFLEB>k__BackingField;    // 0x0x10
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x18
    public string <DIHABAOBGEF>k__BackingField;    // 0x0x20
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x28
    public string <HDMOOGIANJC>k__BackingField;    // 0x0x30
    public bool <OIFBNIFEFJG>k__BackingField;    // 0x0x38
    public int <LKDFFLEKICF>k__BackingField;    // 0x0x3C
    public FHMJLOHHCHC <JKGGMFBFGMJ>k__BackingField;    // 0x0x40
    public FNFFDFFBKBL LAFGBLLKOOI;    // 0x0x48
    public FNFFDFFBKBL FINEMBJJHKP;    // 0x0x50
    public FNFFDFFBKBL HLLEHENPEHH;    // 0x0x58
    public DAOIHHLPFKM KGFFEBHNKJO;    // 0x0x60
}

// --------------------------------------------------------------------------
// KKFANPLCKCC
//   (not directly referenced by a detected call)
public class KKFANPLCKCC
{
    public FEOJLOHGGMD <OKKKILAFNKD>k__BackingField;    // 0x0x10
    public MNDOCHBLAGJ <IGDEOBKCFKJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KMEBGANIBFG
//   (not directly referenced by a detected call)
public class KMEBGANIBFG
{
    public long <DIIFDAAAGLD>k__BackingField;    // 0x0x10
    public Guid <HKCHFAOGENL>k__BackingField;    // 0x0x18
    public long <HGPFPAFMCPK>k__BackingField;    // 0x0x28
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x30
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x38
    public int <BBAMKHAPNAH>k__BackingField;    // 0x0x40
    public Guid? <MPAPJIJDHGC>k__BackingField;    // 0x0x44
    public DateTime <ALIJOOMMGGF>k__BackingField;    // 0x0x58
    public string <IIGHEPEOFIN>k__BackingField;    // 0x0x60
    public JHAMBACPAEK <OOGNDPHIEBE>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// KNIPELEAIMI
//   (not directly referenced by a detected call)
public class KNIPELEAIMI
{
    public bool <DNNGLFCJKNE>k__BackingField;    // 0x0x10
    public OOCPHAFHJHN <KHMPOAAHCJI>k__BackingField;    // 0x0x14
    public int <BNABMNDDAPA>k__BackingField;    // 0x0x18
    public DateTime <MGPMAJMFHJJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KOGOHEGFGAJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KOGOHEGFGAJ
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
// LCDPKMCDJMJ
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{dCMDLBGKIGH}   [Service.API]
public class LCDPKMCDJMJ
{
    public List<FEOJLOHGGMD> <IIILHDHGBJF>k__BackingField;    // 0x0x10
    public List<KKFANPLCKCC> <LMNJEFECLGE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LGMIGMMMNPJ
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.Econ]
public class LGMIGMMMNPJ
{
    public AEOKPNKIBAH <JGCCAMLMKGO>k__BackingField;    // 0x0x10
    public GBANIBNKDCN <LFNJFKFGFNH>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LHCHIOANGPD
//   RESPONSE ?      api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Econ]
public class LHCHIOANGPD
{
    public CBMKAGAHPOM <JGCCAMLMKGO>k__BackingField;    // 0x0x10
    public KMEBGANIBFG <HIABKNIPCNJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LOGDGEGCJMF
// base   : PDJLNBMLJNG
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class LOGDGEGCJMF : PDJLNBMLJNG
{
    public IAJDGMPCEGC? <EIFBHNCNBLE>k__BackingField;    // 0x0x18
    public PNIEBLACDAO <ICPLLOALKOP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LPMKOMGMBBP
//   (not directly referenced by a detected call)
public class LPMKOMGMBBP
{
    public string <FNHKHEPOCPP>k__BackingField;    // 0x0x10
    public HGMNIDGBAED <OOGNDPHIEBE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MDBKLPOJJIK
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{lNHACNHDILG}   [Service.API]
public class MDBKLPOJJIK
{
    public uint <CKBODBKIDMF>k__BackingField;    // 0x0x10
    public uint? <BAPCPNKHLNP>k__BackingField;    // 0x0x14
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x20
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x28
    public DateTime <FJHLHFNOOFL>k__BackingField;    // 0x0x30
    public DateTime? <OGONDHANJBB>k__BackingField;    // 0x0x38
    public bool <GIHIIPICKAD>k__BackingField;    // 0x0x48
    public List<HOFLFLINLKO> <JLBAACMGDHE>k__BackingField;    // 0x0x50
    public List<string> <MHIMEJFCKHG>k__BackingField;    // 0x0x58
    public int <JPLLKJCJPLL>k__BackingField;    // 0x0x60
    public int <OALIMGFFEEG>k__BackingField;    // 0x0x64
    public int <DHOLMKPCMOJ>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// MHLJNDAGJHH
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{aMODOANMDIJ}   [Service.API]
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
public class MHLJNDAGJHH
{
    public OIHAMNFDDGE <OKKKILAFNKD>k__BackingField;    // 0x0x10
    public HHMNFHKFPNB <JOHKPEFPAHB>k__BackingField;    // 0x0x18
    public HLJPOIOMMAN <NEGFJHNFAEL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MIDNAAJPGCD
// base   : ENHAEHDJDBB`1<BNEIEDNLCLC>
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{cJJNEDEIIEP}   [Service.API]
public class MIDNAAJPGCD
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// MNDOCHBLAGJ
//   (not directly referenced by a detected call)
public class MNDOCHBLAGJ
{
    public long <ECEDDIFONND>k__BackingField;    // 0x0x10
    public long <EBCKLJFEKBI>k__BackingField;    // 0x0x18
    public int <GLCODDGAMMP>k__BackingField;    // 0x0x20
    public DateTime <ALIJOOMMGGF>k__BackingField;    // 0x0x28
    public JJPKBMIGGLJ <OOGNDPHIEBE>k__BackingField;    // 0x0x30
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
// NBFLCLCKEFD
// base   : BDLDMNMEKBO
//   (not directly referenced by a detected call)
public class NBFLCLCKEFD : BDLDMNMEKBO
{
    public OKFLCGDBGOC <PPGBDICIILI>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// NFIMKJMMHGA
//   (not directly referenced by a detected call)
public class NFIMKJMMHGA
{
    public int <KHBENDGLIPL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NHOBHPJONOO
//   REQUEST  PUT    api/avatar/v4/saved/name   [Service.Econ]
public class NHOBHPJONOO
{
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x10
    public int <LKDFFLEKICF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NLMJJBNIGBM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NLMJJBNIGBM
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
// NMNKLIINMEA
//   RESPONSE GET    api/config/v2   [Service.API]
public class NMNKLIINMEA
{
    public Dictionary<int, int> <CNACHDOJICI>k__BackingField;    // 0x0x10
    public List<OGLAPJANLII> <BIALJECGBEP>k__BackingField;    // 0x0x18
    public EAOFMJOICIG[][] <AHFJGLLJBDL>k__BackingField;    // 0x0x20
    public DNMPFOAKJKM <JAGEHBGDLGG>k__BackingField;    // 0x0x28
    public GCAIIGGGLKG <GCLCOCMNHAD>k__BackingField;    // 0x0x30
    public NFIMKJMMHGA <MDDAFMBPILF>k__BackingField;    // 0x0x38
    public OCJDOBMAGNI <GBNJJFCLNMC>k__BackingField;    // 0x0x40
    public COHCDIBPNJL <EGBAKDJAFFM>k__BackingField;    // 0x0x48
    public string <GGAMIADLFOH>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// NNGPLLEAKAM
//   (not directly referenced by a detected call)
public class NNGPLLEAKAM
{
    public Guid <LDMCIMEPMHB>k__BackingField;    // 0x0x10
    public long <HGPFPAFMCPK>k__BackingField;    // 0x0x20
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x28
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x30
    public string <IIGHEPEOFIN>k__BackingField;    // 0x0x38
    public long <BBAMKHAPNAH>k__BackingField;    // 0x0x40
    public Guid? <MPAPJIJDHGC>k__BackingField;    // 0x0x48
    public DateTime <MGPMAJMFHJJ>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// OAIFOALCFAB
//   RESPONSE ?      api/inventions/   [Service.API]
//   RESPONSE GET    api/inventions/v1/personaldetails/{hEHBPLPMIPC}   [Service.API]
public class OAIFOALCFAB
{
    public bool <NNDAOAOAMME>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OAMNOIPABLK
//   (not directly referenced by a detected call)
public class OAMNOIPABLK
{
    public DateTime <ALIJOOMMGGF>k__BackingField;    // 0x0x10
    public string <BAGOAELBBDG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OCJDOBMAGNI
//   (not directly referenced by a detected call)
public class OCJDOBMAGNI
{
    public int <MMMIPFFOPJO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OHFJGCCKOGD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OHFJGCCKOGD
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// OIFGKJMCALB
// base   : ENHAEHDJDBB`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class OIFGKJMCALB
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// OIHAMNFDDGE
// base   : FEOJLOHGGMD
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class OIHAMNFDDGE : FEOJLOHGGMD
{
    public List<LPMKOMGMBBP> <MHIMEJFCKHG>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// OKFLCGDBGOC
//   (not directly referenced by a detected call)
public class OKFLCGDBGOC
{
    public int <PCLLNDCPOCG>k__BackingField;    // 0x0x10
    public string <LKODLLBEDBP>k__BackingField;    // 0x0x18
    public string <HDMOOGIANJC>k__BackingField;    // 0x0x20
    public string <EBEOEEKHFCN>k__BackingField;    // 0x0x28
    public string <AAMOFKIPFED>k__BackingField;    // 0x0x30
    public string <HDCLKFOIOGP>k__BackingField;    // 0x0x38
    public MICLEHLCMID? <NJCKCNAPDBK>k__BackingField;    // 0x0x40
    public string <LBCDMKLEDFP>k__BackingField;    // 0x0x48
    public string <MGAOJHIHDHF>k__BackingField;    // 0x0x50
    public bool <CNJCIDIGIJI>k__BackingField;    // 0x0x58
    public bool <DBAODNEKKBA>k__BackingField;    // 0x0x59
    public bool <BIKEPNBBHHF>k__BackingField;    // 0x0x5A
    public BFGPOPPFKCE <AJEDEECKBHI>k__BackingField;    // 0x0x5C
    public int <DOMNPPBKLMK>k__BackingField;    // 0x0x60
    public DOEKJNLHOAI <AMDKKOOBOGJ>k__BackingField;    // 0x0x64
    public int <HOMLIKFKMLB>k__BackingField;    // 0x0x68
    public NLMJJBNIGBM <PLFLMHJBEEJ>k__BackingField;    // 0x0x6C
    public EGEKMHNCGNL <HCDEJHPMBAD>k__BackingField;    // 0x0x70
    public int? <NPDEDKDIHLA>k__BackingField;    // 0x0x74
    public string <BIKFLPAGIMK>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// OLGCNHCPNPL
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class OLGCNHCPNPL
{
    public int? <DPPFDGOHAFK>k__BackingField;    // 0x0x10
    public string <OFKFGKAIMNK>k__BackingField;    // 0x0x18
    public string <BILJFJEPPHE>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// OOCPHAFHJHN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OOCPHAFHJHN
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
// PAKJJJEHEPI
//   (not directly referenced by a detected call)
public class PAKJJJEHEPI
{
    public int <BJDPHAPEEON>k__BackingField;    // 0x0x10
    public HHMNFHKFPNB <JOHKPEFPAHB>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// PEKFJNKAEHO
// base   : LJHMKMNOODN
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{jCOCKDJCHNI}   [Service.Econ]
public class PEKFJNKAEHO : LJHMKMNOODN
{
    public int <MJKEBKPCBAE>k__BackingField;    // 0x0x30
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x38
    public DateTime <LHFOCJAJEPO>k__BackingField;    // 0x0x40
    public DateTime <FNEMKGLNCAG>k__BackingField;    // 0x0x48
    public DOEKJNLHOAI <AMDKKOOBOGJ>k__BackingField;    // 0x0x50
    public BDLDMNMEKBO <NDOFBJMMOFC>k__BackingField;    // 0x0x58
    public List<PLOOIIEIPCE> <BEBOJJBBINC>k__BackingField;    // 0x0x60
    public KNIPELEAIMI <JKJLOILNKBK>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// PEMFAAPKJNP
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
public class PEMFAAPKJNP
{
    public bool <LBOPPJGAIEN>k__BackingField;    // 0x0x10
    public string <LMMLGGAHGGK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PLOOIIEIPCE
// base   : BDLDMNMEKBO
//   (not directly referenced by a detected call)
public class PLOOIIEIPCE : BDLDMNMEKBO
{
    public int <EKLAJNIONBC>k__BackingField;    // 0x0x60
    public List<FJAMHDAFDGB> <GFHFDIKABIP>k__BackingField;    // 0x0x68
    public List<FJAMHDAFDGB> <EPDOPMLGAFH>k__BackingField;    // 0x0x70
    public List<FJAMHDAFDGB> <MHHLLGODJOG>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// PNIEBLACDAO
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class PNIEBLACDAO
{
    public int <JGPJHBIDMKK>k__BackingField;    // 0x0x10
    public Guid <BCGDBKHPMJP>k__BackingField;    // 0x0x14
    public long <GFJLKKEPPBB>k__BackingField;    // 0x0x28
    public DateTime <MGPMAJMFHJJ>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// PODPMAENOJM
//   (not directly referenced by a detected call)
public class PODPMAENOJM
{
    public int <ENFANMLFIAI>k__BackingField;    // 0x0x10
    public DateTime? <GOOAFGMMNIG>k__BackingField;    // 0x0x18
    public DateTime? <NFMEAKDBKLD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.API]
public class AddKeepsakeInstanceRequest
{
    public long <HGPFPAFMCPK>k__BackingField;    // 0x0x10
    public long? <AJKNGOFKKBI>k__BackingField;    // 0x0x18
    public NHINHHJKNOE <NPFMFDEFLDH>k__BackingField;    // 0x0x28
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
    public ADKAEBEDKGD <JOHKPEFPAHB>k__BackingField;    // 0x0x10
    public string <CILMONFDLNA>k__BackingField;    // 0x0x18
    public string <CJMGHCBGHLO>k__BackingField;    // 0x0x20
    public string <FMBKLNJFENJ>k__BackingField;    // 0x0x28
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
    public long <EBCKLJFEKBI>k__BackingField;    // 0x0x10
    public long? <EEOGKEKDKGB>k__BackingField;    // 0x0x18
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
    public IABJEOJJMNO FilterType;    // 0x0x20
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
    public NHINHHJKNOE <GOCHEJKGFNP>k__BackingField;    // 0x0x10
    public string <JOCBHLBNLIH>k__BackingField;    // 0x0x18
    public int <AKPPCKIONJM>k__BackingField;    // 0x0x20
    public int <BBBDPAOONNB>k__BackingField;    // 0x0x24
    public string <ONECHEKCDJJ>k__BackingField;    // 0x0x28
    public string <OEEKAOJEKOJ>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <JGPJHBIDMKK>k__BackingField;    // 0x0x10
    public Guid <OMEHPHMHPDA>k__BackingField;    // 0x0x14
    public DateTime <DFOFEIPBHBH>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <BFJNIOHNHHI>k__BackingField;    // 0x0x10
    public int <IEJMFNMBKBM>k__BackingField;    // 0x0x14
    public bool <PKJGABGHFCL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <OMEHPHMHPDA>k__BackingField;    // 0x0x10
    public NHINHHJKNOE <JLFIAHKCKDM>k__BackingField;    // 0x0x20
    public int <JAIADPLALGJ>k__BackingField;    // 0x0x24
    public long <HGPFPAFMCPK>k__BackingField;    // 0x0x28
    public long? <AJKNGOFKKBI>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{dGNKKLIGEOC}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <IOFDNDBLNMK>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <AJAJJCHLOFM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <FEMKMMBPCCH>k__BackingField;    // 0x0x10
    public long <HGPFPAFMCPK>k__BackingField;    // 0x0x18
    public long <AHMHBLKGNEB>k__BackingField;    // 0x0x20
    public BAFOBLIBAOL <OOGNDPHIEBE>k__BackingField;    // 0x0x28
    public int <LEEDGDLHGHJ>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <HGPFPAFMCPK>k__BackingField;    // 0x0x10
    public List<Guid> <AKECIKDMFHE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <IOFDNDBLNMK>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <AJAJJCHLOFM>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <CDLBMHPOAMK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <AHMHBLKGNEB>k__BackingField;    // 0x0x10
    public long <KDBGHMANPHC>k__BackingField;    // 0x0x18
    public int? <KEOPIKCGIHL>k__BackingField;    // 0x0x20
    public int? <BFOEJKGNAMF>k__BackingField;    // 0x0x28
    public long? <HMCNBOIGIJK>k__BackingField;    // 0x0x30
    public long <HMEKHGMFMMP>k__BackingField;    // 0x0x40
    public long <PDJGNBKOFNP>k__BackingField;    // 0x0x48
    public int <ECEIHKIBPOK>k__BackingField;    // 0x0x50
    public BAFOBLIBAOL <GLHJAKJMIMD>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <NPDCNMOLOPF>k__BackingField;    // 0x0x58
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
    public EGEKMHNCGNL <GiftContext>k__BackingField;    // 0x0x20
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
    public IELFPCAAOGM creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public PDNHFCPAGIO <KDLCBCAAGGP>k__BackingField;    // 0x0x10
    public EJDIIGDMFDK <BMMFJLBBJHB>k__BackingField;    // 0x0x14
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x18
    public string <DBALGPDOAIO>k__BackingField;    // 0x0x20
    public bool <JJFGMLBNPKN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public List<PDNHFCPAGIO> <BJDBNNJMDLO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{aMODOANMDIJ}   [Service.API]
public class ProgressionEventDTO
{
    public long <KDBGHMANPHC>k__BackingField;    // 0x0x10
    public string <EFJGHJCKNCM>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <MHHLLGODJOG>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <NGLEIHHNEGJ>k__BackingField;    // 0x0x28
    public DateTime <IKIPILOPAAC>k__BackingField;    // 0x0x30
    public DateTime <PCKKENLHOND>k__BackingField;    // 0x0x38
    public DateTime <GCAPPEGBOJN>k__BackingField;    // 0x0x40
    public bool <NPDFBAFAPEA>k__BackingField;    // 0x0x48
    public int <FKCJEPDKEOO>k__BackingField;    // 0x0x4C
    public float <GBMDGCLONAN>k__BackingField;    // 0x0x50
    public Guid? <ABDEAEDLJOB>k__BackingField;    // 0x0x54
    public string <MMMCHMLKDHL>k__BackingField;    // 0x0x68
    public string <NNAJJFBOHON>k__BackingField;    // 0x0x70
    public string <NMIDDIFLJAJ>k__BackingField;    // 0x0x78
    public string <EAOGKOMDHFP>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <FJKHNDGMEIE>k__BackingField;    // 0x0x10
    public int <HLLIEILKBFB>k__BackingField;    // 0x0x20
    public int <EAAOHGPIDDN>k__BackingField;    // 0x0x24
    public int <BHHJKFFBDAI>k__BackingField;    // 0x0x28
    public long <DODBIJHHLBA>k__BackingField;    // 0x0x30
    public long <JJJFMMFIBLM>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <JGPJHBIDMKK>k__BackingField;    // 0x0x10
    public int <HLFNCJDADNI>k__BackingField;    // 0x0x14
    public int <CDBGHPOKHDC>k__BackingField;    // 0x0x18
    public int <NOFDLFLEPIJ>k__BackingField;    // 0x0x1C
    public int <EICBLHBDION>k__BackingField;    // 0x0x20
    public DateTime? <EJEIAKHHGIC>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <KOPAKEJCMOF>k__BackingField;    // 0x0x10
    public int <PCLLNDCPOCG>k__BackingField;    // 0x0x18
    public string <IIGHEPEOFIN>k__BackingField;    // 0x0x20
    public int <HLFNCJDADNI>k__BackingField;    // 0x0x28
    public int <JBEOOJMPPGH>k__BackingField;    // 0x0x2C
    public bool <IKGODCGIIBK>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public KIIMMHCNJAB ReportCategory;    // 0x0x20
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
    public bool NKGMHDFLJKJ;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.Foundation.Templates.SA_DataResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class SA_DataResult : SA_Result
{
    public string m_Data;    // 0x0x28
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
    public string m_State;    // 0x0x28
    public string m_Description;    // 0x0x30
    public int m_ErrorCode;    // 0x0x38
    public ISN_CKRecord m_Record;    // 0x0x40
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
    public ISN_NSKeyValueObject m_KeyValueObject;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKAchievementsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKAchievementsResult : SA_Result
{
    public List<ISN_GKAchievement> m_Achievements;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKIdentityVerificationSignatureResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKIdentityVerificationSignatureResult : SA_Result
{
    public string m_PublicKeyUrl;    // 0x0x28
    public string m_Signature;    // 0x0x30
    public string m_Salt;    // 0x0x38
    public long m_Timestamp;    // 0x0x40
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKImageLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKImageLoadResult : SA_Result
{
    public Texture2D m_Image;    // 0x0x28
    public string m_ImageBase64;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKLeaderboardsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKLeaderboardsResult : SA_Result
{
    public List<ISN_GKLeaderboard> m_Leaderboards;    // 0x0x28
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
    public List<ISN_GKSavedGame> m_SavedGames;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameLoadResult : SA_Result
{
    public string m_Data;    // 0x0x28
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
// SA.iOS.GameKit.ISN_GKScoreLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKScoreLoadResult : SA_Result
{
    public List<ISN_GKScore> m_Scores;    // 0x0x28
    public ISN_GKLeaderboard m_Leaderboard;    // 0x0x30
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
    public string m_ActivityType;    // 0x0x28
    public bool m_Completed;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKInitResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_SKInitResult : SA_Result
{
    public List<ISN_SKProduct> m_Products;    // 0x0x28
    public List<string> m_InvalidProductIdentifiers;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKProductsRequest
//   (not directly referenced by a detected call)
public class ISN_SKProductsRequest
{
    public ISN_LoadStoreRequest m_loadStoreRequest;    // 0x0x10
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
    public int m_ChosenIndex;    // 0x0x28
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
    public string m_DeviceTokenUtf8;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIWheelPickerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIWheelPickerResult : SA_Result
{
    public string m_Value;    // 0x0x28
    public string m_State;    // 0x0x30
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
    public GLGFPGONFDK? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public GLGFPGONFDK OJAGICMPHOD;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public OLPFOKKGNMJ EMAJMFLNLMO;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public IFCNBCFDCIL LFBJHCMDIAE;  // wrapper
    public int? ILLDIFPOAPG;  // wrapper
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
    public FGMDGNJAKAB MFOFCBDENNP;  // wrapper
    public float? GGHNNHFEPKE;  // wrapper
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
    public List<string> desc;  // query
}

// api/avatar/v2/gifts/consume/  [Econ POST]
public class AvatarV2GiftsConsumeRequest
{
    public CKKGHJCJMCB UnlockedLevel;  // wrapper
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public EGEKMHNCGNL JHAKINLMMJL;  // wrapper
    public EGEKMHNCGNL? CFKCMOLKLJP;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public EGEKMHNCGNL JHAKINLMMJL;  // wrapper
    public EGEKMHNCGNL? CFKCMOLKLJP;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [Econ POST]
public class ChallengeV2UpdateProgressRequest
{
    public KIFAMLKBJHM DLEHEIKFFBC;  // wrapper
    public object UpdateChallengeProgress;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object ChallengeMapId;  // candidate
    public object Complete;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public FGMDGNJAKAB MFOFCBDENNP;  // wrapper
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
    public KEEEIICNMDG FPDBMKDELDM;  // wrapper
    public IPOPEDGMDHN MHKOHCACMIO;  // wrapper
    public byte[] NMOLOBOAJMM;  // wrapper
    public byte[] JAPBKDPGEPO;  // wrapper
    public Color OOJLGEBJDPI;  // wrapper
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
    public List<EPHGAAONFDF> KEHBJLKKMPK;  // wrapper
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
    public EHNEDFIHDGM LLNKGHONALH;  // wrapper
    public EGEKMHNCGNL? MPLMNJIJFAA;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public NDEMEDBNMLJ NNFHJCFDAOO;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/gamesight/event  [API POST]
public class GamesightEventRequest
{
    public object EventData;  // candidate
    public object cumulative;  // candidate
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

// api/inventions/v1/delete  [API GET]
public class InventionsV1DeleteRequest
{
    public DEJBLEMMOFN inventionId;  // wrapper
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

// api/keepsakes/{bHBNPLODPJC}/collect  [API POST]
public class KeepsakesBHBNPLODPJCCollectRequest
{
    public Guid BHBNPLODPJC;  // wrapper
}

// api/messages/v1/sendMultiple  [API POST]
public class MessagesV1SendMultipleRequest
{
    public List<long> HMBAPIMNGEM;  // wrapper
    public BNJCJHKHCHL COJOEMGFGJJ;  // wrapper
    public long? EDDMGMBKEBK;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
    public object SendMessageMultiple;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public BNJCJHKHCHL COJOEMGFGJJ;  // wrapper
    public long? EDDMGMBKEBK;  // wrapper
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
    public long? MEMACFBCEOO;  // wrapper
}

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/bulkInvite  [API POST]
public class PlayereventsV1BulkInviteRequest
{
    public List<int> HMBAPIMNGEM;  // wrapper
}

// api/playerevents/v1/deleteResponse  [API POST]
public class PlayereventsV1DeleteResponseRequest
{
    public JJPKBMIGGLJ CGMOGCAIPPC;  // wrapper
}

// api/playerevents/v1/report  [API POST]
public class PlayereventsV1ReportRequest
{
    public FGMDGNJAKAB MFOFCBDENNP;  // wrapper
}

// api/playerevents/v1/respond  [API POST]
public class PlayereventsV1RespondRequest
{
    public JJPKBMIGGLJ CGMOGCAIPPC;  // wrapper
}

// api/playerevents/v2  [API POST]
public class PlayereventsV2Request
{
    public long? LKPOLLBAPFL;  // wrapper
    public long? FFOGLEOPLJA;  // wrapper
    public List<string> ACAKPEMIHNH;  // wrapper
    public DateTime BALBDAAMGGG;  // wrapper
    public DateTime JIDHFHPDFKK;  // wrapper
    public EPGEJJGMFGJ FPDBMKDELDM;  // wrapper
    public GFMHBMEMAKI PHNLDLGFGOG;  // wrapper
    public GFMHBMEMAKI EIHHCHOCIBC;  // wrapper
}

// api/playerevents/v2/{eventId}  [API POST]
public class PlayereventsV2EventIdRequest
{
    public long? LKPOLLBAPFL;  // wrapper
    public List<string> ACAKPEMIHNH;  // wrapper
    public DateTime BALBDAAMGGG;  // wrapper
    public DateTime JIDHFHPDFKK;  // wrapper
    public EPGEJJGMFGJ FPDBMKDELDM;  // wrapper
    public long? FFOGLEOPLJA;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public EPGEJJGMFGJ FPDBMKDELDM;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? FFOGLEOPLJA;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public GFMHBMEMAKI PHNLDLGFGOG;  // wrapper
    public GFMHBMEMAKI FLAODCKABPO;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? LKPOLLBAPFL;  // wrapper
}

// api/playerevents/v2/{eventId}/tags  [API PUT]
public class PlayereventsV2EventIdTagsRequest
{
    public List<string> ACAKPEMIHNH;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime BALBDAAMGGG;  // wrapper
    public DateTime JIDHFHPDFKK;  // wrapper
}

// api/playerwarnings  [API POST]
public class PlayerwarningsRequest
{
    public FGMDGNJAKAB MFOFCBDENNP;  // wrapper
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
    public Guid NDBFNOGFODE;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomcurrencies/v1/awardCurrency/bulk  [Econ POST]
public class RoomcurrenciesV1AwardCurrencyBulkRequest
{
    public List<LLBFJKHLJAN> HANNFEGJNCG;  // wrapper
}

// api/roomcurrencies/v1/createCurrency  [Econ POST]
public class RoomcurrenciesV1CreateCurrencyRequest
{
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object RoomId;  // candidate
    public object Description;  // candidate
}

// api/roomcurrencies/v1/createPurchaseOffer  [Econ POST]
public class RoomcurrenciesV1CreatePurchaseOfferRequest
{
    public Guid HAAOPMBHFOB;  // wrapper
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
    public Guid HAAOPMBHFOB;  // wrapper
    public long? HNENKCBGPPB;  // wrapper
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
    public object Description;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid NDBFNOGFODE;  // wrapper
    public long? NCDLCNBPFPE;  // wrapper
    public long? CMEFELJFKDM;  // wrapper
    public int? FENAPNIOFNB;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> CCDJMIJMJKG;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/awardbulk  [Econ POST]
public class RoomkeysV1AwardbulkRequest
{
    public IEnumerable<NIMLPHEOHKN> KCECACJLKOP;  // wrapper
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public JHAMBACPAEK LFBJHCMDIAE;  // wrapper
    public Guid? BHHPCNNDPPL;  // wrapper
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
    public FGMDGNJAKAB MFOFCBDENNP;  // wrapper
    public long? CCBGBLOKAPN;  // wrapper
    public object ReportCategory;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
    public object Details;  // candidate
}

// api/royale/v2/matchcomplete  [Econ POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats CDEDNHPLJKH;  // wrapper
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
    public Guid MCPPHCKENFN;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid LJEPABHDAKK;  // wrapper
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
    public List<PHIHIMPCBFC> AKBMLLNAMDC;  // wrapper
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
    public HOPJIFKGIEL OCCLLPFBIIB;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

