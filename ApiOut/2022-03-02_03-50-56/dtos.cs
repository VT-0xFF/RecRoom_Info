// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 232 (plus referenced enums)

// --------------------------------------------------------------------------
// ACGNAMMODON
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ACGNAMMODON
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// ADAKIFOAFGI
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/consume   [Service.API]
public class ADAKIFOAFGI
{
    public ADLHCGHPGNP <HHDAIOPDPHG>k__BackingField;    // 0x0x10
    public GMDDMDGKOEG <PGOBMBOOHOO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ADLHCGHPGNP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ADLHCGHPGNP
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
// AJKPLEMBBOC
// base   : HNODOJDPPOH
//   RESPONSE GET    api/storefronts/v1/season/{seasonId}   [Service.API]
public class AJKPLEMBBOC : HNODOJDPPOH
{
    public int <FIGAPKMKANE>k__BackingField;    // 0x0x30
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x38
    public DateTime <NLKAGMHCAGA>k__BackingField;    // 0x0x40
    public DateTime <BGPGJJGLKKJ>k__BackingField;    // 0x0x48
    public NFPOLCDIFOD <PDJHKCNNJKC>k__BackingField;    // 0x0x50
    public ILHKOKEOMMF <ONMBCPGOIFM>k__BackingField;    // 0x0x58
    public List<MNHNLMLGAIE> <PLIHCCBOGKP>k__BackingField;    // 0x0x60
    public MHNHEKPJKMM <ANJKDIKJPJL>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// AJMLINCGCGG
//   RESPONSE POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.API]
//   RESPONSE POST   api/roomEarningsDistributions/v1/earningsDistribution/{lJODGADJAPC}   [Service.API]
public class AJMLINCGCGG
{
    public long <PBKBDNNJHCJ>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <OADDCJCHIJG>k__BackingField;    // 0x0x18
    public ACGNAMMODON <KMBAOECDGBH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AOFJIDOLOMB
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{lPABPJCFOKF}   [Service.API]
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
public class AOFJIDOLOMB
{
    public DKGJGNDIAAH <BIBIGDKLDJJ>k__BackingField;    // 0x0x10
    public NHDMLJAKFMP <NLCAIKCDFMA>k__BackingField;    // 0x0x18
    public NFHGFCLOPKE <LNNLAGLFHLF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BELKOAAGGAO
//   (not directly referenced by a detected call)
public class BELKOAAGGAO
{
    public DateTime <DFHGAMJPDDD>k__BackingField;    // 0x0x10
    public string <HOJFOOLKOPJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BEMEIIBECND
//   RESPONSE POST   api/roomCurrencies/v2/purchase   [Service.API]
public class BEMEIIBECND
{
    public HNEONBFJCGG <ALBDCDJJKNC>k__BackingField;    // 0x0x10
    public BalanceResponseDTO <EBFBGGJMEMD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BHKENAINDDI
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.API]
public class BHKENAINDDI
{
    public int <FMLBLMNLCBA>k__BackingField;    // 0x0x10
    public string <LOAAPDLBODD>k__BackingField;    // 0x0x18
    public List<OHCMGFPMKNK> <LBDHNBHDLAC>k__BackingField;    // 0x0x20
    public KOGOFGMKODG <BJEHNDEHJOE>k__BackingField;    // 0x0x28
    public string <OIMCJBFAAIF>k__BackingField;    // 0x0x30
    public DateTime <NLKAGMHCAGA>k__BackingField;    // 0x0x38
    public DateTime <BGPGJJGLKKJ>k__BackingField;    // 0x0x40
    public DateTime <IFDHEFEFMOI>k__BackingField;    // 0x0x48
    public bool? <CLFEOMHEKLA>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// BMHNFPBHKON
//   RESPONSE GET    api/config/   [Service.API]
//   REQUEST  POST   api/config/   [Service.API]
public class BMHNFPBHKON
{
    public Dictionary<int, int> <MPHIPPPFFEN>k__BackingField;    // 0x0x10
    public List<MMJJCPGACLL> <AHEJKJALPJF>k__BackingField;    // 0x0x18
    public DMJCGLKBDMJ[][] <CBOGCKECHKG>k__BackingField;    // 0x0x20
    public PPAPDMGDDMP <FEACKNGADMG>k__BackingField;    // 0x0x28
    public IJAGMCCDKIM <GBMOLOCLOMJ>k__BackingField;    // 0x0x30
    public PLLAGDBPHIK <KGMJGNOKIAD>k__BackingField;    // 0x0x38
    public KJIBCNJMLMC <ICJGJKJFGCK>k__BackingField;    // 0x0x40
    public HBHLFAIMJFK <AGIJAMLFHEP>k__BackingField;    // 0x0x48
    public string <JJHJLLEPBAK>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// BPENNBGNCGP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BPENNBGNCGP
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// BPJGOHKPFPD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum BPJGOHKPFPD
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
// CAHEFFMFMFP
//   RESPONSE GET    api/groups/v1/memberships/{kHNFMGJILNO}   [Service.API]
public class CAHEFFMFMFP
{
    public long <DLJPFHDOOGK>k__BackingField;    // 0x0x10
    public int <IHGKBMOEMAH>k__BackingField;    // 0x0x18
    public FLCEPCCIACC <IBKPOIGOEFD>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// CCKAJLLBLGJ
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/v1/delete/{eGFLDLGHEIA}   [Service.API]
public enum CCKAJLLBLGJ
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
}

// --------------------------------------------------------------------------
// CEBKCIHLLNJ
//   (not directly referenced by a detected call)
public class CEBKCIHLLNJ
{
    public long <MJPCJNALGOD>k__BackingField;    // 0x0x10
    public long <FMJFKLOIMEI>k__BackingField;    // 0x0x18
    public int <IHGKBMOEMAH>k__BackingField;    // 0x0x20
    public DateTime <DFHGAMJPDDD>k__BackingField;    // 0x0x28
    public MIKIMGBAHJP <PLDNNCNGLMB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// CFNJCBAEBPA
//   RESPONSE POST   api/settings/v2/set   [Service.API]
public class CFNJCBAEBPA
{
    public bool MHAMCOJFNEJ;    // 0x0x10
    public bool NAJCGBLBCJB;    // 0x0x11
}

// --------------------------------------------------------------------------
// CHAJGIOAMGH
// base   : OPPEHAHDDMG
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
//   REQUEST  POST   api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.API]
public class CHAJGIOAMGH : OPPEHAHDDMG
{
    public DCFPMGGGIPI? <OFHCEANBIMB>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <EBFBGGJMEMD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CHHCOJOCIOI
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{hJPPHGKEPAC}   [Service.API]
public class CHHCOJOCIOI
{
    public uint <ONMJCFLHEPN>k__BackingField;    // 0x0x10
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x18
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x20
    public DateTime <DADMHDGIDFD>k__BackingField;    // 0x0x28
    public DateTime? <JMKKBJKDMPM>k__BackingField;    // 0x0x30
    public bool <FDGOPEAFEOG>k__BackingField;    // 0x0x40
    public List<LFKGKPJOGIE> <IJILKLLKKKJ>k__BackingField;    // 0x0x48
    public List<string> <ILIGBJLAABB>k__BackingField;    // 0x0x50
    public int <NNJFGBHAOPB>k__BackingField;    // 0x0x58
    public int <ENNFHEJJGDE>k__BackingField;    // 0x0x5C
    public int <IMMPHIJDFAN>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// CMHJCBIMJDA
//   RESPONSE PUT    api/roomkeys/v1/RoomKeyId   [Service.API]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.API]
public class CMHJCBIMJDA
{
    public CCKAJLLBLGJ <HHDAIOPDPHG>k__BackingField;    // 0x0x10
    public GMCFKNEKKPJ <FEAHIDJMGHE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DFNILFJCEOC
//   RESPONSE GET    api/incentivizedreferrals/progress   [Service.API]
//   REQUEST  POST   api/incentivizedreferrals/progress   [Service.API]
public class DFNILFJCEOC
{
    public int <GHEODCKEBOL>k__BackingField;    // 0x0x10
    public List<PJDAAGHDGLF> <POJNHFJNKBI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DKGJGNDIAAH
//   (not directly referenced by a detected call)
public class DKGJGNDIAAH
{
    public long <FMJFKLOIMEI>k__BackingField;    // 0x0x10
    public int <CLFMCINDFGC>k__BackingField;    // 0x0x18
    public long <PBKBDNNJHCJ>k__BackingField;    // 0x0x20
    public long? <OCPBCADEPIF>k__BackingField;    // 0x0x28
    public long? <JNAGGHMKGCH>k__BackingField;    // 0x0x38
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x48
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x50
    public string <NEHCOGJAMBL>k__BackingField;    // 0x0x58
    public DateTime <EPKGLBMPHED>k__BackingField;    // 0x0x60
    public DateTime <DNPAHOPMDJA>k__BackingField;    // 0x0x68
    public int <OAHEIOIEFEF>k__BackingField;    // 0x0x70
    public FMOKDCALFOE <PGBNNOOMAAC>k__BackingField;    // 0x0x74
    public bool <KNAPIHMENOH>k__BackingField;    // 0x0x78
    public bool <BEFIMFJPMPG>k__BackingField;    // 0x0x79
    public long? <GIDHCOGOAPB>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// DMBDJIHIPEN
//   RESPONSE POST   api/itemWishlists/v1/wishlist/me/{bMHIFAHHOKG}   [Service.API]
public class DMBDJIHIPEN
{
    public Guid <NPAECCODKPD>k__BackingField;    // 0x0x10
    public int <DAGIHNKKAIJ>k__BackingField;    // 0x0x20
    public int <PPCJHDBKOJB>k__BackingField;    // 0x0x24
    public DateTime <DFHGAMJPDDD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// DMJCGLKBDMJ
//   (not directly referenced by a detected call)
public class DMJCGLKBDMJ
{
    public OHDMBPJNIDP KDINOMLBBJH;    // 0x0x10
    public int PDPNGLJLPDF;    // 0x0x14
    public int CJDFFCGONFO;    // 0x0x18
}

// --------------------------------------------------------------------------
// DNABCFCMFME
//   REQUEST  POST   api/playerevents/v2   [Service.API]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.API]
public class DNABCFCMFME
{
    public long <PBKBDNNJHCJ>k__BackingField;    // 0x0x10
    public long? <OCPBCADEPIF>k__BackingField;    // 0x0x18
    public long? <JNAGGHMKGCH>k__BackingField;    // 0x0x28
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x38
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x40
    public List<string> <ILIGBJLAABB>k__BackingField;    // 0x0x48
    public string <NEHCOGJAMBL>k__BackingField;    // 0x0x50
    public DateTime <EPKGLBMPHED>k__BackingField;    // 0x0x58
    public DateTime <DNPAHOPMDJA>k__BackingField;    // 0x0x60
    public FMOKDCALFOE <PGBNNOOMAAC>k__BackingField;    // 0x0x68
    public bool <KNAPIHMENOH>k__BackingField;    // 0x0x6C
    public bool <BEFIMFJPMPG>k__BackingField;    // 0x0x6D
}

// --------------------------------------------------------------------------
// EAOPBMJACPD
//   (not directly referenced by a detected call)
public class EAOPBMJACPD
{
    public bool <IAKLBMCGIHF>k__BackingField;    // 0x0x10
    public MELACGDOKGF <MDPACCHKMFK>k__BackingField;    // 0x0x18
    public float <IDNMJOKBOMP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EBAAHDFICCC
// base   : OPPEHAHDDMG
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  POST   api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.API]
public class EBAAHDFICCC : OPPEHAHDDMG
{
    public BPENNBGNCGP? <OFHCEANBIMB>k__BackingField;    // 0x0x18
    public HNEONBFJCGG <ALBDCDJJKNC>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EFCPFLBCOMO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EFCPFLBCOMO
{
    Unassigned = 0,
    LimitedOneUseOnly = 10,
    UseOnly = 20,
    EditAndSave = 40,
    Publish = 60,
    Charge = 80,
    Unlimited = 100,
}

// --------------------------------------------------------------------------
// EFOOLDGHONI
// base   : HNODOJDPPOH
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.API]
public class EFOOLDGHONI : HNODOJDPPOH
{
    public List<FBNKAAFFOFB> PDDHCMENNPA;    // 0x0x30
    public int <EJJEHBJAKNE>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// EGKKFFPDMIK
//   RESPONSE PUT    api/players/v4/current/contact   [Service.API]
//   REQUEST  POST   api/players/v4/current/contact   [Service.API]
public class EGKKFFPDMIK
{
    public HTTPResponse IICGBDNPOJO;    // 0x0x10
    public int? PNCEHMEEIHO;    // 0x0x18
    public string FECKPLLKOEH;    // 0x0x20
    public byte[] MCPPCECJEHI;    // 0x0x28
    public string CGHACFJMBND;    // 0x0x30
}

// --------------------------------------------------------------------------
// EIPFDDIKEBH
//   (not directly referenced by a detected call)
public class EIPFDDIKEBH
{
    public NFPOLCDIFOD <PDJHKCNNJKC>k__BackingField;    // 0x0x10
    public int <LAOGMBHNGON>k__BackingField;    // 0x0x14
    public KPAHNCIDEAJ <LJOAOLONJEL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ELDMGGOEPGP
//   (not directly referenced by a detected call)
public class ELDMGGOEPGP
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// ELHOCMNAFOA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ELHOCMNAFOA
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// EMMAJAAEDLJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EMMAJAAEDLJ
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// ENEEHMKFNCP
//   RESPONSE GET    api/groups/v1/name/{nameId}   [Service.API]
//   RESPONSE GET    api/groups/v1/{groupId}   [Service.API]
public class ENEEHMKFNCP
{
    public long <DLJPFHDOOGK>k__BackingField;    // 0x0x10
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x18
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x20
    public DateTime <DFHGAMJPDDD>k__BackingField;    // 0x0x28
    public string <NEHCOGJAMBL>k__BackingField;    // 0x0x30
    public JHAEMOPGPOO <JPBAAOGIOOJ>k__BackingField;    // 0x0x38
    public int <GLMABLLDLMF>k__BackingField;    // 0x0x3C
    public int <HEANFMIPGJC>k__BackingField;    // 0x0x40
    public List<CAHEFFMFMFP> <BCDMJLGDGCI>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// EOLKHEOFCID
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/rooms/v1/filters   [Service.API]
public class EOLKHEOFCID
{
    public List<string> <OKCJKKCOECO>k__BackingField;    // 0x0x10
    public List<string> <OHKGGEDAELO>k__BackingField;    // 0x0x18
    public List<string> <HONJDOCPFNP>k__BackingField;    // 0x0x20
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
// FBNKAAFFOFB
// base   : ILHKOKEOMMF
//   (not directly referenced by a detected call)
public class FBNKAAFFOFB : ILHKOKEOMMF
{
    public MELACGDOKGF <MDPACCHKMFK>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// FCBPDHONFFN
//   (not directly referenced by a detected call)
public class FCBPDHONFFN
{
    public string <MLKOAILMHFL>k__BackingField;    // 0x0x10
    public MAALIFHGPNP <PLDNNCNGLMB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FHFEHBPNOAH
//   (not directly referenced by a detected call)
public class FHFEHBPNOAH
{
    public long <MDJDKBFEIEA>k__BackingField;    // 0x0x10
    public string <FCOPMIEFCII>k__BackingField;    // 0x0x18
    public int <HKKJIIDDALH>k__BackingField;    // 0x0x20
    public int <CGCHJIFGEAA>k__BackingField;    // 0x0x24
    public int <JCKAMAHIBMN>k__BackingField;    // 0x0x28
    public int <AMNHNMCLNNK>k__BackingField;    // 0x0x2C
    public int <LIMHLBDAGLH>k__BackingField;    // 0x0x30
    public string <GDLANFAIFPK>k__BackingField;    // 0x0x38
    public string <EHGHEIEIBDD>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// FIKPLKHLJEL
//   RESPONSE GET    api/avatar/   [Service.API]
//   REQUEST  POST   api/avatar/   [Service.API]
//   REQUEST  POST   api/avatar/v2/set   [Service.API]
//   RESPONSE GET    api/avatar/v2/{cJLHCFEBBOM}   [Service.API]
//   REQUEST  POST   api/avatar/v2/{cJLHCFEBBOM}   [Service.API]
public class FIKPLKHLJEL
{
    public string <KNHHBLPCKPC>k__BackingField;    // 0x0x10
    public string <BEEDOPLAGPC>k__BackingField;    // 0x0x18
    public string <BDFAHPGILFN>k__BackingField;    // 0x0x20
    public string <EBDDDEENNAE>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// FLCEPCCIACC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FLCEPCCIACC
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
// FMOKDCALFOE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FMOKDCALFOE
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// GADCJFLOHCG
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class GADCJFLOHCG
{
    public List<FCBPDHONFFN> <ILIGBJLAABB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GBAFOOFKLGN
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.API]
public class GBAFOOFKLGN
{
    public Guid <JFPCGFICNLM>k__BackingField;    // 0x0x10
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x20
    public string <NEHCOGJAMBL>k__BackingField;    // 0x0x28
    public DateTime <NLKAGMHCAGA>k__BackingField;    // 0x0x30
    public DateTime? <BNAKAIACHOF>k__BackingField;    // 0x0x38
    public List<MMFANHGDCDA> <MFOBBOIEIHG>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// GJGEDPAHMDM
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/inventions/v4/addversion   [Service.API]
//   RESPONSE POST   api/inventions/v6/save   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.API]
public class GJGEDPAHMDM
{
    public HJCGJDIBBIJ <HHDAIOPDPHG>k__BackingField;    // 0x0x10
    public KFDADDFELJG <CKOHKAOOELK>k__BackingField;    // 0x0x18
    public FHFEHBPNOAH <GMDKBNMNBDB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// GMCFKNEKKPJ
//   (not directly referenced by a detected call)
public class GMCFKNEKKPJ
{
    public long <FPADEEKONII>k__BackingField;    // 0x0x10
    public Guid <FCOPMIEFCII>k__BackingField;    // 0x0x18
    public long <PBKBDNNJHCJ>k__BackingField;    // 0x0x28
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x30
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x38
    public int <LAOGMBHNGON>k__BackingField;    // 0x0x40
    public Guid? <JGMFPMMGBNH>k__BackingField;    // 0x0x44
    public DateTime <DFHGAMJPDDD>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// GMDDMDGKOEG
//   (not directly referenced by a detected call)
public class GMDDMDGKOEG
{
    public Guid <BCJENEOIMFC>k__BackingField;    // 0x0x10
    public int <DAGIHNKKAIJ>k__BackingField;    // 0x0x20
    public int <LNDBOBKNCOK>k__BackingField;    // 0x0x24
    public Guid <BNBKACIEIJM>k__BackingField;    // 0x0x28
    public DateTime <EOFOBDGLMLO>k__BackingField;    // 0x0x38
    public NMADCJGPLCL <OBHOGHKLJIC>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// HBHLFAIMJFK
//   (not directly referenced by a detected call)
public class HBHLFAIMJFK
{
    public float <PDDHIAMLFOE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// HGIHBHPCMJO
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
//   REQUEST  POST   api/config/v1/amplitude   [Service.API]
public class HGIHBHPCMJO
{
    public string <CPONJNDNMIF>k__BackingField;    // 0x0x10
    public string <BADHFAKGBLA>k__BackingField;    // 0x0x18
    public bool <GJKINCMGBMG>k__BackingField;    // 0x0x20
    public string <PKCFFEAPGAM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// HJCGJDIBBIJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HJCGJDIBBIJ
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
// HKANOGCHMGA
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.API]
public class HKANOGCHMGA
{
    public int <NEFKNCHHAKE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// HMKAILJCGHH
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable   [Service.API]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{dDINLPCKBJH}   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{dDINLPCKBJH}   [Service.API]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/description   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/description   [Service.API]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/image   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/image   [Service.API]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/name   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/name   [Service.API]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable/{roomconsumableId}/price   [Service.API]
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/{roomconsumableId}/price   [Service.API]
public class HMKAILJCGHH
{
    public ADLHCGHPGNP <HHDAIOPDPHG>k__BackingField;    // 0x0x10
    public NMADCJGPLCL <OBHOGHKLJIC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HNEONBFJCGG
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.API]
//   REQUEST  POST   api/roomcurrencies/v1/getBalance   [Service.API]
public class HNEONBFJCGG
{
    public int <DAGIHNKKAIJ>k__BackingField;    // 0x0x10
    public Guid <EHAJGGNNKOL>k__BackingField;    // 0x0x14
    public long <EBKFOKMBDED>k__BackingField;    // 0x0x28
    public DateTime <EOFOBDGLMLO>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// IJAGMCCDKIM
//   (not directly referenced by a detected call)
public class IJAGMCCDKIM
{
    public float <FGKBCAMJEDE>k__BackingField;    // 0x0x10
    public float <BOEOHNNFAED>k__BackingField;    // 0x0x14
    public float <KJNKFJLCJOO>k__BackingField;    // 0x0x18
    public float <FCGMBAOBBHL>k__BackingField;    // 0x0x1C
    public float <IFMEKBGCECA>k__BackingField;    // 0x0x20
    public float <FPFHLAGLDII>k__BackingField;    // 0x0x24
    public float <MEIBPNOGNFF>k__BackingField;    // 0x0x28
    public float <IJAFEFDDEAB>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// ILHKOKEOMMF
//   (not directly referenced by a detected call)
public class ILHKOKEOMMF
{
    public int <PPCJHDBKOJB>k__BackingField;    // 0x0x10
    public ELHOCMNAFOA <PLDNNCNGLMB>k__BackingField;    // 0x0x14
    public List<EIPFDDIKEBH> <ICDDKKEAPPJ>k__BackingField;    // 0x0x18
    public List<EIPFDDIKEBH> <OBCLOKLBLIH>k__BackingField;    // 0x0x20
    public bool <OCPOBHAKOCD>k__BackingField;    // 0x0x28
    public DateTime? <LIJNOKDPEMP>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// JAABOANDGIP
//   RESPONSE POST   api/roomcurrencies/v1/createPurchaseOffer   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/updatePurchaseOffer   [Service.API]
public class JAABOANDGIP
{
    public Guid <IOPGMKIBFGE>k__BackingField;    // 0x0x10
    public Guid <EHAJGGNNKOL>k__BackingField;    // 0x0x20
    public int <MFFLIGANNAE>k__BackingField;    // 0x0x30
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x38
    public long <EFKLLLDJIOD>k__BackingField;    // 0x0x40
    public long <LAOGMBHNGON>k__BackingField;    // 0x0x48
    public DateTime <EOFOBDGLMLO>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// JDFKNBAPIGE
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
public class JDFKNBAPIGE
{
    public bool <CNBOOBCPAFD>k__BackingField;    // 0x0x10
    public string <EMEBPJKDBBI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JHAEMOPGPOO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JHAEMOPGPOO
{
    GoodStanding = 0,
    InReview = 1,
    TempLock = 2,
    Permaban = 3,
}

// --------------------------------------------------------------------------
// JHEMHCBKIGF
//   RESPONSE POST   api/roomcurrencies/v1/awardCurrency   [Service.API]
public class JHEMHCBKIGF
{
    public int <DAGIHNKKAIJ>k__BackingField;    // 0x0x10
    public Guid <EHAJGGNNKOL>k__BackingField;    // 0x0x14
    public long <EBKFOKMBDED>k__BackingField;    // 0x0x28
    public long <OMCHGDHDMMP>k__BackingField;    // 0x0x30
    public DateTime <BFGHAICAIAF>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// JMNCAMGDOCF
//   RESPONSE POST   api/roomcurrencies/v1/createCurrency   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/updateCurrency   [Service.API]
public class JMNCAMGDOCF
{
    public Guid <EHAJGGNNKOL>k__BackingField;    // 0x0x10
    public long? <PBKBDNNJHCJ>k__BackingField;    // 0x0x20
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x30
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x38
    public NFPOLCDIFOD <PDJHKCNNJKC>k__BackingField;    // 0x0x40
    public long <BBGOCCJHJLK>k__BackingField;    // 0x0x48
    public DateTime <DFHGAMJPDDD>k__BackingField;    // 0x0x50
    public DateTime <EOFOBDGLMLO>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// KBEMDLHEOJF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KBEMDLHEOJF
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
// KECLAPALEJB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KECLAPALEJB
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
// KFDADDFELJG
//   (not directly referenced by a detected call)
public class KFDADDFELJG
{
    public long <MDJDKBFEIEA>k__BackingField;    // 0x0x10
    public string <FCOPMIEFCII>k__BackingField;    // 0x0x18
    public int <CLFMCINDFGC>k__BackingField;    // 0x0x20
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x28
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x30
    public string <NEHCOGJAMBL>k__BackingField;    // 0x0x38
    public int <PIDGFBBDMCP>k__BackingField;    // 0x0x40
    public KFMKGBBCBAM <PGBNNOOMAAC>k__BackingField;    // 0x0x44
    public DateTime <EOFOBDGLMLO>k__BackingField;    // 0x0x48
    public DateTime <DFHGAMJPDDD>k__BackingField;    // 0x0x50
    public DateTime? <HPAEIGNCFCI>k__BackingField;    // 0x0x58
    public long? <MIHHFNNKCBG>k__BackingField;    // 0x0x68
    public int <FMLBOAONAGM>k__BackingField;    // 0x0x78
    public int <MLJPENCADIH>k__BackingField;    // 0x0x7C
    public int <PMPMAFJOOMC>k__BackingField;    // 0x0x80
    public EFCPFLBCOMO <JOPAGOGGMPM>k__BackingField;    // 0x0x84
    public EFCPFLBCOMO <PACIFMPOAMB>k__BackingField;    // 0x0x88
    public bool <OKMHCAEIBHN>k__BackingField;    // 0x0x8C
    public bool <KHGKOGONCHN>k__BackingField;    // 0x0x8D
    public bool <EBAKFIEGIBP>k__BackingField;    // 0x0x8E
    public int? <LAOGMBHNGON>k__BackingField;    // 0x0x90
    public bool <FFDKMBDEKEB>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// KFEMJDLJIKD
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class KFEMJDLJIKD
{
    public List<MPCALKFCECL> <IMKMPFGEJPJ>k__BackingField;    // 0x0x10
    public NHDMLJAKFMP <NLCAIKCDFMA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KJIBCNJMLMC
//   (not directly referenced by a detected call)
public class KJIBCNJMLMC
{
    public int <KNPKDKNDKKC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KJOKBDPDFHI
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.API]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.API]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.API]
public class KJOKBDPDFHI
{
    public int <BJBODFOCJEI>k__BackingField;    // 0x0x10
    public bool <CFCBKIFKGPO>k__BackingField;    // 0x0x14
    public DateTime <GAIAPAKAEGD>k__BackingField;    // 0x0x18
    public bool <LKMNJONFBPG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KNEPMENKHAA
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
public class KNEPMENKHAA
{
    public bool <CNBOOBCPAFD>k__BackingField;    // 0x0x10
    public string <GCPADAKGEDF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KNHNPOMHPLC
//   RESPONSE GET    api/inventions/v1/personaldetails/{mDEFMMBOPJF}   [Service.API]
public class KNHNPOMHPLC
{
    public bool <OEPMGACIGKI>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KOGOFGMKODG
//   (not directly referenced by a detected call)
public class KOGOFGMKODG
{
    public long <LICOMCJNALG>k__BackingField;    // 0x0x10
    public string <GONHPBJIHAH>k__BackingField;    // 0x0x18
    public string <CMHCLNLILBD>k__BackingField;    // 0x0x20
    public BLIBFEAHCOE? <FOKGNMMDNLF>k__BackingField;    // 0x0x28
    public string <EKJCBPNKOEC>k__BackingField;    // 0x0x30
    public string <DANBLCBLEPA>k__BackingField;    // 0x0x38
    public OCGEAFIGJBG <NCLAINCDENB>k__BackingField;    // 0x0x40
    public int <HNIDLJMDNNG>k__BackingField;    // 0x0x44
    public int <OIAGAEBBLAF>k__BackingField;    // 0x0x48
    public PPAOBACMBDG? <NHFCIIGMONO>k__BackingField;    // 0x0x4C
    public OFKBPADPBID? <LNFNKLPAGIN>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// KPAHNCIDEAJ
//   (not directly referenced by a detected call)
public class KPAHNCIDEAJ
{
    public int <JAKLOPABDIP>k__BackingField;    // 0x0x10
    public DateTime? <OGMHMPLFFKM>k__BackingField;    // 0x0x18
    public DateTime? <FMIEEIJOLFN>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LDAJEECHOGC
//   REQUEST  POST   api/settings/v2/set   [Service.API]
public class LDAJEECHOGC
{
    public string <JDDENHCPBAD>k__BackingField;    // 0x0x10
    public string <BCOCKKKJAFA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LEIMNGLPAJC
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class LEIMNGLPAJC
{
    public int? <ALGJNMEMIIM>k__BackingField;    // 0x0x10
    public string <MEKPKNPLJBG>k__BackingField;    // 0x0x18
    public string <OIKOOPFIOAI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LFKGKPJOGIE
//   RESPONSE GET    api/testcasemanagement/v1/testcase/{hJPPHGKEPAC}   [Service.API]
public class LFKGKPJOGIE
{
    public string <ONMJCFLHEPN>k__BackingField;    // 0x0x10
    public string <JDDENHCPBAD>k__BackingField;    // 0x0x18
    public string <PKLLGPNDFMN>k__BackingField;    // 0x0x20
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x28
    public string <MEKPKNPLJBG>k__BackingField;    // 0x0x30
    public LLBPNLANKOG <HHDAIOPDPHG>k__BackingField;    // 0x0x38
    public List<string> <JOBLNDCBOHM>k__BackingField;    // 0x0x40
    public List<string> <ILIGBJLAABB>k__BackingField;    // 0x0x48
    public string <JJKBIJMIMJI>k__BackingField;    // 0x0x50
    public List<BELKOAAGGAO> <LMGGJFAINOB>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// LGMFBPCAFFL
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class LGMFBPCAFFL
{
    public int <IEMPHNIHOEL>k__BackingField;    // 0x0x10
    public MMBOAMHHADG <PLDNNCNGLMB>k__BackingField;    // 0x0x14
    public PPABKCBFGKO <GHDGMEAHGJI>k__BackingField;    // 0x0x18
    public PPABKCBFGKO <EBLJJLBJCAN>k__BackingField;    // 0x0x1C
    public PPABKCBFGKO <HBBLFECJMFK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LIOGIPKINCH
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.API]
public class LIOGIPKINCH
{
    public int <KHGDEHLDAIP>k__BackingField;    // 0x0x10
    public int <BJBODFOCJEI>k__BackingField;    // 0x0x14
    public float <HKACAGGIKPK>k__BackingField;    // 0x0x18
    public float <ICLMLOCHPPI>k__BackingField;    // 0x0x1C
    public bool <CFCBKIFKGPO>k__BackingField;    // 0x0x20
    public bool <CJAPCMKFNGJ>k__BackingField;    // 0x0x21
    public bool <AJHDKGINECC>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// LLBPNLANKOG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LLBPNLANKOG
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// MAALIFHGPNP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MAALIFHGPNP
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// MELACGDOKGF
//   (not directly referenced by a detected call)
public class MELACGDOKGF
{
    public int <LICOMCJNALG>k__BackingField;    // 0x0x10
    public string <JNEKFFAAGOB>k__BackingField;    // 0x0x18
    public string <IPNCKJJANOO>k__BackingField;    // 0x0x20
    public string <GONHPBJIHAH>k__BackingField;    // 0x0x28
    public string <HAIOMFPDKKK>k__BackingField;    // 0x0x30
    public BLIBFEAHCOE? <FOKGNMMDNLF>k__BackingField;    // 0x0x38
    public string <EKJCBPNKOEC>k__BackingField;    // 0x0x40
    public string <DANBLCBLEPA>k__BackingField;    // 0x0x48
    public bool <PHFJCBGLLDC>k__BackingField;    // 0x0x50
    public bool <GKCIBAFFKMC>k__BackingField;    // 0x0x51
    public bool <AIAIMNOJEHN>k__BackingField;    // 0x0x52
    public OFKBPADPBID <AAIFDMJHPLJ>k__BackingField;    // 0x0x54
    public NFPOLCDIFOD <PDJHKCNNJKC>k__BackingField;    // 0x0x58
    public int <HACEICNODJC>k__BackingField;    // 0x0x5C
    public PCJBCNHELOG <JINNPJIPGPA>k__BackingField;    // 0x0x60
    public PPAOBACMBDG <BDBANDAFKPD>k__BackingField;    // 0x0x64
    public int? <EMNMIGBCOHN>k__BackingField;    // 0x0x68
    public string <BFGOOIHMMOF>k__BackingField;    // 0x0x70
}

// --------------------------------------------------------------------------
// MHNHEKPJKMM
//   (not directly referenced by a detected call)
public class MHNHEKPJKMM
{
    public bool <LLJBLKFAIJC>k__BackingField;    // 0x0x10
    public KBEMDLHEOJF <ELBJEFLJEIN>k__BackingField;    // 0x0x14
    public int <CNPHAEGEMJJ>k__BackingField;    // 0x0x18
    public DateTime <EOFOBDGLMLO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MIKIMGBAHJP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MIKIMGBAHJP
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// MJKEGEHBIGG
//   RESPONSE GET    api/incentivizedreferrals/   [Service.API]
//   REQUEST  POST   api/incentivizedreferrals/   [Service.API]
public class MJKEGEHBIGG
{
    public List<PPMGAKNOJDC> <CFPBGDEMGKO>k__BackingField;    // 0x0x10
    public string <BJALJEFMEDF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MJKPHKHNCKK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MJKPHKHNCKK
{
    Locked = 0,
    Unlocked = 1,
    Claimed = 2,
}

// --------------------------------------------------------------------------
// MMFANHGDCDA
//   (not directly referenced by a detected call)
public class MMFANHGDCDA
{
    public Guid <GINFBNCIJEI>k__BackingField;    // 0x0x10
    public Guid <POCHJEEGAEC>k__BackingField;    // 0x0x20
    public DateTime <NLKAGMHCAGA>k__BackingField;    // 0x0x30
    public List<MELACGDOKGF> <KKKCGFAJHOH>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// MNHNLMLGAIE
// base   : ILHKOKEOMMF
//   (not directly referenced by a detected call)
public class MNHNLMLGAIE : ILHKOKEOMMF
{
    public int <NGLJDNIINPN>k__BackingField;    // 0x0x40
    public List<EAOPBMJACPD> <IEIBNNDFFKI>k__BackingField;    // 0x0x48
    public List<EAOPBMJACPD> <NLLDIMIFBFM>k__BackingField;    // 0x0x50
    public List<EAOPBMJACPD> <LKNCLNJIIAA>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// MPCALKFCECL
//   (not directly referenced by a detected call)
public class MPCALKFCECL
{
    public int <MMLGMMLJBBC>k__BackingField;    // 0x0x10
    public NHDMLJAKFMP <NLCAIKCDFMA>k__BackingField;    // 0x0x14
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
// NFHGFCLOPKE
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class NFHGFCLOPKE
{
    public BPJGOHKPFPD <NLCAIKCDFMA>k__BackingField;    // 0x0x10
    public List<string> <ILIGBJLAABB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NFPOLCDIFOD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NFPOLCDIFOD
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
// NHDMLJAKFMP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NHDMLJAKFMP
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
// NMADCJGPLCL
//   (not directly referenced by a detected call)
public class NMADCJGPLCL
{
    public Guid <BCJENEOIMFC>k__BackingField;    // 0x0x10
    public long <PBKBDNNJHCJ>k__BackingField;    // 0x0x20
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x28
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x30
    public string <NEHCOGJAMBL>k__BackingField;    // 0x0x38
    public long <LAOGMBHNGON>k__BackingField;    // 0x0x40
    public Guid? <JGMFPMMGBNH>k__BackingField;    // 0x0x48
    public DateTime <EOFOBDGLMLO>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// OCGEAFIGJBG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OCGEAFIGJBG
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
}

// --------------------------------------------------------------------------
// OFKBPADPBID
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OFKBPADPBID
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// OGEOHBLLBDJ
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class OGEOHBLLBDJ
{
    public NHDMLJAKFMP <NLCAIKCDFMA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OHCMGFPMKNK
//   (not directly referenced by a detected call)
public class OHCMGFPMKNK
{
    public int <ACLFCBCPAED>k__BackingField;    // 0x0x10
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x18
    public string <NCJIHLANNPG>k__BackingField;    // 0x0x20
    public string <FMJHFIHBGBE>k__BackingField;    // 0x0x28
    public string <IPNCKJJANOO>k__BackingField;    // 0x0x30
    public bool <DKMGHIEJDCF>k__BackingField;    // 0x0x38
    public int <FCCCIMOPBCP>k__BackingField;    // 0x0x3C
    public ELDMGGOEPGP <ELLPMMDEBKB>k__BackingField;    // 0x0x40
    public NGEHCJLLODH ILFFIKOOPLN;    // 0x0x48
    public NGEHCJLLODH KELAGEBOHCL;    // 0x0x50
    public NGEHCJLLODH GJGINNOLKKI;    // 0x0x58
    public NDNJKLFBIGI EKEEFIPLNLJ;    // 0x0x60
}

// --------------------------------------------------------------------------
// OHDMBPJNIDP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OHDMBPJNIDP
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
// OIFJEPBJFKH
//   REQUEST  POST   api/avatar/v3/saved/set   [Service.API]
public class OIFJEPBJFKH
{
    public int <FCCCIMOPBCP>k__BackingField;    // 0x0x10
    public string <KMCPINBLKCG>k__BackingField;    // 0x0x18
    public string <KNHHBLPCKPC>k__BackingField;    // 0x0x20
    public string <BEEDOPLAGPC>k__BackingField;    // 0x0x28
    public string <BDFAHPGILFN>k__BackingField;    // 0x0x30
    public string <EBDDDEENNAE>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// OPDPEGPHHAJ
//   (not directly referenced by a detected call)
public class OPDPEGPHHAJ
{
    public DKGJGNDIAAH <BIBIGDKLDJJ>k__BackingField;    // 0x0x10
    public CEBKCIHLLNJ <LLGCFCOEHAI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PCFNDANECLP
//   (not directly referenced by a detected call)
public class PCFNDANECLP
{
    public int <DIFCKPNBHDD>k__BackingField;    // 0x0x10
    public int <JLNDEHMDMCO>k__BackingField;    // 0x0x14
    public int <LLFGBEAJODG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PCJBCNHELOG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PCJBCNHELOG
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
// PCPEEIBGEMB
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{balanceaddtypeId}/{id1}   [Service.API]
public class PCPEEIBGEMB
{
    public NFPOLCDIFOD <PDJHKCNNJKC>k__BackingField;    // 0x0x10
    public KECLAPALEJB <JFALBMBIGCK>k__BackingField;    // 0x0x14
    public int <FBIBKKMNPJM>k__BackingField;    // 0x0x18
    public int <PMNOAMCDDCD>k__BackingField;    // 0x0x1C
    public int <AGAOAOCJAHA>k__BackingField;    // 0x0x20
    public EMMAJAAEDLJ <KHMFKJGMMMB>k__BackingField;    // 0x0x24
    public bool <JEHGPMOGCAC>k__BackingField;    // 0x0x28
    public float <KEAAJHGHFDG>k__BackingField;    // 0x0x2C
    public int <EDOBKPFHOJL>k__BackingField;    // 0x0x30
    public bool <DGCHAHFMMHA>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// PFBINHPMFJI
//   REQUEST  POST   api/playerevents/v1/report   [Service.API]
public class PFBINHPMFJI
{
    public GGIFKBIPKPN <OOJFECKMEDC>k__BackingField;    // 0x0x10
    public long <FMJFKLOIMEI>k__BackingField;    // 0x0x18
    public string <LFPIIBPAIGB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PFFLBJFIHAK
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   REQUEST  POST   api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{cJLHCFEBBOM}   [Service.API]
public class PFFLBJFIHAK
{
    public List<DKGJGNDIAAH> <PAKAHLEGBEM>k__BackingField;    // 0x0x10
    public List<OPDPEGPHHAJ> <GFKIJFNONFC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PFHIBMIKAFP
//   RESPONSE GET    api/influencerpartnerprogram/   [Service.API]
//   REQUEST  POST   api/influencerpartnerprogram/   [Service.API]
public class PFHIBMIKAFP
{
    public List<int> <MIEDCHNGFJL>k__BackingField;    // 0x0x10
    public string <BJALJEFMEDF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PIDBNCDACEI
//   REQUEST  POST   api/playerevents/v1/respond   [Service.API]
public class PIDBNCDACEI
{
    public long <FMJFKLOIMEI>k__BackingField;    // 0x0x10
    public MIKIMGBAHJP <PLDNNCNGLMB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PJDAAGHDGLF
//   (not directly referenced by a detected call)
public class PJDAAGHDGLF
{
    public DateTime? <BHKLNALKAHK>k__BackingField;    // 0x0x10
    public DateTime? <FMJJGPICKLB>k__BackingField;    // 0x0x20
    public MJKPHKHNCKK <HHDAIOPDPHG>k__BackingField;    // 0x0x30
    public PCFNDANECLP <KBAHCAOIFBD>k__BackingField;    // 0x0x38
    public bool <NLKHNJMHILP>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// PLLAGDBPHIK
//   (not directly referenced by a detected call)
public class PLLAGDBPHIK
{
    public int <DHCCCFNCIFC>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PNJAEMFJNGJ
//   RESPONSE GET    api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class PNJAEMFJNGJ
{
    public GGIFKBIPKPN <OOJFECKMEDC>k__BackingField;    // 0x0x10
    public int <NEFKNCHHAKE>k__BackingField;    // 0x0x14
    public long <MCCCIHCLGFB>k__BackingField;    // 0x0x18
    public bool <KICLGMDBOIB>k__BackingField;    // 0x0x20
    public string <EMEBPJKDBBI>k__BackingField;    // 0x0x28
    public int? <BOKEJCBDBKM>k__BackingField;    // 0x0x30
    public bool <IOBFGCIOPAI>k__BackingField;    // 0x0x38
    public string <CEIGNIFLFAK>k__BackingField;    // 0x0x40
    public float <ALJLJIOFNEL>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// PPAOBACMBDG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PPAOBACMBDG
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
    SubscribersOnly = 1003,
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
    Commerce_Purchase = 200000,
}

// --------------------------------------------------------------------------
// PPAPDMGDDMP
//   (not directly referenced by a detected call)
public class PPAPDMGDDMP
{
    public int <ALFAIKDJCLP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PPMGAKNOJDC
//   (not directly referenced by a detected call)
public class PPMGAKNOJDC
{
    public int <FBPONKLHAHH>k__BackingField;    // 0x0x10
    public DateTime <DFHGAMJPDDD>k__BackingField;    // 0x0x18
    public DateTime? <OHNLACGNBPI>k__BackingField;    // 0x0x20
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
    public LKMMPHBMHOA FilterType;    // 0x0x20
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
    public PPAOBACMBDG <GiftContext>k__BackingField;    // 0x0x20
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
    public CFECFFENNLN creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public OJHOPBPGALG <AGDANIPNLBA>k__BackingField;    // 0x0x10
    public string <PLJJKCPMDIG>k__BackingField;    // 0x0x18
    public bool <HEGHKBBAACN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public List<OJHOPBPGALG> <MFAIPGPEJPO>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public KLFMLGIHMKI ReportCategory;    // 0x0x20
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
    public JCCBLLDHJLA? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public JCCBLLDHJLA CJGEMGIOIBJ;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object RoomId;  // candidate
    public object Anonymous;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public NPKLNNFGNIK MFMMILFGFKE;  // wrapper
    public object oldDeviceId;  // candidate
    public object newDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public KHECGCAJKBE CIMKNKPILIM;  // wrapper
    public int? FMGEJEFALNI;  // wrapper
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
    public KPNFDNMNMIM UnlockedLevel;  // wrapper
}

// api/avatar/v2/gifts/generate  [API POST]
public class AvatarV2GiftsGenerateRequest
{
    public PPAOBACMBDG JJNBJBEMAKH;  // wrapper
    public PPAOBACMBDG? ACFDCEKOKLK;  // wrapper
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object AlternateGiftContext;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [API POST]
public class AvatarV3GiftsGenerateRequest
{
    public PPAOBACMBDG JJNBJBEMAKH;  // wrapper
    public PPAOBACMBDG? ACFDCEKOKLK;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [API POST]
public class ChallengeV2UpdateProgressRequest
{
    public OHCMGFPMKNK KCNPGMLPJAB;  // wrapper
    public object UpdateChallengeProgress;  // candidate
    public object ChallengeMapId;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object Complete;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public GGIFKBIPKPN DKDENPBAPEK;  // wrapper
    public object clubId;  // candidate
    public object reportCategory;  // candidate
    public object details;  // candidate
}

// api/equipment/v1/update  [API POST]
public class EquipmentV1UpdateRequest
{
    public IReadOnlyList<KBCPFALAIAN> Update;  // wrapper
}

// api/gamerewards/v1/request  [API POST]
public class GamerewardsV1RequestRequest
{
    public LMOHPCCOGJN MGOHPDEMMBF;  // wrapper
    public PPAOBACMBDG? OPBNGIBIANH;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [API POST]
public class GamerewardsV1SelectRequest
{
    public POBKHDNDPPL HNJKOHGDCCE;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/groups/v1/delete/{groupId}  [API POST]
public class GroupsV1DeleteGroupIdRequest
{
    public StatusResponse> FNJEPDKDNHM;  // wrapper
    public object GroupId;  // candidate
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
    public List<long> FKJDCPKDGLO;  // wrapper
    public GHGPPPNELMG AJJDDKOOIEN;  // wrapper
    public long? LJODGADJAPC;  // wrapper
    public AGGHFFPJNPK FNJEPDKDNHM;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object SendMessageMultiple;  // candidate
    public object RoomId;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public GHGPPPNELMG AJJDDKOOIEN;  // wrapper
    public long? LJODGADJAPC;  // wrapper
    public AGGHFFPJNPK FNJEPDKDNHM;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/offlineinvite/v1/send  [API POST]
public class OfflineinviteV1SendRequest
{
    public String> FNJEPDKDNHM;  // wrapper
    public object PlayerId;  // candidate
}

// api/playerevents/v2/delete/{lPABPJCFOKF}  [API POST]
public class PlayereventsV2DeleteLPABPJCFOKFRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public FMOKDCALFOE FPCDIAALGKD;  // wrapper
    public object accessibility;  // candidate
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public long? PNDEMFEIGCG;  // wrapper
    public object clubId;  // candidate
}

// api/playerevents/v2/{eventId}/description  [API PUT]
public class PlayereventsV2EventIdDescriptionRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public object description;  // candidate
}

// api/playerevents/v2/{eventId}/image  [API PUT]
public class PlayereventsV2EventIdImageRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public object imageName;  // candidate
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public object isMultiInstance;  // candidate
    public object supportsMultiInstanceRoomChat;  // candidate
}

// api/playerevents/v2/{eventId}/name  [API PUT]
public class PlayereventsV2EventIdNameRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public object name;  // candidate
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public long? DMONLOHCBJH;  // wrapper
    public object roomId;  // candidate
    public object subRoomId;  // candidate
}

// api/playerevents/v2/{eventId}/tags  [API PUT]
public class PlayereventsV2EventIdTagsRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public List<string> CGFFBLCNDNK;  // wrapper
    public object ModifyEventTags;  // candidate
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DKGJGNDIAAH LPABPJCFOKF;  // wrapper
    public DateTime MMJOAHLLJHF;  // wrapper
    public DateTime KIKFPEBIKFF;  // wrapper
    public object startTime;  // candidate
    public object endTime;  // candidate
}

// api/players/v2/objectives  [API POST]
public class PlayersV2ObjectivesRequest
{
    public List<GJEJBBJMJJM> KGCKJGLJCIG;  // wrapper
    public object objectiveType;  // candidate
    public object additionalXp;  // candidate
    public object inParty;  // candidate
    public object CompleteObjectives;  // candidate
}

// api/roomkeys/v1/RoomKeyId  [API PUT]
public class RoomkeysV1RoomKeyIdRequest
{
    public IEnumerable<KeyValuePair<string, string>> INNGGBGHBPE;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [API POST]
public class RoomkeysV1CreateRequest
{
    public Guid? BKFHCNFFMEM;  // wrapper
    public object RoomId;  // candidate
    public object Name;  // candidate
    public object Description;  // candidate
    public object Price;  // candidate
    public object PurchaseCurrencyId;  // candidate
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
    public MatchCompleteStats HNDCJPLMICJ;  // wrapper
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
    public Guid JPCGMAFLALA;  // wrapper
    public object RoomKeyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedPurchaseCurrencyId;  // candidate
}

// api/storefronts/v1/objectives  [API POST]
public class StorefrontsV1ObjectivesRequest
{
    public List<MPGNHACKAPE> KGCKJGLJCIG;  // wrapper
    public object objectiveType;  // candidate
    public object completionPercentage;  // candidate
    public object roomId;  // candidate
    public object CompleteObjectives;  // candidate
}

// api/testcasemanagement/v1/testcase/{testcaseId}/status  [API POST]
public class TestcasemanagementV1TestcaseTestcaseIdStatusRequest
{
    public LLBPNLANKOG IIOFNHABMEN;  // wrapper
}

