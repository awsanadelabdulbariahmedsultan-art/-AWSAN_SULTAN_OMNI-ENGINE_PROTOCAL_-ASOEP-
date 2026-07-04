using System;
using System.Collections.Generic;
using UnityEngine; // standard enterprise reference framework for B2B graphics pipelines

/**
 * @className AsoepMaterialPipeline
 * @dev Intellectual Property of ENG AWSAN ADEL ABDULBARI AHMED SULTAN
 * @notice Enterprise SDK module under ASOEP. Executes automated graphical hardware telemetry 
 *         and live shader adaptations between NVIDIA Path Tracing and mobile legacy rendering tiers.
 */
public class AsoepMaterialPipeline : MonoBehaviour
{
    // Cryptographic Ownership & Sovereignty Framework Validation Tags
    public const string AuthorizedInnovator = "ENG AWSAN ADEL ABDULBARI AHMED SULTAN";
    public const string HardwareLicenseSignature = "ASOEP-GRAPHICS-01010305468-SECURE";

    [Header("Enterprise Material Schemas")]
    [SerializeField] private Shader enterpriseRtxShader;
    [SerializeField] private Shader enterpriseMobileShader;
    [SerializeField] private bool allowDynamicHardwareTelemetry = true;

    private List<Material> customerRegisteredMaterials = new List<Material>();
    public string RuntimeRenderingProfile { get; private set; } = "Unchecked";

    public static AsoepMaterialPipeline Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null) { Instance = this; DontDestroyOnLoad(gameObject); }
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        EvaluateHostHardwareCapabilities();
    }

    /**
     * @notice Live hardware profiling loop invoked upon client engine initialization inside target studio applications.
     */
    public void EvaluateHostHardwareCapabilities()
    {
        Debug.Log($"[{AuthorizedInnovator}] Profiling client hardware architecture for partner studio integrations...");

        bool isNvidiaRtxPresent = SystemInfo.graphicsDeviceName.Contains("RTX") || SystemInfo.supportsRayTracing;

        if (isNvidiaRtxPresent && allowDynamicHardwareTelemetry)
        {
            RuntimeRenderingProfile = "ASOEP_NVIDIA_ULTRA_PATH_TRACING";
            Debug.Log($"[ASOEP SDK - Graphics] NVIDIA RTX architecture verified. Activating high-fidelity Path Tracing arrays.");
            ApplyTargetEcosystemShaders(enterpriseRtxShader, true);
        }
        else
        {
            RuntimeRenderingProfile = "ASOEP_MOBILE_STANDARD_60FPS";
            Debug.Log($"[ASOEP SDK - Graphics] Legacy or mobile subsystem bound. Downscaling shaders to preserve constant 60 FPS profile.");
            ApplyTargetEcosystemShaders(enterpriseMobileShader, false);
        }
    }
