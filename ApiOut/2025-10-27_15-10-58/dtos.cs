// DTO wire types extracted from the Cpp2IL metadata dump.
// DTO classes: 651 (plus referenced enums)

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
// AGUI.StackedUI.Dialog.MultipleChoiceDialogResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class MultipleChoiceDialogResponse : ValueType
{
    public int Index;    // 0x0x0
    public string ResponseText;    // 0x0x8
    public ConfirmDialogResponses Response;    // 0x0x10
}

// --------------------------------------------------------------------------
// AmplitudeAnalytics.PostResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class PostResponse : ValueType
{
    public int StatusCode;    // 0x0x0
    public string DataAsText;    // 0x0x8
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
// BestHTTP.ServerSentEvents.EventSourceResponse
// base   : BestHTTP.HTTPResponse
//   (not directly referenced by a detected call)
public class EventSourceResponse : HTTPResponse
{
    public bool <IsClosed>k__BackingField;    // 0x0xE0
    public Action<EventSourceResponse, Message> OnMessage;    // 0x0xE8
    public Action<EventSourceResponse> OnClosed;    // 0x0xF0
    public object FrameLock;    // 0x0xF8
    public byte[] LineBuffer;    // 0x0x100
    public int LineBufferPos;    // 0x0x108
    public Message CurrentMessage;    // 0x0x110
    public List<Message> CompletedMessages;    // 0x0x118
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
// Circuits.All.Api.DebugExecutionResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class DebugExecutionResult : ValueType
{
    public DebugExecutionResultData Data;    // 0x0x0
    public DebugExecutionResultKind Kind;    // 0x0x18
}

// --------------------------------------------------------------------------
// Circuits.All.Mock.RecRoom.EVCreationResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class EVCreationResult : ValueType
{
    public QUFIWQZKMRB<OJTYTSYFGFU, MockStaticNetSysDeps> StaticNetSys;    // 0x0x0
    public QBYDPTCZCSP<OJTYTSYFGFU, MockCV2DynamicNetSysDeps> CV2DynamicNetSys;    // 0x0x8
    public ICGXRSEYDCA CircuitsManager;    // 0x0x10
    public Id32<DQQOGREBWGB> ClientId;    // 0x0x18
    public OJTYTSYFGFU Network;    // 0x0x20
}

// --------------------------------------------------------------------------
// Circuits.Dynamic.Api.LegacyCV2Result`1
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class LegacyCV2Result : ValueType
{
    public ZPUVDYIOLRT err;    // 0x0x0
    public T ok;    // 0x0x0
}

// --------------------------------------------------------------------------
// Circuits.Shared.Utilities.MultiResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class MultiResult : ValueType
{
    public Result<object, TBKCGNLOMPR>[] _results;    // 0x0x0
}

// --------------------------------------------------------------------------
// Circuits.Static.Core.UnificationSystem.Value.ApplyConstraintResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ApplyConstraintResult : ValueType
{
    public ApplyConstraintResultImpl Impl;    // 0x0x0
    public ApplyConstraintResultKind Kind;    // 0x0x10
}

// --------------------------------------------------------------------------
// CircuitsV2.Lang.Nodes.DiceResult
// base   : CircuitsV2.Lang.Nodes.ZHYODXSRXOG
//   (not directly referenced by a detected call)
public class DiceResult : ZHYODXSRXOG
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// CircuitsV2.LegacyError.LegacyTestConnectionResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LegacyTestConnectionResult
{
    CanConnectDirectly = 0,
    CanConvertAndConnect = 1,
}

// --------------------------------------------------------------------------
// CircuitsV2.Persistence.CV2Request
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class CV2Request : ValueType
{
    public ICTTKLBYQGC _deps;    // 0x0x0
    public RJNEMTAVLYW _staticNetSys;    // 0x0x8
}

// --------------------------------------------------------------------------
// Dissonance.Networking.Client.XIOGHFNODTO`1
// base   : Dissonance.Networking.QGICSZOUING`1<System.Nullable`1<a>>
//   (not directly referenced by a detected call)
public class XIOGHFNODTO
{
    public NIGVFSTZDWW<a> BADKYIIXAZN;    // 0x0x0
    public NYCWDQDRHYA TKEIDBHJGBU;    // 0x0x0
    public EventQueue BYAHGFFFLDN;    // 0x0x0
    public Rooms AHURXLVXFHV;    // 0x0x0
    public string DPVMGNBCIPS;    // 0x0x0
    public CodecSettings AUSKVNVGFOB;    // 0x0x0
    public Action<ZUGHWRNHRON<a?>> EVQQXVNEHSW;    // 0x0x0
    public List<KeyValuePair<ushort, a>> EOCGJILQFMK;    // 0x0x0
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
// LiteNetLib.ConnectRequestResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ConnectRequestResult
{
    None = 0,
    P2PLose = 1,
    Reconnection = 2,
    NewConnection = 3,
}

// --------------------------------------------------------------------------
// LiteNetLib.ConnectionRequestResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ConnectionRequestResult
{
    None = 0,
    Accept = 1,
    Reject = 2,
    RejectForce = 3,
}

// --------------------------------------------------------------------------
// LiteNetLib.DisconnectResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum DisconnectResult
{
    None = 0,
    Reject = 1,
    Disconnect = 2,
}

// --------------------------------------------------------------------------
// LiteNetLib.ShutdownResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ShutdownResult
{
    None = 0,
    Success = 1,
    WasConnected = 2,
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
// RRUI.Data.Notifications.MessageNotificationController_InAppMessageDTO
// base   : RRUI.Data.Notifications.BaseMessageNotificationController`1<RecNet.InAppMessageDTO>
//   (not directly referenced by a detected call)
public class MessageNotificationController_InAppMessageDTO
{
    public string viewSource;    // 0x0x60
    public ContentBlockButton primaryContentBlockButton;    // 0x0x68
    public IYSYHFMUVCR inAppMessages;    // 0x0x70
}

// --------------------------------------------------------------------------
// RRUI.Data.RoomPublishUpsellDialogResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum RoomPublishUpsellDialogResponse
{
    Dismissed = 0,
    DoUpsell = 1,
    SkipUpsell = 2,
}

// --------------------------------------------------------------------------
// RRUI.Models.Store.DialogResponse`1
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class DialogResponse : ValueType
{
    public bool WasDismissed;    // 0x0x0
    public TResponse CustomResponse;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.AI.AddMessageToConversationRequestDTO
//   (not directly referenced by a detected call)
public class AddMessageToConversationRequestDTO
{
    public string <ConversationId>k__BackingField;    // 0x0x10
    public ConversationMessageRole <Role>k__BackingField;    // 0x0x18
    public string <Text>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AI.AddToolCallResponseToConversationRequestDTO
//   (not directly referenced by a detected call)
public class AddToolCallResponseToConversationRequestDTO
{
    public string <ConversationId>k__BackingField;    // 0x0x10
    public string <ToolCallId>k__BackingField;    // 0x0x18
    public string <Response>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AI.ChatRequestDTO
//   (not directly referenced by a detected call)
public class ChatRequestDTO
{
    public string <Model>k__BackingField;    // 0x0x10
    public string <Prompt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.ChatResponseDTO
//   (not directly referenced by a detected call)
public class ChatResponseDTO
{
    public List<string> <AIResponse>k__BackingField;    // 0x0x10
    public decimal <Cost>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.CircuitGenConfigDTO
//   (not directly referenced by a detected call)
public class CircuitGenConfigDTO
{
    public string <LibraryId>k__BackingField;    // 0x0x10
    public bool <AllowBetaContent>k__BackingField;    // 0x0x18
    public bool <ComponentModificationEnabled>k__BackingField;    // 0x0x19
    public bool <UseOnObjectSpawnedOrReset>k__BackingField;    // 0x0x1A
    public bool <ExposeTunables>k__BackingField;    // 0x0x1B
    public bool <ExposePublicMethods>k__BackingField;    // 0x0x1C
    public bool <ObjectEventsEnabled>k__BackingField;    // 0x0x1D
    public bool <SpawnablesEnabled>k__BackingField;    // 0x0x1E
    public bool <TagEnumEnabled>k__BackingField;    // 0x0x1F
    public bool <IsRecRoomObjectOfTypeEnabled>k__BackingField;    // 0x0x20
    public bool <VirtualMethodsEnabled>k__BackingField;    // 0x0x21
    public bool <ComponentModificationEnabledForSceneObjects>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// RecNet.AI.ConversationDTO
//   (not directly referenced by a detected call)
public class ConversationDTO
{
    public List<ConversationMessageDTO> <ConversationItems>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AI.ConversationMessageDTO
//   (not directly referenced by a detected call)
public class ConversationMessageDTO
{
    public string <Conversation>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AI.CreateRealtimeSessionRequestDTO
//   (not directly referenced by a detected call)
public class CreateRealtimeSessionRequestDTO
{
    public string <AIType>k__BackingField;    // 0x0x10
    public string <Model>k__BackingField;    // 0x0x18
    public string <Instructions>k__BackingField;    // 0x0x20
    public string <Voice>k__BackingField;    // 0x0x28
    public string <TranscriptionModel>k__BackingField;    // 0x0x30
    public float <Temperature>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.AI.CreateRealtimeSessionResponseDTO
//   (not directly referenced by a detected call)
public class CreateRealtimeSessionResponseDTO
{
    public string <SessionId>k__BackingField;    // 0x0x10
    public string <ClientSecret>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.DescribeImageFileRequestDTO
// base   : RecNet.AI.ChatRequestDTO
//   (not directly referenced by a detected call)
public class DescribeImageFileRequestDTO : ChatRequestDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.AI.DescribeImageRequestDTO
//   (not directly referenced by a detected call)
public class DescribeImageRequestDTO
{
    public string <Model>k__BackingField;    // 0x0x10
    public string <Prompt>k__BackingField;    // 0x0x18
    public float? <Temperature>k__BackingField;    // 0x0x20
    public string <ImageName>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AI.DescribeImageResponseDTO
// base   : RecNet.AI.ChatResponseDTO
//   (not directly referenced by a detected call)
public class DescribeImageResponseDTO : ChatResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.AI.EditImageRequestDTO
//   (not directly referenced by a detected call)
public class EditImageRequestDTO
{
    public string <Model>k__BackingField;    // 0x0x10
    public string <Prompt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.GameAIPromoBalanceDTO
//   (not directly referenced by a detected call)
public class GameAIPromoBalanceDTO
{
    public int <AvailableDevCreditPacks>k__BackingField;    // 0x0x10
    public DateTime? <NextDevCreditPackGrantDate>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.GameAIRoomSpendSummaryDTO
//   (not directly referenced by a detected call)
public class GameAIRoomSpendSummaryDTO
{
    public RecNetResult <GameAIStatus>k__BackingField;    // 0x0x10
    public AIBalanceStatus <PromoBalanceStatus>k__BackingField;    // 0x0x18
    public long? <AmountSpent>k__BackingField;    // 0x0x20
    public DateTime? <AmountSpentSince>k__BackingField;    // 0x0x30
    public long? <AvailableBalance>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateAudioOrSongResponseDTO
//   (not directly referenced by a detected call)
public class GenerateAudioOrSongResponseDTO
{
    public string <Filename>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateCircuitsFromCodeRequestDTO
//   (not directly referenced by a detected call)
public class GenerateCircuitsFromCodeRequestDTO
{
    public string <Code>k__BackingField;    // 0x0x10
    public CircuitObjectDefinition <ObjectDefinition>k__BackingField;    // 0x0x18
    public CircuitGenConfigDTO <Config>k__BackingField;    // 0x0x20
    public string <LibraryCode>k__BackingField;    // 0x0x28
    public IReadOnlyList<string> <SceneTags>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateCircuitsRequestDTO
//   (not directly referenced by a detected call)
public class GenerateCircuitsRequestDTO
{
    public string <Prompt>k__BackingField;    // 0x0x10
    public CircuitObjectDefinition <ObjectDefinition>k__BackingField;    // 0x0x18
    public IReadOnlyList<CircuitObjectDefinition> <SceneObjectDefinitions>k__BackingField;    // 0x0x20
    public IReadOnlyList<string> <SceneTags>k__BackingField;    // 0x0x28
    public CircuitGenConfigDTO <Config>k__BackingField;    // 0x0x30
    public string <Instructions>k__BackingField;    // 0x0x38
    public string <LibraryCode>k__BackingField;    // 0x0x40
    public string <Model>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateCircuitsResponseDTO
//   (not directly referenced by a detected call)
public class GenerateCircuitsResponseDTO
{
    public RecNetResultObject<GeneratedCircuitBoardDTO> <Result>k__BackingField;    // 0x0x10
    public decimal <CodeGenerationCost>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateConversationResponseRequestDTO
//   (not directly referenced by a detected call)
public class GenerateConversationResponseRequestDTO
{
    public string <ConversationId>k__BackingField;    // 0x0x10
    public string <Model>k__BackingField;    // 0x0x18
    public float? <Temperature>k__BackingField;    // 0x0x20
    public NamedSchemaDTO <ResponseFormat>k__BackingField;    // 0x0x28
    public List<NamedSchemaDTO> <Tools>k__BackingField;    // 0x0x30
    public ToolChoice <ToolChoice>k__BackingField;    // 0x0x38
    public string <ForceToolName>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateConversationResponseResponseDTO
//   (not directly referenced by a detected call)
public class GenerateConversationResponseResponseDTO
{
    public List<string> <TextItems>k__BackingField;    // 0x0x10
    public List<ToolCallDTO> <ToolCalls>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateImageRequestDTO
//   (not directly referenced by a detected call)
public class GenerateImageRequestDTO
{
    public string <Model>k__BackingField;    // 0x0x10
    public string <Prompt>k__BackingField;    // 0x0x18
    public bool <Tileable>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateImageResponseDTO
//   (not directly referenced by a detected call)
public class GenerateImageResponseDTO
{
    public string <Filename>k__BackingField;    // 0x0x10
    public decimal <ImageGenerationCost>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateMeshFromImageRequestDTO
// base   : RecNet.AI.GenerateMeshRequestDTO
//   (not directly referenced by a detected call)
public class GenerateMeshFromImageRequestDTO : GenerateMeshRequestDTO
{
    public string <ImageName>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateMeshRequestDTO
//   (not directly referenced by a detected call)
public class GenerateMeshRequestDTO
{
    public string <FriendlyName>k__BackingField;    // 0x0x10
    public string <Prompt>k__BackingField;    // 0x0x18
    public bool <AllowRoomInstanceAccess>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateMeshResponseDTO
//   (not directly referenced by a detected call)
public class GenerateMeshResponseDTO
{
    public long <GenerateMeshRequestId>k__BackingField;    // 0x0x10
    public string <FriendlyName>k__BackingField;    // 0x0x18
    public GenerateMeshRequestStates <GenerateMeshRequestState>k__BackingField;    // 0x0x20
    public Guid? <UnityAssetId>k__BackingField;    // 0x0x24
    public string <MeshFileName>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.AI.GenerateSpeechRequestDTO
//   (not directly referenced by a detected call)
public class GenerateSpeechRequestDTO
{
    public string <Model>k__BackingField;    // 0x0x10
    public string <Input>k__BackingField;    // 0x0x18
    public string <Voice>k__BackingField;    // 0x0x20
    public string <ResponseFormat>k__BackingField;    // 0x0x28
    public string <Instructions>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AI.GeneratedCircuitBoardDTO
//   (not directly referenced by a detected call)
public class GeneratedCircuitBoardDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public CircuitBoard <CircuitBoard>k__BackingField;    // 0x0x18
    public CircuitObjectDefinition <ObjectDefinition>k__BackingField;    // 0x0x20
    public List<CircuitObjectDefinition> <SceneObjectDefinitions>k__BackingField;    // 0x0x28
    public IReadOnlyList<Chip> <EventDefinitions>k__BackingField;    // 0x0x30
    public IReadOnlyList<CircuitObjectEvent> <ObjectEvents>k__BackingField;    // 0x0x38
    public string <Code>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AI.MakerAIBalancesDTO
//   (not directly referenced by a detected call)
public class MakerAIBalancesDTO
{
    public AIBalanceStatus <TimeBalanceStatus>k__BackingField;    // 0x0x10
    public DateTime <TimeExpiresAt>k__BackingField;    // 0x0x18
    public AIBalanceStatus <UsageBalanceStatus>k__BackingField;    // 0x0x20
    public float <UsagePercent>k__BackingField;    // 0x0x24
    public AIBalanceStatus <RRPlusUsageBalanceStatus>k__BackingField;    // 0x0x28
    public float <RRPlusUsagePercent>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.AI.MakerAIFreeTrialConfigDTO
//   RESPONSE GET    api/makerai/freetrialconfig   [Service.Econ]
public class MakerAIFreeTrialConfigDTO
{
    public TimeSpan <Cooldown>k__BackingField;    // 0x0x10
    public TimeSpan <Duration>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.NamedSchemaDTO
//   (not directly referenced by a detected call)
public class NamedSchemaDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public string <Schema>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AI.RoomieEnergyDTO
//   (not directly referenced by a detected call)
public class RoomieEnergyDTO
{
    public long <MaxEnergyFromSubscriptions>k__BackingField;    // 0x0x10
    public long <EnergyLeft>k__BackingField;    // 0x0x18
    public bool <OutputAudioEnabled>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AI.RoomieUserFactsDTO
//   (not directly referenced by a detected call)
public class RoomieUserFactsDTO
{
    public List<UserFactDTO> <UserFacts>k__BackingField;    // 0x0x10
    public string <UserContext>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.SearchRoomsResponseDTO
//   (not directly referenced by a detected call)
public class SearchRoomsResponseDTO
{
    public List<string> <Value>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AI.ToolCallDTO
//   (not directly referenced by a detected call)
public class ToolCallDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Arguments>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AI.UpdateRoomieSessionSpendRequestDTO
// base   : RecNet.AI.UpdateUserSessionSpendRequestDTO
//   (not directly referenced by a detected call)
public class UpdateRoomieSessionSpendRequestDTO : UpdateUserSessionSpendRequestDTO
{
    public byte <RoomieEnergyMode>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.AI.UpdateUserSessionSpendRequestDTO
//   (not directly referenced by a detected call)
public class UpdateUserSessionSpendRequestDTO
{
    public Guid <SpendSessionId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x20
    public long <RoomInstanceId>k__BackingField;    // 0x0x28
    public decimal <Spend>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AI.UploadRealtimeSessionLogsDTO
//   (not directly referenced by a detected call)
public class UploadRealtimeSessionLogsDTO
{
    public string <SessionId>k__BackingField;    // 0x0x10
    public string <Logs>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AI.UserFactDTO
//   (not directly referenced by a detected call)
public class UserFactDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public string <Predicate>k__BackingField;    // 0x0x18
    public string <Object>k__BackingField;    // 0x0x20
    public string <Emotion>k__BackingField;    // 0x0x28
    public DateTime <CreatedAt>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ActionLinkDTO
//   (not directly referenced by a detected call)
public class ActionLinkDTO
{
    public int <CreatorPlayerId>k__BackingField;    // 0x0x10
    public string <Data>k__BackingField;    // 0x0x18
    public bool <IsValid>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.AddKeepsakeInstanceRequest
//   REQUEST  GET    api/keepsakes   [Service.Clubs]
public class AddKeepsakeInstanceRequest
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public long? <SubRoomId>k__BackingField;    // 0x0x18
    public KeepsakeCategory <KeepsakeCategory>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.AddOrRemovePlayerRoomInventoryItemCountResponseDTO
//   (not directly referenced by a detected call)
public class AddOrRemovePlayerRoomInventoryItemCountResponseDTO
{
    public PlayerRoomInventoryOperationResult <Result>k__BackingField;    // 0x0x10
    public PlayerRoomInventoryItemDTO <PlayerRoomInventoryItem>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AddOrRemovePlayerRoomInventoryRequestDTO
//   (not directly referenced by a detected call)
public class AddOrRemovePlayerRoomInventoryRequestDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public Guid <RoomInventoryItemOriginId>k__BackingField;    // 0x0x18
    public long <Quantity>k__BackingField;    // 0x0x28
    public ConcurrencyCodePairDTO <ConcurrencyCodes>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AddVersionInventionRequestDTO
//   REQUEST  POST   api/inventions/v2/mine   [Service.API]
//   REQUEST  POST   api/inventions/v8/addversion   [Service.Notifications]
public class AddVersionInventionRequestDTO
{
    public long <inventionId>k__BackingField;    // 0x0x10
    public bool <hasBetaContent>k__BackingField;    // 0x0x18
    public int <instantiationCost>k__BackingField;    // 0x0x1C
    public int <lightsCost>k__BackingField;    // 0x0x20
    public int <chipsCost>k__BackingField;    // 0x0x24
    public int <cloudVariablesCost>k__BackingField;    // 0x0x28
    public int <aiCost>k__BackingField;    // 0x0x2C
    public byte <ugcVersion>k__BackingField;    // 0x0x30
    public long <creationRoomId>k__BackingField;    // 0x0x38
    public string <inventionDataFilename>k__BackingField;    // 0x0x40
    public List<long> <referencedInventions>k__BackingField;    // 0x0x48
    public IReadOnlyList<Guid> <referencedUnityAssetIds>k__BackingField;    // 0x0x50
    public ModifyTagsRequest <tagsRequest>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.AnnouncementDTO
//   (not directly referenced by a detected call)
public class AnnouncementDTO
{
    public long <AnnouncementId>k__BackingField;    // 0x0x10
    public AnnouncementType <AnnouncementType>k__BackingField;    // 0x0x18
    public string <Title>k__BackingField;    // 0x0x20
    public string <Body>k__BackingField;    // 0x0x28
    public string <ImageName>k__BackingField;    // 0x0x30
    public ContentBlockLinkType <LinkType>k__BackingField;    // 0x0x38
    public string <LinkName>k__BackingField;    // 0x0x40
    public string <LinkButtonLabel>k__BackingField;    // 0x0x48
    public string <LinkUri>k__BackingField;    // 0x0x50
    public PlatformMask <PlatformMask>k__BackingField;    // 0x0x58
    public PlatformType <Platform>k__BackingField;    // 0x0x5C
    public DateTime <CreatedAt>k__BackingField;    // 0x0x60
    public AnnouncementStatus <AnnouncementStatus>k__BackingField;    // 0x0x68
    public bool <IsMostRecent>k__BackingField;    // 0x0x6C
}

// --------------------------------------------------------------------------
// RecNet.AnnouncementIdDTO
//   (not directly referenced by a detected call)
public class AnnouncementIdDTO
{
    public long <AnnouncementId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AppleMusicPromotionResponseDTO
//   RESPONSE GET    api/apple/musicpromotion/code   [Service.API]
public class AppleMusicPromotionResponseDTO
{
    public Results <Result>k__BackingField;    // 0x0x10
    public string <Code>k__BackingField;    // 0x0x18
    public string <Url>k__BackingField;    // 0x0x20
    public string <RedemptionUrl>k__BackingField;    // 0x0x28
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
// RecNet.AvatarItemDetails
//   RESPONSE GET    api/avatar/v1/defaultbaseavataritems   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/defaultunlocked   [Service.Econ]
//   RESPONSE GET    api/avatar/v1/lockeditems   [Service.Econ]
//   RESPONSE POST   api/avatar/v1/lockeditems/bulk   [Service.Econ]
//   RESPONSE GET    api/avatar/v4/items   [Service.Econ]
public class AvatarItemDetails
{
    public AvatarItemType <AvatarItemType>k__BackingField;    // 0x0x10
    public string <AvatarItemDescString>k__BackingField;    // 0x0x18
    public string <FriendlyName>k__BackingField;    // 0x0x20
    public string <Tooltip>k__BackingField;    // 0x0x28
    public GiftRarity <Rarity>k__BackingField;    // 0x0x30
    public string <TagList>k__BackingField;    // 0x0x38
    public int <AvatarItemId>k__BackingField;    // 0x0x40
    public bool <IsBaseAvatarItem>k__BackingField;    // 0x0x44
    public string <ThumbnailImage>k__BackingField;    // 0x0x48
    public DateTime <CreatedAt>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.AvatarItemType
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum AvatarItemType
{
    Outfit = 0,
    HairDye = 1,
    CustomOutfit = 2,
}

// --------------------------------------------------------------------------
// RecNet.AwardCurrencyBulkResponse
//   (not directly referenced by a detected call)
public class AwardCurrencyBulkResponse
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public Guid <CurrencyId>k__BackingField;    // 0x0x14
    public bool <Success>k__BackingField;    // 0x0x24
    public string <Error>k__BackingField;    // 0x0x28
    public AwardCurrencyResponse <Response>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AwardCurrencyRequest
//   (not directly referenced by a detected call)
public class AwardCurrencyRequest
{
    public Guid <CurrencyId>k__BackingField;    // 0x0x10
    public int <RecipientId>k__BackingField;    // 0x0x20
    public long <Amount>k__BackingField;    // 0x0x28
    public Guid <TransactionId>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.AwardCurrencyResponse
//   (not directly referenced by a detected call)
public class AwardCurrencyResponse
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public Guid <CurrencyId>k__BackingField;    // 0x0x14
    public long <Balance>k__BackingField;    // 0x0x28
    public long <AmountAwarded>k__BackingField;    // 0x0x30
    public DateTime <AwardedAt>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.AwardRoomConsumableBulkRequest
//   REQUEST  POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class AwardRoomConsumableBulkRequest
{
    public Dictionary<Guid, AwardRoomConsumableRequest> <Requests>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AwardRoomConsumableRequest
//   (not directly referenced by a detected call)
public class AwardRoomConsumableRequest
{
    public int <Quantity>k__BackingField;    // 0x0x10
    public RoomConsumableConcurrencyCodes <ConcurrencyCodes>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AwardRoomKeyRequest
//   REQUEST  POST   api/roomkeys/v1/awardbulk   [Service.Econ]
public class AwardRoomKeyRequest
{
    public long <RoomKeyId>k__BackingField;    // 0x0x10
    public int <AccountId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AwardRoomKeyRequestDummyDTO
//   (not directly referenced by a detected call)
public class AwardRoomKeyRequestDummyDTO
{
    public IEnumerable<AwardRoomKeyRequest> <items>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.AwardRoomKeyResponse
//   (not directly referenced by a detected call)
public class AwardRoomKeyResponse
{
    public long <RoomKeyId>k__BackingField;    // 0x0x10
    public int <AccountId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.AzureSpeechConfig
//   RESPONSE GET    api/config/v1/azurespeech   [Service.API]
public class AzureSpeechConfig
{
    public bool <Enabled>k__BackingField;    // 0x0x10
    public string <Key>k__BackingField;    // 0x0x18
    public string <Region>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.BacktraceConfigDTO
//   RESPONSE GET    api/config/v1/backtrace   [Service.API]
public class BacktraceConfigDTO
{
    public int <ReportBudget>k__BackingField;    // 0x0x10
    public int <FilterType>k__BackingField;    // 0x0x14
    public float <SampleRate>k__BackingField;    // 0x0x18
    public int <LogLineCount>k__BackingField;    // 0x0x1C
    public int <CaptureNativeCrashes>k__BackingField;    // 0x0x20
    public int <ANRThresholdMs>k__BackingField;    // 0x0x24
    public int <MessageCount>k__BackingField;    // 0x0x28
    public string <MessageRegex>k__BackingField;    // 0x0x30
    public string <VersionRegex>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceResponseDTO
{
    public long <Balance>k__BackingField;    // 0x0x10
    public CurrencyType <CurrencyType>k__BackingField;    // 0x0x18
    public StorefrontBalanceType <BalanceType>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO
// base   : RecNet.BalanceUpdateResponseDTO`1<RecNet.BulkPurchaseItemsBalanceUpdateResponseDataDTO>
//   (not directly referenced by a detected call)
public class BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.BalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class BalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<RDAQZEYYGSP<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
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
// RecNet.BrazeConfigDTO
//   (not directly referenced by a detected call)
public class BrazeConfigDTO
{
    public string <AppId>k__BackingField;    // 0x0x10
    public string <SdkEndpoint>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.BugReporting.ADOBugDTO
//   (not directly referenced by a detected call)
public class ADOBugDTO
{
    public long <Id>k__BackingField;    // 0x0x10
    public string <Link>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.BugReporting.ReportClientInformationDTO
//   (not directly referenced by a detected call)
public class ReportClientInformationDTO
{
    public ReportTriggerType <TriggerType>k__BackingField;    // 0x0x10
    public ReportCategory <Category>k__BackingField;    // 0x0x14
    public Guid <TriggerId>k__BackingField;    // 0x0x18
    public DateTime <TriggeredAt>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BugReporting.ReportRequestDTO
//   (not directly referenced by a detected call)
public class ReportRequestDTO
{
    public Guid <ReportId>k__BackingField;    // 0x0x10
    public ReportClientInformationDTO <Client>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.BugReporting.ReportUserInformationDTO
//   (not directly referenced by a detected call)
public class ReportUserInformationDTO
{
    public string <Title>k__BackingField;    // 0x0x10
    public string <Description>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.BulkPurchaseItemRequestDTO
//   REQUEST  POST   api/items/bulkpurchase   [Service.Commerce]
public class BulkPurchaseItemRequestDTO
{
    public List<PurchaseItemRequestDTO> <PurchaseItemRequests>k__BackingField;    // 0x0x10
    public StorefrontTypes? <StorefrontType>k__BackingField;    // 0x0x18
    public CurrencyType <CurrencyType>k__BackingField;    // 0x0x20
    public bool <BypassGiftPackages>k__BackingField;    // 0x0x24
    public bool <AllowPartialSuccess>k__BackingField;    // 0x0x25
    public Guid? <ShoppingBagId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.BulkPurchaseItemsBalanceUpdateResponseDataDTO
//   (not directly referenced by a detected call)
public class BulkPurchaseItemsBalanceUpdateResponseDataDTO
{
    public GiftPackage <GiftPackage>k__BackingField;    // 0x0x10
    public int? <PurchasableItemId>k__BackingField;    // 0x0x18
    public CustomAvatarItem <CustomAvatarItem>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ChatPrivacySettingDTO
//   (not directly referenced by a detected call)
public class ChatPrivacySettingDTO
{
    public int <PlayerId>k__BackingField;    // 0x0x10
    public DirectMessagePrivacySettingOption <DirectMessagePrivacySetting>k__BackingField;    // 0x0x14
    public GroupChatPrivacySettingOption <GroupChatPrivacySetting>k__BackingField;    // 0x0x15
}

// --------------------------------------------------------------------------
// RecNet.CheerRequest
//   REQUEST  POST   api/inventions/v2/cheer   [Service.API]
public class CheerRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public bool <Cheer>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ClientJoinDataDTO
//   (not directly referenced by a detected call)
public class ClientJoinDataDTO
{
    public string <WelcomeMatName>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ClubMembershipRequest
//   (not directly referenced by a detected call)
public class ClubMembershipRequest
{
    public long <MembershipRequestId>k__BackingField;    // 0x0x10
    public int <AccountId>k__BackingField;    // 0x0x18
    public int? <InviterAccountId>k__BackingField;    // 0x0x1C
    public long <ClubId>k__BackingField;    // 0x0x28
    public ClubMembershipType <MembershipType>k__BackingField;    // 0x0x30
    public MembershipStatus <MembershipStatus>k__BackingField;    // 0x0x34
    public DateTime <CreatedAt>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.ClubMembershipRequestSearchResult
//   (not directly referenced by a detected call)
public class ClubMembershipRequestSearchResult
{
    public List<ClubMembershipRequest> <MembershipRequests>k__BackingField;    // 0x0x10
    public int <TotalMembershipRequests>k__BackingField;    // 0x0x18
    public string <ContinuationToken>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ClubMembershipSearchResult
//   (not directly referenced by a detected call)
public class ClubMembershipSearchResult
{
    public List<ClubMembership> <Memberships>k__BackingField;    // 0x0x10
    public int <TotalMemberships>k__BackingField;    // 0x0x18
    public string <ContinuationToken>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ClubSearchResult
//   (not directly referenced by a detected call)
public class ClubSearchResult
{
    public List<Club> <Clubs>k__BackingField;    // 0x0x10
    public int <TotalClubs>k__BackingField;    // 0x0x18
    public string <ContinuationToken>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ClubhouseRoomSummaryDTO
//   (not directly referenced by a detected call)
public class ClubhouseRoomSummaryDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public long <ClubId>k__BackingField;    // 0x0x18
    public int <PlayerCount>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.CoOwnerSetCurrencyBalanceRequest
//   REQUEST  POST   api/roomcurrencies   [Service.Econ]
//   REQUEST  POST   api/roomcurrencies/v1/{roomCurrencyId}/setBalance   [Service.Econ]
public class CoOwnerSetCurrencyBalanceRequest
{
    public Guid <TransactionId>k__BackingField;    // 0x0x10
    public long <NewBalance>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ConcurrencyCodePairDTO
//   (not directly referenced by a detected call)
public class ConcurrencyCodePairDTO
{
    public Guid? <CurrentConcurrencyCode>k__BackingField;    // 0x0x10
    public Guid <NewConcurrencyCode>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.AnimationCurveConfigDTO
//   (not directly referenced by a detected call)
public class AnimationCurveConfigDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public Guid <Id>k__BackingField;    // 0x0x18
    public AnimationCurveDTO <AnimationCurve>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.AnimationCurveDTO
//   (not directly referenced by a detected call)
public class AnimationCurveDTO
{
    public List<AnimationCurveKeyDTO> <CurveKeys>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.AnimationCurveKeyDTO
//   (not directly referenced by a detected call)
public class AnimationCurveKeyDTO
{
    public float <Time>k__BackingField;    // 0x0x10
    public float <Value>k__BackingField;    // 0x0x14
    public float <InSlope>k__BackingField;    // 0x0x18
    public float <OutSlope>k__BackingField;    // 0x0x1C
    public float <InWeight>k__BackingField;    // 0x0x20
    public float <OutWeight>k__BackingField;    // 0x0x24
    public int <TangentMode>k__BackingField;    // 0x0x28
    public int <WeightedMode>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.AuraConfigDTO
//   (not directly referenced by a detected call)
public class AuraConfigDTO
{
    public Guid <Id>k__BackingField;    // 0x0x10
    public int <AuraId>k__BackingField;    // 0x0x20
    public string <TextureName>k__BackingField;    // 0x0x28
    public ColorConfig <Color>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.AvatarEffectConfigDTO
//   (not directly referenced by a detected call)
public class AvatarEffectConfigDTO
{
    public List<AvatarEffectKeyDTO> <AvailableEffects>k__BackingField;    // 0x0x10
    public List<PotionBottleConfigDTO> <PotionBottleOverrides>k__BackingField;    // 0x0x18
    public List<DriverTypeBottleConfigDTO> <DriverTypeConfigs>k__BackingField;    // 0x0x20
    public List<AuraConfigDTO> <AuraConfigs>k__BackingField;    // 0x0x28
    public List<GradientConfigDTO> <GradientConfigs>k__BackingField;    // 0x0x30
    public List<AnimationCurveConfigDTO> <AnimationCurveConfigs>k__BackingField;    // 0x0x38
    public List<TextureEffectDTO> <TextureEffectConfigs>k__BackingField;    // 0x0x40
    public List<PlayerScaleEffectDTO> <PlayerScaleEffectConfigs>k__BackingField;    // 0x0x48
    public DriverConfigDTO <PlayerVelocityDriverConfig>k__BackingField;    // 0x0x50
    public DriverConfigDTO <PlayerVoiceVolumeDriverConfig>k__BackingField;    // 0x0x58
    public DriverConfigDTO <PlayerHighFivesDriverConfig>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.AvatarEffectKeyDTO
//   (not directly referenced by a detected call)
public class AvatarEffectKeyDTO
{
    public AvatarItemEffectChannel <EffectChannel>k__BackingField;    // 0x0x10
    public DriverType <DriverType>k__BackingField;    // 0x0x11
    public Guid <DriverConfigKey>k__BackingField;    // 0x0x14
    public Guid <ApplierConfigKey>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.DriverConfigDTO
//   (not directly referenced by a detected call)
public class DriverConfigDTO
{
    public DriverType <Id>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public AnimationCurveDTO <AnimationCurve>k__BackingField;    // 0x0x20
    public float <ValueAttackRate>k__BackingField;    // 0x0x28
    public float <ValueDecayRate>k__BackingField;    // 0x0x2C
    public float <EffectOverdrive>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.DriverTypeBottleConfigDTO
//   (not directly referenced by a detected call)
public class DriverTypeBottleConfigDTO
{
    public DriverType <DriverType>k__BackingField;    // 0x0x10
    public string <TextureName>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.GradientConfigDTO
//   (not directly referenced by a detected call)
public class GradientConfigDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public Guid <Id>k__BackingField;    // 0x0x18
    public float <GradientTime>k__BackingField;    // 0x0x28
    public GradientType <GradientType>k__BackingField;    // 0x0x2C
    public List<GradientKeyDTO> <ColorKeys>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.GradientKeyDTO
//   (not directly referenced by a detected call)
public class GradientKeyDTO
{
    public float <Time>k__BackingField;    // 0x0x10
    public ColorConfig <Color>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.PlayerScaleEffectDTO
//   (not directly referenced by a detected call)
public class PlayerScaleEffectDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public Guid <Id>k__BackingField;    // 0x0x18
    public AnimationCurveDTO <RemapCurve>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.PotionBottleConfigDTO
//   (not directly referenced by a detected call)
public class PotionBottleConfigDTO
{
    public AvatarEffectKeyDTO <Key>k__BackingField;    // 0x0x10
    public string <BottleTextureName>k__BackingField;    // 0x0x18
    public ColorConfig <LiquidColor>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.RemapConfigDTO
//   (not directly referenced by a detected call)
public class RemapConfigDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public Guid <Id>k__BackingField;    // 0x0x18
    public float <MinRemappedValue>k__BackingField;    // 0x0x28
    public float <MinRemappedNormalValue>k__BackingField;    // 0x0x2C
    public float <MaxRemappedNormalValue>k__BackingField;    // 0x0x30
    public float <MaxRemappedValue>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.TextureChannelDTO
//   (not directly referenced by a detected call)
public class TextureChannelDTO
{
    public Vector2Dto <Scroll>k__BackingField;    // 0x0x10
    public float <ColorIntensity>k__BackingField;    // 0x0x18
    public float <AlphaIntensity>k__BackingField;    // 0x0x1C
    public Vector4Dto <ST>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ConsumableEffects.AvatarItemEffects.TextureEffectDTO
//   (not directly referenced by a detected call)
public class TextureEffectDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public Guid <Id>k__BackingField;    // 0x0x18
    public string <MaskTextureName>k__BackingField;    // 0x0x28
    public string <LUTTextureName>k__BackingField;    // 0x0x30
    public bool <UseNormalFade>k__BackingField;    // 0x0x38
    public float <GlobalIntensity>k__BackingField;    // 0x0x3C
    public TextureChannelDTO <Vfx1>k__BackingField;    // 0x0x40
    public TextureChannelDTO <Vfx2>k__BackingField;    // 0x0x48
    public TextureChannelDTO <Vfx3>k__BackingField;    // 0x0x50
    public TextureChannelDTO <Vfx4>k__BackingField;    // 0x0x58
    public Vector4Dto <LUT_ST>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// RecNet.ConsumableInstanceDTO
//   (not directly referenced by a detected call)
public class ConsumableInstanceDTO
{
    public long <InstanceId>k__BackingField;    // 0x0x10
    public string <ConsumableItemDesc>k__BackingField;    // 0x0x18
    public DateTime <CreatedAt>k__BackingField;    // 0x0x20
    public int <Count>k__BackingField;    // 0x0x28
    public int? <ActiveDurationMinutes>k__BackingField;    // 0x0x2C
    public bool <IsActive>k__BackingField;    // 0x0x34
    public bool <IsTransferable>k__BackingField;    // 0x0x35
    public bool <ActivatedByRoomie>k__BackingField;    // 0x0x36
    public bool <IsRRO>k__BackingField;    // 0x0x37
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
// RecNet.CreateCustomConsumableResponseDTO
//   (not directly referenced by a detected call)
public class CreateCustomConsumableResponseDTO
{
    public long <ConsumableItemId>k__BackingField;    // 0x0x10
    public string <ConsumableItemDesc>k__BackingField;    // 0x0x18
    public string <FriendlyName>k__BackingField;    // 0x0x20
    public string <ThumbnailImageName>k__BackingField;    // 0x0x28
    public int <ConfigurationVersion>k__BackingField;    // 0x0x30
    public int <RoomieCategory>k__BackingField;    // 0x0x34
    public string <ConsumableToolName>k__BackingField;    // 0x0x38
    public string <ConfigurationDataString>k__BackingField;    // 0x0x40
    public DateTime <CreatedAt>k__BackingField;    // 0x0x48
    public ConsumableConfigurationData <ConfigurationData>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.CreatorClubSubscriptionDTO
//   (not directly referenced by a detected call)
public class CreatorClubSubscriptionDTO
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public long <ClubId>k__BackingField;    // 0x0x18
    public int <SubscriberCount>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.CrmAssignmentDTO
//   (not directly referenced by a detected call)
public class CrmAssignmentDTO
{
    public CrmUserDTO <UserConfig>k__BackingField;    // 0x0x10
    public BrazeConfigDTO <BrazeConfig>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.CrmUserDTO
//   (not directly referenced by a detected call)
public class CrmUserDTO
{
    public CrmType <AssignedCrmType>k__BackingField;    // 0x0x10
    public PushNotificationServices? <AssignedPushNotificationService>k__BackingField;    // 0x0x14
    public bool <AllowPush>k__BackingField;    // 0x0x16
}

// --------------------------------------------------------------------------
// RecNet.CurrencyBalance
//   RESPONSE GET    api/roomcurrencies/v1/getBalance   [Service.Econ]
public class CurrencyBalance
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public Guid <CurrencyId>k__BackingField;    // 0x0x14
    public long <Balance>k__BackingField;    // 0x0x28
    public DateTime <ModifiedAt>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.CurrencyBalanceUpdateResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CurrencyBalanceUpdateResult
{
    Success = 0,
    NotEnoughCredit = 1,
}

// --------------------------------------------------------------------------
// RecNet.CurrencyIdDTO
//   (not directly referenced by a detected call)
public class CurrencyIdDTO
{
    public Guid <CurrencyId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.CurrencyType
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CurrencyType
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
    RoomieCredits = 500,
    PaintballPaint = 600,
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItem
//   (not directly referenced by a detected call)
public class CustomAvatarItem
{
    public Guid <CustomAvatarItemId>k__BackingField;    // 0x0x10
    public int <CreatorAccountId>k__BackingField;    // 0x0x20
    public string <Name>k__BackingField;    // 0x0x28
    public string <Description>k__BackingField;    // 0x0x30
    public int <Price>k__BackingField;    // 0x0x38
    public UgcAccessibility <Accessibility>k__BackingField;    // 0x0x3C
    public bool <ForceCannotPublish>k__BackingField;    // 0x0x40
    public bool <IsFeatured>k__BackingField;    // 0x0x41
    public bool <IsRecRoomApproved>k__BackingField;    // 0x0x42
    public int? <BaseAvatarItemId>k__BackingField;    // 0x0x44
    public string <BaseAvatarItemColor>k__BackingField;    // 0x0x50
    public string <DesignFilename>k__BackingField;    // 0x0x58
    public string <ThumbnailImageFilename>k__BackingField;    // 0x0x60
    public DateTime <CreatedAt>k__BackingField;    // 0x0x68
    public DateTime <ModifiedAt>k__BackingField;    // 0x0x70
    public CustomAvatarItemPreviewOrientation <PreviewOrientation>k__BackingField;    // 0x0x78
    public string <RankingContext>k__BackingField;    // 0x0x80
    public int <OutfitType>k__BackingField;    // 0x0x88
    public IReadOnlyList<CustomAvatarItemSaveDTO> <CurrentSaves>k__BackingField;    // 0x0x90
    public ItemPurchaseInfoDTO <PurchaseInfo>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemBalanceModificationResponse
// base   : RecNet.ULGJLKTOJIK`1<RecNet.CustomAvatarItem>
//   (not directly referenced by a detected call)
public class CustomAvatarItemBalanceModificationResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemCreateRequest
//   REQUEST  POST   api/customAvatarItems/v1   [Service.API]
public class CustomAvatarItemCreateRequest
{
    public string <Name>k__BackingField;    // 0x0x10
    public string <Description>k__BackingField;    // 0x0x18
    public int <Price>k__BackingField;    // 0x0x20
    public int? <BaseAvatarItemId>k__BackingField;    // 0x0x24
    public string <BaseAvatarItemColor>k__BackingField;    // 0x0x30
    public UgcAccessibility <Accessibility>k__BackingField;    // 0x0x38
    public CustomAvatarItemPreviewOrientation? <PreviewOrientation>k__BackingField;    // 0x0x3C
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemDesign
//   RESPONSE GET    api/customAvatarItems/v1/design   [Service.API]
public class CustomAvatarItemDesign
{
    public int <CreatorAccountId>k__BackingField;    // 0x0x10
    public int? <BaseAvatarItemId>k__BackingField;    // 0x0x14
    public string <DesignFilename>k__BackingField;    // 0x0x20
    public string <BaseAvatarItemColor>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemDesignRequest
//   REQUEST  PUT    api/customAvatarItems/v1/design   [Service.API]
public class CustomAvatarItemDesignRequest
{
    public int? <BaseAvatarItemId>k__BackingField;    // 0x0x10
    public string <BaseAvatarItemColor>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemPreviewOrientation
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum CustomAvatarItemPreviewOrientation
{
    Front = 0,
    Back = 1,
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemPricingConfigDTO
//   RESPONSE GET    api/customAvatarItems/v1/pricingconfig   [Service.API]
public class CustomAvatarItemPricingConfigDTO
{
    public int <MinimumPriceInTokens>k__BackingField;    // 0x0x10
    public int <MaximumPriceInTokens>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemPurchaseRequest
//   (not directly referenced by a detected call)
public class CustomAvatarItemPurchaseRequest
{
    public int <RequestedPrice>k__BackingField;    // 0x0x10
    public int? <RecipientAccountId>k__BackingField;    // 0x0x14
    public string <Message>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemReportRequest
//   REQUEST  POST   api/customAvatarItems   [Service.API]
//   REQUEST  POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
public class CustomAvatarItemReportRequest
{
    public UgcReportCategory <ReportCategory>k__BackingField;    // 0x0x10
    public string <Details>k__BackingField;    // 0x0x18
    public int? <ReportedPlayerId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemSaveDTO
//   (not directly referenced by a detected call)
public class CustomAvatarItemSaveDTO
{
    public long <CustomAvatarItemSaveId>k__BackingField;    // 0x0x10
    public Guid <CustomAvatarItemId>k__BackingField;    // 0x0x18
    public Guid <UnityAssetId>k__BackingField;    // 0x0x28
    public DateTime <CreatedAt>k__BackingField;    // 0x0x38
    public string <ThumbnailFileName>k__BackingField;    // 0x0x40
    public string <AdditionalConfiguration>k__BackingField;    // 0x0x48
    public int <BodyType>k__BackingField;    // 0x0x50
    public string <UnityAsset>k__BackingField;    // 0x0x58
    public string <UnityAssetHash>k__BackingField;    // 0x0x60
    public string <UnityAsset2>k__BackingField;    // 0x0x68
    public string <UnityAsset2Hash>k__BackingField;    // 0x0x70
    public int <OutfitType>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemSet
//   RESPONSE GET    api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/{customAvatarItemId}/itemset   [Service.API]
public class CustomAvatarItemSet
{
    public string <Name>k__BackingField;    // 0x0x10
    public long <CreatorAccountId>k__BackingField;    // 0x0x18
    public List<CustomAvatarItem> <CustomAvatarItems>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.CustomAvatarItemUpdateRequest
//   REQUEST  PUT    api/customAvatarItems   [Service.API]
//   REQUEST  PUT    api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
public class CustomAvatarItemUpdateRequest
{
    public string <Name>k__BackingField;    // 0x0x10
    public string <Description>k__BackingField;    // 0x0x18
    public int? <Price>k__BackingField;    // 0x0x20
    public UgcAccessibility? <Accessibility>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.DataAPI.UserSegmentDTO
//   (not directly referenced by a detected call)
public class UserSegmentDTO
{
    public string <user_segment_algo_name>k__BackingField;    // 0x0x10
    public string <user_segment_algo_version>k__BackingField;    // 0x0x18
    public string <user_id>k__BackingField;    // 0x0x20
    public string <user_segment_value>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.DataLinkDTO
//   (not directly referenced by a detected call)
public class DataLinkDTO
{
    public string <Data>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.DebugCommandDTO
//   (not directly referenced by a detected call)
public class DebugCommandDTO
{
    public string <Command>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.DeleteInventionRequest
//   REQUEST  POST   api/inventions/v2/delete   [Service.API]
public class DeleteInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.DeleteMessagesRequestDTO
//   REQUEST  POST   api/messages/v3/delete   [Service.Data]
public class DeleteMessagesRequestDTO
{
    public List<long> <MessageIds>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Discovery.GenreRoomsDTO
//   (not directly referenced by a detected call)
public class GenreRoomsDTO
{
    public List<long> <JoinOrCreateRooms>k__BackingField;    // 0x0x10
    public List<long> <JoinOnlyRooms>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Discovery.SectionDTO
//   (not directly referenced by a detected call)
public class SectionDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public SectionType <SectionType>k__BackingField;    // 0x0x18
    public string <Source>k__BackingField;    // 0x0x20
    public string <SourceMetadata>k__BackingField;    // 0x0x28
    public string <DisplayMetadata>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.DoesPlayerOwnRoomKeyRequest
//   (not directly referenced by a detected call)
public class DoesPlayerOwnRoomKeyRequest
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public long <RoomKeyId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.DoesPlayerOwnRoomKeyRequestDummyDTO
//   (not directly referenced by a detected call)
public class DoesPlayerOwnRoomKeyRequestDummyDTO
{
    public IReadOnlyList<DoesPlayerOwnRoomKeyRequest> <items>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.DoesPlayerOwnRoomKeyResult
//   (not directly referenced by a detected call)
public class DoesPlayerOwnRoomKeyResult
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public long <RoomKeyId>k__BackingField;    // 0x0x18
    public bool <DoesPlayerOwnRoomKey>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ETIXNOOFYJG
//   (not directly referenced by a detected call)
public class ETIXNOOFYJG
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.BattlePassAccountProgressDTO
//   (not directly referenced by a detected call)
public class BattlePassAccountProgressDTO
{
    public long <BattlePassId>k__BackingField;    // 0x0x10
    public int <AccountId>k__BackingField;    // 0x0x18
    public int <Xp>k__BackingField;    // 0x0x1C
    public bool <IsPurchased>k__BackingField;    // 0x0x20
    public int <DailyParticipationBonusCount>k__BackingField;    // 0x0x24
    public DateTime? <BoostedUntil>k__BackingField;    // 0x0x28
    public DateTime? <CompletionDate>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.BattlePassDTO
//   (not directly referenced by a detected call)
public class BattlePassDTO
{
    public long <BattlePassId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public DateTime <StartTime>k__BackingField;    // 0x0x20
    public DateTime <EndTime>k__BackingField;    // 0x0x28
    public IReadOnlyList<BattlePassLevelDTO> <Levels>k__BackingField;    // 0x0x30
    public IReadOnlyDictionary<BattlePassEvent, int> <EventXP>k__BackingField;    // 0x0x38
    public int <DailyParticipationBonusLimit>k__BackingField;    // 0x0x40
    public int <MinimumParticipationTimeInSeconds>k__BackingField;    // 0x0x44
    public IReadOnlyList<BattlePassSkuDTO> <PurchasableSkus>k__BackingField;    // 0x0x48
    public int <PermanentBoostTokenPrice>k__BackingField;    // 0x0x50
    public BattlePassLimitedTimeRewardDTO <LimitedTimeReward>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.BattlePassLevelDTO
//   (not directly referenced by a detected call)
public class BattlePassLevelDTO
{
    public int <XpRequired>k__BackingField;    // 0x0x10
    public IReadOnlyList<int> <RewardGiftDropIds>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.BattlePassLimitedTimeRewardDTO
//   (not directly referenced by a detected call)
public class BattlePassLimitedTimeRewardDTO
{
    public DateTime <CompletionDeadline>k__BackingField;    // 0x0x10
    public IReadOnlyList<int> <GiftDropIds>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.BattlePassSkuDTO
//   (not directly referenced by a detected call)
public class BattlePassSkuDTO
{
    public int <BattlePassSkuId>k__BackingField;    // 0x0x10
    public int <TokenPrice>k__BackingField;    // 0x0x14
    public int <BonusLevels>k__BackingField;    // 0x0x18
    public bool <PermanentBoost>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.PurchaseBattlePassPermanentBoostRequestDTO
//   (not directly referenced by a detected call)
public class PurchaseBattlePassPermanentBoostRequestDTO
{
    public int <RequestedPrice>k__BackingField;    // 0x0x10
    public int? <ToAccountId>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.PurchaseBattlePassRequestDTO
//   (not directly referenced by a detected call)
public class PurchaseBattlePassRequestDTO
{
    public int <BattlePassSkuId>k__BackingField;    // 0x0x10
    public int? <ToAccountId>k__BackingField;    // 0x0x14
    public int? <RequestedPrice>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.ReportBattlePassSessionRequestDTO
//   (not directly referenced by a detected call)
public class ReportBattlePassSessionRequestDTO
{
    public long <RoomInstanceId>k__BackingField;    // 0x0x10
    public DateTime <SessionStartTime>k__BackingField;    // 0x0x18
    public IReadOnlyDictionary<BattlePassEvent, int> <Events>k__BackingField;    // 0x0x20
    public IReadOnlyList<int> <TeammateAccountIds>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.Econ.BattlePass.ReportBattlePassSessionResponseDTO
//   (not directly referenced by a detected call)
public class ReportBattlePassSessionResponseDTO
{
    public BattlePassAccountProgressDTO <Progress>k__BackingField;    // 0x0x10
    public int <EventXpEarned>k__BackingField;    // 0x0x18
    public int <ParticipationBonusXpEarned>k__BackingField;    // 0x0x1C
    public int <BoostPercent>k__BackingField;    // 0x0x20
    public int <TeamBonusPercent>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.Events.BroadcastRoomInstanceRequest
//   REQUEST  POST   api/playerevents/v1/broadcast   [Service.API]
public class BroadcastRoomInstanceRequest
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
    public long? <BroadcastRoomInstanceId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.BulkInviteRequest
//   REQUEST  POST   api/playerevents/v1/bulkInvite   [Service.API]
public class BulkInviteRequest
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
    public List<int> <InvitedPlayerIds>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.BulkInviteResponse
//   RESPONSE POST   api/playerevents/v1/bulkInvite   [Service.API]
public class BulkInviteResponse
{
    public List<InviteResponse> <FailedInvites>k__BackingField;    // 0x0x10
    public CreateModifyPlayerEventStatus <Result>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.CreateModifyEventRequest
//   REQUEST  POST   api/playerevents/v2   [Service.API]
//   REQUEST  POST   api/playerevents/v2/{eventId}   [Service.API]
public class CreateModifyEventRequest
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public long? <SubRoomId>k__BackingField;    // 0x0x18
    public long? <ClubId>k__BackingField;    // 0x0x28
    public string <Name>k__BackingField;    // 0x0x38
    public string <Description>k__BackingField;    // 0x0x40
    public List<string> <Tags>k__BackingField;    // 0x0x48
    public string <ImageName>k__BackingField;    // 0x0x50
    public DateTime <StartTime>k__BackingField;    // 0x0x58
    public DateTime <EndTime>k__BackingField;    // 0x0x60
    public PlayerEventAccessibility <Accessibility>k__BackingField;    // 0x0x68
    public bool <IsMultiInstance>k__BackingField;    // 0x0x6C
    public bool <SupportMultiInstanceRoomChat>k__BackingField;    // 0x0x6D
    public PlayerEventBroadcastPermissionsMode <DefaultBroadcastPermissions>k__BackingField;    // 0x0x70
    public PlayerEventBroadcastPermissionsMode <CanRequestBroadcastPermissions>k__BackingField;    // 0x0x74
}

// --------------------------------------------------------------------------
// RecNet.Events.CreateModifyPlayerEventResponse
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
public class CreateModifyPlayerEventResponse
{
    public PlayerEventDetails <PlayerEvent>k__BackingField;    // 0x0x10
    public CreateModifyPlayerEventStatus <Result>k__BackingField;    // 0x0x18
    public ModifyTagsResponse <TagModifyResult>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Events.CreateModifyPlayerEventResult
//   RESPONSE POST   api/playerevents/v1/deleteResponse   [Service.API]
//   RESPONSE POST   api/playerevents/v1/respond   [Service.API]
public class CreateModifyPlayerEventResult
{
    public CreateModifyPlayerEventStatus <Result>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.DeleteResponseRequest
//   REQUEST  POST   api/playerevents/v1/deleteResponse   [Service.API]
public class DeleteResponseRequest
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.InviteResponse
//   (not directly referenced by a detected call)
public class InviteResponse
{
    public int <InvitedPlayerId>k__BackingField;    // 0x0x10
    public CreateModifyPlayerEventStatus <Result>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.Events.LocalPlayerEventInfo
//   RESPONSE GET    api/playerevents/v1/all   [Service.API]
//   RESPONSE GET    api/playerevents/v1/all/{eventId}   [Service.API]
public class LocalPlayerEventInfo
{
    public List<PlayerEvent> <Created>k__BackingField;    // 0x0x10
    public List<PlayerEventInformation> <Responses>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEvent
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class PlayerEvent
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
    public int <CreatorPlayerId>k__BackingField;    // 0x0x18
    public long <RoomId>k__BackingField;    // 0x0x20
    public long? <SubRoomId>k__BackingField;    // 0x0x28
    public long? <ClubId>k__BackingField;    // 0x0x38
    public string <Name>k__BackingField;    // 0x0x48
    public string <Description>k__BackingField;    // 0x0x50
    public string <ImageName>k__BackingField;    // 0x0x58
    public DateTime <StartTime>k__BackingField;    // 0x0x60
    public DateTime <EndTime>k__BackingField;    // 0x0x68
    public int <AttendeeCount>k__BackingField;    // 0x0x70
    public PlayerEventAccessibility <Accessibility>k__BackingField;    // 0x0x74
    public bool <IsMultiInstance>k__BackingField;    // 0x0x78
    public bool <SupportMultiInstanceRoomChat>k__BackingField;    // 0x0x79
    public PlayerEventBroadcastPermissionsMode <DefaultBroadcastPermissions>k__BackingField;    // 0x0x7C
    public PlayerEventBroadcastPermissionsMode <CanRequestBroadcastPermissions>k__BackingField;    // 0x0x80
    public long? <BroadcastingRoomInstanceId>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEventAccessibility
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PlayerEventAccessibility
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEventBroadcastPermissionsMode
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PlayerEventBroadcastPermissionsMode
{
    None = 0,
    RoomOwners = 256,
    All = 2147483647,
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEventDTOPage
//   RESPONSE GET    api/playerevents/v1/club/{clubId}   [Service.API]
public class PlayerEventDTOPage
{
    public List<PlayerEvent> <Events>k__BackingField;    // 0x0x10
    public string <ContinuationToken>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEventDetails
// base   : RecNet.Events.PlayerEvent
//   RESPONSE GET    api/playerevents/v1/{eventId}   [Service.API]
public class PlayerEventDetails : PlayerEvent
{
    public List<TagDTO> <Tags>k__BackingField;    // 0x0x98
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEventIdDTO
//   (not directly referenced by a detected call)
public class PlayerEventIdDTO
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEventInformation
//   (not directly referenced by a detected call)
public class PlayerEventInformation
{
    public PlayerEvent <PlayerEvent>k__BackingField;    // 0x0x10
    public PlayerEventResponse <PlayerEventResponse>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEventReportRequest
//   REQUEST  POST   api/playerevents/v1/report   [Service.API]
public class PlayerEventReportRequest
{
    public ReportCategory <ReportCategory>k__BackingField;    // 0x0x10
    public long <PlayerEventId>k__BackingField;    // 0x0x18
    public string <Details>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Events.PlayerEventResponse
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
// RecNet.Events.PlayerEventResponseRequest
//   REQUEST  POST   api/playerevents/v1/respond   [Service.API]
public class PlayerEventResponseRequest
{
    public long <PlayerEventId>k__BackingField;    // 0x0x10
    public PlayerEventResponseType <Type>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.FavoriteChatResponse
//   (not directly referenced by a detected call)
public class FavoriteChatResponse
{
    public ChatResults <ChatResult>k__BackingField;    // 0x0x10
    public bool <IsFavorited>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.FilteredTextDTO
//   (not directly referenced by a detected call)
public class FilteredTextDTO
{
    public string <Text>k__BackingField;    // 0x0x10
    public int <NumBadWords>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.GetCustomAvatarItemCurrentSavesForCustomAvatarItemIdsResponse
//   (not directly referenced by a detected call)
public class GetCustomAvatarItemCurrentSavesForCustomAvatarItemIdsResponse
{
    public Dictionary<Guid, List<CustomAvatarItemSaveDTO>> <CustomAvatarItemSavesByCustomAvatarItemId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescsResponse
//   (not directly referenced by a detected call)
public class GetCustomAvatarItemCurrentSavesForLegacyAvatarItemDescsResponse
{
    public Dictionary<string, List<CustomAvatarItemSaveDTO>> <CustomAvatarItemSavesByAvatarItemDesc>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.GetInfluencersResponse
//   RESPONSE GET    api/influencerpartnerprogram/influencers   [Service.Econ]
public class GetInfluencersResponse
{
    public List<int> <InfluencerIds>k__BackingField;    // 0x0x10
    public string <ContinuationToken>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.GetItemPurchaseInfosRequestDTO
//   REQUEST  POST   api/items/purchaseInfos   [Service.Econ]
public class GetItemPurchaseInfosRequestDTO
{
    public IReadOnlyList<UGCPurchasableItemIdentifier> <Ids>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.GetLockedAvatarItemDetailsBulkAsPostRequest
//   REQUEST  POST   api/avatar/v1/lockeditems/bulk   [Service.Econ]
public class GetLockedAvatarItemDetailsBulkAsPostRequest
{
    public List<string> <AvatarItemDescriptions>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.GetNearbyScoresRequestDTO
// base   : RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetNearbyScoresRequestDTO : GetRankRequestDTO
{
    public int <WindowSize>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.GetPlayersOutfitsRequestDTO
//   (not directly referenced by a detected call)
public class GetPlayersOutfitsRequestDTO
{
    public List<int> <AccountIds>k__BackingField;    // 0x0x10
    public byte? <UnityAssetTarget>k__BackingField;    // 0x0x18
    public int? <UnityAssetVersion>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.GetPlayersOutfitsResponseDTO
//   (not directly referenced by a detected call)
public class GetPlayersOutfitsResponseDTO
{
    public Dictionary<int, OutfitDTO> <OutfitsByAccountId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetRankRequestDTO
{
    public int <PlayerId>k__BackingField;    // 0x0x10
    public long? <PrimaryKey>k__BackingField;    // 0x0x18
    public int? <SecondaryKey>k__BackingField;    // 0x0x28
    public FilterType <FilterType>k__BackingField;    // 0x0x30
    public bool <SortAscending>k__BackingField;    // 0x0x34
    public LeaderboardType <LeaderboardType>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.GetRanksRequestDTO
// base   : RecNet.GetRankRequestDTO
//   (not directly referenced by a detected call)
public class GetRanksRequestDTO : GetRankRequestDTO
{
    public int <RankStart>k__BackingField;    // 0x0x40
    public int <RankEnd>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// RecNet.GiftBoxContents
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GiftBoxContents
{
    Unspecified = -1,
    XP = 0,
    OutfitItem = 1,
    Equipment = 2,
    Currency = 3,
    Consumable = 4,
    Query = 5,
    HairDye = 6,
    Rectober_Trick = 7,
}

// --------------------------------------------------------------------------
// RecNet.GiftContext
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GiftContext
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
    FB_Unassigned_Avatar = 13,
    Reacquisition = 20,
    Membership = 21,
    Day2Reengagement = 22,
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
    Rectober = 600,
    Rectober_Trick = 601,
    Rectober_Treat = 602,
    Rectober_Treat_Consumable = 603,
    Rectober_Treat_Token = 604,
    Rectober_Gift = 605,
    Store_Limited_Time_Seasonal = 1000,
    Store_Limited_Time_Contest = 1001,
    Store_Limited_Time_Promotion = 1002,
    Store_Limited_Time_Recurring = 1003,
    Store_Limited_Time_Event = 1004,
    Store_Limited_Time_Contract = 1005,
    Store_Limited_Time_Free = 1006,
    Store_Members_Only = 1010,
    Store_Free = 1011,
    Store_Indefinitely_Locked = 1090,
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
    Paintball_MerryMidway = 2016,
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
    TimedRewardTrack = 13100,
    PaintballBattlePass = 13200,
    PaintballBattlePass_Sprays_Common = 13201,
    PaintballBattlePass_Sprays_Uncommon = 13202,
    PaintballBattlePass_Sprays_Rare = 13203,
    PaintballBattlePass_Sprays_Epic = 13204,
    PaintballBattlePass_Sprays_Legendary = 13205,
    Store_LaserTag = 100000,
    Store_RecCenter = 100010,
    Consumable = 110000,
    Token = 110100,
    Punchcard_Challenge_Complete = 110200,
    All_Punchcard_Challenges_Complete = 110201,
    New_Player_Checklist_Item_Complete = 110300,
    ShoppingBagPromotions = 110400,
    Commerce_Purchase = 200000,
    Gift_Card_Redemption = 210000,
}

// --------------------------------------------------------------------------
// RecNet.GiftItemDTO
//   (not directly referenced by a detected call)
public class GiftItemDTO
{
    public int <ToPlayerId>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public bool <Anonymous>k__BackingField;    // 0x0x20
    public GiftContext <GiftContext>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.GiftPackage
//   RESPONSE POST   api/avatar/v2/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/avatar/v3/gifts/generate   [Service.Econ]
//   RESPONSE POST   api/checklist/v1/complete   [Service.Econ]
public class GiftPackage
{
    public long? <Id>k__BackingField;    // 0x0x10
    public int <PlayerId>k__BackingField;    // 0x0x20
    public int? <FromPlayerId>k__BackingField;    // 0x0x24
    public string <ConsumableItemDesc>k__BackingField;    // 0x0x30
    public AvatarItemType? <AvatarItemType>k__BackingField;    // 0x0x38
    public string <AvatarItemDescOrHairDyeDesc>k__BackingField;    // 0x0x40
    public Guid? <CustomAvatarItemId>k__BackingField;    // 0x0x48
    public string <EquipmentPrefabName>k__BackingField;    // 0x0x60
    public string <EquipmentModificationGuid>k__BackingField;    // 0x0x68
    public CurrencyType <CurrencyType>k__BackingField;    // 0x0x70
    public int <Currency>k__BackingField;    // 0x0x74
    public int <Xp>k__BackingField;    // 0x0x78
    public GiftContext <GiftContext>k__BackingField;    // 0x0x7C
    public GiftRarity <GiftRarity>k__BackingField;    // 0x0x80
    public string <RawMessage>k__BackingField;    // 0x0x88
    public string <Signature>k__BackingField;    // 0x0x90
    public bool <IsSignatureValid>k__BackingField;    // 0x0x98
    public PlatformType <Platform>k__BackingField;    // 0x0x9C
    public PlatformMask <PlatformsToSpawnOn>k__BackingField;    // 0x0xA0
    public StorefrontBalanceType? <BalanceType>k__BackingField;    // 0x0xA4
    public long? <RoomId>k__BackingField;    // 0x0xB0
    public string <GiftDescription>k__BackingField;    // 0x0xC0
    public bool <Consumed>k__BackingField;    // 0x0xC8
    public bool <IsValid>k__BackingField;    // 0x0xC9
    public string <CustomMessage>k__BackingField;    // 0x0xD0
    public string <ErrorMessage>k__BackingField;    // 0x0xD8
    public bool <CanSpawnOnCurrentPlatform>k__BackingField;    // 0x0xE0
    public bool IsGifted;    // 0x0xE1
}

// --------------------------------------------------------------------------
// RecNet.GiftRarity
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum GiftRarity
{
    None = -1,
    Common = 0,
    Uncommon = 10,
    Rare = 20,
    Epic = 30,
    Legendary = 50,
}

// --------------------------------------------------------------------------
// RecNet.GoToRoomListRequestDTO
// base   : RecNet.GoToRoomRequestDTO
//   (not directly referenced by a detected call)
public class GoToRoomListRequestDTO : GoToRoomRequestDTO
{
    public List<long> <RoomIds>k__BackingField;    // 0x0x80
    public List<long> <JoinOnlyRoomIds>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// RecNet.GoToRoomRequestDTO
//   (not directly referenced by a detected call)
public class GoToRoomRequestDTO
{
    public List<int> <AdditionalPlayerIds>k__BackingField;    // 0x0x10
    public bool <BypassMovementModeRestriction>k__BackingField;    // 0x0x18
    public int? <MaxPersistenceVersion>k__BackingField;    // 0x0x1C
    public int? <Ugc1SubVersion>k__BackingField;    // 0x0x24
    public int? <Ugc2SubVersion>k__BackingField;    // 0x0x2C
    public string <VoiceServerVersion>k__BackingField;    // 0x0x38
    public Guid <LoginLock>k__BackingField;    // 0x0x40
    public string <ClientJoinData>k__BackingField;    // 0x0x50
    public Guid <CorrelationId>k__BackingField;    // 0x0x58
    public RoomJoinMode <JoinMode>k__BackingField;    // 0x0x68
    public JoinRoomInviteMode <InviteMode>k__BackingField;    // 0x0x6C
    public bool <ShouldKeepPlayerWithParty>k__BackingField;    // 0x0x70
    public List<PlayerScoresDTO> <PlayerScores>k__BackingField;    // 0x0x78
}

// --------------------------------------------------------------------------
// RecNet.GoToSubRoomRequestDTO
// base   : RecNet.GoToRoomRequestDTO
//   (not directly referenced by a detected call)
public class GoToSubRoomRequestDTO : GoToRoomRequestDTO
{
    public bool <AdditionalPlayersAutoFollow>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.HeartbeatResponseDTO
// base   : RecNet.PlayerPresence
//   (not directly referenced by a detected call)
public class HeartbeatResponseDTO : PlayerPresence
{
    public DateTime? <ServerTime>k__BackingField;    // 0x0x70
}

// --------------------------------------------------------------------------
// RecNet.InAppMessageDTO
//   (not directly referenced by a detected call)
public class InAppMessageDTO
{
    public string <MessageId>k__BackingField;    // 0x0x10
    public string <SenderMessageId>k__BackingField;    // 0x0x18
    public bool <IsBroadcast>k__BackingField;    // 0x0x20
    public PlatformType <Platform>k__BackingField;    // 0x0x24
    public PlatformMask <PlatformTypeMask>k__BackingField;    // 0x0x28
    public int <Priority>k__BackingField;    // 0x0x2C
    public DateTime <SentAt>k__BackingField;    // 0x0x30
    public bool <YQVDWJEFURI>k__BackingField;    // 0x0x38
    public bool <IsClientRead>k__BackingField;    // 0x0x39
    public InAppMessageChannel <Channel>k__BackingField;    // 0x0x3C
    public InAppMessageContentType <ContentType>k__BackingField;    // 0x0x40
    public string <THPNJJEQOXY>k__BackingField;    // 0x0x48
    public PNVGGMEQILU <ContentObject>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.InAppMessageIdDTO
//   (not directly referenced by a detected call)
public class InAppMessageIdDTO
{
    public string <MessageId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.InitiatePurchaseRequest
//   (not directly referenced by a detected call)
public class InitiatePurchaseRequest
{
    public string <AccessToken>k__BackingField;    // 0x0x10
    public int <SkuId>k__BackingField;    // 0x0x18
    public int? <PurchaseReminderId>k__BackingField;    // 0x0x1C
    public int? <RRPlusSignUpBonusId>k__BackingField;    // 0x0x24
    public List<ItemPurchaseMethodId> <BonusItemIds>k__BackingField;    // 0x0x30
    public int? <GiftRecipientAccountId>k__BackingField;    // 0x0x38
    public string <GiftRecipientMessage>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.InitiatePurchaseResponse
//   (not directly referenced by a detected call)
public class InitiatePurchaseResponse
{
    public long <TransactionId>k__BackingField;    // 0x0x10
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
// RecNet.InventionModifyTagsRequest
// base   : RecNet.ModifyTagsRequest
//   REQUEST  POST   api/inventions/v1/settags   [Service.API]
public class InventionModifyTagsRequest : ModifyTagsRequest
{
    public long <InventionId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.InventionResponse
//   (not directly referenced by a detected call)
public class InventionResponse
{
    public InventionResult <Status>k__BackingField;    // 0x0x10
    public Invention <Invention>k__BackingField;    // 0x0x18
    public InventionVersion <InventionVersion>k__BackingField;    // 0x0x20
    public ModifyTagsResponse <TagsResponse>k__BackingField;    // 0x0x28
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
// RecNet.InventionTrialDurationResponse
//   RESPONSE GET    api/storefronts/v1/trialInvention/duration   [Service.Econ]
public class InventionTrialDurationResponse
{
    public int <Duration>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ItemPurchaseInfoDTO
//   (not directly referenced by a detected call)
public class ItemPurchaseInfoDTO
{
    public UGCPurchasableItemIdentifier <ItemId>k__BackingField;    // 0x0x10
    public ItemPurchaseMethodId <PurchaseMethodId>k__BackingField;    // 0x0x18
    public List<PurchasablePrice> <Prices>k__BackingField;    // 0x0x20
    public DateTime? <NewUntil>k__BackingField;    // 0x0x28
    public DateTime? <AvailableAt>k__BackingField;    // 0x0x38
    public DateTime? <AvailableUntil>k__BackingField;    // 0x0x48
    public bool <CanBeGifted>k__BackingField;    // 0x0x58
    public bool <CanApplySubscriberDiscount>k__BackingField;    // 0x0x59
    public bool <SubscribersOnly>k__BackingField;    // 0x0x5A
    public bool <IsFeatured>k__BackingField;    // 0x0x5B
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCategoryConfigDTO
//   (not directly referenced by a detected call)
public class KeepsakeCategoryConfigDTO
{
    public KeepsakeCategory <KeepsakeCategoryId>k__BackingField;    // 0x0x10
    public string <VisualId>k__BackingField;    // 0x0x18
    public int <LimitPerRoom>k__BackingField;    // 0x0x20
    public int <XpValue>k__BackingField;    // 0x0x24
    public string <IconOutlineImageName>k__BackingField;    // 0x0x28
    public string <IconFilledImageName>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectInstanceResponse
//   (not directly referenced by a detected call)
public class KeepsakeCollectInstanceResponse
{
    public int <TotalXp>k__BackingField;    // 0x0x10
    public int <SocialBoostXp>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeCollectionRecordDTO
//   (not directly referenced by a detected call)
public class KeepsakeCollectionRecordDTO
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public Guid <KeepsakeInstanceId>k__BackingField;    // 0x0x14
    public DateTime <CollectedAt>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeGlobalConfigDTO
//   RESPONSE GET    api/keepsakes/globalconfig   [Service.API]
public class KeepsakeGlobalConfigDTO
{
    public bool <KeepsakeFeatureEnabled>k__BackingField;    // 0x0x10
    public int <KeepsakeRoomLimit>k__BackingField;    // 0x0x14
    public bool <SocialXpBoostEnabled>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeInstanceDTO
//   (not directly referenced by a detected call)
public class KeepsakeInstanceDTO
{
    public Guid <KeepsakeInstanceId>k__BackingField;    // 0x0x10
    public KeepsakeCategory <KeepsakeCategoryConfigId>k__BackingField;    // 0x0x20
    public int <PlacedByAccountId>k__BackingField;    // 0x0x24
    public long <RoomId>k__BackingField;    // 0x0x28
    public long? <SubRoomId>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeProgressionEventInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/events/{eventId}   [Service.API]
public class KeepsakeProgressionEventInstancesDTO
{
    public List<KeepsakeRoomInstanceIdsDTO> <Instances>k__BackingField;    // 0x0x10
    public List<KeepsakeRoomInstanceIdsDTO> <CollectionRecords>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomDTO
{
    public long <KeepsakeRoomId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x18
    public long <KeepsakeRoomListId>k__BackingField;    // 0x0x20
    public KeepsakeRoomType <Type>k__BackingField;    // 0x0x28
    public int <Order>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstanceIdsDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomInstanceIdsDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public List<Guid> <KeepsakeInstanceIds>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomInstancesDTO
//   RESPONSE GET    api/keepsakes   [Service.API]
//   RESPONSE GET    api/keepsakes/rooms/{roomId}   [Service.API]
public class KeepsakeRoomInstancesDTO
{
    public IReadOnlyList<KeepsakeInstanceDTO> <Instances>k__BackingField;    // 0x0x10
    public IReadOnlyList<KeepsakeCollectionRecordDTO> <CollectionRecords>k__BackingField;    // 0x0x18
    public IReadOnlyList<long> <KeepsakeProgressionEventIds>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.KeepsakeRoomListDTO
//   (not directly referenced by a detected call)
public class KeepsakeRoomListDTO
{
    public long <KeepsakeRoomListId>k__BackingField;    // 0x0x10
    public long <ProgressionEventId>k__BackingField;    // 0x0x18
    public int? <UnlockItemAvatarItemId>k__BackingField;    // 0x0x20
    public int? <UnlockItemGiftDropId>k__BackingField;    // 0x0x28
    public long? <UnlockItemLockDurationTicks>k__BackingField;    // 0x0x30
    public long <RoomUnlockStartOffsetTicks>k__BackingField;    // 0x0x40
    public long <RoomUnlockIntervalTicks>k__BackingField;    // 0x0x48
    public int <RoomUnlockBatchSize>k__BackingField;    // 0x0x50
    public KeepsakeRoomType <RoomType>k__BackingField;    // 0x0x54
    public List<KeepsakeRoomDTO> <KeepsakeRooms>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.KickPlayerDTO
//   (not directly referenced by a detected call)
public class KickPlayerDTO
{
    public long <GameSessionId>k__BackingField;    // 0x0x10
    public List<int> <PlayerIds>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.LeaderboardStatChangedDTO
//   (not directly referenced by a detected call)
public class LeaderboardStatChangedDTO
{
    public int <PlayerId>k__BackingField;    // 0x0x10
    public int <StatValue>k__BackingField;    // 0x0x14
    public long <PrimaryKey>k__BackingField;    // 0x0x18
    public int <SecondaryKey>k__BackingField;    // 0x0x20
    public LeaderboardType <LeaderboardType>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.LegacyOutfitDataDTO
//   (not directly referenced by a detected call)
public class LegacyOutfitDataDTO
{
    public string <SelectionsV1>k__BackingField;    // 0x0x10
    public string <SelectionsV2>k__BackingField;    // 0x0x18
    public string <FaceFeatures>k__BackingField;    // 0x0x20
    public string <SkinColor>k__BackingField;    // 0x0x28
    public string <HairColor>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.Lists.AlgorithmicListDTO
//   (not directly referenced by a detected call)
public class AlgorithmicListDTO
{
    public EntityType <Type>k__BackingField;    // 0x0x10
    public IReadOnlyList<RankedEntityDTO> <Entities>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Lists.CuratedListDTO
//   (not directly referenced by a detected call)
public class CuratedListDTO
{
    public long <ListId>k__BackingField;    // 0x0x10
    public int <CreatorAccountId>k__BackingField;    // 0x0x18
    public string <Name>k__BackingField;    // 0x0x20
    public string <Description>k__BackingField;    // 0x0x28
    public string <ImageName>k__BackingField;    // 0x0x30
    public EntityType <Type>k__BackingField;    // 0x0x38
    public IReadOnlyList<string> <ItemIds>k__BackingField;    // 0x0x40
    public DateTime <CreatedAt>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.Lists.RankedEntityDTO
//   (not directly referenced by a detected call)
public class RankedEntityDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public string <Context>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.LoginResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class LoginResult : ValueType
{
    public LoginStatus <Status>k__BackingField;    // 0x0x0
    public YTFGBGYDUVY <SecurityCodeHint>k__BackingField;    // 0x0x8
    public string <LoginContext>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.MatchmakingResponse
//   (not directly referenced by a detected call)
public class MatchmakingResponse
{
    public MatchmakingErrorCode <ErrorCode>k__BackingField;    // 0x0x10
    public RoomInstance <RoomInstance>k__BackingField;    // 0x0x18
    public Guid <CorrelationId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.MessageIdDTO
//   (not directly referenced by a detected call)
public class MessageIdDTO
{
    public long <Id>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ModifyTagsRequest
//   (not directly referenced by a detected call)
public class ModifyTagsRequest
{
    public List<string> <AutoTags>k__BackingField;    // 0x0x10
    public List<string> <CustomTags>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.MultiRecipientFreeGiftRequestDTO
//   REQUEST  POST   api/freegifts/v1/sendmultiple   [Service.Econ]
public class MultiRecipientFreeGiftRequestDTO
{
    public List<int> <ToPlayerIds>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
    public GiftContext <GiftContext>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.NewInventionRequestDTO
//   REQUEST  POST   api/inventions/v9/save   [Service.Matchmaking]
public class NewInventionRequestDTO
{
    public string <name>k__BackingField;    // 0x0x10
    public string <description>k__BackingField;    // 0x0x18
    public string <imageName>k__BackingField;    // 0x0x20
    public bool <hasBetaContent>k__BackingField;    // 0x0x28
    public int <instantiationCost>k__BackingField;    // 0x0x2C
    public int <lightsCost>k__BackingField;    // 0x0x30
    public int <chipsCost>k__BackingField;    // 0x0x34
    public int <cloudVariablesCost>k__BackingField;    // 0x0x38
    public int <aiCost>k__BackingField;    // 0x0x3C
    public byte <ugcVersion>k__BackingField;    // 0x0x40
    public long <creationRoomId>k__BackingField;    // 0x0x48
    public string <inventionDataFilename>k__BackingField;    // 0x0x50
    public List<long> <referencedInventions>k__BackingField;    // 0x0x58
    public IReadOnlyList<Guid> <referencedUnityAssetIds>k__BackingField;    // 0x0x60
    public AccountRoleType <creatorAccountRole>k__BackingField;    // 0x0x68
    public long? <convertedFromInventionId>k__BackingField;    // 0x0x70
    public string <displayMetadataJson>k__BackingField;    // 0x0x80
    public string <longDescription>k__BackingField;    // 0x0x88
    public ModifyTagsRequest <tagsRequest>k__BackingField;    // 0x0x90
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_AnnouncementDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.AnnouncementDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_AnnouncementDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_AnnouncementIdDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.AnnouncementIdDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_AnnouncementIdDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_BalanceResponseDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.BalanceResponseDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_BalanceResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_BalanceUpdateResponseDTO_RewardBalanceModificationDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.BalanceUpdateResponseDTO`1<RecNet.Storefronts/RewardBalanceModificationDTO>>
//   (not directly referenced by a detected call)
public class NotificationDto_BalanceUpdateResponseDTO_RewardBalanceModificationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_CommunityBoardAnnouncementDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.CommunityBoard/CommunityBoardAnnouncementDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_CommunityBoardAnnouncementDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_CommunityBoardDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.CommunityBoard/CommunityBoardDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_CommunityBoardDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_CurrencyIdDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.CurrencyIdDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_CurrencyIdDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_DataCollection_EventDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Data.AEETVKWFGVC/EventDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_DataCollection_EventDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_GenerateMeshResponseDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.AI.GenerateMeshResponseDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_GenerateMeshResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_GiftPackageIdDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.DYLAMRVJOMP/GiftPackageIdDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_GiftPackageIdDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_InAppMessageDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.InAppMessageDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_InAppMessageDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_InAppMessageIdDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.InAppMessageIdDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_InAppMessageIdDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_InventionPurchaseResponseDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Storefronts/InventionPurchaseResponseDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_InventionPurchaseResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_KeepsakeInstanceDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.KeepsakeInstanceDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_KeepsakeInstanceDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_LeaderboardStatChangedDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.LeaderboardStatChangedDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_LeaderboardStatChangedDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_LogoutNotificationDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Login/LogoutNotificationDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_LogoutNotificationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_MessageIdDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.MessageIdDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_MessageIdDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_NotifyVoiceViolationDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Moderation/NotifyVoiceViolationDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_NotifyVoiceViolationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_PhotonAccessTokenAndPermissionsDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Rooms.PhotonAccessTokenAndPermissionsDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_PhotonAccessTokenAndPermissionsDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_PlayerEventIdDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Events.PlayerEventIdDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_PlayerEventIdDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_ProgressionEventRecordDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.ProgressionEventRecordDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_ProgressionEventRecordDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_PurchaseBalanceModificationDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Storefronts/PurchaseBalanceModificationDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_PurchaseBalanceModificationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_RemoteRunDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Studio.RemoteRunDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_RemoteRunDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_RoomBanNotificationDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Rooms.RoomBanNotificationDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_RoomBanNotificationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_RoomBoostConsumedNotificationDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Rooms.RoomBoostConsumedNotificationDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_RoomBoostConsumedNotificationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_RoomBoostNotificationDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Rooms.RoomBoostNotificationDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_RoomBoostNotificationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_RoomDetailsDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Rooms.RoomDetailsDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_RoomDetailsDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_RoomKeyIdDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.RoomKeyIdDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_RoomKeyIdDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_RoomOfferIdDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.RoomOfferIdDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_RoomOfferIdDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_ServerMaintenanceDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.ServerMaintenanceDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_ServerMaintenanceDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_SubscriptionEventDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.Commerce/SubscriptionEventDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_SubscriptionEventDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_TimedRewardTrackRecordDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.TimedRewardTrackRecordDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_TimedRewardTrackRecordDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.NotificationDto_VoiceConnectionDTO
// base   : RecNet.Notifications/NotificationDto`1<RecNet.VoiceConnectionDTO>
//   (not directly referenced by a detected call)
public class NotificationDto_VoiceConnectionDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.Objective
//   (not directly referenced by a detected call)
public class Objective
{
    public ObjectiveType <ObjectiveType>k__BackingField;    // 0x0x10
    public int <RequiredScore>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.ObjectiveGroupProgress
//   RESPONSE POST   api/objectives/v1/cleargroup   [Service.Econ]
//   RESPONSE POST   api/objectives/v1/completegroup   [Service.Auth]
//   RESPONSE POST   api/objectives/v1/updateobjective   [Service.Econ]
public class ObjectiveGroupProgress
{
    public int <Group>k__BackingField;    // 0x0x10
    public bool <IsCompleted>k__BackingField;    // 0x0x14
    public DateTime <ClearedAt>k__BackingField;    // 0x0x18
    public bool <RequiresCompleteOnServer>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.ObjectiveProgress
//   REQUEST  POST   api/objectives/v1/completegroup   [Service.Auth]
//   REQUEST  POST   api/objectives/v1/updateobjective   [Service.Econ]
public class ObjectiveProgress
{
    public int <Index>k__BackingField;    // 0x0x10
    public int <Group>k__BackingField;    // 0x0x14
    public float <Progress>k__BackingField;    // 0x0x18
    public float <VisualProgress>k__BackingField;    // 0x0x1C
    public bool <IsCompleted>k__BackingField;    // 0x0x20
    public bool <HasClaimedReward>k__BackingField;    // 0x0x21
    public bool <IsDirty>k__BackingField;    // 0x0x22
}

// --------------------------------------------------------------------------
// RecNet.ObjectiveType
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ObjectiveType
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
// RecNet.OkResponse
//   RESPONSE POST   api/PlayerCheer/v1/create   [Service.API]
//   RESPONSE POST   api/clubreporting/v1/report   [Service.API]
//   RESPONSE POST   api/inventions/v1/report   [Service.API]
//   RESPONSE POST   api/playerevents/v1/report   [Service.API]
//   RESPONSE POST   api/relationships/sendfriendintroductions   [Service.API]
//   RESPONSE POST   api/screensharereports/v1/report   [Service.API]
public class OkResponse
{
    public bool <Success>k__BackingField;    // 0x0x10
    public string <Message>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.OutfitDTO
//   (not directly referenced by a detected call)
public class OutfitDTO
{
    public long <DataVersion>k__BackingField;    // 0x0x10
    public LegacyOutfitDataDTO <LegacyData>k__BackingField;    // 0x0x18
    public string <CustomizationSettings>k__BackingField;    // 0x0x20
    public List<OutfitSelectionDTO> <Selections>k__BackingField;    // 0x0x28
    public int <Slot>k__BackingField;    // 0x0x30
    public string <Name>k__BackingField;    // 0x0x38
    public UgcAccessibility <Accessibility>k__BackingField;    // 0x0x40
    public string <ThumbnailFileName>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.OutfitSelectionDTO
//   (not directly referenced by a detected call)
public class OutfitSelectionDTO
{
    public Guid <CustomAvatarItemId>k__BackingField;    // 0x0x10
    public int <BodyPart>k__BackingField;    // 0x0x20
    public string <BakedUnityAssetFileName>k__BackingField;    // 0x0x28
    public string <AdditionalConfiguration>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.PageViewDTO
//   (not directly referenced by a detected call)
public class PageViewDTO
{
    public double <FreshnessSeconds>k__BackingField;    // 0x0x10
    public string <Url>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.PartyInviteSettingsResponse
//   (not directly referenced by a detected call)
public class PartyInviteSettingsResponse
{
    public int <InviteLinkLifetimeInMinutes>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.PersonalInventionDetails
//   RESPONSE GET    api/inventions/   [Service.API]
//   RESPONSE GET    api/inventions/v1/personaldetails/{personaldetailId}   [Service.API]
public class PersonalInventionDetails
{
    public bool <IsCheering>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.PlatformMask
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PlatformMask
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
// RecNet.PlatformNotificationCategoryConfigDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationCategoryConfigDTO
{
    public PlatformNotificationCategory <CategoryId>k__BackingField;    // 0x0x10
    public PlatformNotificationImportance <Importance>k__BackingField;    // 0x0x14
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public bool <IsMuteable>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.PlatformNotificationPreferencesDTO
//   (not directly referenced by a detected call)
public class PlatformNotificationPreferencesDTO
{
    public IReadOnlyList<PlatformNotificationCategory> <MutedCategories>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.PlatformType
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PlatformType
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
// RecNet.PlayerQuickPlayDTO
//   RESPONSE GET    api/quickPlay/v1/getandclear   [Service.API]
public class PlayerQuickPlayDTO
{
    public int? <TargetPlayerId>k__BackingField;    // 0x0x10
    public string <RoomName>k__BackingField;    // 0x0x18
    public string <ActionCode>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PlayerRoomInventoryItemDTO
//   (not directly referenced by a detected call)
public class PlayerRoomInventoryItemDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public Guid <RoomInventoryItemOriginId>k__BackingField;    // 0x0x18
    public long <Count>k__BackingField;    // 0x0x28
    public Guid <ConcurrencyCode>k__BackingField;    // 0x0x30
    public DateTime <CreatedAt>k__BackingField;    // 0x0x40
    public DateTime <ModifiedAt>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.PlayerRoomInventoryOperationResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum PlayerRoomInventoryOperationResult
{
    Unknown = -1,
    Success = 0,
    RoomInventoryItemDoesNotExist = 1,
    PlayerDoesNotExist = 2,
    RoomDoesNotExist = 3,
    RequestQuantityTooLarge = 4,
    PlayerHasReachedTheMinimumOwnedAmount = 5,
    ConcurrencyCodeMismatch = 6,
    InvalidConcurrencyCode = 7,
}

// --------------------------------------------------------------------------
// RecNet.PlayerScoresDTO
//   (not directly referenced by a detected call)
public class PlayerScoresDTO
{
    public int <PlayerId>k__BackingField;    // 0x0x10
    public List<ScoreDTO> <Scores>k__BackingField;    // 0x0x18
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
// RecNet.PlayerVoiceVolumeDTO
//   REQUEST  POST   api/relationships/v2/updateVoiceVolume   [Service.API]
public class PlayerVoiceVolumeDTO
{
    public int <PlayerId>k__BackingField;    // 0x0x10
    public byte <VoiceVolume>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecNet.Preferences.RecNetSettingDTO
//   (not directly referenced by a detected call)
public class RecNetSettingDTO
{
    public string <Key>k__BackingField;    // 0x0x10
    public string <Value>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ProcessPurchaseRequest
//   (not directly referenced by a detected call)
public class ProcessPurchaseRequest
{
    public string <AccessToken>k__BackingField;    // 0x0x10
    public string <PurchaseDetails>k__BackingField;    // 0x0x18
    public int? <PurchaseReminderId>k__BackingField;    // 0x0x20
    public int? <RRPlusSignUpBonusId>k__BackingField;    // 0x0x28
    public List<ItemPurchaseMethodId> <BonusItemIds>k__BackingField;    // 0x0x30
    public int? <GiftRecipientAccountId>k__BackingField;    // 0x0x38
    public string <GiftRecipientMessage>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventDTO
//   RESPONSE GET    api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/event/{eventId}   [Service.API]
public class ProgressionEventDTO
{
    public long <ProgressionEventId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public List<ProgressionEventRewardDTO> <Rewards>k__BackingField;    // 0x0x20
    public List<KeepsakeRoomListDTO> <KeepsakeRoomLists>k__BackingField;    // 0x0x28
    public DateTime <StartTime>k__BackingField;    // 0x0x30
    public DateTime <EndTime>k__BackingField;    // 0x0x38
    public DateTime <CollectionEndTime>k__BackingField;    // 0x0x40
    public bool <UsesBoost>k__BackingField;    // 0x0x48
    public int <BoostDailyGameplayMinutesLimit>k__BackingField;    // 0x0x4C
    public float <BoostXpMultiplier>k__BackingField;    // 0x0x50
    public Guid? <PurchasableXpBoostId>k__BackingField;    // 0x0x54
    public string <ActiveExperiment>k__BackingField;    // 0x0x68
    public string <ChallengesIconImageName>k__BackingField;    // 0x0x70
    public string <RewardsPipImageName>k__BackingField;    // 0x0x78
    public string <EventInfoImageName>k__BackingField;    // 0x0x80
    public long? <EventLeaderboardId>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventPurchasableXpBoostDTO
//   (not directly referenced by a detected call)
public class ProgressionEventPurchasableXpBoostDTO
{
    public Guid <ProgressionEventPurchasableXpBoostId>k__BackingField;    // 0x0x10
    public int <Cost>k__BackingField;    // 0x0x20
    public int <XpMultiplier>k__BackingField;    // 0x0x24
    public int <XpCap>k__BackingField;    // 0x0x28
    public long <LookbackDurationTicks>k__BackingField;    // 0x0x30
    public long <CooldownDurationTicks>k__BackingField;    // 0x0x38
    public CurrencyType <CurrencyType>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRecordDTO
//   RESPONSE ?      api/progressionEvents   [Service.API]
//   RESPONSE GET    api/progressionEvents/record/{recordId}   [Service.API]
public class ProgressionEventRecordDTO
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public long <ProgressionEventId>k__BackingField;    // 0x0x18
    public int <Xp>k__BackingField;    // 0x0x20
    public int <GameMinutesToday>k__BackingField;    // 0x0x24
    public int <RewardsCollected>k__BackingField;    // 0x0x28
    public int <BonusRewardsCollected>k__BackingField;    // 0x0x2C
    public DateTime? <XpBoostLastPurchasedAt>k__BackingField;    // 0x0x30
    public int <PremiumRewardsCollected>k__BackingField;    // 0x0x40
    public ProgressionEventLimitedRewardCollectionState <LimitedRewardCollectionState>k__BackingField;    // 0x0x44
}

// --------------------------------------------------------------------------
// RecNet.ProgressionEventRewardDTO
//   (not directly referenced by a detected call)
public class ProgressionEventRewardDTO
{
    public long <ProgressionEventRewardId>k__BackingField;    // 0x0x10
    public string <ImageName>k__BackingField;    // 0x0x18
    public int <Xp>k__BackingField;    // 0x0x20
    public int <RewardIndex>k__BackingField;    // 0x0x24
    public bool <IsBonus>k__BackingField;    // 0x0x28
    public bool <IsRRPlusExclusive>k__BackingField;    // 0x0x29
    public int? <MaxGlobalCollections>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.PublishInventionRequest
//   REQUEST  POST   api/inventions/v4/publish   [Service.API]
public class PublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public InventionPermission <Permission>k__BackingField;    // 0x0x18
    public UgcAccessibility <Accessibility>k__BackingField;    // 0x0x1C
    public int? <Price>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.PurchaseBalanceUpdateResponseDTO`1
// base   : RecNet.BalanceResponseDTO
//   (not directly referenced by a detected call)
public class PurchaseBalanceUpdateResponseDTO : BalanceResponseDTO
{
    public List<RDAQZEYYGSP<DataTypeDTO>> <BalanceUpdates>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.PurchaseItemRequestDTO
//   (not directly referenced by a detected call)
public class PurchaseItemRequestDTO
{
    public ItemPurchaseMethodId <ItemPurchaseMethodId>k__BackingField;    // 0x0x10
    public long <RequestedPrice>k__BackingField;    // 0x0x18
    public GiftItemDTO <Gift>k__BackingField;    // 0x0x20
    public long? <CouponConsumablePlayerMappingId>k__BackingField;    // 0x0x28
    public int <DuplicateItemCount>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.RRPlusSignupConfigDTO
//   (not directly referenced by a detected call)
public class RRPlusSignupConfigDTO
{
    public int <Version>k__BackingField;    // 0x0x10
    public string <HighlightText>k__BackingField;    // 0x0x18
    public string <MoreDetailsText>k__BackingField;    // 0x0x20
    public Dictionary<int, RRPlusBenefitDescriptionDto> <BenefitLookup>k__BackingField;    // 0x0x28
    public Dictionary<string, int> <NumberReplacements>k__BackingField;    // 0x0x30
    public Dictionary<BenefitListType, List<int>> <BenefitLists>k__BackingField;    // 0x0x38
    public Dictionary<string, string> <StringConfigs>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.RecNetResult
//   RESPONSE POST   api/chatreport/createChatReport   [Service.API]
//   RESPONSE POST   api/consumables/v1/transfer   [Service.Econ]
//   RESPONSE POST   api/customAvatarItems   [Service.API]
//   RESPONSE GET    api/customAvatarItems/v1/isCreationAllowedForAccount   [Service.API]
//   RESPONSE DELETE api/customAvatarItems/v1/{customAvatarItemId}   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/appeal   [Service.API]
//   RESPONSE POST   api/customAvatarItems/v1/{customAvatarItemId}/report   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/createplatforminvite   [Service.API]
//   RESPONSE POST   api/externalfriendinvite/v1/sendtextmessageinvite   [Service.API]
//   RESPONSE POST   api/freegifts/v1/sendmultiple   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/request   [Service.Econ]
//   RESPONSE POST   api/gamerewards/v1/select   [Service.Econ]
//   RESPONSE POST   api/images/v2/modifyaccessibility   [Service.API]
//   RESPONSE POST   api/influencerpartnerprogram/remove   [Service.Econ]
//   RESPONSE POST   api/influencerpartnerprogram/support   [Service.Econ]
//   RESPONSE DELETE api/keepsakes   [Service.API]
//   RESPONSE DELETE api/keepsakes/{keepsakeId}   [Service.API]
//   RESPONSE POST   api/makerai/activatefreetrial   [Service.API]
//   RESPONSE GET    api/makerai/checkfreetrialeligibility   [Service.Econ]
//   RESPONSE POST   api/roomcurrencies/v1/deletePurchaseOffer   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/revoke   [Service.Econ]
//   RESPONSE POST   api/rooms/v1/report/addScreenshot   [Service.API]
public class RecNetResult
{
    public bool <Success>k__BackingField;    // 0x0x10
    public string <Error>k__BackingField;    // 0x0x18
    public string <ErrorId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultListObject_ClubMembershipRequest
// base   : RecNet.RecNetResultListObject`1<RecNet.ClubMembershipRequest>
//   (not directly referenced by a detected call)
public class RecNetResultListObject_ClubMembershipRequest
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultListObject_ExternalRoomProgressionDTO
// base   : RecNet.RecNetResultListObject`1<RecNet.Rooms.ExternalRoomProgressionDTO>
//   (not directly referenced by a detected call)
public class RecNetResultListObject_ExternalRoomProgressionDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultListObject_NintendoProfanityResponseStringDTO
// base   : RecNet.RecNetResultListObject`1<RecNet.RecNetResultObject`1<RecNet.FilteredTextDTO>>
//   (not directly referenced by a detected call)
public class RecNetResultListObject_NintendoProfanityResponseStringDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultListObject_RoomAssetDTO
// base   : RecNet.RecNetResultListObject`1<RecNet.Rooms.RoomAssetDTO>
//   (not directly referenced by a detected call)
public class RecNetResultListObject_RoomAssetDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultListObject_RoomInventoryItemTagDTO
// base   : RecNet.RecNetResultListObject`1<RecNet.RoomInventoryItemTagDTO>
//   (not directly referenced by a detected call)
public class RecNetResultListObject_RoomInventoryItemTagDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultListObject_RoomOfferLastPurchaseDTO
// base   : RecNet.RecNetResultListObject`1<RecNet.RoomOfferLastPurchaseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultListObject_RoomOfferLastPurchaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultListObject_RoomOfferPurchaseCountDTO
// base   : RecNet.RecNetResultListObject`1<RecNet.RoomOfferPurchaseCountDTO>
//   (not directly referenced by a detected call)
public class RecNetResultListObject_RoomOfferPurchaseCountDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_AddClientFeatureReferencesResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Storage/AddClientFeatureReferencesResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_AddClientFeatureReferencesResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_AwardCurrencyResponse
// base   : RecNet.RecNetResultObject`1<RecNet.AwardCurrencyResponse>
//   (not directly referenced by a detected call)
public class RecNetResultObject_AwardCurrencyResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_AwardRoomKeyResponse
// base   : RecNet.RecNetResultObject`1<RecNet.AwardRoomKeyResponse>
//   (not directly referenced by a detected call)
public class RecNetResultObject_AwardRoomKeyResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_BalanceResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.BalanceResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_BalanceResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO
// base   : RecNet.RecNetResultObject`1<RecNet.BalanceUpdateResponseDTO`1<RecNet.BulkPurchaseItemsBalanceUpdateResponseDataDTO>>
//   (not directly referenced by a detected call)
public class RecNetResultObject_BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_ChatResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.ChatResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_ChatResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_CreateCustomConsumableResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.CreateCustomConsumableResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_CreateCustomConsumableResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_CreateRealtimeSessionResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.CreateRealtimeSessionResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_CreateRealtimeSessionResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_CrmAssignmentDTO
// base   : RecNet.RecNetResultObject`1<RecNet.CrmAssignmentDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_CrmAssignmentDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_CuratedListDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Lists.CuratedListDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_CuratedListDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_CustomAvatarItemBalanceModificationResponse
// base   : RecNet.RecNetResultObject`1<RecNet.CustomAvatarItemBalanceModificationResponse>
//   (not directly referenced by a detected call)
public class RecNetResultObject_CustomAvatarItemBalanceModificationResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_DescribeImageResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.DescribeImageResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_DescribeImageResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_GameAIRoomSpendSummaryDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.GameAIRoomSpendSummaryDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_GameAIRoomSpendSummaryDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_GenerateAudioOrSongResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.GenerateAudioOrSongResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_GenerateAudioOrSongResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_GenerateConversationResponseResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.GenerateConversationResponseResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_GenerateConversationResponseResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_GenerateImageResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.GenerateImageResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_GenerateImageResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_GenerateMeshResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.GenerateMeshResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_GenerateMeshResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_GeneratedCircuitBoardDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.GeneratedCircuitBoardDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_GeneratedCircuitBoardDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_InventionResponse
// base   : RecNet.RecNetResultObject`1<RecNet.InventionResponse>
//   (not directly referenced by a detected call)
public class RecNetResultObject_InventionResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_KeepsakeCollectInstanceResponse
// base   : RecNet.RecNetResultObject`1<RecNet.KeepsakeCollectInstanceResponse>
//   (not directly referenced by a detected call)
public class RecNetResultObject_KeepsakeCollectInstanceResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_NintendoProfanityResponseStringDTO
// base   : RecNet.RecNetResultObject`1<RecNet.FilteredTextDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_NintendoProfanityResponseStringDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_PendingPurchasesDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Commerce/PendingPurchasesDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_PendingPurchasesDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_ProcessPurchaseResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Commerce/ProcessPurchaseResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_ProcessPurchaseResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RecRoomStudioRemoteRunDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Studio.RemoteRunDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RecRoomStudioRemoteRunDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_ReplicationRoomDetailsDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Rooms.ReplicationRoomDetailsDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_ReplicationRoomDetailsDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_ReportBattlePassSessionResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Econ.BattlePass.ReportBattlePassSessionResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_ReportBattlePassSessionResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomAssetDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Rooms.RoomAssetDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomAssetDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomBanHistoryDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Rooms.RoomBanHistoryDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomBanHistoryDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomCurrencyPurchaseResponse
// base   : RecNet.RecNetResultObject`1<RecNet.RoomCurrencyPurchaseResponse>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomCurrencyPurchaseResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomDetailsDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Rooms.RoomDetailsDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomDetailsDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomEarningsDistributionDTO
// base   : RecNet.RecNetResultObject`1<RecNet.RoomEarningsDistributionDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomEarningsDistributionDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomInviteDTO
// base   : RecNet.RecNetResultObject`1<RecNet.RoomInviteDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomInviteDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomLoadDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Rooms.RoomLoadDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomLoadDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomPublishStateConfigDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Rooms.RoomPublishStateConfigDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomPublishStateConfigDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_RoomieEnergyDTO
// base   : RecNet.RecNetResultObject`1<RecNet.AI.RoomieEnergyDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_RoomieEnergyDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_SaveSubRoomResponseDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Rooms.SaveSubRoomResponseDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_SaveSubRoomResponseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_SendOnlineStatusToFriendsResultDTO
// base   : RecNet.RecNetResultObject`1<RecNet.SendOnlineStatusToFriendsResultDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_SendOnlineStatusToFriendsResultDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_StorageFileReferenceDTO
// base   : RecNet.RecNetResultObject`1<RecNet.Rooms.StorageFileReferenceDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_StorageFileReferenceDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_TokenSpendReminderBalanceModificationResponse
// base   : RecNet.RecNetResultObject`1<RecNet.TokenSpendPurchaseReminderBalanceModificationResponse>
//   (not directly referenced by a detected call)
public class RecNetResultObject_TokenSpendReminderBalanceModificationResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_VoiceConnectionDTO
// base   : RecNet.RecNetResultObject`1<RecNet.VoiceConnectionDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_VoiceConnectionDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResultObject_VoicePresencesDTO
// base   : RecNet.RecNetResultObject`1<RecNet.VoicePresencesDTO>
//   (not directly referenced by a detected call)
public class RecNetResultObject_VoicePresencesDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.RecNetResult`1
// base   : RecNet.RecNetResult
//   (not directly referenced by a detected call)
public class RecNetResult : RecNetResult
{
    public T <Value>k__BackingField;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecNet.RecRoomConfig
//   RESPONSE GET    api/config/v2   [Service.API]
public class RecRoomConfig
{
    public Dictionary<int, int> <LevelProgressionMapDictionary>k__BackingField;    // 0x0x10
    public List<LevelProgressionMap> <LevelProgressionMaps>k__BackingField;    // 0x0x18
    public Objective[][] <DailyObjectives>k__BackingField;    // 0x0x20
    public ServerMaintenanceDTO <ServerMaintenance>k__BackingField;    // 0x0x28
    public AutoMicMutingConfig <AutoMicMutingConfig>k__BackingField;    // 0x0x30
    public StorefrontConfig <StorefrontConfig>k__BackingField;    // 0x0x38
    public RoomKeyConfigDTO <RoomKeyConfig>k__BackingField;    // 0x0x40
    public RoomCurrencyConfigDTO <RoomCurrencyConfig>k__BackingField;    // 0x0x48
    public string <ShareBaseUrl>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.RefereeFileReferenceDTO
//   (not directly referenced by a detected call)
public class RefereeFileReferenceDTO
{
    public string <Filename>k__BackingField;    // 0x0x10
    public string <Hash>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ReferralDTO
//   (not directly referenced by a detected call)
public class ReferralDTO
{
    public string <Info>k__BackingField;    // 0x0x10
    public int <ReferrerId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ReferralsResponse
//   RESPONSE GET    api/incentivizedreferrals/referrals   [Service.Econ]
public class ReferralsResponse
{
    public List<PlayerReferral> <Referrals>k__BackingField;    // 0x0x10
    public string <ContinuationToken>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Relationship
//   RESPONSE GET    api/relationships/v1/addfriendwithcode   [Service.API]
//   RESPONSE GET    api/relationships/v1/favorite   [Service.API]
//   RESPONSE GET    api/relationships/v1/unfavorite   [Service.API]
//   RESPONSE GET    api/relationships/v2/acceptfriendrequest   [Service.API]
//   RESPONSE GET    api/relationships/v2/addfriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/removefriend   [Service.API]
//   RESPONSE GET    api/relationships/v2/sendfriendrequest   [Service.API]
//   RESPONSE POST   api/relationships/v2/updateVoiceVolume   [Service.API]
public class Relationship
{
    public int <PlayerID>k__BackingField;    // 0x0x10
    public RelationshipType <Type>k__BackingField;    // 0x0x14
    public ReciprocalStatus <Muted>k__BackingField;    // 0x0x18
    public ReciprocalStatus <Ignored>k__BackingField;    // 0x0x1C
    public ReciprocalStatus <Favorited>k__BackingField;    // 0x0x20
    public byte? <VoiceVolume>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.ReportRequest
//   REQUEST  POST   api/inventions/v1/report   [Service.API]
public class ReportRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public string <Details>k__BackingField;    // 0x0x18
    public InventionReportCategory <ReportCategory>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RevokeRoomKeyRequest
//   REQUEST  POST   api/roomkeys/v1/revoke   [Service.Econ]
public class RevokeRoomKeyRequest
{
    public long <RoomKeyId>k__BackingField;    // 0x0x10
    public int <AccountId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RewardPlayersForOutfitsInRoomRequest
//   (not directly referenced by a detected call)
public class RewardPlayersForOutfitsInRoomRequest
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public long <SubRoomId>k__BackingField;    // 0x0x18
    public string <CheckpointName>k__BackingField;    // 0x0x20
    public Dictionary<int, HashSet<Guid>> <AccountIdsToCurrentOutfitCustomAvatarItemIds>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableConcurrencyCodes
//   REQUEST  PUT    api/roomconsumables   [Service.Econ]
public class RoomConsumableConcurrencyCodes
{
    public Guid? <CurrentConcurrencyCode>k__BackingField;    // 0x0x10
    public Guid <NewConcurrencyCode>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableCreateOrUpdateRequest
//   REQUEST  PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
public class RoomConsumableCreateOrUpdateRequest
{
    public Guid? <RoomConsumableId>k__BackingField;    // 0x0x10
    public long? <RoomId>k__BackingField;    // 0x0x28
    public string <Name>k__BackingField;    // 0x0x38
    public string <Description>k__BackingField;    // 0x0x40
    public string <ImageName>k__BackingField;    // 0x0x48
    public RoomConsumablePriceAndCurrency <PriceAndCurrency>k__BackingField;    // 0x0x50
    public bool <IsGiftable>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableEditDescriptionRequest
//   (not directly referenced by a detected call)
public class RoomConsumableEditDescriptionRequest
{
    public string <Description>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableEditImageRequest
//   (not directly referenced by a detected call)
public class RoomConsumableEditImageRequest
{
    public string <ImageName>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableEditNameRequest
//   (not directly referenced by a detected call)
public class RoomConsumableEditNameRequest
{
    public string <Name>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableEditPriceRequest
//   (not directly referenced by a detected call)
public class RoomConsumableEditPriceRequest
{
    public RoomConsumablePriceAndCurrency <PriceAndCurrency>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableInventoryItemOperationBulkResult
//   RESPONSE POST   api/roomconsumables/v1/roomConsumable/awardBulk   [Service.Econ]
public class RoomConsumableInventoryItemOperationBulkResult
{
    public Dictionary<Guid, RoomConsumableInventoryItemOperationResult> <Results>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableInventoryItemOperationResult
//   RESPONSE PUT    api/roomconsumables   [Service.Econ]
public class RoomConsumableInventoryItemOperationResult
{
    public RoomConsumableResult <Status>k__BackingField;    // 0x0x10
    public RoomConsumableInventoryItem <InventoryItem>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableOperationResult
//   RESPONSE DELETE api/roomconsumables   [Service.Econ]
//   RESPONSE PUT    api/roomconsumables/v1/roomConsumable   [Service.Econ]
//   RESPONSE DELETE api/roomconsumables/v1/roomConsumable/{roomconsumableId}   [Service.Econ]
public class RoomConsumableOperationResult
{
    public RoomConsumableResult <Status>k__BackingField;    // 0x0x10
    public RoomConsumable <Consumable>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumablePurchaseRequest
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
//   REQUEST  PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class RoomConsumablePurchaseRequest
{
    public RoomConsumableConcurrencyCodes <ConcurrencyCodes>k__BackingField;    // 0x0x10
    public RoomConsumablePriceAndCurrency <ExpectedPriceAndCurrency>k__BackingField;    // 0x0x18
    public int <Quantity>k__BackingField;    // 0x0x20
    public int? <GiftRecipientAccountId>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumablePurchaseResponse
//   (not directly referenced by a detected call)
public class RoomConsumablePurchaseResponse
{
    public RoomConsumableInventoryItemOperationResult <OperationResult>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumablePurchaseWithCurrencyResponse
// base   : RecNet.RoomConsumablePurchaseResponse
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/currency   [Service.?]
public class RoomConsumablePurchaseWithCurrencyResponse : RoomConsumablePurchaseResponse
{
    public CurrencyBalanceUpdateResult? <BalanceUpdateResult>k__BackingField;    // 0x0x18
    public CurrencyBalance <CurrencyBalanceResponse>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumablePurchaseWithTokenResponse
// base   : RecNet.RoomConsumablePurchaseResponse
//   RESPONSE PUT    api/roomconsumables/v1/roomconsumable/{roomconsumableId}/purchase/tokens   [Service.?]
public class RoomConsumablePurchaseWithTokenResponse : RoomConsumablePurchaseResponse
{
    public UpdateResponseTypes? <BalanceUpdateResult>k__BackingField;    // 0x0x18
    public BalanceResponseDTO <TokenBalanceResponse>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RoomConsumableResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum RoomConsumableResult
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
    InvalidRelationship = 47,
    PlayerIsUgcGiftingRestricted = 48,
    PlayerIsUgcGiftReceivingRestricted = 49,
    CannotGiftFreeConsumable = 50,
    RoomConsumableNotGiftable = 51,
    GiftingRateLimited = 52,
}

// --------------------------------------------------------------------------
// RecNet.RoomCurrencyConfigDTO
//   (not directly referenced by a detected call)
public class RoomCurrencyConfigDTO
{
    public float <AwardCurrencyCooldownSeconds>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.RoomCurrencyPurchaseResponse
//   (not directly referenced by a detected call)
public class RoomCurrencyPurchaseResponse
{
    public CurrencyBalance <CurrencyBalanceResponse>k__BackingField;    // 0x0x10
    public BalanceResponseDTO <TokenBalanceResponse>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RoomEarningsDistributionDTO
//   REQUEST  POST   api/roomEarningsDistributions/v1/earningsDistribution   [Service.Econ]
public class RoomEarningsDistributionDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public Dictionary<int, byte> <EarningsDistributionMapping>k__BackingField;    // 0x0x18
    public EarningsDistributionMethod <EarningsDistributionMethod>k__BackingField;    // 0x0x20
    public bool <ShouldDistributeToRoomBalance>k__BackingField;    // 0x0x21
    public long <RoomBalanceTokenLimit>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.RoomEconConfigDTO
//   (not directly referenced by a detected call)
public class RoomEconConfigDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public bool <EnableSortingTabs>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RoomGiftDropShopItemPurchaseRequest
//   (not directly referenced by a detected call)
public class RoomGiftDropShopItemPurchaseRequest
{
    public Guid <RequestedCurrencyId>k__BackingField;    // 0x0x10
    public long <RequestedPrice>k__BackingField;    // 0x0x20
    public int <RequestedGiftDropId>k__BackingField;    // 0x0x28
    public Guid <TransactionId>k__BackingField;    // 0x0x2C
}

// --------------------------------------------------------------------------
// RecNet.RoomGiftDropShopItemPurchaseResponse
//   (not directly referenced by a detected call)
public class RoomGiftDropShopItemPurchaseResponse
{
    public RoomGiftDropShopItemPurchaseResult <BalanceUpdateResult>k__BackingField;    // 0x0x10
    public CurrencyBalance <CurrencyBalanceResponse>k__BackingField;    // 0x0x18
    public GiftPackage <GiftPackage>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RoomGiftDropShopItemPurchaseResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum RoomGiftDropShopItemPurchaseResult
{
    Success = 0,
    NotEnoughCredit = 1,
    AlreadyOwned = 2,
    InvalidItem = 3,
    RequestedPriceDoesNotMatch = 4,
    RequestedCurrencyDoesNotMatch = 5,
}

// --------------------------------------------------------------------------
// RecNet.RoomInventoryCreateOrUpdateRequestDTO
//   (not directly referenced by a detected call)
public class RoomInventoryCreateOrUpdateRequestDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public string <Description>k__BackingField;    // 0x0x18
    public string <ImageName>k__BackingField;    // 0x0x20
    public List<long> <TagIds>k__BackingField;    // 0x0x28
    public List<RoomInventoryItemTagCreateDTO> <NewTags>k__BackingField;    // 0x0x30
    public string <Properties>k__BackingField;    // 0x0x38
    public byte? <IconShape>k__BackingField;    // 0x0x40
    public int? <IconColor>k__BackingField;    // 0x0x44
    public Guid? <OriginId>k__BackingField;    // 0x0x4C
    public bool <AllowRename>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// RecNet.RoomInventoryItemDTO
//   (not directly referenced by a detected call)
public class RoomInventoryItemDTO
{
    public Guid <OriginId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x20
    public string <Name>k__BackingField;    // 0x0x28
    public string <Description>k__BackingField;    // 0x0x30
    public string <ImageName>k__BackingField;    // 0x0x38
    public DateTime <CreatedAt>k__BackingField;    // 0x0x40
    public DateTime <ModifiedAt>k__BackingField;    // 0x0x48
    public string <Properties>k__BackingField;    // 0x0x50
    public List<long> <TagIds>k__BackingField;    // 0x0x58
    public List<RoomInventoryItemTagDTO> <NewTags>k__BackingField;    // 0x0x60
    public byte <IconShape>k__BackingField;    // 0x0x68
    public int <IconColor>k__BackingField;    // 0x0x6C
}

// --------------------------------------------------------------------------
// RecNet.RoomInventoryItemReplicationDTO
// base   : RecNet.RoomInventoryItemDTO
//   (not directly referenced by a detected call)
public class RoomInventoryItemReplicationDTO : RoomInventoryItemDTO
{
    public Guid <RoomInventoryItemId>k__BackingField;    // 0x0x70
}

// --------------------------------------------------------------------------
// RecNet.RoomInventoryItemTagCreateDTO
//   (not directly referenced by a detected call)
public class RoomInventoryItemTagCreateDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public string <Properties>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RoomInventoryItemTagDTO
//   (not directly referenced by a detected call)
public class RoomInventoryItemTagDTO
{
    public long <TagId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Properties>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RoomInventoryItemTagUpdateDTO
//   (not directly referenced by a detected call)
public class RoomInventoryItemTagUpdateDTO
{
    public long <TagId>k__BackingField;    // 0x0x10
    public string <Properties>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RoomInviteDTO
//   (not directly referenced by a detected call)
public class RoomInviteDTO
{
    public long <RoomInviteId>k__BackingField;    // 0x0x10
    public int <FromPlayerId>k__BackingField;    // 0x0x18
    public int <ToPlayerId>k__BackingField;    // 0x0x1C
    public long <RoomId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RoomKeyConfigDTO
//   (not directly referenced by a detected call)
public class RoomKeyConfigDTO
{
    public int <MaxKeysPerRoom>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.RoomKeyIdDTO
//   (not directly referenced by a detected call)
public class RoomKeyIdDTO
{
    public long <RoomKeyId>k__BackingField;    // 0x0x10
    public Guid <ReplicationId>k__BackingField;    // 0x0x18
    public RoomKeyType <Type>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.RoomKeyResponse
//   RESPONSE PUT    api/roomkeys/v1/   [Service.Econ]
//   RESPONSE POST   api/roomkeys/v1/create   [Service.Matchmaking]
//   REQUEST  POST   api/roomkeys/v1/create   [Service.Econ]
public class RoomKeyResponse
{
    public RoomKeyResult <Status>k__BackingField;    // 0x0x10
    public RoomKey <RoomKey>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferCreateOrUpdateRequestDTO
//   (not directly referenced by a detected call)
public class RoomOfferCreateOrUpdateRequestDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public string <Description>k__BackingField;    // 0x0x18
    public string <ImageName>k__BackingField;    // 0x0x20
    public int <Price>k__BackingField;    // 0x0x28
    public bool <HasDynamicPrice>k__BackingField;    // 0x0x2C
    public int? <MinimumDynamicPrice>k__BackingField;    // 0x0x30
    public int? <MaximumDynamicPrice>k__BackingField;    // 0x0x38
    public int? <MaxNumPurchasesPerPlayer>k__BackingField;    // 0x0x40
    public int? <MaxCountPerPurchase>k__BackingField;    // 0x0x48
    public List<RoomOfferItemMappingDTO> <ItemMappings>k__BackingField;    // 0x0x50
    public Guid? <PriceUnitId>k__BackingField;    // 0x0x58
    public Guid? <OriginId>k__BackingField;    // 0x0x6C
    public bool <AllowRename>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferIdDTO
//   (not directly referenced by a detected call)
public class RoomOfferIdDTO
{
    public Guid <OriginId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferItemMappingDTO
//   (not directly referenced by a detected call)
public class RoomOfferItemMappingDTO
{
    public RoomOfferItemType <ItemType>k__BackingField;    // 0x0x10
    public Guid <ItemOriginId>k__BackingField;    // 0x0x14
    public int <Count>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferLastPurchaseDTO
//   (not directly referenced by a detected call)
public class RoomOfferLastPurchaseDTO
{
    public Guid <RoomOfferOriginId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x20
    public int <PurchasePrice>k__BackingField;    // 0x0x28
    public DateTime <PurchaseDate>k__BackingField;    // 0x0x30
    public int <Version>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferPurchaseCountDTO
//   (not directly referenced by a detected call)
public class RoomOfferPurchaseCountDTO
{
    public Guid <RoomOfferOriginId>k__BackingField;    // 0x0x10
    public int <NumOffersPurchased>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferPurchaseOperationResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum RoomOfferPurchaseOperationResult
{
    Success = 0,
    ConcurrencyCodeMismatch = 1,
    RoomOfferDoesNotExist = 2,
    InvalidRequest = 3,
    AccountIdIsInvalid = 4,
    PlayerIsP2PBuyingRestricted = 5,
    ExpectedOfferTotalPriceMismatch = 6,
    ExpectedOfferVersionMismatch = 7,
    InsufficientBalance = 8,
    OfferUnderModeration = 9,
    InvalidExpectedTotalPrice = 10,
    InvalidExpectedOfferVersion = 11,
    CannotPurchaseMoreThanPerPlayerLimit = 12,
    InvalidExpectedPriceUnit = 13,
    InsufficientInventoryItems = 14,
    InvalidDynamicPriceSettings = 15,
    InvalidDynamicPrice = 16,
    NoConcurrencyCodesForInventoryItem = 100,
    UnexpectedOfferItemType = 101,
    FeatureDisabled = 254,
    UnknownError = 255,
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferPurchaseRequestDTO
//   (not directly referenced by a detected call)
public class RoomOfferPurchaseRequestDTO
{
    public int <NumOffersPurchased>k__BackingField;    // 0x0x10
    public Guid <TransactionId>k__BackingField;    // 0x0x14
    public int <ExpectedTotalPrice>k__BackingField;    // 0x0x24
    public Guid? <ExpectedPriceUnitOriginId>k__BackingField;    // 0x0x28
    public int <ExpectedRoomOfferVersion>k__BackingField;    // 0x0x3C
    public Dictionary<Guid, Guid?> <ConcurrencyCodeByItemOriginIdMap>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferPurchaseResponseDTO
//   (not directly referenced by a detected call)
public class RoomOfferPurchaseResponseDTO
{
    public RoomOfferPurchaseOperationResult <OperationResult>k__BackingField;    // 0x0x10
    public UpdateResponseTypes? <BalanceUpdateResult>k__BackingField;    // 0x0x14
    public BalanceResponseDTO <TokenBalanceResponse>k__BackingField;    // 0x0x20
    public List<PlayerRoomInventoryItemDTO> <PlayerRoomInventoryItems>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.RoomOfferReplicationDTO
// base   : RecNet.RoomOffer
//   (not directly referenced by a detected call)
public class RoomOfferReplicationDTO : RoomOffer
{
    public Guid <RoomOfferId>k__BackingField;    // 0x0xC0
    public Guid? <PriceUnitId>k__BackingField;    // 0x0xD0
}

// --------------------------------------------------------------------------
// RecNet.Rooms.AccountRoleDTO
//   (not directly referenced by a detected call)
public class AccountRoleDTO
{
    public ObscuredInt FYGYRFGTTFK;    // 0x0x10
    public AccountRoleType <Role>k__BackingField;    // 0x0x24
    public int? <LastChangedByAccountId>k__BackingField;    // 0x0x28
    public AccountRoleType <InvitedRole>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.Rooms.BakedUnityAssetDTO
//   (not directly referenced by a detected call)
public class BakedUnityAssetDTO
{
    public Guid <UnityAssetId>k__BackingField;    // 0x0x10
    public byte <Target>k__BackingField;    // 0x0x20
    public int <Version>k__BackingField;    // 0x0x24
    public string <Filename>k__BackingField;    // 0x0x28
    public string <Hash>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.Rooms.BakedUnitySubAssetDTO
//   (not directly referenced by a detected call)
public class BakedUnitySubAssetDTO
{
    public Guid <UnityAssetId>k__BackingField;    // 0x0x10
    public string <UnityAsset>k__BackingField;    // 0x0x20
    public string <UnityAssetHash>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.Rooms.CheerDTO
//   (not directly referenced by a detected call)
public class CheerDTO
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public DateTime <CheeredAt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.CreateRoomAssetRequestDTO
//   (not directly referenced by a detected call)
public class CreateRoomAssetRequestDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public string <Description>k__BackingField;    // 0x0x18
    public FileWithOwnershipProofDTO <DataFile>k__BackingField;    // 0x0x20
    public string <ThumbnailFilename>k__BackingField;    // 0x0x28
    public Guid <OriginId>k__BackingField;    // 0x0x30
    public byte <Type>k__BackingField;    // 0x0x40
    public long? <InventionId>k__BackingField;    // 0x0x48
    public int? <UgcSubVersion>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.Rooms.CreateRoomAssetSaveErrorDTO
//   (not directly referenced by a detected call)
public class CreateRoomAssetSaveErrorDTO
{
    public string <Message>k__BackingField;    // 0x0x10
    public string <LastSavePlayerName>k__BackingField;    // 0x0x18
    public DateTime? <LastSaveCreatedAt>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.CreateRoomAssetSaveRequestDTO
//   (not directly referenced by a detected call)
public class CreateRoomAssetSaveRequestDTO
{
    public FileWithOwnershipProofDTO <DataFile>k__BackingField;    // 0x0x10
    public string <ThumbnailFilename>k__BackingField;    // 0x0x18
    public Guid <ExpectedLastSaveId>k__BackingField;    // 0x0x20
    public bool? <ForceCreateSave>k__BackingField;    // 0x0x30
    public string <Name>k__BackingField;    // 0x0x38
    public string <AssetDescription>k__BackingField;    // 0x0x40
    public string <SaveDescription>k__BackingField;    // 0x0x48
    public bool <UseNewDataFile>k__BackingField;    // 0x0x50
    public bool <UseNewThumbnailFile>k__BackingField;    // 0x0x51
    public bool <ShouldStageSave>k__BackingField;    // 0x0x52
    public int? <UgcSubVersion>k__BackingField;    // 0x0x54
}

// --------------------------------------------------------------------------
// RecNet.Rooms.CreateRoomAssetSaveResponseDTO
//   (not directly referenced by a detected call)
public class CreateRoomAssetSaveResponseDTO
{
    public bool <Success>k__BackingField;    // 0x0x10
    public RoomAssetSaveDTO <Value>k__BackingField;    // 0x0x18
    public CreateRoomAssetSaveErrorDTO <Error>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.ExternalContentReferenceDTO
//   (not directly referenced by a detected call)
public class ExternalContentReferenceDTO
{
    public ExternalContentType <Type>k__BackingField;    // 0x0x10
    public string <Reference>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.ExternalRoomProgressionDTO
//   (not directly referenced by a detected call)
public class ExternalRoomProgressionDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public ExternalRoomProgressionLayoutType <LayoutType>k__BackingField;    // 0x0x18
    public string <LayoutKey>k__BackingField;    // 0x0x20
    public int? <TimeSpentMinutes>k__BackingField;    // 0x0x28
    public RoomLeaderboardDTO <LeaderboardMetadata>k__BackingField;    // 0x0x30
    public SingleLeaderboard <LeaderboardRows>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.Rooms.FavoriteDTO
//   (not directly referenced by a detected call)
public class FavoriteDTO
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public DateTime <FavoritedAt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.FeaturedRoomDTO
//   (not directly referenced by a detected call)
public class FeaturedRoomDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public string <RawRoomName>k__BackingField;    // 0x0x18
    public string <SanitizedRoomName>k__BackingField;    // 0x0x20
    public string <ImageName>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.Rooms.FeaturedRoomGroupDTO
//   (not directly referenced by a detected call)
public class FeaturedRoomGroupDTO
{
    public long <FeaturedRoomGroupId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public IReadOnlyList<FeaturedRoomDTO> <Rooms>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.FileWithOwnershipProofDTO
//   (not directly referenced by a detected call)
public class FileWithOwnershipProofDTO
{
    public string <Filename>k__BackingField;    // 0x0x10
    public string <OwnershipProof>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.InventionAndVersionReplicationIdsDTO
//   (not directly referenced by a detected call)
public class InventionAndVersionReplicationIdsDTO
{
    public Guid <ReplicationId>k__BackingField;    // 0x0x10
    public Guid <VersionReplicationId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.LoadScreenDTO
//   (not directly referenced by a detected call)
public class LoadScreenDTO
{
    public string <ImageName>k__BackingField;    // 0x0x10
    public string <Title>k__BackingField;    // 0x0x18
    public string <Subtitle>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.MagicDoorRoomDTO
//   (not directly referenced by a detected call)
public class MagicDoorRoomDTO
{
    public DateTime <RefreshesAt>k__BackingField;    // 0x0x10
    public int <RefreshIntervalMinutes>k__BackingField;    // 0x0x18
    public RoomDTO <Room>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.MatchmakingSubRoomDTO
// base   : RecNet.Rooms.SubRoomDTO
//   (not directly referenced by a detected call)
public class MatchmakingSubRoomDTO : SubRoomDTO
{
    public bool <SupportsJoinInProgress>k__BackingField;    // 0x0x70
    public bool <UseLevelBasedMatchmaking>k__BackingField;    // 0x0x71
    public bool <UseAgeBasedMatchmaking>k__BackingField;    // 0x0x72
    public bool <UseRecRoyaleMatchmaking>k__BackingField;    // 0x0x73
}

// --------------------------------------------------------------------------
// RecNet.Rooms.PhotonAccessTokenAndPermissionsDTO
//   (not directly referenced by a detected call)
public class PhotonAccessTokenAndPermissionsDTO
{
    public long <RoomInstanceId>k__BackingField;    // 0x0x10
    public string <PhotonAccessToken>k__BackingField;    // 0x0x18
    public IReadOnlyList<RolePermissionDTO> <Permissions>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.PlayerRoomDataDTO
//   (not directly referenced by a detected call)
public class PlayerRoomDataDTO
{
    public string <Data>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Rooms.PublishStagedRoomEntitySavesRequestDTO
//   (not directly referenced by a detected call)
public class PublishStagedRoomEntitySavesRequestDTO
{
    public IReadOnlyList<long> <StagedSubRoomIds>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Rooms.ReplicationRoomDetailsDTO
// base   : RecNet.Rooms.RoomDTO
//   (not directly referenced by a detected call)
public class ReplicationRoomDetailsDTO : RoomDTO
{
    public string <ReplicationId>k__BackingField;    // 0x0x108
    public string <DataBlob>k__BackingField;    // 0x0x110
    public IReadOnlyList<ReplicationSubRoomDTO> <SubRooms>k__BackingField;    // 0x0x118
    public IReadOnlyList<TagDTO> <Tags>k__BackingField;    // 0x0x120
    public IReadOnlyList<UnityAssetWithSourceDTO> <UnityAssets>k__BackingField;    // 0x0x128
    public IReadOnlyList<RolePermissionDTO> <Permissions>k__BackingField;    // 0x0x130
    public RoomExperience <RoomExperience>k__BackingField;    // 0x0x138
}

// --------------------------------------------------------------------------
// RecNet.Rooms.ReplicationSubRoomDTO
// base   : RecNet.Rooms.MatchmakingSubRoomDTO
//   (not directly referenced by a detected call)
public class ReplicationSubRoomDTO : MatchmakingSubRoomDTO
{
    public string <ReplicationId>k__BackingField;    // 0x0x78
    public SubRoomDataSaveReplicationDataDTO <CurrentSaveReplicationData>k__BackingField;    // 0x0x80
}

// --------------------------------------------------------------------------
// RecNet.Rooms.ReplicationUnityAssetsDTO
//   (not directly referenced by a detected call)
public class ReplicationUnityAssetsDTO
{
    public InventionAndVersionReplicationIdsDTO <Invention>k__BackingField;    // 0x0x10
    public List<UnityAssetWithSourceDTO> <UnityAssets>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RolePermissionDTO
//   (not directly referenced by a detected call)
public class RolePermissionDTO
{
    public string <Permission>k__BackingField;    // 0x0x10
    public AccountRoleType <Role>k__BackingField;    // 0x0x18
    public bool <Override>k__BackingField;    // 0x0x19
    public RolePermissionType <Type>k__BackingField;    // 0x0x1A
    public string <Value>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomAssetDTO
//   (not directly referenced by a detected call)
public class RoomAssetDTO
{
    public Guid <RoomAssetId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x20
    public long? <InventionId>k__BackingField;    // 0x0x28
    public RoomAssetSaveDTO <CurrentRoomAssetSave>k__BackingField;    // 0x0x38
    public RoomAssetSaveDTO <LatestRoomAssetSave>k__BackingField;    // 0x0x40
    public Guid? <StagedRoomAssetSaveId>k__BackingField;    // 0x0x48
    public byte <Type>k__BackingField;    // 0x0x5C
    public DateTime <CreatedAt>k__BackingField;    // 0x0x60
    public DateTime <ModifiedAt>k__BackingField;    // 0x0x68
    public Guid <OriginId>k__BackingField;    // 0x0x70
    public bool <IsHidden>k__BackingField;    // 0x0x80
    public bool <ShouldAutoStageSaves>k__BackingField;    // 0x0x81
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomAssetLoadDTO
//   (not directly referenced by a detected call)
public class RoomAssetLoadDTO
{
    public Guid <RoomAssetId>k__BackingField;    // 0x0x10
    public Guid <OriginId>k__BackingField;    // 0x0x20
    public byte <AssetType>k__BackingField;    // 0x0x30
    public StorageFileReferenceDTO <Data>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomAssetSaveDTO
//   (not directly referenced by a detected call)
public class RoomAssetSaveDTO
{
    public Guid <RoomAssetSaveId>k__BackingField;    // 0x0x10
    public Guid <RoomAssetId>k__BackingField;    // 0x0x20
    public string <Name>k__BackingField;    // 0x0x30
    public string <AssetDescription>k__BackingField;    // 0x0x38
    public StorageFileReferenceDTO <DataFile>k__BackingField;    // 0x0x40
    public StorageFileReferenceDTO <ThumbnailImageFile>k__BackingField;    // 0x0x48
    public string <SaveDescription>k__BackingField;    // 0x0x50
    public int <SavedByAccountId>k__BackingField;    // 0x0x58
    public DateTime <CreatedAt>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomBanDTO
//   (not directly referenced by a detected call)
public class RoomBanDTO
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public int? <BannedByAccountId>k__BackingField;    // 0x0x14
    public DateTime <BanStartTime>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomBanDetailsDTO
// base   : RecNet.Rooms.RoomBanDTO
//   (not directly referenced by a detected call)
public class RoomBanDetailsDTO : RoomBanDTO
{
    public RoomBanStatus <Status>k__BackingField;    // 0x0x28
    public int? <UnbannedByAccountId>k__BackingField;    // 0x0x2C
    public DateTime? <BanEndTime>k__BackingField;    // 0x0x38
    public string <Reason>k__BackingField;    // 0x0x48
    public string <BannedByUsername>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomBanHistoryDTO
//   (not directly referenced by a detected call)
public class RoomBanHistoryDTO
{
    public RoomBanDetailsDTO <ActiveBan>k__BackingField;    // 0x0x10
    public List<RoomBanDetailsDTO> <PreviousBans>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomBanNotificationDTO
//   (not directly referenced by a detected call)
public class RoomBanNotificationDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomBoostConsumedNotificationDTO
//   (not directly referenced by a detected call)
public class RoomBoostConsumedNotificationDTO
{
    public Guid <RequestId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x20
    public int <AccountId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomBoostNotificationDTO
//   (not directly referenced by a detected call)
public class RoomBoostNotificationDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public int <GlobalBoostCount>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomDTO
//   (not directly referenced by a detected call)
public class RoomDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomDetailsDTO
// base   : RecNet.Rooms.RoomDTO
//   (not directly referenced by a detected call)
public class RoomDetailsDTO : RoomDTO
{
    public string <DataBlob>k__BackingField;    // 0x0x108
    public string <DataBlobHash>k__BackingField;    // 0x0x110
    public IReadOnlyList<SubRoomDTO> <SubRooms>k__BackingField;    // 0x0x118
    public SubRoomDTO <UnlistedSubroom>k__BackingField;    // 0x0x120
    public IReadOnlyList<AccountRoleDTO> <Roles>k__BackingField;    // 0x0x128
    public IReadOnlyList<TagDTO> <Tags>k__BackingField;    // 0x0x130
    public IReadOnlyList<LoadScreenDTO> <LoadScreens>k__BackingField;    // 0x0x138
    public IReadOnlyList<string> <PromoImages>k__BackingField;    // 0x0x140
    public IReadOnlyList<ExternalContentReferenceDTO> <PromoExternalContent>k__BackingField;    // 0x0x148
    public SubRoomDataSaveModerationState <LastRoomModerationState>k__BackingField;    // 0x0x150
    public SubRoomDataSaveModerationState <CurrentRoomModerationState>k__BackingField;    // 0x0x151
    public IReadOnlyList<string> <FlaggedAssets>k__BackingField;    // 0x0x158
    public string <ModeratorMessage>k__BackingField;    // 0x0x160
    public RoomBanDetailsDTO <RoomBanDetails>k__BackingField;    // 0x0x168
    public Guid? <CurrentRoomLoadSnapshotId>k__BackingField;    // 0x0x170
    public Guid? <LatestRoomLoadSnapshotId>k__BackingField;    // 0x0x184
    public Guid? <StagedRoomLoadSnapshotId>k__BackingField;    // 0x0x198
    public Guid? <CompatibleRoomLoadSnapshotId>k__BackingField;    // 0x0x1AC
    public RoomPublishStateAvailabilityDTO <PublishStateAvailability>k__BackingField;    // 0x0x1C0
    public IReadOnlyList<string> <RestrictedCircuitsAllowListNames>k__BackingField;    // 0x0x1C8
    public IReadOnlyList<string> OCPNFFCCXDS;    // 0x0x1D0
    public IReadOnlyList<string> CBHUTUUUMYQ;    // 0x0x1D8
    public IReadOnlyList<string> YRZFRUKCTQO;    // 0x0x1E0
    public string CHLYCVTJPAF;    // 0x0x1E8
    public IReadOnlyList<string> DEBSDJREOGX;    // 0x0x1F0
    public bool? DVYHZWQNDWX;    // 0x0x1F8
    public bool? IOYTSHWGZUK;    // 0x0x1FA
    public IReadOnlyList<ObscuredInt> MQMWNVSLAOM;    // 0x0x200
    public IReadOnlyList<ObscuredInt> LVQGKCZWDIW;    // 0x0x208
    public ObscuredInt? HUGWGLAYZHV;    // 0x0x210
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomEconReplicationDTO
//   (not directly referenced by a detected call)
public class RoomEconReplicationDTO
{
    public IReadOnlyList<RoomOfferReplicationDTO> <RoomOffers>k__BackingField;    // 0x0x10
    public IReadOnlyList<RoomInventoryItemReplicationDTO> <RoomInventoryItems>k__BackingField;    // 0x0x18
    public IReadOnlyList<RoomInventoryItemTagDTO> <RoomInventoryItemTags>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomLeaderboardDTO
//   (not directly referenced by a detected call)
public class RoomLeaderboardDTO
{
    public int <StatChannel>k__BackingField;    // 0x0x10
    public string <ShortTitle>k__BackingField;    // 0x0x18
    public GameUIDataModelStatFormat <StatFormat>k__BackingField;    // 0x0x20
    public bool <SortAscending>k__BackingField;    // 0x0x24
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomLoadDTO
//   (not directly referenced by a detected call)
public class RoomLoadDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public Guid <RoomSnapshotId>k__BackingField;    // 0x0x18
    public long? <SubRoomId>k__BackingField;    // 0x0x28
    public SubRoomLoadDTO <SubRoom>k__BackingField;    // 0x0x38
    public IReadOnlyList<RoomAssetLoadDTO> <Assets>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomPublishStateAvailabilityDTO
//   (not directly referenced by a detected call)
public class RoomPublishStateAvailabilityDTO
{
    public bool <CanSaveAsBeta>k__BackingField;    // 0x0x10
    public bool <CanSaveAsUpdate>k__BackingField;    // 0x0x11
    public int <AvailableUpdateTokenCount>k__BackingField;    // 0x0x14
    public DateTime? <NextAvailableUpdateDateTimeUtc>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomPublishStateConfigDTO
//   (not directly referenced by a detected call)
public class RoomPublishStateConfigDTO
{
    public int <UpdateMaxCount>k__BackingField;    // 0x0x10
    public int <UpdateRollingWindowInDays>k__BackingField;    // 0x0x14
    public int <UpdateExpirationInDays>k__BackingField;    // 0x0x18
    public int <UpdateCooldownInDays>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.Rooms.RoomRecommendationGroupDTO
//   (not directly referenced by a detected call)
public class RoomRecommendationGroupDTO
{
    public RoomDTO <SeedRoom>k__BackingField;    // 0x0x10
    public IReadOnlyList<RoomDTO> <Rooms>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.SaveSubRoomRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class SaveSubRoomRequest : ValueType
{
    public long roomId;    // 0x0x0
    public long subRoomId;    // 0x0x8
    public Guid? unityAssetId;    // 0x0x10
    public IReadOnlyCollection<Guid> referencedUnityAssetIds;    // 0x0x28
    public UploadFileResponseDTO roomData;    // 0x0x30
    public UploadFileResponseDTO subRoomData;    // 0x0x38
    public IReadOnlyDictionary<long, int> inventionUsage;    // 0x0x40
    public int persistenceVersion;    // 0x0x48
    public int omVersion;    // 0x0x4C
    public string description;    // 0x0x50
    public bool autoPublish;    // 0x0x58
    public bool shouldStageSave;    // 0x0x59
    public int saveRequestPlayerId;    // 0x0x5C
    public IReadOnlyList<Guid> roomAssetOriginIds;    // 0x0x60
    public int ugcSubVersion;    // 0x0x68
}

// --------------------------------------------------------------------------
// RecNet.Rooms.SaveSubRoomRequestDTO
//   (not directly referenced by a detected call)
public class SaveSubRoomRequestDTO
{
    public Guid? <UnityAssetId>k__BackingField;    // 0x0x10
    public IReadOnlyCollection<Guid> <ReferencedUnityAssetIds>k__BackingField;    // 0x0x28
    public UploadFileResponseDTO <RoomData>k__BackingField;    // 0x0x30
    public UploadFileResponseDTO <SubRoomData>k__BackingField;    // 0x0x38
    public string <InventionUsage>k__BackingField;    // 0x0x40
    public int <PersistenceVersion>k__BackingField;    // 0x0x48
    public int <OMVersion>k__BackingField;    // 0x0x4C
    public string <Description>k__BackingField;    // 0x0x50
    public bool <AutoPublish>k__BackingField;    // 0x0x58
    public bool <ShouldStageSave>k__BackingField;    // 0x0x59
    public IReadOnlyList<Guid> <RoomAssetOriginIds>k__BackingField;    // 0x0x60
    public int? <UgcSubVersion>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// RecNet.Rooms.SaveSubRoomResponseDTO
//   (not directly referenced by a detected call)
public class SaveSubRoomResponseDTO
{
    public RoomDetailsDTO <Room>k__BackingField;    // 0x0x10
    public SubRoomDataSaveDTO <SubRoomDataSave>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.StorageFileReferenceDTO
//   (not directly referenced by a detected call)
public class StorageFileReferenceDTO
{
    public string <Filename>k__BackingField;    // 0x0x10
    public string <Hash>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.SubRoomDTO
//   (not directly referenced by a detected call)
public class SubRoomDTO
{
    public long <SubRoomId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x18
    public string <UnitySceneId>k__BackingField;    // 0x0x20
    public RoomSceneLocations <Location>k__BackingField;    // 0x0x28
    public string <RawName>k__BackingField;    // 0x0x30
    public string <SanitizedName>k__BackingField;    // 0x0x38
    public SubRoomDataSaveDTO <CurrentSave>k__BackingField;    // 0x0x40
    public SubRoomDataSaveModerationState <LastModeratedSaveModerationState>k__BackingField;    // 0x0x48
    public bool <IsSandbox>k__BackingField;    // 0x0x49
    public int <MaxPlayers>k__BackingField;    // 0x0x4C
    public Accessibility <Accessibility>k__BackingField;    // 0x0x50
    public RoomInstanceMatchmakingPolicy <DefaultMatchmakingPolicy>k__BackingField;    // 0x0x54
    public bool <ShouldAutoStageSaves>k__BackingField;    // 0x0x58
    public long? <StagedSubRoomDataSaveId>k__BackingField;    // 0x0x60
}

// --------------------------------------------------------------------------
// RecNet.Rooms.SubRoomDataSaveDTO
//   (not directly referenced by a detected call)
public class SubRoomDataSaveDTO
{
    public long <SubRoomDataSaveId>k__BackingField;    // 0x0x10
    public long <SubRoomId>k__BackingField;    // 0x0x18
    public Guid? <UnityAssetId>k__BackingField;    // 0x0x20
    public IReadOnlyCollection<Guid> <ReferencedUnityAssetIds>k__BackingField;    // 0x0x38
    public string <DataBlob>k__BackingField;    // 0x0x40
    public string <DataBlobHash>k__BackingField;    // 0x0x48
    public int <PersistenceVersion>k__BackingField;    // 0x0x50
    public int <OMVersion>k__BackingField;    // 0x0x54
    public int? <SavedByAccountId>k__BackingField;    // 0x0x58
    public PlatformType? <SavedOnPlatform>k__BackingField;    // 0x0x60
    public DeviceClass? <SavedOnDeviceClass>k__BackingField;    // 0x0x68
    public string <Description>k__BackingField;    // 0x0x70
    public SubRoomDataSaveModerationState <ModerationState>k__BackingField;    // 0x0x78
    public DateTime <CreatedAt>k__BackingField;    // 0x0x80
    public int? <UgcSubVersion>k__BackingField;    // 0x0x88
}

// --------------------------------------------------------------------------
// RecNet.Rooms.SubRoomDataSaveReplicationDataDTO
//   (not directly referenced by a detected call)
public class SubRoomDataSaveReplicationDataDTO
{
    public string <InventionUsage>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Rooms.SubRoomDataSaveWithUnityAssetsDTO
// base   : RecNet.Rooms.SubRoomDataSaveDTO
//   (not directly referenced by a detected call)
public class SubRoomDataSaveWithUnityAssetsDTO : SubRoomDataSaveDTO
{
    public List<BakedUnitySubAssetDTO> <UnitySubAssets>k__BackingField;    // 0x0x90
    public List<BakedUnitySubAssetDTO> <ReferencedUnityAssets>k__BackingField;    // 0x0x98
    public string <UnityAsset>k__BackingField;    // 0x0xA0
    public string <UnityAssetHash>k__BackingField;    // 0x0xA8
}

// --------------------------------------------------------------------------
// RecNet.Rooms.SubRoomLoadDTO
//   (not directly referenced by a detected call)
public class SubRoomLoadDTO
{
    public long <SubRoomDataSaveId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.Rooms.TagDTO
//   (not directly referenced by a detected call)
public class TagDTO
{
    public string <Tag>k__BackingField;    // 0x0x10
    public TagType <Type>k__BackingField;    // 0x0x18
    public bool <IsPrimaryGenre>k__BackingField;    // 0x0x19
}

// --------------------------------------------------------------------------
// RecNet.Rooms.UnityAssetDTO
//   (not directly referenced by a detected call)
public class UnityAssetDTO
{
    public Guid <UnityAssetId>k__BackingField;    // 0x0x10
    public int? <CreatedByAccountId>k__BackingField;    // 0x0x20
    public IReadOnlyList<BakedUnityAssetDTO> <BakedUnityAssets>k__BackingField;    // 0x0x28
    public IReadOnlyList<UnitySubAssetDTO> <SubAssets>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.Rooms.UnityAssetWithSourceDTO
// base   : RecNet.Rooms.UnityAssetDTO
//   (not directly referenced by a detected call)
public class UnityAssetWithSourceDTO : UnityAssetDTO
{
    public string <Filename>k__BackingField;    // 0x0x38
    public string <Hash>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.Rooms.UnitySceneDTO
//   (not directly referenced by a detected call)
public class UnitySceneDTO
{
    public string <UnitySceneId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public int <MaxPlayers>k__BackingField;    // 0x0x20
    public bool <SupportsVRLow>k__BackingField;    // 0x0x24
    public bool <SupportsQuest2>k__BackingField;    // 0x0x25
    public bool <SupportsMobile>k__BackingField;    // 0x0x26
    public byte <UgcVersion>k__BackingField;    // 0x0x27
}

// --------------------------------------------------------------------------
// RecNet.Rooms.UnitySubAssetDTO
//   (not directly referenced by a detected call)
public class UnitySubAssetDTO
{
    public Guid <UnityAssetId>k__BackingField;    // 0x0x10
    public string <OriginId>k__BackingField;    // 0x0x20
    public int? <CreatedByAccountId>k__BackingField;    // 0x0x28
    public List<BakedUnityAssetDTO> <BakedUnityAssets>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.Rooms.UserInteractionDTO
//   (not directly referenced by a detected call)
public class UserInteractionDTO
{
    public bool <Cheered>k__BackingField;    // 0x0x10
    public bool <Favorited>k__BackingField;    // 0x0x11
    public DateTime? <LastVisitedAt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Rooms.UserInteractionStatisticsDTO
//   (not directly referenced by a detected call)
public class UserInteractionStatisticsDTO
{
    public int <CheerCount>k__BackingField;    // 0x0x10
    public int <FavoriteCount>k__BackingField;    // 0x0x14
    public int <VisitorCount>k__BackingField;    // 0x0x18
    public int <VisitCount>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.Rooms.VisitorDTO
//   (not directly referenced by a detected call)
public class VisitorDTO
{
    public int <AccountId>k__BackingField;    // 0x0x10
    public DateTime <LastVisitedAt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.SKUButtonConfigDTO
//   (not directly referenced by a detected call)
public class SKUButtonConfigDTO
{
    public string <Text>k__BackingField;    // 0x0x10
    public string <Type>k__BackingField;    // 0x0x18
    public SKUButtonAction <OnClick>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.SKUConfigCollectionDTO
//   (not directly referenced by a detected call)
public class SKUConfigCollectionDTO
{
    public int <Version>k__BackingField;    // 0x0x10
    public List<SKUConfigDTO> <SkuConfigs>k__BackingField;    // 0x0x18
    public Dictionary<string, string> <StringReplacements>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.SKUConfigDTO
//   (not directly referenced by a detected call)
public class SKUConfigDTO
{
    public int <SkuId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public string <ThumbnailImageName>k__BackingField;    // 0x0x28
    public string <DetailsImageName>k__BackingField;    // 0x0x30
    public bool? <ShowSkuDetails>k__BackingField;    // 0x0x38
    public SKUFooterConfigDTO <Footer>k__BackingField;    // 0x0x40
    public Dictionary<string, SKUDialogConfigDTO> <DialogConfigs>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.SKUDialogConfigDTO
//   (not directly referenced by a detected call)
public class SKUDialogConfigDTO
{
    public string <Title>k__BackingField;    // 0x0x10
    public string <Text>k__BackingField;    // 0x0x18
    public string <SpriteName>k__BackingField;    // 0x0x20
    public List<SKUButtonConfigDTO> <Buttons>k__BackingField;    // 0x0x28
    public SKUFooterConfigDTO <Footer>k__BackingField;    // 0x0x30
    public long <Cooldown>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.SKUFooterConfigDTO
//   (not directly referenced by a detected call)
public class SKUFooterConfigDTO
{
    public string <Text>k__BackingField;    // 0x0x10
    public string <ExternalUrl>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.ScoreDTO
//   (not directly referenced by a detected call)
public class ScoreDTO
{
    public string <ScoreName>k__BackingField;    // 0x0x10
    public float <ScoreValue>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.SendMessageMultipleRequestDTO
//   REQUEST  POST   api/messages/v1/sendMultiple   [Service.API]
public class SendMessageMultipleRequestDTO
{
    public List<long> <ToPlayerIds>k__BackingField;    // 0x0x10
    public MessageType <Type>k__BackingField;    // 0x0x18
    public string <Data>k__BackingField;    // 0x0x20
    public long? <RoomId>k__BackingField;    // 0x0x28
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
// RecNet.SendOnlineStatusToFriendsResultDTO
//   (not directly referenced by a detected call)
public class SendOnlineStatusToFriendsResultDTO
{
    public int <FriendsOnlineCount>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.ServerMaintenanceDTO
//   (not directly referenced by a detected call)
public class ServerMaintenanceDTO
{
    public int <StartsInMinutes>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.SetInventionVersionAccessibilityRequest
//   REQUEST  PUT    api/inventions/v2/accessibility   [Service.API]
public class SetInventionVersionAccessibilityRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public int <VersionNumber>k__BackingField;    // 0x0x18
    public UgcAccessibility <NewAccessibility>k__BackingField;    // 0x0x1C
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
// RecNet.SimpleRoomInstancesSummaryByRoomDTO
//   (not directly referenced by a detected call)
public class SimpleRoomInstancesSummaryByRoomDTO
{
    public long <RoomId>k__BackingField;    // 0x0x10
    public int <PlayerCount>k__BackingField;    // 0x0x18
    public int <RoomInstanceCount>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.SpecialTags
//   RESPONSE GET    api/inventions/v1/specialTags   [Service.API]
public class SpecialTags
{
    public List<string> <AutoTags>k__BackingField;    // 0x0x10
    public List<string> <AGOnlyTags>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.StatsigExperimentConfigDTO
//   (not directly referenced by a detected call)
public class StatsigExperimentConfigDTO
{
    public string <ExperimentName>k__BackingField;    // 0x0x10
    public string <Status>k__BackingField;    // 0x0x18
    public string <LayerName>k__BackingField;    // 0x0x20
    public List<string> <ParameterNames>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecNet.StatsigMemoryOverrideParameterBranchValueDTO
//   (not directly referenced by a detected call)
public class StatsigMemoryOverrideParameterBranchValueDTO
{
    public string <BranchName>k__BackingField;    // 0x0x10
    public string <ParameterValue>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.StatsigMemoryOverrideParameterDTO
//   (not directly referenced by a detected call)
public class StatsigMemoryOverrideParameterDTO
{
    public string <LayerName>k__BackingField;    // 0x0x10
    public string <ExperimentName>k__BackingField;    // 0x0x18
    public string <ParameterName>k__BackingField;    // 0x0x20
    public string <ParameterValue>k__BackingField;    // 0x0x28
    public List<StatsigMemoryOverrideParameterBranchValueDTO> <BranchValueOverrides>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecNet.Store.SkuPurchaseResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class SkuPurchaseResult : ValueType
{
    public States State;    // 0x0x0
    public PurchaseFailureType PurchaseFailureType;    // 0x0x1
    public PurchaseFailureError PurchaseFailureError;    // 0x0x4
}

// --------------------------------------------------------------------------
// RecNet.StorefrontBalanceAddConfigDTO
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/balanceAddType/{id0}/{id1}   [Service.Econ]
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
// RecNet.StorefrontBalanceType
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum StorefrontBalanceType
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
    RoomieEnergyPack = 1101,
}

// --------------------------------------------------------------------------
// RecNet.StorefrontConfig
//   (not directly referenced by a detected call)
public class StorefrontConfig
{
    public int <MinPlayerLevelForGifting>k__BackingField;    // 0x0x10
    public DateTime <LatestStoreBadgeDateTime>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.StorefrontGiftDrop
//   (not directly referenced by a detected call)
public class StorefrontGiftDrop
{
    public int <GiftDropId>k__BackingField;    // 0x0x10
    public string <FriendlyName>k__BackingField;    // 0x0x18
    public string <Tooltip>k__BackingField;    // 0x0x20
    public string <TagList>k__BackingField;    // 0x0x28
    public string <ConsumableItemDesc>k__BackingField;    // 0x0x30
    public AvatarItemDesc? <AvatarItemDescOverride>k__BackingField;    // 0x0x38
    public string <AvatarItemDescOrHairDyeDesc>k__BackingField;    // 0x0x70
    public Guid? <CustomAvatarItemId>k__BackingField;    // 0x0x78
    public AvatarItemType? <AvatarItemType>k__BackingField;    // 0x0x8C
    public string <EquipmentPrefabName>k__BackingField;    // 0x0x98
    public string <EquipmentModificationGuid>k__BackingField;    // 0x0xA0
    public bool <IsQuery>k__BackingField;    // 0x0xA8
    public bool <Unique>k__BackingField;    // 0x0xA9
    public bool <SubscribersOnly>k__BackingField;    // 0x0xAA
    public GiftRarity <Rarity>k__BackingField;    // 0x0xAC
    public CurrencyType <CurrencyType>k__BackingField;    // 0x0xB0
    public int <Currency>k__BackingField;    // 0x0xB4
    public GiftBoxContents <Content>k__BackingField;    // 0x0xB8
    public GiftContext <Context>k__BackingField;    // 0x0xBC
    public int? <ItemSetId>k__BackingField;    // 0x0xC0
    public string <ItemSetFriendlyName>k__BackingField;    // 0x0xC8
    public int? <AvatarItemId>k__BackingField;    // 0x0xD0
    public int? <EquipmentItemId>k__BackingField;    // 0x0xD8
    public string <ThumbnailImageName>k__BackingField;    // 0x0xE0
}

// --------------------------------------------------------------------------
// RecNet.StorefrontSeasonDTO
// base   : RecNet.BaseStorefrontDTO
//   RESPONSE GET    api/storefronts/   [Service.Econ]
//   RESPONSE GET    api/storefronts/v1/season/{seasonId}   [Service.Econ]
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
// RecNet.Strings.GetAllStringsForLocaleResponseDTO
//   (not directly referenced by a detected call)
public class GetAllStringsForLocaleResponseDTO
{
    public Dictionary<string, string> <Strings>k__BackingField;    // 0x0x10
    public string <StringPackageVersion>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.Studio.PushToStudioRequestDTO
//   (not directly referenced by a detected call)
public class PushToStudioRequestDTO
{
    public string <SessionId>k__BackingField;    // 0x0x10
    public long <RoomId>k__BackingField;    // 0x0x18
    public long <SubRoomId>k__BackingField;    // 0x0x20
    public Guid? <UnityAssetId>k__BackingField;    // 0x0x28
    public UploadFileResponseDTO <RoomData>k__BackingField;    // 0x0x40
    public UploadFileResponseDTO <SubRoomData>k__BackingField;    // 0x0x48
    public int? <SavedByAccountId>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.Studio.RemoteRunDTO
//   (not directly referenced by a detected call)
public class RemoteRunDTO
{
    public string <SessionId>k__BackingField;    // 0x0x10
    public long? <RoomId>k__BackingField;    // 0x0x18
    public long? <SubRoomId>k__BackingField;    // 0x0x28
    public Guid? <UnityAssetId>k__BackingField;    // 0x0x38
    public string <RoomDataFilename>k__BackingField;    // 0x0x50
    public string <RoomDataHash>k__BackingField;    // 0x0x58
    public string <SubRoomDataFilename>k__BackingField;    // 0x0x60
    public string <SubRoomDataHash>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// RecNet.SubscriptionSeason
//   RESPONSE GET    api/subscriptionseasons/v1/seasons/current   [Service.Auth]
public class SubscriptionSeason
{
    public Guid <SubscriptionSeasonId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x20
    public string <ImageName>k__BackingField;    // 0x0x28
    public DateTime <StartAt>k__BackingField;    // 0x0x30
    public DateTime? <NextSeasonStart>k__BackingField;    // 0x0x38
    public List<SubscriptionSeasonMilestone> <Milestones>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecNet.SubscriptionSeasonMilestone
//   (not directly referenced by a detected call)
public class SubscriptionSeasonMilestone
{
    public Guid <SubscriptionSeasonMilestoneId>k__BackingField;    // 0x0x10
    public Guid <SeasonId>k__BackingField;    // 0x0x20
    public DateTime <StartAt>k__BackingField;    // 0x0x30
    public List<StorefrontGiftDrop> <GiftDrops>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.Tags.GetFiltersResponse
//   RESPONSE GET    api/inventions/v1/tagfilters   [Service.API]
//   RESPONSE GET    api/playerevents/v1/tagfilters   [Service.API]
public class GetFiltersResponse
{
    public List<string> <PinnedFilters>k__BackingField;    // 0x0x10
    public List<string> <PopularFilters>k__BackingField;    // 0x0x18
    public List<string> <TrendingFilters>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecNet.Tags.ModifyTagsResponse
//   RESPONSE POST   api/inventions/v1/settags   [Service.API]
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
//   RESPONSE GET    api/testcasemanagement/v1/testcase/   [Service.API]
public class TestCase
{
    public string <Id>k__BackingField;    // 0x0x10
    public string <Key>k__BackingField;    // 0x0x18
    public string <Title>k__BackingField;    // 0x0x20
    public string <Description>k__BackingField;    // 0x0x28
    public string <RoomName>k__BackingField;    // 0x0x30
    public TestCaseStatus <Status>k__BackingField;    // 0x0x38
    public List<string> <AssignedPlayerNames>k__BackingField;    // 0x0x40
    public List<string> <Tags>k__BackingField;    // 0x0x48
    public string <JiraUrl>k__BackingField;    // 0x0x50
    public List<TestCaseComment> <Comments>k__BackingField;    // 0x0x58
}

// --------------------------------------------------------------------------
// RecNet.TestCaseComment
//   (not directly referenced by a detected call)
public class TestCaseComment
{
    public DateTime <CreatedAt>k__BackingField;    // 0x0x10
    public string <Comment>k__BackingField;    // 0x0x18
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
    Blocked = 4,
}

// --------------------------------------------------------------------------
// RecNet.TestPass
//   RESPONSE GET    api/testcasemanagement/   [Service.API]
//   RESPONSE GET    api/testcasemanagement/v1/testpass/{testpassId}   [Service.API]
public class TestPass
{
    public uint <Id>k__BackingField;    // 0x0x10
    public uint? <TestPlanId>k__BackingField;    // 0x0x14
    public string <Name>k__BackingField;    // 0x0x20
    public string <Description>k__BackingField;    // 0x0x28
    public DateTime <StartDate>k__BackingField;    // 0x0x30
    public DateTime? <EndDate>k__BackingField;    // 0x0x38
    public bool <WasManuallyClosed>k__BackingField;    // 0x0x48
    public List<TestCase> <TestCases>k__BackingField;    // 0x0x50
    public List<string> <Tags>k__BackingField;    // 0x0x58
    public int <NumTestCases>k__BackingField;    // 0x0x60
    public int <NumPassedTestCases>k__BackingField;    // 0x0x64
    public int <NumFailedTestCases>k__BackingField;    // 0x0x68
}

// --------------------------------------------------------------------------
// RecNet.TimedCurrencyGrantDTO
//   RESPONSE GET    api/timedCurrencyGrants   [Service.Econ]
//   RESPONSE GET    api/timedCurrencyGrants/{timedcurrencygrantId}   [Service.Econ]
public class TimedCurrencyGrantDTO
{
    public long <TimedCurrencyGrantId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public DateTime <StartTime>k__BackingField;    // 0x0x20
    public DateTime <EndTime>k__BackingField;    // 0x0x28
    public CurrencyType <CurrencyType>k__BackingField;    // 0x0x30
    public float <OfflineRatePerHour>k__BackingField;    // 0x0x34
    public float <OnlineRatePerHour>k__BackingField;    // 0x0x38
    public string <ActiveExperiment>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecNet.TimedRewardTrackDTO
//   RESPONSE GET    api/timedRewardTracks   [Service.Econ]
//   RESPONSE GET    api/timedRewardTracks/{timedrewardtrackId}   [Service.Econ]
public class TimedRewardTrackDTO
{
    public long <TrackId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public DateTime <StartTime>k__BackingField;    // 0x0x20
    public DateTime <EndTime>k__BackingField;    // 0x0x28
    public int <RequiredXp>k__BackingField;    // 0x0x30
    public int <GiftDropId>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// RecNet.TimedRewardTrackRecordDTO
//   RESPONSE GET    api/timedRewardTracks   [Service.Econ]
//   RESPONSE GET    api/timedRewardTracks/{timedrewardtrackId}/record   [Service.Econ]
public class TimedRewardTrackRecordDTO
{
    public long <TrackId>k__BackingField;    // 0x0x10
    public int <AccountId>k__BackingField;    // 0x0x18
    public int <Xp>k__BackingField;    // 0x0x1C
}

// --------------------------------------------------------------------------
// RecNet.TokenSpendPurchaseReminderBalanceModificationResponse
// base   : RecNet.XCSZDSPAGRE`1<RecNet.GiftPackage>
//   (not directly referenced by a detected call)
public class TokenSpendPurchaseReminderBalanceModificationResponse
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecNet.UnpublishInventionRequest
//   REQUEST  POST   api/inventions/v2/unpublish   [Service.API]
public class UnpublishInventionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecNet.UpdateInventionGeneralPermissionRequest
//   REQUEST  POST   api/inventions/v2/update   [Service.API]
public class UpdateInventionGeneralPermissionRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public InventionPermission <Permission>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.UpdateInventionMetadataRequest
//   REQUEST  PUT    api/inventions/v2/metadata   [Service.Data]
public class UpdateInventionMetadataRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public string <LongDescription>k__BackingField;    // 0x0x28
    public string <ImageName>k__BackingField;    // 0x0x30
    public ModifyTagsRequest <TagsRequest>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecNet.UpdatePriceRequest
//   REQUEST  POST   api/inventions/v2/updateprice   [Service.API]
public class UpdatePriceRequest
{
    public long <InventionId>k__BackingField;    // 0x0x10
    public int <Price>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecNet.VoiceConnectionDTO
//   (not directly referenced by a detected call)
public class VoiceConnectionDTO
{
    public long <VoiceConnectionId>k__BackingField;    // 0x0x10
    public int <AccountId>k__BackingField;    // 0x0x18
    public long <ChatThreadId>k__BackingField;    // 0x0x20
    public string <AuthToken>k__BackingField;    // 0x0x28
    public string <Address>k__BackingField;    // 0x0x30
    public string <ServerName>k__BackingField;    // 0x0x38
    public string <Cluster>k__BackingField;    // 0x0x40
    public string <Version>k__BackingField;    // 0x0x48
    public DateTime <CreatedAt>k__BackingField;    // 0x0x50
}

// --------------------------------------------------------------------------
// RecNet.VoicePresencesDTO
//   (not directly referenced by a detected call)
public class VoicePresencesDTO
{
    public long <VoiceConnectionId>k__BackingField;    // 0x0x10
    public List<int> <AccountIds>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class BaseDTO
{
    public string <Id>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.FileDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class FileDTO : BaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.MessageContentDTO
//   (not directly referenced by a detected call)
public class MessageContentDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Text>k__BackingField;    // 0x0x18
    public FKDBUPKDFPD <ImageFile>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.MessageDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class MessageDTO : BaseDTO
{
    public List<RCOARBGJVSG> <Content>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.RunDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class RunDTO : BaseDTO
{
    public string <ThreadId>k__BackingField;    // 0x0x18
    public RunStatus <Status>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Assistant.ThreadDTO
// base   : RecRoom.AI.OpenAI.Assistant.BaseDTO
//   (not directly referenced by a detected call)
public class ThreadDTO : BaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ClientEventBaseDTO : EventBaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationCreatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationCreatedEventDTO : EventBaseDTO
{
    public ConversationDTO <Conversation>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationDTO
//   (not directly referenced by a detected call)
public class ConversationDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemContentDTO
//   (not directly referenced by a detected call)
public class ConversationItemContentDTO
{
    public ConversationItemContentType <Type>k__BackingField;    // 0x0x10
    public string <Text>k__BackingField;    // 0x0x18
    public string <Id>k__BackingField;    // 0x0x20
    public string <Audio>k__BackingField;    // 0x0x28
    public string <Transcript>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemCreateEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemCreateEventDTO : ClientEventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemCreatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemCreatedEventDTO : EventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDTO
//   (not directly referenced by a detected call)
public class ConversationItemDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public ConversationItemType <Type>k__BackingField;    // 0x0x18
    public Role? <Role>k__BackingField;    // 0x0x1C
    public List<ConversationItemContentDTO> <Content>k__BackingField;    // 0x0x28
    public string <CallId>k__BackingField;    // 0x0x30
    public string <Name>k__BackingField;    // 0x0x38
    public string <Arguments>k__BackingField;    // 0x0x40
    public string <Output>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDeleteEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemDeleteEventDTO : ClientEventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemDeletedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemDeletedEventDTO : EventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemInputAudioTranscriptionCompletedEventDTO : EventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
    public int <ContentIndex>k__BackingField;    // 0x0x28
    public string <Transcript>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ConversationItemTruncateEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ConversationItemTruncateEventDTO : ClientEventBaseDTO
{
    public string <ItemId>k__BackingField;    // 0x0x20
    public long <AudioEndMs>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ErrorDTO
//   (not directly referenced by a detected call)
public class ErrorDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Code>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
    public string <Param>k__BackingField;    // 0x0x28
    public string <EventId>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ErrorEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ErrorEventDTO : EventBaseDTO
{
    public ErrorDTO <Error>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class EventBaseDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <EventId>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferAppendEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferAppendEventDTO : ClientEventBaseDTO
{
    public string <Audio>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferCommitEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferCommitEventDTO : ClientEventBaseDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferCommittedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferCommittedEventDTO : EventBaseDTO
{
    public string <PreviousItemId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferSpeechStartedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferSpeechStartedEventDTO : EventBaseDTO
{
    public int <AudioStartMs>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioBufferSpeechStoppedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class InputAudioBufferSpeechStoppedEventDTO : EventBaseDTO
{
    public int <AudioEndMs>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputAudioTranscriptionDTO
//   (not directly referenced by a detected call)
public class InputAudioTranscriptionDTO
{
    public string <Model>k__BackingField;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.InputTokenDetailsDTO
// base   : RecRoom.AI.OpenAI.Realtime.TokenDetailsDTO
//   (not directly referenced by a detected call)
public class InputTokenDetailsDTO : TokenDetailsDTO
{
    public int <CachedTokens>k__BackingField;    // 0x0x18
    public TokenDetailsDTO <CachedTokensDetails>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.OutputAudioBufferClearedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.OutputAudioBufferEventDTO
//   (not directly referenced by a detected call)
public class OutputAudioBufferClearedEventDTO : OutputAudioBufferEventDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.OutputAudioBufferEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class OutputAudioBufferEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.OutputAudioBufferStartedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.OutputAudioBufferEventDTO
//   (not directly referenced by a detected call)
public class OutputAudioBufferStartedEventDTO : OutputAudioBufferEventDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.OutputAudioBufferStoppedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.OutputAudioBufferEventDTO
//   (not directly referenced by a detected call)
public class OutputAudioBufferStoppedEventDTO : OutputAudioBufferEventDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.RateLimitDTO
//   (not directly referenced by a detected call)
public class RateLimitDTO
{
    public string <Name>k__BackingField;    // 0x0x10
    public int <Limit>k__BackingField;    // 0x0x18
    public int <Remaining>k__BackingField;    // 0x0x1C
    public float <ResetSeconds>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.RateLimitsUpdatedEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class RateLimitsUpdatedEventDTO : EventBaseDTO
{
    public RateLimitDTO[] <RateLimits>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Delta>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseAudioTranscriptDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseAudioTranscriptDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Transcript>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseContentPartEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseContentPartEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public ConversationItemContentDTO <Part>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseCreateEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseCreateEventDTO : ClientEventBaseDTO
{
    public ResponseDTO <Response>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseDTO
//   (not directly referenced by a detected call)
public class ResponseDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public ResponseStatus <Status>k__BackingField;    // 0x0x18
    public ResponseStatusDetailsDTO <StatusDetails>k__BackingField;    // 0x0x20
    public List<ConversationItemDTO> <Output>k__BackingField;    // 0x0x28
    public TokenUsageDTO <Usage>k__BackingField;    // 0x0x30
    public Dictionary<string, string> <Metadata>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseErrorDTO
//   (not directly referenced by a detected call)
public class ResponseErrorDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Code>k__BackingField;    // 0x0x18
    public string <Message>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseEventDTO : EventBaseDTO
{
    public ResponseDTO <Response>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseFunctionCallArgumentsDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public string <CallId>k__BackingField;    // 0x0x38
    public string <Delta>k__BackingField;    // 0x0x40
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseFunctionCallArgumentsDoneEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseFunctionCallArgumentsDoneEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public string <CallId>k__BackingField;    // 0x0x38
    public string <Name>k__BackingField;    // 0x0x40
    public string <Arguments>k__BackingField;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseOutputItemEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseOutputItemEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public int <OutputIndex>k__BackingField;    // 0x0x28
    public ConversationItemDTO <Item>k__BackingField;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseStatusDetailsDTO
//   (not directly referenced by a detected call)
public class ResponseStatusDetailsDTO
{
    public ResponseStatus <Type>k__BackingField;    // 0x0x10
    public string <Reason>k__BackingField;    // 0x0x18
    public ResponseErrorDTO <Error>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ResponseTextDeltaEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class ResponseTextDeltaEventDTO : EventBaseDTO
{
    public string <ResponseId>k__BackingField;    // 0x0x20
    public string <ItemId>k__BackingField;    // 0x0x28
    public int <OutputIndex>k__BackingField;    // 0x0x30
    public int <ContentIndex>k__BackingField;    // 0x0x34
    public string <Delta>k__BackingField;    // 0x0x38
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.SessionDTO
//   (not directly referenced by a detected call)
public class SessionDTO
{
    public string <Id>k__BackingField;    // 0x0x10
    public DateTime <ExpiresAt>k__BackingField;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.SessionEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.EventBaseDTO
//   (not directly referenced by a detected call)
public class SessionEventDTO : EventBaseDTO
{
    public SessionDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.TokenDetailsDTO
//   (not directly referenced by a detected call)
public class TokenDetailsDTO
{
    public int <TextTokens>k__BackingField;    // 0x0x10
    public int <AudioTokens>k__BackingField;    // 0x0x14
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.TokenUsageDTO
//   (not directly referenced by a detected call)
public class TokenUsageDTO
{
    public int <TotalTokens>k__BackingField;    // 0x0x10
    public int <InputTokens>k__BackingField;    // 0x0x14
    public int <OutputTokens>k__BackingField;    // 0x0x18
    public InputTokenDetailsDTO <InputTokenDetails>k__BackingField;    // 0x0x20
    public TokenDetailsDTO <OutputTokenDetails>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.ToolDTO
//   (not directly referenced by a detected call)
public class ToolDTO
{
    public string <Type>k__BackingField;    // 0x0x10
    public string <Name>k__BackingField;    // 0x0x18
    public string <Description>k__BackingField;    // 0x0x20
    public JsonSchema <Parameters>k__BackingField;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateInputVoiceTranscriptionEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateInputVoiceTranscriptionEventDTO : ClientEventBaseDTO
{
    public UpdateInputVoiceTranscriptionDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateSessionAudioConfigEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateSessionAudioConfigEventDTO : ClientEventBaseDTO
{
    public UpdateSessionAudioConfigDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateSessionConfigurationEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateSessionConfigurationEventDTO : ClientEventBaseDTO
{
    public UpdateSessionConfigurationDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AI.OpenAI.Realtime.UpdateToolConfigEventDTO
// base   : RecRoom.AI.OpenAI.Realtime.ClientEventBaseDTO
//   (not directly referenced by a detected call)
public class UpdateToolConfigEventDTO : ClientEventBaseDTO
{
    public UpdateToolConfigDTO <Session>k__BackingField;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AssetIds.AvatarItemDesc
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class AvatarItemDesc : ValueType
{
    public AvatarItemId AvatarItemId;    // 0x0x0
    public CombinationId MaterialCombinationId;    // 0x0x10
    public Guid CustomAvatarItemId;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.AssetIds.AvatarItemId
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class AvatarItemId : ValueType
{
    public Guid guid;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecRoom.AssetIds.CUYGFIMYDTO
//   (not directly referenced by a detected call)
public class CUYGFIMYDTO
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.AssetIds.CombinationId
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class CombinationId : ValueType
{
    public Guid guid;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecRoom.Avatars.AvatarSaveResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class AvatarSaveResult : ValueType
{
    public string NewThumbnailImageName;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecRoom.ChooseInventionPriceDialogResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ChooseInventionPriceDialogResponse : ValueType
{
    public ConfirmDialogResponses responseType;    // 0x0x0
    public int price;    // 0x0x4
}

// --------------------------------------------------------------------------
// RecRoom.ChooseInventionPublishingPermissionsDialogResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ChooseInventionPublishingPermissionsDialogResponse : ValueType
{
    public ConfirmDialogResponses responseType;    // 0x0x0
    public InventionPermission permission;    // 0x0x4
    public UgcAccessibility accessibility;    // 0x0x8
}

// --------------------------------------------------------------------------
// RecRoom.CircuitsV2.Experience.Highlighting.PortViewHighlightRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class PortViewHighlightRequest : ValueType
{
    public PortView _portView;    // 0x0x0
    public JVEKMJHPKAZ _adapter;    // 0x0x8
    public CircuitsV2Config _cv2Config;    // 0x0x10
    public int _requestId;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.CircuitsV2.Experience.Highlighting.WireHighlightRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class WireHighlightRequest : ValueType
{
    public float _startTime;    // 0x0x0
    public PESPEFADJGZ _line;    // 0x0x8
    public FastLineSettings _lineSettings;    // 0x0x10
    public TypeHighlightSettings _typeHighlightSettings;    // 0x0x18
    public WireHighlightState _state;    // 0x0x20
    public GlobalHighlightConfig _globalHighlightConfig;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.Core.Creation.CanEditInventionObjectsResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class CanEditInventionObjectsResult : ValueType
{
    public bool canEdit;    // 0x0x0
    public string errorMsg;    // 0x0x8
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
    Failure_OverAiLimit = 3,
    Failure_OverChipLimit = 4,
    Failure_OverCloudVaraibleLimit = 5,
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
    Failure_ControlPanelRequired = 5,
    Failure_ConnectedToolFrozen = 6,
    Failure_LockedByOther = 7,
    Failure_HeldByOther = 8,
    Failure_SelectingFrozenTool = 9,
    Failure_SettingsChangedByOther = 10,
    Failure_InsufficientResources = 11,
    Failure_Parented = 12,
    Failure_ObjectDoesNotExist = 13,
    Failure_ParentChanged = 14,
    Failure_ToolHeld = 15,
    Failure_NetworkError = 16,
    Failure_ObjectAlreadyExists = 17,
    Failure_ToolNotEnabled = 18,
    Failure_PermissionDenied = 19,
    Failure_InvalidAction = 20,
    Failure_ObjectInUse = 21,
    Failure_MaxSpawnsUsed = 22,
    Failure_InsufficientLightResources = 23,
    Failure_ContainsDisallowedObjects = 24,
    Failure_ShapeContainerCapacity = 25,
    Failure_LockedByEditedGizmo = 26,
    Failure_InsufficientAiResources = 27,
    Failure_SpawnedObject = 28,
    Failure_CantEditWithMakerPen = 29,
    Failure_InsufficientChipResources = 30,
    Failure_PlayerCantSpawnInventions = 31,
    Failure_InsufficientCloudVariableResources = 32,
    Failure_InventionContainsToolsThatExceedCreationLimit = 33,
    Failure_FeatureNotImplementedInObjectModel = 34,
    Failure_EmptyTemplate = 35,
    Failure_CorruptSubgraph = 36,
    Failure_RateLimit = 37,
    Failure_RequestAlreadyInProgress = 38,
    Failure_LockedByRoomContributor = 39,
    Failure_DataTableInTrial = 40,
    Failure_DataTableSaveDenied = 41,
    Failure_DataTableSaveInsufficientPermissions = 42,
    Failure_TooManyExternalCircuitInputs = 43,
    Failure_TooManyExternalCircuitOutputs = 44,
    Failure_TooManyNestedCircuitBoards = 45,
    Failure_ObjectModelInCircuitBoardScope = 46,
    Failure_SpawningShapeWithoutValidShapeContainer = 47,
    Failure_UgcVersionMismatch = 48,
    PartialSuccess_AllObjectsNotRooms2Compatible = 49,
    PartialSuccess_SomeObjectsNotRooms2Compatible = 50,
    Failure_CircuitsVersioning = 51,
    Failure_NodesNotAllowedInTargetGraph = 52,
    Failure_SyncedVariablesNotAllowedInTargetGraph = 53,
    Failure_Disembodied = 54,
    Failure_InventionRIOCopyFailure = 55,
    Failure_TooComplexToClone = 56,
    Failure_StudioContentNotReadyForDevice = 57,
    Failure_StudioContentDownloadFailed = 58,
    Failure_InventionCannotBeTokenSpawned = 59,
    Failure_InventionTokenInvalid = 60,
}

// --------------------------------------------------------------------------
// RecRoom.Core.Creation.SpawnTemplateResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class SpawnTemplateResult : ValueType
{
    public CreationResult result;    // 0x0x0
    public XLYBIIWOHJI errorCulprit;    // 0x0x8
    public SpawnableTemplateData templateData;    // 0x0x10
    public Dictionary<Guid, Guid> oldToNewIdMap;    // 0x0x18
    public List<MOXNPQACASF> spawnedNodes;    // 0x0x20
    public int rootObjectCount;    // 0x0x28
    public List<JTBNCSLVWMH> spawnedObjects;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.Core.JoinRoomResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class JoinRoomResult : ValueType
{
    public bool DidJoinRoom;    // 0x0x0
    public MatchmakingErrorCode ErrorCode;    // 0x0x4
}

// --------------------------------------------------------------------------
// RecRoom.Core.Locomotion.CustomLocomotionSteeringRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class CustomLocomotionSteeringRequest : ValueType
{
    public Vector3 Direction;    // 0x0x0
    public float NormalizedSpeed;    // 0x0xC
    public float MaxSteeringSpeed;    // 0x0x10
    public float AccelerationTime;    // 0x0x14
    public bool SteerInWorldSpace;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.Core.Locomotion.SlideRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class SlideRequest : ValueType
{
    public bool Start;    // 0x0x0
    public bool Stop;    // 0x0x1
    public bool SlideIntoCrouch;    // 0x0x2
}

// --------------------------------------------------------------------------
// RecRoom.Core.Locomotion.SteeringRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class SteeringRequest : ValueType
{
    public Vector3 Direction;    // 0x0x0
    public float NormalizedSpeed;    // 0x0xC
    public bool InstantaneousAcceleration;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.Core.TickResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum TickResult
{
    None = 0,
    Remove = 1,
    Reinsert = 2,
    NextUpdateChanged = 3,
}

// --------------------------------------------------------------------------
// RecRoom.Creation.OutlineRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class OutlineRequest : ValueType
{
    public RequestPriority Priority;    // 0x0x0
    public ObjectLocalId Requester;    // 0x0x4
    public RequestMode Mode;    // 0x0xC
}

// --------------------------------------------------------------------------
// RecRoom.DataLayer.R2MeshPresenterNetworkData_MeshGenerationRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class R2MeshPresenterNetworkData_MeshGenerationRequest : ValueType
{
    public ValueTuple<long, int, int> value;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecRoom.DataLayer.RoomKeyResult
// base   : System.Enum
//   RESPONSE DELETE api/roomkeys/   [Service.Econ]
//   RESPONSE DELETE api/roomkeys/v1/delete/{roomKeyId}   [Service.Econ]
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
    InvalidRelationship = 31,
    PlayerIsUgcGiftingRestricted = 32,
    PlayerIsUgcGiftReceivingRestricted = 33,
    CannotGiftFreeKey = 34,
    RoomKeyNotGiftable = 35,
    GiftingRateLimited = 36,
}

// --------------------------------------------------------------------------
// RecRoom.DataLayer.UgcAccessibility
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum UgcAccessibility
{
    Private = 0,
    Public = 1,
    Unlisted = 2,
}

// --------------------------------------------------------------------------
// RecRoom.Debugging.AutocompleteResult
// base   : UnityEngine.MonoBehaviour
//   (not directly referenced by a detected call)
public class AutocompleteResult : MonoBehaviour
{
    public RawImage backgroundImage;    // 0x0x20
    public TMP_Text text;    // 0x0x28
    public bool UGRXFWZDFUT;    // 0x0x30
}

// --------------------------------------------------------------------------
// RecRoom.FuzzySearch.SearchResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class SearchResult : ValueType
{
    public float Score;    // 0x0x0
    public int Index;    // 0x0x4
    public ReadOnlyMemory<char> Target;    // 0x0x8
    public BitArray highlightedChars;    // 0x0x18
}

// --------------------------------------------------------------------------
// RecRoom.Networking.CreationOps.CreationOpResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class CreationOpResponse : ValueType
{
    public CreationResult CreationResult;    // 0x0x0
    public byte[] Payload;    // 0x0x8
}

// --------------------------------------------------------------------------
// RecRoom.Networking.RoomJoinRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class RoomJoinRequest : ValueType
{
    public string name;    // 0x0x0
    public string platformId;    // 0x0x8
    public SerializableDictionary PlayerProperties;    // 0x0x10
}

// --------------------------------------------------------------------------
// RecRoom.Networking.RoomJoinResponse
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class RoomJoinResponse : ValueType
{
    public bool Success;    // 0x0x0
    public NetworkedRoomData roomData;    // 0x0x8
}

// --------------------------------------------------------------------------
// RecRoom.NoEngine.DataStructures.Result
//   (not directly referenced by a detected call)
public class Result
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.NoEngine.DataStructures.Result`1
//   (not directly referenced by a detected call)
public class Result
{
    // (no instance fields in the metadata dump)
}

// --------------------------------------------------------------------------
// RecRoom.NoEngine.DataStructures.Result`2
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class Result : ValueType
{
    public TErr Err;    // 0x0x0
    public TOk Ok;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecRoom.ObjectModel.BulkInstantiationResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class BulkInstantiationResult : ValueType
{
    public IEnumerable<InstantiationRequest> requests;    // 0x0x0
    public IReadOnlyList<GameObject> instantiations;    // 0x0x8
    public IReadOnlyList<int> requestIndexByInstantiation;    // 0x0x10
    public IReadOnlyList<ValueTuple<ObjectNetworkId, ObjectNetworkId>> srcDstNetworkIds;    // 0x0x18
    public int rootCount;    // 0x0x20
}

// --------------------------------------------------------------------------
// RecRoom.ObjectModel.Interop.InstantiationRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class InstantiationRequest : ValueType
{
    public Guid guid;    // 0x0x0
    public string prefabName;    // 0x0x10
    public Vector3 position;    // 0x0x18
    public Quaternion rotation;    // 0x0x24
    public Vector3 scale;    // 0x0x34
    public int photonViewId;    // 0x0x40
    public CreationInstantiationParameters parameters;    // 0x0x48
}

// --------------------------------------------------------------------------
// RecRoom.ObjectModel.RRSceneLoadResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class RRSceneLoadResult : ValueType
{
    public ObjectLocalId objectId;    // 0x0x0
}

// --------------------------------------------------------------------------
// RecRoom.Preferences.SetResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum SetResult
{
    Unchanged = 0,
    New = 1,
    Changed = 2,
}

// --------------------------------------------------------------------------
// RecRoom.Profiling.ThresholdResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum ThresholdResult
{
    Critical = -2,
    Caution = -1,
    Normal = 0,
}

// --------------------------------------------------------------------------
// RecRoom.RoomEconomy.RoomOffer.SetPriceOverrideResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum SetPriceOverrideResult
{
    Success = 0,
    SuccessClampedToMax = 1,
    SuccessClampedToMin = 2,
    SuccessCleared = 3,
    FailedToFindRoomOffer = 4,
    FailedBecauseNonDynamicPrice = 5,
}

// --------------------------------------------------------------------------
// RecRoom.RoomLoading.LoadRecoveryAutosaveResponse
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum LoadRecoveryAutosaveResponse
{
    Yes = 0,
    No = 1,
    NoAndDelete = 2,
}

// --------------------------------------------------------------------------
// RecRoom.RoomLoading.PendingRequest
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class PendingRequest : ValueType
{
    public DNCITTWJLLJ pendingRequests;    // 0x0x0
    public Guid operationId;    // 0x0x8
}

// --------------------------------------------------------------------------
// RecRoom.RoomLoading.RoomManagerRoomLoadRequest
//   (not directly referenced by a detected call)
public class RoomManagerRoomLoadRequest
{
    public QQYVZOKJWFY RGMEXGNFAUD;    // 0x0x10
    public LTYBEXKFJMA UWLIWFZFOOH;    // 0x0x18
    public QRQGQCAFBFG GLLDMRTNTMN;    // 0x0x20
    public RITKRVFTNCE YFTGGPJFEJX;    // 0x0x28
}

// --------------------------------------------------------------------------
// RecRoom.Tutorials.TutorialFlowResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum TutorialFlowResult
{
    Completed = 0,
    Canceled = 1,
}

// --------------------------------------------------------------------------
// RecRoom.Tutorials.TutorialFlowStepResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum TutorialFlowStepResult
{
    Pending = 0,
    Finished = 1,
    TutorialCancelRequested = 2,
}

// --------------------------------------------------------------------------
// RecRoom.Tutorials.TutorialStepsManagerResult
// base   : System.Enum
//   (not directly referenced by a detected call)
public enum TutorialStepsManagerResult
{
    Incomplete = 0,
    Complete = 1,
    CancelRequested = 2,
}

// --------------------------------------------------------------------------
// RecRoom.Versioning.Framework.ParseResult`1
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class ParseResult : ValueType
{
    public T Value;    // 0x0x0
    public bool IsNew;    // 0x0x0
}

// --------------------------------------------------------------------------
// RoomieActivities.Response
//   (not directly referenced by a detected call)
public class Response
{
    public string prompt;    // 0x0x10
    public string animation;    // 0x0x18
    public bool singleInstance;    // 0x0x20
    public bool canOnlyHappenOnce;    // 0x0x21
    public float weight;    // 0x0x24
    public float probability;    // 0x0x28
}

// --------------------------------------------------------------------------
// RoomieActivities.StateResponse`1
//   (not directly referenced by a detected call)
public class StateResponse
{
    public T state;    // 0x0x0
    public List<Response> responses;    // 0x0x0
    public Vector2 responseDelay;    // 0x0x0
    public float repeatResponseDelay;    // 0x0x0
    public float responseChance;    // 0x0x0
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
// Unity.Entities.Internal.InternalGatherEntitiesResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class InternalGatherEntitiesResult : ValueType
{
    public int StartingOffset;    // 0x0x0
    public int EntityCount;    // 0x0x4
    public Entity* EntityBuffer;    // 0x0x8
    public NativeArray<Entity> EntityArray;    // 0x0x10
}

// --------------------------------------------------------------------------
// Unity.IO.LowLevel.Unsafe.FileInfoResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class FileInfoResult : ValueType
{
    public long FileSize;    // 0x0x0
    public FileState FileState;    // 0x0x8
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

// --------------------------------------------------------------------------
// Unity.Serialization.Json.JsonValidationResult
// base   : System.ValueType
//   (not directly referenced by a detected call)
public class JsonValidationResult : ValueType
{
    public JsonValidationType ValidationType;    // 0x0x0
    public JsonType ExpectedType;    // 0x0x4
    public JsonType ActualType;    // 0x0x8
    public char Char;    // 0x0xC
    public int LineCount;    // 0x0x10
    public int CharCount;    // 0x0x14
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
    public string accessToken;  // form
}

// api/PlayerCheer/v1/SetSelectedCheer  [API POST]
public class PlayerCheerV1SetSelectedCheerRequest
{
    public CheerCategory? CheerCategory;  // form
}

// api/PlayerCheer/v1/create  [API POST]
public class PlayerCheerV1CreateRequest
{
    public object PlayerIdTo;  // form
    public object CheerCategory;  // form
    public object RoomId;  // form
    public object Anonymous;  // form
}

// api/avatar/v1/lockeditems  [Econ GET]
public class AvatarV1LockeditemsRequest
{
    public List<AvatarItemDesc> desc;  // query
}

// api/avatar/v2/gifts/consume/  [Econ ?]
public class AvatarV2GiftsConsumeRequest
{
    public object Id;  // param
    public object UnlockedLevel;  // param
}

// api/avatar/v2/gifts/generate  [Econ POST]
public class AvatarV2GiftsGenerateRequest
{
    public object GiftContext;  // form
    public object IsGameGift;  // form
    public string Message;  // form
}

// api/avatar/v3/gifts/generate  [Econ POST]
public class AvatarV3GiftsGenerateRequest
{
    public object GiftContext;  // form
    public object IsGameGift;  // form
    public string Message;  // form
}

// api/chatreport/createChatReport  [API POST]
public class ChatreportCreateChatReportRequest
{
    public List<int> ChatThreadId;  // form
    public List<int> ChatMessageId;  // form
    public List<int> ReportCategory;  // form
    public string ReportDescription;  // form
}

// api/clubreporting/v1/report  [API POST]
public class ClubreportingV1ReportRequest
{
    public List<int> clubId;  // form
    public List<int> reportCategory;  // form
    public string details;  // form
}

// api/config/v1/backtrace  [API GET]
public class ConfigV1BacktraceRequest
{
    public object platformType;  // query
    public object allocate;  // query
}

// api/consumables/v1/all  [Econ GET]
public class ConsumablesV1AllRequest
{
    public object supportedVersion;  // query
}

// api/consumables/v1/query/bulk  [Econ POST]
public class ConsumablesV1QueryBulkRequest
{
    public List<string> descriptors;  // form
    public List<string> configurationVersion;  // form
}

// api/customAvatarItems/v1/featured  [API GET]
public class CustomAvatarItemsV1FeaturedRequest
{
    public object unityAssetTarget;  // query
    public object unityAssetVersion;  // query
}

// api/customAvatarItems/v1/hot  [API GET]
public class CustomAvatarItemsV1HotRequest
{
    public object unityAssetTarget;  // query
    public object unityAssetVersion;  // query
}

// api/customAvatarItems/v1/me  [API GET]
public class CustomAvatarItemsV1MeRequest
{
    public object skip;  // query
    public object take;  // query
}

// api/customAvatarItems/v1/pricingconfig  [API GET]
public class CustomAvatarItemsV1PricingconfigRequest
{
    public object outfitType;  // query
}

// api/customAvatarItems/v1/search  [API GET]
public class CustomAvatarItemsV1SearchRequest
{
    public string searchQuery;  // query
    public object itemTypes;  // query
    public object outfitTypes;  // query
    public string creatorUsername;  // query
    public object creatorAccountId;  // query
    public object minPrice;  // query
    public object maxPrice;  // query
    public object isOwned;  // query
    public object isFeatured;  // query
    public object includePurchaseInfos;  // query
    public object includeCoachItems;  // query
    public object ordering;  // query
    public object skip;  // query
    public object take;  // query
    public object unityAssetTarget;  // query
    public object unityAssetVersion;  // query
}

// api/customAvatarItems/v1/{customAvatarItemId}/appeal  [API POST]
public class CustomAvatarItemsV1CustomAvatarItemIdAppealRequest
{
    public Guid guid;  // wrapper
}

// api/customAvatarItems/v2/fromCreator/{fromcreatorId}  [API GET]
public class CustomAvatarItemsV2FromCreatorFromcreatorIdRequest
{
    public int take;  // query
}

// api/externalfriendinvite/v1/createplatforminvite  [API POST]
public class ExternalfriendinviteV1CreateplatforminviteRequest
{
    public string platformId;  // form
}

// api/externalfriendinvite/v1/sendtextmessageinvite  [API POST]
public class ExternalfriendinviteV1SendtextmessageinviteRequest
{
    public string phoneNumber;  // form
    public string friendCode;  // form
    public string senderName;  // form
}

// api/gamerewards/v1/request  [Econ POST]
public class GamerewardsV1RequestRequest
{
    public object rewardType;  // form
    public string Message;  // form
    public object giftContext;  // form
}

// api/gamerewards/v1/select  [Econ POST]
public class GamerewardsV1SelectRequest
{
    public object rewardSelectionId;  // form
    public object giftDropId;  // form
}

// api/images/  [API GET]
public class ImagesRequest
{
    public object sort;  // query
    public object filter;  // query
    public object take;  // query
    public object skip;  // query
    public List<long> sort;  // query
}

// api/images/v4/room/{roomId}  [API GET]
public class ImagesV4RoomRoomIdRequest
{
    public object sort;  // query
    public object filter;  // query
    public object take;  // query
    public object skip;  // query
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
    public object sort;  // query
    public List<long> sort;  // query
}

// api/images/v6  [API GET]
public class ImagesV6Request
{
    public string name;  // query
}

// api/incentivizedreferrals/claim  [Econ POST]
public class IncentivizedreferralsClaimRequest
{
    public int ReferralRewardId;  // form
}

// api/incentivizedreferrals/referrals  [Econ GET]
public class IncentivizedreferralsReferralsRequest
{
    public object take;  // query
    public string continuationToken;  // query
}

// api/influencerpartnerprogram/influencer  [Econ GET]
public class InfluencerpartnerprogramInfluencerRequest
{
    public int accountId;  // query
}

// api/influencerpartnerprogram/influencers  [Econ GET]
public class InfluencerpartnerprogramInfluencersRequest
{
    public object take;  // query
    public string continuationToken;  // query
}

// api/influencerpartnerprogram/remove  [Econ POST]
public class InfluencerpartnerprogramRemoveRequest
{
    public int influencerAccountId;  // form
}

// api/influencerpartnerprogram/support  [Econ POST]
public class InfluencerpartnerprogramSupportRequest
{
    public int influencerAccountId;  // form
}

// api/inventions/v1/details  [API GET]
public class InventionsV1DetailsRequest
{
    public long inventionId;  // query
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

// api/inventions/v1/versions  [API GET]
public class InventionsV1VersionsRequest
{
    public long inventionId;  // query
}

// api/inventions/v2/batch  [API ?]
public class InventionsV2BatchRequest
{
    public List<long> id;  // param
}

// api/inventions/v2/search  [API GET]
public class InventionsV2SearchRequest
{
    public string value;  // query
    public object skip;  // query
    public object take;  // query
    public object ugcVersion;  // query
}

// api/itemWishlists/v1/isonwishlist/bulk  [Econ POST]
public class ItemWishlistsV1IsonwishlistBulkRequest
{
    public List<int> accountIds;  // form
    public List<int> purchasableItemId;  // form
}

// api/itemWishlists/v1/wishlist/add  [Econ POST]
public class ItemWishlistsV1WishlistAddRequest
{
    public List<int> purchasableItemId;  // form
}

// api/itemWishlists/v1/wishlist/remove  [Econ POST]
public class ItemWishlistsV1WishlistRemoveRequest
{
    public List<int> purchasableItemId;  // form
}

// api/keepsakes/{keepsakeId}/collect  [API POST]
public class KeepsakesKeepsakeIdCollectRequest
{
    public Guid guid;  // wrapper
}

// api/messages/v2/send  [API POST]
public class MessagesV2SendRequest
{
    public object ToPlayerId;  // form
    public object Type;  // form
    public string Data;  // form
    public long? RoomId;  // form
}

// api/octoberTricks2025/collectghost  [Econ POST]
public class OctoberTricks2025CollectghostRequest
{
    public object isPaidGhost;  // form
}

// api/offlineinvite/v1/send  [API POST]
public class OfflineinviteV1SendRequest
{
    public long PlayerId;  // form
}

// api/oktoberfeast2025/consume  [Econ POST]
public class Oktoberfeast2025ConsumeRequest
{
    public object creatingAccountId;  // form
}

// api/playerevents/v1/bulk  [API POST]
public class PlayereventsV1BulkRequest
{
    public List<long> Ids;  // form
}

// api/playerevents/v1/club/{clubId}  [API GET]
public class PlayereventsV1ClubClubIdRequest
{
    public object take;  // query
    public string continuationToken;  // query
}

// api/playerevents/v1/clubs  [API POST]
public class PlayereventsV1ClubsRequest
{
    public IReadOnlyCollection<long> id;  // form
}

// api/playerevents/v1/search  [API GET]
public class PlayereventsV1SearchRequest
{
    public string query;  // query
    public object sort;  // query
    public object scheduleFilter;  // query
}

// api/playerevents/v1/searchlive  [API GET]
public class PlayereventsV1SearchliveRequest
{
    public string query;  // query
}

// api/playerevents/v1/{eventId}  [API GET]
public class PlayereventsV1EventIdRequest
{
    public object includeDetails;  // query
    public object clubId;  // query
}

// api/playerevents/v2/delete/{eventId}  [API POST]
public class PlayereventsV2DeleteEventIdRequest
{
    public PlayerEvent playerEvent;  // wrapper
}

// api/playerevents/v2/{eventId}/accessibility  [API PUT]
public class PlayereventsV2EventIdAccessibilityRequest
{
    public object accessibility;  // form
}

// api/playerevents/v2/{eventId}/club  [API PUT]
public class PlayereventsV2EventIdClubRequest
{
    public object clubId;  // form
}

// api/playerevents/v2/{eventId}/description  [API PUT]
public class PlayereventsV2EventIdDescriptionRequest
{
    public string description;  // form
}

// api/playerevents/v2/{eventId}/image  [API PUT]
public class PlayereventsV2EventIdImageRequest
{
    public string imageName;  // form
}

// api/playerevents/v2/{eventId}/multiinstance  [API PUT]
public class PlayereventsV2EventIdMultiinstanceRequest
{
    public object isMultiInstance;  // form
    public object supportsMultiInstanceRoomChat;  // form
    public object defaultBroadcastPermissions;  // form
    public object canRequestBroadcastPermissions;  // form
}

// api/playerevents/v2/{eventId}/name  [API PUT]
public class PlayereventsV2EventIdNameRequest
{
    public string name;  // form
}

// api/playerevents/v2/{eventId}/room  [API PUT]
public class PlayereventsV2EventIdRoomRequest
{
    public object roomId;  // form
    public object subRoomId;  // form
}

// api/playerevents/v2/{eventId}/time  [API PUT]
public class PlayereventsV2EventIdTimeRequest
{
    public DateTime startTime;  // form
    public DateTime endTime;  // form
}

// api/playeritems/v1/isavataritemowned/bulk  [Econ POST]
public class PlayeritemsV1IsavataritemownedBulkRequest
{
    public List<int> accountIds;  // form
    public List<int> avatarItemId;  // form
}

// api/playeritems/v1/isequipmentitemowned/bulk  [Econ POST]
public class PlayeritemsV1IsequipmentitemownedBulkRequest
{
    public List<int> accountIds;  // form
    public List<int> equipmentItemId;  // form
}

// api/relationships/  [API POST]
public class RelationshipsRequest
{
    public object PlayerId;  // form
}

// api/relationships/mutualfriends  [API GET]
public class RelationshipsMutualfriendsRequest
{
    public int id;  // query
}

// api/relationships/v1/addfriendwithcode  [API GET]
public class RelationshipsV1AddfriendwithcodeRequest
{
    public string code;  // query
}

// api/relationships/v1/favorite  [API GET]
public class RelationshipsV1FavoriteRequest
{
    public object id;  // query
}

// api/relationships/v1/unfavorite  [API GET]
public class RelationshipsV1UnfavoriteRequest
{
    public int id;  // query
}

// api/relationships/v2/acceptfriendrequest  [API GET]
public class RelationshipsV2AcceptfriendrequestRequest
{
    public int id;  // query
}

// api/relationships/v2/addfriend  [API GET]
public class RelationshipsV2AddfriendRequest
{
    public object id;  // query
}

// api/relationships/v2/removefriend  [API GET]
public class RelationshipsV2RemovefriendRequest
{
    public int id;  // query
}

// api/relationships/v2/sendfriendrequest  [API GET]
public class RelationshipsV2SendfriendrequestRequest
{
    public object id;  // query
}

// api/roomCurrencies/v2/purchase  [Econ POST]
public class RoomCurrenciesV2PurchaseRequest
{
    public List<int> PurchaseOfferId;  // form
    public List<int> RequestedAmount;  // form
    public List<int> RequestedPrice;  // form
    public List<int> GiftRecipientAccountId;  // form
}

// api/roomcurrencies/v1/createCurrency  [Econ POST]
public class RoomcurrenciesV1CreateCurrencyRequest
{
    public object RoomId;  // form
    public string Name;  // form
    public string Description;  // form
    public object Limit;  // form
    public object Shape;  // form
    public object Color;  // form
    public string ImageName;  // form
    public object IsGiftable;  // form
}

// api/roomcurrencies/v1/createPurchaseOffer  [Econ POST]
public class RoomcurrenciesV1CreatePurchaseOfferRequest
{
    public object CurrencyId;  // form
    public string Name;  // form
    public object Amount;  // form
    public object Price;  // form
    public object Order;  // form
}

// api/roomcurrencies/v1/currencies  [Econ GET]
public class RoomcurrenciesV1CurrenciesRequest
{
    public object roomId;  // query
}

// api/roomcurrencies/v1/deletePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1DeletePurchaseOfferRequest
{
    public Guid PurchaseOfferId;  // form
}

// api/roomcurrencies/v1/getAllBalances  [Econ GET]
public class RoomcurrenciesV1GetAllBalancesRequest
{
    public object roomId;  // query
}

// api/roomcurrencies/v1/getBalance  [Econ GET]
public class RoomcurrenciesV1GetBalanceRequest
{
    public object currencyId;  // query
    public object accountId;  // query
}

// api/roomcurrencies/v1/updateCurrency  [Econ POST]
public class RoomcurrenciesV1UpdateCurrencyRequest
{
    public object CurrencyId;  // form
    public string Name;  // form
    public string Description;  // form
    public object Limit;  // form
    public object Shape;  // form
    public object Color;  // form
    public string ImageName;  // form
    public object IsGiftable;  // form
}

// api/roomcurrencies/v1/updatePurchaseOffer  [Econ POST]
public class RoomcurrenciesV1UpdatePurchaseOfferRequest
{
    public object PurchaseOfferId;  // form
    public string Name;  // form
    public object Amount;  // form
    public object Price;  // form
    public object Order;  // form
}

// api/roomkeys/v1/  [Econ PUT]
public class RoomkeysV1Request
{
    public object RoomKeyId;  // form
    public string RoomKeyId;  // form
}

// api/roomkeys/v1/owns  [Econ GET]
public class RoomkeysV1OwnsRequest
{
    public object playerId;  // query
    public object roomKeyId;  // query
}

// api/rooms/v1/report/addScreenshot  [API POST]
public class RoomsV1ReportAddScreenshotRequest
{
    public object RoomReportId;  // form
    public string Screenshot;  // form
}

// api/rooms/v1/verifyRole  [API POST]
public class RoomsV1VerifyRoleRequest
{
    public List<long> roomId;  // form
    public List<long> role;  // form
    public string context;  // form
}

// api/rooms/v3/report  [API POST]
public class RoomsV3ReportRequest
{
    public List<long> RoomId;  // form
    public List<long> RoomKeyId;  // form
    public string Details;  // form
    public List<long> ReportCategory;  // form
    public List<long> RoomOfferId;  // form
    public List<long> RoomOfferVersion;  // form
}

// api/screensharereports/v1/report  [API POST]
public class ScreensharereportsV1ReportRequest
{
    public string ImageName;  // form
    public object ReportedPlayerId;  // form
    public object RoomId;  // form
    public object RoomInstanceId;  // form
    public object RoomInstanceType;  // form
    public string Details;  // form
}

// api/storefronts/v1/PurchaseRoomKeyWithCurrency  [Econ POST]
public class StorefrontsV1PurchaseRoomKeyWithCurrencyRequest
{
    public List<int> RoomKeyId;  // form
    public List<int> RequestedPrice;  // form
    public List<int> RequestedPurchaseCurrencyId;  // form
    public List<int> GiftRecipientAccountId;  // form
}

// api/storefronts/v1/buyProgressionEventXpBoost  [Econ POST]
public class StorefrontsV1BuyProgressionEventXpBoostRequest
{
    public List<int> progressionEventId;  // form
    public List<int> purchasableXpBoostId;  // form
    public List<int> requestedPrice;  // form
    public List<int> expectedXp;  // form
}

// api/storefronts/v1/buyPurchaseReminder  [Econ POST]
public class StorefrontsV1BuyPurchaseReminderRequest
{
    public List<int> purchaseReminderId;  // form
    public List<int> requestedPrice;  // form
    public List<int> giftRecipientAccountId;  // form
    public string giftRecipientMessage;  // form
}

// api/storefronts/v1/buyRoomKey  [Econ GET]
public class StorefrontsV1BuyRoomKeyRequest
{
    public List<int> RoomKeyId;  // query
    public List<int> RequestedPrice;  // query
    public List<int> GiftRecipientAccountId;  // query
}

// api/storefronts/v2/trialInvention  [Econ POST]
public class StorefrontsV2TrialInventionRequest
{
    public List<int> inventionId;  // form
}

// api/testcasemanagement/v1/testcase/  [API POST]
public class TestcasemanagementV1TestcaseRequest
{
    public TestCaseStatus testCaseStatus;  // wrapper
}

// api/timedRewardTracks  [Econ GET]
public class TimedRewardTracksRequest
{
    public string name;  // query
}

// api/versioncheck/v4  [API GET]
public class VersioncheckV4Request
{
    public string v;  // query
    public object p;  // query
}

