// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 219 (plus referenced enums)

// --------------------------------------------------------------------------
// ACDKILABNNC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ACDKILABNNC
{
    Invalid = 0,
    LaserTagTickets = 1,
    RecCenterTokens = 2,
    LostSkullsGold = 100,
    DraculaSilver = 101,
    RecRoyale_Season1 = 200,
}

// --------------------------------------------------------------------------
// AEBEPCMAABC
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/rooms/v1/filters   [Service.API]
public class AEBEPCMAABC
{
    public List<string> <EPPJKINEHHJ>k__BackingField;    // 0x0x10
    public List<string> <DEDCDFOLGII>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// AHEPPAEOLOD
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE POST   api/inventions/v3/addversion   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/inventions/v4/save   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.API]
public class AHEPPAEOLOD
{
    public JJONIELLJGH <BCMKPFMGHLE>k__BackingField;    // 0x0x10
    public OBBBPCBIMME <LAAELBKJOPB>k__BackingField;    // 0x0x18
    public NEFHINKECJJ <JEKIHBMKBIF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AMAGKLLBGEC
//   (not directly referenced by a detected call)
public class AMAGKLLBGEC
{
    public long <DNOCFKLHLDC>k__BackingField;    // 0x0x10
    public Guid <DJCKNJNCOKN>k__BackingField;    // 0x0x18
    public long <DOFDAMHCJLP>k__BackingField;    // 0x0x28
    public string <LGACIEKBLBM>k__BackingField;    // 0x0x30
    public string <EHGJCEHECFB>k__BackingField;    // 0x0x38
    public int <LGKBIBJHNCN>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// BCKIBFNPIPD
//   RESPONSE POST   api/roomkeys/v1/create   [Service.API]
//   RESPONSE PUT    api/roomkeys/v1/update   [Service.API]
public class BCKIBFNPIPD
{
    public BMHHFIGBOFD <BCMKPFMGHLE>k__BackingField;    // 0x0x10
    public AMAGKLLBGEC <PHHHDCDIMLO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BKFGFHDDNFG
// base   : DOPJPOEFDCN
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.API]
public class BKFGFHDDNFG : DOPJPOEFDCN
{
    public List<HOJMGAMMIAD> JDGEBBMDJBC;    // 0x0x30
}

// --------------------------------------------------------------------------
// BMHHFIGBOFD
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/v1/delete/{bGICHOOBKLD}   [Service.API]
public enum BMHHFIGBOFD
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
// CCMBKDINCAH
//   (not directly referenced by a detected call)
public class CCMBKDINCAH
{
    public long <KJHKNKGENCJ>k__BackingField;    // 0x0x10
    public int <KBFNGJBKEOP>k__BackingField;    // 0x0x18
    public long <DOFDAMHCJLP>k__BackingField;    // 0x0x20
    public long? <OMCJBBKKIKO>k__BackingField;    // 0x0x28
    public long? <CHPCFOKEIFM>k__BackingField;    // 0x0x38
    public string <LGACIEKBLBM>k__BackingField;    // 0x0x48
    public string <EHGJCEHECFB>k__BackingField;    // 0x0x50
    public string <HPJCFFLAJJE>k__BackingField;    // 0x0x58
    public DateTime <NBPEAFMLPDJ>k__BackingField;    // 0x0x60
    public DateTime <EKCLCPFEHDB>k__BackingField;    // 0x0x68
    public int <DIFCEDOHBFA>k__BackingField;    // 0x0x70
    public CMCAFKLAHCD <OMHKPJKDFLJ>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// CDNNKFCCONN
//   REQUEST  POST   api/avatar/v3/saved/set   [Service.API]
public class CDNNKFCCONN
{
    public int <GDACFKPEADA>k__BackingField;    // 0x0x10
    public string <PFFJLDNHOGB>k__BackingField;    // 0x0x18
    public string <PNBGCBDOILI>k__BackingField;    // 0x0x20
    public string <BFMHMHLLEGF>k__BackingField;    // 0x0x28
    public string <DCPCMEAPAKJ>k__BackingField;    // 0x0x30
    public string <CMKJKMJIGEL>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// CMCAFKLAHCD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CMCAFKLAHCD
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// COLBJJAIEIO
//   (not directly referenced by a detected call)
public class COLBJJAIEIO
{
    public int <JEAGGCHDLEH>k__BackingField;    // 0x0x10
    public string <LGACIEKBLBM>k__BackingField;    // 0x0x18
    public string <CKIBDKNHBCA>k__BackingField;    // 0x0x20
    public string <EHGJCEHECFB>k__BackingField;    // 0x0x28
    public string <ILKJJMACHPC>k__BackingField;    // 0x0x30
    public bool <CAHKBCHMKJN>k__BackingField;    // 0x0x38
    public int <GDACFKPEADA>k__BackingField;    // 0x0x3C
    public PHHHPJKCHBM <OKIPJEBHHKO>k__BackingField;    // 0x0x40
    public BOPMIMNFCGL PEJHFIFHFJB;    // 0x0x48
    public BOPMIMNFCGL FEGGFLCNHJK;    // 0x0x50
    public BOPMIMNFCGL PDEILKHDNJJ;    // 0x0x58
    public ODKEIAIGIIM IHGLBDPCIFC;    // 0x0x60
}

// --------------------------------------------------------------------------
// CPFPHLINDHN
//   RESPONSE GET    api/testcasemanagement/v1/testcase/{eNJEOLBEALP}   [Service.API]
public class CPFPHLINDHN
{
    public string JPOHGBCEJEJ;    // 0x0x10
    public string AKFDMGLACLA;    // 0x0x18
    public string LKIBJOMNFFD;    // 0x0x20
    public string KODBEJPEFOJ;    // 0x0x28
    public string HEHAGDOEDHG;    // 0x0x30
    public NIDIHGENDJD HIMCGOCKLLK;    // 0x0x38
    public int JOPPLLFIIOM;    // 0x0x3C
    public List<int> JFOIIDOFNCF;    // 0x0x40
    public List<string> GEPOBHPJHAK;    // 0x0x48
    public List<string> PKKADKGDHNI;    // 0x0x50
    public string EGBGAKBPEBD;    // 0x0x58
    public string IOBANKPIFFG;    // 0x0x60
}

// --------------------------------------------------------------------------
// CircuitsV2.Context.PromptResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class PromptResponse : ValueType
{
    public bool PromptSuccess;    // 0x0x0
    public string TextInput;    // 0x0x8
}

// --------------------------------------------------------------------------
// CircuitsV2.Graph.Nodes.DiceResult
// base   : CircuitsV2.Graph.Nodes.InteropNode
//   (not directly referenced by a detected call)
public class DiceResult : InteropNode
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// CircuitsV2.Types.Checker.Unification.Reference.ReferenceApplyConstraintResult
//   (not directly referenced by a detected call)
public class ReferenceApplyConstraintResult
{
    public ApplyConstraintResultKind <Kind>k__BackingField;    // 0x0x10
    public ReferenceConstraint <FirstConstraint>k__BackingField;    // 0x0x18
    public ReferenceConstraint <SecondConstraint>k__BackingField;    // 0x0x20
    public ReferenceSubstitution <Substitution>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// CircuitsV2.Types.Checker.Unification.Value.ApplyConstraintResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ApplyConstraintResult : ValueType
{
    public Impl impl;    // 0x0x0
    public ApplyConstraintResultKind <Kind>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// CircuitsV2.Utilities.Result
//   (not directly referenced by a detected call)
public class Result
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// CircuitsV2.Utilities.Result`1
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class Result : ValueType
{
    public object err;    // 0x0x0
    public T ok;    // 0x0x0
}

// --------------------------------------------------------------------------
// DGOHCPBKOHD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DGOHCPBKOHD
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
}

// --------------------------------------------------------------------------
// DGOPHENCPOC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DGOPHENCPOC
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
}

// --------------------------------------------------------------------------
// DIBODMEJOPN
//   RESPONSE GET    api/messages/v1/IOSGetNotificationPreferences   [Service.API]
public class DIBODMEJOPN
{
    public bool <PLNOJDHALCD>k__BackingField;    // 0x0x10
    public bool <KOGHJCBHAGK>k__BackingField;    // 0x0x11
    public bool <MBOJCJMCFHK>k__BackingField;    // 0x0x12
}

// --------------------------------------------------------------------------
// DKFDKNLDEAM
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{balanceaddtypeId}/{id1}   [Service.API]
public class DKFDKNLDEAM
{
    public ACDKILABNNC <BMOGJOHDDMD>k__BackingField;    // 0x0x10
    public DKMCNBHMKIK <EKKNIKCKHJC>k__BackingField;    // 0x0x14
    public int <JKIKOCCONFF>k__BackingField;    // 0x0x18
    public int <KOIEJFDEIFD>k__BackingField;    // 0x0x1C
    public int <LJHEMIAEFBD>k__BackingField;    // 0x0x20
    public LNADMEHDHCH <LOJABAECBIA>k__BackingField;    // 0x0x24
    public bool <JMFBNALLNLI>k__BackingField;    // 0x0x28
    public float <KEACGBIGLLI>k__BackingField;    // 0x0x2C
    public int <AECAMDGJDID>k__BackingField;    // 0x0x30
    public bool <HDAPLDHFDKB>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// DKMCNBHMKIK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DKMCNBHMKIK
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
// ECMOALAFBLJ
//   (not directly referenced by a detected call)
public class ECMOALAFBLJ
{
    public float <ANKFILEKHCO>k__BackingField;    // 0x0x10
    public float <EGIBAJEAOHD>k__BackingField;    // 0x0x14
    public float <GBIJILDHMOI>k__BackingField;    // 0x0x18
    public float <BLMFHCBKGEN>k__BackingField;    // 0x0x1C
    public float <EEEFGKJMCGD>k__BackingField;    // 0x0x20
    public float <BFHLDAJEJFK>k__BackingField;    // 0x0x24
    public float <KCPEIFMHANI>k__BackingField;    // 0x0x28
    public float <BKHKIIDAIJE>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// ECOKKKFCDID
//   (not directly referenced by a detected call)
public class ECOKKKFCDID
{
    public int <CBPNJDOGEOJ>k__BackingField;    // 0x0x10
    public GHHAKIFOOMF <PALMIOEJANE>k__BackingField;    // 0x0x14
    public List<NJKOJLBLFGI> <FLOHOPFIOMF>k__BackingField;    // 0x0x18
    public List<NJKOJLBLFGI> <NPKGABGPBEH>k__BackingField;    // 0x0x20
    public bool <KECNJFJOJLM>k__BackingField;    // 0x0x28
    public DateTime? <LMBOMOCLAOE>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// EHMPLAFFJAH
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
public class EHMPLAFFJAH
{
    public string <HKBMCNNGNDN>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// ENAODGBHHFA
// base   : DOPJPOEFDCN
//   RESPONSE GET    api/storefronts/v1/season/{seasonId}   [Service.API]
public class ENAODGBHHFA : DOPJPOEFDCN
{
    public int <LLIBGMJIENA>k__BackingField;    // 0x0x30
    public string <LGACIEKBLBM>k__BackingField;    // 0x0x38
    public DateTime <LKOFPDJICPA>k__BackingField;    // 0x0x40
    public DateTime <OHPBNGBPHLL>k__BackingField;    // 0x0x48
    public ACDKILABNNC <BMOGJOHDDMD>k__BackingField;    // 0x0x50
    public ECOKKKFCDID <MELOBIMHHPE>k__BackingField;    // 0x0x58
    public List<OCGBMPFIJBC> <IJMNLOHNONA>k__BackingField;    // 0x0x60
    public LGKFKEIKPPC <DIDALPJGLJJ>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// ENLDOIBMOJE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ENLDOIBMOJE
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
    public Dictionary<byte, object> Parameters;    // 0x0x18
}

// --------------------------------------------------------------------------
// ExitGames.Client.Photon.OperationResponse
//   (not directly referenced by a detected call)
public class OperationResponse
{
    public byte OperationCode;    // 0x0x10
    public short ReturnCode;    // 0x0x12
    public string DebugMessage;    // 0x0x18
    public Dictionary<byte, object> Parameters;    // 0x0x20
}

// --------------------------------------------------------------------------
// FDAJOEOJFDN
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{eNJEOLBEALP}   [Service.API]
public class FDAJOEOJFDN
{
    public uint JPOHGBCEJEJ;    // 0x0x10
    public string FIKEBGGCDFN;    // 0x0x18
    public string KODBEJPEFOJ;    // 0x0x20
    public DateTime CKDMMCJNCHB;    // 0x0x28
    public DateTime? CKNFHKKHNHP;    // 0x0x30
    public bool JICMOEJKCHG;    // 0x0x40
    public List<CPFPHLINDHN> KODOFNJJJCK;    // 0x0x48
    public List<string> PKKADKGDHNI;    // 0x0x50
    public int BPPENAKNGNG;    // 0x0x58
    public int PFIABEONLFI;    // 0x0x5C
    public int CAKKOAKBIIG;    // 0x0x60
}

// --------------------------------------------------------------------------
// FFEICMIIBMC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FFEICMIIBMC
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// FJAEPBBCEKE
//   RESPONSE POST   api/consumables/v1/transfer   [Service.API]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.API]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.API]
public class FJAEPBBCEKE
{
    public bool <NHCNKEMFEJC>k__BackingField;    // 0x0x10
    public string <ILNFIBHJENP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FNBMIJGOOJM
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
public class FNBMIJGOOJM
{
    public List<CCMBKDINCAH> <AHBNFBFLLBM>k__BackingField;    // 0x0x10
    public List<HJCAMMLHJAE> <LJCDIIPIHLB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FNEEJMCEPOL
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.API]
public class FNEEJMCEPOL
{
    public int <LOFCJJPPFJP>k__BackingField;    // 0x0x10
    public string <HINPCOBOOOK>k__BackingField;    // 0x0x18
    public List<COLBJJAIEIO> <OFGBKDLHOPK>k__BackingField;    // 0x0x20
    public HDCDFPNFDDJ <GAAOLJKDALN>k__BackingField;    // 0x0x28
    public string <JIKKGKKNCMJ>k__BackingField;    // 0x0x30
    public DateTime <LKOFPDJICPA>k__BackingField;    // 0x0x38
    public DateTime <OHPBNGBPHLL>k__BackingField;    // 0x0x40
    public DateTime <NEMFAGILLAN>k__BackingField;    // 0x0x48
    public bool <HAMFDFPPOCA>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// GGCHLMKPJLE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GGCHLMKPJLE
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// GGMFNEALJGL
//   RESPONSE GET    api/avatar/   [Service.API]
//   REQUEST  POST   api/avatar/v2/set   [Service.API]
public class GGMFNEALJGL
{
    public string <PNBGCBDOILI>k__BackingField;    // 0x0x10
    public string <BFMHMHLLEGF>k__BackingField;    // 0x0x18
    public string <DCPCMEAPAKJ>k__BackingField;    // 0x0x20
    public string <CMKJKMJIGEL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// GHBIJPLEEKE
//   (not directly referenced by a detected call)
public class GHBIJPLEEKE
{
    public int <IBIMFJPONKB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GHHAKIFOOMF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GHHAKIFOOMF
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// GMFGNJBHEBC
//   (not directly referenced by a detected call)
public class GMFGNJBHEBC
{
    public bool <EMKDCECGMOJ>k__BackingField;    // 0x0x10
    public MJLPNOMEFKG <IPAKFAFGINE>k__BackingField;    // 0x0x18
    public float <BOKGNADKLFO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// HDCDFPNFDDJ
//   (not directly referenced by a detected call)
public class HDCDFPNFDDJ
{
    public long <IAOCDJAKLAC>k__BackingField;    // 0x0x10
    public string <CNJALCEBPMC>k__BackingField;    // 0x0x18
    public string <KHKDPOODHCD>k__BackingField;    // 0x0x20
    public JHDGJFEOGGA? <IAAAFFLAHEJ>k__BackingField;    // 0x0x28
    public string <JOGJIAPDHFB>k__BackingField;    // 0x0x30
    public string <MGPPFEKOLNK>k__BackingField;    // 0x0x38
    public DGOHCPBKOHD <JPDMGHDJCGG>k__BackingField;    // 0x0x40
    public int <PJOGHHIDEII>k__BackingField;    // 0x0x44
    public int <BOEPNILALGE>k__BackingField;    // 0x0x48
    public LCLKAFOPBLD <CDLFNNNBDHP>k__BackingField;    // 0x0x4C
    public MCEEFCNMNAH <PHPNOPPINMK>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// HECIICKPCDN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HECIICKPCDN
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
// HHPEKHPIABO
//   REQUEST  POST   api/playerevents/v2   [Service.API]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.API]
public class HHPEKHPIABO
{
    public long <DOFDAMHCJLP>k__BackingField;    // 0x0x10
    public long? <OMCJBBKKIKO>k__BackingField;    // 0x0x18
    public long? <CHPCFOKEIFM>k__BackingField;    // 0x0x28
    public string <LGACIEKBLBM>k__BackingField;    // 0x0x38
    public string <EHGJCEHECFB>k__BackingField;    // 0x0x40
    public List<string> <KKFLLGKIPND>k__BackingField;    // 0x0x48
    public string <HPJCFFLAJJE>k__BackingField;    // 0x0x50
    public DateTime <NBPEAFMLPDJ>k__BackingField;    // 0x0x58
    public DateTime <EKCLCPFEHDB>k__BackingField;    // 0x0x60
    public CMCAFKLAHCD <OMHKPJKDFLJ>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// HJCAMMLHJAE
//   (not directly referenced by a detected call)
public class HJCAMMLHJAE
{
    public CCMBKDINCAH <IFJDECGAJKN>k__BackingField;    // 0x0x10
    public PBIJAPEOEDO <GMAEHBOPEMP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HJPDBNLCGIB
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class HJPDBNLCGIB
{
    public List<JLFCINPLFID> <KKFLLGKIPND>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// HOGFDJNNMHM
//   RESPONSE GET    api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class HOGFDJNNMHM
{
    public CJFENPHAAHI <CLJIPKBGBDM>k__BackingField;    // 0x0x10
    public int <NGPAJJFMCNI>k__BackingField;    // 0x0x14
    public long <HOBGIEDEPEE>k__BackingField;    // 0x0x18
    public bool <CHCIDPEBEMO>k__BackingField;    // 0x0x20
    public string <LHJAKNBODPE>k__BackingField;    // 0x0x28
    public int? <PGJEKMFLHOB>k__BackingField;    // 0x0x30
    public bool <KIDHEBGGBMA>k__BackingField;    // 0x0x38
    public string <MAIJHBPMIIF>k__BackingField;    // 0x0x40
    public float <MDKKBKFIDFI>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// HOJMGAMMIAD
// base   : ECOKKKFCDID
//   (not directly referenced by a detected call)
public class HOJMGAMMIAD : ECOKKKFCDID
{
    public List<MJLPNOMEFKG> <MDKABBDLGJD>k__BackingField;    // 0x0x40
    public List<int> <OJJPKIFJEIH>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// ISN_GKResolveSavedGamesRequest
//   (not directly referenced by a detected call)
public class ISN_GKResolveSavedGamesRequest
{
    public List<string> m_conflictedGames;    // 0x0x10
    public string m_data;    // 0x0x18
}

// --------------------------------------------------------------------------
// JJONIELLJGH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JJONIELLJGH
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
// JLFCINPLFID
//   (not directly referenced by a detected call)
public class JLFCINPLFID
{
    public string <PAJHIMLGFHH>k__BackingField;    // 0x0x10
    public GGCHLMKPJLE <PALMIOEJANE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JOHPEJAMBHG
//   RESPONSE GET    api/activities/charades/v1/words   [Service.API]
public class JOHPEJAMBHG
{
    public CJPFKEJAOBI <HEHIONOMCIO>k__BackingField;    // 0x0x10
    public string <JJAAIEBKNHF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KLAMKCBENEA
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.API]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.API]
//   RESPONSE POST   api/inventions/v1/report   [Service.API]
//   RESPONSE POST   api/playerevents/v1/report   [Service.API]
//   RESPONSE POST   api/rooms/v2/report   [Service.API]
public class KLAMKCBENEA
{
    public bool <NHCNKEMFEJC>k__BackingField;    // 0x0x10
    public string <LHJAKNBODPE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LEIHOJHGJGH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LEIHOJHGJGH
{
    GoodStanding = 0,
    InReview = 1,
    TempLock = 2,
    Permaban = 3,
}

// --------------------------------------------------------------------------
// LGKFKEIKPPC
//   (not directly referenced by a detected call)
public class LGKFKEIKPPC
{
    public bool <HDJANAMGICN>k__BackingField;    // 0x0x10
    public ENNEGEELGMC <LPCHIFPECPJ>k__BackingField;    // 0x0x14
    public int <CKGCOFOCLBH>k__BackingField;    // 0x0x18
    public DateTime <FCEEMEMAPIA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LLKHFJDNFMM
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class LLKHFJDNFMM
{
    public int <GFBNBCIPNND>k__BackingField;    // 0x0x10
    public DDAADAMFMCL <PALMIOEJANE>k__BackingField;    // 0x0x14
    public CJEPCMDFKNF <CDMCONCIPMO>k__BackingField;    // 0x0x18
    public CJEPCMDFKNF <GJDPDDHJPAC>k__BackingField;    // 0x0x1C
    public CJEPCMDFKNF <MDFECFAELAN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LLNPLLBEJBE
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{mFJCKOBPMGA}   [Service.API]
//   RESPONSE POST   api/playerevents/v2/{eventId}   [Service.API]
public class LLNPLLBEJBE
{
    public CCMBKDINCAH <IFJDECGAJKN>k__BackingField;    // 0x0x10
    public DGOPHENCPOC <PAMGOEFEDLE>k__BackingField;    // 0x0x18
    public NJMAEIPIOAP <OKCOAMCNOKK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LNADMEHDHCH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LNADMEHDHCH
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// MCHBKEIPLBL
//   RESPONSE GET    api/config/   [Service.API]
public class MCHBKEIPLBL
{
    public Dictionary<int, int> <BHCHHEOKKFG>k__BackingField;    // 0x0x10
    public Objective[][] <IANGLKGDAOO>k__BackingField;    // 0x0x18
    public GHBIJPLEEKE <OJNCILBNGOP>k__BackingField;    // 0x0x20
    public ECMOALAFBLJ <MDFJGBMEJDO>k__BackingField;    // 0x0x28
    public string <DGGMJODGLBG>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// MHPOGBHICJL
//   (not directly referenced by a detected call)
public class MHPOGBHICJL
{
    public int <BLCIOCGNJLK>k__BackingField;    // 0x0x10
    public DGOPHENCPOC <PAMGOEFEDLE>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// MIMANKKMKJG
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.API]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.API]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.API]
public class MIMANKKMKJG
{
    public int <JGMDLPIGAPE>k__BackingField;    // 0x0x10
    public bool <HPKFHDNBLOF>k__BackingField;    // 0x0x14
    public DateTime <EABGCJBFDHO>k__BackingField;    // 0x0x18
    public bool <IEOHLPNFBFL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MJLPNOMEFKG
//   (not directly referenced by a detected call)
public class MJLPNOMEFKG
{
    public int <IAOCDJAKLAC>k__BackingField;    // 0x0x10
    public string <FNIGMBMFOJL>k__BackingField;    // 0x0x18
    public string <ILKJJMACHPC>k__BackingField;    // 0x0x20
    public string <CNJALCEBPMC>k__BackingField;    // 0x0x28
    public string <MCGDGOKLALG>k__BackingField;    // 0x0x30
    public JHDGJFEOGGA? <IAAAFFLAHEJ>k__BackingField;    // 0x0x38
    public string <JOGJIAPDHFB>k__BackingField;    // 0x0x40
    public string <MGPPFEKOLNK>k__BackingField;    // 0x0x48
    public bool <HFPLFJDJBIK>k__BackingField;    // 0x0x50
    public bool <DLINBGAHEHB>k__BackingField;    // 0x0x51
    public bool <EFFHIKNPACF>k__BackingField;    // 0x0x52
    public MCEEFCNMNAH <IGOLNCKNKMK>k__BackingField;    // 0x0x54
    public ACDKILABNNC <BMOGJOHDDMD>k__BackingField;    // 0x0x58
    public int <CJBAMGAMHHC>k__BackingField;    // 0x0x5C
    public HDMOIDKEOCM <KFFMMFIJKJM>k__BackingField;    // 0x0x60
    public LCLKAFOPBLD <KLCOFMJCFHG>k__BackingField;    // 0x0x64
    public int <FCLNBAHOGCH>k__BackingField;    // 0x0x68
    public string <IHBDHFMGMPO>k__BackingField;    // 0x0x70
}

// --------------------------------------------------------------------------
// MOMBJBGEBPO
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.API]
public class MOMBJBGEBPO
{
    public int <NGPAJJFMCNI>k__BackingField;    // 0x0x10
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
// NEFHINKECJJ
//   (not directly referenced by a detected call)
public class NEFHINKECJJ
{
    public long <BHBCCAKKIMJ>k__BackingField;    // 0x0x10
    public string <DJCKNJNCOKN>k__BackingField;    // 0x0x18
    public int <JKNDDDBKJLJ>k__BackingField;    // 0x0x20
    public int <JBNBJMOGKML>k__BackingField;    // 0x0x24
    public int <BIGEHHEAHOL>k__BackingField;    // 0x0x28
    public string <CALLODPICGE>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// NIDIHGENDJD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NIDIHGENDJD
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
}

// --------------------------------------------------------------------------
// NJGLJPPHEGP
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class NJGLJPPHEGP
{
    public DGOPHENCPOC <PAMGOEFEDLE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NJKOJLBLFGI
//   (not directly referenced by a detected call)
public class NJKOJLBLFGI
{
    public ACDKILABNNC <BMOGJOHDDMD>k__BackingField;    // 0x0x10
    public int <LGKBIBJHNCN>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// NJMAEIPIOAP
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class NJMAEIPIOAP
{
    public OCLOGFHCPHN <PAMGOEFEDLE>k__BackingField;    // 0x0x10
    public List<string> <KKFLLGKIPND>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NMEKJOABIFC
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.API]
public class NMEKJOABIFC
{
    public int <CLIKMPKBDDB>k__BackingField;    // 0x0x10
    public int <JGMDLPIGAPE>k__BackingField;    // 0x0x14
    public float <ALHHKBNLKFB>k__BackingField;    // 0x0x18
    public float <OCHECFMCAKO>k__BackingField;    // 0x0x1C
    public bool <HPKFHDNBLOF>k__BackingField;    // 0x0x20
    public bool <NAJMBIICFOC>k__BackingField;    // 0x0x21
    public bool <HACGDJKDNPH>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// NMNODINOCNB
//   REQUEST  POST   api/playerevents/v1/respond   [Service.API]
public class NMNODINOCNB
{
    public long <KJHKNKGENCJ>k__BackingField;    // 0x0x10
    public FFEICMIIBMC <PALMIOEJANE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OBBBPCBIMME
//   RESPONSE GET    api/inventions/   [Service.API]
public class OBBBPCBIMME
{
    public long <BHBCCAKKIMJ>k__BackingField;    // 0x0x10
    public string <DJCKNJNCOKN>k__BackingField;    // 0x0x18
    public int <KBFNGJBKEOP>k__BackingField;    // 0x0x20
    public string <LGACIEKBLBM>k__BackingField;    // 0x0x28
    public string <EHGJCEHECFB>k__BackingField;    // 0x0x30
    public string <HPJCFFLAJJE>k__BackingField;    // 0x0x38
    public int <FCDMDLKPAAK>k__BackingField;    // 0x0x40
    public bool <FOHHAMCICIG>k__BackingField;    // 0x0x44
    public DateTime <FCEEMEMAPIA>k__BackingField;    // 0x0x48
    public DateTime <IPLPEOMCNPJ>k__BackingField;    // 0x0x50
    public DateTime? <KDJHAIKBPJC>k__BackingField;    // 0x0x58
    public long? <OPNCOHNMNPM>k__BackingField;    // 0x0x68
    public int <BGFEBEICDCO>k__BackingField;    // 0x0x78
    public int <IIBFLEBGJEK>k__BackingField;    // 0x0x7C
    public int <MJCOMMCDGJH>k__BackingField;    // 0x0x80
    public HECIICKPCDN <BLHHHLKKGCN>k__BackingField;    // 0x0x84
    public HECIICKPCDN <EILALLIKMBE>k__BackingField;    // 0x0x88
    public bool <KLNIPPLHPCP>k__BackingField;    // 0x0x8C
    public bool <FMNHFPPAELJ>k__BackingField;    // 0x0x8D
    public int? <LGKBIBJHNCN>k__BackingField;    // 0x0x90
    public bool <AONKJNPFIGJ>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// OCGBMPFIJBC
// base   : ECOKKKFCDID
//   (not directly referenced by a detected call)
public class OCGBMPFIJBC : ECOKKKFCDID
{
    public int <BPGJELMKLAB>k__BackingField;    // 0x0x40
    public List<GMFGNJBHEBC> <HHANJNHIGAD>k__BackingField;    // 0x0x48
    public List<GMFGNJBHEBC> <ICOBAHGEFMI>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// OCLOGFHCPHN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OCLOGFHCPHN
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
// OEGPIPBKHCN
//   RESPONSE GET    api/inventions/v1/personaldetails/{oEMDIAHHILF}   [Service.API]
public class OEGPIPBKHCN
{
    public bool <NIOEIABHBCH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OGKIDDEAFND
//   RESPONSE GET    api/groups/v1/name/{nameId}   [Service.API]
//   RESPONSE GET    api/groups/v1/{groupId}   [Service.API]
public class OGKIDDEAFND
{
    public long <AIGEOCJHNAD>k__BackingField;    // 0x0x10
    public string <LGACIEKBLBM>k__BackingField;    // 0x0x18
    public string <EHGJCEHECFB>k__BackingField;    // 0x0x20
    public DateTime <IPLPEOMCNPJ>k__BackingField;    // 0x0x28
    public string <HPJCFFLAJJE>k__BackingField;    // 0x0x30
    public LEIHOJHGJGH <AAFOEMDHMNB>k__BackingField;    // 0x0x38
    public int <BKJOPFMHMKE>k__BackingField;    // 0x0x3C
    public int <HOPLPHELONG>k__BackingField;    // 0x0x40
    public List<OHLKLLNHEJA> <FAGEPNIBCJP>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// OHLKCDKEGMN
//   REQUEST  POST   api/settings/v2/set   [Service.API]
public class OHLKCDKEGMN
{
    public string <HKKBNCJMPDP>k__BackingField;    // 0x0x10
    public string <ECBPPNEBCMG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OHLKLLNHEJA
//   RESPONSE GET    api/groups/v1/memberships/{cJFGEMGOJHB}   [Service.API]
public class OHLKLLNHEJA
{
    public long <AIGEOCJHNAD>k__BackingField;    // 0x0x10
    public int <FMMJEJMBDPL>k__BackingField;    // 0x0x18
    public ENLDOIBMOJE <JPPFLNEJHDB>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// OVR.OpenVR.ETrackingResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ETrackingResult
{
    Uninitialized = 1,
    Calibrating_InProgress = 100,
    Calibrating_OutOfRange = 101,
    Running_OK = 200,
    Running_OutOfRange = 201,
}

// --------------------------------------------------------------------------
// OVR.OpenVR.VRMessageOverlayResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum VRMessageOverlayResponse
{
    ButtonPress_0 = 0,
    ButtonPress_1 = 1,
    ButtonPress_2 = 2,
    ButtonPress_3 = 3,
    CouldntFindSystemOverlay = 4,
    CouldntFindOrCreateClientOverlay = 5,
    ApplicationQuit = 6,
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithAssetFileDeleteResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.AssetFileDeleteResult>
//   (not directly referenced by a detected call)
public class MessageWithAssetFileDeleteResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithAssetFileDownloadCancelResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.AssetFileDownloadCancelResult>
//   (not directly referenced by a detected call)
public class MessageWithAssetFileDownloadCancelResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithAssetFileDownloadResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.AssetFileDownloadResult>
//   (not directly referenced by a detected call)
public class MessageWithAssetFileDownloadResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithCloudStorageUpdateResponse
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.CloudStorageUpdateResponse>
//   (not directly referenced by a detected call)
public class MessageWithCloudStorageUpdateResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithLaunchBlockFlowResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.LaunchBlockFlowResult>
//   (not directly referenced by a detected call)
public class MessageWithLaunchBlockFlowResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithLaunchFriendRequestFlowResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.LaunchFriendRequestFlowResult>
//   (not directly referenced by a detected call)
public class MessageWithLaunchFriendRequestFlowResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithLaunchReportFlowResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.LaunchReportFlowResult>
//   (not directly referenced by a detected call)
public class MessageWithLaunchReportFlowResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithLaunchUnblockFlowResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.LaunchUnblockFlowResult>
//   (not directly referenced by a detected call)
public class MessageWithLaunchUnblockFlowResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithLivestreamingStartResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.LivestreamingStartResult>
//   (not directly referenced by a detected call)
public class MessageWithLivestreamingStartResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithMatchmakingBrowseResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.MatchmakingBrowseResult>
//   (not directly referenced by a detected call)
public class MessageWithMatchmakingBrowseResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithMatchmakingEnqueueResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.MatchmakingEnqueueResult>
//   (not directly referenced by a detected call)
public class MessageWithMatchmakingEnqueueResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithNetSyncSetSessionPropertyResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.NetSyncSetSessionPropertyResult>
//   (not directly referenced by a detected call)
public class MessageWithNetSyncSetSessionPropertyResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithPingResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.PingResult>
//   (not directly referenced by a detected call)
public class MessageWithPingResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.MessageWithShareMediaResult
// base   : Oculus.Platform.Message`1<Oculus.Platform.Models.ShareMediaResult>
//   (not directly referenced by a detected call)
public class MessageWithShareMediaResult
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.AssetFileDeleteResult
//   (not directly referenced by a detected call)
public class AssetFileDeleteResult
{
    public ulong AssetFileId;    // 0x0x10
    public ulong AssetId;    // 0x0x18
    public string Filepath;    // 0x0x20
    public bool Success;    // 0x0x28
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.AssetFileDownloadCancelResult
//   (not directly referenced by a detected call)
public class AssetFileDownloadCancelResult
{
    public ulong AssetFileId;    // 0x0x10
    public ulong AssetId;    // 0x0x18
    public string Filepath;    // 0x0x20
    public bool Success;    // 0x0x28
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.AssetFileDownloadResult
//   (not directly referenced by a detected call)
public class AssetFileDownloadResult
{
    public ulong AssetId;    // 0x0x10
    public string Filepath;    // 0x0x18
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.CloudStorageUpdateResponse
//   (not directly referenced by a detected call)
public class CloudStorageUpdateResponse
{
    public string Bucket;    // 0x0x10
    public string Key;    // 0x0x18
    public CloudStorageUpdateStatus Status;    // 0x0x20
    public string VersionHandle;    // 0x0x28
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.LaunchBlockFlowResult
//   (not directly referenced by a detected call)
public class LaunchBlockFlowResult
{
    public bool DidBlock;    // 0x0x10
    public bool DidCancel;    // 0x0x11
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.LaunchFriendRequestFlowResult
//   (not directly referenced by a detected call)
public class LaunchFriendRequestFlowResult
{
    public bool DidCancel;    // 0x0x10
    public bool DidSendRequest;    // 0x0x11
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.LaunchReportFlowResult
//   (not directly referenced by a detected call)
public class LaunchReportFlowResult
{
    public bool DidCancel;    // 0x0x10
    public ulong UserReportId;    // 0x0x18
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.LaunchUnblockFlowResult
//   (not directly referenced by a detected call)
public class LaunchUnblockFlowResult
{
    public bool DidCancel;    // 0x0x10
    public bool DidUnblock;    // 0x0x11
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.LivestreamingStartResult
//   (not directly referenced by a detected call)
public class LivestreamingStartResult
{
    public LivestreamingStartStatus StreamingResult;    // 0x0x10
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.MatchmakingBrowseResult
//   (not directly referenced by a detected call)
public class MatchmakingBrowseResult
{
    public MatchmakingEnqueueResult EnqueueResult;    // 0x0x10
    public RoomList Rooms;    // 0x0x18
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.MatchmakingEnqueueResult
//   (not directly referenced by a detected call)
public class MatchmakingEnqueueResult
{
    public MatchmakingAdminSnapshot AdminSnapshotOptional;    // 0x0x10
    public MatchmakingAdminSnapshot AdminSnapshot;    // 0x0x18
    public uint AverageWait;    // 0x0x20
    public uint MatchesInLastHourCount;    // 0x0x24
    public uint MaxExpectedWait;    // 0x0x28
    public string Pool;    // 0x0x30
    public uint RecentMatchPercentage;    // 0x0x38
    public string RequestHash;    // 0x0x40
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.NetSyncSetSessionPropertyResult
//   (not directly referenced by a detected call)
public class NetSyncSetSessionPropertyResult
{
    public NetSyncSession Session;    // 0x0x10
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.PingResult
//   (not directly referenced by a detected call)
public class PingResult
{
    public ulong <ID>k__BackingField;    // 0x0x10
    public ulong? pingTimeUsec;    // 0x0x18
}

// --------------------------------------------------------------------------
// Oculus.Platform.Models.ShareMediaResult
//   (not directly referenced by a detected call)
public class ShareMediaResult
{
    public ShareMediaStatus Status;    // 0x0x10
}

// --------------------------------------------------------------------------
// Oculus.Platform.PlatformInitializeResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PlatformInitializeResult
{
    NotEntitled = -9,
    InvalidCredentials = -8,
    Unknown = -7,
    VersionMismatch = -6,
    UnableToVerify = -5,
    SignatureInvalid = -4,
    FileInvalid = -3,
    PreLoaded = -2,
    Uninitialized = -1,
    Success = 0,
}

// --------------------------------------------------------------------------
// Oculus.Platform.Request
//   (not directly referenced by a detected call)
public class Request
{
    public Callback callback_;    // 0x0x10
    public ulong <RequestID>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// Oculus.Platform.Request`1
// base   : Oculus.Platform.Request
//   (not directly referenced by a detected call)
public class Request : Request
{
    public Callback<T> callback_;    // 0x0x0
}

// --------------------------------------------------------------------------
// PBIJAPEOEDO
//   (not directly referenced by a detected call)
public class PBIJAPEOEDO
{
    public long <BBHNCIFNCJF>k__BackingField;    // 0x0x10
    public long <KJHKNKGENCJ>k__BackingField;    // 0x0x18
    public int <FMMJEJMBDPL>k__BackingField;    // 0x0x20
    public DateTime <IPLPEOMCNPJ>k__BackingField;    // 0x0x28
    public FFEICMIIBMC <PALMIOEJANE>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// PCFEJLDOIJK
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class PCFEJLDOIJK
{
    public int? <DHDMHMIBHMH>k__BackingField;    // 0x0x10
    public string <JJBCFEOMLBI>k__BackingField;    // 0x0x18
    public string <GLCPMMJOCEJ>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PDOBNLOLBAF
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class PDOBNLOLBAF
{
    public List<MHPOGBHICJL> <OLGDMICNJKJ>k__BackingField;    // 0x0x10
    public DGOPHENCPOC <PAMGOEFEDLE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PHHHPJKCHBM
//   (not directly referenced by a detected call)
public class PHHHPJKCHBM
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// PNHCKEHBPDA
//   REQUEST  POST   api/playerevents/v1/report   [Service.API]
public class PNHCKEHBPDA
{
    public CJFENPHAAHI <CLJIPKBGBDM>k__BackingField;    // 0x0x10
    public long <KJHKNKGENCJ>k__BackingField;    // 0x0x18
    public string <JLPHANILMGL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// POpusCodec.Enums.OpusCtlGetRequest
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OpusCtlGetRequest
{
    Application = 4001,
    Bitrate = 4003,
    MaxBandwidth = 4005,
    VBR = 4007,
    Bandwidth = 4009,
    Complexity = 4011,
    InbandFec = 4013,
    PacketLossPercentage = 4015,
    Dtx = 4017,
    VBRConstraint = 4021,
    ForceChannels = 4023,
    Signal = 4025,
    LookAhead = 4027,
    SampleRate = 4029,
    FinalRange = 4031,
    Pitch = 4033,
    Gain = 4035,
    LsbDepth = 4037,
    LastPacketDurationRequest = 4039,
}

// --------------------------------------------------------------------------
// POpusCodec.Enums.OpusCtlSetRequest
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OpusCtlSetRequest
{
    Application = 4000,
    Bitrate = 4002,
    MaxBandwidth = 4004,
    VBR = 4006,
    Bandwidth = 4008,
    Complexity = 4010,
    InbandFec = 4012,
    PacketLossPercentage = 4014,
    Dtx = 4016,
    VBRConstraint = 4020,
    ForceChannels = 4022,
    Signal = 4024,
    Gain = 4034,
    LsbDepth = 4036,
}

// --------------------------------------------------------------------------
// Photon.Realtime.WebRpcResponse
//   (not directly referenced by a detected call)
public class WebRpcResponse
{
    public string <Name>k__BackingField;    // 0x0x10
    public int <ResultCode>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
    public Dictionary<string, object> <Parameters>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v3/addversion   [Service.API]
public class AddVersionInventionRequestDTO
{
    public long inventionId;    // 0x0x10
    public int instantiationCost;    // 0x0x18
    public int lightsCost;    // 0x0x1C
    public int aiCost;    // 0x0x20
    public long creationRoomId;    // 0x0x28
    public string inventionDataFilename;    // 0x0x30
    public List<long> referencedInventions;    // 0x0x38
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
// RecNet.GetLeaderboardRequestDTO
//   (not directly referenced by a detected call)
public class GetLeaderboardRequestDTO
{
    public MIAJPBPGHOC ObjectiveType;    // 0x0x10
    public bool SortAscending;    // 0x0x14
    public int Limit;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.GetNearbyScoresRequestDTO
// base   : RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetNearbyScoresRequestDTO : GetRankRequestDTO
{
    public int WindowSize;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetRankRequestDTO
{
    public int PlayerId;    // 0x0x10
    public int StatChannel;    // 0x0x14
    public long RoomId;    // 0x0x18
    public GHJPLMCGKIH FilterType;    // 0x0x20
    public JBGJIODAFBA Timeframe;    // 0x0x24
    public bool SortAscending;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.GetRanksRequestDTO
// base   : RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetRanksRequestDTO : GetRankRequestDTO
{
    public int RankStart;    // 0x0x30
    public int RankEnd;    // 0x0x34
}

// --------------------------------------------------------------------------
// RecNet.InventionBatchRequest
//   REQUEST  POST   api/inventions/v1/batch   [Service.API]
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
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v4/save   [Service.API]
public class NewInventionRequestDTO
{
    public string name;    // 0x0x10
    public string description;    // 0x0x18
    public string imageName;    // 0x0x20
    public int instantiationCost;    // 0x0x28
    public int lightsCost;    // 0x0x2C
    public int aiCost;    // 0x0x30
    public long creationRoomId;    // 0x0x38
    public string inventionDataFilename;    // 0x0x40
    public List<long> referencedInventions;    // 0x0x48
    public LMLJHMJEIGM creatorAccountRole;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.NewRoomKeyRequestDTO
//   REQUEST  POST   api/roomkeys/v1/create   [Service.API]
public class NewRoomKeyRequestDTO
{
    public long roomId;    // 0x0x10
    public string name;    // 0x0x18
    public string description;    // 0x0x20
    public int price;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public FDEGHHFBJJO ReportCategory;    // 0x0x20
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
// RecNet.UpdateRoomKeyRequestDTO
//   REQUEST  PUT    api/roomkeys/v1/update   [Service.API]
public class UpdateRoomKeyRequestDTO
{
    public long <roomKeyId>k__BackingField;    // 0x0x10
    public string <name>k__BackingField;    // 0x0x18
    public string <description>k__BackingField;    // 0x0x20
    public int? <price>k__BackingField;    // 0x0x28
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
// SA.Foundation.Tests.SA_TestResult
//   (not directly referenced by a detected call)
public class SA_TestResult
{
    public TestResultStatus <Status>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// SA.iOS.Contacts.ISN_CNContactsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_CNContactsResult : SA_Result
{
    public List<ISN_CNContact> m_contacts;    // 0x0x20
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
    public ISN_NSKeyValueObject m_keyValueObject;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKAchievementsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKAchievementsResult : SA_Result
{
    public List<ISN_GKAchievement> m_achievements;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKIdentityVerificationSignatureResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKIdentityVerificationSignatureResult : SA_Result
{
    public string m_publicKeyUrl;    // 0x0x20
    public string m_signature;    // 0x0x28
    public string m_salt;    // 0x0x30
    public long m_timestamp;    // 0x0x38
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKImageLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKImageLoadResult : SA_Result
{
    public Texture2D m_image;    // 0x0x20
    public string m_imageBase64;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKLeaderboardsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKLeaderboardsResult : SA_Result
{
    public List<ISN_GKLeaderboard> m_leaderboards;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameFetchResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameFetchResult : SA_Result
{
    public List<ISN_GKSavedGame> m_savedGames;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameLoadResult : SA_Result
{
    public string m_data;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKSavedGameSaveResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKSavedGameSaveResult : SA_Result
{
    public ISN_GKSavedGame m_savedGame;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.ISN_GKScoreLoadResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_GKScoreLoadResult : SA_Result
{
    public List<ISN_GKScore> m_scores;    // 0x0x20
    public ISN_GKLeaderboard m_leaderboard;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.GameKit.Internal.ISN_GKScoreRequest
//   (not directly referenced by a detected call)
public class ISN_GKScoreRequest
{
    public List<ISN_GKScore> m_scores;    // 0x0x10
}

// --------------------------------------------------------------------------
// SA.iOS.ReplayKit.ISN_PRPreviewResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_PRPreviewResult : SA_Result
{
    public List<string> m_activityTypes;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.ReplayKit.ISN_RPStopResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_RPStopResult : SA_Result
{
    public bool m_hasPreviewController;    // 0x0x20
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
// SA.iOS.Social.ISN_UIActivityViewControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIActivityViewControllerResult : SA_Result
{
    public string m_activityType;    // 0x0x20
    public List<string> m_returnedItems;    // 0x0x28
    public bool m_completed;    // 0x0x30
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKInitResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_SKInitResult : SA_Result
{
    public List<ISN_SKProduct> m_products;    // 0x0x20
    public List<string> m_invalidProductIdentifiers;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.StoreKit.ISN_SKReceiptRefreshRequest
// base   : SA.iOS.StoreKit.ISN_SKRequest
//   (not directly referenced by a detected call)
public class ISN_SKReceiptRefreshRequest : ISN_SKRequest
{
    public ISN_SKReceiptDictionary m_properties;    // 0x0x10
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
// SA.iOS.UIKit.ISN_UIPickerControllerRequest
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerRequest
{
    public List<string> m_mediaTypes;    // 0x0x10
    public ISN_UIImagePickerControllerSourceType m_sourceType;    // 0x0x18
    public bool m_allowsEditing;    // 0x0x1C
    public float m_imageCompressionRate;    // 0x0x20
    public int m_maxImageSize;    // 0x0x24
    public ISN_UIImageCompressionFormat m_encodingType;    // 0x0x28
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIPickerControllerResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIPickerControllerResult : SA_Result
{
    public string m_encodedImage;    // 0x0x20
    public string m_mediaURL;    // 0x0x28
    public string m_imageURL;    // 0x0x30
    public string m_mediaType;    // 0x0x38
    public Texture2D m_texture;    // 0x0x40
}

// --------------------------------------------------------------------------
// SA.iOS.UIKit.ISN_UIRegisterRemoteNotificationsResult
// base   : SA.Foundation.Templates.SA_Result
//   (not directly referenced by a detected call)
public class ISN_UIRegisterRemoteNotificationsResult : SA_Result
{
    public string m_deviceTokenUTF8;    // 0x0x20
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
    public string m_identifier;    // 0x0x10
    public ISN_UNNotificationContent m_content;    // 0x0x18
    public ISN_UNNotificationTrigger m_trigger;    // 0x0x20
}

// --------------------------------------------------------------------------
// SA.iOS.UserNotifications.ISN_UNNotificationResponse
//   (not directly referenced by a detected call)
public class ISN_UNNotificationResponse
{
    public ISN_UNNotification m_notification;    // 0x0x10
    public string m_actionIdentifier;    // 0x0x18
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
    public PIDFCOGLFHN? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public PIDFCOGLFHN PMMHNLCIKKP;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object RoomId;  // candidate
    public object RoomPlaylistId;  // candidate
    public object Anonymous;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public object oldDeviceId;  // candidate
    public object newDeviceId;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public OAODPJFGPAF GEDCEIDOKJL;  // wrapper
    public int? IMHODAEGGON;  // wrapper
    public object Message;  // candidate
    public object Type;  // candidate
    public object hile;  // candidate
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

// api/PlayerReporting/v3/voteToKick  [API POST]
public class PlayerReportingV3VoteToKickRequest
{
    public object PlayerId;  // candidate
    public object Response;  // candidate
    public object Reason;  // candidate
    public object GameSessionId;  // candidate
}

// api/PlayersBanned/v2/ban  [API POST]
public class PlayersBannedV2BanRequest
{
    public CJFENPHAAHI MEABFEIBEMP;  // wrapper
    public CBEOHBCIPEA AFLPGGJMPOE;  // wrapper
    public object PlayerId;  // candidate
    public object Reason;  // candidate
    public object BanType;  // candidate
    public object DisplayReason;  // candidate
    public object BannedUntil;  // candidate
}

// api/avatar/v2/gifts/consume/  [API POST]
public class AvatarV2GiftsConsumeRequest
{
    public LOCNECLOHCA HBBAANIPIMP;  // wrapper
    public CBEOHBCIPEA AFLPGGJMPOE;  // wrapper
    public object UnlockedLevel;  // candidate
}

// api/avatar/v2/gifts/generate  [API POST]
public class AvatarV2GiftsGenerateRequest
{
    public LCLKAFOPBLD LHOMKMINCHH;  // wrapper
    public LCLKAFOPBLD? PCCLFNLJAMG;  // wrapper
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object AlternateGiftContext;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [API POST]
public class AvatarV3GiftsGenerateRequest
{
    public LCLKAFOPBLD LHOMKMINCHH;  // wrapper
    public LCLKAFOPBLD? PCCLFNLJAMG;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [API POST]
public class ChallengeV2UpdateProgressRequest
{
    public COLBJJAIEIO FMIIMOCIHCD;  // wrapper
    public object ChallengeMapId;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object Complete;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public PLILLKHMNDA EGLGJIONCCP;  // wrapper
    public CJFENPHAAHI MEABFEIBEMP;  // wrapper
    public object clubId;  // candidate
    public object reportCategory;  // candidate
    public object details;  // candidate
}

// api/gamerewards/v1/request  [API POST]
public class GamerewardsV1RequestRequest
{
    public EBCOOENKGIJ BHJGDCHJAKB;  // wrapper
    public LCLKAFOPBLD? JKMJLJKBDIK;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [API POST]
public class GamerewardsV1SelectRequest
{
    public HNJGHCGJJFC FDAEIMEHDJJ;  // wrapper
    public object rewardSelectionId;  // candidate
    public object giftDropId;  // candidate
}

// api/groups/v1/delete/{groupId}  [API POST]
public class GroupsV1DeleteGroupIdRequest
{
    public StatusResponse> AFLPGGJMPOE;  // wrapper
    public object GroupId;  // candidate
}

// api/inventions/v2/search  [API GET]
public class InventionsV2SearchRequest
{
    public string take;  // wrapper
}

// api/messages/v1/IOSClearDeviceToken  [API POST]
public class MessagesV1IOSClearDeviceTokenRequest
{
    public object platformId;  // candidate
}

// api/messages/v1/IOSModifyNotificationPreferences  [API POST]
public class MessagesV1IOSModifyNotificationPreferencesRequest
{
    public DIBODMEJOPN JFMOEGCPNAC;  // wrapper
}

// api/messages/v1/IOSSaveDeviceToken  [API POST]
public class MessagesV1IOSSaveDeviceTokenRequest
{
    public object platformId;  // candidate
    public object deviceToken;  // candidate
    public object appBundleId;  // candidate
}

// api/messages/v1/sendMultiple  [API POST]
public class MessagesV1SendMultipleRequest
{
    public List<long> FNNIKBKHAFN;  // wrapper
    public CBEOHBCIPEA AFLPGGJMPOE;  // wrapper
    public BBELBJELLHN JMDIPDGMIOG;  // wrapper
    public long? HNHLJONGKHB;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public BBELBJELLHN JMDIPDGMIOG;  // wrapper
    public long? HNHLJONGKHB;  // wrapper
    public CBEOHBCIPEA AFLPGGJMPOE;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
}

// api/offlineinvite/v1/send  [API POST]
public class OfflineinviteV1SendRequest
{
    public String> AFLPGGJMPOE;  // wrapper
    public object PlayerId;  // candidate
}

// api/playerevents/v2/delete/{mFJCKOBPMGA}  [API POST]
public class PlayereventsV2DeleteMFJCKOBPMGARequest
{
    public CCMBKDINCAH MFJCKOBPMGA;  // wrapper
}

// api/players/v2/objectives  [API POST]
public class PlayersV2ObjectivesRequest
{
    public List<PIHHFPDKFAG> DBDFCMJFNEC;  // wrapper
    public object objectiveType;  // candidate
    public object additionalXp;  // candidate
    public object inParty;  // candidate
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
    public CJFENPHAAHI MEABFEIBEMP;  // wrapper
    public object RoomId;  // candidate
    public object Details;  // candidate
    public object ReportCategory;  // candidate
}

// api/royale/v2/matchcomplete  [API POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats CNALBEPOKJJ;  // wrapper
}

// api/storefronts/v1/objectives  [API POST]
public class StorefrontsV1ObjectivesRequest
{
    public List<MPMIBGDAIPK> DBDFCMJFNEC;  // wrapper
    public object objectiveType;  // candidate
    public object completionPercentage;  // candidate
    public object roomId;  // candidate
}

// api/testcasemanagement/v1/testcase/{testcaseId}/status  [API POST]
public class TestcasemanagementV1TestcaseTestcaseIdStatusRequest
{
    public NIDIHGENDJD AKPHCJFIPBB;  // wrapper
}

