// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 202 (plus referenced enums)

// --------------------------------------------------------------------------
// AGUI.StackedUI.Dialog.EnterTextDialogResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class EnterTextDialogResponse : ValueType
{
    public ConfirmDialogResponses responseType;    // 0x0x0
    public string text;    // 0x0x8
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
    public bool <TryToMinimizeTCPLatency>k__BackingField;    // 0x0x110
    public long <Downloaded>k__BackingField;    // 0x0x118
    public long <DownloadLength>k__BackingField;    // 0x0x120
    public bool <DownloadProgressChanged>k__BackingField;    // 0x0x128
    public long <Uploaded>k__BackingField;    // 0x0x130
    public long <UploadLength>k__BackingField;    // 0x0x138
    public bool <UploadProgressChanged>k__BackingField;    // 0x0x140
    public bool isKeepAlive;    // 0x0x141
    public bool disableCache;    // 0x0x142
    public bool cacheOnly;    // 0x0x143
    public int streamFragmentSize;    // 0x0x144
    public bool useStreaming;    // 0x0x148
    public Dictionary<string, List<string>> <Headers>k__BackingField;    // 0x0x150
    public HTTPFormBase FieldCollector;    // 0x0x158
    public HTTPFormBase FormImpl;    // 0x0x160
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
// CodeStage.AntiCheat.ObscuredTypes.ObscuredInt
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ObscuredInt : ValueType
{
    public int currentCryptoKey;    // 0x0x0
    public int hiddenValue;    // 0x0x4
    public int fakeValue;    // 0x0x8
    public bool inited;    // 0x0xC
}

// --------------------------------------------------------------------------
// ExitGames.Client.Photon.LoadBalancing.WebRpcResponse
//   (not directly referenced by a detected call)
public class WebRpcResponse
{
    public string <Name>k__BackingField;    // 0x0x10
    public int <ReturnCode>k__BackingField;    // 0x0x18
    public string <DebugMessage>k__BackingField;    // 0x0x20
    public Dictionary<string, object> <Parameters>k__BackingField;    // 0x0x28
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
// ISN_GKResolveSavedGamesRequest
//   (not directly referenced by a detected call)
public class ISN_GKResolveSavedGamesRequest
{
    public List<string> m_conflictedGames;    // 0x0x10
    public string m_data;    // 0x0x18
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
// Oculus.Platform.Request`1
// base   : Oculus.Platform.Request
//   (not directly referenced by a detected call)
public class Request
{
    // (no instance fields in the metadata dump)
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
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v3/addversion   [Service.API]
public class AddVersionInventionRequestDTO
{
    public long inventionId;    // 0x0x10
    public int instantiationCost;    // 0x0x18
    public int lightsCost;    // 0x0x1C
    public long creationRoomId;    // 0x0x20
    public string inventionDataFilename;    // 0x0x28
    public List<long> referencedInventions;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AmplitudeConfig
//   RESPONSE GET    api/config/v1/amplitude   [Service.API]
public class AmplitudeConfig
{
    public string <AmplitudeKey>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AutoMicMutingConfig
//   (not directly referenced by a detected call)
public class AutoMicMutingConfig
{
    public float <MicSpamVolumeThreshold>k__BackingField;    // 0x0x10
    public float <MicVolumeSampleInterval>k__BackingField;    // 0x0x14
    public float <MicVolumeSampleRollingWindowLength>k__BackingField;    // 0x0x18
    public float <MicSpamSamplePercentageForWarning>k__BackingField;    // 0x0x1C
    public float <MicSpamSamplePercentageForWarningToEnd>k__BackingField;    // 0x0x20
    public float <MicSpamSamplePercentageForForceMute>k__BackingField;    // 0x0x24
    public float <MicSpamSamplePercentageForForceMuteToEnd>k__BackingField;    // 0x0x28
    public float <MicSpamWarningStateVolumeMultiplier>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.BaseStorefrontDTO
//   (not directly referenced by a detected call)
public class BaseStorefrontDTO
{
    public StorefrontTypes <StorefrontType>k__BackingField;    // 0x0x10
    public DateTime <NextUpdate>k__BackingField;    // 0x0x18
    public DateTime? <NewUntil>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.BioDTO
//   (not directly referenced by a detected call)
public class BioDTO
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public string <Bio>k__BackingField;    // 0x0x18
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
// RecNet.BulkInviteResponse
//   REQUEST  ?      api/playerevents/   [Service.?]
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
//   REQUEST  ?      api/playerevents/v1/{eventId}/responses   [Service.?]
public class BulkInviteResponse
{
    public List<InviteResponse> <FailedInvites>k__BackingField;    // 0x0x10
    public CreateModifyPlayerEventStatus <Result>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ChallengeGift
//   (not directly referenced by a detected call)
public class ChallengeGift
{
    public long <GiftDropId>k__BackingField;    // 0x0x10
    public string <ConsumableItemDesc>k__BackingField;    // 0x0x18
    public string <AvatarItemDesc>k__BackingField;    // 0x0x20
    public AvatarItemType? <AvatarItemType>k__BackingField;    // 0x0x28
    public string <EquipmentPrefabName>k__BackingField;    // 0x0x30
    public string <EquipmentModificationGuid>k__BackingField;    // 0x0x38
    public StorefrontTypes <StorefrontType>k__BackingField;    // 0x0x40
    public int <Xp>k__BackingField;    // 0x0x44
    public int <Level>k__BackingField;    // 0x0x48
    public GiftContext <GiftContext>k__BackingField;    // 0x0x4C
    public GiftRarity <GiftRarity>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.ChallengeMap
//   RESPONSE GET    api/challenge/v2/getCurrent   [Service.API]
public class ChallengeMap
{
    public int <ChallengeMapId>k__BackingField;    // 0x0x10
    public string <ThemeString>k__BackingField;    // 0x0x18
    public List<RecNetChallenge> <Challenges>k__BackingField;    // 0x0x20
    public ChallengeGift <Gift>k__BackingField;    // 0x0x28
    public DateTime <StartAt>k__BackingField;    // 0x0x30
    public DateTime <EndAt>k__BackingField;    // 0x0x38
    public DateTime <ServerTime>k__BackingField;    // 0x0x40
    public bool <CompletedRequired>k__BackingField;    // 0x0x48
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
// RecNet.CreateChatResponse
//   (not directly referenced by a detected call)
public class CreateChatResponse
{
    public ChatThread <ChatThread>k__BackingField;    // 0x0x10
    public ChatResults <ChatResult>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.CreateModifyEventRequest
//   REQUEST  POST   api/playerevents/   [Service.API]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.API]
public class CreateModifyEventRequest
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public DateTime <StartTime>k__BackingField;    // 0x0x28
    public DateTime <EndTime>k__BackingField;    // 0x0x30
    public PlayerEventAccessibility <Accessibility>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.CreateModifyPlayerEventResponse
//   RESPONSE POST   api/playerevents/   [Service.API]
//   REQUEST  ?      api/playerevents/   [Service.?]
//   RESPONSE POST   api/playerevents/v2/delete/{playerEventId}   [Service.API]
//   RESPONSE POST   api/playerevents/v2/{eventId}   [Service.API]
public class CreateModifyPlayerEventResponse
{
    public PlayerEvent <PlayerEvent>k__BackingField;    // 0x0x10
    public CreateModifyPlayerEventStatus <Result>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.CreateModifyPlayerEventResult
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class CreateModifyPlayerEventResult
{
    public CreateModifyPlayerEventStatus <Result>k__BackingField;    // 0x0x10
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
// RecNet.GetFiltersResponse
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
public class GetFiltersResponse
{
    public List<string> <PinnedFilters>k__BackingField;    // 0x0x10
    public List<string> <PopularFilters>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.GetLeaderboardRequestDTO
//   (not directly referenced by a detected call)
public class GetLeaderboardRequestDTO
{
    public ObjectiveType ObjectiveType;    // 0x0x10
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
    public FilterType FilterType;    // 0x0x20
    public Timeframe Timeframe;    // 0x0x24
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
// RecNet.GiftDropStorefront
// base   : RecNet.BaseStorefrontDTO
//   RESPONSE GET    api/storefronts/v3/giftdropstore/{giftdropstoreId}   [Service.API]
public class GiftDropStorefront : BaseStorefrontDTO
{
    public List<PurchasableGiftDrop> StoreItems;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.Group
//   RESPONSE GET    api/groups/v1/name/{nameId}   [Service.API]
//   RESPONSE GET    api/groups/v1/{groupId}   [Service.API]
public class Group
{
    public long <GroupId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public DateTime <CreatedAt>k__BackingField;    // 0x0x28
    public string <ImageName>k__BackingField;    // 0x0x30
    public GroupBanStatus <BanStatus>k__BackingField;    // 0x0x38
    public int <CreatorId>k__BackingField;    // 0x0x3C
    public int <NumMembers>k__BackingField;    // 0x0x40
    public List<GroupMembership> <Members>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.GroupBanStatus
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GroupBanStatus
{
    GoodStanding = 0,
    InReview = 1,
    TempLock = 2,
    Permaban = 3,
}

// --------------------------------------------------------------------------
// RecNet.GroupMembership
//   RESPONSE GET    api/groups/v1/memberships/{playerId}   [Service.API]
public class GroupMembership
{
    public long <GroupId>k__BackingField;    // 0x0x10
    public int <PlayerId>k__BackingField;    // 0x0x18
    public GroupMembershipPermissions <Permissions>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.GroupMembershipPermissions
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GroupMembershipPermissions
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
// RecNet.IOSNotificationPreferences
//   RESPONSE GET    api/messages/v1/IOSGetNotificationPreferences   [Service.API]
public class IOSNotificationPreferences
{
    public bool <ChatMessage>k__BackingField;    // 0x0x10
    public bool <FriendInvite>k__BackingField;    // 0x0x11
    public bool <FavoriteFriendOnline>k__BackingField;    // 0x0x12
}

// --------------------------------------------------------------------------
// RecNet.Invention
//   RESPONSE GET    api/inventions/   [Service.API]
public class Invention
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public string <ReplicationId>k__BackingField;    // 0x0x18
    public int <CreatorPlayerId>k__BackingField;    // 0x0x20
    public string <Name>k__BackingField;    // 0x0x28
    public string <Description>k__BackingField;    // 0x0x30
    public string <ImageName>k__BackingField;    // 0x0x38
    public int <CurrentVersionNumber>k__BackingField;    // 0x0x40
    public bool <IsPublished>k__BackingField;    // 0x0x44
    public DateTime <ModifiedAt>k__BackingField;    // 0x0x48
    public DateTime <CreatedAt>k__BackingField;    // 0x0x50
    public DateTime? <FirstPublishedAt>k__BackingField;    // 0x0x58
    public long? <CreationRoomId>k__BackingField;    // 0x0x68
    public int <NumPlayersHaveUsedInRoom>k__BackingField;    // 0x0x78
    public int <NumDownloads>k__BackingField;    // 0x0x7C
    public int <CheerCount>k__BackingField;    // 0x0x80
    public InventionPermission <CreatorPermission>k__BackingField;    // 0x0x84
    public InventionPermission <GeneralPermission>k__BackingField;    // 0x0x88
    public bool <IsAgInvention>k__BackingField;    // 0x0x8C
}

// --------------------------------------------------------------------------
// RecNet.InventionBatchRequest
//   REQUEST  POST   api/inventions/v1/batch   [Service.API]
public class InventionBatchRequest
{
    public List<long> InventionIds;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.InventionCreatorIdDTO
//   (not directly referenced by a detected call)
public class InventionCreatorIdDTO
{
    public int <CreatorPlayerId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.InventionDetails
//   RESPONSE GET    api/inventions/v1/details   [Service.API]
public class InventionDetails
{
    public List<TagDTO> <Tags>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.InventionPermission
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum InventionPermission
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
// RecNet.InventionResponse
//   RESPONSE POST   api/inventions/v1/cheer   [Service.API]
//   RESPONSE GET    api/inventions/v1/delete   [Service.API]
//   RESPONSE GET    api/inventions/v1/download   [Service.API]
//   RESPONSE GET    api/inventions/v1/unpublish   [Service.API]
//   RESPONSE GET    api/inventions/v1/update   [Service.API]
//   RESPONSE GET    api/inventions/v2/publish   [Service.API]
//   RESPONSE POST   api/inventions/v3/addversion   [Service.API]
//   RESPONSE POST   api/inventions/v3/save   [Service.API]
public class InventionResponse
{
    public InventionResult <Status>k__BackingField;    // 0x0x10
    public Invention <Invention>k__BackingField;    // 0x0x18
    public InventionVersion <InventionVersion>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.InventionResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum InventionResult
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
}

// --------------------------------------------------------------------------
// RecNet.InventionVersion
//   RESPONSE GET    api/inventions/v1/version   [Service.API]
public class InventionVersion
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public string <ReplicationId>k__BackingField;    // 0x0x18
    public int <VersionNumber>k__BackingField;    // 0x0x20
    public int <InstantiationCost>k__BackingField;    // 0x0x24
    public int <LightsCost>k__BackingField;    // 0x0x28
    public string <BlobName>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.InviteResponse
//   (not directly referenced by a detected call)
public class InviteResponse
{
    public int <InvitedPlayerId>k__BackingField;    // 0x0x10
    public CreateModifyPlayerEventStatus <Result>k__BackingField;    // 0x0x14
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
// RecNet.LocalPlayerEventInfo
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
public class LocalPlayerEventInfo
{
    public List<PlayerEvent> <Created>k__BackingField;    // 0x0x10
    public List<PlayerEventInformation> <Responses>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ModerationBlockDetail
//   RESPONSE GET    api/PlayerReporting/v1/moderationBlockDetails   [Service.API]
public class ModerationBlockDetail
{
    public ReportCategory <ReportCategory>k__BackingField;    // 0x0x10
    public int <Duration>k__BackingField;    // 0x0x14
    public long <GameSessionId>k__BackingField;    // 0x0x18
    public bool <IsHostKick>k__BackingField;    // 0x0x20
    public string <Message>k__BackingField;    // 0x0x28
    public int? <PlayerIdReporter>k__BackingField;    // 0x0x30
    public bool <IsBan>k__BackingField;    // 0x0x38
    public float <UnscaledBlockStartTime>k__BackingField;    // 0x0x3C
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
//   REQUEST  POST   api/inventions/v3/save   [Service.API]
public class NewInventionRequestDTO
{
    public string name;    // 0x0x10
    public string description;    // 0x0x18
    public string imageName;    // 0x0x20
    public int instantiationCost;    // 0x0x28
    public int lightsCost;    // 0x0x2C
    public long creationRoomId;    // 0x0x30
    public string inventionDataFilename;    // 0x0x38
    public List<long> referencedInventions;    // 0x0x40
    public int creatorPlayerRole;    // 0x0x48
    public RoomPermissionValue creatorPlayerCoOwnerRoomPermission;    // 0x0x4C
    public RoomPermissionValue creatorPlayerModeratorRoomPermission;    // 0x0x50
    public RoomPermissionValue creatorPlayerHostRoomPermission;    // 0x0x54
}

// --------------------------------------------------------------------------
// RecNet.ObjectiveGroupProgress
//   RESPONSE POST   api/objectives/   [Service.API]
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.API]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.API]
public class ObjectiveGroupProgress
{
    public int <Group>k__BackingField;    // 0x0x10
    public bool <IsCompleted>k__BackingField;    // 0x0x14
    public DateTime <ClearedAt>k__BackingField;    // 0x0x18
    public bool <RequiresCompleteOnServer>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ObjectiveProgress
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.API]
public class ObjectiveProgress
{
    public int <Index>k__BackingField;    // 0x0x10
    public int <Group>k__BackingField;    // 0x0x14
    public float <Progress>k__BackingField;    // 0x0x18
    public float <VisualProgress>k__BackingField;    // 0x0x1C
    public bool <IsCompleted>k__BackingField;    // 0x0x20
    public bool <IsRewarded>k__BackingField;    // 0x0x21
    public bool <IsDirty>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// RecNet.OkResponse
//   REQUEST  POST   api/PlayerCheer/v1/create   [Service.API]
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v1/instantKick   [Service.API]
//   REQUEST  POST   api/PlayerReporting/v3/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/create   [Service.API]
//   RESPONSE POST   api/PlayerReporting/v3/voteToKick   [Service.API]
//   RESPONSE POST   api/inventions/v1/report   [Service.API]
//   RESPONSE POST   api/playerevents/v1/report   [Service.API]
//   REQUEST  ?      api/rooms/   [Service.?]
//   RESPONSE POST   api/rooms/v1/bookmark   [Service.API]
//   RESPONSE POST   api/rooms/v1/cheer   [Service.API]
//   REQUEST  ?      api/rooms/v2/personaldetails/{personaldetailId}   [Service.?]
//   RESPONSE POST   api/rooms/v2/report   [Service.API]
public class OkResponse
{
    public bool <Success>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.PersonalInventionDetails
//   RESPONSE GET    api/inventions/v1/personaldetails/{inventionId}   [Service.API]
public class PersonalInventionDetails
{
    public bool <IsCheering>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.PersonalRoomDetails
//   RESPONSE GET    api/rooms/v2/personaldetails/{personaldetailId}   [Service.API]
public class PersonalRoomDetails
{
    public bool <IsCheering>k__BackingField;    // 0x0x10
    public bool <IsBookmarked>k__BackingField;    // 0x0x11
}

// --------------------------------------------------------------------------
// RecNet.PlayerEvent
//   RESPONSE GET    api/playerevents/v1/{playerEventId}   [Service.API]
public class PlayerEvent
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
    public int <CreatorPlayerId>k__BackingField;    // 0x0x18
    public long <RoomId>k__BackingField;    // 0x0x20
    public string <Name>k__BackingField;    // 0x0x28
    public string <Description>k__BackingField;    // 0x0x30
    public DateTime <StartTime>k__BackingField;    // 0x0x38
    public DateTime <EndTime>k__BackingField;    // 0x0x40
    public int <AttendeeCount>k__BackingField;    // 0x0x48
    public string <ImageName>k__BackingField;    // 0x0x50
    public PlayerEventAccessibility <Accessibility>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.PlayerEventAccessibility
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PlayerEventAccessibility
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// RecNet.PlayerEventIdDTO
//   (not directly referenced by a detected call)
public class PlayerEventIdDTO
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.PlayerEventInformation
//   (not directly referenced by a detected call)
public class PlayerEventInformation
{
    public PlayerEvent <PlayerEvent>k__BackingField;    // 0x0x10
    public PlayerEventResponse <PlayerEventResponse>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.PlayerEventReportRequest
//   REQUEST  POST   api/playerevents/v1/report   [Service.API]
public class PlayerEventReportRequest
{
    public ReportCategory <ReportCategory>k__BackingField;    // 0x0x10
    public long <PlayerEventId>k__BackingField;    // 0x0x18
    public string <Details>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PlayerEventResponse
//   (not directly referenced by a detected call)
public class PlayerEventResponse
{
    public long <PlayerEventResponseId>k__BackingField;    // 0x0x10
    public long <PlayerEventId>k__BackingField;    // 0x0x18
    public int <PlayerId>k__BackingField;    // 0x0x20
    public DateTime <CreatedAt>k__BackingField;    // 0x0x28
    public PlayerEventResponseType <Type>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.PlayerEventResponseRequest
//   REQUEST  POST   api/playerevents/v1/respond   [Service.API]
public class PlayerEventResponseRequest
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
    public PlayerEventResponseType <Type>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.PlayerQuickPlayDTO
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class PlayerQuickPlayDTO
{
    public int? <TargetPlayerId>k__BackingField;    // 0x0x10
    public string <RoomName>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.PlayerStorefrontSeasonDTO
//   (not directly referenced by a detected call)
public class PlayerStorefrontSeasonDTO
{
    public bool <HasEliteUpgrade>k__BackingField;    // 0x0x10
    public PlatformMask <HasEliteUpgradePlatformMask>k__BackingField;    // 0x0x14
    public int <CurrentSeasonTierNumber>k__BackingField;    // 0x0x18
    public DateTime <ModifiedAt>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PurchasableGiftDrop
// base   : RecNet.PurchasableItem
//   (not directly referenced by a detected call)
public class PurchasableGiftDrop : PurchasableItem
{
    public List<StorefrontGiftDrop> <GiftDrops>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.RecNetChallenge
//   (not directly referenced by a detected call)
public class RecNetChallenge
{
    public int <ChallengeId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Config>k__BackingField;    // 0x0x20
    public string <Description>k__BackingField;    // 0x0x28
    public string <Tooltip>k__BackingField;    // 0x0x30
    public bool <Complete>k__BackingField;    // 0x0x38
    public int <Slot>k__BackingField;    // 0x0x3C
    public IChallenge <ChallengeDefinition>k__BackingField;    // 0x0x40
    public ChallengeUpdate ChallengeDefinitionUpdateEvent;    // 0x0x48
    public ChallengeUpdate ChallengeDefinitionUpdateServerEvent;    // 0x0x50
    public ChallengeUpdate ChallengeDefinitionCompleteEvent;    // 0x0x58
    public ChallengeNotification ChallengeNotificationEvent;    // 0x0x60
}

// --------------------------------------------------------------------------
// RecNet.RecNetResult
//   (not directly referenced by a detected call)
public class RecNetResult
{
    public bool <Success>k__BackingField;    // 0x0x10
    public string <Error>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RecRoomConfig
//   RESPONSE GET    api/config/   [Service.API]
public class RecRoomConfig
{
    public Dictionary<int, int> <LevelProgressionMap>k__BackingField;    // 0x0x10
    public Objective[][] <DailyObjectives>k__BackingField;    // 0x0x18
    public ServerMaintenanceDTO <ServerMaintenance>k__BackingField;    // 0x0x20
    public AutoMicMutingConfig <AutoMicMutingConfig>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.Relationship
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
public class Relationship
{
    public int <PlayerID>k__BackingField;    // 0x0x10
    public RelationshipType <Type>k__BackingField;    // 0x0x14
    public ReciprocalStatus <Muted>k__BackingField;    // 0x0x18
    public ReciprocalStatus <Ignored>k__BackingField;    // 0x0x1C
    public ReciprocalStatus <Favorited>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long InventionId;    // 0x0x10
    public string Details;    // 0x0x18
    public InventionReportCategory ReportCategory;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RoomDetails
//   RESPONSE GET    api/rooms/v4/details/{detailId}   [Service.API]
public class RoomDetails
{
    public Room <Room>k__BackingField;    // 0x0x10
    public List<RoomScene> <Scenes>k__BackingField;    // 0x0x18
    public List<int> <CoOwnerIds>k__BackingField;    // 0x0x20
    public List<int> <InvitedCoOwnerIds>k__BackingField;    // 0x0x28
    public List<int> <ModeratorIds>k__BackingField;    // 0x0x30
    public List<int> <InvitedModeratorIds>k__BackingField;    // 0x0x38
    public List<int> <HostIds>k__BackingField;    // 0x0x40
    public List<int> <InvitedHostIds>k__BackingField;    // 0x0x48
    public List<string> AllTags;    // 0x0x50
    public List<string> AutoTags;    // 0x0x58
    public List<string> PlayerAddedTags;    // 0x0x60
    public List<string> AgTags;    // 0x0x68
    public int <CheerCount>k__BackingField;    // 0x0x70
    public int <FavoriteCount>k__BackingField;    // 0x0x74
    public int <VisitCount>k__BackingField;    // 0x0x78
    public List<int> <PlayerIdsWithModPower>k__BackingField;    // 0x0x80
    public ObscuredInt _localPlayerRole;    // 0x0x88
}

// --------------------------------------------------------------------------
// RecNet.RoomScene
//   RESPONSE POST   api/rooms/v4/saveData   [Service.API]
public class RoomScene
{
    public long <RoomSceneId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x18
    public RoomSceneLocations <Location>k__BackingField;    // 0x0x20
    public string <Name>k__BackingField;    // 0x0x28
    public bool <IsSandbox>k__BackingField;    // 0x0x30
    public string <DataBlobName>k__BackingField;    // 0x0x38
    public int <MaxPlayers>k__BackingField;    // 0x0x40
    public bool <CanMatchmakeInto>k__BackingField;    // 0x0x44
    public DateTime <DataModifiedAt>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.SavedOutfit
//   REQUEST  POST   api/avatar/v3/saved/set   [Service.API]
public class SavedOutfit
{
    public int <Slot>k__BackingField;    // 0x0x10
    public string <PreviewImageName>k__BackingField;    // 0x0x18
    public string <OutfitSelections>k__BackingField;    // 0x0x20
    public string <FaceFeatures>k__BackingField;    // 0x0x28
    public string <SkinColor>k__BackingField;    // 0x0x30
    public string <HairColor>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.SendMessageResponse
//   (not directly referenced by a detected call)
public class SendMessageResponse
{
    public ChatMessage <ChatMessage>k__BackingField;    // 0x0x10
    public ChatResults <ChatResult>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ServerMaintenanceDTO
//   (not directly referenced by a detected call)
public class ServerMaintenanceDTO
{
    public int <StartsInMinutes>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.SetStatRequestDTO
//   (not directly referenced by a detected call)
public class SetStatRequestDTO
{
    public int StatChannel;    // 0x0x10
    public long RoomId;    // 0x0x18
    public int StatValue;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Setting
//   REQUEST  POST   api/settings/v2/{settingId}   [Service.API]
public class Setting
{
    public string <Key>k__BackingField;    // 0x0x10
    public string <Value>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.StorefrontBalanceAddConfigDTO
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{balanceaddtypeId}/{id1}   [Service.API]
public class StorefrontBalanceAddConfigDTO
{
    public CurrencyType <CurrencyType>k__BackingField;    // 0x0x10
    public StorefrontBalanceAddTypes <BalanceAddType>k__BackingField;    // 0x0x14
    public int <BaseAward>k__BackingField;    // 0x0x18
    public int <BonusAwardMin>k__BackingField;    // 0x0x1C
    public int <BonusAwardMax>k__BackingField;    // 0x0x20
    public RateLimitTypes <RateLimitType>k__BackingField;    // 0x0x24
    public bool <IgnorePartialMultiplier>k__BackingField;    // 0x0x28
    public float <MaxPartialMultiplier>k__BackingField;    // 0x0x2C
    public int <RateLimit>k__BackingField;    // 0x0x30
    public bool <BalanceInGiftBox>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// RecNet.StorefrontGiftDrop
//   (not directly referenced by a detected call)
public class StorefrontGiftDrop
{
    public int <GiftDropId>k__BackingField;    // 0x0x10
    public int <Level>k__BackingField;    // 0x0x14
    public string <FriendlyName>k__BackingField;    // 0x0x18
    public string <Tooltip>k__BackingField;    // 0x0x20
    public string <ConsumableItemDesc>k__BackingField;    // 0x0x28
    public string <AvatarItemDescOrHairDyeDesc>k__BackingField;    // 0x0x30
    public AvatarItemType? <AvatarItemType>k__BackingField;    // 0x0x38
    public string <EquipmentPrefabName>k__BackingField;    // 0x0x40
    public string <EquipmentModificationGuid>k__BackingField;    // 0x0x48
    public bool <IsQuery>k__BackingField;    // 0x0x50
    public bool <Unique>k__BackingField;    // 0x0x51
    public bool <SubscribersOnly>k__BackingField;    // 0x0x52
    public GiftRarity <Rarity>k__BackingField;    // 0x0x54
    public GiftBoxContents <Content>k__BackingField;    // 0x0x58
    public GiftContext <Context>k__BackingField;    // 0x0x5C
}

// --------------------------------------------------------------------------
// RecNet.StorefrontSeasonDTO
// base   : RecNet.BaseStorefrontDTO
//   RESPONSE GET    api/storefronts/v1/season/{seasonId}   [Service.API]
public class StorefrontSeasonDTO : BaseStorefrontDTO
{
    public int <Season>k__BackingField;    // 0x0x30
    public string <Name>k__BackingField;    // 0x0x38
    public DateTime <StartAt>k__BackingField;    // 0x0x40
    public DateTime <EndAt>k__BackingField;    // 0x0x48
    public CurrencyType <CurrencyType>k__BackingField;    // 0x0x50
    public PurchasableItem <EliteUpgrade>k__BackingField;    // 0x0x58
    public List<PurchasableSeasonTier> <Tiers>k__BackingField;    // 0x0x60
    public PlayerStorefrontSeasonDTO <PersonalDetails>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// RecNet.StorefrontTypes
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum StorefrontTypes
{
    None = 0,
    LaserTag = 1,
    RecCenter = 2,
    Watch = 3,
    Quest_LostSkulls = 100,
    Quest_Dracula = 101,
    RecRoyale = 200,
    Cafe = 300,
    Paintball = 400,
    Bowling = 500,
    StuntRunner = 600,
    DormMirror = 700,
}

// --------------------------------------------------------------------------
// RecNet.Tags.ModifyTagsResponse
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
//   RESPONSE POST   api/rooms/v1/modify/tags   [Service.API]
public class ModifyTagsResponse
{
    public TagStatus <Result>k__BackingField;    // 0x0x10
    public List<string> <Tags>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Tags.TagDTO
//   (not directly referenced by a detected call)
public class TagDTO
{
    public string <Tag>k__BackingField;    // 0x0x10
    public TagType <Type>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.TestCase
//   RESPONSE GET    api/testcasemanagement/v1/testcase/{id}   [Service.API]
public class TestCase
{
    public string Id;    // 0x0x10
    public string Key;    // 0x0x18
    public string Title;    // 0x0x20
    public string Description;    // 0x0x28
    public TestCaseStatus Status;    // 0x0x30
    public int MinNumAssignedPlayers;    // 0x0x34
    public List<int> AssignedPlayerIds;    // 0x0x38
    public List<string> AssignedPlayerNames;    // 0x0x40
    public List<string> Tags;    // 0x0x48
    public string JiraUrl;    // 0x0x50
    public string JiraBugUrl;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.TestCaseStatus
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum TestCaseStatus
{
    NotYetTested = 0,
    Claimed = 1,
    Failed = 2,
    Passed = 3,
}

// --------------------------------------------------------------------------
// RecNet.TestPass
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{id}   [Service.API]
public class TestPass
{
    public int Id;    // 0x0x10
    public string Name;    // 0x0x18
    public string Description;    // 0x0x20
    public DateTime StartDate;    // 0x0x28
    public DateTime EndDate;    // 0x0x30
    public bool WasManuallyClosed;    // 0x0x38
    public List<TestCase> TestCases;    // 0x0x40
    public List<string> Tags;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecRoom.Challenges.IChallenge
//   (not directly referenced by a detected call)
public class IChallenge
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.ChooseInventionPublishingPermissionsDialogResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ChooseInventionPublishingPermissionsDialogResponse : ValueType
{
    public ConfirmDialogResponses responseType;    // 0x0x0
    public InventionPermission permission;    // 0x0x4
}

// --------------------------------------------------------------------------
// RecRoom.Core.Combat.AimAssistResult
//   (not directly referenced by a detected call)
public class AimAssistResult
{
    public Vector3 TargetPosition;    // 0x0x10
    public Vector3 TargetVelocity;    // 0x0x1C
    public float TargetLateralDistanceAtOneMeter;    // 0x0x28
    public float TargetDistance;    // 0x0x2C
    public bool IsFriendlyFireLikely;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.Core.Creation.CostInfoResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CostInfoResult
{
    Success = 0,
    Failure_OverInkLimit = 1,
    Failure_OverLightsLimit = 2,
}

// --------------------------------------------------------------------------
// RecRoom.Core.Creation.CreationResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CreationResult
{
    Success = 0,
    Failure_Generic = 1,
    Failure_NoAuthority = 2,
    Failure_ToolFrozen = 3,
    Failure_ObjectRequired = 4,
    Failure_ConnectedToolFrozen = 5,
    Failure_LockedByOther = 6,
    Failure_HeldByOther = 7,
    Failure_SelectingFrozenTool = 8,
    Failure_SettingsChangedByOther = 9,
    Failure_InsufficientResources = 10,
    Failure_Parented = 11,
    Failure_ObjectDoesNotExist = 12,
    Failure_ParentChanged = 13,
    Failure_ToolHeld = 14,
    Failure_NetworkError = 15,
    Failure_ObjectAlreadyExists = 16,
    Failure_ToolNotEnabled = 17,
    Failure_PermissionDenied = 18,
    Failure_InvalidAction = 19,
    Failure_ObjectInUse = 20,
    Failure_MaxSpawnsUsed = 21,
    Failure_InsufficientLightResources = 22,
    Failure_ContainsDisallowedObjects = 23,
}

// --------------------------------------------------------------------------
// RoomSceneLocations
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum RoomSceneLocations
{
    INVALID = -1,
    DORM_ROOM = 0,
    REC_CENTER = 1,
    CHARADES = 2,
    LAKE = 3,
    PROPULSION = 4,
    DODGEBALL = 5,
    THE_LOUNGE = 6,
    PADDLEBALL = 7,
    RIVER = 8,
    HOMESTEAD = 9,
    QUARRY = 10,
    CLEAR_CUT = 11,
    SPILLWAY = 12,
    QUEST_FOR_THE_GOLDEN_TROPHY = 13,
    THE_RISE_OF_JUMBOTRON = 14,
    CURSE_OF_THE_CRIMSON_CAULDRON = 15,
    THE_ISLE_OF_LOST_SKULLS = 16,
    SOCCER = 17,
    ART_TESTING = 18,
    PERFORMANCE_HALL = 19,
    PSVR_ROOM_CALIBRATION = 20,
    PARK = 21,
    WAREHOUSE = 22,
    CYBERJUNK_CITY = 23,
    MAKER_ROOM = 24,
    FRONTIER_SQUADS = 25,
    FRONTIER_SOLOS = 26,
    CRESCENDO_OF_THE_BLOOD_MOON = 27,
    BOWLING_ALLEY = 28,
    ANIMATION_RECORDING_STUDIO = 29,
    PAINTBALL_DRIVEIN_WHITEBOX = 30,
    STUNTRUNNER = 31,
    STUNTRUNNER_THE_MAIN_EVENT = 32,
    STUNTRUNNER_BASE_ROOM = 33,
    REGISTRATION = 34,
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
// Steamworks.CallResult`1
//   (not directly referenced by a detected call)
public class CallResult
{
    public CCallbackBaseVTable VTable;    // 0x0x0
    public nint m_pVTable;    // 0x0x0
    public CCallbackBase m_CCallbackBase;    // 0x0x0
    public GCHandle m_pCCallbackBase;    // 0x0x0
    public APIDispatchDelegate<T> m_Func;    // 0x0x0
    public SteamAPICall_t m_hAPICall;    // 0x0x0
    public int m_size;    // 0x0x0
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
// WebRpcResponse
//   (not directly referenced by a detected call)
public class WebRpcResponse
{
    public string <Name>k__BackingField;    // 0x0x10
    public int <ReturnCode>k__BackingField;    // 0x0x18
    public string <DebugMessage>k__BackingField;    // 0x0x20
    public Dictionary<string, object> <Parameters>k__BackingField;    // 0x0x28
}

// ==========================================================================
// SYNTHESIZED request DTOs: no wire body DTO was observed;
// these are built from observed form/query params, wrapper
// params and candidate keys. Field origins: form = POST/PUT
// form field, query = URL query param, wrapper = wrapper
// signature (not observed on wire), candidate = low
// confidence key. Names derive from the route.
// ==========================================================================

// api/PlayerCheer/v1/SetSelectedCheer  [API POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public CheerCategory? cheerCategory;  // wrapper
    public ApiCallback callback;  // wrapper
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
    public HileType type;  // wrapper
    public int? otherPlayerId;  // wrapper
    public object Message;  // candidate
    public object hile;  // candidate
    public object ReportedPlayer;  // candidate
}

// api/PlayerReporting/v3/voteToKick  [API POST]
public class PlayerReportingV3VoteToKickRequest
{
    public object PlayerId;  // candidate
    public object Response;  // candidate
    public object GameSessionId;  // candidate
}

// api/PlayersBanned/v2/ban  [API POST]
public class PlayersBannedV2BanRequest
{
    public ReportCategory reportCategory;  // wrapper
    public ApiCallback callback;  // wrapper
    public object PlayerId;  // candidate
    public object Reason;  // candidate
    public object BanType;  // candidate
    public object DisplayReason;  // candidate
    public object BannedUntil;  // candidate
}

// api/avatar/v2/gifts/consume/  [API POST]
public class AvatarV2GiftsConsumeRequest
{
    public object UnlockedLevel;  // candidate
}

// api/avatar/v2/gifts/generate  [API POST]
public class AvatarV2GiftsGenerateRequest
{
    public GiftContext context;  // wrapper
    public GiftContext? alternateContext;  // wrapper
    public ApiCallback<GiftPackage> callback;  // wrapper
    public object GiftContext;  // candidate
    public object IsGameGift;  // candidate
    public object AlternateGiftContext;  // candidate
    public object Message;  // candidate
}

// api/challenge/v2/updateProgress  [API POST]
public class ChallengeV2UpdateProgressRequest
{
    public RecNetChallenge challenge;  // wrapper
    public object ChallengeMapId;  // candidate
    public object ChallengeId;  // candidate
    public object Config;  // candidate
    public object Complete;  // candidate
}

// api/groups/v1/delete/{groupId}  [API POST]
public class GroupsV1DeleteGroupIdRequest
{
    public ApiCallback<StatusResponse> callback;  // wrapper
    public object GroupId;  // candidate
}

// api/messages/v1/IOSClearDeviceToken  [API POST]
public class MessagesV1IOSClearDeviceTokenRequest
{
    public object platformId;  // candidate
}

// api/messages/v1/IOSModifyNotificationPreferences  [API POST]
public class MessagesV1IOSModifyNotificationPreferencesRequest
{
    public IOSNotificationPreferences preferences;  // wrapper
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
    public List<long> playerIds;  // wrapper
    public MessageType messageType;  // wrapper
    public long? roomId;  // wrapper
    public ApiCallback callback;  // wrapper
    public object ToPlayerIds;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public MessageType messageType;  // wrapper
    public long? roomId;  // wrapper
    public ApiCallback callback;  // wrapper
    public object ToPlayerId;  // candidate
    public object Type;  // candidate
    public object Data;  // candidate
}

// api/offlineinvite/v1/send  [API POST]
public class OfflineinviteV1SendRequest
{
    public ApiCallback<string> callback;  // wrapper
    public object PlayerId;  // candidate
}

// api/players/v2/objectives  [API POST]
public class PlayersV2ObjectivesRequest
{
    public List<ObjectiveCompletionRecord> objectiveCompletionRecords;  // wrapper
    public object objectiveType;  // candidate
    public object additionalXp;  // candidate
    public object inParty;  // candidate
}

// api/playersubscriptions/v1/subscribe/{subscribeId}  [API POST]
public class PlayersubscriptionsV1SubscribeSubscribeIdRequest
{
    public ApiCallback callback;  // wrapper
    public object PlayerId;  // candidate
}

// api/playersubscriptions/v1/unsubscribe/{unsubscribeId}  [API POST]
public class PlayersubscriptionsV1UnsubscribeUnsubscribeIdRequest
{
    public ApiCallback callback;  // wrapper
    public object PlayerId;  // candidate
}

// api/rooms/v2/myRecent  [API GET]
public class RoomsV2MyRecentRequest
{
    public object skip;  // candidate
    public object take;  // candidate
}

// api/royale/v2/matchcomplete  [API POST]
public class RoyaleV2MatchcompleteRequest
{
    public MatchCompleteStats matchStats;  // wrapper
}

// api/storefronts/v1/objectives  [API POST]
public class StorefrontsV1ObjectivesRequest
{
    public List<StorefrontObjectiveCompletionRecord> objectiveCompletionRecords;  // wrapper
    public object objectiveType;  // candidate
    public object completionPercentage;  // candidate
    public object roomId;  // candidate
}

// api/testcasemanagement/v1/testcase/{testcaseId}/status  [API POST]
public class TestcasemanagementV1TestcaseTestcaseIdStatusRequest
{
    public TestCaseStatus newStatus;  // wrapper
}

