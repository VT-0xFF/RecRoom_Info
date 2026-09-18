// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 214 (plus referenced enums)

// --------------------------------------------------------------------------
// ABCFCHNDFPJ
//   RESPONSE POST   api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class ABCFCHNDFPJ
{
    public DOPJHNMIPKL <HIFMFPMFJJF>k__BackingField;    // 0x0x10
    public int <DNOOBMFNNNG>k__BackingField;    // 0x0x14
    public long <HIIFFPFMGAA>k__BackingField;    // 0x0x18
    public bool <HDFDIFBLKEN>k__BackingField;    // 0x0x20
    public string <KLFJNPDEJCL>k__BackingField;    // 0x0x28
    public int? <ENDJKCHBGDK>k__BackingField;    // 0x0x30
    public bool <IJKELDAGCLF>k__BackingField;    // 0x0x38
    public bool <ANJIEMNBIGN>k__BackingField;    // 0x0x39
    public bool <EDKKOELJINI>k__BackingField;    // 0x0x3A
    public bool <IAJEJKPDHKF>k__BackingField;    // 0x0x3B
    public string <HOJPODMLNBK>k__BackingField;    // 0x0x40
    public DateTime? <LNJBNJEOFML>k__BackingField;    // 0x0x48
    public string <IELBIMDOMIF>k__BackingField;    // 0x0x58
    public float <HMAAGFNIFDD>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// ADJKHBJLOIG
//   (not directly referenced by a detected call)
public class ADJKHBJLOIG
{
    public Guid? <CMMONKBCBHF>k__BackingField;    // 0x0x10
    public Guid <LKDOHGOAGCH>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// AEONGDMPHKG
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AEONGDMPHKG
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// BFDAFOMAEPP
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Auth]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class BFDAFOMAEPP
{
    public int <HOBFJLMHLMD>k__BackingField;    // 0x0x10
    public bool <JKLEAEIEICH>k__BackingField;    // 0x0x14
    public DateTime <FHAIPNBKALM>k__BackingField;    // 0x0x18
    public bool <CLKKHOINOKM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// BICFPOGFHIO
//   (not directly referenced by a detected call)
public class BICFPOGFHIO
{
    public long <IHBKDGOLBLF>k__BackingField;    // 0x0x10
    public Guid <KHNIFBGNGHK>k__BackingField;    // 0x0x18
    public Guid <MJMNCMJDCII>k__BackingField;    // 0x0x28
    public DateTime <OBIJMCGBDDJ>k__BackingField;    // 0x0x38
    public string <ECMIPDIHBEJ>k__BackingField;    // 0x0x40
    public string <LBNDMIKJHOL>k__BackingField;    // 0x0x48
    public string <CPLCMKMNFCO>k__BackingField;    // 0x0x50
    public string <BENDNFKBCGB>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// BKEIKMFABLA
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class BKEIKMFABLA
{
    public long <BONPKCOJMPJ>k__BackingField;    // 0x0x10
    public int <CNKDHMEPJAP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// BLOJKJIPHJF
//   (not directly referenced by a detected call)
public class BLOJKJIPHJF
{
    public long <EJBEGHBJEAH>k__BackingField;    // 0x0x10
    public string <EMMAECDJAHB>k__BackingField;    // 0x0x18
    public int <HAAPMAGCOHN>k__BackingField;    // 0x0x20
    public int <BMLKBEBLOHG>k__BackingField;    // 0x0x24
    public int <NPOIEIHNAIB>k__BackingField;    // 0x0x28
    public int <HMKEPHJAAOI>k__BackingField;    // 0x0x2C
    public int <FGBPGNMIIDI>k__BackingField;    // 0x0x30
    public string <LODLCINIPIG>k__BackingField;    // 0x0x38
    public string <KNLBLPNBMNJ>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// BNEFMLLKOOB
//   RESPONSE ?      api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Econ]
public class BNEFMLLKOOB
{
    public OCLOFBDJKAO <FLDIJNOGFLO>k__BackingField;    // 0x0x10
    public MEBDMEOLIOC <JLHJAFAHBKM>k__BackingField;    // 0x0x18
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
// CACMBMEILGI
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.API]
public class CACMBMEILGI
{
    public List<string> <DPAFLLALNJM>k__BackingField;    // 0x0x10
    public byte <IPNNMHBILPK>k__BackingField;    // 0x0x18
    public int <IGMICKLGAAC>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// CCFGNIPFIGG
// base   : MMGAGOFHCGM
//   (not directly referenced by a detected call)
public class CCFGNIPFIGG : MMGAGOFHCGM
{
    public int <INEFONAELKA>k__BackingField;    // 0x0x60
    public List<PBBIEEGCGIC> <OACEGLPEJOJ>k__BackingField;    // 0x0x68
    public List<PBBIEEGCGIC> <DAKBIIBEAGN>k__BackingField;    // 0x0x70
    public List<PBBIEEGCGIC> <EJDFCCANEAO>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// CEEMDKNNJPK
//   (not directly referenced by a detected call)
public class CEEMDKNNJPK
{
    public int <CELFODHOCHH>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// CEIPEHFLPKF
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class CEIPEHFLPKF
{
    public List<int> <IPAJBBMLNJN>k__BackingField;    // 0x0x10
    public string <GABLCABMADK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// CEJIBKMHJHA
//   (not directly referenced by a detected call)
public class CEJIBKMHJHA
{
    public bool <FIKJDMOHPJH>k__BackingField;    // 0x0x10
    public EKMPEFEPOED <CFPNGNLIPGO>k__BackingField;    // 0x0x14
    public int <OOCOBNHEHMP>k__BackingField;    // 0x0x18
    public DateTime <NLGACPGKGGH>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CGAMJKBELDH
// base   : GNNFODODAJC
//   RESPONSE ?      api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.Econ]
public class CGAMJKBELDH : GNNFODODAJC
{
    public NKOEPKLLLJA? <MNKKKMKIPHF>k__BackingField;    // 0x0x18
    public ELOFAIHDAGF <NJDGMIHNFAI>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// CHECIBGLHBH
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{pMCGMADKOIG}/{iKDIJDPAMJO}   [Service.Econ]
public class CHECIBGLHBH
{
    public DCHENIAKGEM <PJBAOGCKCJM>k__BackingField;    // 0x0x10
    public ONOMOLNJKJD <EBBFCJEODJJ>k__BackingField;    // 0x0x14
    public int <DHMMGGOMADC>k__BackingField;    // 0x0x18
    public int <EMPAPAKIHJH>k__BackingField;    // 0x0x1C
    public int <KPBOEHKLCFG>k__BackingField;    // 0x0x20
    public MEAPOKCJCIM <PPDGDIDHLFB>k__BackingField;    // 0x0x24
    public bool <PIEACKMIPPO>k__BackingField;    // 0x0x28
    public float <LEEIBJGIJJB>k__BackingField;    // 0x0x2C
    public int <HGFGLKNIPHI>k__BackingField;    // 0x0x30
    public bool <ENKIMGGNHFF>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// CIAEEKCPLAL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CIAEEKCPLAL
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
// CLCMCENNPDC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CLCMCENNPDC
{
    Equal = 0,
    Custom = 1,
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
// DAEOBNJGMBL
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescs   [Service.API]
//   RESPONSE POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems   [Service.API]
public class DAEOBNJGMBL
{
    public Dictionary<string, BICFPOGFHIO> <HMCGDMCNDBE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DCHENIAKGEM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DCHENIAKGEM
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
// DDDCLNLBBLI
// base   : MMGAGOFHCGM
//   (not directly referenced by a detected call)
public class DDDCLNLBBLI : MMGAGOFHCGM
{
    public HPNNMGEIFJE <LAEJAACIKFO>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// DIEIMFKIDAL
//   (not directly referenced by a detected call)
public class DIEIMFKIDAL
{
    public float <OIGJCJLCGNP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// DIKDEPBLEGB
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class DIKDEPBLEGB
{
    public int <DHAOFMFBPAH>k__BackingField;    // 0x0x10
    public int <JBBENKHJKCE>k__BackingField;    // 0x0x14
    public float <EAGPBCPJOHE>k__BackingField;    // 0x0x18
    public int <EKNIJEALMNA>k__BackingField;    // 0x0x1C
    public int <AIFCPDPKOPF>k__BackingField;    // 0x0x20
    public int <LEDHAIKEPDB>k__BackingField;    // 0x0x24
    public int <GMPFKHDCFCJ>k__BackingField;    // 0x0x28
    public string <OIPEBPDEMGP>k__BackingField;    // 0x0x30
    public string <NIPMGDKGDBP>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// DJIBOCNAKCH
// base   : BLBGPPJEJOK`1<RecNet.KeepsakeCategoryConfigDTO>
//   RESPONSE GET    api/keepsakes/categories   [Service.API]
public class DJIBOCNAKCH
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// DJKJPGEIOHB
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class DJKJPGEIOHB
{
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x10
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x18
    public int? <KGNDEIDDLLK>k__BackingField;    // 0x0x20
    public NNCILFBPIAD? <GMAKGFDFOOO>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// DMOPCFJNMBJ
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
public class DMOPCFJNMBJ
{
    public bool <MMDEPMIFJEF>k__BackingField;    // 0x0x10
    public string <KLFJNPDEJCL>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// DNAJNKBOLEG
//   (not directly referenced by a detected call)
public class DNAJNKBOLEG
{
    public int <KBIMLIALNHD>k__BackingField;    // 0x0x10
    public DateTime <OBIJMCGBDDJ>k__BackingField;    // 0x0x18
    public DateTime? <GDDOPENJDJG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// DNGNNCNKAFJ
//   (not directly referenced by a detected call)
public class DNGNNCNKAFJ
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// DNNGFLAJJKO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DNNGFLAJJKO
{
    General = 0,
    Auto = 1,
    AGOnly = 2,
    Banned = 3,
}

// --------------------------------------------------------------------------
// EHBEJFOIFJG
//   (not directly referenced by a detected call)
public class EHBEJFOIFJG
{
    public Guid <MNNKHDIJLJC>k__BackingField;    // 0x0x10
    public Guid <DALKFDDDPHP>k__BackingField;    // 0x0x20
    public DateTime <JPKEFLLHFOO>k__BackingField;    // 0x0x30
    public List<HPNNMGEIFJE> <JJIMPIAKFLJ>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// EHMNHGGECPK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EHMNHGGECPK
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
// EJGKKHNDLBN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EJGKKHNDLBN
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// EKMPEFEPOED
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EKMPEFEPOED
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
// ELDLBHBPMAF
//   (not directly referenced by a detected call)
public class ELDLBHBPMAF
{
    public string <AAFKODCPELK>k__BackingField;    // 0x0x10
    public DNNGFLAJJKO <MKLPANCHDMD>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// ELLABFKAAAB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ELLABFKAAAB
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// ELOFAIHDAGF
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class ELOFAIHDAGF
{
    public int <CNKDHMEPJAP>k__BackingField;    // 0x0x10
    public Guid <HOBLMEHDILP>k__BackingField;    // 0x0x14
    public long <OAGLNDDHDKA>k__BackingField;    // 0x0x28
    public DateTime <NLGACPGKGGH>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// EMCBOGFFDFF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EMCBOGFFDFF
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
// EMOKLNCDOFK
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class EMOKLNCDOFK
{
    public int <BIEKFNPGJOC>k__BackingField;    // 0x0x10
    public int? <GAIBFDDNNGL>k__BackingField;    // 0x0x14
    public string <DJEBNKICBBN>k__BackingField;    // 0x0x20
    public string <PLPHLBIPFNA>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// ENACDDOAAGO
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class ENACDDOAAGO
{
    public int <PGPAAKOFMEC>k__BackingField;    // 0x0x10
    public CCFMLAFHEDI <MKLPANCHDMD>k__BackingField;    // 0x0x14
    public NKIAGICFKCH <DPAAPCJBBEA>k__BackingField;    // 0x0x18
    public NKIAGICFKCH <JPAFCGEAKJB>k__BackingField;    // 0x0x1C
    public NKIAGICFKCH <KKNPNJCBDMG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EOOCLAKGOMH
//   (not directly referenced by a detected call)
public class EOOCLAKGOMH
{
    public DCHENIAKGEM <PJBAOGCKCJM>k__BackingField;    // 0x0x10
    public int <KGNDEIDDLLK>k__BackingField;    // 0x0x14
    public LKLOIGBNOGG <FFHAIJFGDND>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// EPBLLBDJHBA
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class EPBLLBDJHBA
{
    public bool <PIOIIIKPHDL>k__BackingField;    // 0x0x10
    public string <HIGJKBPDJBF>k__BackingField;    // 0x0x18
    public string <KKLHLCGLKEO>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// EPGDKEACHMH
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum EPGDKEACHMH
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
    Blocked = 4,
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
// FCFKCLBHMJP
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{gGMPKKECCME}   [Service.API]
public class FCFKCLBHMJP
{
    public List<MCOLNNONCKK> <GDOPKLLELOA>k__BackingField;    // 0x0x10
    public List<NBBCGOBGGEF> <EEKOABIKNDJ>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// FDCMFFDIKMM
//   (not directly referenced by a detected call)
public class FDCMFFDIKMM
{
    public float <AIIAMKHEEPK>k__BackingField;    // 0x0x10
    public float <KEELMHPOCGO>k__BackingField;    // 0x0x14
    public float <OCDKEPBEAEN>k__BackingField;    // 0x0x18
    public float <JPPBDNFNCIJ>k__BackingField;    // 0x0x1C
    public float <NDJBLPJCKDJ>k__BackingField;    // 0x0x20
    public float <LAKDFFFJOCA>k__BackingField;    // 0x0x24
    public float <NGHIKFOIFHA>k__BackingField;    // 0x0x28
    public float <BEMBCOECHHA>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// FDMPGGLGAFC
// base   : IPFKAJGOFLK
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.Econ]
public class FDMPGGLGAFC : IPFKAJGOFLK
{
    public List<DDDCLNLBBLI> PLGECONDNEJ;    // 0x0x30
    public int <JFJINKOLNKK>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// FDPPJBDGGLM
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
public class FDPPJBDGGLM
{
    public string <HJEPHKLECIE>k__BackingField;    // 0x0x10
    public string <BBADEFNBBNJ>k__BackingField;    // 0x0x18
    public bool <NGEKFPMCBOH>k__BackingField;    // 0x0x20
    public string <FDFEADOBLAL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// FHEKBPKNMJM
//   REQUEST  POST   api/customAvatarItems/GetCustomAvatarItemCurrentSavesForLegacyAvatarItems   [Service.API]
public class FHEKBPKNMJM
{
    public byte <IPNNMHBILPK>k__BackingField;    // 0x0x10
    public int <IGMICKLGAAC>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// FIEFNCMIBIP
//   RESPONSE ?      api/inventions/   [Service.API]
//   RESPONSE GET    api/inventions/v1/personaldetails/{lFKPIJCMOPL}   [Service.API]
public class FIEFNCMIBIP
{
    public bool <EDHMMOJDPEE>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// FOAIHCLBMBO
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum FOAIHCLBMBO
{
    GiftDrop = 0,
    SeasonTier = 1,
    SeasonEliteUpgrade = 2,
}

// --------------------------------------------------------------------------
// GBAMEEJOCNN
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
public class GBAMEEJOCNN
{
    public EHMNHGGECPK <FLDIJNOGFLO>k__BackingField;    // 0x0x10
    public LJFJJDLGAGJ <PJFHAPNOHMK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GDJGCBDFDFA
//   (not directly referenced by a detected call)
public class GDJGCBDFDFA
{
    public long <AAHFDDHDLLM>k__BackingField;    // 0x0x10
    public string <MJHJNOGNMJB>k__BackingField;    // 0x0x18
    public string <NENHPCCCGFG>k__BackingField;    // 0x0x20
    public NIBFHMGLMBD? <DCMIKCIEHBJ>k__BackingField;    // 0x0x28
    public string <JJHKGGJHHNG>k__BackingField;    // 0x0x30
    public string <IMLIJCEKAKE>k__BackingField;    // 0x0x38
    public JNBAFMIMBNN <ALEBGIIPKPF>k__BackingField;    // 0x0x40
    public int <ILHEJFHGOMA>k__BackingField;    // 0x0x44
    public int <PKHFFKKKKNL>k__BackingField;    // 0x0x48
    public MGLPKGCBFMF? <BJLJIEIIADI>k__BackingField;    // 0x0x4C
    public ELLABFKAAAB? <PPLPLBGOFLA>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// GHJEOPLLBGB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GHJEOPLLBGB
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
// GKLHNFIHOLC
// base   : MCOLNNONCKK
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class GKLHNFIHOLC : MCOLNNONCKK
{
    public List<ELDLBHBPMAF> <DCPGMFDEOBG>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// GLAEMJLMBBE
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
public class GLAEMJLMBBE
{
    public KLEBNLCIDMK <JAADOONNFMG>k__BackingField;    // 0x0x10
    public List<string> <DCPGMFDEOBG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// GNELEDPGLDJ
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GNELEDPGLDJ
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
    NonPurchasedEarnedByP2Pv2 = 1001,
}

// --------------------------------------------------------------------------
// GOONEKHABAC
//   (not directly referenced by a detected call)
public class GOONEKHABAC
{
    public int <AFPIDPCHHIP>k__BackingField;    // 0x0x10
    public OGBCPAACCFP <JAADOONNFMG>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// HDAGHPJKMKJ
//   (not directly referenced by a detected call)
public class HDAGHPJKMKJ
{
    public Guid <IDLBDKPADND>k__BackingField;    // 0x0x10
    public long <BFFDBKLPKOC>k__BackingField;    // 0x0x20
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x28
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x30
    public string <PJFMINHEFDD>k__BackingField;    // 0x0x38
    public long <KGNDEIDDLLK>k__BackingField;    // 0x0x40
    public Guid? <FEHJHFHFNNA>k__BackingField;    // 0x0x48
    public DateTime <NLGACPGKGGH>k__BackingField;    // 0x0x60
    public int <NPBMHHKGLOJ>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// HJHFGJAPOOL
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum HJHFGJAPOOL
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
// HPNNMGEIFJE
//   (not directly referenced by a detected call)
public class HPNNMGEIFJE
{
    public int <AAHFDDHDLLM>k__BackingField;    // 0x0x10
    public string <PAKKEJGBJLH>k__BackingField;    // 0x0x18
    public string <EFDNKAOBLMG>k__BackingField;    // 0x0x20
    public string <OLJCFEHHMCG>k__BackingField;    // 0x0x28
    public string <MJHJNOGNMJB>k__BackingField;    // 0x0x30
    public string <FHFNOAKEDEO>k__BackingField;    // 0x0x38
    public NIBFHMGLMBD? <DCMIKCIEHBJ>k__BackingField;    // 0x0x40
    public string <JJHKGGJHHNG>k__BackingField;    // 0x0x48
    public string <IMLIJCEKAKE>k__BackingField;    // 0x0x50
    public bool <BENLJKDNBFA>k__BackingField;    // 0x0x58
    public bool <ABDOANBBKIB>k__BackingField;    // 0x0x59
    public bool <MNIBBNGCJAK>k__BackingField;    // 0x0x5A
    public ELLABFKAAAB <IEDGNDMEGHJ>k__BackingField;    // 0x0x5C
    public int <CJPIFCMAFGE>k__BackingField;    // 0x0x60
    public DCHENIAKGEM <PJBAOGCKCJM>k__BackingField;    // 0x0x64
    public int <NNDAKBDMABG>k__BackingField;    // 0x0x68
    public MGMLICPNHND <OHOABKJINHK>k__BackingField;    // 0x0x6C
    public MGLPKGCBFMF <BFMHBADBIKJ>k__BackingField;    // 0x0x70
    public int? <ODINDIJCGCO>k__BackingField;    // 0x0x74
    public string <BBPIMPCHMPL>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// ICMKOEACJDA
// base   : BLBGPPJEJOK`1<CGCHKNIICFJ>
//   RESPONSE ?      api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/me   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v2/fromCreator/{cKNOIEHNPKH}   [Service.API]
public class ICMKOEACJDA
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// IIFCMAFNDAH
//   (not directly referenced by a detected call)
public class IIFCMAFNDAH
{
    public long <PJAIGKFNCLN>k__BackingField;    // 0x0x10
    public long <FOEMFBCBICA>k__BackingField;    // 0x0x18
    public int <IGNCEGDCAOL>k__BackingField;    // 0x0x20
    public DateTime <OBIJMCGBDDJ>k__BackingField;    // 0x0x28
    public OOLGEHMGCCE <MKLPANCHDMD>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// IIKPIMABMDA
// base   : IPFKAJGOFLK
//   RESPONSE ?      api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{pBFHNIFMDCK}   [Service.Econ]
public class IIKPIMABMDA : IPFKAJGOFLK
{
    public int <GHLCLLCKFNN>k__BackingField;    // 0x0x30
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x38
    public DateTime <JPKEFLLHFOO>k__BackingField;    // 0x0x40
    public DateTime <FENDFFNJLJD>k__BackingField;    // 0x0x48
    public DCHENIAKGEM <PJBAOGCKCJM>k__BackingField;    // 0x0x50
    public MMGAGOFHCGM <EKHPJMCJLMK>k__BackingField;    // 0x0x58
    public List<CCFGNIPFIGG> <GCJNPMFBCMG>k__BackingField;    // 0x0x60
    public CEJIBKMHJHA <NKNPMIPIFCL>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// INIECBPDCKE
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.Econ]
public class INIECBPDCKE
{
    public int <FKNJMHHDCOO>k__BackingField;    // 0x0x10
    public string <JKIAAKHBAIC>k__BackingField;    // 0x0x18
    public List<PELJGHBNKAL> <DNAMCJLIFCB>k__BackingField;    // 0x0x20
    public GDJGCBDFDFA <IFPIHJGMDKK>k__BackingField;    // 0x0x28
    public string <KNJNALMCADA>k__BackingField;    // 0x0x30
    public DateTime <JPKEFLLHFOO>k__BackingField;    // 0x0x38
    public DateTime <FENDFFNJLJD>k__BackingField;    // 0x0x40
    public DateTime <MKEFCFDONPJ>k__BackingField;    // 0x0x48
    public bool? <OGACIKHIINF>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// IPCDIAAHHPP
//   RESPONSE ?      api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{cHECOEIFABE}   [Service.Econ]
public class IPCDIAAHHPP
{
    public EHMNHGGECPK <FLDIJNOGFLO>k__BackingField;    // 0x0x10
    public HDAGHPJKMKJ <CMDHBGCLPLN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// IPFBKNGIPMN
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class IPFBKNGIPMN
{
    public List<string> <BGDBLLPNODD>k__BackingField;    // 0x0x10
    public List<string> <JMMADHEAIKO>k__BackingField;    // 0x0x18
    public List<string> <KBILPCFHMFG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JENFNPOJJID
//   (not directly referenced by a detected call)
public class JENFNPOJJID
{
    public GHJEOPLLBGB PAJDJPFIDOO;    // 0x0x10
    public int CPJIEIOECOF;    // 0x0x14
}

// --------------------------------------------------------------------------
// JGNGNOIEFPH
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class JGNGNOIEFPH
{
    public string <LDPNFJLLCPG>k__BackingField;    // 0x0x10
    public string <HIGJKBPDJBF>k__BackingField;    // 0x0x18
    public string <PMDFBDFGNHI>k__BackingField;    // 0x0x20
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x28
    public string <OMLOINCJENA>k__BackingField;    // 0x0x30
    public EPGDKEACHMH <FLDIJNOGFLO>k__BackingField;    // 0x0x38
    public List<string> <KCJMCEANGPI>k__BackingField;    // 0x0x40
    public List<string> <DCPGMFDEOBG>k__BackingField;    // 0x0x48
    public string <KEDINELJNIG>k__BackingField;    // 0x0x50
    public List<MCFDBAJAFJP> <OOIOIAJDDJJ>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// JLEIMMMGENP
//   (not directly referenced by a detected call)
public class JLEIMMMGENP
{
    public int <INGMEAGEBIB>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// JLPHJHKEDIE
//   (not directly referenced by a detected call)
public class JLPHJHKEDIE
{
    public ObscuredLong <KJHCPMJIBJL>k__BackingField;    // 0x0x10
    public string <EMMAECDJAHB>k__BackingField;    // 0x0x38
    public ObscuredInt <BBCLEKNKLLL>k__BackingField;    // 0x0x40
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x58
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x60
    public string <PJFMINHEFDD>k__BackingField;    // 0x0x68
    public int <JHHEAGNMJGM>k__BackingField;    // 0x0x70
    public NNCILFBPIAD <GMAKGFDFOOO>k__BackingField;    // 0x0x74
    public DateTime <NLGACPGKGGH>k__BackingField;    // 0x0x78
    public DateTime <OBIJMCGBDDJ>k__BackingField;    // 0x0x80
    public DateTime? <LKHOEGPIBJF>k__BackingField;    // 0x0x88
    public long? <KBAEIOPHGMK>k__BackingField;    // 0x0x98
    public int <BHOEENJJAHP>k__BackingField;    // 0x0xA8
    public int <CEONHKHBNLA>k__BackingField;    // 0x0xAC
    public int <KPGHIFMGFDC>k__BackingField;    // 0x0xB0
    public HJHFGJAPOOL <DNCPJBHFELM>k__BackingField;    // 0x0xB4
    public HJHFGJAPOOL <HIHJCOJBFKB>k__BackingField;    // 0x0xB8
    public ObscuredBool <JHEKACENLPE>k__BackingField;    // 0x0xBC
    public ObscuredBool <AFKDNIMAOCP>k__BackingField;    // 0x0xC8
    public ObscuredBool <FGEEHMDGEND>k__BackingField;    // 0x0xD4
    public int? <KGNDEIDDLLK>k__BackingField;    // 0x0xE0
    public bool <LNJKONGHGFJ>k__BackingField;    // 0x0xE8
}

// --------------------------------------------------------------------------
// JMJEDPHIMMF
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class JMJEDPHIMMF
{
    public int? <HABOGCGGKFG>k__BackingField;    // 0x0x10
    public string <OMLOINCJENA>k__BackingField;    // 0x0x18
    public string <AKMIPGABICP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// JNBAFMIMBNN
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum JNBAFMIMBNN
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
// JNPHEECLKDJ
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class JNPHEECLKDJ
{
    public OGBCPAACCFP <JAADOONNFMG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KEBINDMMFOL
//   REQUEST  ?      api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class KEBINDMMFOL
{
    public OPHPEANAPHM <HIFMFPMFJJF>k__BackingField;    // 0x0x10
    public string <BGHPFOLGHEN>k__BackingField;    // 0x0x18
    public int? <OLJNOIFMFIL>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// KHIBMGAGCCM
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Econ]
public class KHIBMGAGCCM
{
    public Guid <GDFFLGFGPEE>k__BackingField;    // 0x0x10
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x20
    public string <PJFMINHEFDD>k__BackingField;    // 0x0x28
    public DateTime <JPKEFLLHFOO>k__BackingField;    // 0x0x30
    public DateTime? <FJLCOGPGOJL>k__BackingField;    // 0x0x38
    public List<EHBEJFOIFJG> <BKIOGNPFIKL>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// KIDHHLFGHOJ
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class KIDHHLFGHOJ
{
    public int <DNOOBMFNNNG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// KLAFFGEOGCB
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KLAFFGEOGCB
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
// KLEBNLCIDMK
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum KLEBNLCIDMK
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
// KMPELENKBKF
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class KMPELENKBKF
{
    public long <BFFDBKLPKOC>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <FEAMJHPHOIG>k__BackingField;    // 0x0x18
    public CLCMCENNPDC <ENHDCHAEDKD>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LCDINCAIENL
//   RESPONSE POST   api/playerevents/v1/broadcast   [Service.API]
//   RESPONSE POST   api/playerevents/v2   [Service.API]
//   RESPONSE POST   api/playerevents/v2/delete/{eventId}   [Service.API]
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
public class LCDINCAIENL
{
    public GKLHNFIHOLC <AGCICIMGPIK>k__BackingField;    // 0x0x10
    public OGBCPAACCFP <JAADOONNFMG>k__BackingField;    // 0x0x18
    public GLAEMJLMBBE <DHGECBCCPNG>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// LFNNKHKNHED
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Econ]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class LFNNKHKNHED
{
    public int <CEPMHKKJLGC>k__BackingField;    // 0x0x10
    public int <HOBFJLMHLMD>k__BackingField;    // 0x0x14
    public float <IMGHEFLHNBP>k__BackingField;    // 0x0x18
    public float <NBPFMEPCMKF>k__BackingField;    // 0x0x1C
    public bool <JKLEAEIEICH>k__BackingField;    // 0x0x20
    public bool <BAHABGGLEKM>k__BackingField;    // 0x0x21
    public bool <PJIGLIDNOGF>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// LHEIJAOPHGJ
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/checklist/v1/complete   [Service.Econ]
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE POST   api/progressionEvents/collect/{lFBPEGLMOAG}/{iKDJNDPBJNB}   [Service.API]
public class LHEIJAOPHGJ
{
    public long? <LDPNFJLLCPG>k__BackingField;    // 0x0x10
    public int <IGNCEGDCAOL>k__BackingField;    // 0x0x20
    public int? <LDKOHJBNMOI>k__BackingField;    // 0x0x24
    public string <MJHJNOGNMJB>k__BackingField;    // 0x0x30
    public NIBFHMGLMBD? <DCMIKCIEHBJ>k__BackingField;    // 0x0x38
    public string <FHFNOAKEDEO>k__BackingField;    // 0x0x40
    public string <JJHKGGJHHNG>k__BackingField;    // 0x0x48
    public string <IMLIJCEKAKE>k__BackingField;    // 0x0x50
    public DCHENIAKGEM <PJBAOGCKCJM>k__BackingField;    // 0x0x58
    public int <NNDAKBDMABG>k__BackingField;    // 0x0x5C
    public int <ILHEJFHGOMA>k__BackingField;    // 0x0x60
    public MGLPKGCBFMF <BJLJIEIIADI>k__BackingField;    // 0x0x64
    public ELLABFKAAAB <PPLPLBGOFLA>k__BackingField;    // 0x0x68
    public string <NGPJPMDCLJG>k__BackingField;    // 0x0x70
    public CIAEEKCPLAL <LNBEDOBIFHD>k__BackingField;    // 0x0x78
    public EKMPEFEPOED <FDEAMAFKHAK>k__BackingField;    // 0x0x7C
    public GNELEDPGLDJ? <ALOJCFFOKPM>k__BackingField;    // 0x0x80
    public bool <DDJIHNHOFND>k__BackingField;    // 0x0x88
    public bool <NINGEKEHPFJ>k__BackingField;    // 0x0x89
    public string <OGDBHABAHDA>k__BackingField;    // 0x0x90
    public bool <EKBKDOICHLG>k__BackingField;    // 0x0x98
    public bool LIFJAJFNOHN;    // 0x0x99
}

// --------------------------------------------------------------------------
// LJFJJDLGAGJ
//   (not directly referenced by a detected call)
public class LJFJJDLGAGJ
{
    public Guid <IDLBDKPADND>k__BackingField;    // 0x0x10
    public int <CNKDHMEPJAP>k__BackingField;    // 0x0x20
    public int <GKNBOBDLDKH>k__BackingField;    // 0x0x24
    public Guid <KNGGFJAIGKL>k__BackingField;    // 0x0x28
    public DateTime <NLGACPGKGGH>k__BackingField;    // 0x0x38
    public HDAGHPJKMKJ <CMDHBGCLPLN>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// LKLOIGBNOGG
//   (not directly referenced by a detected call)
public class LKLOIGBNOGG
{
    public int <OOCKGIEJPIK>k__BackingField;    // 0x0x10
    public DateTime? <EJECOMOFAFF>k__BackingField;    // 0x0x18
    public DateTime? <CDPDAOGOMMK>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// LKNAOJLBLPJ
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class LKNAOJLBLPJ
{
    public List<ELDLBHBPMAF> <DCPGMFDEOBG>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// LLJCBGBAGMN
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class LLJCBGBAGMN
{
    public Dictionary<Guid, MDEGEFMNPPG> <JLNLCODIMFJ>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MCFDBAJAFJP
//   (not directly referenced by a detected call)
public class MCFDBAJAFJP
{
    public DateTime <OBIJMCGBDDJ>k__BackingField;    // 0x0x10
    public string <OOHPLLEBCCN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MCOLNNONCKK
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class MCOLNNONCKK
{
    public long <FOEMFBCBICA>k__BackingField;    // 0x0x10
    public int <JCIAIHPPJPP>k__BackingField;    // 0x0x18
    public long <BFFDBKLPKOC>k__BackingField;    // 0x0x20
    public long? <AFFKHCCJKMA>k__BackingField;    // 0x0x28
    public long? <JLGLBINKBMF>k__BackingField;    // 0x0x38
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x48
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x50
    public string <PJFMINHEFDD>k__BackingField;    // 0x0x58
    public DateTime <IPHBOHKEDLF>k__BackingField;    // 0x0x60
    public DateTime <PKEDGBJANAN>k__BackingField;    // 0x0x68
    public int <MBOFMGBPNEO>k__BackingField;    // 0x0x70
    public AEONGDMPHKG <GMAKGFDFOOO>k__BackingField;    // 0x0x74
    public bool <KDFPNKNCDCG>k__BackingField;    // 0x0x78
    public bool <ANKBALAHKIL>k__BackingField;    // 0x0x79
    public EJGKKHNDLBN <MLJIBCAPGFL>k__BackingField;    // 0x0x7C
    public EJGKKHNDLBN <OBECFFCPGCO>k__BackingField;    // 0x0x80
    public long? <MHCOMAHJKNP>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// MDEGEFMNPPG
//   (not directly referenced by a detected call)
public class MDEGEFMNPPG
{
    public int <JLOIJOFKDKB>k__BackingField;    // 0x0x10
    public ADJKHBJLOIG <BGEGIFHJBHP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MEAPOKCJCIM
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MEAPOKCJCIM
{
    Interval = 0,
    PerDay = 1,
}

// --------------------------------------------------------------------------
// MEBDMEOLIOC
//   (not directly referenced by a detected call)
public class MEBDMEOLIOC
{
    public long <BONPKCOJMPJ>k__BackingField;    // 0x0x10
    public Guid <EMMAECDJAHB>k__BackingField;    // 0x0x18
    public long <BFFDBKLPKOC>k__BackingField;    // 0x0x28
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x30
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x38
    public int <KGNDEIDDLLK>k__BackingField;    // 0x0x40
    public Guid? <FEHJHFHFNNA>k__BackingField;    // 0x0x44
    public DateTime <OBIJMCGBDDJ>k__BackingField;    // 0x0x58
    public string <PJFMINHEFDD>k__BackingField;    // 0x0x60
    public MPOJNGKOPGC <MKLPANCHDMD>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// MEGNJDILIOP
// base   : GNNFODODAJC
//   RESPONSE ?      api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.Econ]
public class MEGNJDILIOP : GNNFODODAJC
{
    public EMCBOGFFDFF? <MNKKKMKIPHF>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <PJGFJIEBCOB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// MGLPKGCBFMF
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MGLPKGCBFMF
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
// MGMLICPNHND
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MGMLICPNHND
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
// MHBELHJLGLE
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.Econ]
public class MHBELHJLGLE
{
    public List<DNAJNKBOLEG> <KOMLHDPNHPD>k__BackingField;    // 0x0x10
    public string <GABLCABMADK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MLDHMAIADMB
//   (not directly referenced by a detected call)
public class MLDHMAIADMB
{
    public int <NJEENABDHIK>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// MMGAGOFHCGM
//   (not directly referenced by a detected call)
public class MMGAGOFHCGM
{
    public int <ICAJECGIEIN>k__BackingField;    // 0x0x10
    public FOAIHCLBMBO <MKLPANCHDMD>k__BackingField;    // 0x0x14
    public List<EOOCLAKGOMH> <FHBAFFLBONH>k__BackingField;    // 0x0x18
    public List<EOOCLAKGOMH> <PKKKDNBJHLH>k__BackingField;    // 0x0x20
    public bool <BCDMHGACHOI>k__BackingField;    // 0x0x28
    public DateTime? <JLMIPIKAHGL>k__BackingField;    // 0x0x30
    public DateTime? <LMMKEFHPCKP>k__BackingField;    // 0x0x40
    public DateTime? <KKKEPNIKAMC>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// MNCLBGGBEIB
//   (not directly referenced by a detected call)
public class MNCLBGGBEIB
{
    public long <KGNDEIDDLLK>k__BackingField;    // 0x0x10
    public Guid? <HOBLMEHDILP>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// MPOJNGKOPGC
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum MPOJNGKOPGC
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
// NAGAPHMDJML
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
//   RESPONSE DELETE api/keepsakes/{bFDAGJGHJBC}   [Service.API]
//   RESPONSE POST   api/playerwarnings   [Service.API]
//   RESPONSE POST   api/playerwarnings/acknowledge   [Service.API]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
public class NAGAPHMDJML
{
    public bool <MMDEPMIFJEF>k__BackingField;    // 0x0x10
    public string <DLOMOHCBJCI>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NBBCGOBGGEF
//   (not directly referenced by a detected call)
public class NBBCGOBGGEF
{
    public MCOLNNONCKK <AGCICIMGPIK>k__BackingField;    // 0x0x10
    public IIFCMAFNDAH <CBHNACHCGDA>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NDFCDKLJIID
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class NDFCDKLJIID
{
    public List<GOONEKHABAC> <GBGCFKGHOEO>k__BackingField;    // 0x0x10
    public OGBCPAACCFP <JAADOONNFMG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// NIBFHMGLMBD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NIBFHMGLMBD
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// NINMIEKPNOA
//   REQUEST  ?      api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class NINMIEKPNOA
{
    public Guid <AICPPMFDKPM>k__BackingField;    // 0x0x10
    public long <AJGCBGDHLID>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// NKOEPKLLLJA
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NKOEPKLLLJA
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// NMNHOMDBIHH
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class NMNHOMDBIHH
{
    public Guid? <IDLBDKPADND>k__BackingField;    // 0x0x10
    public long? <BFFDBKLPKOC>k__BackingField;    // 0x0x28
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x38
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x40
    public string <PJFMINHEFDD>k__BackingField;    // 0x0x48
    public MNCLBGGBEIB <EIOFCCLEDBH>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// NNCILFBPIAD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum NNCILFBPIAD
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// NONFGAFMCDN
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class NONFGAFMCDN
{
    public List<MCOLNNONCKK> <HLIBDGPPHKG>k__BackingField;    // 0x0x10
    public string <GABLCABMADK>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// OCLOFBDJKAO
// base   : System.Enum
//   RESPONSE ?      api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{cEFNPCHLPME}   [Service.Econ]
public enum OCLOFBDJKAO
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
// OGBCPAACCFP
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OGBCPAACCFP
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
// OJKCMPAHIND
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE POST   api/inventions/v1/updateprice   [Service.API]
//   RESPONSE GET    api/inventions/v3/publish   [Service.API]
//   RESPONSE POST   api/inventions/v4/addversion   [Service.API]
//   RESPONSE POST   api/inventions/v6/save   [Service.API]
//   RESPONSE POST   api/storefronts/v1/trialInvention   [Service.Econ]
public class OJKCMPAHIND
{
    public KLAFFGEOGCB <FLDIJNOGFLO>k__BackingField;    // 0x0x10
    public JLPHJHKEDIE <HNCMGBOKKHE>k__BackingField;    // 0x0x18
    public BLOJKJIPHJF <DMAOAGFLINP>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// ONOMOLNJKJD
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ONOMOLNJKJD
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
// OOLFLFDIKAA
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{ePDCALNHKAP}   [Service.API]
public class OOLFLFDIKAA
{
    public uint <LDPNFJLLCPG>k__BackingField;    // 0x0x10
    public uint? <ILLHOPFGHPC>k__BackingField;    // 0x0x14
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x20
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x28
    public DateTime <LAIHGALKLLP>k__BackingField;    // 0x0x30
    public DateTime? <ALAEBCOMBHD>k__BackingField;    // 0x0x38
    public bool <OFBGODBGGND>k__BackingField;    // 0x0x48
    public List<JGNGNOIEFPH> <DFGGPJFLNDH>k__BackingField;    // 0x0x50
    public List<string> <DCPGMFDEOBG>k__BackingField;    // 0x0x58
    public int <NCLJMNCHBAA>k__BackingField;    // 0x0x60
    public int <OHNANGGLPLE>k__BackingField;    // 0x0x64
    public int <DHBDKHMGJLO>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// OOLGEHMGCCE
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum OOLGEHMGCCE
{
    None = -1,
    Yes = 0,
    Interested = 1,
    No = 2,
    Pending = 3,
}

// --------------------------------------------------------------------------
// PBBIEEGCGIC
//   (not directly referenced by a detected call)
public class PBBIEEGCGIC
{
    public bool <BPNDFCNLPCN>k__BackingField;    // 0x0x10
    public HPNNMGEIFJE <LAEJAACIKFO>k__BackingField;    // 0x0x18
    public float <NJOMBDOFGHM>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// PBEBGOHGAMJ
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class PBEBGOHGAMJ
{
    public Dictionary<Guid, GBAMEEJOCNN> <NONCCPOPDEP>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// PBNAMHMFOIP
//   RESPONSE GET    api/config/v2   [Service.API]
public class PBNAMHMFOIP
{
    public Dictionary<int, int> <JNJNOCDMCKL>k__BackingField;    // 0x0x10
    public List<IGFGKIBOCGI> <PMLIEKNCPJB>k__BackingField;    // 0x0x18
    public JENFNPOJJID[][] <EBDBMDLCKBL>k__BackingField;    // 0x0x20
    public CEEMDKNNJPK <FNIJCFJNCNL>k__BackingField;    // 0x0x28
    public FDCMFFDIKMM <AOEEAEGMCLL>k__BackingField;    // 0x0x30
    public MLDHMAIADMB <FLCEMAMICIJ>k__BackingField;    // 0x0x38
    public JLEIMMMGENP <GCPDOELAOPC>k__BackingField;    // 0x0x40
    public DIEIMFKIDAL <NMGDKGNCDML>k__BackingField;    // 0x0x48
    public string <IEGGODGFJEF>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// PELJGHBNKAL
//   (not directly referenced by a detected call)
public class PELJGHBNKAL
{
    public int <BIKOKDEINJM>k__BackingField;    // 0x0x10
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x18
    public string <OBOEEPELHBD>k__BackingField;    // 0x0x20
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x28
    public string <EFDNKAOBLMG>k__BackingField;    // 0x0x30
    public bool <CAMKAOLGIHH>k__BackingField;    // 0x0x38
    public int <MJBBNGHPICM>k__BackingField;    // 0x0x3C
    public DNGNNCNKAFJ <EFNLPIGAKNG>k__BackingField;    // 0x0x40
    public AACNLBKAPIJ ENHOHPLDGFF;    // 0x0x48
    public AACNLBKAPIJ NFEGODODAJB;    // 0x0x50
    public AACNLBKAPIJ FPCJAGBJOAJ;    // 0x0x58
    public ANFFGCDMCKB NOHKAKJEDPC;    // 0x0x60
}

// --------------------------------------------------------------------------
// PHHCJFBJGIP
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.Econ]
//   RESPONSE GET    api/avatar/v4/items   [Service.Econ]
public class PHHCJFBJGIP
{
    public NIBFHMGLMBD <DCMIKCIEHBJ>k__BackingField;    // 0x0x10
    public string <MDGDAFAMION>k__BackingField;    // 0x0x18
    public string <PAKKEJGBJLH>k__BackingField;    // 0x0x20
    public string <EFDNKAOBLMG>k__BackingField;    // 0x0x28
    public ELLABFKAAAB <IEDGNDMEGHJ>k__BackingField;    // 0x0x30
    public string <OLJCFEHHMCG>k__BackingField;    // 0x0x38
    public int <CJPIFCMAFGE>k__BackingField;    // 0x0x40
    public bool <KMONMPAKJKL>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  POST   api/keepsakes   [Service.API]
public class AddKeepsakeInstanceRequest
{
    public long <BFFDBKLPKOC>k__BackingField;    // 0x0x10
    public long? <AFFKHCCJKMA>k__BackingField;    // 0x0x18
    public PCEKIMKFBFL <AEONGNHLIGF>k__BackingField;    // 0x0x28
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
    public FNFCJJGANIK <JAADOONNFMG>k__BackingField;    // 0x0x10
    public string <NHHPIFGJNPC>k__BackingField;    // 0x0x18
    public string <MMOAOINKBEK>k__BackingField;    // 0x0x20
    public string <KOCGGDMKNKL>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public DCHENIAKGEM <CurrencyType>k__BackingField;    // 0x0x18
    public GNELEDPGLDJ <BalanceType>k__BackingField;    // 0x0x1C
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
    public long <FOEMFBCBICA>k__BackingField;    // 0x0x10
    public long? <NBAMIMHICCM>k__BackingField;    // 0x0x18
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
    public ELDHGIGNEAJ FilterType;    // 0x0x20
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
    public PCEKIMKFBFL <FFOFBMMKBOG>k__BackingField;    // 0x0x10
    public string <PAINKEGMBPE>k__BackingField;    // 0x0x18
    public int <FJEJABOOHFN>k__BackingField;    // 0x0x20
    public int <GMJJPNICGNJ>k__BackingField;    // 0x0x24
    public string <FGFFGFMJDMP>k__BackingField;    // 0x0x28
    public string <IPEINHLKAAB>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <CNKDHMEPJAP>k__BackingField;    // 0x0x10
    public Guid <DAONPFFNMFD>k__BackingField;    // 0x0x14
    public DateTime <IHECALGCKKG>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <BJBDBEDDGAB>k__BackingField;    // 0x0x10
    public int <MCBPDNDKFBG>k__BackingField;    // 0x0x14
    public bool <IJBIDHPJJBN>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <DAONPFFNMFD>k__BackingField;    // 0x0x10
    public PCEKIMKFBFL <NFBCLOAMFFP>k__BackingField;    // 0x0x20
    public int <JCCGNOCAJPJ>k__BackingField;    // 0x0x24
    public long <BFFDBKLPKOC>k__BackingField;    // 0x0x28
    public long? <AFFKHCCJKMA>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE POST   api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{cACJOEELMCK}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <KKGLAAFNDEJ>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <GCAJKEEHDGG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <GPLDBCNJGDG>k__BackingField;    // 0x0x10
    public long <BFFDBKLPKOC>k__BackingField;    // 0x0x18
    public long <JDKIMFMDMCH>k__BackingField;    // 0x0x20
    public OMKDEJNBPJH <MKLPANCHDMD>k__BackingField;    // 0x0x28
    public int <EMAIDLLDHMN>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <BFFDBKLPKOC>k__BackingField;    // 0x0x10
    public List<Guid> <DMNKDJBJHLG>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <KKGLAAFNDEJ>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <GCAJKEEHDGG>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <CKPICKOAHDB>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <JDKIMFMDMCH>k__BackingField;    // 0x0x10
    public long <DAKHJNENAOP>k__BackingField;    // 0x0x18
    public int? <NKDCIONMDHH>k__BackingField;    // 0x0x20
    public int? <PCGHMGBLKOC>k__BackingField;    // 0x0x28
    public long? <JJPPPCCJCPL>k__BackingField;    // 0x0x30
    public long <LPBJMLGEFCN>k__BackingField;    // 0x0x40
    public long <EJLPPDFJPMA>k__BackingField;    // 0x0x48
    public int <PMHKJAGOFAK>k__BackingField;    // 0x0x50
    public OMKDEJNBPJH <FNEEPKODGKP>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <FGLGHGHKAEL>k__BackingField;    // 0x0x58
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
    public MGLPKGCBFMF <GiftContext>k__BackingField;    // 0x0x20
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
    public BJCGPHDFGJF creatorAccountRole;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public BPJGOAJACJB <CLPAJBBHKJG>k__BackingField;    // 0x0x10
    public FJBPBHKGHFA <FJKLGHEOOLG>k__BackingField;    // 0x0x14
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x18
    public string <MLPPABAMJKF>k__BackingField;    // 0x0x20
    public bool <ILCLBNPPKCM>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<BPJGOAJACJB> <FIJPPAEOMGM>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{lFBPEGLMOAG}   [Service.API]
public class ProgressionEventDTO
{
    public long <DAKHJNENAOP>k__BackingField;    // 0x0x10
    public string <GNEOLEJEBFJ>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <EJDFCCANEAO>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <JECELBJNMJG>k__BackingField;    // 0x0x28
    public DateTime <IPHBOHKEDLF>k__BackingField;    // 0x0x30
    public DateTime <PKEDGBJANAN>k__BackingField;    // 0x0x38
    public DateTime <NLIOLAIBHDH>k__BackingField;    // 0x0x40
    public bool <CNCOIHIFCHG>k__BackingField;    // 0x0x48
    public int <LFEGIMAANAH>k__BackingField;    // 0x0x4C
    public float <EANEHHAACGG>k__BackingField;    // 0x0x50
    public Guid? <OAMIMFDGAFI>k__BackingField;    // 0x0x54
    public string <GCEIAIGCLKE>k__BackingField;    // 0x0x68
    public string <IEKBKDMCFBH>k__BackingField;    // 0x0x70
    public string <OHNDADGJBJI>k__BackingField;    // 0x0x78
    public string <KCOKMGBAKOD>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <DKOKKDKFBEF>k__BackingField;    // 0x0x10
    public int <MBCDJJJEFKL>k__BackingField;    // 0x0x20
    public int <FGOAGFDLIHG>k__BackingField;    // 0x0x24
    public int <PNONCINAKJA>k__BackingField;    // 0x0x28
    public long <BPBGIKIAHAJ>k__BackingField;    // 0x0x30
    public long <MLLIBHHKBII>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <CNKDHMEPJAP>k__BackingField;    // 0x0x10
    public int <ILHEJFHGOMA>k__BackingField;    // 0x0x14
    public int <LBKPONIAHHF>k__BackingField;    // 0x0x18
    public int <KJNIGHDGPLH>k__BackingField;    // 0x0x1C
    public int <PELBKFKPJMN>k__BackingField;    // 0x0x20
    public DateTime? <KOBBIOCPDEB>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <ICHPIDPEPLI>k__BackingField;    // 0x0x10
    public int <AAHFDDHDLLM>k__BackingField;    // 0x0x18
    public string <PJFMINHEFDD>k__BackingField;    // 0x0x20
    public int <ILHEJFHGOMA>k__BackingField;    // 0x0x28
    public int <BPONONEJNLA>k__BackingField;    // 0x0x2C
    public bool <ADGIMEECKPC>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public HLFILCNIOBA ReportCategory;    // 0x0x20
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
    public bool PBKPDAEDMHA;    // 0x0x28
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
    public GACMIKAHPDJ? CheerCategory;  // wrapper
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public GACMIKAHPDJ EMNIPODFCLN;  // wrapper
    public object PlayerIdTo;  // candidate
    public object CheerCategory;  // candidate
    public object Anonymous;  // candidate
    public object RoomId;  // candidate
}

// api/PlayerReporting/v1/deviceId  [API POST]
public class PlayerReportingV1DeviceIdRequest
{
    public CIAEEKCPLAL DLKINNFHCHK;  // wrapper
    public object newDeviceId;  // candidate
    public object oldDeviceId;  // candidate
    public object platform;  // candidate
}

// api/PlayerReporting/v1/hile  [API POST]
public class PlayerReportingV1HileRequest
{
    public JCHDCGGPOEF LFLAEPCPMDG;  // wrapper
    public int? BJDELAHOEHK;  // wrapper
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
    public DOPJHNMIPKL OCFEOENNEME;  // wrapper
    public float? CJCGDJGIMCA;  // wrapper
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
    public List<AFKPLGJHCHM> desc;  // wrapper
}

// api/avatar/v2/gifts/consume/  [Econ POST]
public class AvatarV2GiftsConsumeRequest
{
    public LHEIJAOPHGJ UnlockedLevel;  // wrapper
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public MGLPKGCBFMF LAACBMJOJOJ;  // wrapper
    public MGLPKGCBFMF? PNFHLFBGONE;  // wrapper
    public object AlternateGiftContext;  // candidate
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object Message;  // candidate
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public MGLPKGCBFMF LAACBMJOJOJ;  // wrapper
    public MGLPKGCBFMF? PNFHLFBGONE;  // wrapper
    public object GiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [Econ POST]
public class ChallengeV2UpdateProgressRequest
{
    public PELJGHBNKAL ADDLEEAFKPB;  // wrapper
    public object UpdateChallengeProgress;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object ChallengeMapId;  // candidate
    public object Complete;  // candidate
}

// api/chatreport/createChatReport  [API POST]
public class ChatreportCreateChatReportRequest
{
    public ChatMessage KCFFPPIEBHH;  // wrapper
    public NIJIEMJECHJ OCFEOENNEME;  // wrapper
    public object ReportDescription;  // candidate
    public object ReportCategory;  // candidate
    public object ChatThreadId;  // candidate
    public object ChatMessageId;  // candidate
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public DOPJHNMIPKL OCFEOENNEME;  // wrapper
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
    public NNCILFBPIAD AOEHBOGMIMH;  // wrapper
    public NEPDOMGFBLJ EJBGPNALPDP;  // wrapper
    public byte[] HFBBIALBBGN;  // wrapper
    public byte[] HEEBPBILHCI;  // wrapper
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
    public List<PCHAKNEEEKI> CGNOIDCDMBH;  // wrapper
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
    public GGMAABNAOFK PJLCFEKIECO;  // wrapper
    public MGLPKGCBFMF? KHKHOOENDCH;  // wrapper
    public object rewardType;  // candidate
    public object Message;  // candidate
    public object giftContext;  // candidate
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public BNCFLGACMHF OFHNFCMJFEJ;  // wrapper
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
    public JLPHJHKEDIE inventionId;  // wrapper
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

// api/keepsakes/{bFDAGJGHJBC}/collect  [API POST]
public class KeepsakesBFDAGJGHJBCCollectRequest
{
    public Guid BFDAGJGHJBC;  // wrapper
}

// api/messages/v1/sendMultiple  [API POST]
public class MessagesV1SendMultipleRequest
{
    public List<long> LHPFFHBNDIO;  // wrapper
    public GJOPAGIIHLG DGDDOCPFDKL;  // wrapper
    public long? IIAJMJMGGCI;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
    public object RoomId;  // candidate
    public object SendMessageMultiple;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public GJOPAGIIHLG DGDDOCPFDKL;  // wrapper
    public long? IIAJMJMGGCI;  // wrapper
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
    public long? EICIOPEPIOH;  // wrapper
}

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/bulkInvite  [API POST]
public class PlayereventsV1BulkInviteRequest
{
    public List<int> LHPFFHBNDIO;  // wrapper
    public List<int> AMPFPDBKNCK;  // wrapper
}

// api/playerevents/v1/deleteResponse  [API POST]
public class PlayereventsV1DeleteResponseRequest
{
    public OOLGEHMGCCE CANKDHAGEKM;  // wrapper
    public OOLGEHMGCCE KILLBCOOAGG;  // wrapper
}

// api/playerevents/v1/report  [API POST]
public class PlayereventsV1ReportRequest
{
    public DOPJHNMIPKL OCFEOENNEME;  // wrapper
}

// api/playerevents/v1/respond  [API POST]
public class PlayereventsV1RespondRequest
{
    public OOLGEHMGCCE CANKDHAGEKM;  // wrapper
    public OOLGEHMGCCE KILLBCOOAGG;  // wrapper
}

// api/playerevents/v2  [API POST]
public class PlayereventsV2Request
{
    public long? LNBMOIBCHHF;  // wrapper
    public long? ODFFBANLMII;  // wrapper
    public List<string> LNBDKAJPBGK;  // wrapper
    public DateTime GDGJKFLFKCP;  // wrapper
    public DateTime DLAICJOBAGL;  // wrapper
    public AEONGDMPHKG AOEHBOGMIMH;  // wrapper
    public EJGKKHNDLBN EBEJAEADJCG;  // wrapper
    public EJGKKHNDLBN HDEPHDILAHG;  // wrapper
}

// api/playerevents/v2/delete/{eventId}  [API POST]
public class PlayereventsV2DeleteEventIdRequest
{
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
}

// api/playerevents/v2/{eventId}  [API POST]
public class PlayereventsV2EventIdRequest
{
    public long? LNBMOIBCHHF;  // wrapper
    public List<string> LNBDKAJPBGK;  // wrapper
    public DateTime GDGJKFLFKCP;  // wrapper
    public DateTime DLAICJOBAGL;  // wrapper
    public AEONGDMPHKG AOEHBOGMIMH;  // wrapper
    public long? ODFFBANLMII;  // wrapper
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public AEONGDMPHKG AOEHBOGMIMH;  // wrapper
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
    public AEONGDMPHKG DJNMAFBKHKI;  // wrapper
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public long? ODFFBANLMII;  // wrapper
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
    public long? JIFFOGNFBGP;  // wrapper
}

// api/playerevents/v2/{eventId}/description  [API PUT]
public class PlayereventsV2EventIdDescriptionRequest
{
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
}

// api/playerevents/v2/{eventId}/image  [API PUT]
public class PlayereventsV2EventIdImageRequest
{
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public EJGKKHNDLBN EBEJAEADJCG;  // wrapper
    public EJGKKHNDLBN IMBCDOGIJJL;  // wrapper
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
}

// api/playerevents/v2/{eventId}/name  [API PUT]
public class PlayereventsV2EventIdNameRequest
{
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public long? LNBMOIBCHHF;  // wrapper
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
    public long? DPMDMECIOGA;  // wrapper
}

// api/playerevents/v2/{eventId}/tags  [API PUT]
public class PlayereventsV2EventIdTagsRequest
{
    public List<string> LNBDKAJPBGK;  // wrapper
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
    public List<string> KDHKJGJBOEL;  // wrapper
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime GDGJKFLFKCP;  // wrapper
    public DateTime DLAICJOBAGL;  // wrapper
    public MCOLNNONCKK FMPAKINGKJG;  // wrapper
    public DateTime ELNPFIKBDEB;  // wrapper
    public DateTime LHAFGJDHHFF;  // wrapper
}

// api/playerwarnings  [API POST]
public class PlayerwarningsRequest
{
    public DOPJHNMIPKL OCFEOENNEME;  // wrapper
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
    public Guid OCOAGIGKOAK;  // wrapper
    public object PurchaseOfferId;  // candidate
    public object RequestedPrice;  // candidate
    public object RequestedAmount;  // candidate
}

// api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency  [Econ PUT]
public class RoomconsumablesV1RoomconsumableRoomconsumableIdPurchaseCurrencyRequest
{
    public Guid CHECOEIFABE;  // wrapper
    public Guid DMCCJLHIFBP;  // wrapper
    public Guid? FKAPCLHHDLF;  // wrapper
}

// api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens  [Econ PUT]
public class RoomconsumablesV1RoomconsumableRoomconsumableIdPurchaseTokensRequest
{
    public Guid CHECOEIFABE;  // wrapper
    public Guid? FKAPCLHHDLF;  // wrapper
}

// api/roomcurrencies/v1/awardCurrency/bulk  [Econ POST]
public class RoomcurrenciesV1AwardCurrencyBulkRequest
{
    public List<PAGIGLIPPGK> DCBDHFOOPFM;  // wrapper
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
    public Guid NEJOKBAOPAG;  // wrapper
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
    public Guid NEJOKBAOPAG;  // wrapper
    public long? FLLHACJOMKO;  // wrapper
    public byte? CEGPNHKCFDA;  // wrapper
    public int? DDJLPLIEHMO;  // wrapper
    public object Color;  // candidate
    public object CurrencyId;  // candidate
    public object Name;  // candidate
    public object ImageName;  // candidate
    public object Limit;  // candidate
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public Guid OCOAGIGKOAK;  // wrapper
    public long? ICOKPJLHPHK;  // wrapper
    public long? GAKOKHMGJPD;  // wrapper
    public int? KNKCFCGHKPC;  // wrapper
    public object Price;  // candidate
    public object Amount;  // candidate
    public object Name;  // candidate
    public object PurchaseOfferId;  // candidate
    public object Order;  // candidate
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public IEnumerable<KeyValuePair<string, string>> NNBNMFFCBEB;  // wrapper
    public object RoomKeyId;  // candidate
}

// api/roomkeys/v1/awardbulk  [Econ POST]
public class RoomkeysV1AwardbulkRequest
{
    public IEnumerable<PDFDOADDLKJ> FDGAMIMIJGK;  // wrapper
}

// api/roomkeys/v1/create  [Econ POST]
public class RoomkeysV1CreateRequest
{
    public MPOJNGKOPGC LFLAEPCPMDG;  // wrapper
    public Guid? KPIPMEAEHIC;  // wrapper
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
    public DOPJHNMIPKL OCFEOENNEME;  // wrapper
    public long? DIHDEADJHAP;  // wrapper
    public object ReportCategory;  // candidate
    public object RoomId;  // candidate
    public object RoomKeyId;  // candidate
    public object Details;  // candidate
}

// api/royale/v2/matchcomplete  [Econ POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats JNPKHHGFJEM;  // wrapper
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
    public Guid MEFDDIOEEMF;  // wrapper
    public object RequestedPurchaseCurrencyId;  // candidate
    public object RequestedPrice;  // candidate
    public object RoomKeyId;  // candidate
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public Guid CODBEKGMPNA;  // wrapper
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
    public List<GBDJMJCJOMK> FBPOALGPBBG;  // wrapper
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
    public EPGDKEACHMH JNBMPHOBHBP;  // wrapper
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public int? pid;  // wrapper
}

