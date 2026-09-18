// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 204 (plus referenced enums)

// --------------------------------------------------------------------------
// ABIEBPOKHDK
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.Auth]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.Data]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.Data]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.Auth]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.Data]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.Auth]
public class ABIEBPOKHDK
{
    public int <BFOBGIGDNGM>k__BackingField;    // 0x0x10
    public PAABBEDFFFG <EAJPBEBBHHC>k__BackingField;    // 0x0x14
    public PGOGKEOEAKL <HMFLHHGDNOA>k__BackingField;    // 0x0x18
    public PGOGKEOEAKL <OGCIFOLMACN>k__BackingField;    // 0x0x1C
    public PGOGKEOEAKL <MCBMFIEOHDD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// AMAMOGLLCKB
//   REQUEST  POST   api/roomkeys/v1/owns/bulk   [Service.WWW]
public class AMAMOGLLCKB
{
    public int EFPFNCGDCMI;    // 0x0x10
    public long HGKOAMAGELG;    // 0x0x18
}

// --------------------------------------------------------------------------
// AMIADJEPFML
//   (not directly referenced by a detected call)
public class AMIADJEPFML
{
    public long <OOIJDNDAFEH>k__BackingField;    // 0x0x10
    public Guid <CFPGFJPAJOF>k__BackingField;    // 0x0x18
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x28
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x30
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x38
    public int <IPDALCKNGGE>k__BackingField;    // 0x0x40
    public Guid? <DAJMNILLEFN>k__BackingField;    // 0x0x44
    public DateTime <LOIBMIPGGBB>k__BackingField;    // 0x0x58
    public string <LDHBHIGBHFN>k__BackingField;    // 0x0x60
    public DBPBLFNDFEM <EAJPBEBBHHC>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// APNBCLMEONM
//   RESPONSE ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds/v2   [Service.Auth]
public class APNBCLMEONM
{
    public Dictionary<Guid, List<MMCPMGPIPAJ>> <IMBCNOBABKH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// BBJDPDMEHII
// base   : EPALAIHOGLP`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.Auth]
public class BBJDPDMEHII
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// BCNIKPGIJHM
//   (not directly referenced by a detected call)
public class BCNIKPGIJHM
{
    public CMKAPEDFEOP DMOFJBGHFDA;    // 0x0x10
    public int IKIKBFLAHPO;    // 0x0x14
}

// --------------------------------------------------------------------------
// BJPLBPEPJAL
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.Auth]
public class BJPLBPEPJAL
{
    public List<string> <GBKIPPGFEEN>k__BackingField;    // 0x0x10
    public List<string> <AMJBKPNFHLH>k__BackingField;    // 0x0x18
    public List<string> <FHCOMKCCJKP>k__BackingField;    // 0x0x20
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
// CCDAAOEIIIC
//   (not directly referenced by a detected call)
public class CCDAAOEIIIC
{
    public int <MGEPFDPLLMF>k__BackingField;    // 0x0x10
    public EGJJHIMKCOF <EAJPBEBBHHC>k__BackingField;    // 0x0x14
    public List<KCHKOLGGMLA> <KMKIBJMNGLE>k__BackingField;    // 0x0x18
    public List<KCHKOLGGMLA> <DLKAJLABMBB>k__BackingField;    // 0x0x20
    public bool <LHNPDDONMAM>k__BackingField;    // 0x0x28
    public DateTime? <LOFMMPLHKOG>k__BackingField;    // 0x0x30
    public DateTime? <FLOANLMKOND>k__BackingField;    // 0x0x40
    public DateTime? <APLBFPCEOLI>k__BackingField;    // 0x0x50
    public bool <ELHNPGFKOLD>k__BackingField;    // 0x0x60
    public bool <EPALIHJAJBO>k__BackingField;    // 0x0x61
}

// --------------------------------------------------------------------------
// CCNBHLCBJCO
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{eBMJLAAEGCK}/{bCABMFAKDIJ}   [Service.WWW]
public class CCNBHLCBJCO
{
    public OBCDIJLNJEA <EDKCFOIOIGN>k__BackingField;    // 0x0x10
    public LJJPNCIFGEK <OKODOIAGPIM>k__BackingField;    // 0x0x14
    public int <AIIAPNNNHML>k__BackingField;    // 0x0x18
    public int <FFHDCNOGNDO>k__BackingField;    // 0x0x1C
    public int <ECGEOFJIKHF>k__BackingField;    // 0x0x20
    public KGMCKCPDDAH <GBJJHIOCNAA>k__BackingField;    // 0x0x24
    public bool <JJKCBCHLFFJ>k__BackingField;    // 0x0x28
    public float <BMGELNMFFKL>k__BackingField;    // 0x0x2C
    public int <NDGHOMOLJPN>k__BackingField;    // 0x0x30
    public bool <GKCDHONGFEM>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// CDHLODGBDBL
//   (not directly referenced by a detected call)
public class CDHLODGBDBL
{
    public int <CABBFOMOKJK>k__BackingField;    // 0x0x10
    public NFLDALCBEGM <OCMBKAODHDF>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// CEHEBDFBLFJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CEHEBDFBLFJ
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// CHONCFGCBPG
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.WWW]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.WWW]
public class CHONCFGCBPG
{
    public int <JPLNOCIDAMF>k__BackingField;    // 0x0x10
    public int <BACFBFNLMJH>k__BackingField;    // 0x0x14
    public float <GBFEPGFFNDE>k__BackingField;    // 0x0x18
    public float <IHDFKJHLAOA>k__BackingField;    // 0x0x1C
    public bool <FMENMIFMEEL>k__BackingField;    // 0x0x20
    public bool <KFNJGKFFKFK>k__BackingField;    // 0x0x21
    public bool <GCMODLOGJEE>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// CKLJMLBJAHB
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class CKLJMLBJAHB
{
    public long <LMENJHNEOPM>k__BackingField;    // 0x0x10
    public int <BGEAADHLPDH>k__BackingField;    // 0x0x18
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x20
    public long? <DFEOCLCMPKK>k__BackingField;    // 0x0x28
    public long? <HLPODBLIJDM>k__BackingField;    // 0x0x38
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x48
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x50
    public string <LDHBHIGBHFN>k__BackingField;    // 0x0x58
    public DateTime <DAMCCKPBHIP>k__BackingField;    // 0x0x60
    public DateTime <DALDGJLFILG>k__BackingField;    // 0x0x68
    public int <EMEHCAIOEPH>k__BackingField;    // 0x0x70
    public MJAKEEBGDAP <FMDPJKLBJJL>k__BackingField;    // 0x0x74
    public bool <ANLFKJGEEMH>k__BackingField;    // 0x0x78
    public bool <DGELNIAHKOA>k__BackingField;    // 0x0x79
    public JNELIEKGKBC <AFEAHJHEMKM>k__BackingField;    // 0x0x7C
    public JNELIEKGKBC <ICIENFONCME>k__BackingField;    // 0x0x80
    public long? <OGFOAGIIAHD>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// CMDCJLNFHKD
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.Auth]
public class CMDCJLNFHKD
{
    public List<CKLJMLBJAHB> <OHHHFIIDIPP>k__BackingField;    // 0x0x10
    public string <EHKJGDAPLKG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CMKAPEDFEOP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CMKAPEDFEOP
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
// DBNAGHEMBOJ
// base   : FLCJMOOMFGO
//   RESPONSE GET    api/storefronts/   [Service.WWW]
//   RESPONSE GET    api/storefronts/v1/season/{lGFLINELMGE}   [Service.WWW]
public class DBNAGHEMBOJ : FLCJMOOMFGO
{
    public int <EMBPHPDLJBG>k__BackingField;    // 0x0x30
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x38
    public DateTime <OEDPPLJIBJI>k__BackingField;    // 0x0x40
    public DateTime <KNIHEJHDBII>k__BackingField;    // 0x0x48
    public OBCDIJLNJEA <EDKCFOIOIGN>k__BackingField;    // 0x0x50
    public CCDAAOEIIIC <PKOIKHBIBFH>k__BackingField;    // 0x0x58
    public List<POJPDOGKBIK> <KOHBBJGMMBD>k__BackingField;    // 0x0x60
    public EGDLDFIKMIK <KECJDFIDEDC>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// DBOBBJOOJAL
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.Auth]
public class DBOBBJOOJAL
{
    public List<CDHLODGBDBL> <JOFHPNMGAFC>k__BackingField;    // 0x0x10
    public NFLDALCBEGM <OCMBKAODHDF>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DBPBLFNDFEM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DBPBLFNDFEM
{
    Key = 0,
    CircuitEventKey = 1,
}

// --------------------------------------------------------------------------
// DGEIIOONNHG
//   (not directly referenced by a detected call)
public class DGEIIOONNHG
{
    public float <LAJALNHLBNJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DJOPFLNCLMO
//   RESPONSE POST   api/inventions/v1/cheer   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/delete   [Service.Auth]
//   RESPONSE PUT    api/inventions/v1/metadata   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.Auth]
//   RESPONSE GET    api/inventions/v1/update   [Service.Auth]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.Auth]
//   RESPONSE GET    api/inventions/v3/publish   [Service.Matchmaking]
//   RESPONSE POST   api/inventions/v7/addversion   [Service.Notifications]
//   RESPONSE POST   api/inventions/v8/save   [Service.Matchmaking]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.WWW]
public class DJOPFLNCLMO
{
    public OEMPMKBBFPO <IEPBDPGLAME>k__BackingField;    // 0x0x10
    public LINOEOENJOC <FHKNEDJIGCA>k__BackingField;    // 0x0x18
    public IBLFJEIOALE <MDLHJDDLDEN>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DMEEHOGDJOJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DMEEHOGDJOJ
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
// DOHJBDPNGCC
//   REQUEST  POST   api/playerevents/v1/report   [Service.Auth]
public class DOHJBDPNGCC
{
    public CBABLNOEPEH <IBECBLEFECI>k__BackingField;    // 0x0x10
    public long <LMENJHNEOPM>k__BackingField;    // 0x0x18
    public string <NNHIAHICONG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EAJLPCJCGBK
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.Auth]
public class EAJLPCJCGBK
{
    public string <JALDNMEBPHP>k__BackingField;    // 0x0x10
    public string <EGOGBFMCJOA>k__BackingField;    // 0x0x18
    public string <NGCDONONAPP>k__BackingField;    // 0x0x20
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x28
    public string <CODACFMOEPG>k__BackingField;    // 0x0x30
    public OCEDAMGLFCD <IEPBDPGLAME>k__BackingField;    // 0x0x38
    public List<string> <JBHNDBOOCNE>k__BackingField;    // 0x0x40
    public List<string> <FKBDFOOEJIL>k__BackingField;    // 0x0x48
    public string <LCIGEEJAKBH>k__BackingField;    // 0x0x50
    public List<FKLLFODEEND> <KBLOCKGLBAD>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// EDHIFCDPIPD
//   (not directly referenced by a detected call)
public class EDHIFCDPIPD
{
    public CKLJMLBJAHB <HJNFFPFCOHH>k__BackingField;    // 0x0x10
    public HIPGBBMGPFH <LANBGIJDLKO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EDLHIJDBBNF
// base   : GMIJBGBEMDL
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class EDLHIJDBBNF : GMIJBGBEMDL
{
    public EFAGCICLCKK? <CIMFEEFHFNH>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <KDHJFLGDCHK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EFAGCICLCKK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EFAGCICLCKK
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
// EFMJPBOODMG
//   RESPONSE DELETE api/roomconsumables   [Service.WWW]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{kFBFFPPACPN}   [Service.WWW]
public class EFMJPBOODMG
{
    public DMEEHOGDJOJ <IEPBDPGLAME>k__BackingField;    // 0x0x10
    public NBAKMKJFBLK <BJEOJPAEPAI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EGDLDFIKMIK
//   (not directly referenced by a detected call)
public class EGDLDFIKMIK
{
    public bool <HMDPAMMADNG>k__BackingField;    // 0x0x10
    public MJKMEFKDKKB <FJCLAFGOKEH>k__BackingField;    // 0x0x14
    public int <JBJDPCKEBNI>k__BackingField;    // 0x0x18
    public DateTime <BINDMDJDAKA>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EGJJHIMKCOF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EGJJHIMKCOF
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// EOFLOFPDDGD
//   REQUEST  ?      api/customAvatarItems/GetCustomAvatarItemCurrentSavesForCustomAvatarItemIds/v2   [Service.Auth]
public class EOFLOFPDDGD
{
    public List<Guid> <MBEPBDMCPIC>k__BackingField;    // 0x0x10
    public byte <ECIACANIHPJ>k__BackingField;    // 0x0x18
    public int <INGNELEBANB>k__BackingField;    // 0x0x1C
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
// FIPKBBGECKM
//   REQUEST  POST   api/equipment/v1/update   [Service.WWW]
public class FIPKBBGECKM
{
    public string <MIBGPPPCEIH>k__BackingField;    // 0x0x10
    public string <IEAMAAHDGDI>k__BackingField;    // 0x0x18
    public string <GMCGLIGCJJL>k__BackingField;    // 0x0x20
    public string <EMIFLGMFLKC>k__BackingField;    // 0x0x28
    public GACDBBHFICM <NMHKBLCCDKG>k__BackingField;    // 0x0x30
    public bool DAIAPJCCJKM;    // 0x0x34
    public bool <GCMODLOGJEE>k__BackingField;    // 0x0x35
}

// --------------------------------------------------------------------------
// FKIJCAOKGKD
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Matchmaking]
public class FKIJCAOKGKD
{
    public Guid <EINBNOFELEE>k__BackingField;    // 0x0x10
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x20
    public string <LDHBHIGBHFN>k__BackingField;    // 0x0x28
    public DateTime <OEDPPLJIBJI>k__BackingField;    // 0x0x30
    public DateTime? <PAAJCOCMIOJ>k__BackingField;    // 0x0x38
    public List<KFMOCEENFJP> <OCNEHMCGAKG>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// FKLLFODEEND
//   (not directly referenced by a detected call)
public class FKLLFODEEND
{
    public DateTime <LOIBMIPGGBB>k__BackingField;    // 0x0x10
    public string <LPBDJLPIHFP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FNJPAIEKNDP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FNJPAIEKNDP
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
// FOCBBNNOEKA
// base   : EPALAIHOGLP`1<POPLCJGIGAJ>
//   RESPONSE GET    api/customAvatarItems   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.Auth]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{nKBKAHGPKGD}   [Service.Auth]
public class FOCBBNNOEKA
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// GACDBBHFICM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GACDBBHFICM
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// GAOAIBLIFPN
//   RESPONSE POST   api/inventions/v1/settags   [Service.Auth]
public class GAOAIBLIFPN
{
    public KABJNOFILPE <OCMBKAODHDF>k__BackingField;    // 0x0x10
    public List<string> <FKBDFOOEJIL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GCMPPOKHCHP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GCMPPOKHCHP
{
    Equal = 0,
    Custom = 1,
}

// --------------------------------------------------------------------------
// GGDKGOGOBEO
//   (not directly referenced by a detected call)
public class GGDKGOGOBEO
{
    public int <GIBMHBNMAGA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// GHJCNFBOOMB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GHJCNFBOOMB
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// GIOHDADPKMN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GIOHDADPKMN
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// GKIJEOFNJDP
//   (not directly referenced by a detected call)
public class GKIJEOFNJDP
{
    public int <PABNLAEBPBI>k__BackingField;    // 0x0x10
    public IECNMMIGEMK <NNPKBDJLBEJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GMANNBNMDBM
//   (not directly referenced by a detected call)
public class GMANNBNMDBM
{
    public long <IPDALCKNGGE>k__BackingField;    // 0x0x10
    public Guid? <NNLBPEMMKDM>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// HAGLEIJOGDN
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.WWW]
public class HAGLEIJOGDN
{
    public int <PPCPLONJEAO>k__BackingField;    // 0x0x10
    public Guid <NNLBPEMMKDM>k__BackingField;    // 0x0x14
    public long <BNHOOEOEPNB>k__BackingField;    // 0x0x28
    public DateTime <BINDMDJDAKA>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// HCIPKBDNCAN
//   REQUEST  POST   api/playerevents/v2   [Service.Auth]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.Auth]
public class HCIPKBDNCAN
{
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x10
    public long? <DFEOCLCMPKK>k__BackingField;    // 0x0x18
    public long? <HLPODBLIJDM>k__BackingField;    // 0x0x28
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x38
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x40
    public List<string> <FKBDFOOEJIL>k__BackingField;    // 0x0x48
    public string <LDHBHIGBHFN>k__BackingField;    // 0x0x50
    public DateTime <DAMCCKPBHIP>k__BackingField;    // 0x0x58
    public DateTime <DALDGJLFILG>k__BackingField;    // 0x0x60
    public MJAKEEBGDAP <FMDPJKLBJJL>k__BackingField;    // 0x0x68
    public bool <ANLFKJGEEMH>k__BackingField;    // 0x0x6C
    public bool <DGELNIAHKOA>k__BackingField;    // 0x0x6D
    public JNELIEKGKBC <AFEAHJHEMKM>k__BackingField;    // 0x0x70
    public JNELIEKGKBC <ICIENFONCME>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// HIPGBBMGPFH
//   (not directly referenced by a detected call)
public class HIPGBBMGPFH
{
    public long <NAPGLHIIAGG>k__BackingField;    // 0x0x10
    public long <LMENJHNEOPM>k__BackingField;    // 0x0x18
    public int <MEAHEKPBKKI>k__BackingField;    // 0x0x20
    public DateTime <LOIBMIPGGBB>k__BackingField;    // 0x0x28
    public IDFGMODPELA <EAJPBEBBHHC>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// HNMLJIBJMKI
//   (not directly referenced by a detected call)
public class HNMLJIBJMKI
{
    public float <BAGEHMCGAGH>k__BackingField;    // 0x0x10
    public float <EKLCOMDNGHJ>k__BackingField;    // 0x0x14
    public float <JBMLDBPAANI>k__BackingField;    // 0x0x18
    public float <NGGCNFKOCOF>k__BackingField;    // 0x0x1C
    public float <EJBAEJJHLPI>k__BackingField;    // 0x0x20
    public float <DPLGIAKOOML>k__BackingField;    // 0x0x24
    public float <EEKFBEKKECP>k__BackingField;    // 0x0x28
    public float <BIDBEEHJKLG>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// HOLEMHONMKB
//   RESPONSE PUT    api/roomconsumables   [Service.WWW]
public class HOLEMHONMKB
{
    public DMEEHOGDJOJ <IEPBDPGLAME>k__BackingField;    // 0x0x10
    public IKKCAPDPENG <DAOAJOJBNEJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IBLFJEIOALE
//   (not directly referenced by a detected call)
public class IBLFJEIOALE
{
    public long <MEABDCBIPPC>k__BackingField;    // 0x0x10
    public string <CFPGFJPAJOF>k__BackingField;    // 0x0x18
    public int <PICBDAPPPLB>k__BackingField;    // 0x0x20
    public bool <NIEEAJPHGAG>k__BackingField;    // 0x0x24
    public int <FPDKJIGEBIN>k__BackingField;    // 0x0x28
    public int <PKIFPDOLGMJ>k__BackingField;    // 0x0x2C
    public int <IMCKACGGBDM>k__BackingField;    // 0x0x30
    public int <MEDNDEPIPLP>k__BackingField;    // 0x0x34
    public string <GABACMHDPPF>k__BackingField;    // 0x0x38
    public string <GALLHFEFBJL>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// ICMJIALCJAF
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.Auth]
public class ICMJIALCJAF
{
    public int <GBJCBJAAFLK>k__BackingField;    // 0x0x10
    public int? <MICPMCPJJMM>k__BackingField;    // 0x0x14
    public string <CLMEAHLPMKF>k__BackingField;    // 0x0x20
    public string <KGKMBJHJLIK>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// IDFGMODPELA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum IDFGMODPELA
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// IECNMMIGEMK
//   REQUEST  PUT    api/roomconsumables   [Service.WWW]
public class IECNMMIGEMK
{
    public Guid? <ENEEGCFNKLI>k__BackingField;    // 0x0x10
    public Guid <GKILGGJBADO>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// IEGDMHBMHEB
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.WWW]
public class IEGDMHBMHEB
{
    public List<LJIKDBNGDFL> <KOGIBLAAPDG>k__BackingField;    // 0x0x10
    public string <EHKJGDAPLKG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IFNCMMLNLFF
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.WWW]
public class IFNCMMLNLFF
{
    public long <OOIJDNDAFEH>k__BackingField;    // 0x0x10
    public int <PPCPLONJEAO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IJEKHKFNDCA
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.Auth]
public class IJEKHKFNDCA
{
    public CBABLNOEPEH <IBECBLEFECI>k__BackingField;    // 0x0x10
    public int <AACNNIHHEIG>k__BackingField;    // 0x0x14
    public long <DHPOCHFKFPD>k__BackingField;    // 0x0x18
    public bool <GAEJEJDBMIF>k__BackingField;    // 0x0x20
    public string <MJIDOKNEBPE>k__BackingField;    // 0x0x28
    public int? <JHBABGJGOBL>k__BackingField;    // 0x0x30
    public bool <DPPCLGECEGG>k__BackingField;    // 0x0x38
    public bool <KDEFOHAEFAI>k__BackingField;    // 0x0x39
    public bool <DDHADBKGLJL>k__BackingField;    // 0x0x3A
    public bool <NOKPADMPGFG>k__BackingField;    // 0x0x3B
    public string <NKMJHLCCFBJ>k__BackingField;    // 0x0x40
    public DateTime? <OKJIDOPPCHN>k__BackingField;    // 0x0x48
    public string <ODENGAACIDI>k__BackingField;    // 0x0x58
    public float <AGLLJJIFLBC>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// IKKCAPDPENG
//   (not directly referenced by a detected call)
public class IKKCAPDPENG
{
    public Guid <LPIGPDMEFDH>k__BackingField;    // 0x0x10
    public int <PPCPLONJEAO>k__BackingField;    // 0x0x20
    public int <JOOEFMCMDPA>k__BackingField;    // 0x0x24
    public Guid <MBCGNENAEJP>k__BackingField;    // 0x0x28
    public DateTime <BINDMDJDAKA>k__BackingField;    // 0x0x38
    public NBAKMKJFBLK <BJEOJPAEPAI>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// INBHGJOCJIH
//   REQUEST  POST   api/roomcurrencies/v1/awardCurrency/bulk   [Service.WWW]
public class INBHGJOCJIH
{
    public Guid <NNLBPEMMKDM>k__BackingField;    // 0x0x10
    public int <BMOCNPHFBIB>k__BackingField;    // 0x0x20
    public long <NDLBNIPIGKF>k__BackingField;    // 0x0x28
    public Guid <LPDKNAAFBBJ>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// JACJBADBDCL
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
//   RESPONSE DELETE api/keepsakes/{aGIDFPANIND}   [Service.Auth]
//   RESPONSE POST   api/playerwarnings   [Service.Auth]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.Auth]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.WWW]
public class JACJBADBDCL
{
    public bool <GHDJEHHOJOO>k__BackingField;    // 0x0x10
    public string <EMKGOAELDGA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JCAGDPBGPPL
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.WWW]
public class JCAGDPBGPPL
{
    public int <AACNNIHHEIG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JCFJDLKGCBK
//   RESPONSE GET    api/inventions/v1/details   [Service.Auth]
public class JCFJDLKGCBK
{
    public List<LGEEIEOLGDI> <FKBDFOOEJIL>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JEBLENBCCOC
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/   [Service.WWW]
//   RESPONSE DELETE api/roomkeys/v1/delete/{oOLKBDPFICE}   [Service.WWW]
public enum JEBLENBCCOC
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
// JJGAOPMFFME
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.WWW]
public class JJGAOPMFFME
{
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <CEPFHDBMFCP>k__BackingField;    // 0x0x18
    public GCMPPOKHCHP <MBAHBHBLKNM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JNDPECAJCPC
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.WWW]
//   RESPONSE POST   api/checklist/v1/complete   [Service.WWW]
//   RESPONSE POST   api/progressionEvents   [Service.Auth]
//   RESPONSE POST   api/progressionEvents/collect/{pLANLNEPGJO}/{mMKGGNNOOBA}   [Service.Auth]
public class JNDPECAJCPC
{
    public long? <JALDNMEBPHP>k__BackingField;    // 0x0x10
    public int <MEAHEKPBKKI>k__BackingField;    // 0x0x20
    public int? <AMLOPKLFNCF>k__BackingField;    // 0x0x24
    public string <HLECIAOMCHF>k__BackingField;    // 0x0x30
    public GIOHDADPKMN? <HMCHJOOHJBN>k__BackingField;    // 0x0x38
    public string <ONABAGBKAOF>k__BackingField;    // 0x0x40
    public Guid? <CBKHBMHDPHB>k__BackingField;    // 0x0x48
    public string <FBJFLHAJDDF>k__BackingField;    // 0x0x60
    public string <PCHABHNHPCB>k__BackingField;    // 0x0x68
    public OBCDIJLNJEA <EDKCFOIOIGN>k__BackingField;    // 0x0x70
    public int <NINKLIHIAOF>k__BackingField;    // 0x0x74
    public int <FNOHECFPICI>k__BackingField;    // 0x0x78
    public FNJPAIEKNDP <AAHHCPNGBGL>k__BackingField;    // 0x0x7C
    public GACDBBHFICM <LGEJAEKEPII>k__BackingField;    // 0x0x80
    public string <FHPOIDEMANC>k__BackingField;    // 0x0x88
    public LBENLFJCENJ <NDPMDEABIOA>k__BackingField;    // 0x0x90
    public MJKMEFKDKKB <NKHPCAODAAC>k__BackingField;    // 0x0x94
    public NDDGFHCMKDI? <PHPAFEOHCFK>k__BackingField;    // 0x0x98
    public bool <JEKNMFIGOKN>k__BackingField;    // 0x0xA0
    public bool <DCJNKJFEPGH>k__BackingField;    // 0x0xA1
    public string <EMENIJLFONH>k__BackingField;    // 0x0xA8
    public bool <HGNFBKDHBJD>k__BackingField;    // 0x0xB0
    public bool NELNHAOKOMD;    // 0x0xB1
}

// --------------------------------------------------------------------------
// JNELIEKGKBC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JNELIEKGKBC
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// JNOEKGGKCKM
//   RESPONSE GET    api/playerevents/v1/all   [Service.Auth]
//   RESPONSE GET    api/playerevents/v1/all/{iACOINPJAHD}   [Service.Auth]
public class JNOEKGGKCKM
{
    public List<CKLJMLBJAHB> <LGNHPFLJOOI>k__BackingField;    // 0x0x10
    public List<EDHIFCDPIPD> <GCABOMHOHKJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// JPDCDELPABJ
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.Auth]
public class JPDCDELPABJ
{
    public List<long> <NMBOECEOPCL>k__BackingField;    // 0x0x10
    public CDFOLOLGPHC <EAJPBEBBHHC>k__BackingField;    // 0x0x18
    public string <ONNLACEGIHG>k__BackingField;    // 0x0x20
    public long? <IFOCLHDMHEJ>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// KABJNOFILPE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KABJNOFILPE
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
// KAJJELPIJGJ
//   (not directly referenced by a detected call)
public class KAJJELPIJGJ
{
    public int <HOJNGFPNOIM>k__BackingField;    // 0x0x10
    public string <GMCGLIGCJJL>k__BackingField;    // 0x0x18
    public string <EMIFLGMFLKC>k__BackingField;    // 0x0x20
    public string <OLHBFCKLCCG>k__BackingField;    // 0x0x28
    public string <HLECIAOMCHF>k__BackingField;    // 0x0x30
    public string <ONABAGBKAOF>k__BackingField;    // 0x0x38
    public Guid? <CBKHBMHDPHB>k__BackingField;    // 0x0x40
    public GIOHDADPKMN? <HMCHJOOHJBN>k__BackingField;    // 0x0x54
    public string <FBJFLHAJDDF>k__BackingField;    // 0x0x60
    public string <PCHABHNHPCB>k__BackingField;    // 0x0x68
    public bool <NGIBPCEMCFE>k__BackingField;    // 0x0x70
    public bool <MPAKOJBFCCG>k__BackingField;    // 0x0x71
    public bool <BHCPDPEIBPL>k__BackingField;    // 0x0x72
    public GACDBBHFICM <NMHKBLCCDKG>k__BackingField;    // 0x0x74
    public OBCDIJLNJEA <EDKCFOIOIGN>k__BackingField;    // 0x0x78
    public int <NINKLIHIAOF>k__BackingField;    // 0x0x7C
    public NDBFIDLKEKF <OIJIMPJNBOD>k__BackingField;    // 0x0x80
    public FNJPAIEKNDP <MABGMNGEFNF>k__BackingField;    // 0x0x84
    public int? <BLBOAFABMJH>k__BackingField;    // 0x0x88
    public string <BHHIBBFGNBD>k__BackingField;    // 0x0x90
    public int? <IBGFHCAMLME>k__BackingField;    // 0x0x98
    public int? <EEFLBJEAFCD>k__BackingField;    // 0x0xA0
}

// --------------------------------------------------------------------------
// KBFGGDOMMKL
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.WWW]
public class KBFGGDOMMKL
{
    public long <OOIJDNDAFEH>k__BackingField;    // 0x0x10
    public int <PPCPLONJEAO>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KCHKOLGGMLA
//   (not directly referenced by a detected call)
public class KCHKOLGGMLA
{
    public OBCDIJLNJEA <EDKCFOIOIGN>k__BackingField;    // 0x0x10
    public int <IPDALCKNGGE>k__BackingField;    // 0x0x14
    public OABDGOEGFIG <IMBJHHDHEPB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// KFKLEAOGGIF
//   RESPONSE GET    api/config/v2   [Service.Auth]
public class KFKLEAOGGIF
{
    public Dictionary<int, int> <KJEDCDIHEID>k__BackingField;    // 0x0x10
    public List<OGGKHHNLHDF> <DFCIBDBGEJE>k__BackingField;    // 0x0x18
    public BCNIKPGIJHM[][] <PPJDADMALFH>k__BackingField;    // 0x0x20
    public GGDKGOGOBEO <CGDKLAIMALK>k__BackingField;    // 0x0x28
    public HNMLJIBJMKI <BEDNGDPILGN>k__BackingField;    // 0x0x30
    public MNCOKPIEGII <OPLEMGJJBKL>k__BackingField;    // 0x0x38
    public NCANMJKBCGI <DHIDJIIMJNP>k__BackingField;    // 0x0x40
    public DGEIIOONNHG <PKECFMNGECC>k__BackingField;    // 0x0x48
    public string <MHKHDBBOJHD>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// KFMOCEENFJP
//   (not directly referenced by a detected call)
public class KFMOCEENFJP
{
    public Guid <CDOPMKPEIFD>k__BackingField;    // 0x0x10
    public Guid <OFNIAOKLHKM>k__BackingField;    // 0x0x20
    public DateTime <OEDPPLJIBJI>k__BackingField;    // 0x0x30
    public List<KAJJELPIJGJ> <HHDOKGFFBNA>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// KGMCKCPDDAH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KGMCKCPDDAH
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// KJNLGKDNMFC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KJNLGKDNMFC
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
// KNBJKOJMLML
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.WWW]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.WWW]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
//   RESPONSE GET    api/avatar/v4/items   [Service.WWW]
public class KNBJKOJMLML
{
    public GIOHDADPKMN <HMCHJOOHJBN>k__BackingField;    // 0x0x10
    public string <BLNIOJLEJAB>k__BackingField;    // 0x0x18
    public string <GMCGLIGCJJL>k__BackingField;    // 0x0x20
    public string <EMIFLGMFLKC>k__BackingField;    // 0x0x28
    public GACDBBHFICM <NMHKBLCCDKG>k__BackingField;    // 0x0x30
    public string <OLHBFCKLCCG>k__BackingField;    // 0x0x38
    public int <IBGFHCAMLME>k__BackingField;    // 0x0x40
    public bool <ECBHPKJJIOP>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// KNGILHNBDOK
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.WWW]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.WWW]
public class KNGILHNBDOK
{
    public int <BACFBFNLMJH>k__BackingField;    // 0x0x10
    public bool <FMENMIFMEEL>k__BackingField;    // 0x0x14
    public DateTime <MDGEHIJJGKN>k__BackingField;    // 0x0x18
    public bool <IMNOCCCEDCP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LAKNDCOMPAB
//   REQUEST  PUT    api/customAvatarItems   [Service.Auth]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.Auth]
public class LAKNDCOMPAB
{
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x10
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x18
    public int? <IPDALCKNGGE>k__BackingField;    // 0x0x20
    public CEHEBDFBLFJ? <FMDPJKLBJJL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LBENLFJCENJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LBENLFJCENJ
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
// LECMOHDELPB
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.WWW]
public class LECMOHDELPB
{
    public Guid? <LPIGPDMEFDH>k__BackingField;    // 0x0x10
    public long? <IFOCLHDMHEJ>k__BackingField;    // 0x0x28
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x38
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x40
    public string <LDHBHIGBHFN>k__BackingField;    // 0x0x48
    public GMANNBNMDBM <KKOPHEKCNPK>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// LFPFJIKLINH
// base   : CKLJMLBJAHB
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.Auth]
public class LFPFJIKLINH : CKLJMLBJAHB
{
    public List<LGEEIEOLGDI> <FKBDFOOEJIL>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// LGEEIEOLGDI
//   (not directly referenced by a detected call)
public class LGEEIEOLGDI
{
    public string <LHJJNOMIDHN>k__BackingField;    // 0x0x10
    public ODNMICGILJL <EAJPBEBBHHC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LINOEOENJOC
//   (not directly referenced by a detected call)
public class LINOEOENJOC
{
    public ObscuredLong <PJABHEHDPMF>k__BackingField;    // 0x0x10
    public string <CFPGFJPAJOF>k__BackingField;    // 0x0x38
    public ObscuredInt <HDCPGIAEGKI>k__BackingField;    // 0x0x40
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x58
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x60
    public string <GJAHCGHNGPB>k__BackingField;    // 0x0x68
    public string <LDHBHIGBHFN>k__BackingField;    // 0x0x70
    public byte <ILPFDLHMNPM>k__BackingField;    // 0x0x78
    public int <PEGAMOGENDJ>k__BackingField;    // 0x0x7C
    public CEHEBDFBLFJ <FMDPJKLBJJL>k__BackingField;    // 0x0x80
    public bool <FHILCHLCABH>k__BackingField;    // 0x0x84
    public DateTime <BINDMDJDAKA>k__BackingField;    // 0x0x88
    public DateTime <LOIBMIPGGBB>k__BackingField;    // 0x0x90
    public DateTime? <DNFNBNGNGEA>k__BackingField;    // 0x0x98
    public long? <NMLNOAHBHGF>k__BackingField;    // 0x0xA8
    public int <PAGKCAMOMFO>k__BackingField;    // 0x0xB8
    public int <ABAOFIHJALO>k__BackingField;    // 0x0xBC
    public int <GNDGCMKEBAF>k__BackingField;    // 0x0xC0
    public KJNLGKDNMFC <AJHHCKMFLMH>k__BackingField;    // 0x0xC4
    public KJNLGKDNMFC <JFILKGCILKO>k__BackingField;    // 0x0xC8
    public ObscuredBool <NFNPFLMMGNE>k__BackingField;    // 0x0xCC
    public ObscuredBool <KIECFFIOABL>k__BackingField;    // 0x0xD8
    public ObscuredBool <KBPBECPNEFN>k__BackingField;    // 0x0xE4
    public ObscuredBool <MJIEFPBAHFO>k__BackingField;    // 0x0xF0
    public int? <IPDALCKNGGE>k__BackingField;    // 0x0xFC
    public bool <KNHFGKPHLFB>k__BackingField;    // 0x0x104
    public string <BEOFMPNDKOA>k__BackingField;    // 0x0x108
}

// --------------------------------------------------------------------------
// LJIKDBNGDFL
//   (not directly referenced by a detected call)
public class LJIKDBNGDFL
{
    public int <EFCBLMLGPKD>k__BackingField;    // 0x0x10
    public DateTime <LOIBMIPGGBB>k__BackingField;    // 0x0x18
    public DateTime? <KENFOHAKOAG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LJJPNCIFGEK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LJJPNCIFGEK
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
// LKCKLMANHOA
//   REQUEST  POST   api/playerevents/v1/respond   [Service.Auth]
public class LKCKLMANHOA
{
    public long <LMENJHNEOPM>k__BackingField;    // 0x0x10
    public IDFGMODPELA <EAJPBEBBHHC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// LLAAEENMPIB
//   (not directly referenced by a detected call)
public class LLAAEENMPIB
{
    public bool <HCNPFDKPIPG>k__BackingField;    // 0x0x10
    public KAJJELPIJGJ <IGKMKCINDBM>k__BackingField;    // 0x0x18
    public float <BCDFHELMEMD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LLGJPOJBODH
//   RESPONSE GET    api/config/v1/azurespeech   [Service.Auth]
public class LLGJPOJBODH
{
    public bool <PGNACLHEABM>k__BackingField;    // 0x0x10
    public string <EGOGBFMCJOA>k__BackingField;    // 0x0x18
    public string <HJECJDAPGOO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MHGJINPFAPF
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Data]
public class MHGJINPFAPF
{
    public Dictionary<Guid, HOLEMHONMKB> <BDMFIFFBICK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MIKCMKHAGGF
//   REQUEST  POST   api/customAvatarItems   [Service.Auth]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.Auth]
public class MIKCMKHAGGF
{
    public DMEGHAJHBLB <IBECBLEFECI>k__BackingField;    // 0x0x10
    public string <NNHIAHICONG>k__BackingField;    // 0x0x18
    public int? <NFFKOMMNEDK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MJAKEEBGDAP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MJAKEEBGDAP
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// MJKMEFKDKKB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MJKMEFKDKKB
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
// MMCPMGPIPAJ
//   (not directly referenced by a detected call)
public class MMCPMGPIPAJ
{
    public long <KFOKLMHKOBN>k__BackingField;    // 0x0x10
    public Guid <CBKHBMHDPHB>k__BackingField;    // 0x0x18
    public Guid <DPKPIABGFIH>k__BackingField;    // 0x0x28
    public DateTime <LOIBMIPGGBB>k__BackingField;    // 0x0x38
    public string <PNDNOCADNCO>k__BackingField;    // 0x0x40
    public string <DOLNOCNLHLP>k__BackingField;    // 0x0x48
    public int <HGFHNHPFIGH>k__BackingField;    // 0x0x50
    public string <FJOANNMKOIN>k__BackingField;    // 0x0x58
    public string <PBMNDNILGEG>k__BackingField;    // 0x0x60
    public string <CFBCAKJOHHN>k__BackingField;    // 0x0x68
    public string <JMIBJEMMCMF>k__BackingField;    // 0x0x70
    public int <GMBLAAKHMOO>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// MNCOKPIEGII
//   (not directly referenced by a detected call)
public class MNCOKPIEGII
{
    public int <IMGNPOMDILM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MPCGKFJDLIG
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.Auth]
public class MPCGKFJDLIG
{
    public int? <APHDPIBHDON>k__BackingField;    // 0x0x10
    public string <CODACFMOEPG>k__BackingField;    // 0x0x18
    public string <NHMCLLCJDIK>k__BackingField;    // 0x0x20
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
// NBAKMKJFBLK
//   (not directly referenced by a detected call)
public class NBAKMKJFBLK
{
    public Guid <LPIGPDMEFDH>k__BackingField;    // 0x0x10
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x20
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x28
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x30
    public string <LDHBHIGBHFN>k__BackingField;    // 0x0x38
    public long <IPDALCKNGGE>k__BackingField;    // 0x0x40
    public Guid? <DAJMNILLEFN>k__BackingField;    // 0x0x48
    public DateTime <BINDMDJDAKA>k__BackingField;    // 0x0x60
    public int <IHALAFHNMGM>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// NCANMJKBCGI
//   (not directly referenced by a detected call)
public class NCANMJKBCGI
{
    public int <HIHOFDNGGLA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NDBFIDLKEKF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NDBFIDLKEKF
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
// NDDGFHCMKDI
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NDDGFHCMKDI
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
// NFHMOGPAAAI
//   RESPONSE PUT    api/roomkeys/v1/   [Service.WWW]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
public class NFHMOGPAAAI
{
    public JEBLENBCCOC <IEPBDPGLAME>k__BackingField;    // 0x0x10
    public AMIADJEPFML <OJMADHDDEDC>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NFLDALCBEGM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NFLDALCBEGM
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
// NMPNMDOJFLL
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Data]
public class NMPNMDOJFLL
{
    public Dictionary<Guid, GKIJEOFNJDP> <KBKLILEINKA>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// NPNBMOKDFAI
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.WWW]
public class NPNBMOKDFAI
{
    public List<string> <AFDBJMKDADG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OABDGOEGFIG
//   (not directly referenced by a detected call)
public class OABDGOEGFIG
{
    public int <LKEJLMOPEEJ>k__BackingField;    // 0x0x10
    public DateTime? <OBADIFFILJL>k__BackingField;    // 0x0x18
    public DateTime? <HNOECMKODIJ>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// OBCDIJLNJEA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OBCDIJLNJEA
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
// OCEDAMGLFCD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OCEDAMGLFCD
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
}

// --------------------------------------------------------------------------
// ODNMICGILJL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ODNMICGILJL
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// OELMGIDHPHM
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.WWW]
public class OELMGIDHPHM
{
    public List<int> <KBELJJIHLNC>k__BackingField;    // 0x0x10
    public string <EHKJGDAPLKG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OEMPMKBBFPO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OEMPMKBBFPO
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
// OHHBFELOJJC
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.Auth]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.Auth]
public class OHHBFELOJJC
{
    public NFLDALCBEGM <OCMBKAODHDF>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// OODAIFGBIGF
//   RESPONSE GET    api/config/v1/backtrace   [Service.Auth]
public class OODAIFGBIGF
{
    public int <JCIDOBBIFJO>k__BackingField;    // 0x0x10
    public int <FPHDECIGOIF>k__BackingField;    // 0x0x14
    public float <OBKAELIPJLE>k__BackingField;    // 0x0x18
    public int <JBKPFODIJBM>k__BackingField;    // 0x0x1C
    public int <OFMPDOLBLIJ>k__BackingField;    // 0x0x20
    public int <NODMLOAKBII>k__BackingField;    // 0x0x24
    public int <FCJCOKGBFBA>k__BackingField;    // 0x0x28
    public string <HDCACHLANAK>k__BackingField;    // 0x0x30
    public string <OMBBOCFPAFP>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// OPENGPMGINN
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class OPENGPMGINN
{
    public IECNMMIGEMK <NNPKBDJLBEJ>k__BackingField;    // 0x0x10
    public GMANNBNMDBM <OCKIEKOHDJH>k__BackingField;    // 0x0x18
    public int <PABNLAEBPBI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PBDGCFJIBHC
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
public class PBDGCFJIBHC
{
    public bool <GHDJEHHOJOO>k__BackingField;    // 0x0x10
    public string <MJIDOKNEBPE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// PGEINKBOKLA
//   RESPONSE GET    api/testcasemanagement/   [Service.Auth]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{gNBDDFJPEIA}   [Service.Auth]
public class PGEINKBOKLA
{
    public uint <JALDNMEBPHP>k__BackingField;    // 0x0x10
    public uint? <FOICAMMOGHC>k__BackingField;    // 0x0x14
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x20
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x28
    public DateTime <OBIBOLGFDPP>k__BackingField;    // 0x0x30
    public DateTime? <CIGINHCAIMJ>k__BackingField;    // 0x0x38
    public bool <MNIHCCNLMFH>k__BackingField;    // 0x0x48
    public List<EAJLPCJCGBK> <BHCFMKPMHIA>k__BackingField;    // 0x0x50
    public List<string> <FKBDFOOEJIL>k__BackingField;    // 0x0x58
    public int <AIACLEAHLHG>k__BackingField;    // 0x0x60
    public int <MBNNHOMFAJF>k__BackingField;    // 0x0x64
    public int <FGFOCIDGAPB>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// PHMICDAACOD
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2   [Service.Auth]
//   RESPONSE POST   api/playerevents/v2/delete/{pLANLNEPGJO}   [Service.Auth]
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
public class PHMICDAACOD
{
    public LFPFJIKLINH <HJNFFPFCOHH>k__BackingField;    // 0x0x10
    public NFLDALCBEGM <OCMBKAODHDF>k__BackingField;    // 0x0x18
    public GAOAIBLIFPN <DGDAPEPKHDG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PJFBPFNJFPF
// base   : GMIJBGBEMDL
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class PJFBPFNJFPF : GMIJBGBEMDL
{
    public GHJCNFBOOMB? <CIMFEEFHFNH>k__BackingField;    // 0x0x18
    public HAGLEIJOGDN <BIPANIEBLFK>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PJMDCPBJBPJ
//   REQUEST  POST   api/roomcurrencies   [Service.WWW]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.WWW]
public class PJMDCPBJBPJ
{
    public Guid <LPDKNAAFBBJ>k__BackingField;    // 0x0x10
    public long <FJPEACFNDJI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// POJPDOGKBIK
// base   : CCDAAOEIIIC
//   (not directly referenced by a detected call)
public class POJPDOGKBIK : CCDAAOEIIIC
{
    public int <PPNDLPNDELP>k__BackingField;    // 0x0x68
    public List<LLAAEENMPIB> <ICKNAOAJFBE>k__BackingField;    // 0x0x70
    public List<LLAAEENMPIB> <GNLLPJFNBEA>k__BackingField;    // 0x0x78
    public List<LLAAEENMPIB> <MICOHHDEJBO>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x10
    public long? <DFEOCLCMPKK>k__BackingField;    // 0x0x18
    public CLHOCNKNHHO <LMDINCBAPEC>k__BackingField;    // 0x0x28
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
    public GLKHJABAHGA <OCMBKAODHDF>k__BackingField;    // 0x0x10
    public string <LEMBBOAJCGL>k__BackingField;    // 0x0x18
    public string <GPEFPFENIKP>k__BackingField;    // 0x0x20
    public string <HOMNICPIGGJ>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public OBCDIJLNJEA <CurrencyType>k__BackingField;    // 0x0x18
    public NDDGFHCMKDI <BalanceType>k__BackingField;    // 0x0x1C
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
//   REQUEST  POST   api/messages/v3/delete   [Service.Data]
public class DeleteMessagesRequestDTO
{
    public List<long> MessageIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.BroadcastRoomInstanceRequest
//   REQUEST  POST   api/playerevents/v1/broadcast   [Service.Auth]
public class BroadcastRoomInstanceRequest
{
    public long <LMENJHNEOPM>k__BackingField;    // 0x0x10
    public long? <AJEFLKMFKBH>k__BackingField;    // 0x0x18
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
    public HBFGKKCHAHC FilterType;    // 0x0x20
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
    public CLHOCNKNHHO <KOIEKIDBBAF>k__BackingField;    // 0x0x10
    public string <LOHEPGLOJEB>k__BackingField;    // 0x0x18
    public int <CKEFAMLAIAH>k__BackingField;    // 0x0x20
    public int <APHJFKLLFOP>k__BackingField;    // 0x0x24
    public string <BAFMAOKLGEK>k__BackingField;    // 0x0x28
    public string <AIJBJNOJBDL>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <PPCPLONJEAO>k__BackingField;    // 0x0x10
    public Guid <KGMLOGFLNII>k__BackingField;    // 0x0x14
    public DateTime <OEOGAMFLCAD>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.Auth]
public class KeepsakeGlobalConfigDTO
{
    public bool <MKJJEFPMNCJ>k__BackingField;    // 0x0x10
    public int <EDKFKPIDMLF>k__BackingField;    // 0x0x14
    public bool <MBCDIDAHLEE>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <KGMLOGFLNII>k__BackingField;    // 0x0x10
    public CLHOCNKNHHO <IOICBCANIFC>k__BackingField;    // 0x0x20
    public int <GLINIJDPHLA>k__BackingField;    // 0x0x24
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x28
    public long? <DFEOCLCMPKK>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.Auth]
//   RESPONSE GET    api/keepsakes/events/{dNPHFCALLPP}   [Service.Auth]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <NIHFEGHPJME>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <ONAEINGJLCI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <DCPBGGHADGH>k__BackingField;    // 0x0x10
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x18
    public long <LJGAMPDMBGD>k__BackingField;    // 0x0x20
    public AONJGKPBJJF <EAJPBEBBHHC>k__BackingField;    // 0x0x28
    public int <AAHCFMIJDLN>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <IFOCLHDMHEJ>k__BackingField;    // 0x0x10
    public List<Guid> <MCIGIAFNMLB>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <NIHFEGHPJME>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <ONAEINGJLCI>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <LBMIODPJAIF>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <LJGAMPDMBGD>k__BackingField;    // 0x0x10
    public long <JBFJPNLFNHK>k__BackingField;    // 0x0x18
    public int? <JEFCEJMICFG>k__BackingField;    // 0x0x20
    public int? <ICMBGAANDOA>k__BackingField;    // 0x0x28
    public long? <DABLODNKBIE>k__BackingField;    // 0x0x30
    public long <CAGBEPOKEOF>k__BackingField;    // 0x0x40
    public long <NIMJBIHOIEL>k__BackingField;    // 0x0x48
    public int <GKGGGOLKNCF>k__BackingField;    // 0x0x50
    public AONJGKPBJJF <CJKHAPDKIND>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <DILJMCIJMHP>k__BackingField;    // 0x0x58
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
    public FNJPAIEKNDP <GiftContext>k__BackingField;    // 0x0x20
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
    public PPPMMMCJDKO creatorAccountRole;    // 0x0x60
    public long? convertedFromInventionId;    // 0x0x68
    public string displayMetadataJson;    // 0x0x78
    public string longDescription;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public DFFDEHPEOAO <BMLLNMFCCHH>k__BackingField;    // 0x0x10
    public IINHLJEAGHC <MBKEEADBOGC>k__BackingField;    // 0x0x14
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x18
    public string <FEFOCOOHKNC>k__BackingField;    // 0x0x20
    public bool <GKDNKNKOCBE>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<DFFDEHPEOAO> <NOLOHNNKPMJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/event/{pLANLNEPGJO}   [Service.Auth]
public class ProgressionEventDTO
{
    public long <JBFJPNLFNHK>k__BackingField;    // 0x0x10
    public string <OMCEIIBMOEB>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <MICOHHDEJBO>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <FIDNFJBHAEE>k__BackingField;    // 0x0x28
    public DateTime <DAMCCKPBHIP>k__BackingField;    // 0x0x30
    public DateTime <DALDGJLFILG>k__BackingField;    // 0x0x38
    public DateTime <PBGPFMPPBIG>k__BackingField;    // 0x0x40
    public bool <JCCEMGIFBBG>k__BackingField;    // 0x0x48
    public int <EFEACMECBGF>k__BackingField;    // 0x0x4C
    public float <DEMOPIKLFFB>k__BackingField;    // 0x0x50
    public Guid? <JHLPDLLLDAP>k__BackingField;    // 0x0x54
    public string <IGPGBONHBKI>k__BackingField;    // 0x0x68
    public string <JOOCDCDNAFK>k__BackingField;    // 0x0x70
    public string <CKFEBKEJBPD>k__BackingField;    // 0x0x78
    public string <GMPHKPNHKFG>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <NCMEBGKIAEF>k__BackingField;    // 0x0x10
    public int <LCOEDLPPMEB>k__BackingField;    // 0x0x20
    public int <JDCEMHFLIAJ>k__BackingField;    // 0x0x24
    public int <OGDBFNCENAB>k__BackingField;    // 0x0x28
    public long <AKMOHPGOJBG>k__BackingField;    // 0x0x30
    public long <GFPECIMCANN>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE GET    api/progressionEvents   [Service.Auth]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.Auth]
public class ProgressionEventRecordDTO
{
    public int <PPCPLONJEAO>k__BackingField;    // 0x0x10
    public int <FNOHECFPICI>k__BackingField;    // 0x0x14
    public int <IMDMNNMCMCP>k__BackingField;    // 0x0x18
    public int <ADAECAFODFL>k__BackingField;    // 0x0x1C
    public int <PDPALCGJOPN>k__BackingField;    // 0x0x20
    public DateTime? <GNMEDMMAGFB>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <NKFLKOEACKB>k__BackingField;    // 0x0x10
    public int <HOJNGFPNOIM>k__BackingField;    // 0x0x18
    public string <LDHBHIGBHFN>k__BackingField;    // 0x0x20
    public int <FNOHECFPICI>k__BackingField;    // 0x0x28
    public int <EDAPIAAGNND>k__BackingField;    // 0x0x2C
    public bool <BCGOOIHDECO>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.Auth]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public DKGEEPHDAEN ReportCategory;    // 0x0x20
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
// RecNet.UpdateInventionMetadataRequest
//   REQUEST  PUT    api/inventions/v1/metadata   [Service.Auth]
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
    public bool HPNMOMHCJMC;    // 0x0x28
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
    public EBNFBOPALDD? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [Auth POST]
public class PlayerCheerV1CreateRequest
{
    public EBNFBOPALDD KCPOCFKILLE;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [Auth POST]
public class PlayerReportingV1DeviceIdRequest
{
    public LBENLFJCENJ PCCLCKKJNCF;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [Auth POST]
public class PlayerReportingV1HileRequest
{
    public JCOKPJIJFNL EPPKBKJHHHJ;  // wrapper
    public int? EIJCNELHPGD;  // wrapper
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
    public CBABLNOEPEH GDJHDDHDBHN;  // wrapper
    public float? MGJHINFODKA;  // wrapper
    public bool? LEOEBFDOFCG;  // wrapper
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
    public List<CJKCONKAKEF> desc;  // wrapper
}

// api/avatar/v2/gifts/generate  [WWW POST]
public class AvatarV2GiftsGenerateRequest
{
    public FNJPAIEKNDP NMIKEFKOPMC;  // wrapper
    public FNJPAIEKNDP? GAFMEIIFBCE;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [WWW POST]
public class AvatarV3GiftsGenerateRequest
{
    public FNJPAIEKNDP NMIKEFKOPMC;  // wrapper
    public FNJPAIEKNDP? GAFMEIIFBCE;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/chatreport/createChatReport  [? POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage PBDOHNMILPN;  // wrapper
    public LAHAIMPNNFD GDJHDDHDBHN;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [Notifications POST]
public class ClubreportingV1ReportRequest
{
    public CBABLNOEPEH GDJHDDHDBHN;  // wrapper
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
    public CEHEBDFBLFJ POHKOLGMMBG;  // wrapper
    public GNNCJOKJAOL JNFIOOAALIJ;  // wrapper
    public LHKMMDDBGEL LNPEELGIAPN;  // wrapper
    public LHKMMDDBGEL NIAHCIOLEAP;  // wrapper
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
    public LBEAOEMKJHC AKLMPDONANI;  // wrapper
    public FNJPAIEKNDP? ODDHPBKLLCO;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [WWW POST]
public class GamerewardsV1SelectRequest
{
    public JEPOLLOHDBE JIFDMJHIABN;  // wrapper
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
    public LINOEOENJOC inventionId;  // wrapper
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

// api/keepsakes/{aGIDFPANIND}/collect  [Auth POST]
public class KeepsakesAGIDFPANINDCollectRequest
{
    public Guid AGIDFPANIND;  // wrapper
}

// api/messages/v2/send  [Auth POST]
public class MessagesV2SendRequest
{
    public CDFOLOLGPHC IHHJBDJAIEA;  // wrapper
    public long? GICEIKJHPKB;  // wrapper
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
    public IReadOnlyCollection<long> HANEAMEJINO;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [Auth PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public MJAKEEBGDAP POHKOLGMMBG;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [Auth PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? CJNCHPCLNFL;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [Auth PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public JNELIEKGKBC GJMFCPHDCMO;  // wrapper
    public JNELIEKGKBC NGCMDBKNLHH;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [Auth PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? DLHGGKMFGDE;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [Auth PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime BLLGDIEHKHA;  // wrapper
    public DateTime HEIOPKGEFPJ;  // wrapper
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
    public CBABLNOEPEH GDJHDDHDBHN;  // wrapper
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
    public Guid LDLAIAIKILA;  // wrapper
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
    public Guid MPEFFPEOHDL;  // wrapper
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
    public Guid MPEFFPEOHDL;  // wrapper
    public long? IFDBBFFEGNG;  // wrapper
    public byte? HNIPAMKIPII;  // wrapper
    public int? IGDDAGDAAIO;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [WWW POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid LDLAIAIKILA;  // wrapper
    public long? LHACNDPNHMH;  // wrapper
    public long? GOPFHBMOMFI;  // wrapper
    public int? CNOCNELMGPI;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [WWW PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> GLODDHJJLAG;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/create  [WWW POST]
public class RoomkeysV1CreateRequest
{
    public DBPBLFNDFEM EPPKBKJHHHJ;  // wrapper
    public Guid? MBPJMKFCPCN;  // wrapper
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
    public CBABLNOEPEH GDJHDDHDBHN;  // wrapper
    public long? GBCNODMLGHA;  // wrapper
    public Guid? IBMGMLCLALN;  // wrapper
    public int? OKKAAEDLADL;  // wrapper
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
    public Guid NBHLEFPEGAE;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [WWW POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid EOOJKCEGAFG;  // wrapper
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
    public OCEDAMGLFCD ELLGKFJNEIM;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

